// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AOZScore", columnHash: 0xefee2933 )]
public partial class AOZScore : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public int Score { get; private set; }
    public bool IsHidden { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Score = parser.ReadOffset< int >( 8 );
        IsHidden = parser.ReadOffset< bool >( 12 );
        

    }
}