// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GFATE", columnHash: 0x440a2c22 )]
public partial class GFATE : ExcelRow
{
    public struct GFATEParamsStruct
    {
    	public LazyRow< Level > LGBPopRange { get; internal set; }
    	public uint Icon { get; internal set; }
    	public bool Unknown0 { get; internal set; }
    	public bool Unknown1 { get; internal set; }
    	public bool Unknown2 { get; internal set; }
    }
    
    public GFATEParamsStruct[] GFATEParams { get; private set; }
    public uint Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public uint Unknown5 { get; private set; }
    public uint Unknown6 { get; private set; }
    public ushort Unknown7 { get; private set; }
    public ushort Unknown8 { get; private set; }
    public ushort Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        GFATEParams = new GFATEParamsStruct[15];
        for (int i = 0; i < 15; i++)
        {
        	GFATEParams[i].LGBPopRange = new LazyRow< Level >( gameData, parser.ReadOffset< uint >( (ushort) (i * 12 + 0) ), language );
        	GFATEParams[i].Icon = parser.ReadOffset< uint >( (ushort) (i * 12 + 4));
        	GFATEParams[i].Unknown0 = parser.ReadOffset< bool >( (ushort) (i * 12 + 8));
        	GFATEParams[i].Unknown1 = parser.ReadOffset< bool >( (ushort) (i * 12 + 8), 2);
        	GFATEParams[i].Unknown2 = parser.ReadOffset< bool >( (ushort) (i * 12 + 8), 4);
        }
        Unknown0 = parser.ReadOffset< uint >( 180 );
        Unknown1 = parser.ReadOffset< uint >( 184 );
        Unknown2 = parser.ReadOffset< bool >( 188 );
        Unknown3 = parser.ReadOffset< bool >( 188, 2 );
        Unknown4 = parser.ReadOffset< bool >( 188, 4 );
        Unknown5 = parser.ReadOffset< uint >( 192 );
        Unknown6 = parser.ReadOffset< uint >( 196 );
        Unknown7 = parser.ReadOffset< ushort >( 200 );
        Unknown8 = parser.ReadOffset< ushort >( 202 );
        Unknown9 = parser.ReadOffset< ushort >( 204 );
        Unknown10 = parser.ReadOffset< byte >( 206 );
        Unknown11 = parser.ReadOffset< byte >( 207 );
        

    }
}