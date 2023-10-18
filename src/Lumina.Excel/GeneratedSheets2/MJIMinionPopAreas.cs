// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIMinionPopAreas", columnHash: 0x3591bdd9 )]
public partial class MJIMinionPopAreas : ExcelRow
{
    
    public int Unknown0 { get; private set; }
    public short Unknown1 { get; private set; }
    public short Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< int >( 0 );
        Unknown1 = parser.ReadOffset< short >( 4 );
        Unknown2 = parser.ReadOffset< short >( 6 );
        Unknown3 = parser.ReadOffset< byte >( 8 );
        Unknown4 = parser.ReadOffset< bool >( 9 );
        

    }
}