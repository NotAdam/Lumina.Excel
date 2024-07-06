// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GlassesStyle", columnHash: 0xc138bb6e )]
public partial class GlassesStyle : ExcelRow
{
    
    public SeString Singular { get; private set; }
    public SeString Plural { get; private set; }
    public SeString Name { get; private set; }
    public sbyte Unknown_70_1 { get; private set; }
    public sbyte Unknown_70_2 { get; private set; }
    public sbyte Unknown_70_3 { get; private set; }
    public sbyte Unknown_70_4 { get; private set; }
    public sbyte Unknown_70_5 { get; private set; }
    public sbyte Unknown_70_6 { get; private set; }
    public int Icon { get; private set; }
    public ushort Order { get; private set; }
    public LazyRow< Glasses >[] Glasses { get; private set; }
    public short Unknown_70_7 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Singular = parser.ReadOffset< SeString >( 0 );
        Plural = parser.ReadOffset< SeString >( 4 );
        Name = parser.ReadOffset< SeString >( 8 );
        Unknown_70_1 = parser.ReadOffset< sbyte >( 12 );
        Unknown_70_2 = parser.ReadOffset< sbyte >( 13 );
        Unknown_70_3 = parser.ReadOffset< sbyte >( 14 );
        Unknown_70_4 = parser.ReadOffset< sbyte >( 15 );
        Unknown_70_5 = parser.ReadOffset< sbyte >( 16 );
        Unknown_70_6 = parser.ReadOffset< sbyte >( 17 );
        Icon = parser.ReadOffset< int >( 20 );
        Order = parser.ReadOffset< ushort >( 24 );
        Glasses = new LazyRow< Glasses >[12];
        for (int i = 0; i < 12; i++)
        	Glasses[i] = new LazyRow< Glasses >( gameData, parser.ReadOffset< ushort >( (ushort) ( 26 + i * 2 ) ), language );
        Unknown_70_7 = parser.ReadOffset< short >( 50 );
        

    }
}