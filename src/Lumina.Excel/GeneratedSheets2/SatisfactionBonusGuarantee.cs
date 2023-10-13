// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SatisfactionBonusGuarantee", columnHash: 0x69213275 )]
public partial class SatisfactionBonusGuarantee : ExcelRow
{
    
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< byte >( 0 );
        Unknown1 = parser.ReadOffset< byte >( 1 );
        Unknown2 = parser.ReadOffset< byte >( 2 );
        Unknown3 = parser.ReadOffset< byte >( 3 );
        Unknown4 = parser.ReadOffset< byte >( 4 );
        Unknown5 = parser.ReadOffset< byte >( 5 );
        

    }
}