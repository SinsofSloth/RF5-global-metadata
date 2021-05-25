public class TeleportAreaManager : SingletonMonoBehaviour<TeleportAreaManager> // TypeDefIndex: 7498
{
	// Fields
	private const float SampleNavMeshMaxDistance = 100;
	private const float ReSampleNavMeshDistance = 1;
	[SerializeField] // RVA: 0x166BB0 Offset: 0x166CB1 VA: 0x166BB0
	private string _SceneName; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x166BC0 Offset: 0x166CC1 VA: 0x166BC0
	private FieldPlaceId <FieldPlaceId>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x166BD0 Offset: 0x166CD1 VA: 0x166BD0
	private FieldPlaceId <FieldMapAreaPlaceId>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x166BE0 Offset: 0x166CE1 VA: 0x166BE0
	private FieldSceneId <FieldSceneId>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x166BF0 Offset: 0x166CF1 VA: 0x166BF0
	private Stack<FieldSceneId> <FieldSceneIdStack>k__BackingField; // 0x30
	[SerializeField] // RVA: 0x166C00 Offset: 0x166D01 VA: 0x166C00
	private string _PrevSceneName; // 0x38
	private Stack<string> _SceneNameStack; // 0x40
	[SerializeField] // RVA: 0x166C10 Offset: 0x166D11 VA: 0x166C10
	private TeleportPositionDataObject[] _TeleportPositionDataObjects; // 0x48
	public Dictionary<string, TeleportPositionDataObject> TeleportPositionDataTable; // 0x50
	private FieldTeleportDataTableArray FieldTeleportDataTableArray; // 0x58
	[SerializeField] // RVA: 0x166C20 Offset: 0x166D21 VA: 0x166C20
	private FieldSceneData _SceneDataTable; // 0x60
	[SerializeField] // RVA: 0x166C30 Offset: 0x166D31 VA: 0x166C30
	private PlayerTeleport _PlayerTeleport; // 0x68
	[SerializeField] // RVA: 0x166C40 Offset: 0x166D41 VA: 0x166C40
	private PlayerMover _PlayerMover; // 0x70
	[SerializeField] // RVA: 0x166C50 Offset: 0x166D51 VA: 0x166C50
	private Streamer[] _Streamers; // 0x78
	private Transform StreamerTargetTransform; // 0x80
	public string DefaultFieldSceneName; // 0x88
	[SerializeField] // RVA: 0x166C60 Offset: 0x166D61 VA: 0x166C60
	private float _DetectGroundRayDistance; // 0x90
	protected const float kBackstepDistance = 0.05;
	private const string MapNameBeginIdString = "MAPNAME_SCENE_FieldMap";
	private static int MapNameBeginId; // 0x0
	private const int WorldStreamerMoveCheckDist = 2304;
	[CompilerGeneratedAttribute] // RVA: 0x166C70 Offset: 0x166D71 VA: 0x166C70
	private LayerMask <GroundLayer>k__BackingField; // 0x94
	private HashSet<TeleportDragonRope> TeleportDragonRopesHashSet; // 0x98
	public UnityEvent OnBeginTeleport; // 0xA0
	public UnityEvent OnSceneLoadComplete; // 0xA8
	public UnityEvent OnSceneChangeComplete; // 0xB0
	public UnityEvent OnEndTeleport; // 0xB8
	public UnityEvent OnResetPlaceID; // 0xC0
	public HashSet<Func<IEnumerator>> OnSceneChangeLoadFuncs; // 0xC8
	private Action _OnLoadCompleteAction; // 0xD0
	public bool IsTeleportEnable; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x166C80 Offset: 0x166D81 VA: 0x166C80
	private bool <IsTeleporting>k__BackingField; // 0xD9
	[CompilerGeneratedAttribute] // RVA: 0x166C90 Offset: 0x166D91 VA: 0x166C90
	private bool <IsShortPlayLock>k__BackingField; // 0xDA
	[CompilerGeneratedAttribute] // RVA: 0x166CA0 Offset: 0x166DA1 VA: 0x166CA0
	private bool <IsTeleportEndFade>k__BackingField; // 0xDB
	[CompilerGeneratedAttribute] // RVA: 0x166CB0 Offset: 0x166DB1 VA: 0x166CB0
	private bool <IsCameraCulling>k__BackingField; // 0xDC
	private static FieldSceneData.Data loadSceneParam; // 0x8
	private const int PhysicCollidersCount = 16;
	private Collider[] PhysicColliders; // 0xE0
	private string loadSceneName; // 0xE8
	private string teleportName; // 0xF0
	private Vector3 TargetPosition; // 0xF8
	private Quaternion TargetQuaternion; // 0x104
	private bool PrevPause; // 0x114
	private bool PrevFade; // 0x115
	private RigidbodyInterpolation PrevInterpolation; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x166CC0 Offset: 0x166DC1 VA: 0x166CC0
	private bool <IsUseCpuBoost>k__BackingField; // 0x11C
	private bool IsCreatingNaviMeshSurfaces; // 0x11D
	public bool isCreatedNaviMeshSurfaces; // 0x11E
	public FieldRestrictionType prevFieldRestrictionType; // 0x120
	public FieldRestrictionType nowFieldRestrictionType; // 0x124
	private HashSet<MapFieldCollider> MapFieldColliders; // 0x128
	private GameObject worldStreamerTargetObject; // 0x130
	private bool isSetWorldStreamerTargetObject; // 0x138
	private int worldStreamerTargetIntensity; // 0x13C
	private bool isFirstCheckWorldStreamerTargetDist; // 0x140
	private Character TeleportCharacter; // 0x148
	private static readonly int[][] worldStreamerRangeNormals; // 0x50

	// Properties
	public string SceneName { get; set; }
	public FieldPlaceId FieldPlaceId { get; set; }
	public FieldPlaceId FieldMapAreaPlaceId { get; set; }
	public FieldSceneId FieldSceneId { get; set; }
	public bool IsPlayerInKyoten { get; }
	public Stack<FieldSceneId> FieldSceneIdStack { get; set; }
	public FieldSceneId CurrentFieldSceneIdStack { get; }
	public string PrevSceneName { get; set; }
	public Stack<string> SceneNameStack { get; }
	public string CurrentSceneNameStack { get; }
	public FieldSceneData.Data[] SceneDataTable { get; }
	public PlayerTeleport PlayerTeleport { get; }
	public PlayerMover PlayerMover { get; }
	public Streamer[] Streamers { get; set; }
	public static CharacterMoveSetting CharacterMoveSetting { get; }
	public LayerMask GroundLayer { get; set; }
	public bool IsTeleporting { get; set; }
	public bool IsShortPlayLock { get; set; }
	public bool IsTeleportEndFade { get; set; }
	public bool IsCameraCulling { get; set; }
	public static bool IsInDoor { get; }
	public static bool IsInTown { get; }
	public static bool IsInTownArea { get; }
	public static bool IsDungeon { get; }
	public static bool IsField { get; }
	public bool IsUseCpuBoost { get; set; }
	public static bool IsCreatedNaviMeshSurfaces { get; }
	public static bool IsStartFestivalResultScript { get; }

	// Methods

	// RVA: 0x1C78320 Offset: 0x1C78421 VA: 0x1C78320
	public string get_SceneName() { }

	// RVA: 0x1C78330 Offset: 0x1C78431 VA: 0x1C78330
	public void set_SceneName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1430 Offset: 0x1A1531 VA: 0x1A1430
	// RVA: 0x1C78340 Offset: 0x1C78441 VA: 0x1C78340
	public FieldPlaceId get_FieldPlaceId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1440 Offset: 0x1A1541 VA: 0x1A1440
	// RVA: 0x1C78350 Offset: 0x1C78451 VA: 0x1C78350
	private void set_FieldPlaceId(FieldPlaceId value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1450 Offset: 0x1A1551 VA: 0x1A1450
	// RVA: 0x1C78360 Offset: 0x1C78461 VA: 0x1C78360
	public FieldPlaceId get_FieldMapAreaPlaceId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1460 Offset: 0x1A1561 VA: 0x1A1460
	// RVA: 0x1C78370 Offset: 0x1C78471 VA: 0x1C78370
	private void set_FieldMapAreaPlaceId(FieldPlaceId value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1470 Offset: 0x1A1571 VA: 0x1A1470
	// RVA: 0x1C78380 Offset: 0x1C78481 VA: 0x1C78380
	public FieldSceneId get_FieldSceneId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1480 Offset: 0x1A1581 VA: 0x1A1480
	// RVA: 0x1C78390 Offset: 0x1C78491 VA: 0x1C78390
	private void set_FieldSceneId(FieldSceneId value) { }

	// RVA: 0x1C783A0 Offset: 0x1C784A1 VA: 0x1C783A0
	public bool get_IsPlayerInKyoten() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1490 Offset: 0x1A1591 VA: 0x1A1490
	// RVA: 0x1C783B0 Offset: 0x1C784B1 VA: 0x1C783B0
	public Stack<FieldSceneId> get_FieldSceneIdStack() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A14A0 Offset: 0x1A15A1 VA: 0x1A14A0
	// RVA: 0x1C783C0 Offset: 0x1C784C1 VA: 0x1C783C0
	private void set_FieldSceneIdStack(Stack<FieldSceneId> value) { }

	// RVA: 0x1C783D0 Offset: 0x1C784D1 VA: 0x1C783D0
	public FieldSceneId get_CurrentFieldSceneIdStack() { }

	// RVA: 0x1C78450 Offset: 0x1C78551 VA: 0x1C78450
	public string get_PrevSceneName() { }

	// RVA: 0x1C78460 Offset: 0x1C78561 VA: 0x1C78460
	public void set_PrevSceneName(string value) { }

	// RVA: 0x1C78470 Offset: 0x1C78571 VA: 0x1C78470
	public Stack<string> get_SceneNameStack() { }

	// RVA: 0x1C78480 Offset: 0x1C78581 VA: 0x1C78480
	public string get_CurrentSceneNameStack() { }

	// RVA: 0x1C78540 Offset: 0x1C78641 VA: 0x1C78540
	public FieldSceneData.Data[] get_SceneDataTable() { }

	// RVA: 0x1C78560 Offset: 0x1C78661 VA: 0x1C78560
	public PlayerTeleport get_PlayerTeleport() { }

	// RVA: 0x1C78570 Offset: 0x1C78671 VA: 0x1C78570
	public PlayerMover get_PlayerMover() { }

	// RVA: 0x1C78580 Offset: 0x1C78681 VA: 0x1C78580
	public Streamer[] get_Streamers() { }

	// RVA: 0x1C78590 Offset: 0x1C78691 VA: 0x1C78590
	private void set_Streamers(Streamer[] value) { }

	// RVA: 0x1C785A0 Offset: 0x1C786A1 VA: 0x1C785A0
	public static CharacterMoveSetting get_CharacterMoveSetting() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A14B0 Offset: 0x1A15B1 VA: 0x1A14B0
	// RVA: 0x1C78650 Offset: 0x1C78751 VA: 0x1C78650
	public LayerMask get_GroundLayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A14C0 Offset: 0x1A15C1 VA: 0x1A14C0
	// RVA: 0x1C78660 Offset: 0x1C78761 VA: 0x1C78660
	private void set_GroundLayer(LayerMask value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A14D0 Offset: 0x1A15D1 VA: 0x1A14D0
	// RVA: 0x1C78670 Offset: 0x1C78771 VA: 0x1C78670
	public bool get_IsTeleporting() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A14E0 Offset: 0x1A15E1 VA: 0x1A14E0
	// RVA: 0x1C78680 Offset: 0x1C78781 VA: 0x1C78680
	public void set_IsTeleporting(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A14F0 Offset: 0x1A15F1 VA: 0x1A14F0
	// RVA: 0x1C78690 Offset: 0x1C78791 VA: 0x1C78690
	public bool get_IsShortPlayLock() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1500 Offset: 0x1A1601 VA: 0x1A1500
	// RVA: 0x1C786A0 Offset: 0x1C787A1 VA: 0x1C786A0
	public void set_IsShortPlayLock(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1510 Offset: 0x1A1611 VA: 0x1A1510
	// RVA: 0x1C786B0 Offset: 0x1C787B1 VA: 0x1C786B0
	public bool get_IsTeleportEndFade() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1520 Offset: 0x1A1621 VA: 0x1A1520
	// RVA: 0x1C786C0 Offset: 0x1C787C1 VA: 0x1C786C0
	private void set_IsTeleportEndFade(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1530 Offset: 0x1A1631 VA: 0x1A1530
	// RVA: 0x1C786D0 Offset: 0x1C787D1 VA: 0x1C786D0
	public bool get_IsCameraCulling() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1540 Offset: 0x1A1641 VA: 0x1A1540
	// RVA: 0x1C786E0 Offset: 0x1C787E1 VA: 0x1C786E0
	private void set_IsCameraCulling(bool value) { }

	// RVA: 0x1C68C40 Offset: 0x1C68D41 VA: 0x1C68C40
	public static bool get_IsInDoor() { }

	// RVA: 0x1C786F0 Offset: 0x1C787F1 VA: 0x1C786F0
	public static bool get_IsInTown() { }

	// RVA: 0x1C78860 Offset: 0x1C78961 VA: 0x1C78860
	public static bool get_IsInTownArea() { }

	// RVA: 0x1C78970 Offset: 0x1C78A71 VA: 0x1C78970
	public static bool get_IsDungeon() { }

	// RVA: 0x1C789E0 Offset: 0x1C78AE1 VA: 0x1C789E0
	public static bool get_IsField() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1550 Offset: 0x1A1651 VA: 0x1A1550
	// RVA: 0x1C78AD0 Offset: 0x1C78BD1 VA: 0x1C78AD0
	public bool get_IsUseCpuBoost() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1560 Offset: 0x1A1661 VA: 0x1A1560
	// RVA: 0x1C78AE0 Offset: 0x1C78BE1 VA: 0x1C78AE0
	public void set_IsUseCpuBoost(bool value) { }

	// RVA: 0x1C78AF0 Offset: 0x1C78BF1 VA: 0x1C78AF0
	public static bool get_IsCreatedNaviMeshSurfaces() { }

	// RVA: 0x1C78BB0 Offset: 0x1C78CB1 VA: 0x1C78BB0
	public static bool get_IsStartFestivalResultScript() { }

	// RVA: 0x1C78C50 Offset: 0x1C78D51 VA: 0x1C78C50
	public static void InitializeForNewGame() { }

	// RVA: 0x1C78C60 Offset: 0x1C78D61 VA: 0x1C78C60
	public static void UnloadAllScene() { }

	// RVA: 0x1C78D30 Offset: 0x1C78E31 VA: 0x1C78D30
	private void BeginTeleportCharacter() { }

	// RVA: 0x1C79070 Offset: 0x1C79171 VA: 0x1C79070
	private void EndTeleportCharacter() { }

	// RVA: 0x1C79450 Offset: 0x1C79551 VA: 0x1C79450
	public Dictionary<string, TeleportPortalData> GetTeleportPositionDataTable(string sceneName) { }

	// RVA: 0x1C79530 Offset: 0x1C79631 VA: 0x1C79530
	public FieldSceneData.Data GetSceneData(string sceneName) { }

	// RVA: 0x1C79650 Offset: 0x1C79751 VA: 0x1C79650
	public FieldSceneData.Data GetSceneData(int sceneId) { }

	// RVA: 0x1C796C0 Offset: 0x1C797C1 VA: 0x1C796C0
	public static ItemLevelWeightID GetItemLevelWeightID() { }

	// RVA: 0x1C79730 Offset: 0x1C79831 VA: 0x1C79730
	public static int GetEquipItemLevelCap() { }

	// RVA: 0x1C797A0 Offset: 0x1C798A1 VA: 0x1C797A0
	public TeleportPortalData GetTeleportPositionData(string teleportPositionName, string sceneName) { }

	// RVA: 0x1C79860 Offset: 0x1C79961 VA: 0x1C79860
	public FieldTeleportDataTable GetFieldTeleportData(FieldTeleportID id) { }

	// RVA: 0x1C798F0 Offset: 0x1C799F1 VA: 0x1C798F0
	private void SetEnableStreamer(string enableSceneName, string disableSceneName, ref List<Streamer> list, bool isKeep) { }

	// RVA: 0x1C79B80 Offset: 0x1C79C81 VA: 0x1C79B80
	private void SetPlayerTransform(PlayerTeleport playerTeleport, Transform targetTransform) { }

	// RVA: 0x1C79D00 Offset: 0x1C79E01 VA: 0x1C79D00
	private void SetWorldStreamerParam(string nowSceneName, string nextSceneName, string teleportName, bool isKeep) { }

	// RVA: 0x1C7A780 Offset: 0x1C7A881 VA: 0x1C7A780
	private void WorldStreamerMove() { }

	// RVA: 0x1C7A960 Offset: 0x1C7AA61 VA: 0x1C7A960
	private void UpdatePlaceId() { }

	// RVA: 0x1C7ACB0 Offset: 0x1C7ADB1 VA: 0x1C7ACB0
	private void BeginPlayerMover() { }

	// RVA: 0x1C7A8D0 Offset: 0x1C7A9D1 VA: 0x1C7A8D0
	private void OnDonePlayerMover() { }

	// RVA: 0x1C7ADB0 Offset: 0x1C7AEB1 VA: 0x1C7ADB0
	private void OnDonePlayerMoverInvoke() { }

	// RVA: 0x1C7B0C0 Offset: 0x1C7B1C1 VA: 0x1C7B0C0
	public void SetWorldStreamerRange(TeleportAreaManager.WorldStreamerRangeMode mode, bool isCheck) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1570 Offset: 0x1A1671 VA: 0x1A1570
	// RVA: 0x1C7AD30 Offset: 0x1C7AE31 VA: 0x1C7AD30
	public IEnumerator WaitLoadPlayerMover() { }

	// RVA: 0x1C7B400 Offset: 0x1C7B501 VA: 0x1C7B400
	private EventStartPoint GetEventStartPointPlayerLandOn() { }

	// RVA: 0x1C7A020 Offset: 0x1C7A121 VA: 0x1C7A020
	private bool SetPlayerPosition(PlayerTeleport playerTeleport, string teleportName, string sceneName) { }

	// RVA: 0x1C7B8A0 Offset: 0x1C7B9A1 VA: 0x1C7B8A0
	private bool SceneNameIfMatches(string checkSceneName, string targetSceneName) { }

	// RVA: 0x1C7B8C0 Offset: 0x1C7B9C1 VA: 0x1C7B8C0
	public void SceneUnloadAsync(string loadSceneName, bool isPopScene, Action onLoadCompleteAction) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A15E0 Offset: 0x1A16E1 VA: 0x1A15E0
	// RVA: 0x1C7B900 Offset: 0x1C7BA01 VA: 0x1C7B900
	public IEnumerator SceneUnloadAsyncCoroutine(string loadSceneName, bool isPopScene, Action onLoadCompleteAction) { }

	// RVA: 0x1C7B9C0 Offset: 0x1C7BAC1 VA: 0x1C7B9C0
	private void PreloadSceneDeactevie() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1650 Offset: 0x1A1751 VA: 0x1A1650
	// RVA: 0x1C7BB70 Offset: 0x1C7BC71 VA: 0x1C7BB70
	public IEnumerator ScenePopWaitAsync() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A16C0 Offset: 0x1A17C1 VA: 0x1A16C0
	// RVA: 0x1C7BBF0 Offset: 0x1C7BCF1 VA: 0x1C7BBF0
	public IEnumerator LoadObjectWaitAsync() { }

	// RVA: 0x1C7BC50 Offset: 0x1C7BD51 VA: 0x1C7BC50
	private void OnLoadComplete() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1730 Offset: 0x1A1831 VA: 0x1A1730
	// RVA: 0x1C7BCF0 Offset: 0x1C7BDF1 VA: 0x1C7BCF0
	public IEnumerator OnLoadCompleteCoroutine() { }

	// RVA: 0x1C7BD70 Offset: 0x1C7BE71 VA: 0x1C7BD70
	private void LoadCompleteCommon(bool isSceneLoad) { }

	// RVA: 0x1C7C100 Offset: 0x1C7C201 VA: 0x1C7C100
	public void FieldSceneSetting(string NextSceneName) { }

	// RVA: 0x1C7C4C0 Offset: 0x1C7C5C1 VA: 0x1C7C4C0
	private void NpcLoad(FieldPlaceId id, bool checkArea) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A17A0 Offset: 0x1A18A1 VA: 0x1A17A0
	// RVA: 0x1C7C6B0 Offset: 0x1C7C7B1 VA: 0x1C7C6B0
	private IEnumerator SceneChangeLoad() { }

	// RVA: 0x1C7C030 Offset: 0x1C7C131 VA: 0x1C7C030
	private void SetSceneImageEffectsParam(FieldSceneData.Data loadSceneParam) { }

	// RVA: 0x1C7C730 Offset: 0x1C7C831 VA: 0x1C7C730
	private void SceneStreamerAdjust() { }

	// RVA: 0x1C7C9E0 Offset: 0x1C7CAE1 VA: 0x1C7C9E0
	public void ScenePush(string loadSceneName, Action onLoadCompleteAction) { }

	// RVA: 0x1C7CCD0 Offset: 0x1C7CDD1 VA: 0x1C7CCD0
	private void SceneAddAsync(string loadSceneName, Action onLoadCompleteAction) { }

	// RVA: 0x1C7D330 Offset: 0x1C7D431 VA: 0x1C7D330
	public Streamer[] FindStreamers(GameObject[] streamerObjects) { }

	// RVA: 0x1C7D4C0 Offset: 0x1C7D5C1 VA: 0x1C7D4C0
	public Streamer[] FindStreamers() { }

	// RVA: 0x1C7D5B0 Offset: 0x1C7D6B1 VA: 0x1C7D5B0
	public bool IsUseWorldStearmer() { }

	// RVA: 0x1C7D5F0 Offset: 0x1C7D6F1 VA: 0x1C7D5F0
	public void TeleportPosition(Vector3 position, Quaternion rotation) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1810 Offset: 0x1A1911 VA: 0x1A1810
	// RVA: 0x1C7DB90 Offset: 0x1C7DC91 VA: 0x1C7DB90
	public IEnumerator TeleportPositionCoroutine() { }

	// RVA: 0x1C7DC10 Offset: 0x1C7DD11 VA: 0x1C7DC10
	public void TeleportPlayerPosition() { }

	// RVA: 0x1C7DD90 Offset: 0x1C7DE91 VA: 0x1C7DD90
	public void TeleportScene(int sceneId, Vector3 position, Vector3 rotation, Action onLoadCompleteAction) { }

	// RVA: 0x1C7E9B0 Offset: 0x1C7EAB1 VA: 0x1C7E9B0
	public void TeleportScene(FieldTeleportID fieldTeleportID, Action onLoadCompleteAction) { }

	// RVA: 0x1C7EC10 Offset: 0x1C7ED11 VA: 0x1C7EC10
	public void TeleportScene(string sceneName, Action onLoadCompleteAction) { }

	// RVA: 0x1C7EC90 Offset: 0x1C7ED91 VA: 0x1C7EC90
	public void TeleportScene(string sceneName, Vector3 position, Vector3 rotation, Action onLoadCompleteAction) { }

	// RVA: 0x1C7ED70 Offset: 0x1C7EE71 VA: 0x1C7ED70
	public void TeleportScene(int sceneId, string teleportPortal, Action onLoadCompleteAction) { }

	// RVA: 0x1C7DF40 Offset: 0x1C7E041 VA: 0x1C7DF40
	public void TeleportScene(string sceneName, string teleportPortal, Action onLoadCompleteAction) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1880 Offset: 0x1A1981 VA: 0x1A1880
	// RVA: 0x1C7CC50 Offset: 0x1C7CD51 VA: 0x1C7CC50
	public IEnumerator LoadSceneBgm() { }

	// RVA: 0x1C7F0A0 Offset: 0x1C7F1A1 VA: 0x1C7F0A0
	public void SetSceneBgm(string sceneName) { }

	// RVA: 0x1C7F4E0 Offset: 0x1C7F5E1 VA: 0x1C7F4E0
	public BGMID GetFieldBGMId(FieldPlaceId fieldPlaceId = 0) { }

	// RVA: 0x1C7F330 Offset: 0x1C7F431 VA: 0x1C7F330
	public void SetFieldBgm(FieldPlaceId fieldPlaceId = 0) { }

	// RVA: 0x1C7F420 Offset: 0x1C7F521 VA: 0x1C7F420
	public void PlayHomeBGM() { }

	// RVA: 0x1C7F580 Offset: 0x1C7F681 VA: 0x1C7F580
	public BGMID GetHomeBGMId() { }

	// RVA: 0x1C7EEE0 Offset: 0x1C7EFE1 VA: 0x1C7EEE0
	protected bool IsDispLoadHint(FieldSceneData.Data sceneData) { }

	// RVA: 0x1C7F5F0 Offset: 0x1C7F6F1 VA: 0x1C7F5F0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1C7F7F0 Offset: 0x1C7F8F1 VA: 0x1C7F7F0
	private void Start() { }

	// RVA: 0x1C7FA80 Offset: 0x1C7FB81 VA: 0x1C7FA80
	public bool IsLoadCompletedStreamer() { }

	// RVA: 0x1C7FBE0 Offset: 0x1C7FCE1 VA: 0x1C7FBE0
	public bool IsTransitionCompleted() { }

	// RVA: 0x1C7FC20 Offset: 0x1C7FD21 VA: 0x1C7FC20
	public void SetWorldStreamerTarget(Transform transform) { }

	// RVA: 0x1C7FEB0 Offset: 0x1C7FFB1 VA: 0x1C7FEB0
	public void SetWorldStreamerTargetPosition(float x, float y, float z, int intensity = -1) { }

	// RVA: 0x1C80070 Offset: 0x1C80171 VA: 0x1C80070
	public void RemoveWorldStreamerTargetPosition() { }

	// RVA: 0x1C80080 Offset: 0x1C80181 VA: 0x1C80080
	public void SetWorldStreamerTargetPositionIntensity(int value) { }

	// RVA: 0x1C80090 Offset: 0x1C80191 VA: 0x1C80090
	public int GetWorldStreamerTargetPositionIntensity() { }

	// RVA: 0x1C800A0 Offset: 0x1C801A1 VA: 0x1C800A0
	public void ResetWorldStreamerTargetPositionIntensity() { }

	// RVA: 0x1C800D0 Offset: 0x1C801D1 VA: 0x1C800D0
	public bool CheckWorldStreamerTargetDist(float x, float y, float z, int intensity = -1) { }

	// RVA: 0x1C800C0 Offset: 0x1C801C1 VA: 0x1C800C0
	public void ClearCheckWorldStreamerTargetDist() { }

	// RVA: 0x1C801D0 Offset: 0x1C802D1 VA: 0x1C801D0
	public void CheckPositionStreamers() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A18F0 Offset: 0x1A19F1 VA: 0x1A18F0
	// RVA: 0x1C80250 Offset: 0x1C80351 VA: 0x1C80250
	public IEnumerator UnloadStearmerSceneAsync(Action completeAction) { }

	// RVA: 0x1C802D0 Offset: 0x1C803D1 VA: 0x1C802D0
	public bool CheckUseSceneWeather(string sceneName) { }

	// RVA: 0x1C79E60 Offset: 0x1C79F61 VA: 0x1C79E60
	public Transform GetStreamerTargetTransform() { }

	// RVA: 0x1C80300 Offset: 0x1C80401 VA: 0x1C80300
	public void AddDragonRope(TeleportDragonRope dragonRope) { }

	// RVA: 0x1C80370 Offset: 0x1C80471 VA: 0x1C80370
	public void RemoveDragonRope(TeleportDragonRope dragonRope) { }

	// RVA: 0x1C803E0 Offset: 0x1C804E1 VA: 0x1C803E0
	private void OnSceneChangeSetTeleportPoint() { }

	// RVA: 0x1C80500 Offset: 0x1C80601 VA: 0x1C80500
	private void LateUpdate() { }

	// RVA: 0x1C80590 Offset: 0x1C80691 VA: 0x1C80590
	public void SetRestrictionArea(FieldRestrictionType restrictionType) { }

	// RVA: 0x1C805A0 Offset: 0x1C806A1 VA: 0x1C805A0
	public FieldRestrictionType GetRestrictionArea() { }

	// RVA: 0x1C805B0 Offset: 0x1C806B1 VA: 0x1C805B0
	public bool IsSaveRestriction() { }

	// RVA: 0x1C805D0 Offset: 0x1C806D1 VA: 0x1C805D0
	public void ClearFieldMapAreaPlaceId() { }

	// RVA: 0x1C7AC50 Offset: 0x1C7AD51 VA: 0x1C7AC50
	public void SetFieldMapAreaPlaceId(FieldPlaceId placeId) { }

	// RVA: 0x1C7EFA0 Offset: 0x1C7F0A1 VA: 0x1C7EFA0
	public FieldPlaceId UpdateFieldPlaceId(bool checkArea) { }

	// RVA: 0x1C805E0 Offset: 0x1C806E1 VA: 0x1C805E0
	public string GetNamingPlaceName() { }

	// RVA: 0x1C80920 Offset: 0x1C80A21 VA: 0x1C80920
	public string GetFieldPlaceName() { }

	// RVA: 0x1C809C0 Offset: 0x1C80AC1 VA: 0x1C809C0
	public static string GetFieldPlaceName(FieldPlaceId fieldPlaceId) { }

	// RVA: 0x1C80BA0 Offset: 0x1C80CA1 VA: 0x1C80BA0
	public void AddMapFieldCollider(MapFieldCollider addCollider) { }

	// RVA: 0x1C80C10 Offset: 0x1C80D11 VA: 0x1C80C10
	public void RemoveMapFieldCollider(MapFieldCollider removeCollider) { }

	// RVA: 0x1C80C80 Offset: 0x1C80D81 VA: 0x1C80C80
	public void .ctor() { }

	// RVA: 0x1C80EF0 Offset: 0x1C80FF1 VA: 0x1C80EF0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1960 Offset: 0x1A1A61 VA: 0x1A1960
	// RVA: 0x1C81050 Offset: 0x1C81151 VA: 0x1C81050
	private void <TeleportScene>b__179_0() { }
}

