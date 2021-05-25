[Serializable]
public class RewardBoxSaveData // TypeDefIndex: 10513
{
	// Fields
	public const int OrderRewardItemLength = 24;
	public const int OrderRewardRecipeLength = 24;
	public const int WantedRewardItemLength = 8;
	public const int FestivalRewardItemLength = 4;
	[SerializeField] // RVA: 0x181D00 Offset: 0x181E01 VA: 0x181D00
	public int Version; // 0x10
	[SerializeField] // RVA: 0x181D10 Offset: 0x181E11 VA: 0x181D10
	public RewardItemData[] OrderRewardItemData; // 0x18
	[SerializeField] // RVA: 0x181D20 Offset: 0x181E21 VA: 0x181D20
	public int[] OrderRewardRecipeData; // 0x20
	[SerializeField] // RVA: 0x181D30 Offset: 0x181E31 VA: 0x181D30
	public int OrderRewardGold; // 0x28
	[SerializeField] // RVA: 0x181D40 Offset: 0x181E41 VA: 0x181D40
	public RewardItemData[] WantedRewardItemData; // 0x30
	[SerializeField] // RVA: 0x181D50 Offset: 0x181E51 VA: 0x181D50
	public RewardItemData[] FestivalRewardItemData; // 0x38

	// Methods

	// RVA: 0x1EEE620 Offset: 0x1EEE721 VA: 0x1EEE620
	public void Initialize() { }

	// RVA: 0x1EEE8F0 Offset: 0x1EEE9F1 VA: 0x1EEE8F0
	public int GetOrderRewardItemCount() { }

	// RVA: 0x1EEE970 Offset: 0x1EEEA71 VA: 0x1EEE970
	public int GetOrderRewardRecipeCount() { }

	// RVA: 0x1EEE9F0 Offset: 0x1EEEAF1 VA: 0x1EEE9F0
	public int GetWantedRewardItemCount() { }

	// RVA: 0x1EEEA70 Offset: 0x1EEEB71 VA: 0x1EEEA70
	public int GetFestivalrRewardItemCount() { }

	// RVA: 0x1EEEAF0 Offset: 0x1EEEBF1 VA: 0x1EEEAF0
	public bool AddOrderRewardItem(int itemId, int amount, int level) { }

	// RVA: 0x1EEEB80 Offset: 0x1EEEC81 VA: 0x1EEEB80
	public bool AddOrderRewardRecipe(int id) { }

	// RVA: 0x1EEEBF0 Offset: 0x1EEECF1 VA: 0x1EEEBF0
	public bool AddWantedRewardItem(int itemId, int amount, int level) { }

	// RVA: 0x1EEEC70 Offset: 0x1EEED71 VA: 0x1EEEC70
	public bool AddFestivalRewardItem(int itemId, int amount, int level) { }

	// RVA: 0x1EEECF0 Offset: 0x1EEEDF1 VA: 0x1EEECF0
	public void ClearOrderRewardItem() { }

	// RVA: 0x1EEED60 Offset: 0x1EEEE61 VA: 0x1EEED60
	public void ClearOrderRewardRecipe() { }

	// RVA: 0x1EEEDC0 Offset: 0x1EEEEC1 VA: 0x1EEEDC0
	public void ClearWantedRewardItem() { }

	// RVA: 0x1EEEE20 Offset: 0x1EEEF21 VA: 0x1EEEE20
	public void ClearFestivalReward() { }

	// RVA: 0x1EEEE80 Offset: 0x1EEEF81 VA: 0x1EEEE80
	public void Writer(BinaryWriter writer) { }

	// RVA: 0x1EEF180 Offset: 0x1EEF281 VA: 0x1EEF180
	public void Reader(BinaryReader reader) { }

	// RVA: 0x1EEF5B0 Offset: 0x1EEF6B1 VA: 0x1EEF5B0
	public void Reader0010(BinaryReader reader) { }

	// RVA: 0x1EEF990 Offset: 0x1EEFA91 VA: 0x1EEF990
	public void .ctor() { }
}

