// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Recipe", columnHash: 0xb0dc277f )]
public partial class Recipe : ExcelRow
{
    
    public uint RequiredQuality { get; private set; }
    public LazyRow< Quest > Quest { get; private set; }
    public int Number { get; private set; }
    public LazyRow< CraftType > CraftType { get; private set; }
    public LazyRow< Item > ItemResult { get; private set; }
    public LazyRow< Item >[] Ingredient { get; private set; }
    public LazyRow< Status > StatusRequired { get; private set; }
    public LazyRow< Item > ItemRequired { get; private set; }
    public LazyRow< RecipeLevelTable > RecipeLevelTable { get; private set; }
    public LazyRow< RecipeNotebookList > RecipeNotebookList { get; private set; }
    public ushort DifficultyFactor { get; private set; }
    public ushort QualityFactor { get; private set; }
    public ushort DurabilityFactor { get; private set; }
    public ushort RequiredCraftsmanship { get; private set; }
    public ushort RequiredControl { get; private set; }
    public ushort QuickSynthCraftsmanship { get; private set; }
    public ushort QuickSynthControl { get; private set; }
    public LazyRow< SecretRecipeBook > SecretRecipeBook { get; private set; }
    public ushort Unknown0 { get; private set; }
    public ushort PatchNumber { get; private set; }
    public byte AmountResult { get; private set; }
    public byte[] AmountIngredient { get; private set; }
    public byte MaterialQualityFactor { get; private set; }
    public byte Unknown1 { get; private set; }
    public bool IsSecondary { get; private set; }
    public bool CanQuickSynth { get; private set; }
    public bool CanHq { get; private set; }
    public bool ExpRewarded { get; private set; }
    public bool IsSpecializationRequired { get; private set; }
    public bool IsExpert { get; private set; }
    
    public override void PopulateData( RowParser parser, GameData gameData, Language language )
    {
        base.PopulateData( parser, gameData, language );

        RequiredQuality = parser.ReadOffset< uint >( 0 );
        Quest = new LazyRow< Quest >( gameData, parser.ReadOffset< uint >( 4 ), language );
        Number = parser.ReadOffset< int >( 8 );
        CraftType = new LazyRow< CraftType >( gameData, parser.ReadOffset< int >( 12 ), language );
        ItemResult = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 16 ), language );
        Ingredient = new LazyRow< Item >[10];
        for (int i = 0; i < 10; i++)
        	Ingredient[i] = new LazyRow< Item >( gameData, parser.ReadOffset< int >( (ushort) ( 20 + i * 4 ) ), language );
        StatusRequired = new LazyRow< Status >( gameData, parser.ReadOffset< int >( 60 ), language );
        ItemRequired = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 64 ), language );
        RecipeLevelTable = new LazyRow< RecipeLevelTable >( gameData, parser.ReadOffset< ushort >( 68 ), language );
        RecipeNotebookList = new LazyRow< RecipeNotebookList >( gameData, parser.ReadOffset< ushort >( 70 ), language );
        DifficultyFactor = parser.ReadOffset< ushort >( 72 );
        QualityFactor = parser.ReadOffset< ushort >( 74 );
        DurabilityFactor = parser.ReadOffset< ushort >( 76 );
        RequiredCraftsmanship = parser.ReadOffset< ushort >( 78 );
        RequiredControl = parser.ReadOffset< ushort >( 80 );
        QuickSynthCraftsmanship = parser.ReadOffset< ushort >( 82 );
        QuickSynthControl = parser.ReadOffset< ushort >( 84 );
        SecretRecipeBook = new LazyRow< SecretRecipeBook >( gameData, parser.ReadOffset< ushort >( 86 ), language );
        Unknown0 = parser.ReadOffset< ushort >( 88 );
        PatchNumber = parser.ReadOffset< ushort >( 90 );
        AmountResult = parser.ReadOffset< byte >( 92 );
        AmountIngredient = new byte[10];
        for (int i = 0; i < 10; i++)
        	AmountIngredient[i] = parser.ReadOffset< byte >( 93 + i * 1 );
        MaterialQualityFactor = parser.ReadOffset< byte >( 103 );
        Unknown1 = parser.ReadOffset< byte >( 104 );
        IsSecondary = parser.ReadOffset< bool >( 105 );
        CanQuickSynth = parser.ReadOffset< bool >( 105, 2 );
        CanHq = parser.ReadOffset< bool >( 105, 4 );
        ExpRewarded = parser.ReadOffset< bool >( 105, 8 );
        IsSpecializationRequired = parser.ReadOffset< bool >( 105, 16 );
        IsExpert = parser.ReadOffset< bool >( 105, 32 );
        

    }
}