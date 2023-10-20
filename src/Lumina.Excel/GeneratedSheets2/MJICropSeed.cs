// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJICropSeed", columnHash: 0xcd7b9ae9 )]
public partial class MJICropSeed : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public LazyRow< EObjName > Name { get; private set; }
    public LazyRow< ExportedSG > SGB { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Name = new LazyRow< EObjName >( gameData, parser.ReadOffset< uint >( 4 ), language );
        SGB = new LazyRow< ExportedSG >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        

    }
}