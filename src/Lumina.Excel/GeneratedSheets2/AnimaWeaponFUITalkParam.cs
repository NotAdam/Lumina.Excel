// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AnimaWeaponFUITalkParam", columnHash: 0x9db0e48f )]
public partial class AnimaWeaponFUITalkParam : ExcelRow
{
    
    public SeString Prologue { get; private set; }
    public SeString Epilogue { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Prologue = parser.ReadOffset< SeString >( 0 );
        Epilogue = parser.ReadOffset< SeString >( 4 );
        

    }
}