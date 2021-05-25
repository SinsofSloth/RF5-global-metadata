public static class ItemLevelWeight // TypeDefIndex: 7669
{
	// Fields
	private static ItemLevelWeightDataTableArray _ItemLevelWeightDataTableArray; // 0x0

	// Methods

	// RVA: 0x1F47120 Offset: 0x1F47221 VA: 0x1F47120
	public static ItemLevelWeightID GetCurrectItemLevelWeightID() { }

	// RVA: 0x1F47390 Offset: 0x1F47491 VA: 0x1F47390
	public static int GetCurrectEquipItemLevelCap() { }

	// RVA: 0x1F47520 Offset: 0x1F47621 VA: 0x1F47520
	public static ItemLevelWeightDataTable GetLevelWeightDataTable(ItemLevelWeightID itemLevelWeightID) { }

	// RVA: 0x1F47270 Offset: 0x1F47371 VA: 0x1F47270
	public static SerializedItemLevelWeightDataTable[] GetLevelWeightDataTables() { }

	// RVA: 0x1F47660 Offset: 0x1F47761 VA: 0x1F47660
	public static int CheckCropItemLevel(ItemID id) { }

	// RVA: 0x1F47830 Offset: 0x1F47931 VA: 0x1F47830
	public static ItemData LevelLotteryWithCreateItemData(ItemID itemID, int amount = 1) { }

	// RVA: 0x1F47A90 Offset: 0x1F47B91 VA: 0x1F47A90
	public static void StrengtheningRandom(EquipItemData equip, int toLevel) { }

	// RVA: 0x1F47930 Offset: 0x1F47A31 VA: 0x1F47930
	public static int CalcDropItemLevel() { }

	// RVA: 0x1F481E0 Offset: 0x1F482E1 VA: 0x1F481E0
	public static int LotteryArrangeItemNum(FieldTreasureBoxData boxData) { }

	// RVA: 0x1F48370 Offset: 0x1F48471 VA: 0x1F48370
	public static void AddRandomArrangeItem(EquipItemData equip, int num) { }
}

