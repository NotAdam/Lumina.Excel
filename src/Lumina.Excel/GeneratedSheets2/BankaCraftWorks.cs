// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BankaCraftWorks", columnHash: 0x92b51979 )]
public partial class BankaCraftWorks : ExcelRow
{
    
    public SeString Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< SeString >( 0 );
        Unknown1 = parser.ReadOffset< uint >( 4 );
        Unknown2 = parser.ReadOffset< ushort >( 8 );
        

    }
}