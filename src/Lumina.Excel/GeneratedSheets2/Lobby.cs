// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Lobby", columnHash: 0x54075f2e )]
public partial class Lobby : ExcelRow
{
    
    public SeString Text { get; private set; }
    public SeString Unknown4 { get; private set; }
    public SeString Unknown5 { get; private set; }
    public uint TYPE { get; private set; }
    public uint PARAM { get; private set; }
    public uint LINK { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        Unknown4 = parser.ReadOffset< SeString >( 4 );
        Unknown5 = parser.ReadOffset< SeString >( 8 );
        TYPE = parser.ReadOffset< uint >( 12 );
        PARAM = parser.ReadOffset< uint >( 16 );
        LINK = parser.ReadOffset< uint >( 20 );
        

    }
}