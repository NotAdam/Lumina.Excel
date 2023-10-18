// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HWDAnnounce", columnHash: 0x1d91a784 )]
public partial class HWDAnnounce : ExcelRow
{
    
    public SeString Name { get; private set; }
    public LazyRow< ENpcResident > ENPC { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        ENPC = new LazyRow< ENpcResident >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Unknown0 = parser.ReadOffset< byte >( 8 );
        Unknown1 = parser.ReadOffset< byte >( 9 );
        

    }
}