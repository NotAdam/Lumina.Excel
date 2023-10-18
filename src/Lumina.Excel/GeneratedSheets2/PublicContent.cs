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
    public ushort Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public ushort Unknown2 { get; private set; }
    public ushort Unknown3 { get; private set; }
    public byte Type { get; private set; }
    public byte Unknown4 { get; private set; }
    
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
        Unknown0 = parser.ReadOffset< ushort >( 38 );
        Unknown1 = parser.ReadOffset< ushort >( 40 );
        Unknown2 = parser.ReadOffset< ushort >( 42 );
        Unknown3 = parser.ReadOffset< ushort >( 44 );
        Type = parser.ReadOffset< byte >( 46 );
        Unknown4 = parser.ReadOffset< byte >( 47 );
        
        AdditionalData = Type switch
        {
        	3 => new LazyRow< Eureka >( gameData, AdditionalDataRowId, language ),
        	5 => new LazyRow< GFateClimbing2Content >( gameData, AdditionalDataRowId, language ),
        	_ => new EmptyLazyRow( (uint) AdditionalDataRowId ),
        };
    }
}