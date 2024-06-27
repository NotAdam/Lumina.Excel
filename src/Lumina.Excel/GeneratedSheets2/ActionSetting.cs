// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ActionSetting", columnHash: 0xb42d3edf )]
public partial class ActionSetting : ExcelRow
{
    
    public int Unknown0 { get; private set; }
    public int Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< int >( 0 );
        Unknown1 = parser.ReadOffset< int >( 4 );
        Unknown2 = parser.ReadOffset< byte >( 8 );
        Unknown3 = parser.ReadOffset< bool >( 9 );
        Unknown4 = parser.ReadOffset< bool >( 9, 2 );
        Unknown5 = parser.ReadOffset< bool >( 9, 4 );
        Unknown6 = parser.ReadOffset< bool >( 9, 8 );
        

    }
}