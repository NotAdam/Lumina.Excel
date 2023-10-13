// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HWDSharedGroup", columnHash: 0x5a516458 )]
public partial class HWDSharedGroup : ExcelRow
{
    
    public uint LGBSharedGroup { get; private set; }
    public LazyRow< HWDSharedGroupControlParam > Param { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        LGBSharedGroup = parser.ReadOffset< uint >( 0 );
        Param = new LazyRow< HWDSharedGroupControlParam >( gameData, parser.ReadOffset< byte >( 4 ), language );
        

    }
}