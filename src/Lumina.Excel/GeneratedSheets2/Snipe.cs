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
    	public ushort Unknown0 { get; internal set; }
    	public ushort Unknown1 { get; internal set; }
    	public ushort Unknown2 { get; internal set; }
    	public ushort Unknown3 { get; internal set; }
    	public byte Unknown4 { get; internal set; }
    	public byte Unknown5 { get; internal set; }
    }
    
    public SnipeDataStruct[] SnipeData { get; private set; }
    public uint[] EventNPC { get; private set; }
    public uint Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public uint Unknown6 { get; private set; }
    public ushort Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public uint Unknown9 { get; private set; }
    public ushort Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public SeString Objective0 { get; private set; }
    public SeString Hint0 { get; private set; }
    public SeString Objective1 { get; private set; }
    public SeString Hint1 { get; private set; }
    public SeString Unknown12 { get; private set; }
    public SeString Unknown13 { get; private set; }
    public SeString Unknown14 { get; private set; }
    public SeString Unknown15 { get; private set; }
    public SeString Unknown16 { get; private set; }
    public SeString Unknown17 { get; private set; }
    public SeString Unknown18 { get; private set; }
    public SeString ActionText { get; private set; }
    public byte Unknown19 { get; private set; }
    public byte Unknown20 { get; private set; }
    public SeString VFXFire { get; private set; }
    public SeString VFXHit { get; private set; }
    public SeString VFXMiss { get; private set; }
    public SeString VFXAdditional { get; private set; }
    public uint LGBTargetMarker { get; private set; }
    public ushort Unknown21 { get; private set; }
    public ushort Unknown22 { get; private set; }
    public ushort Unknown23 { get; private set; }
    public byte Unknown24 { get; private set; }
    public byte Unknown25 { get; private set; }
    public byte Unknown26 { get; private set; }
    public byte Unknown27 { get; private set; }
    public byte Unknown28 { get; private set; }
    public byte Unknown29 { get; private set; }
    public byte Unknown30 { get; private set; }
    public bool Unknown31 { get; private set; }
    public bool Unknown32 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SnipeData = new SnipeDataStruct[8];
        for (int i = 0; i < 8; i++)
        {
        	SnipeData[i].DataEventNPC = parser.ReadOffset< uint >( (ushort) (i * 16 + 0));
        	SnipeData[i].Unknown0 = parser.ReadOffset< ushort >( (ushort) (i * 16 + 4));
        	SnipeData[i].Unknown1 = parser.ReadOffset< ushort >( (ushort) (i * 16 + 6));
        	SnipeData[i].Unknown2 = parser.ReadOffset< ushort >( (ushort) (i * 16 + 8));
        	SnipeData[i].Unknown3 = parser.ReadOffset< ushort >( (ushort) (i * 16 + 10));
        	SnipeData[i].Unknown4 = parser.ReadOffset< byte >( (ushort) (i * 16 + 12));
        	SnipeData[i].Unknown5 = parser.ReadOffset< byte >( (ushort) (i * 16 + 13));
        }
        EventNPC = new uint[8];
        for (int i = 0; i < 8; i++)
        	EventNPC[i] = parser.ReadOffset< uint >( 128 + i * 4 );
        Unknown0 = parser.ReadOffset< uint >( 160 );
        Unknown1 = parser.ReadOffset< ushort >( 164 );
        Unknown2 = parser.ReadOffset< byte >( 166 );
        Unknown3 = parser.ReadOffset< uint >( 168 );
        Unknown4 = parser.ReadOffset< ushort >( 172 );
        Unknown5 = parser.ReadOffset< byte >( 174 );
        Unknown6 = parser.ReadOffset< uint >( 176 );
        Unknown7 = parser.ReadOffset< ushort >( 180 );
        Unknown8 = parser.ReadOffset< byte >( 182 );
        Unknown9 = parser.ReadOffset< uint >( 184 );
        Unknown10 = parser.ReadOffset< ushort >( 188 );
        Unknown11 = parser.ReadOffset< byte >( 190 );
        Objective0 = parser.ReadOffset< SeString >( 192 );
        Hint0 = parser.ReadOffset< SeString >( 196 );
        Objective1 = parser.ReadOffset< SeString >( 200 );
        Hint1 = parser.ReadOffset< SeString >( 204 );
        Unknown12 = parser.ReadOffset< SeString >( 208 );
        Unknown13 = parser.ReadOffset< SeString >( 212 );
        Unknown14 = parser.ReadOffset< SeString >( 216 );
        Unknown15 = parser.ReadOffset< SeString >( 220 );
        Unknown16 = parser.ReadOffset< SeString >( 224 );
        Unknown17 = parser.ReadOffset< SeString >( 228 );
        Unknown18 = parser.ReadOffset< SeString >( 232 );
        ActionText = parser.ReadOffset< SeString >( 236 );
        Unknown19 = parser.ReadOffset< byte >( 240 );
        Unknown20 = parser.ReadOffset< byte >( 241 );
        VFXFire = parser.ReadOffset< SeString >( 244 );
        VFXHit = parser.ReadOffset< SeString >( 248 );
        VFXMiss = parser.ReadOffset< SeString >( 252 );
        VFXAdditional = parser.ReadOffset< SeString >( 256 );
        LGBTargetMarker = parser.ReadOffset< uint >( 260 );
        Unknown21 = parser.ReadOffset< ushort >( 264 );
        Unknown22 = parser.ReadOffset< ushort >( 266 );
        Unknown23 = parser.ReadOffset< ushort >( 268 );
        Unknown24 = parser.ReadOffset< byte >( 270 );
        Unknown25 = parser.ReadOffset< byte >( 271 );
        Unknown26 = parser.ReadOffset< byte >( 272 );
        Unknown27 = parser.ReadOffset< byte >( 273 );
        Unknown28 = parser.ReadOffset< byte >( 274 );
        Unknown29 = parser.ReadOffset< byte >( 275 );
        Unknown30 = parser.ReadOffset< byte >( 276 );
        Unknown31 = parser.ReadOffset< bool >( 277 );
        Unknown32 = parser.ReadOffset< bool >( 277, 2 );
        

    }
}