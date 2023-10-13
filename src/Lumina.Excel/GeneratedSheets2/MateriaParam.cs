// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "MateriaParam", columnHash: 0xf5bcbfdb )]
public partial class MateriaParam : ExcelRow
{
    
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
    public bool Unknown13 { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool Unknown15 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< byte >( 0 );
        Unknown1 = parser.ReadOffset< byte >( 1 );
        Unknown2 = parser.ReadOffset< bool >( 2 );
        Unknown3 = parser.ReadOffset< bool >( 3 );
        Unknown4 = parser.ReadOffset< bool >( 4 );
        Unknown5 = parser.ReadOffset< bool >( 5 );
        Unknown6 = parser.ReadOffset< bool >( 6 );
        Unknown7 = parser.ReadOffset< bool >( 7 );
        Unknown8 = parser.ReadOffset< bool >( 8 );
        Unknown9 = parser.ReadOffset< bool >( 9 );
        Unknown10 = parser.ReadOffset< bool >( 10 );
        Unknown11 = parser.ReadOffset< bool >( 11 );
        Unknown12 = parser.ReadOffset< bool >( 12 );
        Unknown13 = parser.ReadOffset< bool >( 13 );
        Unknown14 = parser.ReadOffset< bool >( 14 );
        Unknown15 = parser.ReadOffset< bool >( 15 );
        

    }
}