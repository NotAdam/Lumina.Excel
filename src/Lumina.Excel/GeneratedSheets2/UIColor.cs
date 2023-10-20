// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "UIColor", columnHash: 0x05bcd0de )]
public partial class UIColor : ExcelRow
{
    
    public uint UIForeground { get; private set; }
    public uint UIGlow { get; private set; }
    public uint Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        UIForeground = parser.ReadOffset< uint >( 0 );
        UIGlow = parser.ReadOffset< uint >( 4 );
        Unknown0 = parser.ReadOffset< uint >( 8 );
        Unknown1 = parser.ReadOffset< uint >( 12 );
        

    }
}