// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CSBonusContent", columnHash: 0xf8d2be91 )]
public partial class CSBonusContent : ExcelRow
{
    
    public int Score1 { get; private set; }
    public int Score2 { get; private set; }
    public int Score3 { get; private set; }
    public int Score4 { get; private set; }
    public int Score5 { get; private set; }
    public LazyRow< CSBonusContentIdentifier > Content0 { get; private set; }
    public LazyRow< CSBonusContentIdentifier > Content1 { get; private set; }
    public ushort Score0 { get; private set; }
    public LazyRow< CSBonusContentType > ContentType { get; private set; }
    public byte RewardCount0 { get; private set; }
    public byte RewardCount1 { get; private set; }
    public byte RewardCount2 { get; private set; }
    public byte RewardCount3 { get; private set; }
    public byte RewardCount4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Score1 = parser.ReadOffset< int >( 0 );
        Score2 = parser.ReadOffset< int >( 4 );
        Score3 = parser.ReadOffset< int >( 8 );
        Score4 = parser.ReadOffset< int >( 12 );
        Score5 = parser.ReadOffset< int >( 16 );
        Content0 = new LazyRow< CSBonusContentIdentifier >( gameData, parser.ReadOffset< ushort >( 20 ), language );
        Content1 = new LazyRow< CSBonusContentIdentifier >( gameData, parser.ReadOffset< ushort >( 22 ), language );
        Score0 = parser.ReadOffset< ushort >( 24 );
        ContentType = new LazyRow< CSBonusContentType >( gameData, parser.ReadOffset< byte >( 26 ), language );
        RewardCount0 = parser.ReadOffset< byte >( 27 );
        RewardCount1 = parser.ReadOffset< byte >( 28 );
        RewardCount2 = parser.ReadOffset< byte >( 29 );
        RewardCount3 = parser.ReadOffset< byte >( 30 );
        RewardCount4 = parser.ReadOffset< byte >( 31 );
        

    }
}