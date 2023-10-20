// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BuddyAction", columnHash: 0x9a695bec )]
public partial class BuddyAction : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public int Icon { get; private set; }
    public int IconStatus { get; private set; }
    public ushort Reward { get; private set; }
    public byte Sort { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Icon = parser.ReadOffset< int >( 8 );
        IconStatus = parser.ReadOffset< int >( 12 );
        Reward = parser.ReadOffset< ushort >( 16 );
        Sort = parser.ReadOffset< byte >( 18 );
        

    }
}