// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ChocoboRaceAbility", columnHash: 0xc68f9e95 )]
public partial class ChocoboRaceAbility : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public uint Icon { get; private set; }
    public byte Value { get; private set; }
    public LazyRow< ChocoboRaceAbilityType > ChocoboRaceAbilityType { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Icon = parser.ReadOffset< uint >( 8 );
        Value = parser.ReadOffset< byte >( 12 );
        ChocoboRaceAbilityType = new LazyRow< ChocoboRaceAbilityType >( gameData, parser.ReadOffset< sbyte >( 13 ), language );
        

    }
}