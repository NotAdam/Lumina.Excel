// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "EObj", columnHash: 0x82700e8d )]
public partial class EObj : ExcelRow
{
    
    public uint Data { get; private set; }
    public LazyRow< ExportedSG > SgbPath { get; private set; }
    public byte PopType { get; private set; }
    public byte Invisibility { get; private set; }
    public byte EventHighAddition { get; private set; }
    public byte Unknown0 { get; private set; }
    public bool Unknown1 { get; private set; }
    public bool Unknown2 { get; private set; }
    public bool Unknown3 { get; private set; }
    public bool Unknown4 { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool EyeCollision { get; private set; }
    public bool DirectorControl { get; private set; }
    public bool Target { get; private set; }
    public bool Unknown9 { get; private set; }
    public bool AddedIn53 { get; private set; }
    public bool Unknown10 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Data = parser.ReadOffset< uint >( 0 );
        SgbPath = new LazyRow< ExportedSG >( gameData, parser.ReadOffset< ushort >( 4 ), language );
        PopType = parser.ReadOffset< byte >( 6 );
        Invisibility = parser.ReadOffset< byte >( 7 );
        EventHighAddition = parser.ReadOffset< byte >( 8 );
        Unknown0 = parser.ReadOffset< byte >( 9 );
        Unknown1 = parser.ReadOffset< bool >( 10 );
        Unknown2 = parser.ReadOffset< bool >( 11 );
        Unknown3 = parser.ReadOffset< bool >( 12 );
        Unknown4 = parser.ReadOffset< bool >( 13 );
        Unknown5 = parser.ReadOffset< bool >( 14 );
        Unknown6 = parser.ReadOffset< bool >( 15 );
        Unknown7 = parser.ReadOffset< bool >( 16 );
        Unknown8 = parser.ReadOffset< bool >( 17 );
        EyeCollision = parser.ReadOffset< bool >( 18 );
        DirectorControl = parser.ReadOffset< bool >( 18, 2 );
        Target = parser.ReadOffset< bool >( 18, 4 );
        Unknown9 = parser.ReadOffset< bool >( 18, 8 );
        AddedIn53 = parser.ReadOffset< bool >( 18, 16 );
        Unknown10 = parser.ReadOffset< bool >( 18, 32 );
        

    }
}