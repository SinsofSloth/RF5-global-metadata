internal abstract class TypeNames.ATypeName : TypeName, IEquatable<TypeName> // TypeDefIndex: 419
{
	// Properties
	public abstract string DisplayName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_DisplayName() { }

	// RVA: 0x1ADF4B0 Offset: 0x1ADF5B1 VA: 0x1ADF4B0 Slot: 5
	public bool Equals(TypeName other) { }

	// RVA: 0x1ADF5A0 Offset: 0x1ADF6A1 VA: 0x1ADF5A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ADF5D0 Offset: 0x1ADF6D1 VA: 0x1ADF5D0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1ADE030 Offset: 0x1ADE131 VA: 0x1ADE030
	protected void .ctor() { }
}

