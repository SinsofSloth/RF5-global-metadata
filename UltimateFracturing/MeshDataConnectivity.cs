public class MeshDataConnectivity // TypeDefIndex: 9243
{
	// Fields
	public static int s_CurrentSharedFaceHash; // 0x0
	public Dictionary<int, List<MeshDataConnectivity.Face>> dicHash2FaceList; // 0x10
	public Dictionary<MeshDataConnectivity.Face, List<int>> dicFace2HashList; // 0x18
	public Dictionary<MeshDataConnectivity.Face, bool> dicFace2IsClipped; // 0x20

	// Methods

	// RVA: 0x1F4B6B0 Offset: 0x1F4B7B1 VA: 0x1F4B6B0
	public void .ctor() { }

	// RVA: 0x1F4DA10 Offset: 0x1F4DB11 VA: 0x1F4DA10
	public MeshDataConnectivity GetDeepCopy() { }

	// RVA: 0x1F51760 Offset: 0x1F51861 VA: 0x1F51760
	public void NotifyNewClippedFace(MeshData meshDataSource, int nSourceSubMesh, int nSourceFaceIndex, int nDestSubMesh, int nDestFaceIndex) { }

	// RVA: 0x1F51BC0 Offset: 0x1F51CC1 VA: 0x1F51BC0
	public static int GetNewHash() { }

	// RVA: 0x1F51CE0 Offset: 0x1F51DE1 VA: 0x1F51CE0
	public void NotifyNewCapFace(int nHash, int nSubMesh, int nFaceIndex) { }

	// RVA: 0x1F50DA0 Offset: 0x1F50EA1 VA: 0x1F50DA0
	public void NotifyRemappedFace(MeshDataConnectivity source, int nSourceSubMesh, int nSourceFaceIndex, int nDestSubMesh, int nDestFaceIndex) { }

	// RVA: 0x1F51E80 Offset: 0x1F51F81 VA: 0x1F51E80
	private static void .cctor() { }
}

