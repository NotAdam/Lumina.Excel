// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MacroIconRedirectOld", columnHash: 0x5c9aa6b3 )]
public partial class MacroIconRedirectOld : ExcelRow
{
    
    public uint IconOld { get; private set; }
    public int IconNew { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        IconOld = parser.ReadOffset< uint >( 0 );
        IconNew = parser.ReadOffset< int >( 4 );
        

    }
}