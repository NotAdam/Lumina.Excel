// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FishingRecordType", columnHash: 0x2c75ba5d )]
public partial class FishingRecordType : ExcelRow
{
    
    public LazyRow< Addon > Addon { get; private set; }
    public ushort RankBRequirement { get; private set; }
    public ushort RankARequirement { get; private set; }
    public ushort RankAARequirement { get; private set; }
    public ushort RankAAARequirement { get; private set; }
    public ushort RankSRequirement { get; private set; }
    public byte IsSpearfishing { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Addon = new LazyRow< Addon >( gameData, parser.ReadOffset< int >( 0 ), language );
        RankBRequirement = parser.ReadOffset< ushort >( 4 );
        RankARequirement = parser.ReadOffset< ushort >( 6 );
        RankAARequirement = parser.ReadOffset< ushort >( 8 );
        RankAAARequirement = parser.ReadOffset< ushort >( 10 );
        RankSRequirement = parser.ReadOffset< ushort >( 12 );
        IsSpearfishing = parser.ReadOffset< byte >( 14 );
        

    }
}