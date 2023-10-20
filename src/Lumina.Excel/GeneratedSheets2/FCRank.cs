// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FCRank", columnHash: 0x0105b558 )]
public partial class FCRank : ExcelRow
{
    
    public uint NextPoint { get; private set; }
    public uint CurrentPoint { get; private set; }
    public ushort Rights { get; private set; }
    public ushort Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public byte FCActionActiveNum { get; private set; }
    public byte FCActionStockNum { get; private set; }
    public byte FCChestCompartments { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        NextPoint = parser.ReadOffset< uint >( 0 );
        CurrentPoint = parser.ReadOffset< uint >( 4 );
        Rights = parser.ReadOffset< ushort >( 8 );
        Unknown0 = parser.ReadOffset< ushort >( 10 );
        Unknown1 = parser.ReadOffset< ushort >( 12 );
        FCActionActiveNum = parser.ReadOffset< byte >( 14 );
        FCActionStockNum = parser.ReadOffset< byte >( 15 );
        FCChestCompartments = parser.ReadOffset< byte >( 16 );
        

    }
}