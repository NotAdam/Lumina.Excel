// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HowToPage", columnHash: 0x006e1eac )]
public partial class HowToPage : ExcelRow
{
    
    public SeString[] Text { get; private set; }
    public int Image { get; private set; }
    public byte Type { get; private set; }
    public byte IconType { get; private set; }
    public byte TextType { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = new SeString[3];
        for (int i = 0; i < 3; i++)
        	Text[i] = parser.ReadOffset< SeString >( 0 + i * 4 );
        Image = parser.ReadOffset< int >( 12 );
        Type = parser.ReadOffset< byte >( 16 );
        IconType = parser.ReadOffset< byte >( 17 );
        TextType = parser.ReadOffset< byte >( 18 );
        

    }
}