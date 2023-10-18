// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentExAction", columnHash: 0x8690a89e )]
public partial class ContentExAction : ExcelRow
{
    
    public LazyRow< Action > Name { get; private set; }
    public uint Unknown0 { get; private set; }
    public byte Charges { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = new LazyRow< Action >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Unknown0 = parser.ReadOffset< uint >( 4 );
        Charges = parser.ReadOffset< byte >( 8 );
        Unknown1 = parser.ReadOffset< byte >( 9 );
        

    }
}