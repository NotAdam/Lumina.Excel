// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestEffect", columnHash: 0x9f0492cf )]
public partial class QuestEffect : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public uint Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public uint Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public uint Unknown6 { get; private set; }
    public byte Unknown7 { get; private set; }
    public uint Unknown8 { get; private set; }
    public uint Unknown9 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< byte >( 4 );
        Unknown2 = parser.ReadOffset< uint >( 8 );
        Unknown3 = parser.ReadOffset< byte >( 12 );
        Unknown4 = parser.ReadOffset< uint >( 16 );
        Unknown5 = parser.ReadOffset< byte >( 20 );
        Unknown6 = parser.ReadOffset< uint >( 24 );
        Unknown7 = parser.ReadOffset< byte >( 28 );
        Unknown8 = parser.ReadOffset< uint >( 32 );
        Unknown9 = parser.ReadOffset< uint >( 36 );
        

    }
}