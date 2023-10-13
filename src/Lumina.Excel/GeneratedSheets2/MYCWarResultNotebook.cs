// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MYCWarResultNotebook", columnHash: 0x02f3734a )]
public partial class MYCWarResultNotebook : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public SeString NameJP { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    public int Unknown4 { get; private set; }
    public int Icon { get; private set; }
    public int Image { get; private set; }
    public byte Number { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Link { get; private set; }
    public byte Rarity { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        NameJP = parser.ReadOffset< SeString >( 8 );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< int >( 12 ), language );
        Unknown4 = parser.ReadOffset< int >( 16 );
        Icon = parser.ReadOffset< int >( 20 );
        Image = parser.ReadOffset< int >( 24 );
        Number = parser.ReadOffset< byte >( 28 );
        Unknown1 = parser.ReadOffset< byte >( 29 );
        Link = parser.ReadOffset< byte >( 30 );
        Rarity = parser.ReadOffset< byte >( 31 );
        

    }
}