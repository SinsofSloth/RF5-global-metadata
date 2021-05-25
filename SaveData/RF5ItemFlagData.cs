public class RF5ItemFlagData : SaveDataValueBase // TypeDefIndex: 9886
{
	// Fields
	public SaveFlagStorage SaveFlag; // 0x10
	public SaveFlagStorage ClothFlag; // 0x18

	// Methods

	// RVA: 0x1D79140 Offset: 0x1D79241 VA: 0x1D79140
	public bool CheckItemGet(ItemID itemID) { }

	// RVA: 0x1D791B0 Offset: 0x1D792B1 VA: 0x1D791B0
	public void SetItemGet(bool value, ItemID itemID) { }

	// RVA: 0x1D79220 Offset: 0x1D79321 VA: 0x1D79220
	public bool CheckRecipeRelease(RecipeRelease recipeId) { }

	// RVA: 0x1D79240 Offset: 0x1D79341 VA: 0x1D79240
	public void SetRecipeRelease(bool value, RecipeRelease recipeId) { }

	// RVA: 0x1D792A0 Offset: 0x1D793A1 VA: 0x1D792A0
	public bool IsFirstRecipeGet() { }

	// RVA: 0x1D792C0 Offset: 0x1D793C1 VA: 0x1D792C0
	public bool CheckClothShop(ClothShopID id) { }

	// RVA: 0x1D792E0 Offset: 0x1D793E1 VA: 0x1D792E0
	public void SetClothShop(bool value, ClothShopID id) { }

	// RVA: 0x1D79190 Offset: 0x1D79291 VA: 0x1D79190
	private bool GetSaveFlag(RF5ItemFlagData.FLAG id) { }

	// RVA: 0x1D79200 Offset: 0x1D79301 VA: 0x1D79200
	private void SetSaveFlag(RF5ItemFlagData.FLAG id, bool value) { }

	// RVA: 0x1D79310 Offset: 0x1D79411 VA: 0x1D79310
	public void .ctor() { }

	// RVA: 0x1D793D0 Offset: 0x1D794D1 VA: 0x1D793D0 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D793F0 Offset: 0x1D794F1 VA: 0x1D793F0 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D79400 Offset: 0x1D79501 VA: 0x1D79400 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D79410 Offset: 0x1D79511 VA: 0x1D79410 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D79460 Offset: 0x1D79561 VA: 0x1D79460
	public void Reader0000(BinaryReader reader) { }
}

