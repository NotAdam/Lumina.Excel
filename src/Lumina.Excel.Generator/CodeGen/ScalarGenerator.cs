using System.Text;
using Lumina.Data.Structs.Excel;

namespace Lumina.Generator.CodeGen;

public class ScalarGenerator : BaseGenerator
{
    public ScalarGenerator( Field field, List< ExcelColumnDefinition > columns, int startColumnIndex, int startOffset ) : base( field, columns, startColumnIndex, startOffset ) { }

    public override void WriteFields( StringBuilder sb )
    {
        sb.AppendLine( $"public {ClrTypeOfCurrentColumn()} {Field.Name} {{ get; private set; }}" );
    }

    public override void WriteReaders( StringBuilder sb )
    {
        sb.AppendLine( $"{Field.Name} = parser.ReadOffset< {ClrTypeOfCurrentColumn()} >( {CurrentOffset()}{GetParserBitArg()} );" );
    }
}