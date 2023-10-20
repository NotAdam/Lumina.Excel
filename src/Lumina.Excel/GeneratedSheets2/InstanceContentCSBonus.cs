// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "InstanceContentCSBonus", columnHash: 0x43042e70 )]
public partial class InstanceContentCSBonus : ExcelRow
{
    
    public LazyRow< Item > Item { get; private set; }
    public LazyRow< InstanceContent > Instance { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Item = new LazyRow< Item >( gameData, parser.ReadOffset< uint >( 0 ), language );
        Instance = new LazyRow< InstanceContent >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        Unknown0 = parser.ReadOffset< byte >( 6 );
        Unknown1 = parser.ReadOffset< byte >( 7 );
        Unknown2 = parser.ReadOffset< byte >( 8 );
        

    }
}