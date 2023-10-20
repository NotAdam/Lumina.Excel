// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ModelState", columnHash: 0xd73eab80 )]
public partial class ModelState : ExcelRow
{
    
    public LazyRow< ActionTimeline > Start { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Start = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        Unknown0 = parser.ReadOffset< byte >( 2 );
        

    }
}