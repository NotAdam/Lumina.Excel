// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "IKDFishParam", columnHash: 0x1b55da98 )]
public partial class IKDFishParam : ExcelRow
{
    
    public LazyRow< FishParameter > Fish { get; private set; }
    public LazyRow< IKDContentBonus > IKDContentBonus { get; private set; }
    public byte Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Fish = new LazyRow< FishParameter >( gameData, parser.ReadOffset< uint >( 0 ), language );
        IKDContentBonus = new LazyRow< IKDContentBonus >( gameData, parser.ReadOffset< byte >( 4 ), language );
        Unknown2 = parser.ReadOffset< byte >( 5 );
        

    }
}