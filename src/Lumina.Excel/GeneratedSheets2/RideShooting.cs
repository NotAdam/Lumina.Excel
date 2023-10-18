// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RideShooting", columnHash: 0xdd593ecd )]
public partial class RideShooting : ExcelRow
{
    public struct RideShootingParamsStruct
    {
    	public uint Unknown0 { get; internal set; }
    	public uint PopRange { get; internal set; }
    	public LazyRow< ENpcBase > ENpc { get; internal set; }
    	public uint Unknown1 { get; internal set; }
    	public uint Unknown2 { get; internal set; }
    	public uint Unknown3 { get; internal set; }
    	public uint Unknown4 { get; internal set; }
    	public uint Unknown5 { get; internal set; }
    	public byte ENpcScale { get; internal set; }
    	public byte Unknown6 { get; internal set; }
    	public byte Unknown7 { get; internal set; }
    	public byte Unknown8 { get; internal set; }
    	public byte Unknown9 { get; internal set; }
    	public byte Unknown10 { get; internal set; }
    }
    
    public RideShootingParamsStruct[] RideShootingParams { get; private set; }
    public LazyRow< GFateRideShooting > GFateRideShooting { get; private set; }
    public ushort Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public LazyRow< RideShootingTextData > StartText { get; private set; }
    public short Unknown2 { get; private set; }
    public short Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        RideShootingParams = new RideShootingParamsStruct[8];
        for (int i = 0; i < 8; i++)
        {
        	RideShootingParams[i].Unknown0 = parser.ReadOffset< uint >( (ushort) (i * 40 + 0));
        	RideShootingParams[i].PopRange = parser.ReadOffset< uint >( (ushort) (i * 40 + 4));
        	RideShootingParams[i].ENpc = new LazyRow< ENpcBase >( gameData, parser.ReadOffset< uint >( (ushort) (i * 40 + 8) ), language );
        	RideShootingParams[i].Unknown1 = parser.ReadOffset< uint >( (ushort) (i * 40 + 12));
        	RideShootingParams[i].Unknown2 = parser.ReadOffset< uint >( (ushort) (i * 40 + 16));
        	RideShootingParams[i].Unknown3 = parser.ReadOffset< uint >( (ushort) (i * 40 + 20));
        	RideShootingParams[i].Unknown4 = parser.ReadOffset< uint >( (ushort) (i * 40 + 24));
        	RideShootingParams[i].Unknown5 = parser.ReadOffset< uint >( (ushort) (i * 40 + 28));
        	RideShootingParams[i].ENpcScale = parser.ReadOffset< byte >( (ushort) (i * 40 + 32));
        	RideShootingParams[i].Unknown6 = parser.ReadOffset< byte >( (ushort) (i * 40 + 33));
        	RideShootingParams[i].Unknown7 = parser.ReadOffset< byte >( (ushort) (i * 40 + 34));
        	RideShootingParams[i].Unknown8 = parser.ReadOffset< byte >( (ushort) (i * 40 + 35));
        	RideShootingParams[i].Unknown9 = parser.ReadOffset< byte >( (ushort) (i * 40 + 36));
        	RideShootingParams[i].Unknown10 = parser.ReadOffset< byte >( (ushort) (i * 40 + 37));
        }
        GFateRideShooting = new LazyRow< GFateRideShooting >( gameData, parser.ReadOffset< ushort >( 320 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 322 );
        Unknown1 = parser.ReadOffset< ushort >( 324 );
        StartText = new LazyRow< RideShootingTextData >( gameData, parser.ReadOffset< ushort >( 326 ), language );
        Unknown2 = parser.ReadOffset< short >( 328 );
        Unknown3 = parser.ReadOffset< short >( 330 );
        

    }
}