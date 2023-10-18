// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "JobHudManualPriority", columnHash: 0x5be005ad )]
public partial class JobHudManualPriority : ExcelRow
{
    
    public LazyRow< JobHudManual >[] JobHudManual { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        JobHudManual = new LazyRow< JobHudManual >[3];
        for (int i = 0; i < 3; i++)
        	JobHudManual[i] = new LazyRow< JobHudManual >( gameData, parser.ReadOffset< byte >( (ushort) ( 0 + i * 1 ) ), language );
        Unknown0 = parser.ReadOffset< byte >( 3 );
        Unknown1 = parser.ReadOffset< byte >( 4 );
        

    }
}