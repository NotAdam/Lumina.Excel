// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestClassJobSupply", columnHash: 0xe5f06bbc )]
public partial class QuestClassJobSupply : ExcelRow
{
    
    public LazyRow< ENpcResident > ENpcResident { get; private set; }
    public LazyRow< Item > Item { get; private set; }
    public uint Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte AmountRequired { get; private set; }
    public bool ItemHQ { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ENpcResident = new LazyRow< ENpcResident >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Unknown1 = parser.ReadOffset< uint >( 8 );
        Unknown2 = parser.ReadOffset< ushort >( 12 );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 14 ), language );
        Unknown0 = parser.ReadOffset< byte >( 15 );
        AmountRequired = parser.ReadOffset< byte >( 16 );
        ItemHQ = parser.ReadOffset< bool >( 17 );
        

    }
}