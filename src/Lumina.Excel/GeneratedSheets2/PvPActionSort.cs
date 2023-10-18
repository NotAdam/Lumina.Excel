// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PvPActionSort", columnHash: 0xc3af756b )]
public partial class PvPActionSort : ExcelRow
{
    
    public int Unknown0 { get; private set; }
    public ILazyRow Action { get; private set; }
    public byte ActionType { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< int >( 0 );
        var ActionRowId = parser.ReadOffset< ushort >( 4 );
        ActionType = parser.ReadOffset< byte >( 6 );
        Unknown1 = parser.ReadOffset< bool >( 7 );
        Unknown2 = parser.ReadOffset< bool >( 7, 2 );
        
        Action = ActionType switch
        {
        	1 => new LazyRow< Action >( gameData, ActionRowId, language ),
        	2 => new LazyRow< ActionComboRoute >( gameData, ActionRowId, language ),
        	_ => new EmptyLazyRow( (uint) ActionRowId ),
        };
    }
}