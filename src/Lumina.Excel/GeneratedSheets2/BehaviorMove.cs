// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BehaviorMove", columnHash: 0x0c362f6e )]
public partial class BehaviorMove : ExcelRow
{
    
    public float Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< float >( 0 );
        Unknown1 = parser.ReadOffset< byte >( 4 );
        Unknown2 = parser.ReadOffset< bool >( 5 );
        Unknown3 = parser.ReadOffset< bool >( 5, 2 );
        

    }
}