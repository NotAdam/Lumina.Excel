// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CompleteJournal", columnHash: 0x8741e36a )]
public partial class CompleteJournal : ExcelRow
{
    
    public SeString Name { get; private set; }
    public uint Unknown0 { get; private set; }
    public uint Unknown4 { get; private set; }
    public int Icon { get; private set; }
    public LazyRow< Cutscene >[] Cutscene { get; private set; }
    public ushort RequiredLevel { get; private set; }
    public byte Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Unknown0 = parser.ReadOffset< uint >( 4 );
        Unknown4 = parser.ReadOffset< uint >( 8 );
        Icon = parser.ReadOffset< int >( 12 );
        Cutscene = new LazyRow< Cutscene >[24];
        for (int i = 0; i < 24; i++)
        	Cutscene[i] = new LazyRow< Cutscene >( gameData, parser.ReadOffset< int >( (ushort) ( 16 + i * 4 ) ), language );
        RequiredLevel = parser.ReadOffset< ushort >( 112 );
        Unknown2 = parser.ReadOffset< byte >( 114 );
        

    }
}