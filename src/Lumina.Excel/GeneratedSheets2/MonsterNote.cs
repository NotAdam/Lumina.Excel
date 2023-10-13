// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MonsterNote", columnHash: 0x50b4cd8f )]
public partial class MonsterNote : ExcelRow
{
    
    public SeString Name { get; private set; }
    public uint Reward { get; private set; }
    public LazyRow< MonsterNoteTarget >[] MonsterNoteTarget { get; private set; }
    public byte[] Count { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        Reward = parser.ReadOffset< uint >( 4 );
        MonsterNoteTarget = new LazyRow< MonsterNoteTarget >[4];
        for (int i = 0; i < 4; i++)
        	MonsterNoteTarget[i] = new LazyRow< MonsterNoteTarget >( gameData, parser.ReadOffset< ushort >( (ushort) ( 8 + i * 2 ) ), language );
        Count = new byte[4];
        for (int i = 0; i < 4; i++)
        	Count[i] = parser.ReadOffset< byte >( 16 + i * 1 );
        

    }
}