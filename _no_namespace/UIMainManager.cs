public class UIMainManager : SingletonMonoBehaviour<UIMainManager> // TypeDefIndex: 8921
{
	// Fields
	private readonly Prefab[] LoadIds; // 0x18
	private readonly int[] PreloadIds; // 0x20
	private readonly bool[] doActiveOnStart; // 0x28
	private List<GameObject> createdObjectList; // 0x30
	private List<GameObject> preloadObjectList; // 0x38
	private Dictionary<UIMainManager.AttachId, int> AttachDic; // 0x40
	private Dictionary<int, int> PreloadDic; // 0x48
	private List<GameObject> attachedObjectList; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x174B80 Offset: 0x174C81 VA: 0x174B80
	private SpriteAtlas <FaceIconAtlas>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x174B90 Offset: 0x174C91 VA: 0x174B90
	private SpriteAtlas <MonsterFaceIconAtlas>k__BackingField; // 0x60
	private int loadingNo; // 0x68
	public UIItemParameterText ItemParameterText; // 0x70
	public UIModelLoader _UIModelLoader; // 0x78
	private GameObject preloadObject; // 0x80

	// Properties
	public SpriteAtlas FaceIconAtlas { get; set; }
	public SpriteAtlas MonsterFaceIconAtlas { get; set; }
	public bool isLoadCompleted { get; }
	public UIModelLoader UIModelLoader { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A91E0 Offset: 0x1A92E1 VA: 0x1A91E0
	// RVA: 0x1EDDE10 Offset: 0x1EDDF11 VA: 0x1EDDE10
	public SpriteAtlas get_FaceIconAtlas() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A91F0 Offset: 0x1A92F1 VA: 0x1A91F0
	// RVA: 0x1EDDE20 Offset: 0x1EDDF21 VA: 0x1EDDE20
	private void set_FaceIconAtlas(SpriteAtlas value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9200 Offset: 0x1A9301 VA: 0x1A9200
	// RVA: 0x1EDDE30 Offset: 0x1EDDF31 VA: 0x1EDDE30
	public SpriteAtlas get_MonsterFaceIconAtlas() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9210 Offset: 0x1A9311 VA: 0x1A9210
	// RVA: 0x1EDDE40 Offset: 0x1EDDF41 VA: 0x1EDDE40
	private void set_MonsterFaceIconAtlas(SpriteAtlas value) { }

	// RVA: 0x1EDDE50 Offset: 0x1EDDF51 VA: 0x1EDDE50
	public bool get_isLoadCompleted() { }

	// RVA: 0x1EDDF30 Offset: 0x1EDE031 VA: 0x1EDDF30
	public UIModelLoader get_UIModelLoader() { }

	// RVA: 0x1EDDFE0 Offset: 0x1EDE0E1 VA: 0x1EDDFE0
	private void OnDestroy() { }

	// RVA: 0x1EDE170 Offset: 0x1EDE271 VA: 0x1EDE170
	private void Start() { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>(UIMainManager.AttachId id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2264FE0 Offset: 0x22650E1 VA: 0x2264FE0
	|-UIMainManager.GetComponent<object>
	|-UIMainManager.GetComponent<UIModelLoader>
	|-UIMainManager.GetComponent<Camera>
	*/

	// RVA: 0x1EDE2F0 Offset: 0x1EDE3F1 VA: 0x1EDE2F0
	public GameObject GetComponent(UIMainManager.AttachId id) { }

	// RVA: -1 Offset: -1
	public T GetPreload<T>(Prefab id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2265130 Offset: 0x2265231 VA: 0x2265130
	|-UIMainManager.GetPreload<DamageText>
	|-UIMainManager.GetPreload<object>
	*/

	// RVA: -1 Offset: -1
	public T GetPreload<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2265150 Offset: 0x2265251 VA: 0x2265150
	|-UIMainManager.GetPreload<object>
	*/

	// RVA: 0x1EDC310 Offset: 0x1EDC411 VA: 0x1EDC310
	public GameObject GetPreload(Prefab id) { }

	// RVA: 0x1EDE410 Offset: 0x1EDE511 VA: 0x1EDE410
	public GameObject GetPreload(int id) { }

	// RVA: 0x1EDE530 Offset: 0x1EDE631 VA: 0x1EDE530
	private void AddObject(AssetHandle<GameObject> handle) { }

	// RVA: 0x1EDE820 Offset: 0x1EDE921 VA: 0x1EDE820
	private void StartPreload() { }

	// RVA: 0x1EDEB20 Offset: 0x1EDEC21 VA: 0x1EDEB20
	private void SetPreload(AssetHandle<GameObject> handle) { }

	// RVA: 0x1EDEA20 Offset: 0x1EDEB21 VA: 0x1EDEA20
	public void LoadResourceOnGameStart() { }

	// RVA: 0x1EDED40 Offset: 0x1EDEE41 VA: 0x1EDED40
	private void LastInit() { }

	// RVA: 0x1EDEE20 Offset: 0x1EDEF21 VA: 0x1EDEE20
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9220 Offset: 0x1A9321 VA: 0x1A9220
	// RVA: 0x1EDEFF0 Offset: 0x1EDF0F1 VA: 0x1EDEFF0
	private void <LoadResourceOnGameStart>b__36_0(AssetHandle<SpriteAtlas> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9230 Offset: 0x1A9331 VA: 0x1A9230
	// RVA: 0x1EDF070 Offset: 0x1EDF171 VA: 0x1EDF070
	private void <LoadResourceOnGameStart>b__36_1(AssetHandle<SpriteAtlas> handle) { }
}

