// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "OrchestrionCategory", columnHash: 0x005990e4 )]
public partial class OrchestrionCategory : ExcelRow
{
    
    public SeString Name { get; private set; }
    public uint Icon { get; private set; }
    public byte HideOrder { get; private set; }
    public byte Order { get; private set; }
    public bool Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< uint >( 4 );
        HideOrder = parser.ReadOffset< byte >( 8 );
        Order = parser.ReadOffset< byte >( 9 );
        Unknown4 = parser.ReadOffset< bool >( 10 );
        

    }
}