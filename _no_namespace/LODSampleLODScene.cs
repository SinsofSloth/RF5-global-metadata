public class LODSampleLODScene : MonoBehaviour // TypeDefIndex: 9005
{
	// Fields
	public LODSampleLODScene.SceneCamera[] SceneCameras; // 0x18
	public Material WireframeMaterial; // 0x20
	private Dictionary<GameObject, Material[]> m_objectMaterials; // 0x28
	private LODSampleLODScene.SceneCamera m_selectedCamera; // 0x30
	private bool m_bWireframe; // 0x38
	private List<AutomaticLOD> m_sceneLODObjects; // 0x40
	private int m_nMaxLODLevels; // 0x48
	private float m_fCurrentDistanceSlider; // 0x4C
	private int m_nCamMode; // 0x50

	// Methods

	// RVA: 0x217E160 Offset: 0x217E261 VA: 0x217E160
	private void Start() { }

	// RVA: 0x217E6C0 Offset: 0x217E7C1 VA: 0x217E6C0
	private void Update() { }

	// RVA: 0x217EC50 Offset: 0x217ED51 VA: 0x217EC50
	private void OnGUI() { }

	// RVA: 0x217E580 Offset: 0x217E681 VA: 0x217E580
	private void SetActiveCamera(int index) { }

	// RVA: 0x217E7F0 Offset: 0x217E8F1 VA: 0x217E7F0
	private void UpdateCamera(float fPos) { }

	// RVA: 0x217E3B0 Offset: 0x217E4B1 VA: 0x217E3B0
	private void AddMaterials(GameObject theGameObject, Dictionary<GameObject, Material[]> dicMaterials) { }

	// RVA: 0x217E970 Offset: 0x217EA71 VA: 0x217E970
	private void SetWireframe(bool bEnabled) { }

	// RVA: 0x217FAD0 Offset: 0x217FBD1 VA: 0x217FAD0
	public void .ctor() { }
}

