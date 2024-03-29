// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestLinkMarkerSet", columnHash: 0x202b96b0 )]
public partial class QuestLinkMarkerSet : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< ushort >( 4 );
        Unknown2 = parser.ReadOffset< byte >( 6 );
        Unknown3 = parser.ReadOffset< byte >( 7 );
        Unknown4 = parser.ReadOffset< byte >( 8 );
        Unknown5 = parser.ReadOffset< bool >( 9 );
        Unknown6 = parser.ReadOffset< bool >( 9, 2 );
        

    }
}