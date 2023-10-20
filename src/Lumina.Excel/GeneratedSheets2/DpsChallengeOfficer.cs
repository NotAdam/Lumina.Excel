// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "DpsChallengeOfficer", columnHash: 0xef9733d1 )]
public partial class DpsChallengeOfficer : ExcelRow
{
    
    public LazyRow< DpsChallenge >[] ChallengeName { get; private set; }
    public LazyRow< Quest > UnlockQuest { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ChallengeName = new LazyRow< DpsChallenge >[25];
        for (int i = 0; i < 25; i++)
        	ChallengeName[i] = new LazyRow< DpsChallenge >( gameData, parser.ReadOffset< ushort >( (ushort) ( 0 + i * 2 ) ), language );
        UnlockQuest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 52 ), language );
        

    }
}