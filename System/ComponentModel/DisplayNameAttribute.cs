[AttributeUsageAttribute] // RVA: 0xBBF40 Offset: 0xBC041 VA: 0xBBF40
public class DisplayNameAttribute : Attribute // TypeDefIndex: 1803
{
	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	private string _displayName; // 0x10

	// Properties
	public virtual string DisplayName { get; }
	protected string DisplayNameValue { get; }

	// Methods

	// RVA: 0x28E77E0 Offset: 0x28E78E1 VA: 0x28E77E0
	public void .ctor() { }

	// RVA: 0x28E7850 Offset: 0x28E7951 VA: 0x28E7850
	public void .ctor(string displayName) { }

	// RVA: 0x28E7890 Offset: 0x28E7991 VA: 0x28E7890 Slot: 4
	public virtual string get_DisplayName() { }

	// RVA: 0x28E78A0 Offset: 0x28E79A1 VA: 0x28E78A0
	protected string get_DisplayNameValue() { }

	// RVA: 0x28E78B0 Offset: 0x28E79B1 VA: 0x28E78B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x28E79D0 Offset: 0x28E7AD1 VA: 0x28E79D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x28E7A00 Offset: 0x28E7B01 VA: 0x28E7A00
	private static void .cctor() { }
}

