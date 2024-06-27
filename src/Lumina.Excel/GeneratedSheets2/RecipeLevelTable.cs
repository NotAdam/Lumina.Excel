// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RecipeLevelTable", columnHash: 0x463c491f )]
public partial class RecipeLevelTable : ExcelRow
{
    
    public uint Quality { get; private set; }
    public ushort SuggestedCraftsmanship { get; private set; }
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
        Difficulty = parser.ReadOffset< ushort >( 6 );
        Durability = parser.ReadOffset< ushort >( 8 );
        ConditionsFlag = parser.ReadOffset< ushort >( 10 );
        ClassJobLevel = parser.ReadOffset< byte >( 12 );
        Stars = parser.ReadOffset< byte >( 13 );
        ProgressDivider = parser.ReadOffset< byte >( 14 );
        QualityDivider = parser.ReadOffset< byte >( 15 );
        ProgressModifier = parser.ReadOffset< byte >( 16 );
        QualityModifier = parser.ReadOffset< byte >( 17 );
        

    }
}