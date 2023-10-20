// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ActionCastTimeline", columnHash: 0x2020acf6 )]
public partial class ActionCastTimeline : ExcelRow
{
    
    public LazyRow< ActionTimeline > Name { get; private set; }
    public LazyRow< VFX > VFX { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        VFX = new LazyRow< VFX >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        

    }
}