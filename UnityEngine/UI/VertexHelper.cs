public class VertexHelper : IDisposable // TypeDefIndex: 4028
{
	// Fields
	private List<Vector3> m_Positions; // 0x10
	private List<Color32> m_Colors; // 0x18
	private List<Vector2> m_Uv0S; // 0x20
	private List<Vector2> m_Uv1S; // 0x28
	private List<Vector2> m_Uv2S; // 0x30
	private List<Vector2> m_Uv3S; // 0x38
	private List<Vector3> m_Normals; // 0x40
	private List<Vector4> m_Tangents; // 0x48
	private List<int> m_Indices; // 0x50
	private static readonly Vector4 s_DefaultTangent; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x10
	private bool m_ListsInitalized; // 0x58

	// Properties
	public int currentVertCount { get; }
	public int currentIndexCount { get; }

	// Methods

	// RVA: 0x1B846D0 Offset: 0x1B847D1 VA: 0x1B846D0
	public void .ctor() { }

	// RVA: 0x1B846E0 Offset: 0x1B847E1 VA: 0x1B846E0
	public void .ctor(Mesh m) { }

	// RVA: 0x1B848C0 Offset: 0x1B849C1 VA: 0x1B848C0
	private void InitializeListIfRequired() { }

	// RVA: 0x1B84AE0 Offset: 0x1B84BE1 VA: 0x1B84AE0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1B82A80 Offset: 0x1B82B81 VA: 0x1B82A80
	public void Clear() { }

	// RVA: 0x1B84D60 Offset: 0x1B84E61 VA: 0x1B84D60
	public int get_currentVertCount() { }

	// RVA: 0x1B84DC0 Offset: 0x1B84EC1 VA: 0x1B84DC0
	public int get_currentIndexCount() { }

	// RVA: 0x1B84E20 Offset: 0x1B84F21 VA: 0x1B84E20
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	// RVA: 0x1B85010 Offset: 0x1B85111 VA: 0x1B85010
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x1B85160 Offset: 0x1B85261 VA: 0x1B85160
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x1B852D0 Offset: 0x1B853D1 VA: 0x1B852D0
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x1B85490 Offset: 0x1B85591 VA: 0x1B85490
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0, Vector2 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x1B855B0 Offset: 0x1B856B1 VA: 0x1B855B0
	public void AddVert(Vector3 position, Color32 color, Vector2 uv0) { }

	// RVA: 0x1B856E0 Offset: 0x1B857E1 VA: 0x1B856E0
	public void AddVert(UIVertex v) { }

	// RVA: 0x1B85750 Offset: 0x1B85851 VA: 0x1B85750
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x1B82BA0 Offset: 0x1B82CA1 VA: 0x1B82BA0
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x1B85800 Offset: 0x1B85901 VA: 0x1B85800
	public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) { }

	// RVA: 0x1B858C0 Offset: 0x1B859C1 VA: 0x1B858C0
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	// RVA: 0x1B85920 Offset: 0x1B85A21 VA: 0x1B85920
	public void GetUIVertexStream(List<UIVertex> stream) { }

	// RVA: 0x1B85980 Offset: 0x1B85A81 VA: 0x1B85980
	private static void .cctor() { }
}

