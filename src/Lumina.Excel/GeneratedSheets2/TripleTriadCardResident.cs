// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TripleTriadCardResident", columnHash: 0x996e0a5e )]
public partial class TripleTriadCardResident : ExcelRow
{
    
    public ILazyRow Acquisition { get; private set; }
    public ILazyRow Location { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    public ushort Unknown0 { get; private set; }
    public ushort SaleValue { get; private set; }
    public ushort Order { get; private set; }
    public byte Top { get; private set; }
    public byte Bottom { get; private set; }
    public byte Left { get; private set; }
    public byte Right { get; private set; }
    public LazyRow< TripleTriadCardRarity > TripleTriadCardRarity { get; private set; }
    public LazyRow< TripleTriadCardType > TripleTriadCardType { get; private set; }
    public byte SortKey { get; private set; }
    public byte UIPriority { get; private set; }
    public byte AcquisitionType { get; private set; }
    public bool Unknown11 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        var AcquisitionRowId = parser.ReadOffset< uint >( 0 );
        var LocationRowId = parser.ReadOffset< uint >( 4 );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 8 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 12 );
        SaleValue = parser.ReadOffset< ushort >( 14 );
        Order = parser.ReadOffset< ushort >( 16 );
        Top = parser.ReadOffset< byte >( 18 );
        Bottom = parser.ReadOffset< byte >( 19 );
        Left = parser.ReadOffset< byte >( 20 );
        Right = parser.ReadOffset< byte >( 21 );
        TripleTriadCardRarity = new LazyRow< TripleTriadCardRarity >( gameData, parser.ReadOffset< byte >( 22 ), language );
        TripleTriadCardType = new LazyRow< TripleTriadCardType >( gameData, parser.ReadOffset< byte >( 23 ), language );
        SortKey = parser.ReadOffset< byte >( 24 );
        UIPriority = parser.ReadOffset< byte >( 25 );
        AcquisitionType = parser.ReadOffset< byte >( 26 );
        Unknown11 = parser.ReadOffset< bool >( 27 );
        
        Acquisition = AcquisitionType switch
        {
        	2 => new LazyRow< ContentFinderCondition >( gameData, AcquisitionRowId, language ),
        	3 => new LazyRow< ContentFinderCondition >( gameData, AcquisitionRowId, language ),
        	4 => new LazyRow< Fate >( gameData, AcquisitionRowId, language ),
        	5 => new LazyRow< Fate >( gameData, AcquisitionRowId, language ),
        	6 => new LazyRow< ENpcResident >( gameData, AcquisitionRowId, language ),
        	8 => new LazyRow< Item >( gameData, AcquisitionRowId, language ),
        	9 => new LazyRow< Item >( gameData, AcquisitionRowId, language ),
        	10 => new LazyRow< ENpcResident >( gameData, AcquisitionRowId, language ),
        	11 => new LazyRow< Achievement >( gameData, AcquisitionRowId, language ),
        	12 => new LazyRow< ContentFinderCondition >( gameData, AcquisitionRowId, language ),
        	_ => new EmptyLazyRow( (uint) AcquisitionRowId ),
        };
        Location = AcquisitionType switch
        {
        	4 => new LazyRow< TerritoryType >( gameData, LocationRowId, language ),
        	5 => new LazyRow< TerritoryType >( gameData, LocationRowId, language ),
        	6 => new LazyRow< Level >( gameData, LocationRowId, language ),
        	10 => new LazyRow< Level >( gameData, LocationRowId, language ),
        	_ => new EmptyLazyRow( (uint) LocationRowId ),
        };
    }
}