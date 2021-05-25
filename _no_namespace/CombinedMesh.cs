public class CombinedMesh : MonoBehaviour // TypeDefIndex: 9039
{
	// Fields
	public bool SaveMeshAsset; // 0x18
	public bool KeepPosition; // 0x19
	public CombinedMesh.EPivotMode PivotMode; // 0x1C
	public MeshFilter[] MeshObjects; // 0x20
	public GameObject RootNode; // 0x28
	private bool m_bCancelled; // 0x30
	[SerializeField] // RVA: 0x175930 Offset: 0x175A31 VA: 0x175930
	private List<CombinedMesh.ObjectInfo> m_listObjectInfo; // 0x38
	private Dictionary<Material, List<CombinedMesh.MaterialMeshInfo>> m_dicMeshEntries; // 0x40

	// Methods

	// RVA: 0x1FC0F10 Offset: 0x1FC1011 VA: 0x1FC0F10
	public void CancelCombining() { }

	// RVA: 0x1FC0F20 Offset: 0x1FC1021 VA: 0x1FC0F20
	public bool CombiningCancelled() { }

	// RVA: 0x1FC0F30 Offset: 0x1FC1031 VA: 0x1FC0F30
	public void TransformObjInfoMeshVectorsToLocal(Transform newTransform) { }

	// RVA: 0x1FC14F0 Offset: 0x1FC15F1 VA: 0x1FC14F0
	public int GetObjectCount() { }

	// RVA: 0x1FC1540 Offset: 0x1FC1641 VA: 0x1FC1540
	public CombinedMesh.ObjectInfo GetObjectInfo(int nIndex) { }

	// RVA: 0x1FC15C0 Offset: 0x1FC16C1 VA: 0x1FC15C0
	public void Combine(CombinedMesh.CombineProgressDelegate progress) { }

	// RVA: 0x1FC44D0 Offset: 0x1FC45D1 VA: 0x1FC44D0
	public void .ctor() { }
}

