// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CharaMakeCustomize", columnHash: 0xc30e9b73 )]
public partial class CharaMakeCustomize : ExcelRow
{
    
    public uint Icon { get; private set; }
    public LazyRow< Lobby > Hint { get; private set; }
    public LazyRow< Item > HintItem { get; private set; }
    public ushort Data { get; private set; }
    public byte FeatureID { get; private set; }
    public byte Unknown6 { get; private set; }
    public bool IsPurchasable { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Icon = parser.ReadOffset< uint >( 0 );
        Hint = new LazyRow< Lobby >( gameData, parser.ReadOffset< uint >( 4 ), language );
        HintItem = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 8 ), language );
        Data = parser.ReadOffset< ushort >( 12 );
        FeatureID = parser.ReadOffset< byte >( 14 );
        Unknown6 = parser.ReadOffset< byte >( 15 );
        IsPurchasable = parser.ReadOffset< bool >( 16 );
        

    }
}