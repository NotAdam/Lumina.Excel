// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "NotoriousMonsterTerritory", columnHash: 0xf057da9c )]
public partial class NotoriousMonsterTerritory : ExcelRow
{
    
    public LazyRow< NotoriousMonster >[] NotoriousMonsters { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        NotoriousMonsters = new LazyRow< NotoriousMonster >[10];
        for (int i = 0; i < 10; i++)
        	NotoriousMonsters[i] = new LazyRow< NotoriousMonster >( gameData, parser.ReadOffset< ushort >( (ushort) ( 0 + i * 2 ) ), language );
        

    }
}