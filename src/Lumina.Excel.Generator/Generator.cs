using System.Text;
using Lumina.Data.Structs.Excel;
using Lumina.Generator.CodeGen;
using SharpYaml.Serialization;

namespace Lumina.Generator;

public class Generator
{
    private readonly GameData _gameData;
    private readonly string _sheetTemplate;
    private readonly Serializer _serializer;

    public Generator(string path, string tmplPath = null)
    {
        _gameData = new GameData( path );
        _sheetTemplate = File.ReadAllText( tmplPath ?? "class.tmpl" );
        _serializer = new Serializer( new SerializerSettings
        {
            EmitAlias = false,
            EmitDefaultValues = false,
            NamingConvention = new CamelCaseNamingConvention(),
            IgnoreNulls = true,
        } );
    }

    private BaseGenerator CreateGeneratorForField(Field field, List<ExcelColumnDefinition> columns, int columnIndex, int startOffset)
    {
        return field switch
        {
            { Type: FieldType.Scalar or FieldType.Color or FieldType.Icon or FieldType.ModelId } => new ScalarGenerator( field, columns, columnIndex, startOffset ),
            { Type: FieldType.Link, Targets.Count: 1 } => new SingleLinkGenerator( field, columns, columnIndex, startOffset ),
            { Type: FieldType.Link, Targets.Count: > 1 } => new MultiLinkGenerator( field, columns, columnIndex, startOffset ),
            { Type: FieldType.Link, Targets: null, Condition: not null } => new ConditionLinkGenerator( field, columns, columnIndex, startOffset ),
            { Type: FieldType.Array } => new ArrayGenerator( field, columns, columnIndex, startOffset ),
            _ => throw new ArgumentException("Unknown field type"),
        };
    }
    
    public string ProcessDefinition( string name )
    {
        var path = $"./Schemas_test/{name}.yml";
        var def = File.ReadAllText( path );
        var tmpl = _sheetTemplate;

        var sheet = _gameData.Excel.GetSheetRaw( name );
        if( sheet == null )
        {
            Console.WriteLine( $" - sheet {name} no longer exists!" );
            return null;
        }
            
        tmpl = tmpl.Replace( "%%SHEET_NAME%%", name );
        var hash = sheet.HeaderFile.GetColumnsHash();
        tmpl = tmpl.Replace( "%%COL_HASH%%", $"0x{hash:x8}" );
        
        var cols = sheet.Columns.ToList();
        cols.Sort((c1, c2) => Util.CalculateBitOffset(c1).CompareTo(Util.CalculateBitOffset(c2)));

        var schema = _serializer.Deserialize< Sheet >( def );
        if( schema == null )
        {
            Console.WriteLine( $" - schema {name} failed to deserialize!" );
            return null;
        }
        
        var generators = new List< BaseGenerator >();

        var colIndex = 0;

        for( int schemaIndex = 0; schemaIndex < schema.Fields.Count; schemaIndex++ )
        {
            var field = schema.Fields[ schemaIndex ];
            var offset = cols[ colIndex ].Offset;
            var fieldGenerator = CreateGeneratorForField( field, cols, colIndex, offset );
            generators.Add( fieldGenerator );
            colIndex += fieldGenerator.ConsumedColumnCount();
        }
        
        // for( int i = 0; i < cols.Count; i++ )
        // {
        //     var column = cols[ i ];
        //     var schemaDef = schema.Fields[ schemaIndex ];
        //
        //     var excelType = column.Type;
        //     var clrType = Util.ExcelTypeToManaged( excelType );
        //     // var fieldName = Util.Clean( schemaDef.Name );
        //     var fieldName = schemaDef.Name;
        //
        //     if( schemaDef.Type == FieldType.Scalar )
        //     {
        //         generators.Add(new ScalarGenerator( clrType, fieldName, column.Offset ));
        //     } 
        //     else if( schemaDef.Type == FieldType.Link && schemaDef.Targets!.Count == 1 )
        //     {
        //         generators.Add( new SingleLinkGenerator( clrType, fieldName, column.Offset, schemaDef.Targets[ 0 ] ) );
        //     }
        //     else if( schemaDef.Type == FieldType.Link && schemaDef.Targets!.Count > 1 )
        //     {
        //         // return new MultiLinkGenerator( clrType, fieldName, column.Offset, schemaDef.Targets );
        //         // TODO: grab all targets. we only grab the first target for now
        //         generators.Add( new SingleLinkGenerator( clrType, fieldName, column.Offset, schemaDef.Targets[ 0 ] ) );
        //     }
        //     else if( schemaDef.Type == FieldType.Array )
        //     {
        //         generators.Add( new ArrayGenerator( schemaDef, column.Offset, cols, i, schemaIndex ) );
        //     }
        // }
            
        var fieldsSb = new StringBuilder();
        var readsSb = new StringBuilder();
        var structsSb = new StringBuilder();
        var initializersSb = new StringBuilder();
            
        // run the generators
        foreach( var generator in generators )
        {
            generator.WriteFields( fieldsSb );
            generator.WriteReaders( readsSb );
            generator.WriteStructs( structsSb );
            generator.WriteInitializers( initializersSb );
        }

        // fix indent the big brain way
        Func< StringBuilder, int, string > fixIndent = ( sb, level ) =>
        {
            var indent = "";
            for( int i = 0; i < level * 4; i++ )
            {
                indent += " ";
            }

            return indent + sb.ToString().Replace( "\n", $"\n{indent}");
        };

        tmpl = tmpl.Replace( "%%STRUCT_DEFS%%", fixIndent( structsSb, 1 ) );
        tmpl = tmpl.Replace( "%%DATA_MEMBERS%%", fixIndent( fieldsSb, 1 ) );
        tmpl = tmpl.Replace( "%%DATA_READERS%%", fixIndent( readsSb, 2 ) );
        tmpl = tmpl.Replace( "%%DATA_INITIALIZERS%%", fixIndent( initializersSb, 2 ).TrimEnd() );

        return tmpl;
    }
}