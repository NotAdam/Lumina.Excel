// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIVillageAppearanceSG", columnHash: 0x98ef9486 )]
public partial class MJIVillageAppearanceSG : ExcelRow
{
    public struct VillageAppearanceDataStruct
    {
    	public uint UnknownParam { get; internal set; }
    	public LazyRow< ExportedSG > SGB { get; internal set; }
    }
    
    public VillageAppearanceDataStruct[] VillageAppearanceData { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        VillageAppearanceData = new VillageAppearanceDataStruct[4];
        for (int i = 0; i < 4; i++)
        {
        	VillageAppearanceData[i].UnknownParam = parser.ReadOffset< uint >( (ushort) (i * 8 + 0));
        	VillageAppearanceData[i].SGB = new LazyRow< ExportedSG >( gameData, parser.ReadOffset< ushort >( (ushort) (i * 8 + 4) ), language );
        }
        

    }
}