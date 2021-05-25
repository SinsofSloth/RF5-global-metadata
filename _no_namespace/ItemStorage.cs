public class ItemStorage // TypeDefIndex: 7676
{
	// Fields
	private ItemStorageData ItemStorageData; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x168890 Offset: 0x168991 VA: 0x168890
	private StorageType <StorageType>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1688A0 Offset: 0x1689A1 VA: 0x1688A0
	private int <ReleasedLv>k__BackingField; // 0x1C
	private readonly MakingID[][] ReleaseIdTable; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x1688B0 Offset: 0x1689B1 VA: 0x1688B0
	private ItemDataLinker[] <ItemDataLinkers>k__BackingField; // 0x28
	private uint ItemGuardFilter; // 0x30
	private readonly uint[] SortHead; // 0x38
	private int nowCategorySortType; // 0x40
	private int nowSortSubType; // 0x44
	private bool SubSortTypeReverse; // 0x48
	private bool[,] SortPriorityProb; // 0x50
	private ulong[] SortPriorityIndex; // 0x58
	private ulong[] SortPriorityReverseVal; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x1688C0 Offset: 0x1689C1 VA: 0x1688C0
	private List<ItemData> <ItemList>k__BackingField; // 0x68

	// Properties
	public ItemData[] ItemDatas { get; }
	public StorageType StorageType { get; set; }
	private int ReleasedLv { get; set; }
	public int NowStorageSize { get; }
	public ItemDataLinker[] ItemDataLinkers { get; set; }
	private List<ItemData> ItemList { get; set; }

	// Methods

	// RVA: 0x208C110 Offset: 0x208C211 VA: 0x208C110
	public ItemData[] get_ItemDatas() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2450 Offset: 0x1A2551 VA: 0x1A2450
	// RVA: 0x208C130 Offset: 0x208C231 VA: 0x208C130
	public StorageType get_StorageType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2460 Offset: 0x1A2561 VA: 0x1A2460
	// RVA: 0x208C140 Offset: 0x208C241 VA: 0x208C140
	private void set_StorageType(StorageType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2470 Offset: 0x1A2571 VA: 0x1A2470
	// RVA: 0x208C150 Offset: 0x208C251 VA: 0x208C150
	private int get_ReleasedLv() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2480 Offset: 0x1A2581 VA: 0x1A2480
	// RVA: 0x208C160 Offset: 0x208C261 VA: 0x208C160
	private void set_ReleasedLv(int value) { }

	// RVA: 0x208C170 Offset: 0x208C271 VA: 0x208C170
	public int get_NowStorageSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2490 Offset: 0x1A2591 VA: 0x1A2490
	// RVA: 0x208C220 Offset: 0x208C321 VA: 0x208C220
	public ItemDataLinker[] get_ItemDataLinkers() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A24A0 Offset: 0x1A25A1 VA: 0x1A24A0
	// RVA: 0x208C230 Offset: 0x208C331 VA: 0x208C230
	private void set_ItemDataLinkers(ItemDataLinker[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A24B0 Offset: 0x1A25B1 VA: 0x1A24B0
	// RVA: 0x208C240 Offset: 0x208C341 VA: 0x208C240
	private List<ItemData> get_ItemList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A24C0 Offset: 0x1A25C1 VA: 0x1A24C0
	// RVA: 0x208C250 Offset: 0x208C351 VA: 0x208C250
	private void set_ItemList(List<ItemData> value) { }

	// RVA: 0x208C260 Offset: 0x208C361 VA: 0x208C260
	public void .ctor(StorageType storageType) { }

	// RVA: 0x208C800 Offset: 0x208C901 VA: 0x208C800
	public void Init(ItemStorageData storageData) { }

	// RVA: 0x208CA70 Offset: 0x208CB71 VA: 0x208CA70
	public void Reset() { }

	// RVA: 0x208C930 Offset: 0x208CA31 VA: 0x208C930
	private void InitDataLinker() { }

	// RVA: 0x208C830 Offset: 0x208C931 VA: 0x208C830
	public void SetReleasedLv() { }

	// RVA: 0x208CAA0 Offset: 0x208CBA1 VA: 0x208CAA0
	public List<ItemDataLinker> GetDataLinkerList(ItemCategory[] itemCategories) { }

	// RVA: 0x208CD00 Offset: 0x208CE01 VA: 0x208CD00
	public List<ItemDataLinker> GetDataLinkerList(ItemType[] itemTypes) { }

	// RVA: 0x208CD80 Offset: 0x208CE81 VA: 0x208CD80
	public List<ItemDataLinker> GetDataLinkerList(uint FilterType) { }

	// RVA: 0x208CFA0 Offset: 0x208D0A1 VA: 0x208CFA0
	public void CompressItem() { }

	// RVA: 0x208D5C0 Offset: 0x208D6C1 VA: 0x208D5C0
	public bool CompressForOneSlot() { }

	// RVA: 0x208DCC0 Offset: 0x208DDC1 VA: 0x208DCC0
	public ItemData PushAllInAnyStorage(ItemData itemData) { }

	// RVA: 0x208E290 Offset: 0x208E391 VA: 0x208E290
	private ulong GetSortVal(ItemData item) { }

	// RVA: 0x208E670 Offset: 0x208E771 VA: 0x208E670
	private int GetSortHeadId(ItemType itemType) { }

	// RVA: 0x208E700 Offset: 0x208E801 VA: 0x208E700
	private void DoSortItem() { }

	// RVA: 0x208E9B0 Offset: 0x208EAB1 VA: 0x208E9B0
	private bool CheckHasSortItem(int sortId) { }

	// RVA: 0x208EA90 Offset: 0x208EB91 VA: 0x208EA90
	public void SetSortBlock(UISortBlock UISortBlock) { }

	// RVA: 0x208EAC0 Offset: 0x208EBC1 VA: 0x208EAC0
	private bool CheckToNextSortCategory() { }

	// RVA: 0x208EB90 Offset: 0x208EC91 VA: 0x208EB90
	public void SortItem() { }

	// RVA: 0x208EC30 Offset: 0x208ED31 VA: 0x208EC30
	public void SetSubSortType(SubSortType type) { }

	// RVA: 0x208EC40 Offset: 0x208ED41 VA: 0x208EC40
	private List<ItemDataLinker> GetItemListOnFilter(ItemType itemType) { }

	// RVA: 0x208DC10 Offset: 0x208DD11 VA: 0x208DC10
	public int CheckFreeSpace() { }

	// RVA: 0x208ED60 Offset: 0x208EE61 VA: 0x208ED60
	public ItemData PushItemInEmptySlot(ItemData itemData) { }

	// RVA: 0x208EE40 Offset: 0x208EF41 VA: 0x208EE40
	public ItemStorage.PushItemResult PushItemInWithResult(ItemData itemData) { }

	// RVA: 0x208DF80 Offset: 0x208E081 VA: 0x208DF80
	public bool PushItemIn(ItemData itemData) { }

	// RVA: 0x208F090 Offset: 0x208F191 VA: 0x208F090
	public ItemDataLinker TakeItem(ItemID itemId) { }

	// RVA: 0x208F160 Offset: 0x208F261 VA: 0x208F160
	public void RemoveItem(ItemID itemId) { }

	// RVA: 0x208F250 Offset: 0x208F351 VA: 0x208F250
	public void RemoveAllItem() { }

	// RVA: 0x208F2D0 Offset: 0x208F3D1 VA: 0x208F2D0
	private List<ItemDataLinker> GetItemListOnFilter(int itemType) { }

	// RVA: 0x208F3F0 Offset: 0x208F4F1 VA: 0x208F3F0
	public ItemStorage.PushItemResult CheckCanPushAllResult(ItemData itemData) { }

	// RVA: 0x208F5C0 Offset: 0x208F6C1 VA: 0x208F5C0
	public bool CheckCanPushAll(ItemData itemData) { }

	// RVA: 0x208F070 Offset: 0x208F171 VA: 0x208F070
	public bool CheckItemGuard(ItemType type) { }

	// RVA: 0x208F770 Offset: 0x208F871 VA: 0x208F770
	public ItemData PopInventorySlot(int index) { }

	// RVA: 0x208F7D0 Offset: 0x208F8D1 VA: 0x208F7D0
	public List<ItemData> PopInventoryAmount(ItemID itemID, int amount) { }

	// RVA: 0x208E270 Offset: 0x208E371 VA: 0x208E270
	public bool CanAddItem(ItemData inventoryItemData) { }

	// RVA: 0x208FB50 Offset: 0x208FC51 VA: 0x208FB50
	private int IndexOf(ItemData inventoryItemData) { }

	// RVA: 0x208FA00 Offset: 0x208FB01 VA: 0x208FA00
	private int IndexOfWithAddable(ItemData inventoryItemData) { }

	// RVA: 0x208FC50 Offset: 0x208FD51 VA: 0x208FC50
	public int GetItemAmoutId(ItemID itemId) { }

	// RVA: 0x208FD30 Offset: 0x208FE31 VA: 0x208FD30
	public int GetSpaceToInput(ItemID itemId) { }

	// RVA: 0x208FFB0 Offset: 0x20900B1 VA: 0x208FFB0
	public bool IsItemIdInside(ItemID itemID) { }

	// RVA: 0x208FFD0 Offset: 0x20900D1 VA: 0x208FFD0
	public int IndexOf(ItemID itemID) { }

	// RVA: 0x2090080 Offset: 0x2090181 VA: 0x2090080
	public int IndexOf(ItemCategory itemCategory) { }

	// RVA: 0x2090140 Offset: 0x2090241 VA: 0x2090140
	public int HasItemCount(ItemID itemID) { }

	// RVA: 0x208E200 Offset: 0x208E301 VA: 0x208E200
	public bool IsCanAccess() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A24D0 Offset: 0x1A25D1 VA: 0x1A24D0
	// RVA: 0x20901F0 Offset: 0x20902F1 VA: 0x20901F0
	private int <DoSortItem>b__45_1(ItemData a, ItemData b) { }
}

