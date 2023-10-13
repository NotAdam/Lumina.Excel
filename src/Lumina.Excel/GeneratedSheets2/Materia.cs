// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Materia", columnHash: 0x690ce1c4 )]
public partial class Materia : ExcelRow
{
    
    public LazyRow< Item >[] Item { get; private set; }
    public int Unknown10 { get; private set; }
    public int Unknown11 { get; private set; }
    public int Unknown12 { get; private set; }
    public int Unknown13 { get; private set; }
    public int Unknown14 { get; private set; }
    public int Unknown15 { get; private set; }
    public short[] Value { get; private set; }
    public short Unknown27 { get; private set; }
    public short Unknown28 { get; private set; }
    public short Unknown29 { get; private set; }
    public short Unknown30 { get; private set; }
    public short Unknown31 { get; private set; }
    public short Unknown32 { get; private set; }
    public LazyRow< BaseParam > BaseParam { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >[10];
        for (int i = 0; i < 10; i++)
        	Item[i] = new LazyRow< Item >( gameData, parser.ReadOffset< int >( (ushort) ( 0 + i * 4 ) ), language );
        Unknown10 = parser.ReadOffset< int >( 40 );
        Unknown11 = parser.ReadOffset< int >( 44 );
        Unknown12 = parser.ReadOffset< int >( 48 );
        Unknown13 = parser.ReadOffset< int >( 52 );
        Unknown14 = parser.ReadOffset< int >( 56 );
        Unknown15 = parser.ReadOffset< int >( 60 );
        Value = new short[10];
        for (int i = 0; i < 10; i++)
        	Value[i] = parser.ReadOffset< short >( 64 + i * 2 );
        Unknown27 = parser.ReadOffset< short >( 84 );
        Unknown28 = parser.ReadOffset< short >( 86 );
        Unknown29 = parser.ReadOffset< short >( 88 );
        Unknown30 = parser.ReadOffset< short >( 90 );
        Unknown31 = parser.ReadOffset< short >( 92 );
        Unknown32 = parser.ReadOffset< short >( 94 );
        BaseParam = new LazyRow< BaseParam >( gameData, parser.ReadOffset< byte >( 96 ), language );
        

    }
}