[Serializable]
public class OrderData // TypeDefIndex: 7207
{
	// Fields
	public int OrderId; // 0x10
	public OrderCategory OrderCategory; // 0x14
	public int EventId; // 0x18
	public int OrderNpcId; // 0x1C
	public int OrderRequestNpcId; // 0x20
	public int RandomId; // 0x24
	public int OrderNeedRank; // 0x28
	public int[] OrderNeedCompOrders; // 0x30
	public OrderType OrderType; // 0x38
	public OrderCompleteType OrderCompleteType; // 0x3C
	public int OrderWithNpcId; // 0x40
	public int OrderEquipWeapon; // 0x44
	public int OrderTargetSpecialType; // 0x48
	public int OrderTargetType; // 0x4C
	public int OrderTargetId; // 0x50
	public int OrderTargetLv; // 0x54
	public int OrderTargetCompleteAmount; // 0x58
	public int OrderDeliverTarget; // 0x5C
	public int[] OrderOccuredType; // 0x60
	public int[] OrderOccuredTypeValue; // 0x68
	public int RepeatType; // 0x70
	public int[] RewardType; // 0x78
	public int[] RewardId; // 0x80
	public int[] RewardAmount; // 0x88
	public int[] RewardItemLevel; // 0x90
	public int[] RewardPosition; // 0x98
	public int[] HandoutType; // 0xA0
	public int[] HandoutId; // 0xA8
	public int[] HandoutAmount; // 0xB0
	public string OrderEventStartPoint; // 0xB8
	public string OrderAcceptScriptID; // 0xC0
	public string OrderClearScriptID; // 0xC8
	public GameFlagData OrderAcceptFlag; // 0xD0
	public GameFlagData OrderClearFlag; // 0xD4
	public bool RewardUnnecessary; // 0xD8
	public int OrderTargetCurrentAmount; // 0xDC
	public int CompleteDate; // 0xE0
	public bool RecievedOrder; // 0xE4
	public bool Completed; // 0xE5
	public bool GotReward; // 0xE6
	public bool FirstCompleted; // 0xE7
	public string CompletedEventStep; // 0xE8
	public OrderHUDBlock OrderHudBlock; // 0xF0

	// Properties
	public string OrderTitle { get; }
	public string OrderExplain { get; }
	public string OrderHudText { get; }
	public string OrderRewardText { get; }

	// Methods

	// RVA: 0x1F1D660 Offset: 0x1F1D761 VA: 0x1F1D660
	public string get_OrderTitle() { }

	// RVA: 0x1F1E310 Offset: 0x1F1E411 VA: 0x1F1E310
	public string get_OrderExplain() { }

	// RVA: 0x1F1E740 Offset: 0x1F1E841 VA: 0x1F1E740
	public string get_OrderHudText() { }

	// RVA: 0x1F1E4F0 Offset: 0x1F1E5F1 VA: 0x1F1E4F0
	public string get_OrderRewardText() { }

	// RVA: 0x1F1E920 Offset: 0x1F1EA21 VA: 0x1F1E920
	public void .ctor() { }

	// RVA: 0x1F1EA90 Offset: 0x1F1EB91 VA: 0x1F1EA90
	public void .ctor(OrderMasterData masterData) { }

	// RVA: 0x1F1EE20 Offset: 0x1F1EF21 VA: 0x1F1EE20
	public bool IsExistOrderData(OrderType orderType, int orderDeliverTarget, int orderTargetType, int orderTargetId, int orderTargetLevel, Place orderTargetPlace, int value1 = 0, int value2 = 0, int value3 = 0) { }

	// RVA: 0x1F1F130 Offset: 0x1F1F231 VA: 0x1F1F130
	public bool CheckItemType(int targetItemID, int targetType) { }

	// RVA: 0x1F1F570 Offset: 0x1F1F671 VA: 0x1F1F570
	private bool CheckGoldenItem(ItemID itemID) { }

