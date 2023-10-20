// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Relic", columnHash: 0x8080ef57 )]
public partial class Relic : ExcelRow
{
    
    public LazyRow< Item > ItemAtma { get; private set; }
    public LazyRow< Item > ItemAnimus { get; private set; }
    public int Icon { get; private set; }
    public LazyRow< Materia > Materia0 { get; private set; }
    public LazyRow< Materia > Materia1 { get; private set; }
    public LazyRow< Materia > Materia2 { get; private set; }
    public LazyRow< Materia > Materia3 { get; private set; }
    public LazyRow< RelicNote > NoteMain0 { get; private set; }
    public LazyRow< RelicNote > NoteSub0 { get; private set; }
    public LazyRow< RelicNote > NoteSelection10 { get; private set; }
    public LazyRow< RelicNote > NoteMain1 { get; private set; }
    public LazyRow< RelicNote > NoteSub1 { get; private set; }
    public LazyRow< RelicNote > NoteSelection1 { get; private set; }
    public LazyRow< RelicNote > NoteMain2 { get; private set; }
    public LazyRow< RelicNote > NoteSub2 { get; private set; }
    public LazyRow< RelicNote > NoteSelection3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ItemAtma = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        ItemAnimus = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Icon = parser.ReadOffset< int >( 8 );
        Materia0 = new LazyRow< Materia >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        Materia1 = new LazyRow< Materia >( gameData, parser.ReadOffset< ushort >( 14 ), language );
        Materia2 = new LazyRow< Materia >( gameData, parser.ReadOffset< ushort >( 16 ), language );
        Materia3 = new LazyRow< Materia >( gameData, parser.ReadOffset< ushort >( 18 ), language );
        NoteMain0 = new LazyRow< RelicNote >( gameData, parser.ReadOffset< byte >( 20 ), language );
        NoteSub0 = new LazyRow< RelicNote >( gameData, parser.ReadOffset< byte >( 21 ), language );
        NoteSelection10 = new LazyRow< RelicNote >( gameData, parser.ReadOffset< byte >( 22 ), language );
        NoteMain1 = new LazyRow< RelicNote >( gameData, parser.ReadOffset< byte >( 23 ), language );
        NoteSub1 = new LazyRow< RelicNote >( gameData, parser.ReadOffset< byte >( 24 ), language );
        NoteSelection1 = new LazyRow< RelicNote >( gameData, parser.ReadOffset< byte >( 25 ), language );
        NoteMain2 = new LazyRow< RelicNote >( gameData, parser.ReadOffset< byte >( 26 ), language );
        NoteSub2 = new LazyRow< RelicNote >( gameData, parser.ReadOffset< byte >( 27 ), language );
        NoteSelection3 = new LazyRow< RelicNote >( gameData, parser.ReadOffset< byte >( 28 ), language );
        

    }
}