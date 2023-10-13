// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentGaugeColor", columnHash: 0x96a22aea )]
public partial class ContentGaugeColor : ExcelRow
{
    
    public uint AndroidColor1 { get; private set; }
    public uint AndroidColor2 { get; private set; }
    public uint AndroidColor3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        AndroidColor1 = parser.ReadOffset< uint >( 0 );
        AndroidColor2 = parser.ReadOffset< uint >( 4 );
        AndroidColor3 = parser.ReadOffset< uint >( 8 );
        

    }
}