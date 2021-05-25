public static class CraftManager // TypeDefIndex: 7644
{
	// Fields
	public static CraftCategoryId CurrentCraftCategory; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x168780 Offset: 0x168881 VA: 0x168780
	private static DualWorkType <DualWorkType>k__BackingField; // 0x4
	private const int MaxLearn = 4;
	private static readonly Dictionary<ItemID, SkillID> FarmToolOutputItemIDtoSkillID; // 0x8
	private static ItemID[] ReleasedRecipe_ItemIDs; // 0x10
	private static FurnitureID[] ReleaseRecipe_Furnitures; // 0x18
	private static ItemID ReleaseFailRecipePan; // 0x20

	// Properties
	public static bool IsDualWork { get; }
	public static DualWorkType DualWorkType { get; set; }

	// Methods

	// RVA: 0x1FCC0F0 Offset: 0x1FCC1F1 VA: 0x1FCC0F0
	public static bool get_IsDualWork() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A22C0 Offset: 0x1A23C1 VA: 0x1A22C0
	// RVA: 0x1FCC1C0 Offset: 0x1FCC2C1 VA: 0x1FCC1C0
	public static DualWorkType get_DualWorkType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A22D0 Offset: 0x1A23D1 VA: 0x1A22D0
	// RVA: 0x1FCC230 Offset: 0x1FCC331 VA: 0x1FCC230
	public static void set_DualWorkType(DualWorkType value) { }

	// RVA: 0x1FCC2A0 Offset: 0x1FCC3A1 VA: 0x1FCC2A0
	public static RecipeId FindMatchRecipe(CraftCategoryId recipeCatalogId, IEnumerable<ItemID> materialItems) { }

	// RVA: 0x1FCCAE0 Offset: 0x1FCCBE1 VA: 0x1FCCAE0
	private static bool IsWeaponCategory(ItemCategory itemCategory) { }

	// RVA: 0x1FCCAF0 Offset: 0x1FCCBF1 VA: 0x1FCCAF0
	private static bool IsEquipCategory(ItemCategory itemCategory) { }

	// RVA: 0x1FCCB00 Offset: 0x1FCCC01 VA: 0x1FCCB00
	private static bool IsSmithOrDeco(ItemCategory itemCategory) { }

	// RVA: 0x1FCCBA0 Offset: 0x1FCCCA1 VA: 0x1FCCBA0
	public static int CalucCraftCostRp(CraftCategoryId recipeCatalogId, RecipeId recipeId, ItemData[] materialItems, bool isBaseCost) { }

	// RVA: 0x1FCD350 Offset: 0x1FCD451 VA: 0x1FCD350
	public static ValueTuple<bool, ItemData[]> DoSynthesis(CraftCategoryId categoryId, RecipeId recipeId, ItemData[][] materialItemDatas, int craftNum, DualWorkType workType) { }

	// RVA: 0x1FCD920 Offset: 0x1FCDA21 VA: 0x1FCD920
	public static ValueTuple<bool, ItemData> DoSynthesisInternal(CraftCategoryId categoryId, RecipeId recipeId, ItemData[] materialItems) { }

	// RVA: 0x1FCE750 Offset: 0x1FCE851 VA: 0x1FCE750
	private static void SetSynthesisEquipItemData(ref EquipItemData target, CraftCategoryId categoryId, ItemData[] materialItems, bool[] matchResult) { }

	// RVA: 0x1FCEFF0 Offset: 0x1FCF0F1 VA: 0x1FCEFF0
	private static void SetSynthesisFoodItemData(ref FoodItemData target, CraftCategoryId categoryId, ItemData[] materialItems, bool[] matchResult) { }

	// RVA: 0x1FCF1A0 Offset: 0x1FCF2A1 VA: 0x1FCF1A0
	private static ValueTuple<int, int> CalcTotalLevels(int inputSozai, int inputLevel, CraftCategoryId categoryId) { }

	// RVA: 0x1FCC790 Offset: 0x1FCC891 VA: 0x1FCC790
	public static ValueTuple<bool, bool[]> IsRecipeSatisfied(RecipeId recipeId, IEnumerable<ItemID> materialItems) { }

	// RVA: 0x1FCF340 Offset: 0x1FCF441 VA: 0x1FCF340
	public static ValueTuple<ItemData, StorageType>[] AutoFindItemDatasByRecipe(CraftCategoryId recipeCatalogId, RecipeId recipeId) { }

	// RVA: 0x1FCF8C0 Offset: 0x1FCF9C1 VA: 0x1FCF8C0
	public static int[] HasItemCountAll(CraftCategoryId category, ItemID[] itemIDs) { }

	// RVA: 0x1FCF570 Offset: 0x1FCF671 VA: 0x1FCF570
	private static ValueTuple<ItemData, StorageType> AutoFindItemData_internal(CraftCategoryId recipeCatalogId, ItemID recipeSource) { }

	// RVA: 0x1FCFC60 Offset: 0x1FCFD61 VA: 0x1FCFC60
	private static ItemDataLinker FindGenreItemDataLinker(ItemID[] genreItemArray, ItemDataLinker hitDataLinker, StorageType[] targetStorage) { }

	// RVA: 0x1FCFDF0 Offset: 0x1FCFEF1 VA: 0x1FCFDF0
	public static ItemData[] SearchAndReduceItem(CraftCategoryId craftCategoryId, ItemID[] materialItemID) { }

	// RVA: 0x1FCFAA0 Offset: 0x1FCFBA1 VA: 0x1FCFAA0
	public static StorageType[] CategoryToStorage(CraftCategoryId recipeCatalogId) { }

	// RVA: 0x1FCE070 Offset: 0x1FCE171 VA: 0x1FCE070
	public static ItemID RandomFailureItemData(CraftCategoryId categoryId) { }

	// RVA: 0x1FCE260 Offset: 0x1FCE361 VA: 0x1FCE260
	private static void GainSkillExp_Synthesis(bool success, RecipeId recipeId, CraftCategoryId categoryId, ItemData[] materialItems) { }

	// RVA: 0x1FD0130 Offset: 0x1FD0231 VA: 0x1FD0130
	private static void GainSkillExp_Strengthening(SkillID skillID, ItemData baseItemData, ItemData addItemData) { }

	// RVA: 0x1FD02C0 Offset: 0x1FD03C1 VA: 0x1FD02C0
	public static Parameter GetBaseLevelParam(int baseLevel, EquipItemFlag equipItemFlag) { }

	// RVA: 0x1FD03F0 Offset: 0x1FD04F1 VA: 0x1FD03F0
	public static Parameter GetSozaiLevelParam(int sozaiLevel, EquipItemFlag equipItemFlag) { }

	// RVA: 0x1FD0650 Offset: 0x1FD0751 VA: 0x1FD0650
	public static RecipeDataTableArray.RecipeDataTable GetRecipeDataTable(ItemID itemId) { }

	// RVA: 0x1FD07B0 Offset: 0x1FD08B1 VA: 0x1FD07B0
	public static ValueTuple<ItemData, int> GetResultStrengthening(EquipItemData baseItem, ItemData addItem, bool isWeapon) { }

	// RVA: 0x1FD0BB0 Offset: 0x1FD0CB1 VA: 0x1FD0BB0
	public static ItemData DoStrengthening(EquipItemData baseItem, ItemData addItem, bool isWeapon) { }

	// RVA: 0x1FD0D50 Offset: 0x1FD0E51 VA: 0x1FD0D50
	private static void FindCanLearningRecipe_internal(int cap, ref HashSet<RecipeId> set, CraftCategoryId craftCategoryId, SkillID skillID) { }

	// RVA: 0x1FD10D0 Offset: 0x1FD11D1 VA: 0x1FD10D0
	public static bool CheckAndLearnRecipePan(ItemData itemData) { }

	// RVA: 0x1FD19A0 Offset: 0x1FD1AA1 VA: 0x1FD19A0
	private static void FindCanLearningRecipe_Drug(ref HashSet<RecipeId> ret, ItemID recipePanID) { }

	// RVA: 0x1FD1A30 Offset: 0x1FD1B31 VA: 0x1FD1A30
	private static void FindCanLearningRecipe_Cook(ref HashSet<RecipeId> ret, ItemID recipePanID) { }

	// RVA: 0x1FD1EB0 Offset: 0x1FD1FB1 VA: 0x1FD1EB0
	private static void FindCanLearningRecipe_Buki(ref HashSet<RecipeId> ret, ItemID recipePanID) { }

	// RVA: 0x1FD21D0 Offset: 0x1FD22D1 VA: 0x1FD21D0
	private static void FindCanLearningRecipe_Soshoku(ref HashSet<RecipeId> ret, ItemID recipePanID) { }

	// RVA: 0x1FD22B0 Offset: 0x1FD23B1 VA: 0x1FD22B0
	private static void FindCanLearningRecipe_Nougu(ref HashSet<RecipeId> ret, ItemID recipePanID) { }

	// RVA: 0x1FD1630 Offset: 0x1FD1731 VA: 0x1FD1630
	public static RecipeId CalcRecipeLearning(ItemID panId) { }

	// RVA: 0x1FD0F50 Offset: 0x1FD1051 VA: 0x1FD0F50
	private static bool CalcRecipeLevelCheck(int cap, int skillLv, RecipeId recipeID) { }

	// RVA: 0x1FD25E0 Offset: 0x1FD26E1 VA: 0x1FD25E0
	private static int Item_GetRecipeCount(CraftCategoryId craftCategoryId) { }

	// RVA: 0x1FD2710 Offset: 0x1FD2811 VA: 0x1FD2710
	public static string GetForTag_Recipe_ItemName(int index) { }

	// RVA: 0x1FD27C0 Offset: 0x1FD28C1 VA: 0x1FD27C0
	public static string GetForTag_Release_FurnitureName(int index) { }

	// RVA: 0x1FD2930 Offset: 0x1FD2A31 VA: 0x1FD2930
	public static string GetForTag_Release_Category(int index) { }

	// RVA: 0x1FD2AA0 Offset: 0x1FD2BA1 VA: 0x1FD2AA0
	public static string GetForTag_FalseHint() { }

	// RVA: 0x1FD2C30 Offset: 0x1FD2D31 VA: 0x1FD2C30
	private static void .cctor() { }
}

