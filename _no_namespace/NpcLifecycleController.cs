public class NpcLifecycleController : SingletonMonoBehaviour<NpcLifecycleController> // TypeDefIndex: 8136
{
	// Fields
	[SerializeField] // RVA: 0x16B420 Offset: 0x16B521 VA: 0x16B420
	public int[] DebugTargetNpcIds; // 0x18
	[SerializeField] // RVA: 0x16B430 Offset: 0x16B531 VA: 0x16B430
	public bool Debug_UseNavMesh; // 0x20
	[SerializeField] // RVA: 0x16B440 Offset: 0x16B541 VA: 0x16B440
	public bool Debug_UseRoomNavMesh; // 0x21
	public bool LifeCyclePause; // 0x22
	public bool LifeCycleActive; // 0x23
	public NpcLoadState IsNpcLoading; // 0x24
	public bool Debug_DrawNavMesh; // 0x28
	[SerializeField] // RVA: 0x16B450 Offset: 0x16B551 VA: 0x16B450
	public int RotateRouteMaxNpcNum; // 0x2C
	[SerializeField] // RVA: 0x16B460 Offset: 0x16B561 VA: 0x16B460
	public float ForceWalkSpeed; // 0x30
	[SerializeField] // RVA: 0x16B470 Offset: 0x16B571 VA: 0x16B470
	private List<NpcController> NpcList; // 0x38
	private int hour; // 0x40
	private int minutes; // 0x44
	public int ElapsedTime; // 0x48
	public GameObject npcPatrolPoints; // 0x50
	public bool IsDecidedNpcSchedule; // 0x58
	public bool IsLotteryReStart; // 0x59
	public bool IsUpdateSimulatePosition; // 0x5A
	public bool IsFirstUpdateNpcs; // 0x5B
	private const int EnabledSqrMagnitude = 9216;
	private const float EnabledViewportPointZ = 32;
	private static readonly Rect ViewportRect; // 0x0
	private int PrevLifeCycleEventId; // 0x5C
	private int CurrentLifeCycleEventId; // 0x60
	public int SimulateDay; // 0x64
	public int NextSimulateDay; // 0x68
	public Weather SimulateWeather; // 0x6C
	private bool IsStandbyPatrolPoints; // 0x70
	private bool IsStandbyNpcDatas; // 0x71
	private bool IsStandbyNpcs; // 0x72
	public bool IsStandbyAllNpcs; // 0x73
	public bool IsDestroyAllNpcs; // 0x74
	public bool IsCreatedMobs; // 0x75
	public bool IsStandbyMobs; // 0x76
	public bool IsNotCreatedMobs; // 0x77
	private Actor[] mobActor; // 0x78
	private List<int> NewYearVoceActorIdList; // 0x80
	private bool IsChangeLifeCycle; // 0x88
	protected AnimationCurve m_RotateSpeedCurve; // 0x90
	private bool IsRegistOnDayCarry; // 0x98
	public GameObject ShortPlayItems; // 0xA0
	private bool IsNewYear; // 0xA8
	private bool IsReservedSimulate; // 0xA9
	private int chkCnt; // 0xAC
	private List<int> deleteNpcIDList; // 0xB0
	private List<int> removeList; // 0xB8

	// Properties
	private bool IsWakeupTime { get; }

	// Methods

	// RVA: 0x1D7F3E0 Offset: 0x1D7F4E1 VA: 0x1D7F3E0
	private bool get_IsWakeupTime() { }

	// RVA: 0x1D7F470 Offset: 0x1D7F571 VA: 0x1D7F470
	public NpcData GetNpcData(int NpcId) { }

	// RVA: 0x1D7F530 Offset: 0x1D7F631 VA: 0x1D7F530
	public NpcController GetNpc(int NpcId) { }

	// RVA: 0x1D7F650 Offset: 0x1D7F751 VA: 0x1D7F650
	public int GetHour() { }

	// RVA: 0x1D7F660 Offset: 0x1D7F761 VA: 0x1D7F660
	public int GetMinutes() { }

	// RVA: 0x1D7F670 Offset: 0x1D7F771 VA: 0x1D7F670
	public void RemoveNpcs() { }

	// RVA: 0x1D7F680 Offset: 0x1D7F781 VA: 0x1D7F680
	public void AddNpc(NpcController addnpc) { }

	// RVA: 0x1D7F800 Offset: 0x1D7F901 VA: 0x1D7F800
	public void RemoveNpc(NpcController removeNpc) { }

	// RVA: 0x1D7F870 Offset: 0x1D7F971 VA: 0x1D7F870
	public bool IsExistNpc(int NpcId) { }

	// RVA: 0x1D7F880 Offset: 0x1D7F981 VA: 0x1D7F880
	private void RegistOnDayCarry() { }

	// RVA: 0x1D7F990 Offset: 0x1D7FA91 VA: 0x1D7F990
	private void WakeUpUpdate(int diffDay) { }

	// RVA: 0x1D7FD00 Offset: 0x1D7FE01 VA: 0x1D7FD00
	public void SetLifeCyclePause(bool pause) { }

	// RVA: 0x1D7FD10 Offset: 0x1D7FE11 VA: 0x1D7FD10
	protected void OnLoadAsync() { }

	// RVA: 0x1D80850 Offset: 0x1D80951 VA: 0x1D80850 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1D80920 Offset: 0x1D80A21 VA: 0x1D80920
	public void Update() { }

	// RVA: 0x1D81F50 Offset: 0x1D82051 VA: 0x1D81F50
	private void UpdateLifecycleTime() { }

	// RVA: 0x1D80D40 Offset: 0x1D80E41 VA: 0x1D80D40
	private void UpdateDeleteModel() { }

	// RVA: 0x1D82660 Offset: 0x1D82761 VA: 0x1D82660
	private void FixedUpdate() { }

	// RVA: 0x1D82C80 Offset: 0x1D82D81 VA: 0x1D82C80
	public void RefreshAreaPoints() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A6330 Offset: 0x1A6431 VA: 0x1A6330
	// RVA: 0x1D82BF0 Offset: 0x1D82CF1 VA: 0x1D82BF0
	public IEnumerator PlayNewYearVoice(int playedIdx) { }

	// RVA: 0x1D81AD0 Offset: 0x1D81BD1 VA: 0x1D81AD0
	public void SimulateNpcSchedules() { }

	// RVA: 0x1D82F30 Offset: 0x1D83031 VA: 0x1D82F30
	private void SimulateAction(NpcData npcData) { }

	// RVA: 0x1D83480 Offset: 0x1D83581 VA: 0x1D83480
	private void SimulateArrive(NpcData npcData) { }

	// RVA: 0x1D835C0 Offset: 0x1D836C1 VA: 0x1D835C0
	private void SimulateNextAction(NpcData npcData) { }

	// RVA: 0x1D830A0 Offset: 0x1D831A1 VA: 0x1D830A0
	public void SimulateArrivePoint(NpcData npcData) { }

	// RVA: 0x1D839A0 Offset: 0x1D83AA1 VA: 0x1D839A0
	private NpcTimeAction CreateNpcTimeAction(NpcData npcData) { }

	// RVA: 0x1D84310 Offset: 0x1D84411 VA: 0x1D84310
	public bool DeteriorationWeather() { }

	// RVA: 0x1D7FCE0 Offset: 0x1D7FDE1 VA: 0x1D7FCE0
	public void UpdateSimulatePositionFromTimeShiftStart(bool forceUpdate = False, bool IsChangeTime = False) { }

	// RVA: 0x1D843A0 Offset: 0x1D844A1 VA: 0x1D843A0
	private int GetSeasonDay(int season, int day) { }

	// RVA: 0x1D843B0 Offset: 0x1D844B1 VA: 0x1D843B0
	private int GetSimulateDay() { }

	// RVA: 0x1D81990 Offset: 0x1D81A91 VA: 0x1D81990
	private void DoSimulate(bool IsChangeTime = False) { }

	// RVA: 0x1D815A0 Offset: 0x1D816A1 VA: 0x1D815A0
	private void UpdateSimulatePositionFromTimeShift() { }

	// RVA: 0x1D84490 Offset: 0x1D84591 VA: 0x1D84490
	public void UpdateWear() { }

	// RVA: 0x1D845A0 Offset: 0x1D846A1 VA: 0x1D845A0
	public bool IsLucusContisionsToWearGlasses() { }

	// RVA: 0x1D84640 Offset: 0x1D84741 VA: 0x1D84640
	public void GetTimeForUpdateSimulatePosition(out int retHour, out int retMin) { }

	// RVA: 0x1D81FF0 Offset: 0x1D820F1 VA: 0x1D81FF0
	public void UpdateSimulatePosition() { }

	// RVA: 0x1D85850 Offset: 0x1D85951 VA: 0x1D85850
	public void UpdateSimulatePosition(int NpcId) { }

	// RVA: 0x1D84800 Offset: 0x1D84901 VA: 0x1D84800
	public Vector3 GetSimulatePosition(int NpcId, int _hour, int _minutes) { }

	// RVA: 0x1D85AB0 Offset: 0x1D85BB1 VA: 0x1D85AB0
	public Vector3 GetSimulatePositionFromXls(int NpcId) { }

	// RVA: 0x1D863B0 Offset: 0x1D864B1 VA: 0x1D863B0
	public void ByePartnerAction(NpcData npcData) { }

	// RVA: 0x1D864D0 Offset: 0x1D865D1 VA: 0x1D864D0
	private void DisableNpc(Actor act) { }

	// RVA: 0x1D81080 Offset: 0x1D81181 VA: 0x1D81080
	private void UpdatingObjectDisabled() { }

	// RVA: 0x1D82540 Offset: 0x1D82641 VA: 0x1D82540
	private void UpdatingObjectEnabled() { }

	// RVA: 0x1D86600 Offset: 0x1D86701 VA: 0x1D86600
	private void UpdatingObjectEnabled(NpcController npc) { }

	// RVA: 0x1D83EF0 Offset: 0x1D83FF1 VA: 0x1D83EF0
	private string[] DecideRouteToNextTargetPoint(NpcData npcData, Place currentPlace, Place targetPlace, NpcPatrolPoint target) { }

	// RVA: 0x1D83BB0 Offset: 0x1D83CB1 VA: 0x1D83BB0
	public void SetNextPlacePatrolPoints(NpcData npcData, Place nextPlace, NpcPatrolPoint nextPoint) { }

	// RVA: 0x1D869F0 Offset: 0x1D86AF1 VA: 0x1D869F0
	public bool CheckWeatherRain() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A63A0 Offset: 0x1A64A1 VA: 0x1A63A0
	// RVA: 0x1D86A60 Offset: 0x1D86B61 VA: 0x1D86A60
	public IEnumerator StayingMotion(NpcData npcData, NpcAnimState AnimState, float StayingSec, float StayingMotionSec) { }

	// RVA: 0x1D86B50 Offset: 0x1D86C51 VA: 0x1D86B50
	public float DistanceXZ(Vector3 src, Vector3 dst) { }

	// RVA: 0x1D86C00 Offset: 0x1D86D01 VA: 0x1D86C00
	public bool IsFieldMap(Place place) { }

	// RVA: 0x1D86C40 Offset: 0x1D86D41 VA: 0x1D86C40
	public bool IsOutdoor(Place place) { }

	// RVA: 0x1D86C70 Offset: 0x1D86D71 VA: 0x1D86C70
	public void ChangeActiveSelf_AllNpc(bool active) { }

	// RVA: 0x1D80440 Offset: 0x1D80541 VA: 0x1D80440
	public bool AllNpcStanby() { }

	// RVA: 0x1D80840 Offset: 0x1D80941 VA: 0x1D80840
	public void CreateMobs() { }

	// RVA: 0x1D87060 Offset: 0x1D87161 VA: 0x1D87060
	public bool IsMobActive(Actor act) { }

	// RVA: 0x1D81580 Offset: 0x1D81681 VA: 0x1D81580
	public void DispMobs() { }

	// RVA: 0x1D87090 Offset: 0x1D87191 VA: 0x1D87090
	public void .ctor() { }

	// RVA: 0x1D87200 Offset: 0x1D87301 VA: 0x1D87200
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6410 Offset: 0x1A6511 VA: 0x1A6410
	// RVA: 0x1D87290 Offset: 0x1D87391 VA: 0x1D87290
	private void <OnLoadAsync>b__58_0(AssetHandle<GameObject> handle) { }
}

