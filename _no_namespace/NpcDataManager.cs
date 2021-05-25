[Serializable]
public class NpcDataManager : SingletonMonoBehaviour<NpcDataManager> // TypeDefIndex: 8124
{
	// Fields
	private static bool NewGameInitialize; // 0x0
	private static bool Loaded; // 0x1
	public readonly int DatingNumTotalMax; // 0x18
	public readonly int DatingNumMax; // 0x1C
	public int MobTalkCount; // 0x20
	public bool TodayMobTalked; // 0x24
	public bool TodayMobEnabled; // 0x25
	private bool[] NpcGroupIds; // 0x28
	[SerializeField] // RVA: 0x16B3E0 Offset: 0x16B4E1 VA: 0x16B3E0
	public List<NpcData> NpcDatas; // 0x30
	private bool Initialize; // 0x38
	public bool Standby; // 0x39
	public LovePointManager LovePointManager; // 0x40
	private int PlayerConflictCount; // 0x48

	// Methods

	// RVA: 0x23FFAF0 Offset: 0x23FFBF1 VA: 0x23FFAF0
	public bool IsNewGameInitializing() { }

	// RVA: 0x23FFB60 Offset: 0x23FFC61 VA: 0x23FFB60
	public bool IsLoaded() { }

	// RVA: 0x23F79F0 Offset: 0x23F7AF1 VA: 0x23F79F0
	public void AddPlayerConflictCount() { }

	// RVA: 0x23F7A00 Offset: 0x23F7B01 VA: 0x23F7A00
	public void SubPlayerConflictCount() { }

	// RVA: 0x23FFBD0 Offset: 0x23FFCD1 VA: 0x23FFBD0
	public bool IsConflictPlayer() { }

	// RVA: 0x23FFBE0 Offset: 0x23FFCE1 VA: 0x23FFBE0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x23FFD80 Offset: 0x23FFE81 VA: 0x23FFD80
	public void InitData() { }

	// RVA: 0x23FFDF0 Offset: 0x23FFEF1 VA: 0x23FFDF0
	public void BeforeSaveNpcData() { }

	// RVA: 0x23FFF00 Offset: 0x2400001 VA: 0x23FFF00
	public void AfterLoadNpcData() { }

	// RVA: 0x23F5440 Offset: 0x23F5541 VA: 0x23F5440
	public int GetFreeGroupIndex() { }

	// RVA: 0x23F3B80 Offset: 0x23F3C81 VA: 0x23F3B80
	public void ClearGroupIndex(int idx) { }

	// RVA: 0x2400040 Offset: 0x2400141 VA: 0x2400040
	public void Init() { }

	// RVA: 0x2400780 Offset: 0x2400881 VA: 0x2400780
	public void LoadAfterAdvScriptDefCount() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A6260 Offset: 0x1A6361 VA: 0x1A6260
	// RVA: 0x2400700 Offset: 0x2400801 VA: 0x2400700
	private IEnumerator RegistOnHourCarry() { }

	// RVA: 0x24008F0 Offset: 0x24009F1 VA: 0x24008F0
	public static void NpcDataInitializeForNewGame() { }

	// RVA: 0x23FFC40 Offset: 0x23FFD41 VA: 0x23FFC40
	public void NpcDataInitializeForLifeCycle() { }

	// RVA: 0x2400870 Offset: 0x2400971 VA: 0x2400870
	private void SetNpcDataParameter(NpcData npcdata) { }

	// RVA: 0x2400A30 Offset: 0x2400B31 VA: 0x2400A30
	public NpcData GetNpcData(ActorID actorId) { }

	// RVA: 0x2400AD0 Offset: 0x2400BD1 VA: 0x2400AD0
	public NpcData GetNpcData(NPCID NpcId) { }

	// RVA: 0x23F5330 Offset: 0x23F5431 VA: 0x23F5330
	public NpcData GetNpcData(int NpcId) { }

	// RVA: 0x2400BE0 Offset: 0x2400CE1 VA: 0x2400BE0
	public bool TryGetNpcData(int NpcId, out NpcData outData) { }

	// RVA: 0x23ED0A0 Offset: 0x23ED1A1 VA: 0x23ED0A0
	public bool IsMyChild(int NpcId) { }

	// RVA: 0x2400D30 Offset: 0x2400E31 VA: 0x2400D30
	public bool IsKids(NPCID npcId) { }

	// RVA: 0x23F84B0 Offset: 0x23F85B1 VA: 0x23F84B0
	public bool IsLoveTarget(NPCID npcId) { }

	// RVA: 0x23FC2E0 Offset: 0x23FC3E1 VA: 0x23FC2E0
	public bool CanChangeWear(NPCID npcId) { }

	// RVA: 0x23ED0C0 Offset: 0x23ED1C1 VA: 0x23ED0C0
	public int GetSpouseNpcId() { }

	// RVA: 0x2400D40 Offset: 0x2400E41 VA: 0x2400D40
	public NpcData GetSpouseNpcData() { }

