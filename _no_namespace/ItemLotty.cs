public static class ItemLotty // TypeDefIndex: 7670
{
	// Fields
	private static UniqueRandom uniqueRandom; // 0x0

	// Properties
	public static UniqueRandom UniqueRandom { get; }

	// Methods

	// RVA: 0x1F47BD0 Offset: 0x1F47CD1 VA: 0x1F47BD0
	public static ItemID ItemLottery(ItemLotteryID id, bool isHiDropCapOver = False) { }

	// RVA: 0x1F48A50 Offset: 0x1F48B51 VA: 0x1F48A50
	public static ItemID ItemLotteryNoCap(ItemLotteryID id) { }

	// RVA: 0x1F48C00 Offset: 0x1F48D01 VA: 0x1F48C00
	public static UniqueRandom get_UniqueRandom() { }

	// RVA: 0x1F48CA0 Offset: 0x1F48DA1 VA: 0x1F48CA0
	public static ItemID ItemLotteryWeight(ItemLotteryWeightID id, int seed) { }

	// RVA: 0x1F48DC0 Offset: 0x1F48EC1 VA: 0x1F48DC0
	public static ItemID LotteryWeight(List<ItemWeightData> lotteryList, int seed) { }

	// RVA: 0x1F490C0 Offset: 0x1F491C1 VA: 0x1F490C0
	public static ItemID ItemLotteryWeight(ItemLotty.ItemLotteryWeightParam[] lotteryParams) { }

	// RVA: 0x1F49250 Offset: 0x1F49351 VA: 0x1F49250
	public static bool CalcItemCapCheck(ItemID itemID, bool isHiDropCapOver) { }

	// RVA: 0x1F49780 Offset: 0x1F49881 VA: 0x1F49780
	public static ItemID CalcItemDropByCategory(ItemCategory itemCategory, bool isHiDropCapOver) { }

	// RVA: 0x1F499B0 Offset: 0x1F49AB1 VA: 0x1F499B0
	public static ItemID CalcItemDropByCraftGenre(ItemID itemGenre, bool isHiDropCapOver) { }

	// RVA: 0x1F49510 Offset: 0x1F49611 VA: 0x1F49510
	public static bool IsSeedSellCheck(ItemID itemID) { }

	// RVA: 0x1F495C0 Offset: 0x1F496C1 VA: 0x1F495C0
	private static bool IsCropSellCheck(ItemID itemID) { }
}

