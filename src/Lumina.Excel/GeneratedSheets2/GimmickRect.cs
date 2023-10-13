// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GimmickRect", columnHash: 0x9be6d434 )]
public partial class GimmickRect : ExcelRow
{
    
    public uint LayoutID { get; private set; }
    public uint Param0 { get; private set; }
    public uint Unknown3 { get; private set; }
    public uint Unknown4 { get; private set; }
    public uint Unknown5 { get; private set; }
    public uint Param1 { get; private set; }
    public uint Unknown8 { get; private set; }
    public uint Unknown9 { get; private set; }
    public uint Unknown10 { get; private set; }
    public byte TriggerIn { get; private set; }
    public byte TriggerOut { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        LayoutID = parser.ReadOffset< uint >( 0 );
        Param0 = parser.ReadOffset< uint >( 4 );
        Unknown3 = parser.ReadOffset< uint >( 8 );
        Unknown4 = parser.ReadOffset< uint >( 12 );
        Unknown5 = parser.ReadOffset< uint >( 16 );
        Param1 = parser.ReadOffset< uint >( 20 );
        Unknown8 = parser.ReadOffset< uint >( 24 );
        Unknown9 = parser.ReadOffset< uint >( 28 );
        Unknown10 = parser.ReadOffset< uint >( 32 );
        TriggerIn = parser.ReadOffset< byte >( 36 );
        TriggerOut = parser.ReadOffset< byte >( 37 );
        

    }
}