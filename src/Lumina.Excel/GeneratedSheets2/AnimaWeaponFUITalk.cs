// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AnimaWeaponFUITalk", columnHash: 0xda365c51 )]
public partial class AnimaWeaponFUITalk : ExcelRow
{
    
    public LazyRow< AnimaWeaponFUITalkParam > Dialogue { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Dialogue = new LazyRow< AnimaWeaponFUITalkParam >( gameData, parser.ReadOffset< int >( 0 ), language );
        

    }
}