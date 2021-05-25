[DefaultMemberAttribute] // RVA: 0xB0980 Offset: 0xB0A81 VA: 0xB0980
[Serializable]
internal sealed class IntSizedArray : ICloneable // TypeDefIndex: 1093
{
	// Fields
	internal int[] objects; // 0x10
	internal int[] negObjects; // 0x18

	// Properties
	internal int Item { get; set; }

	// Methods

	// RVA: 0x1606E20 Offset: 0x1606F21 VA: 0x1606E20
	public void .ctor() { }

	// RVA: 0x1606EB0 Offset: 0x1606FB1 VA: 0x1606EB0
	private void .ctor(IntSizedArray sizedArray) { }

	// RVA: 0x1606FE0 Offset: 0x16070E1 VA: 0x1606FE0 Slot: 4
	public object Clone() { }

	// RVA: 0x1607040 Offset: 0x1607141 VA: 0x1607040
	internal int get_Item(int index) { }

	// RVA: 0x16070D0 Offset: 0x16071D1 VA: 0x16070D0
	internal void set_Item(int index, int value) { }

	// RVA: 0x1607190 Offset: 0x1607291 VA: 0x1607190
	internal void IncreaseCapacity(int index) { }
}

