// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "NotoriousMonster", columnHash: 0x307c9206 )]
public partial class NotoriousMonster : ExcelRow
{
    
    public LazyRow< BNpcName > BNpcName { get; private set; }
    public LazyRow< BNpcBase > BNpcBase { get; private set; }
    public ushort Unknown3 { get; private set; }
    public byte Rank { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        BNpcName = new LazyRow< BNpcName >( gameData, parser.ReadOffset< uint >( 0 ), language );
        BNpcBase = new LazyRow< BNpcBase >( gameData, parser.ReadOffset< int >( 4 ), language );
        Unknown3 = parser.ReadOffset< ushort >( 8 );
        Rank = parser.ReadOffset< byte >( 10 );
        

    }
}