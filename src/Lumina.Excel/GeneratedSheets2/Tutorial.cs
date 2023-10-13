// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Tutorial", columnHash: 0x871b8a1c )]
public partial class Tutorial : ExcelRow
{
    
    public uint Exp { get; private set; }
    public uint Gil { get; private set; }
    public LazyRow< Item > RewardTank { get; private set; }
    public LazyRow< Item > RewardMelee { get; private set; }
    public LazyRow< Item > RewardRanged { get; private set; }
    public LazyRow< InstanceContentTextData > Objective { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Exp = parser.ReadOffset< uint >( 0 );
        Gil = parser.ReadOffset< uint >( 4 );
        RewardTank = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 8 ), language );
        RewardMelee = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 12 ), language );
        RewardRanged = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 16 ), language );
        Objective = new LazyRow< InstanceContentTextData >( gameData, parser.ReadOffset< uint >( 20 ), language );
        Unknown0 = parser.ReadOffset< byte >( 24 );
        Unknown1 = parser.ReadOffset< byte >( 25 );
        Unknown2 = parser.ReadOffset< byte >( 26 );
        Unknown3 = parser.ReadOffset< byte >( 27 );
        

    }
}