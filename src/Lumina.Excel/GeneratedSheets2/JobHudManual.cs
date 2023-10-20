// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "JobHudManual", columnHash: 0x21d1dec2 )]
public partial class JobHudManual : ExcelRow
{
    
    public LazyRow< Action > Action { get; private set; }
    public uint Unknown0 { get; private set; }
    public LazyRow< Guide > Guide { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Action = new LazyRow< Action >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown0 = parser.ReadOffset< uint >( 4 );
        Guide = new LazyRow< Guide >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        Unknown1 = parser.ReadOffset< byte >( 10 );
        Unknown2 = parser.ReadOffset< byte >( 11 );
        Unknown3 = parser.ReadOffset< byte >( 12 );
        

    }
}