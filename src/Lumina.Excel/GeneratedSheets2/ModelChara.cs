// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ModelChara", columnHash: 0x8d35f5ed )]
public partial class ModelChara : ExcelRow
{
    
    public float Unknown18 { get; private set; }
    public float Unknown19 { get; private set; }
    public ushort Model { get; private set; }
    public ushort SEPack { get; private set; }
    public byte Type { get; private set; }
    public byte Base { get; private set; }
    public byte Variant { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown8 { get; private set; }
    public byte Unknown15 { get; private set; }
    public byte Unknown17 { get; private set; }
    public sbyte Unknown9 { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool PapVariation { get; private set; }
    public bool Unknown10 { get; private set; }
    public bool Unknown11 { get; private set; }
    public bool Unknown12 { get; private set; }
    public bool Unknown13 { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool Unknown16 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown18 = parser.ReadOffset< float >( 0 );
        Unknown19 = parser.ReadOffset< float >( 4 );
        Model = parser.ReadOffset< ushort >( 8 );
        SEPack = parser.ReadOffset< ushort >( 10 );
        Type = parser.ReadOffset< byte >( 12 );
        Base = parser.ReadOffset< byte >( 13 );
        Variant = parser.ReadOffset< byte >( 14 );
        Unknown5 = parser.ReadOffset< byte >( 15 );
        Unknown8 = parser.ReadOffset< byte >( 16 );
        Unknown15 = parser.ReadOffset< byte >( 17 );
        Unknown17 = parser.ReadOffset< byte >( 18 );
        Unknown9 = parser.ReadOffset< sbyte >( 19 );
        Unknown6 = parser.ReadOffset< bool >( 20 );
        PapVariation = parser.ReadOffset< bool >( 20, 2 );
        Unknown10 = parser.ReadOffset< bool >( 20, 4 );
        Unknown11 = parser.ReadOffset< bool >( 20, 8 );
        Unknown12 = parser.ReadOffset< bool >( 20, 16 );
        Unknown13 = parser.ReadOffset< bool >( 20, 32 );
        Unknown14 = parser.ReadOffset< bool >( 20, 64 );
        Unknown16 = parser.ReadOffset< bool >( 20, 128 );
        

    }
}