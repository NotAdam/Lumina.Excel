// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FishingNoteInfo", columnHash: 0xbe43ccf1 )]
public partial class FishingNoteInfo : ExcelRow
{
    
    public ILazyRow Item { get; private set; }
    public byte Size { get; private set; }
    public LazyRow< AquariumWater > AquariumWater { get; private set; }
    public byte WeatherRestriction { get; private set; }
    public byte TimeRestriction { get; private set; }
    public byte SpecialConditions { get; private set; }
    public byte IsCollectable { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< int >( 0 ), language, "EventItem", "Item" );
        Size = parser.ReadOffset< byte >( 4 );
        AquariumWater = new LazyRow< AquariumWater >( gameData, parser.ReadOffset< byte >( 5 ), language );
        WeatherRestriction = parser.ReadOffset< byte >( 6 );
        TimeRestriction = parser.ReadOffset< byte >( 7 );
        SpecialConditions = parser.ReadOffset< byte >( 8 );
        IsCollectable = parser.ReadOffset< byte >( 9 );
        

    }
}