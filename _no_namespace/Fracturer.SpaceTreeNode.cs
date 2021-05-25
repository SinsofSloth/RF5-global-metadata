private class Fracturer.SpaceTreeNode // TypeDefIndex: 9228
{
	// Fields
	private Fracturer.SpaceTreeNode nodeOneSide; // 0x10
	private Fracturer.SpaceTreeNode nodeOtherSide; // 0x18
	private int nLevel; // 0x20
	private int nSplitsX; // 0x24
	private int nSplitsY; // 0x28
	private int nSplitsZ; // 0x2C
	private Vector3 v3Min; // 0x30
	private Vector3 v3Max; // 0x3C
	private List<MeshData> listMeshDatasSpace; // 0x48

	// Methods

	// RVA: 0x1F4A8C0 Offset: 0x1F4A9C1 VA: 0x1F4A8C0
	public void .ctor() { }

	// RVA: 0x1F4A970 Offset: 0x1F4AA71 VA: 0x1F4A970
	public bool ContainsCompletely(Vector3 v3Min, Vector3 v3Max) { }

	// RVA: 0x1F4A9F0 Offset: 0x1F4AAF1 VA: 0x1F4A9F0
	public static List<MeshData> GetSmallestPossibleMeshData(Fracturer.SpaceTreeNode root, Vector3 v3Min, Vector3 v3Max) { }

	// RVA: 0x1F4AB60 Offset: 0x1F4AC61 VA: 0x1F4AB60
	public static Fracturer.SpaceTreeNode BuildSpaceTree(MeshData meshDataIn, int nSubdivisionLevels, FracturedObject fracturedComponent, Fracturer.ProgressDelegate progress) { }
}

