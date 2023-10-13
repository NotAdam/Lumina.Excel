// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FateEvent", columnHash: 0x0f779649 )]
public partial class FateEvent : ExcelRow
{
    public struct EventParametersStruct
    {
    	public uint Gesture { get; internal set; }
    	public int LipSync { get; internal set; }
    	public int Facial { get; internal set; }
    	public int Shape { get; internal set; }
    	public byte Turn { get; internal set; }
    	public byte WidgetType { get; internal set; }
    	public bool IsAutoShake { get; internal set; }
    }
    
    public EventParametersStruct[] EventParameters { get; private set; }
    public SeString[] Text { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        EventParameters = new EventParametersStruct[8];
        for (int i = 0; i < 8; i++)
        {
        	EventParameters[i].Gesture = parser.ReadOffset< uint >( (ushort) (i * 20 + 0));
        	EventParameters[i].LipSync = parser.ReadOffset< int >( (ushort) (i * 20 + 4));
        	EventParameters[i].Facial = parser.ReadOffset< int >( (ushort) (i * 20 + 8));
        	EventParameters[i].Shape = parser.ReadOffset< int >( (ushort) (i * 20 + 12));
        	EventParameters[i].Turn = parser.ReadOffset< byte >( (ushort) (i * 20 + 16));
        	EventParameters[i].WidgetType = parser.ReadOffset< byte >( (ushort) (i * 20 + 17));
        	EventParameters[i].IsAutoShake = parser.ReadOffset< bool >( (ushort) (i * 20 + 18));
        }
        Text = new SeString[8];
        for (int i = 0; i < 8; i++)
        	Text[i] = parser.ReadOffset< SeString >( 160 + i * 4 );
        

    }
}