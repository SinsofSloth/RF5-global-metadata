[HelpURLAttribute] // RVA: 0x147AD0 Offset: 0x147BD1 VA: 0x147AD0
public class Streamer : MonoBehaviour // TypeDefIndex: 9087
{
	// Fields
	[TooltipAttribute] // RVA: 0x1769E0 Offset: 0x176AE1 VA: 0x1769E0
	public bool streamerActive; // 0x18
	public static string STREAMERTAG; // 0x0
	[HeaderAttribute] // RVA: 0x176A20 Offset: 0x176B21 VA: 0x176A20
	[TooltipAttribute] // RVA: 0x176A20 Offset: 0x176B21 VA: 0x176A20
	public SceneCollection sceneCollection; // 0x20
	public SceneSplit[] splits; // 0x28
	[HeaderAttribute] // RVA: 0x176A80 Offset: 0x176B81 VA: 0x176A80
	[TooltipAttribute] // RVA: 0x176A80 Offset: 0x176B81 VA: 0x176A80
	public Vector3 loadingRange; // 0x30
	[TooltipAttribute] // RVA: 0x176AE0 Offset: 0x176BE1 VA: 0x176AE0
	public bool useLoadingRangeMin; // 0x3C
	[TooltipAttribute] // RVA: 0x176B20 Offset: 0x176C21 VA: 0x176B20
	public Vector3 loadingRangeMin; // 0x40
	[TooltipAttribute] // RVA: 0x176B60 Offset: 0x176C61 VA: 0x176B60
	public Vector3 deloadingRange; // 0x4C
	[HeaderAttribute] // RVA: 0x176BA0 Offset: 0x176CA1 VA: 0x176BA0
	[TooltipAttribute] // RVA: 0x176BA0 Offset: 0x176CA1 VA: 0x176BA0
	public float positionCheckTime; // 0x58
	[TooltipAttribute] // RVA: 0x176C00 Offset: 0x176D01 VA: 0x176C00
	public float destroyTileDelay; // 0x5C
	[TooltipAttribute] // RVA: 0x176C40 Offset: 0x176D41 VA: 0x176C40
	public int maxParallelSceneLoading; // 0x60
	[TooltipAttribute] // RVA: 0x176C80 Offset: 0x176D81 VA: 0x176C80
	public int sceneLoadWaitFrames; // 0x64
	[SpaceAttribute] // RVA: 0x176CC0 Offset: 0x176DC1 VA: 0x176CC0
	[TooltipAttribute] // RVA: 0x176CC0 Offset: 0x176DC1 VA: 0x176CC0
	public TerrainNeighbours terrainNeighbours; // 0x68
	[SpaceAttribute] // RVA: 0x176D10 Offset: 0x176E11 VA: 0x176D10
	[TooltipAttribute] // RVA: 0x176D10 Offset: 0x176E11 VA: 0x176D10
	public bool looping; // 0x70
	[SpaceAttribute] // RVA: 0x176D60 Offset: 0x176E61 VA: 0x176D60
	[HeaderAttribute] // RVA: 0x176D60 Offset: 0x176E61 VA: 0x176D60
	[TooltipAttribute] // RVA: 0x176D60 Offset: 0x176E61 VA: 0x176D60
	public Transform player; // 0x78
	[TooltipAttribute] // RVA: 0x176DE0 Offset: 0x176EE1 VA: 0x176DE0
	public bool spawnedPlayer; // 0x80
	[HideInInspector] // RVA: 0x176E20 Offset: 0x176F21 VA: 0x176E20
	public string playerTag; // 0x88
	[HideInInspector] // RVA: 0x176E30 Offset: 0x176F31 VA: 0x176E30
	public bool showLoadingScreen; // 0x90
	[HideInInspector] // RVA: 0x176E40 Offset: 0x176F41 VA: 0x176E40
	public UILoadingStreamer loadingStreamer; // 0x98
	[HideInInspector] // RVA: 0x176E50 Offset: 0x176F51 VA: 0x176E50
	public bool initialized; // 0xA0
	[HideInInspector] // RVA: 0x176E60 Offset: 0x176F61 VA: 0x176E60
	public int tilesToLoad; // 0xA4
	[HideInInspector] // RVA: 0x176E70 Offset: 0x176F71 VA: 0x176E70
	public int tilesLoaded; // 0xA8
	[HideInInspector] // RVA: 0x176E80 Offset: 0x176F81 VA: 0x176E80
	public WorldMover worldMover; // 0xB0
	[HideInInspector] // RVA: 0x176E90 Offset: 0x176F91 VA: 0x176E90
	public Vector3 currentMove; // 0xB8
	protected int xPos; // 0xC4
	protected int yPos; // 0xC8
	protected int zPos; // 0xCC
	public Dictionary<int[], SceneSplit> scenesArray; // 0xD0
	[HideInInspector] // RVA: 0x176EA0 Offset: 0x176FA1 VA: 0x176EA0
	public List<SceneSplit> loadedScenes; // 0xD8
	protected int currentlySceneLoading; // 0xE0
	protected List<SceneSplit> scenesToLoad; // 0xE8
	protected int sceneLoadFrameNext; // 0xF0
	protected bool sceneLoadFramesNextWaited; // 0xF4
	protected int xLimity; // 0xF8
	protected int xLimitx; // 0xFC
	protected int xRange; // 0x100
	protected int yLimity; // 0x104
	protected int yLimitx; // 0x108
	protected int yRange; // 0x10C
	protected int zLimity; // 0x110
	protected int zLimitx; // 0x114
	protected int zRange; // 0x118
	private static bool canUnload; // 0x8
	private static float waitTillNextUnload; // 0xC
	private static bool unloadNext; // 0x10
	protected Coroutine PositionCheckerCoroutine; // 0x120
	private static Vector3 WorkVector3; // 0x14
	private static int[] WorkPosInt; // 0x20
	private static char[] SplitChar; // 0x28