	// RVA: 0x2400E70 Offset: 0x2400F71 VA: 0x2400E70
	public bool IsSpouseNpc(int npcid) { }

	// RVA: 0x2400EB0 Offset: 0x2400FB1 VA: 0x2400EB0
	public bool IsExistLover(int npcid = -1) { }

	// RVA: 0x2401070 Offset: 0x2401171 VA: 0x2401070
	public int GetLoverNum() { }

	// RVA: 0x24011A0 Offset: 0x24012A1 VA: 0x24011A0
	public bool IsLover(int npcid) { }

	// RVA: 0x24012F0 Offset: 0x24013F1 VA: 0x24012F0
	public bool IsMoreThanLover(int npcid) { }

	// RVA: 0x2400150 Offset: 0x2400251 VA: 0x2400150
	public void SetNpcStatusData() { }

	// RVA: 0x2401470 Offset: 0x2401571 VA: 0x2401470
	public void UpdateBedPatrolPointName() { }

	// RVA: 0x2400540 Offset: 0x2400641 VA: 0x2400540
	public void LifeCycleLotteryInit() { }

	// RVA: 0x24017B0 Offset: 0x24018B1 VA: 0x24017B0
	public void UpdateEventId() { }

	// RVA: 0x2400680 Offset: 0x2400781 VA: 0x2400680
	public void LifeCycleLotteryStart() { }

	// RVA: 0x2401B30 Offset: 0x2401C31 VA: 0x2401B30
	public bool LifeCycleLotteryUpdate() { }

	// RVA: 0x2401BA0 Offset: 0x2401CA1 VA: 0x2401BA0
	public List<NpcLifeCycleDataRecord> GetExtractMargineLifeCycleTimeSortList() { }

	// RVA: 0x2401FC0 Offset: 0x24020C1 VA: 0x2401FC0
	public void SetScheduleData(int eventId) { }

	// RVA: 0x2401FD0 Offset: 0x24020D1 VA: 0x2401FD0
	private void OnHourCarry(int diff) { }

	// RVA: 0x24020E0 Offset: 0x24021E1 VA: 0x24020E0
	public int GetTotalDatingCount() { }

	// RVA: 0x2402250 Offset: 0x2402351 VA: 0x2402250
	public void DoBecomeLover(int npcId) { }

	// RVA: 0x24023E0 Offset: 0x24024E1 VA: 0x24023E0
	public void DoMarriage(int npcId) { }

	// RVA: 0x2402560 Offset: 0x2402661 VA: 0x2402560
	public void DoPartner(int npcId, Action<PartnerNPCBehaviorController> callBack) { }

	// RVA: 0x24026E0 Offset: 0x24027E1 VA: 0x24026E0
	public void ReleasePartner(int npcId, Action<NpcController> callBack) { }

	// RVA: 0x2402860 Offset: 0x2402961 VA: 0x2402860
	public void ReleasePartnerByTime(int npcId) { }

	// RVA: 0x24029C0 Offset: 0x2402AC1 VA: 0x24029C0
	public void SetIsDateRefrain(int npcId, bool value) { }

	// RVA: 0x2402AF0 Offset: 0x2402BF1 VA: 0x2402AF0
	public int GetDateRefrain() { }

	// RVA: 0x2402C30 Offset: 0x2402D31 VA: 0x2402C30
	public bool IsMarriageCandidate(int npcId) { }

	// RVA: 0x2402D10 Offset: 0x2402E11 VA: 0x2402D10
	public bool IsHospitalPerson(int npcId) { }

	// RVA: 0x2402D20 Offset: 0x2402E21 VA: 0x2402D20
	public void InitializeHintTalkTime() { }

	// RVA: 0x2402E60 Offset: 0x2402F61 VA: 0x2402E60
	public bool IsPriscillaChangedStyle() { }

	// RVA: 0x2402F10 Offset: 0x2403011 VA: 0x2402F10
	public bool IsShopOpened(int npcId) { }

	// RVA: 0x2402F30 Offset: 0x2403031 VA: 0x2402F30
	public void RemoveAllResources() { }

	// RVA: 0x23EB5A0 Offset: 0x23EB6A1 VA: 0x23EB5A0
	public bool IsSitting(NpcAnimState state) { }

	// RVA: 0x2402FE0 Offset: 0x24030E1 VA: 0x2402FE0
	public bool IsSleeping(NpcAnimState state) { }

	// RVA: 0x2403010 Offset: 0x2403111 VA: 0x2403010
	public Actor CreateNpcActor(int npcId) { }

	// RVA: 0x24030C0 Offset: 0x24031C1 VA: 0x24030C0
	public void EnableNpcLifecycleItems(ActorID actorId, bool enable) { }

	// RVA: 0x2403430 Offset: 0x2403531 VA: 0x2403430
	public void .ctor() { }

	// RVA: 0x24034E0 Offset: 0x24035E1 VA: 0x24034E0
	private static void .cctor() { }
}

