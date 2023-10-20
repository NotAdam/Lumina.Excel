// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "TerritoryIntendedUse", columnHash: 0xcc20ac70 )]
public partial class TerritoryIntendedUse : ExcelRow
{
    
    public ushort Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
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
    public bool Unknown16 { get; private set; }
    public bool Unknown17 { get; private set; }
    public bool Unknown18 { get; private set; }
    public bool Unknown19 { get; private set; }
    public bool Unknown20 { get; private set; }
    public bool Unknown21 { get; private set; }
    public bool Unknown22 { get; private set; }
    public bool Unknown23 { get; private set; }
    public bool Unknown24 { get; private set; }
    public bool Unknown25 { get; private set; }
    public bool Unknown26 { get; private set; }
    public bool Unknown27 { get; private set; }
    public bool Unknown28 { get; private set; }
    public bool Unknown29 { get; private set; }
    public bool Unknown30 { get; private set; }
    public bool Unknown31 { get; private set; }
    public bool Unknown32 { get; private set; }
    public bool Unknown33 { get; private set; }
    public bool Unknown34 { get; private set; }
    public bool Unknown35 { get; private set; }
    public bool Unknown36 { get; private set; }
    public bool Unknown37 { get; private set; }
    public bool Unknown38 { get; private set; }
    public bool Unknown39 { get; private set; }
    public bool Unknown40 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< ushort >( 0 );
        Unknown1 = parser.ReadOffset< byte >( 2 );
        Unknown2 = parser.ReadOffset< byte >( 3 );
        Unknown3 = parser.ReadOffset< byte >( 4 );
        Unknown4 = parser.ReadOffset< bool >( 5 );
        Unknown5 = parser.ReadOffset< bool >( 5, 2 );
        Unknown6 = parser.ReadOffset< bool >( 5, 4 );
        Unknown7 = parser.ReadOffset< bool >( 5, 8 );
        Unknown8 = parser.ReadOffset< bool >( 5, 16 );
        Unknown9 = parser.ReadOffset< bool >( 5, 32 );
        Unknown10 = parser.ReadOffset< bool >( 5, 64 );
        Unknown11 = parser.ReadOffset< bool >( 5, 128 );
        Unknown12 = parser.ReadOffset< bool >( 6 );
        Unknown13 = parser.ReadOffset< bool >( 6, 2 );
        Unknown14 = parser.ReadOffset< bool >( 6, 4 );
        Unknown15 = parser.ReadOffset< bool >( 6, 8 );
        Unknown16 = parser.ReadOffset< bool >( 6, 16 );
        Unknown17 = parser.ReadOffset< bool >( 6, 32 );
        Unknown18 = parser.ReadOffset< bool >( 6, 64 );
        Unknown19 = parser.ReadOffset< bool >( 6, 128 );
        Unknown20 = parser.ReadOffset< bool >( 7 );
        Unknown21 = parser.ReadOffset< bool >( 7, 2 );
        Unknown22 = parser.ReadOffset< bool >( 7, 4 );
        Unknown23 = parser.ReadOffset< bool >( 7, 8 );
        Unknown24 = parser.ReadOffset< bool >( 7, 16 );
        Unknown25 = parser.ReadOffset< bool >( 7, 32 );
        Unknown26 = parser.ReadOffset< bool >( 7, 64 );
        Unknown27 = parser.ReadOffset< bool >( 7, 128 );
        Unknown28 = parser.ReadOffset< bool >( 8 );
        Unknown29 = parser.ReadOffset< bool >( 8, 2 );
        Unknown30 = parser.ReadOffset< bool >( 8, 4 );
        Unknown31 = parser.ReadOffset< bool >( 8, 8 );
        Unknown32 = parser.ReadOffset< bool >( 8, 16 );
        Unknown33 = parser.ReadOffset< bool >( 8, 32 );
        Unknown34 = parser.ReadOffset< bool >( 8, 64 );
        Unknown35 = parser.ReadOffset< bool >( 8, 128 );
        Unknown36 = parser.ReadOffset< bool >( 9 );
        Unknown37 = parser.ReadOffset< bool >( 9, 2 );
        Unknown38 = parser.ReadOffset< bool >( 9, 4 );
        Unknown39 = parser.ReadOffset< bool >( 9, 8 );
        Unknown40 = parser.ReadOffset< bool >( 9, 16 );
        

    }
}