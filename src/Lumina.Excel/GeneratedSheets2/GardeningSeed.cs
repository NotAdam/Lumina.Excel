// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GardeningSeed", columnHash: 0xa8a6cb9c )]
public partial class GardeningSeed : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public uint Icon { get; private set; }
    public ushort ModelID { get; private set; }
    public byte Unknown0 { get; private set; }
    public bool SE { get; private set; }
    public bool Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Icon = parser.ReadOffset< uint >( 4 );
        ModelID = parser.ReadOffset< ushort >( 8 );
        Unknown0 = parser.ReadOffset< byte >( 10 );
        SE = parser.ReadOffset< bool >( 11 );
        Unknown1 = parser.ReadOffset< bool >( 11, 2 );
        

    }
}