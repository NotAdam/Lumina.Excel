// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Glasses", columnHash: 0x2faac2c1 )]
public partial class Glasses : ExcelRow
{
    
    public SeString Singular { get; private set; }
    public SeString Plural { get; private set; }
    public SeString Description { get; private set; }
    public SeString Name { get; private set; }
    public sbyte Unknown_70_1 { get; private set; }
    public sbyte Unknown_70_2 { get; private set; }
    public sbyte Unknown_70_3 { get; private set; }
    public sbyte Unknown_70_4 { get; private set; }
    public sbyte Unknown_70_5 { get; private set; }
    public sbyte Unknown_70_6 { get; private set; }
    public uint Unknown_70_7 { get; private set; }
    public int Icon { get; private set; }
    public ushort Unknown_70_8 { get; private set; }
    public short Unknown_70_9 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Singular = parser.ReadOffset< SeString >( 0 );
        Plural = parser.ReadOffset< SeString >( 4 );
        Description = parser.ReadOffset< SeString >( 8 );
        Name = parser.ReadOffset< SeString >( 12 );
        Unknown_70_1 = parser.ReadOffset< sbyte >( 16 );
        Unknown_70_2 = parser.ReadOffset< sbyte >( 17 );
        Unknown_70_3 = parser.ReadOffset< sbyte >( 18 );
        Unknown_70_4 = parser.ReadOffset< sbyte >( 19 );
        Unknown_70_5 = parser.ReadOffset< sbyte >( 20 );
        Unknown_70_6 = parser.ReadOffset< sbyte >( 21 );
        Unknown_70_7 = parser.ReadOffset< uint >( 24 );
        Icon = parser.ReadOffset< int >( 28 );
        Unknown_70_8 = parser.ReadOffset< ushort >( 32 );
        Unknown_70_9 = parser.ReadOffset< short >( 34 );
        

    }
}