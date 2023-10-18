// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GimmickAccessor", columnHash: 0x5861eaa3 )]
public partial class GimmickAccessor : ExcelRow
{
    
    public uint Param1 { get; private set; }
    public uint Param2 { get; private set; }
    public uint Type { get; private set; }
    public uint Unknown0 { get; private set; }
    public uint Unknown1 { get; private set; }
    public uint Unknown2 { get; private set; }
    public int Param0 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Param1 = parser.ReadOffset< uint >( 0 );
        Param2 = parser.ReadOffset< uint >( 4 );
        Type = parser.ReadOffset< uint >( 8 );
        Unknown0 = parser.ReadOffset< uint >( 12 );
        Unknown1 = parser.ReadOffset< uint >( 16 );
        Unknown2 = parser.ReadOffset< uint >( 20 );
        Param0 = parser.ReadOffset< int >( 24 );
        Unknown3 = parser.ReadOffset< bool >( 28 );
        Unknown4 = parser.ReadOffset< bool >( 28, 2 );
        Unknown5 = parser.ReadOffset< bool >( 28, 4 );
        

    }
}