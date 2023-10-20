// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RecipeLevelTable", columnHash: 0x6d3c3f32 )]
public partial class RecipeLevelTable : ExcelRow
{
    
    public uint Quality { get; private set; }
    public ushort SuggestedCraftsmanship { get; private set; }
    public ushort SuggestedControl { get; private set; }
    public ushort Difficulty { get; private set; }
    public ushort Durability { get; private set; }
    public ushort ConditionsFlag { get; private set; }
    public byte ClassJobLevel { get; private set; }
    public byte Stars { get; private set; }
    public byte ProgressDivider { get; private set; }
    public byte QualityDivider { get; private set; }
    public byte ProgressModifier { get; private set; }
    public byte QualityModifier { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Quality = parser.ReadOffset< uint >( 0 );
        SuggestedCraftsmanship = parser.ReadOffset< ushort >( 4 );
        SuggestedControl = parser.ReadOffset< ushort >( 6 );
        Difficulty = parser.ReadOffset< ushort >( 8 );
        Durability = parser.ReadOffset< ushort >( 10 );
        ConditionsFlag = parser.ReadOffset< ushort >( 12 );
        ClassJobLevel = parser.ReadOffset< byte >( 14 );
        Stars = parser.ReadOffset< byte >( 15 );
        ProgressDivider = parser.ReadOffset< byte >( 16 );
        QualityDivider = parser.ReadOffset< byte >( 17 );
        ProgressModifier = parser.ReadOffset< byte >( 18 );
        QualityModifier = parser.ReadOffset< byte >( 19 );
        

    }
}