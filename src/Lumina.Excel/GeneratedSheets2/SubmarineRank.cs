// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SubmarineRank", columnHash: 0x697b9c75 )]
public partial class SubmarineRank : ExcelRow
{
    
    public uint ExpToNext { get; private set; }
    public ushort Capacity { get; private set; }
    public byte SurveillanceBonus { get; private set; }
    public byte RetrievalBonus { get; private set; }
    public byte SpeedBonus { get; private set; }
    public byte RangeBonus { get; private set; }
    public byte FavorBonus { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ExpToNext = parser.ReadOffset< uint >( 0 );
        Capacity = parser.ReadOffset< ushort >( 4 );
        SurveillanceBonus = parser.ReadOffset< byte >( 6 );
        RetrievalBonus = parser.ReadOffset< byte >( 7 );
        SpeedBonus = parser.ReadOffset< byte >( 8 );
        RangeBonus = parser.ReadOffset< byte >( 9 );
        FavorBonus = parser.ReadOffset< byte >( 10 );
        

    }
}