public class LODPreview : MonoBehaviour // TypeDefIndex: 9002
{
	// Fields
	public LODPreview.ShowcaseObject[] ShowcaseObjects; // 0x18
	public Material WireframeMaterial; // 0x20
	public float MouseSensitvity; // 0x28
	public float MouseReleaseSpeed; // 0x2C
	private Dictionary<GameObject, Material[]> m_objectMaterials; // 0x30
	private AutomaticLOD m_selectedAutomaticLOD; // 0x38
	private int m_nSelectedIndex; // 0x40
	private bool m_bWireframe; // 0x44
	private float m_fRotationSpeed; // 0x48
	private float m_fLastMouseX; // 0x4C
	private Mesh m_newMesh; // 0x50
	private int m_nLastProgress; // 0x58
	private string m_strLastTitle; // 0x60
	private string m_strLastMessage; // 0x68
	private float m_fVertexAmount; // 0x70

	// Methods

	// RVA: 0x217BB50 Offset: 0x217BC51 VA: 0x217BB50
	private void Start() { }

	// RVA: 0x217BEE0 Offset: 0x217BFE1 VA: 0x217BEE0
	private void Progress(string strTitle, string strMessage, float fT) { }

	// RVA: 0x217BFD0 Offset: 0x217C0D1 VA: 0x217BFD0
	private void Update() { }

	// RVA: 0x217C510 Offset: 0x217C611 VA: 0x217C510
	private void OnGUI() { }

	// RVA: 0x217BCD0 Offset: 0x217BDD1 VA: 0x217BCD0
	private void SetActiveObject(int index) { }

	// RVA: 0x217D4A0 Offset: 0x217D5A1 VA: 0x217D4A0
	private void AddMaterials(GameObject theGameObject, Dictionary<GameObject, Material[]> dicMaterials) { }

	// RVA: 0x217C230 Offset: 0x217C331 VA: 0x217C230
	private void SetWireframe(bool bEnabled) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A9500 Offset: 0x1A9601 VA: 0x1A9500
	// RVA: 0x217D410 Offset: 0x217D511 VA: 0x217D410
	private IEnumerator ComputeLODWithVertices(float fAmount) { }

	// RVA: 0x217D670 Offset: 0x217D771 VA: 0x217D670
	public void .ctor() { }
}

