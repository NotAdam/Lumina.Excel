// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PlaceName", columnHash: 0x16a1fd3c )]
public partial class PlaceName : ExcelRow
{
    
    public SeString Name { get; private set; }
    public SeString NameNoArticle { get; private set; }
    public SeString Unknown8 { get; private set; }
    public sbyte Unknown1 { get; private set; }
    public sbyte Unknown3 { get; private set; }
    public sbyte Unknown4 { get; private set; }
    public sbyte Unknown5 { get; private set; }
    public sbyte Unknown6 { get; private set; }
    public sbyte Unknown7 { get; private set; }
    public ushort Unknown10 { get; private set; }
    public byte Unknown9 { get; private set; }
    public byte Unknown11 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        NameNoArticle = parser.ReadOffset< SeString >( 4 );
        Unknown8 = parser.ReadOffset< SeString >( 8 );
        Unknown1 = parser.ReadOffset< sbyte >( 12 );
        Unknown3 = parser.ReadOffset< sbyte >( 13 );
        Unknown4 = parser.ReadOffset< sbyte >( 14 );
        Unknown5 = parser.ReadOffset< sbyte >( 15 );
        Unknown6 = parser.ReadOffset< sbyte >( 16 );
        Unknown7 = parser.ReadOffset< sbyte >( 17 );
        Unknown10 = parser.ReadOffset< ushort >( 20 );
        Unknown9 = parser.ReadOffset< byte >( 22 );
        Unknown11 = parser.ReadOffset< byte >( 23 );
        

    }
}