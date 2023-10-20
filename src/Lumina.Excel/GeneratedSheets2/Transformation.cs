// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Transformation", columnHash: 0xa1ab3fab )]
public partial class Transformation : ExcelRow
{
    
    public float Speed { get; private set; }
    public float Scale { get; private set; }
    public LazyRow< Action > Action6 { get; private set; }
    public LazyRow< BNpcCustomize > BNpcCustomize { get; private set; }
    public LazyRow< NpcEquip > NpcEquip { get; private set; }
    public LazyRow< BNpcName > BNpcName { get; private set; }
    public LazyRow< Action > Action0 { get; private set; }
    public LazyRow< Action > Action1 { get; private set; }
    public LazyRow< Action > Action2 { get; private set; }
    public LazyRow< Action > Action3 { get; private set; }
    public LazyRow< Action > Action4 { get; private set; }
    public LazyRow< Action > Action5 { get; private set; }
    public LazyRow< RPParameter > RPParameter { get; private set; }
    public LazyRow< Action > RemoveAction { get; private set; }
    public LazyRow< VFX > StartVFX { get; private set; }
    public LazyRow< VFX > EndVFX { get; private set; }
    public LazyRow< Action > Action7 { get; private set; }
    public LazyRow< ModelChara > Model { get; private set; }
    public byte Unknown0 { get; private set; }
    public byte Unknown1 { get; private set; }
    public byte Unknown2 { get; private set; }
    public sbyte Unknown3 { get; private set; }
    public sbyte Unknown4 { get; private set; }
    public bool ExHotbarEnableConfig { get; private set; }
    public bool Unknown5 { get; private set; }
    public bool Unknown6 { get; private set; }
    public bool Unknown7 { get; private set; }
    public bool Unknown8 { get; private set; }
    public bool Unknown9 { get; private set; }
    public bool Unknown10 { get; private set; }
    public bool Unknown11 { get; private set; }
    public bool Unknown12 { get; private set; }
    public bool Unknown13 { get; private set; }
    public bool IsPvP { get; private set; }
    public bool IsEvent { get; private set; }
    public bool PlayerCamera { get; private set; }
    public bool Unknown14 { get; private set; }
    public bool Unknown15 { get; private set; }
    public bool Unknown16 { get; private set; }
    public bool Unknown17 { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Speed = parser.ReadOffset< float >( 0 );
        Scale = parser.ReadOffset< float >( 4 );
        Action6 = new LazyRow< Action >( gameData, parser.ReadOffset< uint >( 8 ), language );
        BNpcCustomize = new LazyRow< BNpcCustomize >( gameData, parser.ReadOffset< int >( 12 ), language );
        NpcEquip = new LazyRow< NpcEquip >( gameData, parser.ReadOffset< int >( 16 ), language );
        BNpcName = new LazyRow< BNpcName >( gameData, parser.ReadOffset< ushort >( 20 ), language );
        Action0 = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 22 ), language );
        Action1 = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 24 ), language );
        Action2 = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 26 ), language );
        Action3 = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 28 ), language );
        Action4 = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 30 ), language );
        Action5 = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 32 ), language );
        RPParameter = new LazyRow< RPParameter >( gameData, parser.ReadOffset< ushort >( 34 ), language );
        RemoveAction = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 36 ), language );
        StartVFX = new LazyRow< VFX >( gameData, parser.ReadOffset< ushort >( 38 ), language );
        EndVFX = new LazyRow< VFX >( gameData, parser.ReadOffset< ushort >( 40 ), language );
        Action7 = new LazyRow< Action >( gameData, parser.ReadOffset< ushort >( 42 ), language );
        Model = new LazyRow< ModelChara >( gameData, parser.ReadOffset< short >( 44 ), language );
        Unknown0 = parser.ReadOffset< byte >( 46 );
        Unknown1 = parser.ReadOffset< byte >( 47 );
        Unknown2 = parser.ReadOffset< byte >( 48 );
        Unknown3 = parser.ReadOffset< sbyte >( 49 );
        Unknown4 = parser.ReadOffset< sbyte >( 50 );
        ExHotbarEnableConfig = parser.ReadOffset< bool >( 51 );
        Unknown5 = parser.ReadOffset< bool >( 52 );
        Unknown6 = parser.ReadOffset< bool >( 53 );
        Unknown7 = parser.ReadOffset< bool >( 54 );
        Unknown8 = parser.ReadOffset< bool >( 55 );
        Unknown9 = parser.ReadOffset< bool >( 56 );
        Unknown10 = parser.ReadOffset< bool >( 57 );
        Unknown11 = parser.ReadOffset< bool >( 58 );
        Unknown12 = parser.ReadOffset< bool >( 58, 2 );
        Unknown13 = parser.ReadOffset< bool >( 58, 4 );
        IsPvP = parser.ReadOffset< bool >( 58, 8 );
        IsEvent = parser.ReadOffset< bool >( 58, 16 );
        PlayerCamera = parser.ReadOffset< bool >( 58, 32 );
        Unknown14 = parser.ReadOffset< bool >( 58, 64 );
        Unknown15 = parser.ReadOffset< bool >( 58, 128 );
        Unknown16 = parser.ReadOffset< bool >( 59 );
        Unknown17 = parser.ReadOffset< bool >( 59, 2 );
        

    }
}