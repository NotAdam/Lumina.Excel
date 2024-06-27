// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestSubCommand", columnHash: 0x1aa0f3da )]
public partial class QuestSubCommand : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public uint Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public uint Unknown4 { get; private set; }
    public uint Unknown5 { get; private set; }
    public uint Unknown6 { get; private set; }
    public uint Unknown7 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown10 { get; private set; }
    public byte Unknown11 { get; private set; }
    public byte Unknown12 { get; private set; }
    public byte Unknown13 { get; private set; }
    public byte Unknown14 { get; private set; }
    public byte Unknown15 { get; private set; }
    public byte Unknown16 { get; private set; }
    public byte Unknown17 { get; private set; }
    public byte Unknown18 { get; private set; }
    public byte Unknown19 { get; private set; }
    public byte Unknown20 { get; private set; }
    public byte Unknown21 { get; private set; }
    public byte Unknown22 { get; private set; }
    public byte Unknown23 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< uint >( 4 );
        Unknown2 = parser.ReadOffset< uint >( 8 );
        Unknown3 = parser.ReadOffset< uint >( 12 );
        Unknown4 = parser.ReadOffset< uint >( 16 );
        Unknown5 = parser.ReadOffset< uint >( 20 );
        Unknown6 = parser.ReadOffset< uint >( 24 );
        Unknown7 = parser.ReadOffset< uint >( 28 );
        Unknown8 = parser.ReadOffset< byte >( 32 );
        Unknown9 = parser.ReadOffset< byte >( 33 );
        Unknown10 = parser.ReadOffset< byte >( 34 );
        Unknown11 = parser.ReadOffset< byte >( 35 );
        Unknown12 = parser.ReadOffset< byte >( 36 );
        Unknown13 = parser.ReadOffset< byte >( 37 );
        Unknown14 = parser.ReadOffset< byte >( 38 );
        Unknown15 = parser.ReadOffset< byte >( 39 );
        Unknown16 = parser.ReadOffset< byte >( 40 );
        Unknown17 = parser.ReadOffset< byte >( 41 );
        Unknown18 = parser.ReadOffset< byte >( 42 );
        Unknown19 = parser.ReadOffset< byte >( 43 );
        Unknown20 = parser.ReadOffset< byte >( 44 );
        Unknown21 = parser.ReadOffset< byte >( 45 );
        Unknown22 = parser.ReadOffset< byte >( 46 );
        Unknown23 = parser.ReadOffset< byte >( 47 );
        

    }
}