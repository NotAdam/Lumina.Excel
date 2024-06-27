// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestEffect", columnHash: 0x899c55ad )]
public partial class QuestEffect : ExcelRow
{
    public struct UnknownStructStruct
    {
    	public uint Unknown1 { get; internal set; }
    	public uint Unknown_70 { get; internal set; }
    	public byte Unknown2 { get; internal set; }
    }
    
    public UnknownStructStruct[] UnknownStruct { get; private set; }
    public uint Unknown8 { get; private set; }
    public uint Unknown9 { get; private set; }
    public bool Unknown_70 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        UnknownStruct = new UnknownStructStruct[4];
        for (int i = 0; i < 4; i++)
        {
        	UnknownStruct[i].Unknown1 = parser.ReadOffset< uint >( (ushort) (i * 12 + 0));
        	UnknownStruct[i].Unknown_70 = parser.ReadOffset< uint >( (ushort) (i * 12 + 4));
        	UnknownStruct[i].Unknown2 = parser.ReadOffset< byte >( (ushort) (i * 12 + 8));
        }
        Unknown8 = parser.ReadOffset< uint >( 48 );
        Unknown9 = parser.ReadOffset< uint >( 52 );
        Unknown_70 = parser.ReadOffset< bool >( 56 );
        

    }
}