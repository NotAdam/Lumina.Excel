// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GrandCompanyRank", columnHash: 0x939f7424 )]
public partial class GrandCompanyRank : ExcelRow
{
    
    public uint MaxSeals { get; private set; }
    public uint RequiredSeals { get; private set; }
    public int IconMaelstrom { get; private set; }
    public int IconSerpents { get; private set; }
    public int IconFlames { get; private set; }
    public LazyRow< Quest > QuestMaelstrom { get; private set; }
    public LazyRow< Quest > QuestSerpents { get; private set; }
    public LazyRow< Quest > QuestFlames { get; private set; }
    public byte Tier { get; private set; }
    public byte Order { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        MaxSeals = parser.ReadOffset< uint >( 0 );
        RequiredSeals = parser.ReadOffset< uint >( 4 );
        IconMaelstrom = parser.ReadOffset< int >( 8 );
        IconSerpents = parser.ReadOffset< int >( 12 );
        IconFlames = parser.ReadOffset< int >( 16 );
        QuestMaelstrom = new LazyRow< Quest >( gameData, parser.ReadOffset< int >( 20 ), language );
        QuestSerpents = new LazyRow< Quest >( gameData, parser.ReadOffset< int >( 24 ), language );
        QuestFlames = new LazyRow< Quest >( gameData, parser.ReadOffset< int >( 28 ), language );
        Tier = parser.ReadOffset< byte >( 32 );
        Order = parser.ReadOffset< byte >( 33 );
        Unknown0 = parser.ReadOffset< byte >( 34 );
        

    }
}