// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AnimaWeapon5", columnHash: 0xe777b7a6 )]
public partial class AnimaWeapon5 : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte SecondaryStatTotal { get; private set; }
    public LazyRow< AnimaWeapon5Param >[] Parameter { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 0 ), language );
        Unknown1 = parser.ReadOffset< byte >( 4 );
        SecondaryStatTotal = parser.ReadOffset< byte >( 5 );
        Parameter = new LazyRow< AnimaWeapon5Param >[5];
        for (int i = 0; i < 5; i++)
        	Parameter[i] = new LazyRow< AnimaWeapon5Param >( gameData, parser.ReadOffset< byte >( (ushort) ( 6 + i * 1 ) ), language );
        

    }
}