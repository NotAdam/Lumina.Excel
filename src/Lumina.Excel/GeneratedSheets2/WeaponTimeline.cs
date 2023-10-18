// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "WeaponTimeline", columnHash: 0x7f718689 )]
public partial class WeaponTimeline : ExcelRow
{
    
    public SeString File { get; private set; }
    public short NextWeaponTimeline { get; private set; }
    public bool Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        File = parser.ReadOffset< SeString >( 0 );
        NextWeaponTimeline = parser.ReadOffset< short >( 4 );
        Unknown0 = parser.ReadOffset< bool >( 6 );
        

    }
}