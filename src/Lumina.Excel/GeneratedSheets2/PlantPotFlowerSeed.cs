// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PlantPotFlowerSeed", columnHash: 0x84d0ceef )]
public partial class PlantPotFlowerSeed : ExcelRow
{
    
    public uint[] SeedIcon { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SeedIcon = new uint[9];
        for (int i = 0; i < 9; i++)
        	SeedIcon[i] = parser.ReadOffset< uint >( 0 + i * 4 );
        

    }
}