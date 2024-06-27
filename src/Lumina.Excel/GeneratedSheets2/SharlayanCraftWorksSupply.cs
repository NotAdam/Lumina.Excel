// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SharlayanCraftWorksSupply", columnHash: 0x903b128e )]
public partial class SharlayanCraftWorksSupply : ExcelRow
{
    public struct ItemStruct
    {
    	public uint Id { get; internal set; }
    	public uint XPReward { get; internal set; }
    	public ushort CollectabilityMid { get; internal set; }
    	public ushort CollectabilityHigh { get; internal set; }
    	public ushort GilReward { get; internal set; }
    	public byte Level { get; internal set; }
    	public byte HighXPMultiplier { get; internal set; }
    	public byte HighGilMultiplier { get; internal set; }
    	public byte Unknown8 { get; internal set; }
    	public byte ScripReward { get; internal set; }
    	public byte HighScripMultiplier { get; internal set; }
    }
    
    public ItemStruct[] Item { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new ItemStruct[4];
        for (int i = 0; i < 4; i++)
        {
        	Item[i].Id = parser.ReadOffset< uint >( (ushort) (i * 20 + 0));
        	Item[i].XPReward = parser.ReadOffset< uint >( (ushort) (i * 20 + 4));
        	Item[i].CollectabilityMid = parser.ReadOffset< ushort >( (ushort) (i * 20 + 8));
        	Item[i].CollectabilityHigh = parser.ReadOffset< ushort >( (ushort) (i * 20 + 10));
        	Item[i].GilReward = parser.ReadOffset< ushort >( (ushort) (i * 20 + 12));
        	Item[i].Level = parser.ReadOffset< byte >( (ushort) (i * 20 + 14));
        	Item[i].HighXPMultiplier = parser.ReadOffset< byte >( (ushort) (i * 20 + 15));
        	Item[i].HighGilMultiplier = parser.ReadOffset< byte >( (ushort) (i * 20 + 16));
        	Item[i].Unknown8 = parser.ReadOffset< byte >( (ushort) (i * 20 + 17));
        	Item[i].ScripReward = parser.ReadOffset< byte >( (ushort) (i * 20 + 18));
        	Item[i].HighScripMultiplier = parser.ReadOffset< byte >( (ushort) (i * 20 + 19));
        }
        

    }
}