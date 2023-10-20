// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Buddy", columnHash: 0xd2892cc5 )]
public partial class Buddy : ExcelRow
{
    
    public SeString SoundEffect4 { get; private set; }
    public SeString SoundEffect3 { get; private set; }
    public SeString SoundEffect2 { get; private set; }
    public SeString SoundEffect1 { get; private set; }
    public LazyRow< Quest > QuestRequirement2 { get; private set; }
    public LazyRow< Quest > QuestRequirement1 { get; private set; }
    public int BaseEquip { get; private set; }
    public byte Base { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SoundEffect4 = parser.ReadOffset< SeString >( 0 );
        SoundEffect3 = parser.ReadOffset< SeString >( 4 );
        SoundEffect2 = parser.ReadOffset< SeString >( 8 );
        SoundEffect1 = parser.ReadOffset< SeString >( 12 );
        QuestRequirement2 = new LazyRow< Quest >( gameData, parser.ReadOffset< int >( 16 ), language );
        QuestRequirement1 = new LazyRow< Quest >( gameData, parser.ReadOffset< int >( 20 ), language );
        BaseEquip = parser.ReadOffset< int >( 24 );
        Base = parser.ReadOffset< byte >( 28 );
        

    }
}