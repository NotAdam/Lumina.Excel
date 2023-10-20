// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "NotebookDivision", columnHash: 0xb4638be9 )]
public partial class NotebookDivision : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< Quest > QuestUnlock { get; private set; }
    public LazyRow< NotebookDivisionCategory > NotebookDivisionCategory { get; private set; }
    public byte CraftOpeningLevel { get; private set; }
    public byte GatheringOpeningLevel { get; private set; }
    public byte Unknown0 { get; private set; }
    public bool CRPCraft { get; private set; }
    public bool BSMCraft { get; private set; }
    public bool ARMCraft { get; private set; }
    public bool GSMCraft { get; private set; }
    public bool LTWCraft { get; private set; }
    public bool WVRCraft { get; private set; }
    public bool ALCCraft { get; private set; }
    public bool CULCraft { get; private set; }
    public bool Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        QuestUnlock = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 4 ), language );
        NotebookDivisionCategory = new LazyRow< NotebookDivisionCategory >( gameData, parser.ReadOffset< byte >( 8 ), language );
        CraftOpeningLevel = parser.ReadOffset< byte >( 9 );
        GatheringOpeningLevel = parser.ReadOffset< byte >( 10 );
        Unknown0 = parser.ReadOffset< byte >( 11 );
        CRPCraft = parser.ReadOffset< bool >( 12 );
        BSMCraft = parser.ReadOffset< bool >( 13 );
        ARMCraft = parser.ReadOffset< bool >( 14 );
        GSMCraft = parser.ReadOffset< bool >( 15 );
        LTWCraft = parser.ReadOffset< bool >( 16 );
        WVRCraft = parser.ReadOffset< bool >( 17 );
        ALCCraft = parser.ReadOffset< bool >( 18 );
        CULCraft = parser.ReadOffset< bool >( 19 );
        Unknown1 = parser.ReadOffset< bool >( 20 );
        

    }
}