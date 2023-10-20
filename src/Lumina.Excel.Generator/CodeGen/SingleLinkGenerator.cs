using System.Text;
using Lumina.Data.Structs.Excel;

namespace Lumina.Generator.CodeGen;

public class SingleLinkGenerator : BaseGenerator
{
    public SingleLinkGenerator( Field field, List< ExcelColumnDefinition > columns, int startColumnIndex, int startOffset ) : base( field, columns, startColumnIndex, startOffset ) { }

    public override void WriteFields( StringBuilder sb )
    {
        sb.AppendLine( $"public LazyRow< {Field.Targets[ 0 ]} > {Field.Name} {{ get; private set; }}" );
    }

    public override void WriteReaders( StringBuilder sb )
    {
        if( Columns[ StartColumnIndex ].IsBoolType )
        {
            sb.AppendLine( $"#warning generator warning: the definition for this field ({Field.Name}) has an invalid type for a LazyRow - is a bool when should be numeric!" );
            return;
        }
        sb.AppendLine( $"{Field.Name} = new LazyRow< {Field.Targets[ 0 ]} >( gameData, parser.ReadOffset< {ClrTypeOfCurrentColumn()} >( {CurrentOffset()} ), language );" );
    }
}