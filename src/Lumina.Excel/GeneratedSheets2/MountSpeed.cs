// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MountSpeed", columnHash: 0x91ab8236 )]
public partial class MountSpeed : ExcelRow
{
    
    public LazyRow< Quest > Quest { get; private set; }
    public uint Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown0 = parser.ReadOffset< uint >( 4 );
        Unknown1 = parser.ReadOffset< byte >( 8 );
        

    }
}