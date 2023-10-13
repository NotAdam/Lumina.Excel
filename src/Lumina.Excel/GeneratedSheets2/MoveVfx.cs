// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MoveVfx", columnHash: 0x2020acf6 )]
public partial class MoveVfx : ExcelRow
{
    
    public LazyRow< VFX > VFXNormal { get; private set; }
    public LazyRow< VFX > VFXWalking { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        VFXNormal = new LazyRow< VFX >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        VFXWalking = new LazyRow< VFX >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        

    }
}