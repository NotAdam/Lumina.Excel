// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PetAction", columnHash: 0x5e492849 )]
public partial class PetAction : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public int Icon { get; private set; }
    public LazyRow< Action > Action { get; private set; }
    public LazyRow< Pet > Pet { get; private set; }
    public bool MasterOrder { get; private set; }
    public bool DisableOrder { get; private set; }
    public bool Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Icon = parser.ReadOffset< int >( 8 );
        Action = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        Pet = new LazyRow< Pet >( gameData, parser.ReadOffset< byte >( 14 ), language );
        MasterOrder = parser.ReadOffset< bool >( 15 );
        DisableOrder = parser.ReadOffset< bool >( 15, 2 );
        Unknown0 = parser.ReadOffset< bool >( 15, 4 );
        

    }
}