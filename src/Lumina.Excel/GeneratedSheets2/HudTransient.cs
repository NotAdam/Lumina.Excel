// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "HudTransient", columnHash: 0x83076f24 )]
public partial class HudTransient : ExcelRow
{
    
    public sbyte Unknown0 { get; private set; }
    public sbyte Unknown1 { get; private set; }
    public sbyte Unknown2 { get; private set; }
    public sbyte Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< sbyte >( 0 );
        Unknown1 = parser.ReadOffset< sbyte >( 1 );
        Unknown2 = parser.ReadOffset< sbyte >( 2 );
        Unknown3 = parser.ReadOffset< sbyte >( 3 );
        

    }
}