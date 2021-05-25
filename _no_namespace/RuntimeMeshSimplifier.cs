[RequireComponent] // RVA: 0x147990 Offset: 0x147A91 VA: 0x147990
public class RuntimeMeshSimplifier : MonoBehaviour // TypeDefIndex: 9048
{
	// Fields
	private Dictionary<GameObject, Material[]> m_objectMaterials; // 0x18
	private MeshSimplify m_selectedMeshSimplify; // 0x20
	private bool m_bFinished; // 0x28
	private Mesh m_newMesh; // 0x30
	private int m_nLastProgress; // 0x38
	private string m_strLastTitle; // 0x40
	private string m_strLastMessage; // 0x48

	// Properties
	public string ProgressTitle { get; }
	public string ProgressMessage { get; }
	public int ProgressPercent { get; }
	public bool Finished { get; }

	// Methods

	// RVA: 0x1D6B1C0 Offset: 0x1D6B2C1 VA: 0x1D6B1C0
	public string get_ProgressTitle() { }

	// RVA: 0x1D6B1D0 Offset: 0x1D6B2D1 VA: 0x1D6B1D0
	public string get_ProgressMessage() { }

	// RVA: 0x1D6B1E0 Offset: 0x1D6B2E1 VA: 0x1D6B1E0
	public int get_ProgressPercent() { }

	// RVA: 0x1D6B1F0 Offset: 0x1D6B2F1 VA: 0x1D6B1F0
	public bool get_Finished() { }

	// RVA: 0x1D6B200 Offset: 0x1D6B301 VA: 0x1D6B200
	public void Simplify(float percent) { }

	// RVA: 0x1D6B3A0 Offset: 0x1D6B4A1 VA: 0x1D6B3A0
	private void Awake() { }

	// RVA: 0x1D6B460 Offset: 0x1D6B561 VA: 0x1D6B460
	private void AddMaterials(GameObject theGameObject, Dictionary<GameObject, Material[]> dicMaterials) { }

	// RVA: 0x1D6B620 Offset: 0x1D6B721 VA: 0x1D6B620
	private void Progress(string strTitle, string strMessage, float fT) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A95E0 Offset: 0x1A96E1 VA: 0x1A95E0
	// RVA: 0x1D6B310 Offset: 0x1D6B411 VA: 0x1D6B310
	private IEnumerator ComputeMeshWithVertices(float fAmount) { }

	// RVA: 0x1D6B740 Offset: 0x1D6B841 VA: 0x1D6B740
	public void .ctor() { }
}

