// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SystemGraphicPreset", columnHash: 0xa904455e )]
public partial class SystemGraphicPreset : ExcelRow
{
    
    public sbyte Unknown0 { get; private set; }
    public sbyte Unknown1 { get; private set; }
    public sbyte Unknown2 { get; private set; }
    public sbyte Unknown3 { get; private set; }
    public sbyte Unknown4 { get; private set; }
    public sbyte Unknown5 { get; private set; }
    public sbyte Unknown6 { get; private set; }
    public sbyte Unknown7 { get; private set; }
    public sbyte Unknown8 { get; private set; }
    public sbyte Unknown9 { get; private set; }
    public sbyte Unknown10 { get; private set; }
    public sbyte Unknown11 { get; private set; }
    public sbyte Unknown12 { get; private set; }
    public sbyte Unknown13 { get; private set; }
    public sbyte Unknown14 { get; private set; }
    public sbyte Unknown15 { get; private set; }
    public sbyte Unknown16 { get; private set; }
    public sbyte Unknown17 { get; private set; }
    public sbyte Unknown18 { get; private set; }
    public sbyte Unknown19 { get; private set; }
    public sbyte Unknown20 { get; private set; }
    public sbyte Unknown21 { get; private set; }
    public sbyte Unknown22 { get; private set; }
    public sbyte Unknown23 { get; private set; }
    public sbyte Unknown24 { get; private set; }
    public sbyte Unknown25 { get; private set; }
    public sbyte Unknown26 { get; private set; }
    public sbyte Unknown27 { get; private set; }
    public sbyte Unknown28 { get; private set; }
    public sbyte Unknown29 { get; private set; }
    public sbyte Unknown30 { get; private set; }
    public sbyte Unknown31 { get; private set; }
    public sbyte Unknown32 { get; private set; }
    public sbyte Unknown_70_1 { get; private set; }
    public sbyte Unknown_70_2 { get; private set; }
    public sbyte Unknown_70_3 { get; private set; }
    public sbyte Unknown_70_4 { get; private set; }
    public sbyte Unknown_70_5 { get; private set; }
    public sbyte Unknown_70_6 { get; private set; }
    public sbyte Unknown_70_7 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< sbyte >( 0 );
        Unknown1 = parser.ReadOffset< sbyte >( 1 );
        Unknown2 = parser.ReadOffset< sbyte >( 2 );
        Unknown3 = parser.ReadOffset< sbyte >( 3 );
        Unknown4 = parser.ReadOffset< sbyte >( 4 );
        Unknown5 = parser.ReadOffset< sbyte >( 5 );
        Unknown6 = parser.ReadOffset< sbyte >( 6 );
        Unknown7 = parser.ReadOffset< sbyte >( 7 );
        Unknown8 = parser.ReadOffset< sbyte >( 8 );
        Unknown9 = parser.ReadOffset< sbyte >( 9 );
        Unknown10 = parser.ReadOffset< sbyte >( 10 );
        Unknown11 = parser.ReadOffset< sbyte >( 11 );
        Unknown12 = parser.ReadOffset< sbyte >( 12 );
        Unknown13 = parser.ReadOffset< sbyte >( 13 );
        Unknown14 = parser.ReadOffset< sbyte >( 14 );
        Unknown15 = parser.ReadOffset< sbyte >( 15 );
        Unknown16 = parser.ReadOffset< sbyte >( 16 );
        Unknown17 = parser.ReadOffset< sbyte >( 17 );
        Unknown18 = parser.ReadOffset< sbyte >( 18 );
        Unknown19 = parser.ReadOffset< sbyte >( 19 );
        Unknown20 = parser.ReadOffset< sbyte >( 20 );
        Unknown21 = parser.ReadOffset< sbyte >( 21 );
        Unknown22 = parser.ReadOffset< sbyte >( 22 );
        Unknown23 = parser.ReadOffset< sbyte >( 23 );
        Unknown24 = parser.ReadOffset< sbyte >( 24 );
        Unknown25 = parser.ReadOffset< sbyte >( 25 );
        Unknown26 = parser.ReadOffset< sbyte >( 26 );
        Unknown27 = parser.ReadOffset< sbyte >( 27 );
        Unknown28 = parser.ReadOffset< sbyte >( 28 );
        Unknown29 = parser.ReadOffset< sbyte >( 29 );
        Unknown30 = parser.ReadOffset< sbyte >( 30 );
        Unknown31 = parser.ReadOffset< sbyte >( 31 );
        Unknown32 = parser.ReadOffset< sbyte >( 32 );
        Unknown_70_1 = parser.ReadOffset< sbyte >( 33 );
        Unknown_70_2 = parser.ReadOffset< sbyte >( 34 );
        Unknown_70_3 = parser.ReadOffset< sbyte >( 35 );
        Unknown_70_4 = parser.ReadOffset< sbyte >( 36 );
        Unknown_70_5 = parser.ReadOffset< sbyte >( 37 );
        Unknown_70_6 = parser.ReadOffset< sbyte >( 38 );
        Unknown_70_7 = parser.ReadOffset< sbyte >( 39 );
        

    }
}