	// Properties
	public float LoadingProgress { get; }

	// Methods

	// RVA: 0x224DEA0 Offset: 0x224DFA1 VA: 0x224DEA0
	public float get_LoadingProgress() { }

	// RVA: 0x224DF40 Offset: 0x224E041 VA: 0x224DF40
	private static void SetWorkPosInt(int x, int y, int z) { }

	// RVA: 0x224E020 Offset: 0x224E121 VA: 0x224E020 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x224E400 Offset: 0x224E501 VA: 0x224E400
	private void Start() { }

	// RVA: 0x224E5A0 Offset: 0x224E6A1 VA: 0x224E5A0
	private void OnEnable() { }

	// RVA: 0x224E6C0 Offset: 0x224E7C1 VA: 0x224E6C0
	private void OnDisable() { }

	// RVA: 0x224E700 Offset: 0x224E801 VA: 0x224E700
	private int mod(int x, int m) { }

	// RVA: 0x224E720 Offset: 0x224E821 VA: 0x224E720 Slot: 5
	public virtual void AddSceneGO(string sceneName, GameObject sceneGO) { }

	// RVA: 0x224EC50 Offset: 0x224ED51 VA: 0x224EC50
	private void Update() { }

	// RVA: 0x224EC60 Offset: 0x224ED61 VA: 0x224EC60 Slot: 6
	protected virtual void LoadLevelAsyncManage() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A9650 Offset: 0x1A9751 VA: 0x1A9650
	// RVA: 0x224E520 Offset: 0x224E621 VA: 0x224E520
	private IEnumerator PositionChecker() { }

	// RVA: 0x224EE40 Offset: 0x224EF41 VA: 0x224EE40
	public void CheckPositionTiles(bool isForce = False) { }

	// RVA: 0x224F0E0 Offset: 0x224F1E1 VA: 0x224F0E0 Slot: 7
	protected virtual void SceneLoading() { }

	// RVA: 0x224FCC0 Offset: 0x224FDC1 VA: 0x224FCC0 Slot: 8
	public virtual void SceneUnloading() { }

	// RVA: 0x2250540 Offset: 0x2250641 VA: 0x2250540 Slot: 9
	public virtual void UnloadAllScenes() { }

	// RVA: 0x2250A70 Offset: 0x2250B71 VA: 0x2250A70
	public static void UnloadAssets(Streamer streamer) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A96C0 Offset: 0x1A97C1 VA: 0x1A96C0
	// RVA: 0x2250BD0 Offset: 0x2250CD1 VA: 0x2250BD0
	public IEnumerator UnloadAssetsWait() { }

	// RVA: 0x224E200 Offset: 0x224E301 VA: 0x224E200
	private void PrepareScenesArray() { }

	// RVA: 0x224E9C0 Offset: 0x224EAC1 VA: 0x224E9C0
	public static void SceneNameToPos(SceneCollection sceneCollection, string sceneName, out int posX, out int posY, out int posZ) { }

	// RVA: 0x2250C60 Offset: 0x2250D61 VA: 0x2250C60
	private void OnDrawGizmosSelected() { }

	// RVA: 0x2251010 Offset: 0x2251111 VA: 0x2251010
	public void .ctor() { }

	// RVA: 0x22511E0 Offset: 0x22512E1 VA: 0x22511E0
	private static void .cctor() { }
}

