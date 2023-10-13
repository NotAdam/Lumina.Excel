// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "OpenContent", columnHash: 0x170b114d )]
public partial class OpenContent : ExcelRow
{
    public struct OpenContentDataStruct
    {
    	public LazyRow< OpenContentCandidateName > CandidateName { get; internal set; }
    	public LazyRow< ContentFinderCondition > Content { get; internal set; }
    }
    
    public OpenContentDataStruct[] OpenContentData { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        OpenContentData = new OpenContentDataStruct[16];
        for (int i = 0; i < 16; i++)
        {
        	OpenContentData[i].CandidateName = new LazyRow< OpenContentCandidateName >( gameData, parser.ReadOffset< uint >( (ushort) (i * 8 + 0) ), language );
        	OpenContentData[i].Content = new LazyRow< ContentFinderCondition >( gameData, parser.ReadOffset< ushort >( (ushort) (i * 8 + 4) ), language );
        }
        

    }
}