// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MapReplace", columnHash: 0xe26f9110 )]
public partial class MapReplace : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Unknown2 = parser.ReadOffset< ushort >( 4 );
        Unknown3 = parser.ReadOffset< ushort >( 6 );
        Unknown1 = parser.ReadOffset< byte >( 8 );
        

    }
}