// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HWDDevLively", columnHash: 0xe18cbe18 )]
public partial class HWDDevLively : ExcelRow
{
    
    public LazyRow< ENpcBase > ENPC { get; private set; }
    public ushort Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ENPC = new LazyRow< ENpcBase >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 4 );
        Unknown1 = parser.ReadOffset< byte >( 6 );
        

    }
}