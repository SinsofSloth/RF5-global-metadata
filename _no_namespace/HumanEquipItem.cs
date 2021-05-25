[Serializable]
public class HumanEquipItem // TypeDefIndex: 6641
{
	// Fields
	[SerializeField] // RVA: 0x15E550 Offset: 0x15E651 VA: 0x15E550
	private EquipSlotType equipSlotType; // 0x10
	[SerializeField] // RVA: 0x15E560 Offset: 0x15E661 VA: 0x15E560
	private ItemData itemData; // 0x18
	[SerializeField] // RVA: 0x15E570 Offset: 0x15E671 VA: 0x15E570
	private GameObject[] itemsPrefab; // 0x20
	[SerializeField] // RVA: 0x15E580 Offset: 0x15E681 VA: 0x15E580
	private ItemEquip[] itemEquips; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15E590 Offset: 0x15E691 VA: 0x15E590
	private bool <IsEquip>k__BackingField; // 0x30

	// Properties
	public bool IsEquip { get; set; }
	public EquipSlotType SlotType { get; }
	public ItemData ItemData { get; }
	public ItemEquip[] ItemEquips { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19C4A0 Offset: 0x19C5A1 VA: 0x19C4A0
	// RVA: 0x1E92B20 Offset: 0x1E92C21 VA: 0x1E92B20
	public bool get_IsEquip() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C4B0 Offset: 0x19C5B1 VA: 0x19C4B0
	// RVA: 0x1E92B30 Offset: 0x1E92C31 VA: 0x1E92B30
	public void set_IsEquip(bool value) { }

	// RVA: 0x1E92B40 Offset: 0x1E92C41 VA: 0x1E92B40
	public EquipSlotType get_SlotType() { }

	// RVA: 0x1E92B50 Offset: 0x1E92C51 VA: 0x1E92B50
	public ItemData get_ItemData() { }

	// RVA: 0x1E92B60 Offset: 0x1E92C61 VA: 0x1E92B60
	public ItemEquip[] get_ItemEquips() { }

	// RVA: 0x1E92B70 Offset: 0x1E92C71 VA: 0x1E92B70
	private void Init() { }

	// RVA: 0x1E92BC0 Offset: 0x1E92CC1 VA: 0x1E92BC0
	public void .ctor(EquipSlotType slot_type) { }

	// RVA: 0x1E92C20 Offset: 0x1E92D21 VA: 0x1E92C20
	public void Set(ItemData item_data) { }

	// RVA: 0x1E92C50 Offset: 0x1E92D51 VA: 0x1E92C50
	public void Reset(ItemData item_data) { }

	// RVA: 0x1E92C60 Offset: 0x1E92D61 VA: 0x1E92C60
	public void Create(ItemID itemID, GameObject[] items) { }

	// RVA: 0x1E92E80 Offset: 0x1E92F81 VA: 0x1E92E80
	public void Clear() { }
}

