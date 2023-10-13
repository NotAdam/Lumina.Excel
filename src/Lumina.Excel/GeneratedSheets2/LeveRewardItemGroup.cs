// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "LeveRewardItemGroup", columnHash: 0xf065e622 )]
public partial class LeveRewardItemGroup : ExcelRow
{
    
    public LazyRow< Item >[] Item { get; private set; }
    public byte[] Count { get; private set; }
    public bool[] IsHQ { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >[9];
        for (int i = 0; i < 9; i++)
        	Item[i] = new LazyRow< Item >( gameData, parser.ReadOffset< int >( (ushort) ( 0 + i * 4 ) ), language );
        Count = new byte[9];
        for (int i = 0; i < 9; i++)
        	Count[i] = parser.ReadOffset< byte >( 36 + i * 1 );
        IsHQ = new bool[9];
        for (int i = 0; i < 9; i++)
        	IsHQ[i] = parser.ReadOffset< bool >( 45 + i * 1 );
        

    }
}