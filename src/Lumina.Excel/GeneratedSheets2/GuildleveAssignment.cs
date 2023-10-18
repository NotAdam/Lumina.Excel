// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GuildleveAssignment", columnHash: 0x129d93fa )]
public partial class GuildleveAssignment : ExcelRow
{
    
    public SeString Type { get; private set; }
    public LazyRow< GuildleveAssignmentTalk > AssignmentTalk { get; private set; }
    public LazyRow< Quest >[] Quest { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Type = parser.ReadOffset< SeString >( 0 );
        AssignmentTalk = new LazyRow< GuildleveAssignmentTalk >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Quest = new LazyRow< Quest >[2];
        for (int i = 0; i < 2; i++)
        	Quest[i] = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( (ushort) ( 8 + i * 4 ) ), language );
        Unknown0 = parser.ReadOffset< byte >( 16 );
        Unknown1 = parser.ReadOffset< byte >( 17 );
        Unknown2 = parser.ReadOffset< bool >( 18 );
        Unknown3 = parser.ReadOffset< bool >( 18, 2 );
        Unknown4 = parser.ReadOffset< bool >( 18, 4 );
        Unknown5 = parser.ReadOffset< bool >( 18, 8 );
        Unknown6 = parser.ReadOffset< bool >( 18, 16 );
        

    }
}