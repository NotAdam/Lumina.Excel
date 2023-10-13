// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GilShop", columnHash: 0x4a239844 )]
public partial class GilShop : ExcelRow
{
    
    public SeString Name { get; private set; }
    public uint Icon { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    public LazyRow< DefaultTalk > AcceptTalk { get; private set; }
    public LazyRow< DefaultTalk > FailTalk { get; private set; }
    public ushort Unknown6 { get; private set; }
    public bool Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< uint >( 4 );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 8 ), language );
        AcceptTalk = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< int >( 12 ), language );
        FailTalk = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< int >( 16 ), language );
        Unknown6 = parser.ReadOffset< ushort >( 20 );
        Unknown5 = parser.ReadOffset< bool >( 22 );
        

    }
}