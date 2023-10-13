// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ItemRetainerLevelUp", columnHash: 0x5edc18ea )]
public partial class ItemRetainerLevelUp : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< ushort >( 4 );
        

    }
}