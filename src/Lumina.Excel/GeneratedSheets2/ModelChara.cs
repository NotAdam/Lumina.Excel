// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ModelChara", columnHash: 0x89b148f4 )]
public partial class ModelChara : ExcelRow
{
    
    public float Unknown0 { get; private set; }
    public float Unknown1 { get; private set; }
    public ushort Model { get; private set; }
    public ushort SEPack { get; private set; }
    public byte Type { get; private set; }
    public byte Base { get; private set; }
    public byte Variant { get; private set; }
    public byte Unknown2 { get; private set; }
    public byte Unknown3 { get; private set; }
    public byte Unknown4 { get; private set; }
    public byte Unknown5 { get; private set; }
    public byte Unknown14 { get; private set; }
    public sbyte Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool PapVariation { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown9 { get; private set; }
    public bool Unknown10 { get; private set; }
    public bool Unknown11 { get; private set; }
    public bool Unknown12 { get; private set; }
    public bool Unknown13 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Unknown0 = parser.ReadOffset< float >( 0 );
        Unknown1 = parser.ReadOffset< float >( 4 );
        Model = parser.ReadOffset< ushort >( 8 );
        SEPack = parser.ReadOffset< ushort >( 10 );
        Type = parser.ReadOffset< byte >( 12 );
        Base = parser.ReadOffset< byte >( 13 );
        Variant = parser.ReadOffset< byte >( 14 );
        Unknown2 = parser.ReadOffset< byte >( 15 );
        Unknown3 = parser.ReadOffset< byte >( 16 );
        Unknown4 = parser.ReadOffset< byte >( 17 );
        Unknown5 = parser.ReadOffset< byte >( 18 );
        Unknown14 = parser.ReadOffset< byte >( 19 );
        Unknown6 = parser.ReadOffset< sbyte >( 20 );
        Unknown7 = parser.ReadOffset< bool >( 21 );
        PapVariation = parser.ReadOffset< bool >( 21, 2 );
        Unknown8 = parser.ReadOffset< bool >( 21, 4 );
        Unknown9 = parser.ReadOffset< bool >( 21, 8 );
        Unknown10 = parser.ReadOffset< bool >( 21, 16 );
        Unknown11 = parser.ReadOffset< bool >( 21, 32 );
        Unknown12 = parser.ReadOffset< bool >( 21, 64 );
        Unknown13 = parser.ReadOffset< bool >( 21, 128 );
        

    }
}