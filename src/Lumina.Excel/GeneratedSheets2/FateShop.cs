// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FateShop", columnHash: 0x58d1a3e4 )]
public partial class FateShop : ExcelRow
{
    
    public LazyRow< SpecialShop >[] SpecialShop { get; private set; }
    public LazyRow< DefaultTalk >[] DefaultTalk { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        SpecialShop = new LazyRow< SpecialShop >[3];
        for (int i = 0; i < 3; i++)
        	SpecialShop[i] = new LazyRow< SpecialShop >( gameData, parser.ReadOffset< uint >( (ushort) ( 0 + i * 4 ) ), language );
        DefaultTalk = new LazyRow< DefaultTalk >[9];
        for (int i = 0; i < 9; i++)
        	DefaultTalk[i] = new LazyRow< DefaultTalk >( gameData, parser.ReadOffset< uint >( (ushort) ( 12 + i * 4 ) ), language );
        

    }
}