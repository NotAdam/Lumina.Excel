// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MJIGatheringObject", columnHash: 0xa0ca50af )]
public partial class MJIGatheringObject : ExcelRow
{
    
    public uint MapIcon { get; private set; }
    public uint Unknown2 { get; private set; }
    public LazyRow< EObjName > Name { get; private set; }
    public LazyRow< ExportedSG > SGB { get; private set; }
    public ushort Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        MapIcon = parser.ReadOffset< uint >( 0 );
        Unknown2 = parser.ReadOffset< uint >( 4 );
        Name = new LazyRow< EObjName >( gameData, parser.ReadOffset< uint >( 8 ), language );
        SGB = new LazyRow< ExportedSG >( gameData, parser.ReadOffset< ushort >( 12 ), language );
        Unknown4 = parser.ReadOffset< ushort >( 14 );
        

    }
}