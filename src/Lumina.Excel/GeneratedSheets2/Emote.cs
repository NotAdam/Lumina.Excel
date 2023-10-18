// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Emote", columnHash: 0xf3afded2 )]
public partial class Emote : ExcelRow
{
    
    public SeString Name { get; private set; }
    public uint UnlockLink { get; private set; }
    public LazyRow< TextCommand > TextCommand { get; private set; }
    public LazyRow< ActionTimeline >[] ActionTimeline { get; private set; }
    public ushort Order { get; private set; }
    public ushort Icon { get; private set; }
    public LazyRow< LogMessage > LogMessageTargeted { get; private set; }
    public LazyRow< LogMessage > LogMessageUntargeted { get; private set; }
    public ushort Unknown0 { get; private set; }
    public LazyRow< EmoteCategory > EmoteCategory { get; private set; }
    public LazyRow< EmoteMode > EmoteMode { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool HasCancelEmote { get; private set; }
    public bool DrawsWeapon { get; private set; }
    public bool Unknown6 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Name = parser.ReadOffset< SeString >( 0 );
        UnlockLink = parser.ReadOffset< uint >( 4 );
        TextCommand = new LazyRow< TextCommand >( gameData, parser.ReadOffset< int >( 8 ), language );
        ActionTimeline = new LazyRow< ActionTimeline >[7];
        for (int i = 0; i < 7; i++)
        	ActionTimeline[i] = new LazyRow< ActionTimeline >( gameData, parser.ReadOffset< ushort >( (ushort) ( 12 + i * 2 ) ), language );
        Order = parser.ReadOffset< ushort >( 26 );
        Icon = parser.ReadOffset< ushort >( 28 );
        LogMessageTargeted = new LazyRow< LogMessage >( gameData, parser.ReadOffset< ushort >( 30 ), language );
        LogMessageUntargeted = new LazyRow< LogMessage >( gameData, parser.ReadOffset< ushort >( 32 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 34 );
        EmoteCategory = new LazyRow< EmoteCategory >( gameData, parser.ReadOffset< byte >( 36 ), language );
        EmoteMode = new LazyRow< EmoteMode >( gameData, parser.ReadOffset< byte >( 37 ), language );
        Unknown1 = parser.ReadOffset< bool >( 38 );
        Unknown2 = parser.ReadOffset< bool >( 38, 2 );
        Unknown3 = parser.ReadOffset< bool >( 38, 4 );
        Unknown4 = parser.ReadOffset< bool >( 38, 8 );
        Unknown5 = parser.ReadOffset< bool >( 38, 16 );
        HasCancelEmote = parser.ReadOffset< bool >( 38, 32 );
        DrawsWeapon = parser.ReadOffset< bool >( 38, 64 );
        Unknown6 = parser.ReadOffset< bool >( 38, 128 );
        

    }
}