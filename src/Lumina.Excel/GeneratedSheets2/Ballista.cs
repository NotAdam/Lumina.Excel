// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Ballista", columnHash: 0xcac0c160 )]
public partial class Ballista : ExcelRow
{
    
    public LazyRow< BNpcBase > BNPC { get; private set; }
    public ushort Angle { get; private set; }
    public LazyRow< Action > Action0 { get; private set; }
    public LazyRow< Action > Action1 { get; private set; }
    public LazyRow< Action > Action2 { get; private set; }
    public LazyRow< Action > Action3 { get; private set; }
    public byte Bullet { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public sbyte Near { get; private set; }
    public sbyte Far { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        BNPC = new LazyRow< BNpcBase >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        Angle = parser.ReadOffset< ushort >( 2 );
        Action0 = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        Action1 = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 6 ), language );
        Action2 = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        Action3 = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 10 ), language );
        Bullet = parser.ReadOffset< byte >( 12 );
        Unknown5 = parser.ReadOffset< byte >( 13 );
        Unknown6 = parser.ReadOffset< byte >( 14 );
        Near = parser.ReadOffset< sbyte >( 15 );
        Far = parser.ReadOffset< sbyte >( 16 );
        

    }
}