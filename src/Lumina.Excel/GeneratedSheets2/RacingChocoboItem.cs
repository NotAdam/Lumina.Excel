// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RacingChocoboItem", columnHash: 0xe79dd9d4 )]
public partial class RacingChocoboItem : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public byte Category { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 0 ), language );
        Category = parser.ReadOffset< byte >( 4 );
        Unknown0 = parser.ReadOffset< byte >( 5 );
        Unknown1 = parser.ReadOffset< byte >( 6 );
        

    }
}