// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "StatusLoopVFX", columnHash: 0xd5619c7c )]
public partial class StatusLoopVFX : ExcelRow
{
    
    public LazyRow< VFX >[] VFX { get; private set; }
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

        VFX = new LazyRow< VFX >[4];
        for (int i = 0; i < 4; i++)
        	VFX[i] = new LazyRow< VFX >( gameData, parser.ReadOffset< ushort >( (ushort) ( 0 + i * 2 ) ), language );
        Unknown1 = parser.ReadOffset< byte >( 8 );
        Unknown3 = parser.ReadOffset< byte >( 9 );
        Unknown5 = parser.ReadOffset< byte >( 10 );
        Unknown6 = parser.ReadOffset< byte >( 11 );
        Unknown7 = parser.ReadOffset< bool >( 12 );
        Unknown8 = parser.ReadOffset< bool >( 12, 2 );
        Unknown9 = parser.ReadOffset< bool >( 12, 4 );
        

    }
}