// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GilShopItem", columnHash: 0xb375f1d2 )]
public partial class GilShopItem : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public LazyRow< Quest >[] QuestRequired { get; private set; }
    public LazyRow< Achievement > AchievementRequired { get; private set; }
    public ushort StateRequired { get; private set; }
    public ushort Patch { get; private set; }
    public byte Unknown_70_1 { get; private set; }
    public byte Unknown_70_2 { get; private set; }
    public byte Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 0 ), language );
        QuestRequired = new LazyRow< Quest >[2];
        for (int i = 0; i < 2; i++)
        	QuestRequired[i] = new LazyRow< Quest >( gameData, parser.ReadOffset< int >( (ushort) ( 4 + i * 4 ) ), language );
        AchievementRequired = new LazyRow< Achievement >( gameData, parser.ReadOffset< int >( 12 ), language );
        StateRequired = parser.ReadOffset< ushort >( 16 );
        Patch = parser.ReadOffset< ushort >( 18 );
        Unknown_70_1 = parser.ReadOffset< byte >( 20 );
        Unknown_70_2 = parser.ReadOffset< byte >( 21 );
        Unknown1 = parser.ReadOffset< byte >( 22 );
        Unknown2 = parser.ReadOffset< bool >( 23 );
        

    }
}