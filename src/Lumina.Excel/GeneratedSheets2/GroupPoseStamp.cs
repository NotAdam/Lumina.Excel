// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GroupPoseStamp", columnHash: 0x65a8a2df )]
public partial class GroupPoseStamp : ExcelRow
{
    
    public SeString Name { get; private set; }
    public uint Unknown5 { get; private set; }
    public int StampIcon { get; private set; }
    public int Unknown1 { get; private set; }
    public LazyRow< GroupPoseStampCategory > Category { get; private set; }
    public int Unknown6 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown9 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Unknown5 = parser.ReadOffset< uint >( 4 );
        StampIcon = parser.ReadOffset< int >( 8 );
        Unknown1 = parser.ReadOffset< int >( 12 );
        Category = new LazyRow< GroupPoseStampCategory >( gameData, parser.ReadOffset< int >( 16 ), language );
        Unknown6 = parser.ReadOffset< int >( 20 );
        Unknown3 = parser.ReadOffset< ushort >( 24 );
        Unknown4 = parser.ReadOffset< byte >( 26 );
        Unknown7 = parser.ReadOffset< bool >( 27 );
        Unknown8 = parser.ReadOffset< bool >( 27, 2 );
        Unknown9 = parser.ReadOffset< bool >( 27, 4 );
        

    }
}