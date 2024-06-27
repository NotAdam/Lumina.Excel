// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ReplaceAction", columnHash: 0x9575012c )]
public partial class ReplaceAction : ExcelRow
{
    
    public LazyRow< Action > Action { get; private set; }
    public LazyRow< Action >[] ReplaceActions { get; private set; }
    public ILazyRow Param1 { get; private set; }
    public ILazyRow Param2 { get; private set; }
    public ILazyRow Param3 { get; private set; }
    public sbyte Type1 { get; private set; }
    public sbyte Type2 { get; private set; }
    public sbyte Type3 { get; private set; }
    public sbyte ReplaceSettable { get; private set; }
    public bool Unknown_70 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Action = new LazyRow< Action >( gameData, parser.ReadOffset< int >( 0 ), language );
        ReplaceActions = new LazyRow< Action >[3];
        for (int i = 0; i < 3; i++)
        	ReplaceActions[i] = new LazyRow< Action >( gameData, parser.ReadOffset< int >( (ushort) ( 4 + i * 4 ) ), language );
        var Param1RowId = parser.ReadOffset< short >( 16 );
        var Param2RowId = parser.ReadOffset< short >( 18 );
        var Param3RowId = parser.ReadOffset< short >( 20 );
        Type1 = parser.ReadOffset< sbyte >( 22 );
        Type2 = parser.ReadOffset< sbyte >( 23 );
        Type3 = parser.ReadOffset< sbyte >( 24 );
        ReplaceSettable = parser.ReadOffset< sbyte >( 25 );
        Unknown_70 = parser.ReadOffset< bool >( 26 );
        
        Param1 = Type1 switch
        {
        	2 => new LazyRow< Status >( gameData, Param1RowId, language ),
        	3 => new LazyRow< Trait >( gameData, Param1RowId, language ),
        	4 => new LazyRow< Status >( gameData, Param1RowId, language ),
        	7 => new LazyRow< Status >( gameData, Param1RowId, language ),
        	12 => new LazyRow< Status >( gameData, Param1RowId, language ),
        	13 => new LazyRow< Status >( gameData, Param1RowId, language ),
        	_ => new EmptyLazyRow( (uint) Param1RowId ),
        };
        Param2 = Type1 switch
        {
        	2 => new LazyRow< Status >( gameData, Param2RowId, language ),
        	3 => new LazyRow< Trait >( gameData, Param2RowId, language ),
        	4 => new LazyRow< Status >( gameData, Param2RowId, language ),
        	7 => new LazyRow< Status >( gameData, Param2RowId, language ),
        	12 => new LazyRow< Status >( gameData, Param2RowId, language ),
        	13 => new LazyRow< Status >( gameData, Param2RowId, language ),
        	_ => new EmptyLazyRow( (uint) Param2RowId ),
        };
        Param3 = Type1 switch
        {
        	2 => new LazyRow< Status >( gameData, Param3RowId, language ),
        	3 => new LazyRow< Trait >( gameData, Param3RowId, language ),
        	4 => new LazyRow< Status >( gameData, Param3RowId, language ),
        	7 => new LazyRow< Status >( gameData, Param3RowId, language ),
        	12 => new LazyRow< Status >( gameData, Param3RowId, language ),
        	13 => new LazyRow< Status >( gameData, Param3RowId, language ),
        	_ => new EmptyLazyRow( (uint) Param3RowId ),
        };
    }
}