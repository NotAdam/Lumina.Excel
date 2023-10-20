// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GilShopItem", columnHash: 0x2f7317fe )]
public partial class GilShopItem : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public int Unknown0 { get; private set; }
    public LazyRow< Quest >[] QuestRequired { get; private set; }
    public LazyRow< Achievement > AchievementRequired { get; private set; }
    public ushort StateRequired { get; private set; }
    public ushort Patch { get; private set; }
    public byte Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 0 ), language );
        Unknown0 = parser.ReadOffset< int >( 4 );
        QuestRequired = new LazyRow< Quest >[2];
        for (int i = 0; i < 2; i++)
        	QuestRequired[i] = new LazyRow< Quest >( gameData, parser.ReadOffset< int >( (ushort) ( 8 + i * 4 ) ), language );
        AchievementRequired = new LazyRow< Achievement >( gameData, parser.ReadOffset< int >( 16 ), language );
        StateRequired = parser.ReadOffset< ushort >( 20 );
        Patch = parser.ReadOffset< ushort >( 22 );
        Unknown1 = parser.ReadOffset< byte >( 24 );
        Unknown2 = parser.ReadOffset< bool >( 25 );
        

    }
}