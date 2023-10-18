// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ScenarioTree", columnHash: 0xca183be8 )]
public partial class ScenarioTree : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< Addon > Addon { get; private set; }
    public LazyRow< QuestChapter > QuestChapter { get; private set; }
    public uint Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public LazyRow< ScenarioType > Type { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Addon = new LazyRow< Addon >( gameData, parser.ReadOffset< uint >( 4 ), language );
        QuestChapter = new LazyRow< QuestChapter >( gameData, parser.ReadOffset< uint >( 8 ), language );
        Unknown0 = parser.ReadOffset< uint >( 12 );
        Unknown1 = parser.ReadOffset< int >( 16 );
        Unknown2 = parser.ReadOffset< ushort >( 20 );
        Type = new LazyRow< ScenarioType >( gameData, parser.ReadOffset< byte >( 22 ), language );
        

    }
}