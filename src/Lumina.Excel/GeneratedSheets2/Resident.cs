// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Resident", columnHash: 0x9af0b586 )]
public partial class Resident : ExcelRow
{
    
    public ulong Model { get; private set; }
    public LazyRow< NpcYell > NpcYell { get; private set; }
    public ushort Unknown3 { get; private set; }
    public byte Unknown0 { get; private set; }
    public LazyRow< ResidentMotionType > ResidentMotionType { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Model = parser.ReadOffset< ulong >( 0 );
        NpcYell = new LazyRow< NpcYell >( gameData, parser.ReadOffset< int >( 8 ), language );
        Unknown3 = parser.ReadOffset< ushort >( 12 );
        Unknown0 = parser.ReadOffset< byte >( 14 );
        ResidentMotionType = new LazyRow< ResidentMotionType >( gameData, parser.ReadOffset< byte >( 15 ), language );
        

    }
}