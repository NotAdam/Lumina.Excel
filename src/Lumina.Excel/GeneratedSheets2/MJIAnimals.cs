// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIAnimals", columnHash: 0xeae74967 )]
public partial class MJIAnimals : ExcelRow
{
    
    public LazyRow< BNpcBase > BNpcBase { get; private set; }
    public LazyRow< Item >[] Reward { get; private set; }
    public int Icon { get; private set; }
    public byte Size { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        BNpcBase = new LazyRow< BNpcBase >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Reward = new LazyRow< Item >[2];
        for (int i = 0; i < 2; i++)
        	Reward[i] = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( (ushort) ( 4 + i * 4 ) ), language );
        Icon = parser.ReadOffset< int >( 12 );
        Size = parser.ReadOffset< byte >( 16 );
        Unknown0 = parser.ReadOffset< byte >( 17 );
        Unknown1 = parser.ReadOffset< byte >( 18 );
        

    }
}