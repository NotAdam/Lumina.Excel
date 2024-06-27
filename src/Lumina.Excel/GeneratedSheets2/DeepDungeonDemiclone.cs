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
    
    public SeString Singular { get; private set; }
    public SeString Plural { get; private set; }
    public SeString TitleCase { get; private set; }
    public SeString Description { get; private set; }
    public sbyte Unknown4 { get; private set; }
    public sbyte Unknown5 { get; private set; }
    public sbyte Unknown6 { get; private set; }
    public sbyte Unknown7 { get; private set; }
    public sbyte Unknown8 { get; private set; }
    public sbyte Unknown9 { get; private set; }
    public uint Icon { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Singular = parser.ReadOffset< SeString >( 0 );
        Plural = parser.ReadOffset< SeString >( 4 );
        TitleCase = parser.ReadOffset< SeString >( 8 );
        Description = parser.ReadOffset< SeString >( 12 );
        Unknown4 = parser.ReadOffset< sbyte >( 16 );
        Unknown5 = parser.ReadOffset< sbyte >( 17 );
        Unknown6 = parser.ReadOffset< sbyte >( 18 );
        Unknown7 = parser.ReadOffset< sbyte >( 19 );
        Unknown8 = parser.ReadOffset< sbyte >( 20 );
        Unknown9 = parser.ReadOffset< sbyte >( 21 );
        Icon = parser.ReadOffset< uint >( 24 );
        

    }
}