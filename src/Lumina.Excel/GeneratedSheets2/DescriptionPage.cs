// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DescriptionPage", columnHash: 0xe721cad2 )]
public partial class DescriptionPage : ExcelRow
{
    
    public LazyRow< Quest > Quest { get; private set; }
    public uint[] Image { get; private set; }
    public LazyRow< DescriptionString >[] Text { get; private set; }
    public ushort Unknown25 { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Image = new uint[11];
        for (int i = 0; i < 11; i++)
        	Image[i] = parser.ReadOffset< uint >( 4 + i * 4 );
        Text = new LazyRow< DescriptionString >[11];
        for (int i = 0; i < 11; i++)
        	Text[i] = new LazyRow< DescriptionString >( gameData, parser.ReadOffset< ushort >( (ushort) ( 48 + i * 2 ) ), language );
        Unknown25 = parser.ReadOffset< ushort >( 70 );
        Unknown0 = parser.ReadOffset< byte >( 72 );
        Unknown2 = parser.ReadOffset< byte >( 73 );
        

    }
}