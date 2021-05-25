private class TypeIdentifiers.Display : TypeNames.ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName> // TypeDefIndex: 421
{
	// Fields
	private string displayName; // 0x10
	private string internal_name; // 0x18

	// Properties
	public override string DisplayName { get; }
	public string InternalName { get; }

	// Methods

	// RVA: 0x1ADDFE0 Offset: 0x1ADE0E1 VA: 0x1ADDFE0
	internal void .ctor(string displayName) { }

	// RVA: 0x1ADE040 Offset: 0x1ADE141 VA: 0x1ADE040 Slot: 6
	public override string get_DisplayName() { }

	// RVA: 0x1ADE050 Offset: 0x1ADE151 VA: 0x1ADE050 Slot: 7
	public string get_InternalName() { }

	// RVA: 0x1ADE0A0 Offset: 0x1ADE1A1 VA: 0x1ADE0A0
	private string GetInternalName() { }
}

