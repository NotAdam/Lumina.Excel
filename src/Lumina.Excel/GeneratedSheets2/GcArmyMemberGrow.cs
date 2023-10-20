// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "GcArmyMemberGrow", columnHash: 0xaf66261c )]
public partial class GcArmyMemberGrow : ExcelRow
{
    public struct MemberParamsStruct
    {
    	public LazyRow< GcArmyEquipPreset > EquipPreset { get; internal set; }
    	public byte Physical { get; internal set; }
    	public byte Mental { get; internal set; }
    	public byte Tactical { get; internal set; }
    }
    
    public MemberParamsStruct[] MemberParams { get; private set; }
    public ushort Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public LazyRow< Item > ClassBook { get; private set; }
    public LazyRow< ClassJob > ClassJob { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        MemberParams = new MemberParamsStruct[60];
        for (int i = 0; i < 60; i++)
        {
        	MemberParams[i].EquipPreset = new LazyRow< GcArmyEquipPreset >( gameData, parser.ReadOffset< ushort >( (ushort) (i * 6 + 0) ), language );
        	MemberParams[i].Physical = parser.ReadOffset< byte >( (ushort) (i * 6 + 2));
        	MemberParams[i].Mental = parser.ReadOffset< byte >( (ushort) (i * 6 + 3));
        	MemberParams[i].Tactical = parser.ReadOffset< byte >( (ushort) (i * 6 + 4));
        }
        Unknown0 = parser.ReadOffset< ushort >( 360 );
        Unknown1 = parser.ReadOffset< byte >( 362 );
        Unknown2 = parser.ReadOffset< byte >( 363 );
        Unknown3 = parser.ReadOffset< byte >( 364 );
        ClassBook = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 368 ), language );
        ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadOffset< byte >( 372 ), language );
        

    }
}