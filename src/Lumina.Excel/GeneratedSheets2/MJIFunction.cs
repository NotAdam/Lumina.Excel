// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIFunction", columnHash: 0xb815fb69 )]
public partial class MJIFunction : ExcelRow
{
    
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public sbyte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown1 = parser.ReadOffset< byte >( 0 );
        Unknown2 = parser.ReadOffset< byte >( 1 );
        Unknown3 = parser.ReadOffset< byte >( 2 );
        Unknown4 = parser.ReadOffset< byte >( 3 );
        Unknown0 = parser.ReadOffset< sbyte >( 4 );
        

    }
}