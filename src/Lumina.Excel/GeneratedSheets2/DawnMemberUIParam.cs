// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DawnMemberUIParam", columnHash: 0x7b44bc07 )]
public partial class DawnMemberUIParam : ExcelRow
{
    
    public SeString Unknown1 { get; private set; }
    public SeString ClassPlural { get; private set; }
    public uint VoiceLine { get; private set; }
    public SeString ClassSingular { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown1 = parser.ReadOffset< SeString >( 0 );
        ClassPlural = parser.ReadOffset< SeString >( 4 );
        VoiceLine = parser.ReadOffset< uint >( 8 );
        ClassSingular = parser.ReadOffset< SeString >( 12 );
        

    }
}