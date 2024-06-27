// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BNpcBase", columnHash: 0x86278126 )]
public partial class BNpcBase : ExcelRow
{
    
    public float Scale { get; private set; }
    public LazyRow< ArrayEventHandler > ArrayEventHandler { get; private set; }
    public LazyRow< Behavior > Behavior { get; private set; }
    public LazyRow< ModelChara > ModelChara { get; private set; }
    public LazyRow< BNpcCustomize > BNpcCustomize { get; private set; }
    public LazyRow< NpcEquip > NpcEquip { get; private set; }
    public ushort Special { get; private set; }
    public LazyRow< Battalion > Battalion { get; private set; }
    public LazyRow< LinkRace > LinkRace { get; private set; }
    public byte Rank { get; private set; }
    public byte SEPack { get; private set; }
    public byte Unknown0 { get; private set; }
    public LazyRow< BNpcParts > BNpcParts { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public bool IsOmnidirectional { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool IsTargetLine { get; private set; }
    public bool IsDisplayLevel { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool Unknown_70 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Scale = parser.ReadOffset< float >( 0 );
        ArrayEventHandler = new LazyRow< ArrayEventHandler >( gameData, parser.ReadOffset< int >( 4 ), language );
        Behavior = new LazyRow< Behavior >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        ModelChara = new LazyRow< ModelChara >( gameData, parser.ReadOffset< ushort >( 10 ), language );
        BNpcCustomize = new LazyRow< BNpcCustomize >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        NpcEquip = new LazyRow< NpcEquip >( gameData, parser.ReadOffset< ushort >( 14 ), language );
        Special = parser.ReadOffset< ushort >( 16 );
        Battalion = new LazyRow< Battalion >( gameData, parser.ReadOffset< byte >( 18 ), language );
        LinkRace = new LazyRow< LinkRace >( gameData, parser.ReadOffset< byte >( 19 ), language );
        Rank = parser.ReadOffset< byte >( 20 );
        SEPack = parser.ReadOffset< byte >( 21 );
        Unknown0 = parser.ReadOffset< byte >( 22 );
        BNpcParts = new LazyRow< BNpcParts >( gameData, parser.ReadOffset< byte >( 23 ), language );
        Unknown1 = parser.ReadOffset< byte >( 24 );
        Unknown2 = parser.ReadOffset< byte >( 25 );
        Unknown3 = parser.ReadOffset< byte >( 26 );
        Unknown4 = parser.ReadOffset< byte >( 27 );
        IsOmnidirectional = parser.ReadOffset< bool >( 28 );
        Unknown6 = parser.ReadOffset< bool >( 28, 2 );
        IsTargetLine = parser.ReadOffset< bool >( 28, 4 );
        IsDisplayLevel = parser.ReadOffset< bool >( 28, 8 );
        Unknown7 = parser.ReadOffset< bool >( 28, 16 );
        Unknown_70 = parser.ReadOffset< bool >( 28, 32 );
        

    }
}