// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "InclusionShop", columnHash: 0x415e17e0 )]
public partial class InclusionShop : ExcelRow
{
    
    public SeString Unknown0 { get; private set; }
    public LazyRow< InclusionShopCategory >[] Category { get; private set; }
    public uint Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< SeString >( 0 );
        Category = new LazyRow< InclusionShopCategory >[30];
        for (int i = 0; i < 30; i++)
        	Category[i] = new LazyRow< InclusionShopCategory >( gameData, parser.ReadOffset< ushort >( (ushort) ( 4 + i * 2 ) ), language );
        Unknown1 = parser.ReadOffset< uint >( 64 );
        Unknown2 = parser.ReadOffset< byte >( 68 );
        

    }
}