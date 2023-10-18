// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RPParameter", columnHash: 0x251a33cc )]
public partial class RPParameter : ExcelRow
{
    
    public LazyRow< BNpcName > BNpcName { get; private set; }
    public LazyRow< ClassJob > ClassJob { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        BNpcName = new LazyRow< BNpcName >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadOffset< byte >( 2 ), language );
        Unknown0 = parser.ReadOffset< byte >( 3 );
        

    }
}