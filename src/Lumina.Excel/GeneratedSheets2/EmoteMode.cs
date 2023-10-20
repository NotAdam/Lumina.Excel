// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EmoteMode", columnHash: 0x087a32e7 )]
public partial class EmoteMode : ExcelRow
{
    
    public LazyRow< Emote > StartEmote { get; private set; }
    public LazyRow< Emote > EndEmote { get; private set; }
    public byte ConditionMode { get; private set; }
    public bool Move { get; private set; }
    public bool Camera { get; private set; }
    public bool EndOnRotate { get; private set; }
    public bool EndOnEmote { get; private set; }
    public bool Unknown0 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        StartEmote = new LazyRow< Emote >( gameData, parser.ReadOffset< ushort >( 0 ), language );
        EndEmote = new LazyRow< Emote >( gameData, parser.ReadOffset< ushort >( 2 ), language );
        ConditionMode = parser.ReadOffset< byte >( 4 );
        Move = parser.ReadOffset< bool >( 5 );
        Camera = parser.ReadOffset< bool >( 5, 2 );
        EndOnRotate = parser.ReadOffset< bool >( 5, 4 );
        EndOnEmote = parser.ReadOffset< bool >( 5, 8 );
        Unknown0 = parser.ReadOffset< bool >( 5, 16 );
        

    }
}