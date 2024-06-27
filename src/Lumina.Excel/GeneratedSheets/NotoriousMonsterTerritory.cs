// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NotoriousMonsterTerritory", columnHash: 0xf057da9c )]
    public partial class NotoriousMonsterTerritory : ExcelRow
    {
        
        public LazyRow< NotoriousMonster >[] NotoriousMonsters { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            NotoriousMonsters = new LazyRow< NotoriousMonster >[ 10 ];
            for( var i = 0; i < 10; i++ )
                NotoriousMonsters[ i ] = new LazyRow< NotoriousMonster >( gameData, parser.ReadColumn< ushort >( 0 + i ), language );
        }
    }
}