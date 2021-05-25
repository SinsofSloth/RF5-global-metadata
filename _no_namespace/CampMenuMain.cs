public class CampMenuMain : MonoBehaviour // TypeDefIndex: 8651
{
	// Fields
	[SerializeField] // RVA: 0x171820 Offset: 0x171921 VA: 0x171820
	private CursorLinkConnector CenterMenuObj; // 0x18
	[SerializeField] // RVA: 0x171830 Offset: 0x171931 VA: 0x171830
	private CampPage firstPage; // 0x20
	[SerializeField] // RVA: 0x171840 Offset: 0x171941 VA: 0x171840
	private CampPageSwitcher campPageSwitcher; // 0x28
	[SerializeField] // RVA: 0x171850 Offset: 0x171951 VA: 0x171850
	private CursorController MyCursor; // 0x30
	[SerializeField] // RVA: 0x171860 Offset: 0x171961 VA: 0x171860
	private Color CampModelAmbientColor; // 0x38
	public GameObject SubMenuObj; // 0x48
	private bool MenuOpened; // 0x50
	public bool isOpendModelView; // 0x51
	public bool cursorUsedOpenModelView; // 0x52
	[SerializeField] // RVA: 0x171870 Offset: 0x171971 VA: 0x171870
	private GameObject ModelViewerMenu; // 0x58
	public Transform SubMenuParent; // 0x60
	private ButtonGuideId idOnOpenModelView; // 0x68
	public bool CanSaveState; // 0x6C
	public Color tempAmbientLight; // 0x70

	// Properties
	private Camera MyCamera { get; }
	private UIModelLoader UIEquipModel { get; }

	// Methods

	// RVA: 0x1D38190 Offset: 0x1D38291 VA: 0x1D38190
	private Camera get_MyCamera() { }

	// RVA: 0x1D381F0 Offset: 0x1D382F1 VA: 0x1D381F0
	private UIModelLoader get_UIEquipModel() { }

	// RVA: 0x1D38250 Offset: 0x1D38351 VA: 0x1D38250
	public void OpenModelView(ActorID actor_id) { }

	// RVA: 0x1D38350 Offset: 0x1D38451 VA: 0x1D38350
	public void OpenModelView(MonsterDataID monsterDataID) { }

	// RVA: 0x1D38450 Offset: 0x1D38551 VA: 0x1D38450
	public void ResetModelEquip() { }

	// RVA: 0x1D38530 Offset: 0x1D38631 VA: 0x1D38530
	public void CloseModelView() { }

	// RVA: 0x1D38700 Offset: 0x1D38801 VA: 0x1D38700
	private void Start() { }

	// RVA: 0x1D38780 Offset: 0x1D38881 VA: 0x1D38780
	private void Update() { }

	// RVA: 0x1D38A80 Offset: 0x1D38B81 VA: 0x1D38A80
	private void StartCamp() { }

	// RVA: 0x1D39110 Offset: 0x1D39211 VA: 0x1D39110
	public void StartCampOnSave() { }

	// RVA: 0x1D38D30 Offset: 0x1D38E31 VA: 0x1D38D30
	public void CloseCamp() { }

	// RVA: 0x1D391C0 Offset: 0x1D392C1 VA: 0x1D391C0
	public void .ctor() { }
}

