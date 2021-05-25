public class PlantStatus : MonoBehaviour // TypeDefIndex: 10374
{
	// Fields
	private bool initData; // 0x18
	private bool loading; // 0x19
	[CompilerGeneratedAttribute] // RVA: 0x1815A0 Offset: 0x1816A1 VA: 0x1815A0
	private bool <IsPlanted>k__BackingField; // 0x1A
	[CompilerGeneratedAttribute] // RVA: 0x1815B0 Offset: 0x1816B1 VA: 0x1815B0
	private int <PlantStatusLevel>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x1815C0 Offset: 0x1816C1 VA: 0x1815C0
	private int <PlantStatusLevelMax>k__BackingField; // 0x20
	private int _nowStatus; // 0x24
	private float _size; // 0x28
	private bool _updateSize; // 0x2C
	private bool _isWither; // 0x2D
	private bool _updateWither; // 0x2E
	private int _treeFruitsCount; // 0x30
	private bool _updateTreeFruitsCount; // 0x34
	private List<GameObject> _plantDataObjList; // 0x38
	private List<Prefab> _loadPrefabIds; // 0x40
	private GameObject _fruitObjPrefab; // 0x48
	private Prefab _fruitPrefabId; // 0x50
	private GameObject[] _fruitSockets; // 0x58
	private IEnumerator _createObjectCoroutine; // 0x60

	// Properties
	public bool IsPlanted { get; set; }
	public int PlantStatusLevel { get; set; }
	public int PlantStatusLevelMax { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AECC0 Offset: 0x1AEDC1 VA: 0x1AECC0
	// RVA: 0x20271A0 Offset: 0x20272A1 VA: 0x20271A0
	public bool get_IsPlanted() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AECD0 Offset: 0x1AEDD1 VA: 0x1AECD0
	// RVA: 0x20271B0 Offset: 0x20272B1 VA: 0x20271B0
	public void set_IsPlanted(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AECE0 Offset: 0x1AEDE1 VA: 0x1AECE0
	// RVA: 0x20271C0 Offset: 0x20272C1 VA: 0x20271C0
	public int get_PlantStatusLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AECF0 Offset: 0x1AEDF1 VA: 0x1AECF0
	// RVA: 0x20271D0 Offset: 0x20272D1 VA: 0x20271D0
	public void set_PlantStatusLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AED00 Offset: 0x1AEE01 VA: 0x1AED00
	// RVA: 0x20271E0 Offset: 0x20272E1 VA: 0x20271E0
	public int get_PlantStatusLevelMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AED10 Offset: 0x1AEE11 VA: 0x1AED10
	// RVA: 0x20271F0 Offset: 0x20272F1 VA: 0x20271F0
	public void set_PlantStatusLevelMax(int value) { }

	// RVA: 0x2027200 Offset: 0x2027301 VA: 0x2027200
	private void Start() { }

	// RVA: 0x20272C0 Offset: 0x20273C1 VA: 0x20272C0
	private void OnDestroy() { }

	// RVA: 0x2027460 Offset: 0x2027561 VA: 0x2027460
	private void Update() { }

	// RVA: 0x2027EE0 Offset: 0x2027FE1 VA: 0x2027EE0
	private void OnEnable() { }

	// RVA: 0x20274A0 Offset: 0x20275A1 VA: 0x20274A0
	private void UpdateObj() { }

	// RVA: 0x2027F00 Offset: 0x2028001 VA: 0x2027F00
	public void SetPlantStatusLevel(int level) { }

	// RVA: 0x2027F50 Offset: 0x2028051 VA: 0x2027F50
	public void StatusUpdate() { }

	// RVA: 0x2027F70 Offset: 0x2028071 VA: 0x2027F70
	public bool IsStatusMax() { }

	// RVA: 0x2027220 Offset: 0x2027321 VA: 0x2027220
	public void StatusReset(int level = -1) { }

	// RVA: 0x2024D40 Offset: 0x2024E41 VA: 0x2024D40
	public void ChangeSize(bool isLarge) { }

	// RVA: 0x2028050 Offset: 0x2028151 VA: 0x2028050
	public void ChangeSize(float size) { }

	// RVA: 0x2027960 Offset: 0x2027A61 VA: 0x2027960
	private void UpdateSize() { }

	// RVA: 0x20280A0 Offset: 0x20281A1 VA: 0x20280A0
	public void SetPlantData(CropDataTable cropData, UnityAction callback, bool isUpdate = True, bool isReset = True) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AED20 Offset: 0x1AEE21 VA: 0x1AED20
	// RVA: 0x2028430 Offset: 0x2028531 VA: 0x2028430
	private IEnumerator CreateCropObjectCoroutine(CropDataTable cropData, List<string> prefabNames, UnityAction callback) { }

	// RVA: 0x2028540 Offset: 0x2028641 VA: 0x2028540
	public void ChangeWither(bool isWither) { }

	// RVA: 0x2027AD0 Offset: 0x2027BD1 VA: 0x2027AD0
	private void UpdateWither() { }

	// RVA: 0x2028560 Offset: 0x2028661 VA: 0x2028560
	public void ChangeTreeFruitsCount(int count) { }

	// RVA: 0x2027C60 Offset: 0x2027D61 VA: 0x2027C60
	private void UpdateTreeFruitsCount() { }

	// RVA: 0x2028060 Offset: 0x2028161 VA: 0x2028060
	private bool CanUpdateDetail() { }

	// RVA: 0x2027F80 Offset: 0x2028081 VA: 0x2027F80
	private static void removeChildObjectsAll(Transform t) { }

	// RVA: 0x20272D0 Offset: 0x20273D1 VA: 0x20272D0
	private void removePrefabs() { }

	// RVA: 0x2028570 Offset: 0x2028671 VA: 0x2028570
	public void .ctor() { }
}

