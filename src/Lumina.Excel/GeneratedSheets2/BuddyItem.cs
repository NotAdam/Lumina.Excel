// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BuddyItem", columnHash: 0xfa9fc03d )]
public partial class BuddyItem : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public byte Status { get; private set; }
    public bool UseField { get; private set; }
    public bool UseTraining { get; private set; }
    public bool Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        Status = parser.ReadOffset< byte >( 2 );
        UseField = parser.ReadOffset< bool >( 3 );
        UseTraining = parser.ReadOffset< bool >( 3, 2 );
        Unknown0 = parser.ReadOffset< bool >( 3, 4 );
        

    }
}