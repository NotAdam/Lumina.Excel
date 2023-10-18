// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ManeuversArmor", columnHash: 0xc8b98ed4 )]
public partial class ManeuversArmor : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public LazyRow< BNpcName > FalconName { get; private set; }
    public LazyRow< BNpcName > RavenName { get; private set; }
    public uint NeutralMapIcon { get; private set; }
    public uint FalconImage { get; private set; }
    public uint RavenImage { get; private set; }
    public uint FalconMapImage { get; private set; }
    public uint RavenMapImage { get; private set; }
    public ushort Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        FalconName = new LazyRow< BNpcName >( gameData, parser.ReadOffset< uint >( 8 ), language );
        RavenName = new LazyRow< BNpcName >( gameData, parser.ReadOffset< uint >( 12 ), language );
        NeutralMapIcon = parser.ReadOffset< uint >( 16 );
        FalconImage = parser.ReadOffset< uint >( 20 );
        RavenImage = parser.ReadOffset< uint >( 24 );
        FalconMapImage = parser.ReadOffset< uint >( 28 );
        RavenMapImage = parser.ReadOffset< uint >( 32 );
        Unknown0 = parser.ReadOffset< ushort >( 36 );
        Unknown1 = parser.ReadOffset< byte >( 38 );
        Unknown2 = parser.ReadOffset< bool >( 39 );
        

    }
}