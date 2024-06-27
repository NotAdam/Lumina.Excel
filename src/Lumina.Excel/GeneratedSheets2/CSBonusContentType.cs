// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CSBonusContentType", columnHash: 0x9ff5145f )]
public partial class CSBonusContentType : ExcelRow
{
    
    public LazyRow< Addon >[] Dialogue { get; private set; }
    public uint Image { get; private set; }
    public LazyRow< Quest > UnlockQuest { get; private set; }
    public uint Unknown11 { get; private set; }
    public uint Unknown12 { get; private set; }
    public LazyRow< ContentType > ContentType { get; private set; }
    public bool Unknown6 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Dialogue = new LazyRow< Addon >[4];
        for (int i = 0; i < 4; i++)
        	Dialogue[i] = new LazyRow< Addon >( gameData, parser.ReadOffset< uint >( (ushort) ( 0 + i * 4 ) ), language );
        Image = parser.ReadOffset< uint >( 16 );
        UnlockQuest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 20 ), language );
        Unknown11 = parser.ReadOffset< uint >( 24 );
        Unknown12 = parser.ReadOffset< uint >( 28 );
        ContentType = new LazyRow< ContentType >( gameData, parser.ReadOffset< byte >( 32 ), language );
        Unknown6 = parser.ReadOffset< bool >( 33 );
        

    }
}