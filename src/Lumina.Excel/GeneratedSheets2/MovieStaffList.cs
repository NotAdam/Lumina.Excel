// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MovieStaffList", columnHash: 0xc3212d0e )]
public partial class MovieStaffList : ExcelRow
{
    
    public float StartTime { get; private set; }
    public float EndTime { get; private set; }
    public uint Image { get; private set; }
    public sbyte Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        StartTime = parser.ReadOffset< float >( 0 );
        EndTime = parser.ReadOffset< float >( 4 );
        Image = parser.ReadOffset< uint >( 8 );
        Unknown0 = parser.ReadOffset< sbyte >( 12 );
        

    }
}