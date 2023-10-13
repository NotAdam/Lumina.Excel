// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ChocoboRaceTutorial", columnHash: 0xef6c7b71 )]
public partial class ChocoboRaceTutorial : ExcelRow
{
    
    public LazyRow< NpcYell >[] NpcYell { get; private set; }
    public ushort Unknown8 { get; private set; }
    public ushort Unknown9 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        NpcYell = new LazyRow< NpcYell >[8];
        for (int i = 0; i < 8; i++)
        	NpcYell[i] = new LazyRow< NpcYell >( gameData, parser.ReadOffset< int >( (ushort) ( 0 + i * 4 ) ), language );
        Unknown8 = parser.ReadOffset< ushort >( 32 );
        Unknown9 = parser.ReadOffset< ushort >( 34 );
        

    }
}