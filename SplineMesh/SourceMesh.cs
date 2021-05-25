public struct SourceMesh // TypeDefIndex: 9757
{
	// Fields
	private Vector3 translation; // 0x0
	private Quaternion rotation; // 0xC
	private Vector3 scale; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x17EE80 Offset: 0x17EF81 VA: 0x17EE80
	private readonly Mesh <Mesh>k__BackingField; // 0x28
	private List<MeshVertex> vertices; // 0x30
	private int[] triangles; // 0x38
	private float minX; // 0x40
	private float length; // 0x44

	// Properties
	internal Mesh Mesh { get; }
	internal List<MeshVertex> Vertices { get; }
	internal int[] Triangles { get; }
	internal float MinX { get; }
	internal float Length { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1ACF90 Offset: 0x1AD091 VA: 0x1ACF90
	// RVA: 0x2F1460 Offset: 0x2F1561 VA: 0x2F1460
	internal Mesh get_Mesh() { }

	// RVA: 0x2F1470 Offset: 0x2F1571 VA: 0x2F1470
	internal List<MeshVertex> get_Vertices() { }

	// RVA: 0x2F14B0 Offset: 0x2F15B1 VA: 0x2F14B0
	internal int[] get_Triangles() { }

	// RVA: 0x2F14F0 Offset: 0x2F15F1 VA: 0x2F14F0
	internal float get_MinX() { }

	// RVA: 0x2F1530 Offset: 0x2F1631 VA: 0x2F1530
	internal float get_Length() { }

	// RVA: 0x2F1570 Offset: 0x2F1671 VA: 0x2F1570
	private void .ctor(Mesh mesh) { }

	// RVA: 0x2F15D0 Offset: 0x2F16D1 VA: 0x2F15D0
	private void .ctor(SourceMesh other) { }

	// RVA: 0x2241740 Offset: 0x2241841 VA: 0x2241740
	public static SourceMesh Build(Mesh mesh) { }

	// RVA: 0x2F1650 Offset: 0x2F1751 VA: 0x2F1650
	public SourceMesh Translate(Vector3 translation) { }

	// RVA: 0x2F1750 Offset: 0x2F1851 VA: 0x2F1750
	public SourceMesh Translate(float x, float y, float z) { }

	// RVA: 0x2F1860 Offset: 0x2F1961 VA: 0x2F1860
	public SourceMesh Rotate(Quaternion rotation) { }

	// RVA: 0x2F1960 Offset: 0x2F1A61 VA: 0x2F1960
	public SourceMesh Scale(Vector3 scale) { }

	// RVA: 0x2F1A60 Offset: 0x2F1B61 VA: 0x2F1A60
	public SourceMesh Scale(float x, float y, float z) { }

	// RVA: 0x2F1B70 Offset: 0x2F1C71 VA: 0x2F1B70
	private void BuildData() { }

	// RVA: 0x2F1B80 Offset: 0x2F1C81 VA: 0x2F1B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F1B90 Offset: 0x2F1C91 VA: 0x2F1B90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x223C470 Offset: 0x223C571 VA: 0x223C470
	public static bool op_Equality(SourceMesh sm1, SourceMesh sm2) { }

	// RVA: 0x2242010 Offset: 0x2242111 VA: 0x2242010
	public static bool op_Inequality(SourceMesh sm1, SourceMesh sm2) { }
}

