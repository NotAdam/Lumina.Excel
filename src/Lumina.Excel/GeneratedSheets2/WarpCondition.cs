// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "WarpCondition", columnHash: 0xc096f9d0 )]
public partial class WarpCondition : ExcelRow
{
    
    public LazyRow< Quest > RequiredQuest1 { get; private set; }
    public LazyRow< Quest > RequiredQuest2 { get; private set; }
    public LazyRow< Quest > RequiredQuest3 { get; private set; }
    public LazyRow< Quest > RequiredQuest4 { get; private set; }
    public ushort Gil { get; private set; }
    public ushort QuestReward { get; private set; }
    public ushort ClassLevel { get; private set; }
    public byte CompleteParam { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        RequiredQuest1 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 0 ), language );
        RequiredQuest2 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 4 ), language );
        RequiredQuest3 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 8 ), language );
        RequiredQuest4 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 12 ), language );
        Gil = parser.ReadOffset< ushort >( 16 );
        QuestReward = parser.ReadOffset< ushort >( 18 );
        ClassLevel = parser.ReadOffset< ushort >( 20 );
        CompleteParam = parser.ReadOffset< byte >( 22 );
        

    }
}