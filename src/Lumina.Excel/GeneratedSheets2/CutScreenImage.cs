// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CutScreenImage", columnHash: 0xe4a523cd )]
public partial class CutScreenImage : ExcelRow
{
    
    public int Image { get; private set; }
    public short Type { get; private set; }
    public short Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Image = parser.ReadOffset< int >( 0 );
        Type = parser.ReadOffset< short >( 4 );
        Unknown0 = parser.ReadOffset< short >( 6 );
        

    }
}