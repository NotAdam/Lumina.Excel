// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BeastRankBonus", columnHash: 0x4d6cbdc3 )]
public partial class BeastRankBonus : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public ushort Neutral { get; private set; }
    public ushort Recognized { get; private set; }
    public ushort Friendly { get; private set; }
    public ushort Trusted { get; private set; }
    public ushort Respected { get; private set; }
    public ushort Honored { get; private set; }
    public ushort Sworn { get; private set; }
    public ushort AlliedBloodsworn { get; private set; }
    public byte[] ItemQuantity { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Neutral = parser.ReadOffset< ushort >( 4 );
        Recognized = parser.ReadOffset< ushort >( 6 );
        Friendly = parser.ReadOffset< ushort >( 8 );
        Trusted = parser.ReadOffset< ushort >( 10 );
        Respected = parser.ReadOffset< ushort >( 12 );
        Honored = parser.ReadOffset< ushort >( 14 );
        Sworn = parser.ReadOffset< ushort >( 16 );
        AlliedBloodsworn = parser.ReadOffset< ushort >( 18 );
        ItemQuantity = new byte[8];
        for (int i = 0; i < 8; i++)
        	ItemQuantity[i] = parser.ReadOffset< byte >( 20 + i * 1 );
        

    }
}