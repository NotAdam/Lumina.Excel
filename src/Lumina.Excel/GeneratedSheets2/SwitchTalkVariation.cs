// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SwitchTalkVariation", columnHash: 0x031e9614 )]
public partial class SwitchTalkVariation : ExcelRow
{
    
    public LazyRow< Quest > Quest0 { get; private set; }
    public LazyRow< Quest > Quest1 { get; private set; }
    public LazyRow< DefaultTalk > DefaultTalk { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Quest0 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Quest1 = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 4 ), language );
        DefaultTalk = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< uint >( 8 ), language );
        Unknown0 = parser.ReadOffset< byte >( 12 );
        

    }
}