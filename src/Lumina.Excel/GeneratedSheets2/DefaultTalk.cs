// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DefaultTalk", columnHash: 0xe6dec88d )]
public partial class DefaultTalk : ExcelRow
{
    public struct DefaultTalkParamsStruct
    {
    	public LazyRow< ActionTimeline > ActionTimelinePose { get; internal set; }
    	public ushort Unknown1 { get; internal set; }
    	public byte Unknown2 { get; internal set; }
    	public byte Unknown3 { get; internal set; }
    	public byte Unknown4 { get; internal set; }
    	public bool Unknown5 { get; internal set; }
    }
    
    public DefaultTalkParamsStruct[] DefaultTalkParams { get; private set; }
    public SeString[] Text { get; private set; }
    public uint Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        DefaultTalkParams = new DefaultTalkParamsStruct[3];
        for (int i = 0; i < 3; i++)
        {
        	DefaultTalkParams[i].ActionTimelinePose = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( (ushort) (i * 8 + 0) ), language );
        	DefaultTalkParams[i].Unknown1 = parser.ReadOffset< ushort >( (ushort) (i * 8 + 2));
        	DefaultTalkParams[i].Unknown2 = parser.ReadOffset< byte >( (ushort) (i * 8 + 4));
        	DefaultTalkParams[i].Unknown3 = parser.ReadOffset< byte >( (ushort) (i * 8 + 5));
        	DefaultTalkParams[i].Unknown4 = parser.ReadOffset< byte >( (ushort) (i * 8 + 6));
        	DefaultTalkParams[i].Unknown5 = parser.ReadOffset< bool >( (ushort) (i * 8 + 7));
        }
        Text = new SeString[3];
        for (int i = 0; i < 3; i++)
        	Text[i] = parser.ReadOffset< SeString >( 24 + i * 4 );
        Unknown0 = parser.ReadOffset< uint >( 36 );
        Unknown1 = parser.ReadOffset< byte >( 40 );
        

    }
}