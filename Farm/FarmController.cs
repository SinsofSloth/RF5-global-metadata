public class FarmController : MonoBehaviour // TypeDefIndex: 10329
{
	// Fields
	[SerializeField] // RVA: 0x1813E0 Offset: 0x1814E1 VA: 0x1813E0
	private float _XCount; // 0x18
	[SerializeField] // RVA: 0x1813F0 Offset: 0x1814F1 VA: 0x1813F0
	private float _ZCount; // 0x1C
	[SerializeField] // RVA: 0x181400 Offset: 0x181501 VA: 0x181400
	private FarmManager.FARM_ID FarmId; // 0x20
	[SerializeField] // RVA: 0x181410 Offset: 0x181511 VA: 0x181410
	private GameObject FarmEdge; // 0x28
	private List<CellController> _cellControllers; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x181420 Offset: 0x181521 VA: 0x181420
	private bool <NeedReloadOnEnable>k__BackingField; // 0x38
	private GameObject CultivateSetPrefab; // 0x40
	private List<Texture> LoadTextureIds; // 0x48

	// Properties
	public FarmManager.FARM_ID ThisFarmId { get; }
	public float XCount { get; set; }
	public float ZCount { get; set; }
	public List<CellController> CellControllers { get; }
	public bool NeedReloadOnEnable { get; set; }

	// Methods

	// RVA: 0x1F89E30 Offset: 0x1F89F31 VA: 0x1F89E30
	public FarmManager.FARM_ID get_ThisFarmId() { }

	// RVA: 0x1F89E40 Offset: 0x1F89F41 VA: 0x1F89E40
	public float get_XCount() { }

	// RVA: 0x1F89E50 Offset: 0x1F89F51 VA: 0x1F89E50
	public void set_XCount(float value) { }

	// RVA: 0x1F89E60 Offset: 0x1F89F61 VA: 0x1F89E60
	public float get_ZCount() { }

	// RVA: 0x1F89E70 Offset: 0x1F89F71 VA: 0x1F89E70
	public void set_ZCount(float value) { }

	// RVA: 0x1F89E80 Offset: 0x1F89F81 VA: 0x1F89E80
	public List<CellController> get_CellControllers() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE780 Offset: 0x1AE881 VA: 0x1AE780
	// RVA: 0x1F89E90 Offset: 0x1F89F91 VA: 0x1F89E90
	public bool get_NeedReloadOnEnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE790 Offset: 0x1AE891 VA: 0x1AE790
	// RVA: 0x1F89EA0 Offset: 0x1F89FA1 VA: 0x1F89EA0
	public void set_NeedReloadOnEnable(bool value) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE7A0 Offset: 0x1AE8A1 VA: 0x1AE7A0
	// RVA: 0x1F89EB0 Offset: 0x1F89FB1 VA: 0x1F89EB0
	public IEnumerator CreateFarmCells(UnityAction callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE810 Offset: 0x1AE911 VA: 0x1AE810
	// RVA: 0x1F89F80 Offset: 0x1F8A081 VA: 0x1F89F80
	private IEnumerator LoadTexture(string texName, UnityAction<Texture> callback) { }

	// RVA: 0x1F8A060 Offset: 0x1F8A161 VA: 0x1F8A060
	private void RemoveTextures() { }

	// RVA: 0x1F8A1B0 Offset: 0x1F8A2B1 VA: 0x1F8A1B0
	public CellController GetCellController(Vector3Int cellSetId, int cellId) { }

	// RVA: 0x1F8A2A0 Offset: 0x1F8A3A1 VA: 0x1F8A2A0
	public CellSetController GetCellSetController(Vector3Int cellSetId) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE880 Offset: 0x1AE981 VA: 0x1AE880
	// RVA: 0x1F8A390 Offset: 0x1F8A491 VA: 0x1F8A390
	private IEnumerator Start() { }

	// RVA: 0x1F8A440 Offset: 0x1F8A541 VA: 0x1F8A440
	private void OnEnable() { }

	// RVA: 0x1F8A980 Offset: 0x1F8AA81 VA: 0x1F8A980
	private void OnDestroy() { }

	// RVA: 0x1F8AA80 Offset: 0x1F8AB81 VA: 0x1F8AA80
	public void .ctor() { }
}

