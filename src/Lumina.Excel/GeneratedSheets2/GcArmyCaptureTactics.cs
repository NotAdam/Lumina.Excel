// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GcArmyCaptureTactics", columnHash: 0x62bcfbad )]
public partial class GcArmyCaptureTactics : ExcelRow
{
    
    public LazyRow< Addon > Tactic { get; private set; }
    public uint Icon { get; private set; }
    public LazyRow< Status > Name { get; private set; }
    public byte HP { get; private set; }
    public byte DamageDealt { get; private set; }
    public byte DamageReceived { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Tactic = new LazyRow< Addon >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Icon = parser.ReadOffset< uint >( 4 );
        Name = new LazyRow< Status >( gameData, parser.ReadOffset< int >( 8 ), language );
        HP = parser.ReadOffset< byte >( 12 );
        DamageDealt = parser.ReadOffset< byte >( 13 );
        DamageReceived = parser.ReadOffset< byte >( 14 );
        

    }
}