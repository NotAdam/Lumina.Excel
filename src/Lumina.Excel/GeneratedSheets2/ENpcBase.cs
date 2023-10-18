// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "ENpcBase", columnHash: 0x927347d8 )]
public partial class ENpcBase : ExcelRow
{
    
    public ILazyRow[] ENpcData { get; private set; }
    public ulong ModelMainHand { get; private set; }
    public ulong ModelOffHand { get; private set; }
    public float Scale { get; private set; }
    public uint ModelHead { get; private set; }
    public uint ModelBody { get; private set; }
    public uint ModelHands { get; private set; }
    public uint ModelLegs { get; private set; }
    public uint ModelFeet { get; private set; }
    public uint ModelEars { get; private set; }
    public uint ModelNeck { get; private set; }
    public uint ModelWrists { get; private set; }
    public uint ModelLeftRing { get; private set; }
    public uint ModelRightRing { get; private set; }
    public ushort EventHandler { get; private set; }
    public LazyRow< ModelChara > ModelChara { get; private set; }
    public LazyRow< NpcEquip > NpcEquip { get; private set; }
    public LazyRow< Behavior > Behavior { get; private set; }
    public LazyRow< Balloon > Balloon { get; private set; }
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
    public byte Unknown0 { get; private set; }
    public LazyRow< Stain > DyeMainHand { get; private set; }
    public LazyRow< Stain > DyeOffHand { get; private set; }
    public LazyRow< Stain > DyeHead { get; private set; }
    public LazyRow< Stain > DyeBody { get; private set; }
    public LazyRow< Stain > DyeHands { get; private set; }
    public LazyRow< Stain > DyeLegs { get; private set; }
    public LazyRow< Stain > DyeFeet { get; private set; }
    public LazyRow< Stain > DyeEars { get; private set; }
    public LazyRow< Stain > DyeNeck { get; private set; }
    public LazyRow< Stain > DyeWrists { get; private set; }
    public LazyRow< Stain > DyeLeftRing { get; private set; }
    public LazyRow< Stain > DyeRightRing { get; private set; }
    public byte Invisibility { get; private set; }
    public byte DefaultBalloon { get; private set; }
    public byte Unknown1 { get; private set; }
    public bool Important { get; private set; }
    public bool Visor { get; private set; }
    public bool NotRewriteHeight { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        ENpcData = new ILazyRow[32];
        for (int i = 0; i < 32; i++)
        	ENpcData[i] = EmptyLazyRow.GetFirstLazyRowOrEmpty( gameData, (uint) parser.ReadOffset< uint >( 0 + i * 4 ), language, "ChocoboTaxiStand", "CraftLeve", "CustomTalk", "DefaultTalk", "FccShop", "GCShop", "GilShop", "GuildleveAssignment", "GuildOrderGuide", "GuildOrderOfficer", "Quest", "SpecialShop", "Story", "SwitchTalk", "TopicSelect", "TripleTriad", "Warp" );
        ModelMainHand = parser.ReadOffset< ulong >( 128 );
        ModelOffHand = parser.ReadOffset< ulong >( 136 );
        Scale = parser.ReadOffset< float >( 144 );
        ModelHead = parser.ReadOffset< uint >( 148 );
        ModelBody = parser.ReadOffset< uint >( 152 );
        ModelHands = parser.ReadOffset< uint >( 156 );
        ModelLegs = parser.ReadOffset< uint >( 160 );
        ModelFeet = parser.ReadOffset< uint >( 164 );
        ModelEars = parser.ReadOffset< uint >( 168 );
        ModelNeck = parser.ReadOffset< uint >( 172 );
        ModelWrists = parser.ReadOffset< uint >( 176 );
        ModelLeftRing = parser.ReadOffset< uint >( 180 );
        ModelRightRing = parser.ReadOffset< uint >( 184 );
        EventHandler = parser.ReadOffset< ushort >( 188 );
        ModelChara = new LazyRow< ModelChara >( gameData, parser.ReadOffset< ushort >( 190 ), language );
        NpcEquip = new LazyRow< NpcEquip >( gameData, parser.ReadOffset< ushort >( 192 ), language );
        Behavior = new LazyRow< Behavior >( gameData, parser.ReadOffset< ushort >( 194 ), language );
        Balloon = new LazyRow< Balloon >( gameData, parser.ReadOffset< ushort >( 196 ), language );
        Race = new LazyRow< Race >( gameData, parser.ReadOffset< byte >( 198 ), language );
        Gender = parser.ReadOffset< byte >( 199 );
        BodyType = parser.ReadOffset< byte >( 200 );
        Height = parser.ReadOffset< byte >( 201 );
        Tribe = new LazyRow< Tribe >( gameData, parser.ReadOffset< byte >( 202 ), language );
        Face = parser.ReadOffset< byte >( 203 );
        HairStyle = parser.ReadOffset< byte >( 204 );
        HairHighlight = parser.ReadOffset< byte >( 205 );
        SkinColor = parser.ReadOffset< byte >( 206 );
        EyeHeterochromia = parser.ReadOffset< byte >( 207 );
        HairColor = parser.ReadOffset< byte >( 208 );
        HairHighlightColor = parser.ReadOffset< byte >( 209 );
        FacialFeature = parser.ReadOffset< byte >( 210 );
        FacialFeatureColor = parser.ReadOffset< byte >( 211 );
        Eyebrows = parser.ReadOffset< byte >( 212 );
        EyeColor = parser.ReadOffset< byte >( 213 );
        EyeShape = parser.ReadOffset< byte >( 214 );
        Nose = parser.ReadOffset< byte >( 215 );
        Jaw = parser.ReadOffset< byte >( 216 );
        Mouth = parser.ReadOffset< byte >( 217 );
        LipColor = parser.ReadOffset< byte >( 218 );
        BustOrTone1 = parser.ReadOffset< byte >( 219 );
        ExtraFeature1 = parser.ReadOffset< byte >( 220 );
        ExtraFeature2OrBust = parser.ReadOffset< byte >( 221 );
        FacePaint = parser.ReadOffset< byte >( 222 );
        FacePaintColor = parser.ReadOffset< byte >( 223 );
        Unknown0 = parser.ReadOffset< byte >( 224 );
        DyeMainHand = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 225 ), language );
        DyeOffHand = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 226 ), language );
        DyeHead = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 227 ), language );
        DyeBody = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 228 ), language );
        DyeHands = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 229 ), language );
        DyeLegs = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 230 ), language );
        DyeFeet = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 231 ), language );
        DyeEars = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 232 ), language );
        DyeNeck = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 233 ), language );
        DyeWrists = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 234 ), language );
        DyeLeftRing = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 235 ), language );
        DyeRightRing = new LazyRow< Stain >( gameData, parser.ReadOffset< byte >( 236 ), language );
        Invisibility = parser.ReadOffset< byte >( 237 );
        DefaultBalloon = parser.ReadOffset< byte >( 238 );
        Unknown1 = parser.ReadOffset< byte >( 239 );
        Important = parser.ReadOffset< bool >( 240 );
        Visor = parser.ReadOffset< bool >( 240, 2 );
        NotRewriteHeight = parser.ReadOffset< bool >( 240, 4 );
        

    }
}