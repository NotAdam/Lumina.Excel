// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ItemFood", columnHash: 0xe09a474d )]
public partial class ItemFood : ExcelRow
{
    
    public short[] Max { get; private set; }
    public short[] MaxHQ { get; private set; }
    public byte EXPBonusPercent { get; private set; }
    public LazyRow< BaseParam >[] BaseParam { get; private set; }
    public sbyte[] Value { get; private set; }
    public sbyte[] ValueHQ { get; private set; }
    public bool[] IsRelative { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Max = new short[3];
        for (int i = 0; i < 3; i++)
        	Max[i] = parser.ReadOffset< short >( 0 + i * 2 );
        MaxHQ = new short[3];
        for (int i = 0; i < 3; i++)
        	MaxHQ[i] = parser.ReadOffset< short >( 6 + i * 2 );
        EXPBonusPercent = parser.ReadOffset< byte >( 12 );
        BaseParam = new LazyRow< BaseParam >[3];
        for (int i = 0; i < 3; i++)
        	BaseParam[i] = new LazyRow< BaseParam >( gameData, parser.ReadOffset< byte >( (ushort) ( 13 + i * 1 ) ), language );
        Value = new sbyte[3];
        for (int i = 0; i < 3; i++)
        	Value[i] = parser.ReadOffset< sbyte >( 16 + i * 1 );
        ValueHQ = new sbyte[3];
        for (int i = 0; i < 3; i++)
        	ValueHQ[i] = parser.ReadOffset< sbyte >( 19 + i * 1 );
        IsRelative = new bool[3];
        for (int i = 0; i < 3; i++)
        	IsRelative[i] = parser.ReadOffset< bool >( 22 + i * 1 );
        

    }
}