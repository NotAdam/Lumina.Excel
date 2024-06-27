// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PhysicsOffGroup", columnHash: 0xdb6ee4cd )]
public partial class PhysicsOffGroup : ExcelRow
{
    
    public sbyte Unknown0 { get; private set; }
    public sbyte Unknown1 { get; private set; }
    public sbyte Unknown_70_1 { get; private set; }
    public sbyte Unknown_70_2 { get; private set; }
    public sbyte Unknown_70_3 { get; private set; }
    public sbyte Unknown_70_4 { get; private set; }
    public sbyte Unknown_70_5 { get; private set; }
    public sbyte Unknown_70_6 { get; private set; }
    public sbyte Unknown_70_7 { get; private set; }
    public sbyte Unknown_70_8 { get; private set; }
    public sbyte Unknown_70_9 { get; private set; }
    public sbyte Unknown_70_10 { get; private set; }
    public sbyte Unknown_70_11 { get; private set; }
    public sbyte Unknown_70_12 { get; private set; }
    public sbyte Unknown_70_13 { get; private set; }
    public sbyte Unknown_70_14 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< sbyte >( 0 );
        Unknown1 = parser.ReadOffset< sbyte >( 1 );
        Unknown_70_1 = parser.ReadOffset< sbyte >( 2 );
        Unknown_70_2 = parser.ReadOffset< sbyte >( 3 );
        Unknown_70_3 = parser.ReadOffset< sbyte >( 4 );
        Unknown_70_4 = parser.ReadOffset< sbyte >( 5 );
        Unknown_70_5 = parser.ReadOffset< sbyte >( 6 );
        Unknown_70_6 = parser.ReadOffset< sbyte >( 7 );
        Unknown_70_7 = parser.ReadOffset< sbyte >( 8 );
        Unknown_70_8 = parser.ReadOffset< sbyte >( 9 );
        Unknown_70_9 = parser.ReadOffset< sbyte >( 10 );
        Unknown_70_10 = parser.ReadOffset< sbyte >( 11 );
        Unknown_70_11 = parser.ReadOffset< sbyte >( 12 );
        Unknown_70_12 = parser.ReadOffset< sbyte >( 13 );
        Unknown_70_13 = parser.ReadOffset< sbyte >( 14 );
        Unknown_70_14 = parser.ReadOffset< sbyte >( 15 );
        

    }
}