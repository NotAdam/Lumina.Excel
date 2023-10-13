// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BGMSwitch", columnHash: 0x0989d4f2 )]
public partial class BGMSwitch : ExcelRow
{
    
    public LazyRow< Quest > Quest { get; private set; }
    public ILazyRow BGM { get; private set; }
    public LazyRow< BGMSystemDefine > BGMSystemDefine { get; private set; }
    public byte Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 0 ), language );
        BGM = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< ushort >( 4 ), language, "BGM", "BGMSituation" );
        BGMSystemDefine = new LazyRow< BGMSystemDefine >( gameData, parser.ReadOffset< byte >( 6 ), language );
        Unknown2 = parser.ReadOffset< byte >( 7 );
        

    }
}