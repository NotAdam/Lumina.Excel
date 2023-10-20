// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Calendar", columnHash: 0x005cfabb )]
public partial class Calendar : ExcelRow
{
    public struct CalendarStructStruct
    {
    	public byte Month { get; internal set; }
    	public byte Day { get; internal set; }
    }
    
    public CalendarStructStruct[] CalendarStruct { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        CalendarStruct = new CalendarStructStruct[32];
        for (int i = 0; i < 32; i++)
        {
        	CalendarStruct[i].Month = parser.ReadOffset< byte >( (ushort) (i * 2 + 0));
        	CalendarStruct[i].Day = parser.ReadOffset< byte >( (ushort) (i * 2 + 1));
        }
        

    }
}