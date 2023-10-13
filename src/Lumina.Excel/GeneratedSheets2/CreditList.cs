// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CreditList", columnHash: 0x089033fa )]
public partial class CreditList : ExcelRow
{
    
    public uint Icon { get; private set; }
    public LazyRow< CreditFont > Font { get; private set; }
    public LazyRow< CreditListText > Cast { get; private set; }
    public ushort Scale { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Icon = parser.ReadOffset< uint >( 0 );
        Font = new LazyRow< CreditFont >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Cast = new LazyRow< CreditListText >( gameData, parser.ReadOffset< uint >( 8 ), language );
        Scale = parser.ReadOffset< ushort >( 12 );
        Unknown3 = parser.ReadOffset< byte >( 14 );
        Unknown4 = parser.ReadOffset< byte >( 15 );
        

    }
}