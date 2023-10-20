// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AnimaWeapon5Param", columnHash: 0x5eb59ccb )]
public partial class AnimaWeapon5Param : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< BaseParam > BaseParam { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        BaseParam = new LazyRow< BaseParam >( gameData, parser.ReadOffset< byte >( 4 ), language );
        

    }
}