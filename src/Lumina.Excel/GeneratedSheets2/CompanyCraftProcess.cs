// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CompanyCraftProcess", columnHash: 0x3135b48e )]
public partial class CompanyCraftProcess : ExcelRow
{
    
    public LazyRow< CompanyCraftSupplyItem >[] SupplyItem { get; private set; }
    public ushort[] SetQuantity { get; private set; }
    public ushort[] SetsRequired { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SupplyItem = new LazyRow< CompanyCraftSupplyItem >[12];
        for (int i = 0; i < 12; i++)
        	SupplyItem[i] = new LazyRow< CompanyCraftSupplyItem >( gameData, parser.ReadOffset< ushort >( (ushort) ( 0 + i * 2 ) ), language );
        SetQuantity = new ushort[12];
        for (int i = 0; i < 12; i++)
        	SetQuantity[i] = parser.ReadOffset< ushort >( 24 + i * 2 );
        SetsRequired = new ushort[12];
        for (int i = 0; i < 12; i++)
        	SetsRequired[i] = parser.ReadOffset< ushort >( 48 + i * 2 );
        

    }
}