// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RacingChocoboNameInfo", columnHash: 0x171828cf )]
public partial class RacingChocoboNameInfo : ExcelRow
{
    
    public LazyRow< RacingChocoboName >[] Name { get; private set; }
    public LazyRow< RacingChocoboNameCategory > RacingChocoboNameCategory { get; private set; }
    public bool Unknown0 { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = new LazyRow< RacingChocoboName >[3];
        for (int i = 0; i < 3; i++)
        	Name[i] = new LazyRow< RacingChocoboName >( gameData, parser.ReadOffset< ushort >( (ushort) ( 0 + i * 2 ) ), language );
        RacingChocoboNameCategory = new LazyRow< RacingChocoboNameCategory >( gameData, parser.ReadOffset< byte >( 6 ), language );
        Unknown0 = parser.ReadOffset< bool >( 7 );
        Unknown1 = parser.ReadOffset< bool >( 8 );
        Unknown2 = parser.ReadOffset< bool >( 9 );
        Unknown3 = parser.ReadOffset< bool >( 10 );
        

    }
}