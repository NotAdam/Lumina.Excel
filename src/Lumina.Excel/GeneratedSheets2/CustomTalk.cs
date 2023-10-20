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
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown9 { get; private set; }
    public bool Unknown10 { get; private set; }
    public bool Unknown11 { get; private set; }
    public bool Unknown12 { get; private set; }
    
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
        Unknown0 = parser.ReadOffset< byte >( 264 );
        Unknown1 = parser.ReadOffset< byte >( 265 );
        Unknown2 = parser.ReadOffset< bool >( 266 );
        Unknown3 = parser.ReadOffset< bool >( 266, 2 );
        Unknown4 = parser.ReadOffset< bool >( 266, 4 );
        Unknown5 = parser.ReadOffset< bool >( 266, 8 );
        Unknown6 = parser.ReadOffset< bool >( 266, 16 );
        Unknown7 = parser.ReadOffset< bool >( 266, 32 );
        Unknown8 = parser.ReadOffset< bool >( 266, 64 );
        Unknown9 = parser.ReadOffset< bool >( 266, 128 );
        Unknown10 = parser.ReadOffset< bool >( 267 );
        Unknown11 = parser.ReadOffset< bool >( 267, 2 );
        Unknown12 = parser.ReadOffset< bool >( 267, 4 );
        

    }
}