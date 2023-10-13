using System.Text;
using Lumina.Data.Structs.Excel;

namespace Lumina.Generator.CodeGen;

public class ArrayGenerator : BaseGenerator
{
    private List< BaseGenerator > _generators;
    
    public ArrayGenerator( Field field, List< ExcelColumnDefinition > columns, int startColumnIndex, int startOffset ) : base( field, columns, startColumnIndex, startOffset )
    {
        _generators = new List< BaseGenerator >();
    }

    public override void WriteFields( StringBuilder sb )
    {
        if( Field.Fields?.Count > 1 )
        {
            // HAS STRUCTS
            sb.Append( $"public {Field.Name}Struct[] {Field.Name} {{ get; private set; }}\n" );
        }
        else if( Util.IsSimpleLinkArray(Field) )
        {
            var nonStructField = Field.Fields[ 0 ];
            
            if( nonStructField.Targets.Count == 1 )
            {
                sb.Append( $"public LazyRow< {nonStructField.Targets[0]} >[] {Field.Name} {{ get; private set; }}\n" );
            }
            else
            {
                sb.Append( $"public ILazyRow[] {Field.Name} {{ get; private set; }}\n" );
            }
        }
        else if( Util.IsComplexLinkArray( Field ) )
        {
            sb.Append( $"public ILazyRow[] {Field.Name} {{ get; private set; }}\n" );
        }
        else
        {
            // no fields so our array is just scalars
            sb.Append( $"public {ClrTypeOfCurrentColumn()}[] {Field.Name} {{ get; private set; }}\n" );
        }
        
        ResetOffsets();
    }

