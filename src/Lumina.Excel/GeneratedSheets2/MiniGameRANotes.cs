// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MiniGameRANotes", columnHash: 0xeed86d68 )]
public partial class MiniGameRANotes : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public int Unknown2 { get; private set; }
    public int Unknown3 { get; private set; }
    public ushort Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown6 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< int >( 4 );
        Unknown2 = parser.ReadOffset< int >( 8 );
        Unknown3 = parser.ReadOffset< int >( 12 );
        Unknown4 = parser.ReadOffset< ushort >( 16 );
        Unknown5 = parser.ReadOffset< byte >( 18 );
        Unknown6 = parser.ReadOffset< byte >( 19 );
        

    }
}