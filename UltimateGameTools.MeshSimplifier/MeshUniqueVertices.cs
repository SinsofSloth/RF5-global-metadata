[Serializable]
public class MeshUniqueVertices // TypeDefIndex: 9203
{
	// Fields
	[SerializeField] // RVA: 0x177560 Offset: 0x177661 VA: 0x177560
	private List<Vector3> m_listVertices; // 0x10
	[SerializeField] // RVA: 0x177570 Offset: 0x177671 VA: 0x177570
	private List<Vector3> m_listVerticesWorld; // 0x18
	[SerializeField] // RVA: 0x177580 Offset: 0x177681 VA: 0x177580
	private List<MeshUniqueVertices.SerializableBoneWeight> m_listBoneWeights; // 0x20
	[SerializeField] // RVA: 0x177590 Offset: 0x177691 VA: 0x177590
	private MeshUniqueVertices.ListIndices[] m_aFaceList; // 0x28

	// Properties
	public MeshUniqueVertices.ListIndices[] SubmeshesFaceList { get; }
	public List<Vector3> ListVertices { get; }
	public List<Vector3> ListVerticesWorld { get; }
	public List<MeshUniqueVertices.SerializableBoneWeight> ListBoneWeights { get; }

	// Methods

	// RVA: 0x1F566B0 Offset: 0x1F567B1 VA: 0x1F566B0
	public MeshUniqueVertices.ListIndices[] get_SubmeshesFaceList() { }

	// RVA: 0x1F566C0 Offset: 0x1F567C1 VA: 0x1F566C0
	public List<Vector3> get_ListVertices() { }

	// RVA: 0x1F566D0 Offset: 0x1F567D1 VA: 0x1F566D0
	public List<Vector3> get_ListVerticesWorld() { }

	// RVA: 0x1F566E0 Offset: 0x1F567E1 VA: 0x1F566E0
	public List<MeshUniqueVertices.SerializableBoneWeight> get_ListBoneWeights() { }

	// RVA: 0x1F566F0 Offset: 0x1F567F1 VA: 0x1F566F0
	public void BuildData(Mesh sourceMesh, Vector3[] av3VerticesWorld) { }

	// RVA: 0x1F57100 Offset: 0x1F57201 VA: 0x1F57100
	public void .ctor() { }
}

