[AttributeUsageAttribute] // RVA: 0xB1940 Offset: 0xB1A41 VA: 0xB1940
public sealed class InternalsVisibleToAttribute : Attribute // TypeDefIndex: 1280
{
	// Fields
	private string _assemblyName; // 0x10
	private bool _allInternalsVisible; // 0x18

	// Properties
	public string AssemblyName { get; }
	public bool AllInternalsVisible { get; set; }

	// Methods

	// RVA: 0x1802860 Offset: 0x1802961 VA: 0x1802860
	public void .ctor(string assemblyName) { }

	// RVA: 0x18028A0 Offset: 0x18029A1 VA: 0x18028A0
	public string get_AssemblyName() { }

	// RVA: 0x18028B0 Offset: 0x18029B1 VA: 0x18028B0
	public bool get_AllInternalsVisible() { }

	// RVA: 0x18028C0 Offset: 0x18029C1 VA: 0x18028C0
	public void set_AllInternalsVisible(bool value) { }
}

