// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Frontline03", columnHash: 0x605090e3 )]
public partial class Frontline03 : ExcelRow
{
    public struct OvooDataStruct
    {
    	public uint EmptyIcon { get; internal set; }
    	public uint MaelstromIcon { get; internal set; }
    	public uint TwinAdderIcon { get; internal set; }
    	public uint ImmortalFlamesIcon { get; internal set; }
    	public byte Unknown0 { get; internal set; }
    	public byte Unknown3 { get; internal set; }
    	public byte Unknown6 { get; internal set; }
    }
    
    public OvooDataStruct[] OvooData { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        OvooData = new OvooDataStruct[3];
        for (int i = 0; i < 3; i++)
        {
        	OvooData[i].EmptyIcon = parser.ReadOffset< uint >( (ushort) (i * 20 + 0));
        	OvooData[i].MaelstromIcon = parser.ReadOffset< uint >( (ushort) (i * 20 + 4));
        	OvooData[i].TwinAdderIcon = parser.ReadOffset< uint >( (ushort) (i * 20 + 8));
        	OvooData[i].ImmortalFlamesIcon = parser.ReadOffset< uint >( (ushort) (i * 20 + 12));
        	OvooData[i].Unknown0 = parser.ReadOffset< byte >( (ushort) (i * 20 + 16));
        	OvooData[i].Unknown3 = parser.ReadOffset< byte >( (ushort) (i * 20 + 17));
        	OvooData[i].Unknown6 = parser.ReadOffset< byte >( (ushort) (i * 20 + 18));
        }
        

    }
}