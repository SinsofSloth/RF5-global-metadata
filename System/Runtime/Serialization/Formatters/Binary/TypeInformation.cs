internal sealed class TypeInformation // TypeDefIndex: 1084
{
	// Fields
	private string fullTypeName; // 0x10
	private string assemblyString; // 0x18
	private bool hasTypeForwardedFrom; // 0x20

	// Properties
	internal string FullTypeName { get; }
	internal string AssemblyString { get; }
	internal bool HasTypeForwardedFrom { get; }

	// Methods

	// RVA: 0x150B4E0 Offset: 0x150B5E1 VA: 0x150B4E0
	internal string get_FullTypeName() { }

	// RVA: 0x150B4F0 Offset: 0x150B5F1 VA: 0x150B4F0
	internal string get_AssemblyString() { }

	// RVA: 0x150B500 Offset: 0x150B601 VA: 0x150B500
	internal bool get_HasTypeForwardedFrom() { }

	// RVA: 0x150B510 Offset: 0x150B611 VA: 0x150B510
	internal void .ctor(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }
}