	// RVA: 0x1F1F5A0 Offset: 0x1F1F6A1 VA: 0x1F1F5A0
	private bool CheckBigFlowerItem(ItemID itemID) { }

	// RVA: 0x1F1F5D0 Offset: 0x1F1F6D1 VA: 0x1F1F5D0
	private bool CheckFlowerItem(ItemID itemID) { }

	// RVA: 0x1F1F600 Offset: 0x1F1F701 VA: 0x1F1F600
	private bool CheckVegetableItem(ItemID itemID) { }

	// RVA: 0x1F1F630 Offset: 0x1F1F731 VA: 0x1F1F630
	private bool CheckHavestNonGoldenVegetable(out int count) { }

	// RVA: 0x1F1F790 Offset: 0x1F1F891 VA: 0x1F1F790
	private bool CheckHarvestAll(out int count) { }

	// RVA: 0x1F1F8F0 Offset: 0x1F1F9F1 VA: 0x1F1F8F0
	private bool CheckHarvestOtherThanGongohana(out int count) { }

	// RVA: 0x1F1F520 Offset: 0x1F1F621 VA: 0x1F1F520
	private bool CheckCuisineItem(ItemID itemID) { }

	// RVA: 0x1F1F4D0 Offset: 0x1F1F5D1 VA: 0x1F1F4D0
	private bool CheckWeaponItem(ItemID itemID) { }

	// RVA: 0x1F1F480 Offset: 0x1F1F581 VA: 0x1F1F480
	private bool CheckFarmToolsItem(ItemID itemID) { }

	// RVA: 0x1F1F420 Offset: 0x1F1F521 VA: 0x1F1F420
	private bool CheckArmorItem(ItemID itemID) { }

	// RVA: 0x1F1F3F0 Offset: 0x1F1F4F1 VA: 0x1F1F3F0
	private bool CheckMedicineItem(ItemID itemID) { }

	// RVA: 0x1F1FA60 Offset: 0x1F1FB61 VA: 0x1F1FA60
	private bool CheckHarvestItemID(ItemID id) { }

	// RVA: 0x1F1FAF0 Offset: 0x1F1FBF1 VA: 0x1F1FAF0
	public bool CheckItemSpecialTypeComplete(out int c) { }

	// RVA: 0x1F1F3D0 Offset: 0x1F1F4D1 VA: 0x1F1F3D0
	public bool CheckDeliveryDestination(int deliverTarget, int orderDeliverTarget, Place orderTargetPlace) { }

	// RVA: 0x1F1FB30 Offset: 0x1F1FC31 VA: 0x1F1FB30
	public void AddOrderTargetCurrentAmount(int _targetAmount = 0) { }

	// RVA: 0x1F20050 Offset: 0x1F20151 VA: 0x1F20050
	public bool IsNpcOrder() { }

	// RVA: 0x1F20060 Offset: 0x1F20161 VA: 0x1F20060
	public bool CheckBoxReward() { }

	// RVA: 0x1F20160 Offset: 0x1F20261 VA: 0x1F20160
	public void GetReward() { }

	// RVA: 0x1F207B0 Offset: 0x1F208B1 VA: 0x1F207B0
	public bool IsGotReward() { }

	// RVA: 0x1F207C0 Offset: 0x1F208C1 VA: 0x1F207C0
	public bool IsComplete() { }

	// RVA: 0x1F207F0 Offset: 0x1F208F1 VA: 0x1F207F0
	public bool IsCompleteOnce() { }

	// RVA: 0x1F20800 Offset: 0x1F20901 VA: 0x1F20800
	public bool IsRandomOrder() { }

	// RVA: 0x1F20810 Offset: 0x1F20911 VA: 0x1F20810
	public void SetCompleteDate() { }

	// RVA: 0x1F20940 Offset: 0x1F20A41 VA: 0x1F20940
	public void RunOrderAcceptScript() { }

	// RVA: 0x1F20730 Offset: 0x1F20831 VA: 0x1F20730
	private void RunOrderClearScript() { }
}

