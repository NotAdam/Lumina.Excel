// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DeepDungeonDemiclone", columnHash: 0xc638f2bf )]
public partial class DeepDungeonDemiclone : ExcelRow
{
    
    public SeString Unknown1 { get; private set; }
    public SeString Unknown3 { get; private set; }
    public SeString Unknown9 { get; private set; }
    public SeString Unknown10 { get; private set; }
    public sbyte Unknown2 { get; private set; }
    public sbyte Unknown4 { get; private set; }
    public sbyte Unknown5 { get; private set; }
    public sbyte Unknown6 { get; private set; }
    public sbyte Unknown7 { get; private set; }
    public sbyte Unknown8 { get; private set; }
    public uint Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown1 = parser.ReadOffset< SeString >( 0 );
        Unknown3 = parser.ReadOffset< SeString >( 4 );
        Unknown9 = parser.ReadOffset< SeString >( 8 );
        Unknown10 = parser.ReadOffset< SeString >( 12 );
        Unknown2 = parser.ReadOffset< sbyte >( 16 );
        Unknown4 = parser.ReadOffset< sbyte >( 17 );
        Unknown5 = parser.ReadOffset< sbyte >( 18 );
        Unknown6 = parser.ReadOffset< sbyte >( 19 );
        Unknown7 = parser.ReadOffset< sbyte >( 20 );
        Unknown8 = parser.ReadOffset< sbyte >( 21 );
        Unknown0 = parser.ReadOffset< uint >( 24 );
        

    }
}