private class Simplifier.Triangle // TypeDefIndex: 9212
{
	// Fields
	private Simplifier.Vertex[] m_aVertices; // 0x10
	private bool m_bUVData; // 0x18
	private int[] m_aUV; // 0x20
	private int[] m_aIndices; // 0x28
	private Vector3 m_v3Normal; // 0x30
	private int m_nSubMesh; // 0x3C

	// Properties
	public Simplifier.Vertex[] Vertices { get; }
	public bool HasUVData { get; }
	public int[] IndicesUV { get; }
	public Vector3 Normal { get; }
	public int[] Indices { get; }

	// Methods

	// RVA: 0x1F5ECF0 Offset: 0x1F5EDF1 VA: 0x1F5ECF0
	public Simplifier.Vertex[] get_Vertices() { }

	// RVA: 0x1F5ED00 Offset: 0x1F5EE01 VA: 0x1F5ED00
	public bool get_HasUVData() { }

	// RVA: 0x1F5ED10 Offset: 0x1F5EE11 VA: 0x1F5ED10
	public int[] get_IndicesUV() { }

	// RVA: 0x1F5ED20 Offset: 0x1F5EE21 VA: 0x1F5ED20
	public Vector3 get_Normal() { }

	// RVA: 0x1F5ED30 Offset: 0x1F5EE31 VA: 0x1F5ED30
	public int[] get_Indices() { }

	// RVA: 0x1F5ACD0 Offset: 0x1F5ADD1 VA: 0x1F5ACD0
	public void .ctor(Simplifier simplifier, int nSubMesh, Simplifier.Vertex v0, Simplifier.Vertex v1, Simplifier.Vertex v2, bool bUVData, int nIndex1, int nIndex2, int nIndex3) { }

	// RVA: 0x1F59CA0 Offset: 0x1F59DA1 VA: 0x1F59CA0
	public void Destructor(Simplifier simplifier) { }

	// RVA: 0x1F58DA0 Offset: 0x1F58EA1 VA: 0x1F58DA0
	public bool HasVertex(Simplifier.Vertex v) { }

	// RVA: 0x1F5ED40 Offset: 0x1F5EE41 VA: 0x1F5ED40
	public void ComputeNormal() { }

	// RVA: 0x1F58F30 Offset: 0x1F59031 VA: 0x1F58F30
	public int TexAt(Simplifier.Vertex vertex) { }

	// RVA: 0x1F5EFC0 Offset: 0x1F5F0C1 VA: 0x1F5EFC0
	public int TexAt(int i) { }

	// RVA: 0x1F59B70 Offset: 0x1F59C71 VA: 0x1F59B70
	public void SetTexAt(Simplifier.Vertex vertex, int uv) { }

	// RVA: 0x1F5F000 Offset: 0x1F5F101 VA: 0x1F5F000
	public void SetTexAt(int i, int uv) { }

	// RVA: 0x1F59EF0 Offset: 0x1F59FF1 VA: 0x1F59EF0
	public void ReplaceVertex(Simplifier.Vertex vold, Simplifier.Vertex vnew) { }
}

