public class ItemPoolData // TypeDefIndex: 6718
{
	// Fields
	public ItemID itemID; // 0x10
	public bool IsActive; // 0x14
	public string[] ItemName; // 0x18
	public Prefab[] ItemDataID; // 0x20
	public GameObject[] Item; // 0x28
	public int Reference; // 0x30
	public Action<ItemID> Callback; // 0x38

	// Methods

	// RVA: 0x208B330 Offset: 0x208B431 VA: 0x208B330
	private void Init() { }

	// RVA: 0x208B390 Offset: 0x208B491 VA: 0x208B390
	public void .ctor(ItemID item_id, Action<ItemID> action) { }

	// RVA: 0x208B430 Offset: 0x208B531 VA: 0x208B430
	public void Destroy() { }

	// RVA: 0x208B5D0 Offset: 0x208B6D1 VA: 0x208B5D0
	public void Add(Action<ItemID> action) { }

	// RVA: 0x208B440 Offset: 0x208B541 VA: 0x208B440
	public bool Delete() { }

	// RVA: 0x208B6A0 Offset: 0x208B7A1 VA: 0x208B6A0
	public void Update() { }
}

