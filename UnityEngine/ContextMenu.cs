[RequiredByNativeCodeAttribute] // RVA: 0xC6730 Offset: 0xC6831 VA: 0xC6730
[AttributeUsageAttribute] // RVA: 0xC6730 Offset: 0xC6831 VA: 0xC6730
public sealed class ContextMenu : Attribute // TypeDefIndex: 2996
{
	// Fields
	public readonly string menuItem; // 0x10
	public readonly bool validate; // 0x18
	public readonly int priority; // 0x1C

	// Methods

	// RVA: 0x2B023E0 Offset: 0x2B024E1 VA: 0x2B023E0
	public void .ctor(string itemName) { }

	// RVA: 0x2B02430 Offset: 0x2B02531 VA: 0x2B02430
	public void .ctor(string itemName, bool isValidateFunction) { }

	// RVA: 0x2B02490 Offset: 0x2B02591 VA: 0x2B02490
	public void .ctor(string itemName, bool isValidateFunction, int priority) { }
}

