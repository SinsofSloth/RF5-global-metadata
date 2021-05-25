public struct MeshFaceConnectivity.EdgeData // TypeDefIndex: 9240
{
	// Fields
	public int nEdgeIndex; // 0x0
	private int nVertex1Hash; // 0x4
	private int nVertex2Hash; // 0x8
	public Vector3 v1; // 0xC
	public Vector3 v2; // 0x18
	public List<MeshFaceConnectivity.EdgeData.SideData> listSides; // 0x28

	// Methods

	// RVA: 0x2E17E0 Offset: 0x2E18E1 VA: 0x2E17E0
	public void .ctor(int nEdgeIndex, int nFace, int nSubMesh, int nSubMeshFace, int nEdgePos, Vector3 v1, Vector3 v2, int nVertex1Hash, int nVertex2Hash, int nVertexDataV1, int nVertexDataV2) { }

	// RVA: 0x2E1800 Offset: 0x2E1901 VA: 0x2E1800
	public bool Compare(int nVertex1Hash, int nVertex2Hash) { }

	// RVA: 0x2E1850 Offset: 0x2E1951 VA: 0x2E1850
	public void AddSideData(int nFace, int nSubMesh, int nSubMeshFace, int nEdgePos, int nVertexDataV1, int nVertexDataV2) { }

	// RVA: 0x2E1860 Offset: 0x2E1961 VA: 0x2E1860
	public bool HasMoreThanOneSide() { }
}

