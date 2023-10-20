// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DeepDungeonMap5X", columnHash: 0x64a88f98 )]
public partial class DeepDungeonMap5X : ExcelRow
{
    
    public LazyRow< DeepDungeonRoom >[] DeepDungeonRoom { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        DeepDungeonRoom = new LazyRow< DeepDungeonRoom >[5];
        for (int i = 0; i < 5; i++)
        	DeepDungeonRoom[i] = new LazyRow< DeepDungeonRoom >( gameData, parser.ReadOffset< ushort >( (ushort) ( 0 + i * 2 ) ), language );
        

    }
}