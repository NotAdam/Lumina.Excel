// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DeepDungeonRoom", columnHash: 0x6be0e840 )]
public partial class DeepDungeonRoom : ExcelRow
{
    
    public LazyRow< Level >[] Level { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Level = new LazyRow< Level >[5];
        for (int i = 0; i < 5; i++)
        	Level[i] = new LazyRow< Level >( gameData, parser.ReadOffset< uint >( (ushort) ( 0 + i * 4 ) ), language );
        

    }
}