// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AquariumFish", columnHash: 0x9b5e32ba )]
public partial class AquariumFish : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public ushort Unknown3 { get; private set; }
    public LazyRow< AquariumWater > AquariumWater { get; private set; }
    public byte Size { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown3 = parser.ReadOffset< ushort >( 4 );
        AquariumWater = new LazyRow< AquariumWater >( gameData, parser.ReadOffset< byte >( 6 ), language );
        Size = parser.ReadOffset< byte >( 7 );
        

    }
}