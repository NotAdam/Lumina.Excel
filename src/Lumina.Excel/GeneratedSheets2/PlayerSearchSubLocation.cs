// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PlayerSearchSubLocation", columnHash: 0x16a4252d )]
public partial class PlayerSearchSubLocation : ExcelRow
{
    
    public SeString Unknown3 { get; private set; }
    public SeString Unknown4 { get; private set; }
    public SeString Unknown5 { get; private set; }
    public int Unknown1 { get; private set; }
    public int Unknown2 { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown3 = parser.ReadOffset< SeString >( 0 );
        Unknown4 = parser.ReadOffset< SeString >( 4 );
        Unknown5 = parser.ReadOffset< SeString >( 8 );
        Unknown1 = parser.ReadOffset< int >( 12 );
        Unknown2 = parser.ReadOffset< int >( 16 );
        Unknown0 = parser.ReadOffset< byte >( 20 );
        

    }
}