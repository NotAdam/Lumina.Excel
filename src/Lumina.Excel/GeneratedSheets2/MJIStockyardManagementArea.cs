// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIStockyardManagementArea", columnHash: 0x43bdd5b1 )]
public partial class MJIStockyardManagementArea : ExcelRow
{
    
    public LazyRow< MJIText > Area { get; private set; }
    public LazyRow< MJIItemPouch > RareMaterial { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Area = new LazyRow< MJIText >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        RareMaterial = new LazyRow< MJIItemPouch >( gameData, parser.ReadOffset< byte >( 2 ), language );
        Unknown1 = parser.ReadOffset< byte >( 3 );
        

    }
}