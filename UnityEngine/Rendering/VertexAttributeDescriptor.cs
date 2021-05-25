[UsedByNativeCodeAttribute] // RVA: 0xC85E0 Offset: 0xC86E1 VA: 0xC85E0
public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor> // TypeDefIndex: 3291
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xCB780 Offset: 0xCB881 VA: 0xCB780
	[DebuggerBrowsableAttribute] // RVA: 0xCB780 Offset: 0xCB881 VA: 0xCB780
	private VertexAttribute <attribute>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xCB7C0 Offset: 0xCB8C1 VA: 0xCB7C0
	[DebuggerBrowsableAttribute] // RVA: 0xCB7C0 Offset: 0xCB8C1 VA: 0xCB7C0
	private VertexAttributeFormat <format>k__BackingField; // 0x4
	[DebuggerBrowsableAttribute] // RVA: 0xCB800 Offset: 0xCB901 VA: 0xCB800
	[CompilerGeneratedAttribute] // RVA: 0xCB800 Offset: 0xCB901 VA: 0xCB800
	private int <dimension>k__BackingField; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0xCB840 Offset: 0xCB941 VA: 0xCB840
	[CompilerGeneratedAttribute] // RVA: 0xCB840 Offset: 0xCB941 VA: 0xCB840
	private int <stream>k__BackingField; // 0xC

	// Properties
	public VertexAttribute attribute { get; }
	public VertexAttributeFormat format { get; }
	public int dimension { get; }
	public int stream { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xD99C0 Offset: 0xD9AC1 VA: 0xD99C0
	// RVA: 0x374C80 Offset: 0x374D81 VA: 0x374C80
	public VertexAttribute get_attribute() { }

	[CompilerGeneratedAttribute] // RVA: 0xD99D0 Offset: 0xD9AD1 VA: 0xD99D0
	// RVA: 0x374C90 Offset: 0x374D91 VA: 0x374C90
	public VertexAttributeFormat get_format() { }

	[CompilerGeneratedAttribute] // RVA: 0xD99E0 Offset: 0xD9AE1 VA: 0xD99E0
	// RVA: 0x374CA0 Offset: 0x374DA1 VA: 0x374CA0
	public int get_dimension() { }

	[CompilerGeneratedAttribute] // RVA: 0xD99F0 Offset: 0xD9AF1 VA: 0xD99F0
	// RVA: 0x374CB0 Offset: 0x374DB1 VA: 0x374CB0
	public int get_stream() { }

	// RVA: 0x374CC0 Offset: 0x374DC1 VA: 0x374CC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x374CD0 Offset: 0x374DD1 VA: 0x374CD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x374D00 Offset: 0x374E01 VA: 0x374D00 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x374E20 Offset: 0x374F21 VA: 0x374E20 Slot: 4
	public bool Equals(VertexAttributeDescriptor other) { }
}

