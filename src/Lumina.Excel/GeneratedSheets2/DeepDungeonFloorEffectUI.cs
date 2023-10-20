// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DeepDungeonFloorEffectUI", columnHash: 0x11a44a12 )]
public partial class DeepDungeonFloorEffectUI : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public uint Icon { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Icon = parser.ReadOffset< uint >( 8 );
        

    }
}