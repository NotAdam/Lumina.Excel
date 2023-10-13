// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "CreditBackImage", columnHash: 0x06eccbe2 )]
public partial class CreditBackImage : ExcelRow
{
    
    public uint BackImage { get; private set; }
    public ushort Unknown0 { get; private set; }
    public ushort Unknown1 { get; private set; }
    public byte Unknown6 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        BackImage = parser.ReadOffset< uint >( 0 );
        Unknown0 = parser.ReadOffset< ushort >( 4 );
        Unknown1 = parser.ReadOffset< ushort >( 6 );
        Unknown6 = parser.ReadOffset< byte >( 8 );
        Unknown2 = parser.ReadOffset< bool >( 9 );
        Unknown3 = parser.ReadOffset< bool >( 9, 2 );
        Unknown4 = parser.ReadOffset< bool >( 9, 4 );
        

    }
}