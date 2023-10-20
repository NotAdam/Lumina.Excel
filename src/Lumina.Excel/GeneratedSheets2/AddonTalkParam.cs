// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "AddonTalkParam", columnHash: 0xcbd32284 )]
public partial class AddonTalkParam : ExcelRow
{
    
    public short Unknown0 { get; private set; }
    public short Unknown1 { get; private set; }
    public short Unknown2 { get; private set; }
    public short Unknown3 { get; private set; }
    public short Unknown4 { get; private set; }
    public short Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< short >( 0 );
        Unknown1 = parser.ReadOffset< short >( 2 );
        Unknown2 = parser.ReadOffset< short >( 4 );
        Unknown3 = parser.ReadOffset< short >( 6 );
        Unknown4 = parser.ReadOffset< short >( 8 );
        Unknown5 = parser.ReadOffset< short >( 10 );
        

    }
}