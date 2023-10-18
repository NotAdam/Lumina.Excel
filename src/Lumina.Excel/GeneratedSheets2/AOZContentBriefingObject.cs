// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AOZContentBriefingObject", columnHash: 0x5edc18ea )]
public partial class AOZContentBriefingObject : ExcelRow
{
    
    public uint Icon { get; private set; }
    public ushort Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Icon = parser.ReadOffset< uint >( 0 );
        Unknown0 = parser.ReadOffset< ushort >( 4 );
        

    }
}