// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ScreenImage", columnHash: 0xf03c70eb )]
public partial class ScreenImage : ExcelRow
{
    
    public uint Image { get; private set; }
    public LazyRow< Jingle > Jingle { get; private set; }
    public sbyte Type { get; private set; }
    public bool Lang { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Image = parser.ReadOffset< uint >( 0 );
        Jingle = new LazyRow< Jingle >( gameData, parser.ReadOffset< short >( 4 ), language );
        Type = parser.ReadOffset< sbyte >( 6 );
        Lang = parser.ReadOffset< bool >( 7 );
        

    }
}