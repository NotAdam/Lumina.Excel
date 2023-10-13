// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RideShootingTargetType", columnHash: 0x213f343d )]
public partial class RideShootingTargetType : ExcelRow
{
    
    public LazyRow< EObj > EObj { get; private set; }
    public short Score { get; private set; }
    public short Unknown2 { get; private set; }
    public short Unknown3 { get; private set; }
    public short Unknown4 { get; private set; }
    public short Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        EObj = new LazyRow< EObj >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Score = parser.ReadOffset< short >( 4 );
        Unknown2 = parser.ReadOffset< short >( 6 );
        Unknown3 = parser.ReadOffset< short >( 8 );
        Unknown4 = parser.ReadOffset< short >( 10 );
        Unknown5 = parser.ReadOffset< short >( 12 );
        

    }
}