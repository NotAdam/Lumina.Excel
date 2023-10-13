// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GeneralAction", columnHash: 0x5dffa8fa )]
public partial class GeneralAction : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public int Icon { get; private set; }
    public LazyRow< Action > Action { get; private set; }
    public ushort UnlockLink { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Recast { get; private set; }
    public byte UIPriority { get; private set; }
    public bool Unknown8 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Icon = parser.ReadOffset< int >( 8 );
        Action = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        UnlockLink = parser.ReadOffset< ushort >( 14 );
        Unknown2 = parser.ReadOffset< byte >( 16 );
        Recast = parser.ReadOffset< byte >( 17 );
        UIPriority = parser.ReadOffset< byte >( 18 );
        Unknown8 = parser.ReadOffset< bool >( 19 );
        

    }
}