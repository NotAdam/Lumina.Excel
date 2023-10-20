// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RecipeLookup", columnHash: 0xa708a4a0 )]
public partial class RecipeLookup : ExcelRow
{
    
    public LazyRow< Recipe > CRP { get; private set; }
    public LazyRow< Recipe > BSM { get; private set; }
    public LazyRow< Recipe > ARM { get; private set; }
    public LazyRow< Recipe > GSM { get; private set; }
    public LazyRow< Recipe > LTW { get; private set; }
    public LazyRow< Recipe > WVR { get; private set; }
    public LazyRow< Recipe > ALC { get; private set; }
    public LazyRow< Recipe > CUL { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        CRP = new LazyRow< Recipe >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        BSM = new LazyRow< Recipe >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        ARM = new LazyRow< Recipe >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        GSM = new LazyRow< Recipe >( gameData, parser.ReadOffset< ushort >( 6 ), language );
        LTW = new LazyRow< Recipe >( gameData, parser.ReadOffset< ushort >( 8 ), language );
        WVR = new LazyRow< Recipe >( gameData, parser.ReadOffset< ushort >( 10 ), language );
        ALC = new LazyRow< Recipe >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        CUL = new LazyRow< Recipe >( gameData, parser.ReadOffset< ushort >( 14 ), language );
        

    }
}