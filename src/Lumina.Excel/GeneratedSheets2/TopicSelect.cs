// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TopicSelect", columnHash: 0xc312c89f )]
public partial class TopicSelect : ExcelRow
{
    
    public SeString Name { get; private set; }
    public ILazyRow[] Shop { get; private set; }
    public ushort Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Shop = new ILazyRow[10];
        for (int i = 0; i < 10; i++)
        	Shop[i] = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( 4 + i * 4 ), language, "SpecialShop", "GilShop", "PreHandler" );
        Unknown0 = parser.ReadOffset< ushort >( 44 );
        Unknown1 = parser.ReadOffset< byte >( 46 );
        Unknown2 = parser.ReadOffset< bool >( 47 );
        

    }
}