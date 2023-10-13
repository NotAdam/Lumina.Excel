// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Snipe", columnHash: 0x88d50061 )]
public partial class Snipe : ExcelRow
{
    public struct SnipeDataStruct
    {
    	public uint DataEventNPC { get; internal set; }
    	public ushort Unknown25 { get; internal set; }
    	public ushort Unknown33 { get; internal set; }
    	public ushort Unknown49 { get; internal set; }
    	public ushort Unknown57 { get; internal set; }
    	public byte Unknown41 { get; internal set; }
    	public byte Unknown65 { get; internal set; }
    }
    
    public SnipeDataStruct[] SnipeData { get; private set; }
    public uint[] EventNPC { get; private set; }
    public uint Unknown89 { get; private set; }
    public ushort Unknown81 { get; private set; }
    public byte Unknown85 { get; private set; }
    public uint Unknown90 { get; private set; }
    public ushort Unknown82 { get; private set; }
    public byte Unknown86 { get; private set; }
    public uint Unknown91 { get; private set; }
    public ushort Unknown83 { get; private set; }
    public byte Unknown87 { get; private set; }
    public uint Unknown92 { get; private set; }
    public ushort Unknown84 { get; private set; }
    public byte Unknown88 { get; private set; }
    public SeString Objective0 { get; private set; }
    public SeString Hint0 { get; private set; }
    public SeString Objective1 { get; private set; }
    public SeString Hint1 { get; private set; }
    public SeString Unknown97 { get; private set; }
    public SeString Unknown98 { get; private set; }
    public SeString Unknown99 { get; private set; }
    public SeString Unknown100 { get; private set; }
    public SeString Unknown101 { get; private set; }
    public SeString Unknown102 { get; private set; }
    public SeString Unknown103 { get; private set; }
    public SeString ActionText { get; private set; }
    public byte Unknown105 { get; private set; }
    public byte Unknown106 { get; private set; }
    public SeString VFXFire { get; private set; }
    public SeString VFXHit { get; private set; }
    public SeString VFXMiss { get; private set; }
    public SeString VFXAdditional { get; private set; }
    public uint LGBTargetMarker { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ushort Unknown8 { get; private set; }
    public ushort Unknown15 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown16 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SnipeData = new SnipeDataStruct[8];
        for (int i = 0; i < 8; i++)
        {
        	SnipeData[i].DataEventNPC = parser.ReadOffset< uint >( (ushort) (i * 16 + 0));
        	SnipeData[i].Unknown25 = parser.ReadOffset< ushort >( (ushort) (i * 16 + 4));
        	SnipeData[i].Unknown33 = parser.ReadOffset< ushort >( (ushort) (i * 16 + 6));
        	SnipeData[i].Unknown49 = parser.ReadOffset< ushort >( (ushort) (i * 16 + 8));
        	SnipeData[i].Unknown57 = parser.ReadOffset< ushort >( (ushort) (i * 16 + 10));
        	SnipeData[i].Unknown41 = parser.ReadOffset< byte >( (ushort) (i * 16 + 12));
        	SnipeData[i].Unknown65 = parser.ReadOffset< byte >( (ushort) (i * 16 + 13));
        }
        EventNPC = new uint[8];
        for (int i = 0; i < 8; i++)
        	EventNPC[i] = parser.ReadOffset< uint >( 128 + i * 4 );
        Unknown89 = parser.ReadOffset< uint >( 160 );
        Unknown81 = parser.ReadOffset< ushort >( 164 );
        Unknown85 = parser.ReadOffset< byte >( 166 );
        Unknown90 = parser.ReadOffset< uint >( 168 );
        Unknown82 = parser.ReadOffset< ushort >( 172 );
        Unknown86 = parser.ReadOffset< byte >( 174 );
        Unknown91 = parser.ReadOffset< uint >( 176 );
        Unknown83 = parser.ReadOffset< ushort >( 180 );
        Unknown87 = parser.ReadOffset< byte >( 182 );
        Unknown92 = parser.ReadOffset< uint >( 184 );
        Unknown84 = parser.ReadOffset< ushort >( 188 );
        Unknown88 = parser.ReadOffset< byte >( 190 );
        Objective0 = parser.ReadOffset< SeString >( 192 );
        Hint0 = parser.ReadOffset< SeString >( 196 );
        Objective1 = parser.ReadOffset< SeString >( 200 );
        Hint1 = parser.ReadOffset< SeString >( 204 );
        Unknown97 = parser.ReadOffset< SeString >( 208 );
        Unknown98 = parser.ReadOffset< SeString >( 212 );
        Unknown99 = parser.ReadOffset< SeString >( 216 );
        Unknown100 = parser.ReadOffset< SeString >( 220 );
        Unknown101 = parser.ReadOffset< SeString >( 224 );
        Unknown102 = parser.ReadOffset< SeString >( 228 );
        Unknown103 = parser.ReadOffset< SeString >( 232 );
        ActionText = parser.ReadOffset< SeString >( 236 );
        Unknown105 = parser.ReadOffset< byte >( 240 );
        Unknown106 = parser.ReadOffset< byte >( 241 );
        VFXFire = parser.ReadOffset< SeString >( 244 );
        VFXHit = parser.ReadOffset< SeString >( 248 );
        VFXMiss = parser.ReadOffset< SeString >( 252 );
        VFXAdditional = parser.ReadOffset< SeString >( 256 );
        LGBTargetMarker = parser.ReadOffset< uint >( 260 );
        Unknown1 = parser.ReadOffset< ushort >( 264 );
        Unknown8 = parser.ReadOffset< ushort >( 266 );
        Unknown15 = parser.ReadOffset< ushort >( 268 );
        Unknown3 = parser.ReadOffset< byte >( 270 );
        Unknown4 = parser.ReadOffset< byte >( 271 );
        Unknown5 = parser.ReadOffset< byte >( 272 );
        Unknown6 = parser.ReadOffset< byte >( 273 );
        Unknown7 = parser.ReadOffset< byte >( 274 );
        Unknown9 = parser.ReadOffset< byte >( 275 );
        Unknown10 = parser.ReadOffset< byte >( 276 );
        Unknown2 = parser.ReadOffset< bool >( 277 );
        Unknown16 = parser.ReadOffset< bool >( 277, 2 );
        

    }
}