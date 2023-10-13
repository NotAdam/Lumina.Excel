// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GCSupplyDuty", columnHash: 0xb3265a92 )]
public partial class GCSupplyDuty : ExcelRow
{
    public struct SupplyDataStruct
    {
    	public LazyRow< Item >[] Item { get; internal set; }
    	public byte[] ItemCount { get; internal set; }
    }
    
    public SupplyDataStruct[] SupplyData { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SupplyData = new SupplyDataStruct[11];
        for (int i = 0; i < 11; i++)
        {
        	SupplyData[i].Item = new LazyRow< Item >[3];
        	for (int ItemIndexer = 0; ItemIndexer < 3; ItemIndexer++)
        		SupplyData[i].Item[ItemIndexer] = new LazyRow< Item >( gameData, parser.ReadOffset< int >( i * 16 +  0 + ItemIndexer * 4 ), language );
        	SupplyData[i].ItemCount = new byte[3];
        	for (int ItemCountIndexer = 0; ItemCountIndexer < 3; ItemCountIndexer++)
        		SupplyData[i].ItemCount[ItemCountIndexer] = parser.ReadOffset< byte >( (ushort) ( i * 16 + 12 + ItemCountIndexer * 1 ) );
        }
        

    }
}