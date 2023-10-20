// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CharaMakeClassEquip", columnHash: 0x41dafacb )]
public partial class CharaMakeClassEquip : ExcelRow
{
    
    public ulong Helmet { get; private set; }
    public ulong Top { get; private set; }
    public ulong Glove { get; private set; }
    public ulong Down { get; private set; }
    public ulong Shoes { get; private set; }
    public ulong Weapon { get; private set; }
    public ulong SubWeapon { get; private set; }
    public LazyRow< ClassJob > Class { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Helmet = parser.ReadOffset< ulong >( 0 );
        Top = parser.ReadOffset< ulong >( 8 );
        Glove = parser.ReadOffset< ulong >( 16 );
        Down = parser.ReadOffset< ulong >( 24 );
        Shoes = parser.ReadOffset< ulong >( 32 );
        Weapon = parser.ReadOffset< ulong >( 40 );
        SubWeapon = parser.ReadOffset< ulong >( 48 );
        Class = new LazyRow< ClassJob >( gameData, parser.ReadOffset< int >( 56 ), language );
        

    }
}