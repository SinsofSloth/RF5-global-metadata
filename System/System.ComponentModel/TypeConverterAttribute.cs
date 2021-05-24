[AttributeUsageAttribute] // RVA: 0xBBFE0 Offset: 0xBC0E1 VA: 0xBBFE0
public sealed class TypeConverterAttribute : Attribute // TypeDefIndex: 1819
{
	// Fields
	private string typeName; // 0x10
	public static readonly TypeConverterAttribute Default; // 0x0

	// Properties
	public string ConverterTypeName { get; }

	// Methods

	// RVA: 0x28E8190 Offset: 0x28E8291 VA: 0x28E8190
	public void .ctor() { }

	// RVA: 0x28E8200 Offset: 0x28E8301 VA: 0x28E8200
	public void .ctor(Type type) { }

	// RVA: 0x28E8250 Offset: 0x28E8351 VA: 0x28E8250
	public string get_ConverterTypeName() { }

	// RVA: 0x28E8260 Offset: 0x28E8361 VA: 0x28E8260 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x28E8300 Offset: 0x28E8401 VA: 0x28E8300 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x28E8320 Offset: 0x28E8421 VA: 0x28E8320
	private static void .cctor() { }
}

