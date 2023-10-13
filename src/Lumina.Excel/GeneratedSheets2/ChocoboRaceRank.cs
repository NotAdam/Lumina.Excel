// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ChocoboRaceRank", columnHash: 0xf840eabf )]
public partial class ChocoboRaceRank : ExcelRow
{
    
    public int Icon { get; private set; }
    public ushort RatingMin { get; private set; }
    public ushort RatingMax { get; private set; }
    public LazyRow< GoldSaucerTextData > Name { get; private set; }
    public ushort Fee { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Icon = parser.ReadOffset< int >( 0 );
        RatingMin = parser.ReadOffset< ushort >( 4 );
        RatingMax = parser.ReadOffset< ushort >( 6 );
        Name = new LazyRow< GoldSaucerTextData >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        Fee = parser.ReadOffset< ushort >( 10 );
        

    }
}