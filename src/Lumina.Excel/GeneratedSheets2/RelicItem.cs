// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RelicItem", columnHash: 0xc8fc45d9 )]
public partial class RelicItem : ExcelRow
{
    
    public LazyRow< Item > GladiatorItem { get; private set; }
    public LazyRow< Item > PugilistItem { get; private set; }
    public LazyRow< Item > MarauderItem { get; private set; }
    public LazyRow< Item > LancerItem { get; private set; }
    public LazyRow< Item > ArcherItem { get; private set; }
    public LazyRow< Item > ConjurerItem { get; private set; }
    public LazyRow< Item > ThaumaturgeItem { get; private set; }
    public LazyRow< Item > ArcanistSMNItem { get; private set; }
    public LazyRow< Item > ArcanistSCHItem { get; private set; }
    public LazyRow< Item > ShieldItem { get; private set; }
    public LazyRow< Item > RogueItem { get; private set; }
    public uint Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public uint Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public uint Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        GladiatorItem = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        PugilistItem = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 4 ), language );
        MarauderItem = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 8 ), language );
        LancerItem = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 12 ), language );
        ArcherItem = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 16 ), language );
        ConjurerItem = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 20 ), language );
        ThaumaturgeItem = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 24 ), language );
        ArcanistSMNItem = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 28 ), language );
        ArcanistSCHItem = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 32 ), language );
        ShieldItem = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 36 ), language );
        RogueItem = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 40 ), language );
        Unknown0 = parser.ReadOffset< uint >( 44 );
        Unknown1 = parser.ReadOffset< uint >( 48 );
        Unknown2 = parser.ReadOffset< uint >( 52 );
        Unknown3 = parser.ReadOffset< uint >( 56 );
        Unknown4 = parser.ReadOffset< uint >( 60 );
        Unknown5 = parser.ReadOffset< byte >( 64 );
        

    }
}