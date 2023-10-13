// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CharaCardDesignType", columnHash: 0xcd656c92 )]
public partial class CharaCardDesignType : ExcelRow
{
    
    public bool Unknown0 { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown9 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< bool >( 0 );
        Unknown1 = parser.ReadOffset< bool >( 1 );
        Unknown2 = parser.ReadOffset< bool >( 2 );
        Unknown3 = parser.ReadOffset< bool >( 3 );
        Unknown4 = parser.ReadOffset< bool >( 3, 2 );
        Unknown5 = parser.ReadOffset< bool >( 3, 4 );
        Unknown6 = parser.ReadOffset< bool >( 3, 8 );
        Unknown7 = parser.ReadOffset< bool >( 3, 16 );
        Unknown8 = parser.ReadOffset< bool >( 3, 32 );
        Unknown9 = parser.ReadOffset< bool >( 3, 64 );
        

    }
}