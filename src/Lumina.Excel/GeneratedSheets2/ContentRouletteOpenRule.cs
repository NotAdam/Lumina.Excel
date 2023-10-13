// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentRouletteOpenRule", columnHash: 0x985449ce )]
public partial class ContentRouletteOpenRule : ExcelRow
{
    
    public uint Type { get; private set; }
    public bool Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Type = parser.ReadOffset< uint >( 0 );
        Unknown0 = parser.ReadOffset< bool >( 4 );
        

    }
}