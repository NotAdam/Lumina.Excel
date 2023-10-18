// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIBuildingPlace", columnHash: 0x369fb53b )]
public partial class MJIBuildingPlace : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public LazyRow< EObjName > Name { get; private set; }
    public LazyRow< ExportedSG > SGB { get; private set; }
    public short Unknown1 { get; private set; }
    public short Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        Name = new LazyRow< EObjName >( gameData, parser.ReadOffset< uint >( 4 ), language );
        SGB = new LazyRow< ExportedSG >( gameData, parser.ReadOffset< uint >( 8 ), language );
        Unknown1 = parser.ReadOffset< short >( 12 );
        Unknown2 = parser.ReadOffset< short >( 14 );
        Unknown3 = parser.ReadOffset< byte >( 16 );
        

    }
}