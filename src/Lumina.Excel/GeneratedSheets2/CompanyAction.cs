// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CompanyAction", columnHash: 0xde0dd9cf )]
public partial class CompanyAction : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public uint Cost { get; private set; }
    public int Icon { get; private set; }
    public LazyRow< FCRank > FCRank { get; private set; }
    public byte Order { get; private set; }
    public bool Purchasable { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Cost = parser.ReadOffset< uint >( 8 );
        Icon = parser.ReadOffset< int >( 12 );
        FCRank = new LazyRow< FCRank >( gameData, parser.ReadOffset< byte >( 16 ), language );
        Order = parser.ReadOffset< byte >( 17 );
        Purchasable = parser.ReadOffset< bool >( 18 );
        

    }
}