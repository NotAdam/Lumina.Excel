// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "LogMessage", columnHash: 0xf3a6d024 )]
public partial class LogMessage : ExcelRow
{
    
    public SeString Text { get; private set; }
    public ushort LogKind { get; private set; }
    public ushort Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        LogKind = parser.ReadOffset< ushort >( 4 );
        Unknown0 = parser.ReadOffset< ushort >( 6 );
        Unknown1 = parser.ReadOffset< byte >( 8 );
        Unknown2 = parser.ReadOffset< bool >( 9 );
        

    }
}