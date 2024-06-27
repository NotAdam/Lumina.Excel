// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "SequentialEvent", columnHash: 0xb14c0c35 )]
public partial class SequentialEvent : ExcelRow
{
    public struct UnknownStructStruct
    {
    	public uint Unknown1 { get; internal set; }
    	public uint Unknown2 { get; internal set; }
    	public ushort Unknown3 { get; internal set; }
    	public ushort Unknown4 { get; internal set; }
    	public ushort Unknown5 { get; internal set; }
    }
    
    public UnknownStructStruct[] UnknownStruct { get; private set; }
    public uint Unknown320 { get; private set; }
    public uint Unknown_70 { get; private set; }
    public ushort Unknown321 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        UnknownStruct = new UnknownStructStruct[64];
        for (int i = 0; i < 64; i++)
        {
        	UnknownStruct[i].Unknown1 = parser.ReadOffset< uint >( (ushort) (i * 16 + 0));
        	UnknownStruct[i].Unknown2 = parser.ReadOffset< uint >( (ushort) (i * 16 + 4));
        	UnknownStruct[i].Unknown3 = parser.ReadOffset< ushort >( (ushort) (i * 16 + 8));
        	UnknownStruct[i].Unknown4 = parser.ReadOffset< ushort >( (ushort) (i * 16 + 10));
        	UnknownStruct[i].Unknown5 = parser.ReadOffset< ushort >( (ushort) (i * 16 + 12));
        }
        Unknown320 = parser.ReadOffset< uint >( 1024 );
        Unknown_70 = parser.ReadOffset< uint >( 1028 );
        Unknown321 = parser.ReadOffset< ushort >( 1032 );
        

    }
}