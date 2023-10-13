// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RelicNote", columnHash: 0xb557320e )]
public partial class RelicNote : ExcelRow
{
    
    public LazyRow< EventItem > EventItem { get; private set; }
    public LazyRow< MonsterNoteTarget >[] MonsterNoteTargetCommon { get; private set; }
    public LazyRow< MonsterNoteTarget >[] MonsterNoteTargetNM { get; private set; }
    public ushort Unknown24 { get; private set; }
    public LazyRow< Fate >[] Fate { get; private set; }
    public LazyRow< PlaceName >[] PlaceNameFate { get; private set; }
    public LazyRow< Leve >[] Leve { get; private set; }
    public byte[] MonsterCount { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        EventItem = new LazyRow< EventItem >( gameData, parser.ReadOffset< uint >( 0 ), language );
        MonsterNoteTargetCommon = new LazyRow< MonsterNoteTarget >[10];
        for (int i = 0; i < 10; i++)
        	MonsterNoteTargetCommon[i] = new LazyRow< MonsterNoteTarget >( gameData, parser.ReadOffset< ushort >( (ushort) ( 4 + i * 2 ) ), language );
        MonsterNoteTargetNM = new LazyRow< MonsterNoteTarget >[3];
        for (int i = 0; i < 3; i++)
        	MonsterNoteTargetNM[i] = new LazyRow< MonsterNoteTarget >( gameData, parser.ReadOffset< ushort >( (ushort) ( 24 + i * 2 ) ), language );
        Unknown24 = parser.ReadOffset< ushort >( 30 );
        Fate = new LazyRow< Fate >[3];
        for (int i = 0; i < 3; i++)
        	Fate[i] = new LazyRow< Fate >( gameData, parser.ReadOffset< ushort >( (ushort) ( 32 + i * 2 ) ), language );
        PlaceNameFate = new LazyRow< PlaceName >[3];
        for (int i = 0; i < 3; i++)
        	PlaceNameFate[i] = new LazyRow< PlaceName >( gameData, parser.ReadOffset< ushort >( (ushort) ( 38 + i * 2 ) ), language );
        Leve = new LazyRow< Leve >[3];
        for (int i = 0; i < 3; i++)
        	Leve[i] = new LazyRow< Leve >( gameData, parser.ReadOffset< ushort >( (ushort) ( 44 + i * 2 ) ), language );
        MonsterCount = new byte[10];
        for (int i = 0; i < 10; i++)
        	MonsterCount[i] = parser.ReadOffset< byte >( 50 + i * 1 );
        

    }
}