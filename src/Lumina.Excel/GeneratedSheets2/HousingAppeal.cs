// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HousingAppeal", columnHash: 0xb89097b5 )]
public partial class HousingAppeal : ExcelRow
{
    
    public SeString Tag { get; private set; }
    public uint Icon { get; private set; }
    public byte Order { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Tag = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< uint >( 4 );
        Order = parser.ReadOffset< byte >( 8 );
        

    }
}