// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HugeCraftworksRank", columnHash: 0xf7af7ac5 )]
public partial class HugeCraftworksRank : ExcelRow
{
    
    public uint ExpRewardPerItem { get; private set; }
    public byte CrafterLevel { get; private set; }
    public byte Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ExpRewardPerItem = parser.ReadOffset< uint >( 0 );
        CrafterLevel = parser.ReadOffset< byte >( 4 );
        Unknown2 = parser.ReadOffset< byte >( 5 );
        

    }
}