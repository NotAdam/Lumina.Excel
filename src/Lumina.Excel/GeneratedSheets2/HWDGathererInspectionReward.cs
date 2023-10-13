// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HWDGathererInspectionReward", columnHash: 0x2020acf6 )]
public partial class HWDGathererInspectionReward : ExcelRow
{
    
    public ushort Scrips { get; private set; }
    public ushort Points { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Scrips = parser.ReadOffset< ushort >( 0 );
        Points = parser.ReadOffset< ushort >( 2 );
        

    }
}