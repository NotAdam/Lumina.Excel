// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "WeeklyBingoOrderData", columnHash: 0xe0f2b530 )]
public partial class WeeklyBingoOrderData : ExcelRow
{
    
    public uint Type { get; private set; }
    public ILazyRow Data { get; private set; }
    public uint Icon { get; private set; }
    public byte Unknown0 { get; private set; }
    public LazyRow< WeeklyBingoText > Text { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Type = parser.ReadOffset< uint >( 0 );
        var DataRowId = parser.ReadOffset< uint >( 4 );
        Icon = parser.ReadOffset< uint >( 8 );
        Unknown0 = parser.ReadOffset< byte >( 12 );
        Text = new LazyRow< WeeklyBingoText >( gameData, parser.ReadOffset< byte >( 13 ), language );
        Unknown1 = parser.ReadOffset< byte >( 14 );
        
        Data = Type switch
        {
        	0 => new LazyRow< InstanceContent >( gameData, DataRowId, language ),
        	_ => new EmptyLazyRow( (uint) DataRowId ),
        };
    }
}