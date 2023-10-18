// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestRedo", columnHash: 0x9e53f329 )]
public partial class QuestRedo : ExcelRow
{
    public struct QuestRedoParamStruct
    {
    	public LazyRow< Quest > Quest { get; internal set; }
    	public byte UnknownParam { get; internal set; }
    }
    
    public QuestRedoParamStruct[] QuestRedoParam { get; private set; }
    public LazyRow< Quest > FinalQuest { get; private set; }
    public uint Unknown0 { get; private set; }
    public LazyRow< QuestRedoChapter > Chapter { get; private set; }
    public byte Unknown1 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        QuestRedoParam = new QuestRedoParamStruct[32];
        for (int i = 0; i < 32; i++)
        {
        	QuestRedoParam[i].Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( (ushort) (i * 8 + 0) ), language );
        	QuestRedoParam[i].UnknownParam = parser.ReadOffset< byte >( (ushort) (i * 8 + 4));
        }
        FinalQuest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 256 ), language );
        Unknown0 = parser.ReadOffset< uint >( 260 );
        Chapter = new LazyRow< QuestRedoChapter >( gameData, parser.ReadOffset< ushort >( 264 ), language );
        Unknown1 = parser.ReadOffset< byte >( 266 );
        

    }
}