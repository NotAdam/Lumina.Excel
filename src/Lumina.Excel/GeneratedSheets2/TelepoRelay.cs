// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TelepoRelay", columnHash: 0xcafd686e )]
public partial class TelepoRelay : ExcelRow
{
    public struct RelaysStruct
    {
    	public LazyRow< TerritoryType > EnterTerritory { get; internal set; }
    	public LazyRow< TerritoryType > ExitTerritory { get; internal set; }
    	public ushort Cost { get; internal set; }
    }
    
    public RelaysStruct[] Relays { get; private set; }
    public uint Unknown_70 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Relays = new RelaysStruct[8];
        for (int i = 0; i < 8; i++)
        {
        	Relays[i].EnterTerritory = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( (ushort) (i * 6 + 0) ), language );
        	Relays[i].ExitTerritory = new LazyRow< TerritoryType >( gameData, parser.ReadOffset< ushort >( (ushort) (i * 6 + 2) ), language );
        	Relays[i].Cost = parser.ReadOffset< ushort >( (ushort) (i * 6 + 4));
        }
        Unknown_70 = parser.ReadOffset< uint >( 48 );
        

    }
}