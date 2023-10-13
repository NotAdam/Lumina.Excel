// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "PartyContent", columnHash: 0x0fe3ae35 )]
public partial class PartyContent : ExcelRow
{
    
    public uint[] LGBEventObject { get; private set; }
    public uint[] LGBEventRange { get; private set; }
    public uint[] LGBEventObject2 { get; private set; }
    public LazyRow< PartyContentTextData > TextDataStart { get; private set; }
    public LazyRow< PartyContentTextData > TextDataEnd { get; private set; }
    public uint Image { get; private set; }
    public ushort TimeLimit { get; private set; }
    public ushort Unknown32 { get; private set; }
    public LazyRow< ContentFinderCondition > ContentFinderCondition { get; private set; }
    public byte Key { get; private set; }
    public byte Unknown35 { get; private set; }
    public bool Name { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        LGBEventObject = new uint[9];
        for (int i = 0; i < 9; i++)
        	LGBEventObject[i] = parser.ReadOffset< uint >( 0 + i * 4 );
        LGBEventRange = new uint[9];
        for (int i = 0; i < 9; i++)
        	LGBEventRange[i] = parser.ReadOffset< uint >( 36 + i * 4 );
        LGBEventObject2 = new uint[9];
        for (int i = 0; i < 9; i++)
        	LGBEventObject2[i] = parser.ReadOffset< uint >( 72 + i * 4 );
        TextDataStart = new LazyRow< PartyContentTextData >( gameData, parser.ReadOffset< uint >( 108 ), language );
        TextDataEnd = new LazyRow< PartyContentTextData >( gameData, parser.ReadOffset< uint >( 112 ), language );
        Image = parser.ReadOffset< uint >( 116 );
        TimeLimit = parser.ReadOffset< ushort >( 120 );
        Unknown32 = parser.ReadOffset< ushort >( 122 );
        ContentFinderCondition = new LazyRow< ContentFinderCondition >( gameData, parser.ReadOffset< ushort >( 124 ), language );
        Key = parser.ReadOffset< byte >( 126 );
        Unknown35 = parser.ReadOffset< byte >( 127 );
        Name = parser.ReadOffset< bool >( 128 );
        

    }
}