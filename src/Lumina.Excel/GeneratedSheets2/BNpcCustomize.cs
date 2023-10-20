// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "BNpcCustomize", columnHash: 0x18f060d4 )]
public partial class BNpcCustomize : ExcelRow
{
    
    public LazyRow< Race > Race { get; private set; }
    public byte Gender { get; private set; }
    public byte BodyType { get; private set; }
    public byte Height { get; private set; }
    public LazyRow< Tribe > Tribe { get; private set; }
    public byte Face { get; private set; }
    public byte HairStyle { get; private set; }
    public byte HairHighlight { get; private set; }
    public byte SkinColor { get; private set; }
    public byte EyeHeterochromia { get; private set; }
    public byte HairColor { get; private set; }
    public byte HairHighlightColor { get; private set; }
    public byte FacialFeature { get; private set; }
    public byte FacialFeatureColor { get; private set; }
    public byte Eyebrows { get; private set; }
    public byte EyeColor { get; private set; }
    public byte EyeShape { get; private set; }
    public byte Nose { get; private set; }
    public byte Jaw { get; private set; }
    public byte Mouth { get; private set; }
    public byte LipColor { get; private set; }
    public byte BustOrTone1 { get; private set; }
    public byte ExtraFeature1 { get; private set; }
    public byte ExtraFeature2OrBust { get; private set; }
    public byte FacePaint { get; private set; }
    public byte FacePaintColor { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        Race = new LazyRow< Race >( gameData, parser.ReadOffset< byte >( 0 ), language );
        Gender = parser.ReadOffset< byte >( 1 );
        BodyType = parser.ReadOffset< byte >( 2 );
        Height = parser.ReadOffset< byte >( 3 );
        Tribe = new LazyRow< Tribe >( gameData, parser.ReadOffset< byte >( 4 ), language );
        Face = parser.ReadOffset< byte >( 5 );
        HairStyle = parser.ReadOffset< byte >( 6 );
        HairHighlight = parser.ReadOffset< byte >( 7 );
        SkinColor = parser.ReadOffset< byte >( 8 );
        EyeHeterochromia = parser.ReadOffset< byte >( 9 );
        HairColor = parser.ReadOffset< byte >( 10 );
        HairHighlightColor = parser.ReadOffset< byte >( 11 );
        FacialFeature = parser.ReadOffset< byte >( 12 );
        FacialFeatureColor = parser.ReadOffset< byte >( 13 );
        Eyebrows = parser.ReadOffset< byte >( 14 );
        EyeColor = parser.ReadOffset< byte >( 15 );
        EyeShape = parser.ReadOffset< byte >( 16 );
        Nose = parser.ReadOffset< byte >( 17 );
        Jaw = parser.ReadOffset< byte >( 18 );
        Mouth = parser.ReadOffset< byte >( 19 );
        LipColor = parser.ReadOffset< byte >( 20 );
        BustOrTone1 = parser.ReadOffset< byte >( 21 );
        ExtraFeature1 = parser.ReadOffset< byte >( 22 );
        ExtraFeature2OrBust = parser.ReadOffset< byte >( 23 );
        FacePaint = parser.ReadOffset< byte >( 24 );
        FacePaintColor = parser.ReadOffset< byte >( 25 );
        

    }
}