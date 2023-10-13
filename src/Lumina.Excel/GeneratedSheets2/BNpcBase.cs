// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BNpcBase", columnHash: 0xe136dda3 )]
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
    public byte Unknown12 { get; private set; }
    public LazyRow< BNpcParts > BNpcParts { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte Unknown19 { get; private set; }
    public byte Unknown20 { get; private set; }
    public byte Unknown21 { get; private set; }
    public bool Unknown10 { get; private set; }
    public bool Unknown15 { get; private set; }
    public bool IsTargetLine { get; private set; }
    public bool IsDisplayLevel { get; private set; }
    public bool Unknown18 { get; private set; }
    
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
        Unknown12 = parser.ReadOffset< byte >( 22 );
        BNpcParts = new LazyRow< BNpcParts >( gameData, parser.ReadOffset< byte >( 23 ), language );
        Unknown14 = parser.ReadOffset< byte >( 24 );
        Unknown19 = parser.ReadOffset< byte >( 25 );
        Unknown20 = parser.ReadOffset< byte >( 26 );
        Unknown21 = parser.ReadOffset< byte >( 27 );
        Unknown10 = parser.ReadOffset< bool >( 28 );
        Unknown15 = parser.ReadOffset< bool >( 28, 2 );
        IsTargetLine = parser.ReadOffset< bool >( 28, 4 );
        IsDisplayLevel = parser.ReadOffset< bool >( 28, 8 );
        Unknown18 = parser.ReadOffset< bool >( 28, 16 );
        

    }
}