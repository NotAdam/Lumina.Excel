// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Carry", columnHash: 0x31e1f9e6 )]
public partial class Carry : ExcelRow
{
    
    public ulong Model { get; private set; }
    public byte Timeline { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Model = parser.ReadOffset< ulong >( 0 );
        Timeline = parser.ReadOffset< byte >( 8 );
        Unknown0 = parser.ReadOffset< byte >( 9 );
        Unknown1 = parser.ReadOffset< byte >( 10 );
        

    }
}