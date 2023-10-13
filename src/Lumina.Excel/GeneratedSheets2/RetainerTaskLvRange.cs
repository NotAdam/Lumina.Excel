// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "RetainerTaskLvRange", columnHash: 0xde74b4c4 )]
public partial class RetainerTaskLvRange : ExcelRow
{
    
    public byte Min { get; private set; }
    public byte Max { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Min = parser.ReadOffset< byte >( 0 );
        Max = parser.ReadOffset< byte >( 1 );
        

    }
}