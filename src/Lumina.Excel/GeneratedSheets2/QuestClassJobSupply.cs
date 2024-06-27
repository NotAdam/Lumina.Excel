// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestClassJobSupply", columnHash: 0xcdd1c33a )]
public partial class QuestClassJobSupply : ExcelRow
{
    
    public byte Unknown_70_1 { get; private set; }
    public LazyRow< ENpcResident > ENpcResident { get; private set; }
    public LazyRow< Item > Item { get; private set; }
    public uint Unknown_70_2 { get; private set; }
    public uint Unknown_70_3 { get; private set; }
    public uint Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public LazyRow< ClassJobCategory > ClassJobCategory { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte AmountRequired { get; private set; }
    public bool ItemHQ { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown_70_1 = parser.ReadOffset< byte >( 0 );
        ENpcResident = new LazyRow< ENpcResident >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 8 ), language );
        Unknown_70_2 = parser.ReadOffset< uint >( 12 );
        Unknown_70_3 = parser.ReadOffset< uint >( 16 );
        Unknown1 = parser.ReadOffset< uint >( 20 );
        Unknown2 = parser.ReadOffset< ushort >( 24 );
        ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadOffset< byte >( 26 ), language );
        Unknown0 = parser.ReadOffset< byte >( 27 );
        AmountRequired = parser.ReadOffset< byte >( 28 );
        ItemHQ = parser.ReadOffset< bool >( 29 );
        

    }
}