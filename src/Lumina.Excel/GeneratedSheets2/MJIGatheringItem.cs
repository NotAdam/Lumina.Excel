// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIGatheringItem", columnHash: 0x0dd2ae8d )]
public partial class MJIGatheringItem : ExcelRow
{
    
    public ushort Radius { get; private set; }
    public short X { get; private set; }
    public short Y { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public LazyRow< Item > Item { get; private set; }
    public byte Sort { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Radius = parser.ReadOffset< ushort >( 0 );
        X = parser.ReadOffset< short >( 2 );
        Y = parser.ReadOffset< short >( 4 );
        Unknown0 = parser.ReadOffset< byte >( 6 );
        Unknown1 = parser.ReadOffset< byte >( 7 );
        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 8 ), language );
        Sort = parser.ReadOffset< byte >( 12 );
        

    }
}