// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AnimaWeaponIcon", columnHash: 0x63c20db3 )]
public partial class AnimaWeaponIcon : ExcelRow
{
    
    public int Hyperconductive { get; private set; }
    public int Reborn { get; private set; }
    public int Sharpened { get; private set; }
    public int Zodiac { get; private set; }
    public int ZodiacLux { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Hyperconductive = parser.ReadOffset< int >( 0 );
        Reborn = parser.ReadOffset< int >( 4 );
        Sharpened = parser.ReadOffset< int >( 8 );
        Zodiac = parser.ReadOffset< int >( 12 );
        ZodiacLux = parser.ReadOffset< int >( 16 );
        

    }
}