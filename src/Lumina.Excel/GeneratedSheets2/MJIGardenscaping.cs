// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIGardenscaping", columnHash: 0x3554ffd5 )]
public partial class MJIGardenscaping : ExcelRow
{
    
    public int Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public int Unknown2 { get; private set; }
    public LazyRow< Item > Item { get; private set; }
    public int Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public ushort Unknown5 { get; private set; }
    public ushort Unknown6 { get; private set; }
    public byte Level { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< int >( 0 );
        Unknown1 = parser.ReadOffset< int >( 4 );
        Unknown2 = parser.ReadOffset< int >( 8 );
        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 12 ), language );
        Unknown3 = parser.ReadOffset< int >( 16 );
        Unknown4 = parser.ReadOffset< ushort >( 20 );
        Unknown5 = parser.ReadOffset< ushort >( 22 );
        Unknown6 = parser.ReadOffset< ushort >( 24 );
        Level = parser.ReadOffset< byte >( 26 );
        

    }
}