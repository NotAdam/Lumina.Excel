// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "IKDContentBonus", columnHash: 0xb7d9b7a3 )]
public partial class IKDContentBonus : ExcelRow
{
    
    public SeString Objective { get; private set; }
    public SeString Requirement { get; private set; }
    public uint Image { get; private set; }
    public ushort Unknown2 { get; private set; }
    public byte Order { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Objective = parser.ReadOffset< SeString >( 0 );
        Requirement = parser.ReadOffset< SeString >( 4 );
        Image = parser.ReadOffset< uint >( 8 );
        Unknown2 = parser.ReadOffset< ushort >( 12 );
        Order = parser.ReadOffset< byte >( 14 );
        

    }
}