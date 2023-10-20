// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BuddySkill", columnHash: 0xe3220ddc )]
public partial class BuddySkill : ExcelRow
{
    
    public ILazyRow Defender { get; private set; }
    public ILazyRow Attacker { get; private set; }
    public ILazyRow Healer { get; private set; }
    public byte BuddyLevel { get; private set; }
    public bool IsActive { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Defender = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< ushort >( 0 ), language, "Trait", "Action" );
        Attacker = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< ushort >( 2 ), language, "Trait", "Action" );
        Healer = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< ushort >( 4 ), language, "Trait", "Action" );
        BuddyLevel = parser.ReadOffset< byte >( 6 );
        IsActive = parser.ReadOffset< bool >( 7 );
        

    }
}