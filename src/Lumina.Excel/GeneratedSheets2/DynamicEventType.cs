// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DynamicEventType", columnHash: 0x6be0e840 )]
public partial class DynamicEventType : ExcelRow
{
    
    public uint IconObjective0 { get; private set; }
    public uint IconObjective1 { get; private set; }
    public uint Unknown2 { get; private set; }
    public uint Unknown3 { get; private set; }
    public uint Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        IconObjective0 = parser.ReadOffset< uint >( 0 );
        IconObjective1 = parser.ReadOffset< uint >( 4 );
        Unknown2 = parser.ReadOffset< uint >( 8 );
        Unknown3 = parser.ReadOffset< uint >( 12 );
        Unknown4 = parser.ReadOffset< uint >( 16 );
        

    }
}