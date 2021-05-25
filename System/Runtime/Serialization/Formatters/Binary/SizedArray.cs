[DefaultMemberAttribute] // RVA: 0xB0940 Offset: 0xB0A41 VA: 0xB0940
[Serializable]
internal sealed class SizedArray : ICloneable // TypeDefIndex: 1092
{
	// Fields
	internal object[] objects; // 0x10
	internal object[] negObjects; // 0x18

	// Properties
	internal object Item { get; set; }

	// Methods

	// RVA: 0x150ADD0 Offset: 0x150AED1 VA: 0x150ADD0
	internal void .ctor() { }

	// RVA: 0x150AE60 Offset: 0x150AF61 VA: 0x150AE60
	internal void .ctor(int length) { }

	// RVA: 0x150AF00 Offset: 0x150B001 VA: 0x150AF00
	private void .ctor(SizedArray sizedArray) { }

	// RVA: 0x150AFE0 Offset: 0x150B0E1 VA: 0x150AFE0 Slot: 4
	public object Clone() { }

	// RVA: 0x150B040 Offset: 0x150B141 VA: 0x150B040
	internal object get_Item(int index) { }

	// RVA: 0x150B0E0 Offset: 0x150B1E1 VA: 0x150B0E0
	internal void set_Item(int index, object value) { }

	// RVA: 0x150B200 Offset: 0x150B301 VA: 0x150B200
	internal void IncreaseCapacity(int index) { }
}

