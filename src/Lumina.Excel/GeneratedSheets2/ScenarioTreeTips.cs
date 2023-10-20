// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ScenarioTreeTips", columnHash: 0x71371b8c )]
public partial class ScenarioTreeTips : ExcelRow
{
    
    public uint Tips1 { get; private set; }
    public LazyRow< ScenarioTree > Tips2 { get; private set; }
    public ushort Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Tips1 = parser.ReadOffset< uint >( 0 );
        Tips2 = new LazyRow< ScenarioTree >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 8 );
        Unknown1 = parser.ReadOffset< byte >( 10 );
        

    }
}