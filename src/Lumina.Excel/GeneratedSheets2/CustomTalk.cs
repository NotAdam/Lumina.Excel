// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CustomTalk", columnHash: 0xd20fee6c )]
public partial class CustomTalk : ExcelRow
{
    public struct ScriptStruct
    {
    	public SeString ScriptInstruction { get; internal set; }
    	public uint ScriptArg { get; internal set; }
    }
    
    public ScriptStruct[] Script { get; private set; }
    public SeString MainOption { get; private set; }
    public SeString SubOption { get; private set; }
    public SeString Name { get; private set; }
    public uint IconActor { get; private set; }
    public uint IconMap { get; private set; }
    public ILazyRow SpecialLinks { get; private set; }
    public byte Unknown76 { get; private set; }
    public byte Unknown77 { get; private set; }
    public bool Unknown63 { get; private set; }
    public bool Unknown66 { get; private set; }
    public bool Unknown67 { get; private set; }
    public bool Unknown68 { get; private set; }
    public bool Unknown69 { get; private set; }
    public bool Unknown70 { get; private set; }
    public bool Unknown71 { get; private set; }
    public bool Unknown72 { get; private set; }
    public bool Unknown73 { get; private set; }
    public bool Unknown74 { get; private set; }
    public bool Unknown78 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Script = new ScriptStruct[30];
        for (int i = 0; i < 30; i++)
        {
        	Script[i].ScriptInstruction = parser.ReadOffset< SeString >( (ushort) (i * 8 + 0));
        	Script[i].ScriptArg = parser.ReadOffset< uint >( (ushort) (i * 8 + 4));
        }
        MainOption = parser.ReadOffset< SeString >( 240 );
        SubOption = parser.ReadOffset< SeString >( 244 );
        Name = parser.ReadOffset< SeString >( 248 );
        IconActor = parser.ReadOffset< uint >( 252 );
        IconMap = parser.ReadOffset< uint >( 256 );
        SpecialLinks = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( 260 ), language, "CollectablesShop", "ContentEntry", "SpecialShop", "CustomTalkNestHandlers" );
        Unknown76 = parser.ReadOffset< byte >( 264 );
        Unknown77 = parser.ReadOffset< byte >( 265 );
        Unknown63 = parser.ReadOffset< bool >( 266 );
        Unknown66 = parser.ReadOffset< bool >( 266, 2 );
        Unknown67 = parser.ReadOffset< bool >( 266, 4 );
        Unknown68 = parser.ReadOffset< bool >( 266, 8 );
        Unknown69 = parser.ReadOffset< bool >( 266, 16 );
        Unknown70 = parser.ReadOffset< bool >( 266, 32 );
        Unknown71 = parser.ReadOffset< bool >( 266, 64 );
        Unknown72 = parser.ReadOffset< bool >( 266, 128 );
        Unknown73 = parser.ReadOffset< bool >( 267 );
        Unknown74 = parser.ReadOffset< bool >( 267, 2 );
        Unknown78 = parser.ReadOffset< bool >( 267, 4 );
        

    }
}