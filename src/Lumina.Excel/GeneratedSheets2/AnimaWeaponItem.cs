// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AnimaWeaponItem", columnHash: 0xe0a5cdd0 )]
public partial class AnimaWeaponItem : ExcelRow
{
    
    public LazyRow< Item >[] Item { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >[14];
        for (int i = 0; i < 14; i++)
        	Item[i] = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( (ushort) ( 0 + i * 4 ) ), language );
        

    }
}