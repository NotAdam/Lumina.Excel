// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GroupPoseCharacterShowPreset", columnHash: 0xe9f11aa8 )]
public partial class GroupPoseCharacterShowPreset : ExcelRow
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
    public bool Unknown10 { get; private set; }
    public bool Unknown11 { get; private set; }
    public bool Unknown12 { get; private set; }
    public bool Unknown13 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< bool >( 0 );
        Unknown1 = parser.ReadOffset< bool >( 0, 2 );
        Unknown2 = parser.ReadOffset< bool >( 0, 4 );
        Unknown3 = parser.ReadOffset< bool >( 0, 8 );
        Unknown4 = parser.ReadOffset< bool >( 0, 16 );
        Unknown5 = parser.ReadOffset< bool >( 0, 32 );
        Unknown6 = parser.ReadOffset< bool >( 0, 64 );
        Unknown7 = parser.ReadOffset< bool >( 0, 128 );
        Unknown8 = parser.ReadOffset< bool >( 1 );
        Unknown9 = parser.ReadOffset< bool >( 1, 2 );
        Unknown10 = parser.ReadOffset< bool >( 1, 4 );
        Unknown11 = parser.ReadOffset< bool >( 1, 8 );
        Unknown12 = parser.ReadOffset< bool >( 1, 16 );
        Unknown13 = parser.ReadOffset< bool >( 1, 32 );
        

    }
}