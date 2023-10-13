// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ResistanceWeaponAdjust", columnHash: 0x8fc095f4 )]
public partial class ResistanceWeaponAdjust : ExcelRow
{
    
    public uint Image { get; private set; }
    public ushort MaxTotalStats { get; private set; }
    public ushort MaxEachStat { get; private set; }
    public LazyRow< BaseParam >[] BaseParam { get; private set; }
    public byte Unknown7 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Image = parser.ReadOffset< uint >( 0 );
        MaxTotalStats = parser.ReadOffset< ushort >( 4 );
        MaxEachStat = parser.ReadOffset< ushort >( 6 );
        BaseParam = new LazyRow< BaseParam >[4];
        for (int i = 0; i < 4; i++)
        	BaseParam[i] = new LazyRow< BaseParam >( gameData, parser.ReadOffset< byte >( (ushort) ( 8 + i * 1 ) ), language );
        Unknown7 = parser.ReadOffset< byte >( 12 );
        

    }
}