// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HWDDevLevelUI", columnHash: 0xd73eab80 )]
public partial class HWDDevLevelUI : ExcelRow
{
    
    public ushort Unknown1 { get; private set; }
    public byte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown1 = parser.ReadOffset< ushort >( 0 );
        Unknown0 = parser.ReadOffset< byte >( 2 );
        

    }
}