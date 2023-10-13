// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "StatusLoopVFX", columnHash: 0x69d57da3 )]
public partial class StatusLoopVFX : ExcelRow
{
    
    public LazyRow< VFX > VFX { get; private set; }
    public LazyRow< VFX > VFX2 { get; private set; }
    public LazyRow< VFX > VFX3 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown9 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        VFX = new LazyRow< VFX >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        VFX2 = new LazyRow< VFX >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        VFX3 = new LazyRow< VFX >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        Unknown1 = parser.ReadOffset< byte >( 6 );
        Unknown3 = parser.ReadOffset< byte >( 7 );
        Unknown5 = parser.ReadOffset< byte >( 8 );
        Unknown6 = parser.ReadOffset< byte >( 9 );
        Unknown7 = parser.ReadOffset< bool >( 10 );
        Unknown8 = parser.ReadOffset< bool >( 10, 2 );
        Unknown9 = parser.ReadOffset< bool >( 10, 4 );
        

    }
}