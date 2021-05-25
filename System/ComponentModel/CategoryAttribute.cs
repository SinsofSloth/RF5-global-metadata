[AttributeUsageAttribute] // RVA: 0xBBF00 Offset: 0xBC001 VA: 0xBBF00
public class CategoryAttribute : Attribute // TypeDefIndex: 1799
{
	// Fields
	private bool localized; // 0x10
	private string categoryValue; // 0x18

	// Properties
	public string Category { get; }

	// Methods

	// RVA: 0x28E7310 Offset: 0x28E7411 VA: 0x28E7310
	public string get_Category() { }

	// RVA: 0x28E7370 Offset: 0x28E7471 VA: 0x28E7370 Slot: 4
	protected virtual string GetLocalizedString(string value) { }
}

