// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIHudMode", columnHash: 0xb786ca47 )]
public partial class MJIHudMode : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Title { get; private set; }
    public uint Icon { get; private set; }
    public uint Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Title = parser.ReadOffset< SeString >( 4 );
        Icon = parser.ReadOffset< uint >( 8 );
        Unknown0 = parser.ReadOffset< uint >( 12 );
        

    }
}