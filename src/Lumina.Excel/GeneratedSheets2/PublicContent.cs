// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PublicContent", columnHash: 0x073aaecf )]
public partial class PublicContent : ExcelRow
{
    
    public SeString Name { get; private set; }
    public uint MapIcon { get; private set; }
    public LazyRow< PublicContentTextData > TextDataStart { get; private set; }
    public LazyRow< PublicContentTextData > TextDataEnd { get; private set; }
    public LazyRow< PublicContentCutscene > StartCutscene { get; private set; }
    public uint LGBEventRange { get; private set; }
    public uint LGBPopRange { get; private set; }
    public LazyRow< PublicContentCutscene > EndCutscene { get; private set; }
    public ushort TimeLimit { get; private set; }
    public LazyRow< ContentFinderCondition > ContentFinderCondition { get; private set; }
    public ILazyRow AdditionalData { get; private set; }
    public ushort Unknown12 { get; private set; }
    public ushort Unknown13 { get; private set; }
    public ushort Unknown14 { get; private set; }
    public ushort Unknown15 { get; private set; }
    public byte Type { get; private set; }
    public byte Unknown11 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        MapIcon = parser.ReadOffset< uint >( 4 );
        TextDataStart = new LazyRow< PublicContentTextData >( gameData, parser.ReadOffset< uint >( 8 ), language );
        TextDataEnd = new LazyRow< PublicContentTextData >( gameData, parser.ReadOffset< uint >( 12 ), language );
        StartCutscene = new LazyRow< PublicContentCutscene >( gameData, parser.ReadOffset< uint >( 16 ), language );
        LGBEventRange = parser.ReadOffset< uint >( 20 );
        LGBPopRange = parser.ReadOffset< uint >( 24 );
        EndCutscene = new LazyRow< PublicContentCutscene >( gameData, parser.ReadOffset< uint >( 28 ), language );
        TimeLimit = parser.ReadOffset< ushort >( 32 );
        ContentFinderCondition = new LazyRow< ContentFinderCondition >( gameData, parser.ReadOffset< ushort >( 34 ), language );
        var AdditionalDataRowId = parser.ReadOffset< ushort >( 36 );
        Unknown12 = parser.ReadOffset< ushort >( 38 );
        Unknown13 = parser.ReadOffset< ushort >( 40 );
        Unknown14 = parser.ReadOffset< ushort >( 42 );
        Unknown15 = parser.ReadOffset< ushort >( 44 );
        Type = parser.ReadOffset< byte >( 46 );
        Unknown11 = parser.ReadOffset< byte >( 47 );
        
        AdditionalData = Type switch
        {
        	3 => new LazyRow< Eureka >( gameData, AdditionalDataRowId, language ),
        	5 => new LazyRow< GFateClimbing2Content >( gameData, AdditionalDataRowId, language ),
        	_ => new EmptyLazyRow( (uint) AdditionalDataRowId ),
        };
    }
}