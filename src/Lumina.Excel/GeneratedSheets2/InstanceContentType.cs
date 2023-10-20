// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "InstanceContentType", columnHash: 0xf9304387 )]
public partial class InstanceContentType : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool Unknown8 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown1 = parser.ReadOffset< byte >( 4 );
        Unknown2 = parser.ReadOffset< bool >( 5 );
        Unknown3 = parser.ReadOffset< bool >( 5, 2 );
        Unknown4 = parser.ReadOffset< bool >( 5, 4 );
        Unknown5 = parser.ReadOffset< bool >( 5, 8 );
        Unknown6 = parser.ReadOffset< bool >( 5, 16 );
        Unknown7 = parser.ReadOffset< bool >( 5, 32 );
        Unknown8 = parser.ReadOffset< bool >( 5, 64 );
        

    }
}