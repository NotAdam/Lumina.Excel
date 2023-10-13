// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DeepDungeonBan", columnHash: 0xdc23efe7 )]
public partial class DeepDungeonBan : ExcelRow
{
    
    public LazyRow< ScreenImage > ScreenImage { get; private set; }
    public LazyRow< LogMessage > LogMessage { get; private set; }
    public LazyRow< DeepDungeonFloorEffectUI > Name { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ScreenImage = new LazyRow< ScreenImage >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        LogMessage = new LazyRow< LogMessage >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        Name = new LazyRow< DeepDungeonFloorEffectUI >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        

    }
}