// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TerritoryTypeTelepo", columnHash: 0x33ff1cee )]
public partial class TerritoryTypeTelepo : ExcelRow
{
    
    public ushort X { get; private set; }
    public ushort Y { get; private set; }
    public ushort Expansion { get; private set; }
    public LazyRow< TelepoRelay > Relay { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        X = parser.ReadOffset< ushort >( 0 );
        Y = parser.ReadOffset< ushort >( 2 );
        Expansion = parser.ReadOffset< ushort >( 4 );
        Relay = new LazyRow< TelepoRelay >( gameData, parser.ReadOffset< byte >( 6 ), language );
        

    }
}