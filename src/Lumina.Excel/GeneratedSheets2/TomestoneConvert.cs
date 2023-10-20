// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TomestoneConvert", columnHash: 0xa1a07272 )]
public partial class TomestoneConvert : ExcelRow
{
    
    public SeString Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< SeString >( 0 );
        Unknown1 = parser.ReadOffset< byte >( 4 );
        Unknown2 = parser.ReadOffset< byte >( 5 );
        Unknown3 = parser.ReadOffset< byte >( 6 );
        Unknown4 = parser.ReadOffset< bool >( 7 );
        

    }
}