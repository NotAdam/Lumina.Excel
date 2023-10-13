// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FCActivity", columnHash: 0xe45dc889 )]
public partial class FCActivity : ExcelRow
{
    
    public SeString Text { get; private set; }
    public byte SelfKind { get; private set; }
    public byte TargetKind { get; private set; }
    public byte NumParam { get; private set; }
    public LazyRow< FCActivityCategory > FCActivityCategory { get; private set; }
    public sbyte IconType { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        SelfKind = parser.ReadOffset< byte >( 4 );
        TargetKind = parser.ReadOffset< byte >( 5 );
        NumParam = parser.ReadOffset< byte >( 6 );
        FCActivityCategory = new LazyRow< FCActivityCategory >( gameData, parser.ReadOffset< byte >( 7 ), language );
        IconType = parser.ReadOffset< sbyte >( 8 );
        

    }
}