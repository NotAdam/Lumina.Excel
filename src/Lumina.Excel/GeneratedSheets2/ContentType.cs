// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ContentType", columnHash: 0xb19e831d )]
public partial class ContentType : ExcelRow
{
    
    public SeString Name { get; private set; }
    public uint Icon { get; private set; }
    public uint IconDutyFinder { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Icon = parser.ReadOffset< uint >( 4 );
        IconDutyFinder = parser.ReadOffset< uint >( 8 );
        Unknown1 = parser.ReadOffset< byte >( 12 );
        Unknown2 = parser.ReadOffset< byte >( 13 );
        

    }
}