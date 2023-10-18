// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GilShop", columnHash: 0xf50b55e5 )]
public partial class GilShop : ExcelRow
{
    
    public SeString Name { get; private set; }
    public uint Icon { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    public LazyRow< DefaultTalk > AcceptTalk { get; private set; }
    public LazyRow< DefaultTalk > FailTalk { get; private set; }
    public ushort Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< uint >( 4 );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 8 ), language );
        AcceptTalk = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< int >( 12 ), language );
        FailTalk = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< int >( 16 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 20 );
        Unknown1 = parser.ReadOffset< ushort >( 22 );
        Unknown2 = parser.ReadOffset< bool >( 24 );
        

    }
}