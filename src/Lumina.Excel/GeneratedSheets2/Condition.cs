// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Condition", columnHash: 0xf234a002 )]
public partial class Condition : ExcelRow
{
    
    public LazyRow< LogMessage > LogMessage { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown3 { get; private set; }
    public bool Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        LogMessage = new LazyRow< LogMessage >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown1 = parser.ReadOffset< byte >( 4 );
        Unknown3 = parser.ReadOffset< byte >( 5 );
        Unknown0 = parser.ReadOffset< bool >( 6 );
        

    }
}