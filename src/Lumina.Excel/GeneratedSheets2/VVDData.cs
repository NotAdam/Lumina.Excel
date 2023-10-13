// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "VVDData", columnHash: 0x4466aeed )]
public partial class VVDData : ExcelRow
{
    
    public uint Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public uint Unknown4 { get; private set; }
    public uint Unknown5 { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown2 = parser.ReadOffset< uint >( 0 );
        Unknown3 = parser.ReadOffset< uint >( 4 );
        Unknown4 = parser.ReadOffset< uint >( 8 );
        Unknown5 = parser.ReadOffset< uint >( 12 );
        Unknown0 = parser.ReadOffset< byte >( 16 );
        Unknown1 = parser.ReadOffset< byte >( 17 );
        

    }
}