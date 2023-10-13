// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HousingLandSet", columnHash: 0xc557f79e )]
public partial class HousingLandSet : ExcelRow
{
    public struct LandSetStruct
    {
    	public uint UnknownRange1 { get; internal set; }
    	public uint PlacardId { get; internal set; }
    	public uint UnknownRange2 { get; internal set; }
    	public uint InitialPrice { get; internal set; }
    	public byte PlotSize { get; internal set; }
    }
    
    public LandSetStruct[] LandSet { get; private set; }
    public uint UnknownRange1 { get; private set; }
    public uint UnknownRange2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        LandSet = new LandSetStruct[60];
        for (int i = 0; i < 60; i++)
        {
        	LandSet[i].UnknownRange1 = parser.ReadOffset< uint >( (ushort) (i * 20 + 0));
        	LandSet[i].PlacardId = parser.ReadOffset< uint >( (ushort) (i * 20 + 4));
        	LandSet[i].UnknownRange2 = parser.ReadOffset< uint >( (ushort) (i * 20 + 8));
        	LandSet[i].InitialPrice = parser.ReadOffset< uint >( (ushort) (i * 20 + 12));
        	LandSet[i].PlotSize = parser.ReadOffset< byte >( (ushort) (i * 20 + 16));
        }
        UnknownRange1 = parser.ReadOffset< uint >( 1200 );
        UnknownRange2 = parser.ReadOffset< uint >( 1204 );
        

    }
}