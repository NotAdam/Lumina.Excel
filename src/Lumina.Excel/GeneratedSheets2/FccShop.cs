// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FccShop", columnHash: 0xccd13846 )]
public partial class FccShop : ExcelRow
{
    public struct ItemDataStruct
    {
    	public LazyRow< Item > Item { get; internal set; }
    	public uint Cost { get; internal set; }
    	public LazyRow< FCRank > FCRankRequired { get; internal set; }
    }
    
    public SeString Name { get; private set; }
    public ItemDataStruct[] ItemData { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        ItemData = new ItemDataStruct[10];
        for (int i = 0; i < 10; i++)
        {
        	ItemData[i].Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( (ushort) (i * 12 + 4) ), language );
        	ItemData[i].Cost = parser.ReadOffset< uint >( (ushort) (i * 12 + 8));
        	ItemData[i].FCRankRequired = new LazyRow< FCRank >( gameData, parser.ReadOffset< byte >( (ushort) (i * 12 + 12) ), language );
        }
        

    }
}