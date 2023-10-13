// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentCloseCycle", columnHash: 0xd3032cdb )]
public partial class ContentCloseCycle : ExcelRow
{
    
    public uint Unixtime { get; private set; }
    public uint TimeSeconds { get; private set; }
    public uint Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown9 { get; private set; }
    public bool Unknown10 { get; private set; }
    public bool Unknown11 { get; private set; }
    public bool Unknown12 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unixtime = parser.ReadOffset< uint >( 0 );
        TimeSeconds = parser.ReadOffset< uint >( 4 );
        Unknown2 = parser.ReadOffset< uint >( 8 );
        Unknown3 = parser.ReadOffset< bool >( 12 );
        Unknown4 = parser.ReadOffset< bool >( 13 );
        Unknown5 = parser.ReadOffset< bool >( 14 );
        Unknown6 = parser.ReadOffset< bool >( 15 );
        Unknown7 = parser.ReadOffset< bool >( 16 );
        Unknown8 = parser.ReadOffset< bool >( 17 );
        Unknown9 = parser.ReadOffset< bool >( 18 );
        Unknown10 = parser.ReadOffset< bool >( 19 );
        Unknown11 = parser.ReadOffset< bool >( 20 );
        Unknown12 = parser.ReadOffset< bool >( 21 );
        

    }
}