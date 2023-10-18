// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MainCommand", columnHash: 0xc6604a03 )]
public partial class MainCommand : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString Description { get; private set; }
    public int Icon { get; private set; }
    public byte Category { get; private set; }
    public LazyRow< MainCommandCategory > MainCommandCategory { get; private set; }
    public byte Unknown0 { get; private set; }
    public sbyte SortID { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Description = parser.ReadOffset< SeString >( 4 );
        Icon = parser.ReadOffset< int >( 8 );
        Category = parser.ReadOffset< byte >( 12 );
        MainCommandCategory = new LazyRow< MainCommandCategory >( gameData, parser.ReadOffset< byte >( 13 ), language );
        Unknown0 = parser.ReadOffset< byte >( 14 );
        SortID = parser.ReadOffset< sbyte >( 15 );
        

    }
}