[DefaultMemberAttribute] // RVA: 0x146BE0 Offset: 0x146CE1 VA: 0x146BE0
[MessagePackObjectAttribute] // RVA: 0x146BE0 Offset: 0x146CE1 VA: 0x146BE0
public class HumanEquip // TypeDefIndex: 8227
{
	// Fields
	[KeyAttribute] // RVA: 0x16CBD0 Offset: 0x16CCD1 VA: 0x16CBD0
	public ItemData[] EquipItems; // 0x10
	[IgnoreMemberAttribute] // RVA: 0x16CC10 Offset: 0x16CD11 VA: 0x16CC10
	private EquipSlotType _CurrentWeaponSlot; // 0x18

	// Properties
	[IgnoreMemberAttribute] // RVA: 0x1B9240 Offset: 0x1B9341 VA: 0x1B9240
	public EquipSlotType CurrentWeaponSlot { get; set; }
	[IgnoreMemberAttribute] // RVA: 0x1B9250 Offset: 0x1B9351 VA: 0x1B9250
	public ItemData Item { get; set; }
	[IgnoreMemberAttribute] // RVA: 0x1B9260 Offset: 0x1B9361 VA: 0x1B9260
	public ItemData Item { get; set; }
	[IgnoreMemberAttribute] // RVA: 0x1B9270 Offset: 0x1B9371 VA: 0x1B9270
	public int Length { get; }

	// Methods

	// RVA: 0x1E92120 Offset: 0x1E92221 VA: 0x1E92120
	public EquipSlotType get_CurrentWeaponSlot() { }

	// RVA: 0x1E8C880 Offset: 0x1E8C981 VA: 0x1E8C880
	public void set_CurrentWeaponSlot(EquipSlotType value) { }

	// RVA: 0x1E92130 Offset: 0x1E92231 VA: 0x1E92130
	public ItemData get_Item(EquipSlotType slot_type) { }

	// RVA: 0x1E8C4B0 Offset: 0x1E8C5B1 VA: 0x1E8C4B0
	public void set_Item(EquipSlotType slot_type, ItemData value) { }

	// RVA: 0x1E92170 Offset: 0x1E92271 VA: 0x1E92170
	public ItemData get_Item(int slot_type) { }

	// RVA: 0x1E921B0 Offset: 0x1E922B1 VA: 0x1E921B0
	public void set_Item(int slot_type, ItemData value) { }

	// RVA: 0x1E84680 Offset: 0x1E84781 VA: 0x1E84680
	public ItemData GetCurrentWeapon() { }

	// RVA: 0x1E92230 Offset: 0x1E92331 VA: 0x1E92230
	public int get_Length() { }

	[SerializationConstructorAttribute] // RVA: 0x1A6610 Offset: 0x1A6711 VA: 0x1A6610
	// RVA: 0x1E92250 Offset: 0x1E92351 VA: 0x1E92250
	public void .ctor() { }

	// RVA: 0x1E922D0 Offset: 0x1E923D1 VA: 0x1E922D0
	public HumanEquip GetClone() { }

	// RVA: 0x1E8C1A0 Offset: 0x1E8C2A1 VA: 0x1E8C1A0
	public ItemData Pop(EquipSlotType slotType) { }

	// RVA: 0x1E8C460 Offset: 0x1E8C561 VA: 0x1E8C460
	public ItemData Set(EquipSlotType slotType, ItemData pushData) { }
}

