// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Picture", columnHash: 0xfaedad07 )]
public partial class Picture : ExcelRow
{
    
    public int Image { get; private set; }
    public int Signature { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Image = parser.ReadOffset< int >( 0 );
        Signature = parser.ReadOffset< int >( 4 );
        

    }
}