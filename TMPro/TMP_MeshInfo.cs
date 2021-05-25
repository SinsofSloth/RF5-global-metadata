public struct TMP_MeshInfo // TypeDefIndex: 5829
{
	// Fields
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x4
	private static readonly Vector4 s_DefaultTangent; // 0x10
	private static readonly Bounds s_DefaultBounds; // 0x20
	public Mesh mesh; // 0x0
	public int vertexCount; // 0x8
	public Vector3[] vertices; // 0x10
	public Vector3[] normals; // 0x18
	public Vector4[] tangents; // 0x20
	public Vector2[] uvs0; // 0x28
	public Vector2[] uvs2; // 0x30
	public Color32[] colors32; // 0x38
	public int[] triangles; // 0x40
	public Material material; // 0x48

	// Methods

	// RVA: 0x3360 Offset: 0x3461 VA: 0x3360
	public void .ctor(Mesh mesh, int size) { }

	// RVA: 0x3370 Offset: 0x3471 VA: 0x3370
	public void .ctor(Mesh mesh, int size, bool isVolumetric) { }

	// RVA: 0x3380 Offset: 0x3481 VA: 0x3380
	public void ResizeMeshInfo(int size) { }

	// RVA: 0x3390 Offset: 0x3491 VA: 0x3390
	public void ResizeMeshInfo(int size, bool isVolumetric) { }

	// RVA: 0x33A0 Offset: 0x34A1 VA: 0x33A0
	public void Clear() { }

	// RVA: 0x33B0 Offset: 0x34B1 VA: 0x33B0
	public void Clear(bool uploadChanges) { }

	// RVA: 0x33C0 Offset: 0x34C1 VA: 0x33C0
	public void ClearUnusedVertices() { }

	// RVA: 0x3400 Offset: 0x3501 VA: 0x3400
	public void ClearUnusedVertices(int startIndex) { }

	// RVA: 0x3430 Offset: 0x3531 VA: 0x3430
	public void ClearUnusedVertices(int startIndex, bool updateMesh) { }

	// RVA: 0x3440 Offset: 0x3541 VA: 0x3440
	public void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x34C0 Offset: 0x35C1 VA: 0x34C0
	public void SortGeometry(IList<int> sortingOrder) { }

	// RVA: 0x34D0 Offset: 0x35D1 VA: 0x34D0
	public void SwapVertexData(int src, int dst) { }

	// RVA: 0x1575750 Offset: 0x1575851 VA: 0x1575750
	private static void .cctor() { }
}

