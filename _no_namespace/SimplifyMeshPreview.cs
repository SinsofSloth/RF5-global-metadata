public class SimplifyMeshPreview : MonoBehaviour // TypeDefIndex: 9044
{
	// Fields
	public SimplifyMeshPreview.ShowcaseObject[] ShowcaseObjects; // 0x18
	public Material WireframeMaterial; // 0x20
	public float MouseSensitvity; // 0x28
	public float MouseReleaseSpeed; // 0x2C
	private Dictionary<GameObject, Material[]> m_objectMaterials; // 0x30
	private MeshSimplify m_selectedMeshSimplify; // 0x38
	private int m_nSelectedIndex; // 0x40
	private bool m_bWireframe; // 0x44
	private float m_fRotationSpeed; // 0x48
	private float m_fLastMouseX; // 0x4C
	private Mesh m_newMesh; // 0x50
	private int m_nLastProgress; // 0x58
	private string m_strLastTitle; // 0x60
	private string m_strLastMessage; // 0x68
	private float m_fVertexAmount; // 0x70
	private bool m_bGUIEnabled; // 0x74

	// Methods

	// RVA: 0x1C50EB0 Offset: 0x1C50FB1 VA: 0x1C50EB0
	private void Start() { }

	// RVA: 0x1C51230 Offset: 0x1C51331 VA: 0x1C51230
	private void Progress(string strTitle, string strMessage, float fT) { }

	// RVA: 0x1C51320 Offset: 0x1C51421 VA: 0x1C51320
	private void Update() { }

	// RVA: 0x1C518A0 Offset: 0x1C519A1 VA: 0x1C518A0
	private void OnGUI() { }

	// RVA: 0x1C51030 Offset: 0x1C51131 VA: 0x1C51030
	private void SetActiveObject(int index) { }

	// RVA: 0x1C52870 Offset: 0x1C52971 VA: 0x1C52870
	private void AddMaterials(GameObject theGameObject, Dictionary<GameObject, Material[]> dicMaterials) { }

	// RVA: 0x1C515C0 Offset: 0x1C516C1 VA: 0x1C515C0
	private void SetWireframe(bool bEnabled) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A9570 Offset: 0x1A9671 VA: 0x1A9570
	// RVA: 0x1C527E0 Offset: 0x1C528E1 VA: 0x1C527E0
	private IEnumerator ComputeMeshWithVertices(float fAmount) { }

	// RVA: 0x1C52A40 Offset: 0x1C52B41 VA: 0x1C52A40
	public void .ctor() { }
}

