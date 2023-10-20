// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ItemAction", columnHash: 0xb1f26af0 )]
public partial class ItemAction : ExcelRow
{
    
    public ushort Type { get; private set; }
    public ushort[] Data { get; private set; }
    public ushort[] DataHQ { get; private set; }
    public byte CondLv { get; private set; }
    public bool CondBattle { get; private set; }
    public bool CondPVP { get; private set; }
    public bool CondPVPOnly { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Type = parser.ReadOffset< ushort >( 0 );
        Data = new ushort[9];
        for (int i = 0; i < 9; i++)
        	Data[i] = parser.ReadOffset< ushort >( 2 + i * 2 );
        DataHQ = new ushort[9];
        for (int i = 0; i < 9; i++)
        	DataHQ[i] = parser.ReadOffset< ushort >( 20 + i * 2 );
        CondLv = parser.ReadOffset< byte >( 38 );
        CondBattle = parser.ReadOffset< bool >( 39 );
        CondPVP = parser.ReadOffset< bool >( 39, 2 );
        CondPVPOnly = parser.ReadOffset< bool >( 39, 4 );
        

    }
}