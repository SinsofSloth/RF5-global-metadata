[NativeHeaderAttribute] // RVA: 0x106CA0 Offset: 0x106DA1 VA: 0x106CA0
[RequiredByNativeCodeAttribute] // RVA: 0x106CA0 Offset: 0x106DA1 VA: 0x106CA0
public struct MeshGenerationResult : IEquatable<MeshGenerationResult> // TypeDefIndex: 3739
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x107130 Offset: 0x107231 VA: 0x107130
	[CompilerGeneratedAttribute] // RVA: 0x107130 Offset: 0x107231 VA: 0x107130
	private readonly MeshId <MeshId>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x107170 Offset: 0x107271 VA: 0x107170
	[DebuggerBrowsableAttribute] // RVA: 0x107170 Offset: 0x107271 VA: 0x107170
	private readonly Mesh <Mesh>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x1071B0 Offset: 0x1072B1 VA: 0x1071B0
	[DebuggerBrowsableAttribute] // RVA: 0x1071B0 Offset: 0x1072B1 VA: 0x1071B0
	private readonly MeshCollider <MeshCollider>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x1071F0 Offset: 0x1072F1 VA: 0x1071F0
	[CompilerGeneratedAttribute] // RVA: 0x1071F0 Offset: 0x1072F1 VA: 0x1071F0
	private readonly MeshGenerationStatus <Status>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x107230 Offset: 0x107331 VA: 0x107230
	[DebuggerBrowsableAttribute] // RVA: 0x107230 Offset: 0x107331 VA: 0x107230
	private readonly MeshVertexAttributes <Attributes>k__BackingField; // 0x24

	// Properties
	public MeshId MeshId { get; }
	public Mesh Mesh { get; }
	public MeshCollider MeshCollider { get; }
	public MeshGenerationStatus Status { get; }
	public MeshVertexAttributes Attributes { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x107320 Offset: 0x107421 VA: 0x107320
	// RVA: 0x25E80 Offset: 0x25F81 VA: 0x25E80
	public MeshId get_MeshId() { }

	[CompilerGeneratedAttribute] // RVA: 0x107330 Offset: 0x107431 VA: 0x107330
	// RVA: 0x25E90 Offset: 0x25F91 VA: 0x25E90
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x107340 Offset: 0x107441 VA: 0x107340
	// RVA: 0x25EA0 Offset: 0x25FA1 VA: 0x25EA0
	public MeshCollider get_MeshCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x107350 Offset: 0x107451 VA: 0x107350
	// RVA: 0x25EB0 Offset: 0x25FB1 VA: 0x25EB0
	public MeshGenerationStatus get_Status() { }

	[CompilerGeneratedAttribute] // RVA: 0x107360 Offset: 0x107461 VA: 0x107360
	// RVA: 0x25EC0 Offset: 0x25FC1 VA: 0x25EC0
	public MeshVertexAttributes get_Attributes() { }

	// RVA: 0x25ED0 Offset: 0x25FD1 VA: 0x25ED0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x25F80 Offset: 0x26081 VA: 0x25F80 Slot: 4
	public bool Equals(MeshGenerationResult other) { }

	// RVA: 0x25FC0 Offset: 0x260C1 VA: 0x25FC0 Slot: 2
	public override int GetHashCode() { }
}

