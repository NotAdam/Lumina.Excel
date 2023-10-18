// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "OnlineStatus", columnHash: 0xbcffd5d8 )]
public partial class OnlineStatus : ExcelRow
{
    
    public SeString Name { get; private set; }
    public uint Icon { get; private set; }
    public int Unknown0 { get; private set; }
    public byte Priority { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool List { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< uint >( 4 );
        Unknown0 = parser.ReadOffset< int >( 8 );
        Priority = parser.ReadOffset< byte >( 12 );
        Unknown1 = parser.ReadOffset< bool >( 13 );
        List = parser.ReadOffset< bool >( 13, 2 );
        Unknown2 = parser.ReadOffset< bool >( 13, 4 );
        

    }
}