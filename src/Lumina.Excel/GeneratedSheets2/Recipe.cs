// ReSharper disable All

using UIntSpan = System.Span<uint>;
using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;

namespace Lumina.Excel.GeneratedSheets2;

[Sheet( "Recipe", columnHash: 0x6cbece4b )]
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
    public ushort DisplayPriority { get; private set; }
    public ushort DifficultyFactor { get; private set; }
    public ushort QualityFactor { get; private set; }
    public ushort DurabilityFactor { get; private set; }
    public ushort RequiredCraftsmanship { get; private set; }
    public ushort RequiredControl { get; private set; }
    public ushort QuickSynthCraftsmanship { get; private set; }
    public ushort QuickSynthControl { get; private set; }
    public LazyRow< SecretRecipeBook > SecretRecipeBook { get; private set; }
    public ILazyRow CollectableMetadata { get; private set; }
    public ushort PatchNumber { get; private set; }
    public byte AmountResult { get; private set; }
    public byte[] AmountIngredient { get; private set; }
    public byte MaterialQualityFactor { get; private set; }
    public byte CollectableMetadataKey { get; private set; }
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
        Ingredient = new LazyRow< Item >[8];
        for (int i = 0; i < 8; i++)
        	Ingredient[i] = new LazyRow< Item >( gameData, parser.ReadOffset< int >( (ushort) ( 20 + i * 4 ) ), language );
        StatusRequired = new LazyRow< Status >( gameData, parser.ReadOffset< int >( 52 ), language );
        ItemRequired = new LazyRow< Item >( gameData, parser.ReadOffset< int >( 56 ), language );
        RecipeLevelTable = new LazyRow< RecipeLevelTable >( gameData, parser.ReadOffset< ushort >( 60 ), language );
        RecipeNotebookList = new LazyRow< RecipeNotebookList >( gameData, parser.ReadOffset< ushort >( 62 ), language );
        DisplayPriority = parser.ReadOffset< ushort >( 64 );
        DifficultyFactor = parser.ReadOffset< ushort >( 66 );
        QualityFactor = parser.ReadOffset< ushort >( 68 );
        DurabilityFactor = parser.ReadOffset< ushort >( 70 );
        RequiredCraftsmanship = parser.ReadOffset< ushort >( 72 );
        RequiredControl = parser.ReadOffset< ushort >( 74 );
        QuickSynthCraftsmanship = parser.ReadOffset< ushort >( 76 );
        QuickSynthControl = parser.ReadOffset< ushort >( 78 );
        SecretRecipeBook = new LazyRow< SecretRecipeBook >( gameData, parser.ReadOffset< ushort >( 80 ), language );
        var CollectableMetadataRowId = parser.ReadOffset< ushort >( 82 );
        PatchNumber = parser.ReadOffset< ushort >( 84 );
        AmountResult = parser.ReadOffset< byte >( 86 );
        AmountIngredient = new byte[8];
        for (int i = 0; i < 8; i++)
        	AmountIngredient[i] = parser.ReadOffset< byte >( 87 + i * 1 );
        MaterialQualityFactor = parser.ReadOffset< byte >( 95 );
        CollectableMetadataKey = parser.ReadOffset< byte >( 96 );
        IsSecondary = parser.ReadOffset< bool >( 97 );
        CanQuickSynth = parser.ReadOffset< bool >( 97, 2 );
        CanHq = parser.ReadOffset< bool >( 97, 4 );
        ExpRewarded = parser.ReadOffset< bool >( 97, 8 );
        IsSpecializationRequired = parser.ReadOffset< bool >( 97, 16 );
        IsExpert = parser.ReadOffset< bool >( 97, 32 );
        
        CollectableMetadata = CollectableMetadataKey switch
        {
        	1 => new LazyRow< CollectablesShopRefine >( gameData, CollectableMetadataRowId, language ),
        	2 => new LazyRow< HWDCrafterSupply >( gameData, CollectableMetadataRowId, language ),
        	3 => new LazyRow< SatisfactionSupply >( gameData, CollectableMetadataRowId, language ),
        	4 => new LazyRow< SharlayanCraftWorksSupply >( gameData, CollectableMetadataRowId, language ),
        	_ => new EmptyLazyRow( (uint) CollectableMetadataRowId ),
        };
    }
}