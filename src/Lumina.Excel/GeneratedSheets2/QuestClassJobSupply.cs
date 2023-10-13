// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestClassJobSupply", columnHash: 0xdd620f3e )]
public partial class QuestClassJobSupply : ExcelRow
{
    
    public LazyRow< ENpcResident > ENpcResident { get; private set; }
    public LazyRow< Item > Item { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte AmountRequired { get; private set; }
    public bool ItemHQ { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ENpcResident = new LazyRow< ENpcResident >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 4 ), language );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 8 ), language );
        Unknown1 = parser.ReadOffset< byte >( 9 );
        AmountRequired = parser.ReadOffset< byte >( 10 );
        ItemHQ = parser.ReadOffset< bool >( 11 );
        

    }
}