    public override void WriteReaders( StringBuilder sb )
    {
        if( Field.Fields?.Count > 1 )
        {   // begin inner struct handling
            sb.Append( $"{Field.Name} = new {Field.Name}Struct[{Field.Count}];\n" );
            sb.Append( $"for (int i = 0; i < {Field.Count}; i++)\n" );
            sb.Append( "{\n" );
            var structField = $"{Field.Name}[i]";
            
            var columnStart = StartColumnIndex;
            var structFieldSize = Util.GetFieldSize( Field, Columns, ref columnStart );
            
            foreach( var subField in Field.Fields )
            {
                if( subField.Type == FieldType.Link )
                {
                    if( subField.Targets.Count == 1 )
                    {
                        sb.Append( $"\t{structField}.{subField.Name} = new LazyRow< {subField.Targets[ 0 ]} >( gameData, parser.ReadOffset< {ClrTypeOfCurrentColumn()} >( (ushort) (i * {structFieldSize} + {CurrentOffset()}) ), language );\n" );
                    }
                    else if (subField.Targets.Count > 1)
                    {
                        var sheetList = string.Join( ", ", subField.Targets.Select( x => $"\"{x}\"" ) );
                        sb.Append( $"\t{structField}.{subField.Name} = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< {ClrTypeOfCurrentColumn()} >( i * {structFieldSize} + {CurrentOffset()} ), language, {sheetList} );\n" );
                    }
                    else if (subField.Condition != null)
                    {
                        // TODO what the fuck
                        Console.WriteLine("e");
                    }
                    SkipColumn();
                }
                else if (Util.IsScalar(subField)) // scalar
                {
                    sb.Append( $"\t{structField}.{subField.Name} = parser.ReadOffset< {ClrTypeOfCurrentColumn()} >( (ushort) (i * {structFieldSize} + {CurrentOffset()}){GetParserBitArg()});\n" );
                    SkipColumn();
                }
                else if (Util.IsSimpleArray(subField))
                {
                    var iterator = $"{subField.Name}Indexer";
                    sb.Append( $"\t{structField}.{subField.Name} = new {ClrTypeOfCurrentColumn()}[{subField.Count}];\n" );
                    sb.Append( $"\tfor (int {iterator} = 0; {iterator} < {subField.Count}; {iterator}++)\n" );
                    sb.Append( $"\t\t{structField}.{subField.Name}[{iterator}] = parser.ReadOffset< {ClrTypeOfCurrentColumn()} >( (ushort) ( i * {structFieldSize} + {CurrentOffset()} + {iterator} * {SizeOfCurrentColumn()} ) );\n" );
                    SkipColumn(subField.Count.Value);
                }
                else if (Util.IsSimpleLinkArray(subField))
                {
                    var iterator = $"{subField.Name}Indexer";

                    if( subField.Fields[ 0 ].Targets.Count == 1 )
                    {
                        sb.Append( $"\t{structField}.{subField.Name} = new LazyRow< {subField.Fields[ 0 ].Targets[ 0 ]} >[{subField.Count}];\n" );
                        sb.Append( $"\tfor (int {iterator} = 0; {iterator} < {subField.Count}; {iterator}++)\n" );
                        sb.Append( $"\t\t{structField}.{subField.Name}[{iterator}] = new LazyRow< {subField.Fields[ 0 ].Targets[ 0 ]} >( gameData, parser.ReadOffset< {ClrTypeOfCurrentColumn()} >( i * {structFieldSize} +  {CurrentOffset()} + {iterator} * {SizeOfCurrentColumn()} ), language );\n" );
                    }
                    else
                    {
                        var sheetList = string.Join( ", ", subField.Fields[ 0 ].Targets.Select( x => $"\"{x}\"" ) );
                        sb.Append( $"\t{structField}.{subField.Name} = new ILazyRow[{subField.Count}];\n" );
                        sb.Append( $"\tfor (int {iterator} = 0; {iterator} < {subField.Count}; {iterator}++)\n" );
                        sb.Append( $"\t\t{structField}.{subField.Name}[{iterator}] = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< {ClrTypeOfCurrentColumn()} >( i * {structFieldSize} +  {CurrentOffset()} + {iterator} * {SizeOfCurrentColumn()} ), language, {sheetList} );\n" );
                    }
                    SkipColumn(subField.Count.Value);
                }
                else if( Util.IsComplexLinkArray( subField ) )
                {
                    Console.WriteLine("f");
                }
            }
            sb.Append( "}\n" );
        } // end inner struct handling
        else if( Util.IsSimpleLinkArray(Field) )
        {
            var nonStructField = Field.Fields[ 0 ];
            
            if( nonStructField.Targets.Count == 1 )
            {
                // Name = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 0 ), language );
                sb.AppendLine( $"{Field.Name} = new LazyRow< {nonStructField.Targets[ 0 ]} >[{Field.Count}];" );
                sb.AppendLine( $"for (int i = 0; i < {Field.Count}; i++)" );
                sb.AppendLine( $"\t{Field.Name}[i] = new LazyRow< {nonStructField.Targets[ 0 ]} >( gameData, parser.ReadOffset< {ClrTypeOfCurrentColumn()} >( (ushort) ( {CurrentOffset()} + i * {SizeOfCurrentColumn()} ) ), language );" );
            }
            else
            {
                var sheetList = string.Join( ", ", nonStructField.Targets.Select( x => $"\"{x}\"" ) );
                sb.AppendLine( $"{Field.Name} = new ILazyRow[{Field.Count}];" );
                sb.AppendLine( $"for (int i = 0; i < {Field.Count}; i++)" );
                sb.AppendLine( $"\t{Field.Name}[i] = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< {ClrTypeOfCurrentColumn()} >( {CurrentOffset()} + i * {SizeOfCurrentColumn()} ), language, {sheetList} );" );
            }
        }
        else if( Util.IsComplexLinkArray( Field ) )
        {
            sb.AppendLine( $"var {Field.Name} = new ILazyRow[ {Field.Count} ];" );
            sb.AppendLine( $"UIntSpan {Field.Name}RowId = stackalloc uint[ {Field.Count} ];" );
            sb.AppendLine( $"for( int i = 0; i < {Field.Count}; i++ )" );
            sb.AppendLine( "{" );
            sb.AppendLine( $"\t{Field.Name}RowId[ i ] = (uint) parser.ReadOffset< int >( {CurrentOffset()} + ( i * 4 ) );" );
            sb.AppendLine( "}" );
        }
        else
        {
            // no fields so our array is just scalars, all the same type
            sb.AppendLine( $"{Field.Name} = new {ClrTypeOfCurrentColumn()}[{Field.Count}];" );
            sb.AppendLine( $"for (int i = 0; i < {Field.Count}; i++)" );
            sb.AppendLine( $"\t{Field.Name}[i] = parser.ReadOffset< {ClrTypeOfCurrentColumn()} >( {CurrentOffset()} + i * {SizeOfCurrentColumn()} );" );
        }
        
        ResetOffsets();
    }

