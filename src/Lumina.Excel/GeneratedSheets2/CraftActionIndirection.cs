// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CraftActionIndirection", columnHash: 0xf7903c75 )]
public partial class CraftActionIndirection : ExcelRow
{
    
    public int Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public sbyte Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< int >( 0 );
        Unknown1 = parser.ReadOffset< int >( 4 );
        Unknown2 = parser.ReadOffset< sbyte >( 8 );
        

    }
}