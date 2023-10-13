// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "QuestStatusParam", columnHash: 0xd812e07f )]
public partial class QuestStatusParam : ExcelRow
{
    
    public ushort Unknown0 { get; private set; }
    public short Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< ushort >( 0 );
        Unknown1 = parser.ReadOffset< short >( 2 );
        Unknown2 = parser.ReadOffset< byte >( 4 );
        

    }
}