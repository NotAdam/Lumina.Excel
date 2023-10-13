// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "FateMode", columnHash: 0x6be0e840 )]
public partial class FateMode : ExcelRow
{
    
    public uint Unknown0 { get; private set; }
    public uint MotivationIcon { get; private set; }
    public uint MotivationMapMarker { get; private set; }
    public uint ObjectiveIcon { get; private set; }
    public uint ObjectiveMapMarker { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< uint >( 0 );
        MotivationIcon = parser.ReadOffset< uint >( 4 );
        MotivationMapMarker = parser.ReadOffset< uint >( 8 );
        ObjectiveIcon = parser.ReadOffset< uint >( 12 );
        ObjectiveMapMarker = parser.ReadOffset< uint >( 16 );
        

    }
}