    public override void WriteStructs( StringBuilder sb )
    {
        if( Field.Fields?.Count > 1 )
        {
            sb.Append( $"public struct {Field.Name}Struct\n{{\n" );
            foreach( var subField in Field.Fields )
            {
                if( subField.Type == FieldType.Link ) // link
                {
                    if( subField.Targets?.Count == 1 )
                    {
                        sb.Append( $"\tpublic LazyRow< {subField.Targets[0]} > {subField.Name} {{ get; internal set; }}\n" );
                    }
                    else if ( subField.Targets?.Count > 1 || subField.Condition != null)
                    {
                        sb.Append( $"\tpublic ILazyRow {subField.Name} {{ get; internal set; }}\n" );
                    }
                    else
                    {
                        throw new Exception( $"Unable to handle link for field {subField.Name}" );
                    }
                    SkipColumn();
                }
                else if (Util.IsScalar(subField))
                {
                    sb.Append( $"\tpublic {ClrTypeOfCurrentColumn()} {subField.Name} {{ get; internal set; }}\n" );
                    SkipColumn();
                }
                else if (Util.IsSimpleLinkArray(subField))
                {
                    if( subField.Fields[0].Targets.Count == 1 )
                    {
                        sb.Append( $"\tpublic LazyRow< {subField.Fields[0].Targets[0]} >[] {subField.Name} {{ get; internal set; }}\n" );
                    }
                    else
                    {
                        sb.Append( $"\tpublic ILazyRow[] {subField.Name} {{ get; internal set; }}\n" );
                    }
                    SkipColumn( Util.GetFieldCount( subField ) );
                }
                else if( Util.IsComplexLinkArray( subField ) )
                {
                    sb.Append( $"\tpublic ILazyRow[] {subField.Name} {{ get; internal set; }}\n" );
                    SkipColumn( Util.GetFieldCount( subField ) );
                }
                else if (Util.IsSimpleArray(subField))
                {
                    // we don't have complex nested arrays... for now
                    sb.Append( $"\tpublic {ClrTypeOfCurrentColumn()}[] {subField.Name} {{ get; internal set; }}\n" );
                    SkipColumn( Util.GetFieldCount( subField ) );
                }
            }
            sb.Append( "}\n" );
        }
        
        ResetOffsets();
    }

    public override void WriteInitializers( StringBuilder sb )
    {
        if( Field.Fields?.Count > 1 )
        {   // begin inner struct handling
            // Nothing to do, handled in WriteReaders
        }   // end inner struct handling
        else if( Util.IsSimpleLinkArray(Field) )
        {
            // Nothing to do
        }
        else if( Util.IsComplexLinkArray( Field ) )
        {
            var subField = Field.Fields[ 0 ];
            sb.AppendLine( $"for( int i = 0; i < {Field.Count}; i++ )" );
            sb.AppendLine( "{" );
            sb.AppendLine($"\t{Field.Name}[ i ] = {subField.Condition.Switch} switch");
            sb.AppendLine("\t{");
            foreach (var condition in subField.Condition.Cases)
            {
                if (condition.Value.Count == 1)
                    sb.AppendLine($"\t\t{condition.Key} => new LazyRow< {condition.Value[ 0 ]} >( gameData, {Field.Name}RowId[i], language ),");
                else
                {
                    var sheetList = string.Join( ", ", condition.Value.Select( x => $"\"{x}\"" ) );
                    sb.AppendLine( $"\t\t{condition.Key} => EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, {Field.Name}RowId[i], language, {sheetList} )," );
                }
            }
            sb.AppendLine( $"\t\t_ => new EmptyLazyRow( (uint) {Field.Name}RowId[i] )," );
            sb.AppendLine( "\t};" );
            sb.AppendLine( "}" );
        }
        else
        {
            // Nothing to do
        }
        
        ResetOffsets();
    }
}