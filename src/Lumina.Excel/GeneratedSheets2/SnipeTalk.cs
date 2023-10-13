// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SnipeTalk", columnHash: 0xcea69cac )]
public partial class SnipeTalk : ExcelRow
{
    
    public SeString Text { get; private set; }
    public SeString Unknown4 { get; private set; }
    public SeString Unknown5 { get; private set; }
    public LazyRow< SnipeTalkName > Name { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Text = parser.ReadOffset< SeString >( 0 );
        Unknown4 = parser.ReadOffset< SeString >( 4 );
        Unknown5 = parser.ReadOffset< SeString >( 8 );
        Name = new LazyRow< SnipeTalkName >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        Unknown0 = parser.ReadOffset< byte >( 14 );
        Unknown1 = parser.ReadOffset< byte >( 15 );
        

    }
}