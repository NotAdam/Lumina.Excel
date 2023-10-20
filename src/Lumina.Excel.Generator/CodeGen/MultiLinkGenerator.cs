using System.Text;
using Lumina.Data.Structs.Excel;

namespace Lumina.Generator.CodeGen;

public class MultiLinkGenerator : BaseGenerator
{
    public MultiLinkGenerator( Field field, List< ExcelColumnDefinition > columns, int startColumnIndex, int startOffset ) : base( field, columns, startColumnIndex, startOffset ) { }

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
        var sheetList = string.Join( ", ", Field.Targets.Select( x => $"\"{x}\"" ) );
        sb.AppendLine( $"{Field.Name} = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< {ClrTypeOfCurrentColumn()} >( {CurrentOffset()} ), language, {sheetList} );" );
    }
}