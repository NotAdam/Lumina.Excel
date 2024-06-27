// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "NpcYell", columnHash: 0x9cb5d770 )]
public partial class NpcYell : ExcelRow
{
    
    public SeString Text { get; private set; }
    public float BalloonTime { get; private set; }
    public uint Unknown0 { get; private set; }
    public byte OutputType { get; private set; }
    public byte Unknown_70 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool IsBalloonSlow { get; private set; }
    public bool BattleTalkTime { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        BalloonTime = parser.ReadOffset< float >( 4 );
        Unknown0 = parser.ReadOffset< uint >( 8 );
        OutputType = parser.ReadOffset< byte >( 12 );
        Unknown_70 = parser.ReadOffset< byte >( 13 );
        Unknown1 = parser.ReadOffset< byte >( 14 );
        Unknown2 = parser.ReadOffset< byte >( 15 );
        Unknown3 = parser.ReadOffset< bool >( 16 );
        Unknown4 = parser.ReadOffset< bool >( 16, 2 );
        Unknown5 = parser.ReadOffset< bool >( 16, 4 );
        IsBalloonSlow = parser.ReadOffset< bool >( 16, 8 );
        BattleTalkTime = parser.ReadOffset< bool >( 16, 16 );
        

    }
}