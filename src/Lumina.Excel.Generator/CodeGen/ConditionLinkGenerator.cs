using System.Text;
using Lumina.Data.Structs.Excel;

namespace Lumina.Generator.CodeGen;

public class ConditionLinkGenerator : BaseGenerator
{
    public ConditionLinkGenerator( Field field, List< ExcelColumnDefinition > columns, int startColumnIndex, int startOffset ) : base( field, columns, startColumnIndex, startOffset ) { }

    public override void WriteFields( StringBuilder sb )
    {
        sb.AppendLine( $"public ILazyRow {Field.Name} {{ get; private set; }}" );
    }

    public override void WriteReaders( StringBuilder sb )
    {
        if( Columns[ StartColumnIndex ].IsBoolType )
        {
            sb.AppendLine( $"#warning generator warning: the definition for this field ({Field.Name}) has an invalid type for a LazyRow - is a bool when should be numeric!" );
            return;
        }

        sb.AppendLine( $"var {Field.Name}RowId = parser.ReadOffset< {ClrTypeOfCurrentColumn()} >( {CurrentOffset()} );" );
    }

    public override void WriteInitializers( StringBuilder sb )
    {
        sb.AppendLine($"{Field.Name} = {Field.Condition.Switch} switch");
        sb.AppendLine("{");
        foreach (var condition in Field.Condition.Cases)
        {
            if (condition.Value.Count == 1)
                sb.AppendLine($"\t{condition.Key} => new LazyRow< {condition.Value[ 0 ]} >( gameData, {Field.Name}RowId, language ),");
            else
            {
                var sheetList = string.Join( ", ", condition.Value.Select( x => $"\"{x}\"" ) );
                sb.AppendLine( $"\t{condition.Key} => EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) {Field.Name}RowId, language, {sheetList} )," );
            }
        }
        sb.AppendLine( $"\t_ => new EmptyLazyRow( (uint) {Field.Name}RowId )," );
        sb.AppendLine("};");
    }
}