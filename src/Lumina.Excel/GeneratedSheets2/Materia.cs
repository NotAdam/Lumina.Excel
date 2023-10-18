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
    public int Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public int Unknown2 { get; private set; }
    public int Unknown3 { get; private set; }
    public int Unknown4 { get; private set; }
    public int Unknown5 { get; private set; }
    public short[] Value { get; private set; }
    public short Unknown6 { get; private set; }
    public short Unknown7 { get; private set; }
    public short Unknown8 { get; private set; }
    public short Unknown9 { get; private set; }
    public short Unknown10 { get; private set; }
    public short Unknown11 { get; private set; }
    public LazyRow< BaseParam > BaseParam { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >[10];
        for (int i = 0; i < 10; i++)
        	Item[i] = new LazyRow< Item >( gameData, parser.ReadOffset< int >( (ushort) ( 0 + i * 4 ) ), language );
        Unknown0 = parser.ReadOffset< int >( 40 );
        Unknown1 = parser.ReadOffset< int >( 44 );
        Unknown2 = parser.ReadOffset< int >( 48 );
        Unknown3 = parser.ReadOffset< int >( 52 );
        Unknown4 = parser.ReadOffset< int >( 56 );
        Unknown5 = parser.ReadOffset< int >( 60 );
        Value = new short[10];
        for (int i = 0; i < 10; i++)
        	Value[i] = parser.ReadOffset< short >( 64 + i * 2 );
        Unknown6 = parser.ReadOffset< short >( 84 );
        Unknown7 = parser.ReadOffset< short >( 86 );
        Unknown8 = parser.ReadOffset< short >( 88 );
        Unknown9 = parser.ReadOffset< short >( 90 );
        Unknown10 = parser.ReadOffset< short >( 92 );
        Unknown11 = parser.ReadOffset< short >( 94 );
        BaseParam = new LazyRow< BaseParam >( gameData, parser.ReadOffset< byte >( 96 ), language );
        

    }
}