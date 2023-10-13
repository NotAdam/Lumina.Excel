// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ChocoboTaxi", columnHash: 0x6a82513f )]
public partial class ChocoboTaxi : ExcelRow
{
    
    public LazyRow< ChocoboTaxiStand > Location { get; private set; }
    public ushort TimeRequired { get; private set; }
    public ushort Unknown3 { get; private set; }
    public byte Fare { get; private set; }
    public bool Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Location = new LazyRow< ChocoboTaxiStand >( gameData, parser.ReadOffset< uint >( 0 ), language );
        TimeRequired = parser.ReadOffset< ushort >( 4 );
        Unknown3 = parser.ReadOffset< ushort >( 6 );
        Fare = parser.ReadOffset< byte >( 8 );
        Unknown4 = parser.ReadOffset< bool >( 9 );
        

    }
}