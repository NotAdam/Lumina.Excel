// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CompanyCraftPart", columnHash: 0xe9ffd316 )]
public partial class CompanyCraftPart : ExcelRow
{
    
    public LazyRow< CompanyCraftProcess >[] CompanyCraftProcess { get; private set; }
    public ushort Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public LazyRow< CompanyCraftType > CompanyCraftType { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        CompanyCraftProcess = new LazyRow< CompanyCraftProcess >[3];
        for (int i = 0; i < 3; i++)
        	CompanyCraftProcess[i] = new LazyRow< CompanyCraftProcess >( gameData, parser.ReadOffset< ushort >( (ushort) ( 0 + i * 2 ) ), language );
        Unknown0 = parser.ReadOffset< ushort >( 6 );
        Unknown1 = parser.ReadOffset< byte >( 8 );
        CompanyCraftType = new LazyRow< CompanyCraftType >( gameData, parser.ReadOffset< byte >( 9 ), language );
        

    }
}