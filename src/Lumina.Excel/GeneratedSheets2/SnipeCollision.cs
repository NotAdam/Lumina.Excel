// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SnipeCollision", columnHash: 0xc04fef85 )]
public partial class SnipeCollision : ExcelRow
{
    
    public ushort Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< ushort >( 0 );
        Unknown1 = parser.ReadOffset< ushort >( 2 );
        Unknown2 = parser.ReadOffset< ushort >( 4 );
        Unknown3 = parser.ReadOffset< byte >( 6 );
        Unknown4 = parser.ReadOffset< byte >( 7 );
        

    }
}