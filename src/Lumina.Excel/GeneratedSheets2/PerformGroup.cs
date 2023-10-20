// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PerformGroup", columnHash: 0x5be005ad )]
public partial class PerformGroup : ExcelRow
{
    
    public LazyRow< Perform >[] Perform { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Perform = new LazyRow< Perform >[5];
        for (int i = 0; i < 5; i++)
        	Perform[i] = new LazyRow< Perform >( gameData, parser.ReadOffset< byte >( (ushort) ( 0 + i * 1 ) ), language );
        

    }
}