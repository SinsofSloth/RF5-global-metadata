[Serializable]
public class NpcData // TypeDefIndex: 8111
{
	// Fields
	[HeaderAttribute] // RVA: 0x16B0F0 Offset: 0x16B1F1 VA: 0x16B0F0
	public ActorID actorId; // 0x10
	public int NpcId; // 0x14
	public Vector3 StandbyPosition; // 0x18
	public Quaternion StandbyRotation; // 0x24
	public NpcAnimState StandbyAnimState; // 0x34
	private NpcController Controller; // 0x38
	[HeaderAttribute] // RVA: 0x16B130 Offset: 0x16B231 VA: 0x16B130
	public GameFlagData LifecycleStartFlag; // 0x40
	public bool ObjectEnabled; // 0x44
	public bool FadeDistance; // 0x45
	public bool _forceDisabled; // 0x46
	[SerializeField] // RVA: 0x16B170 Offset: 0x16B271 VA: 0x16B170
	public bool _isShortPlay; // 0x47
	public bool IsShortPlayMove; // 0x48
	public bool Initialized; // 0x49
	public bool InDoor; // 0x4A
	public bool _IsStop; // 0x4B
	public bool _IsSlowDown; // 0x4C
	[HeaderAttribute] // RVA: 0x16B180 Offset: 0x16B281 VA: 0x16B180
	private bool IsMotion; // 0x4D
	public NpcAnimState _AnimationState; // 0x50
	public bool IsSetAnimationState; // 0x54
	public NpcAnimState SpcAnimationState; // 0x58
	public bool _AnimationSitting; // 0x5C
	[HeaderAttribute] // RVA: 0x16B1C0 Offset: 0x16B2C1 VA: 0x16B1C0
	public NpcMoveType NpcMoveType; // 0x60
	public Transform transform; // 0x68
	private float AnimRunSpeed; // 0x70
	[HideInInspector] // RVA: 0x16B200 Offset: 0x16B301 VA: 0x16B200
	private Vector3 PrevTickPosition; // 0x74
	[HeaderAttribute] // RVA: 0x16B210 Offset: 0x16B311 VA: 0x16B210
	public bool UseNavMesh; // 0x80
	public int _NpcGroupId; // 0x84
	public List<NpcTimeAction> NpcTimeActions; // 0x88
	public bool _IsReached; // 0x90
	public bool IsDoneRaycast; // 0x91
	public bool IsLateness; // 0x92
	public bool IsHurry; // 0x93
	public bool IsCheckRainHomeBack; // 0x94
	public Weather _HomeBackWeather; // 0x98
	public bool IsWaitNextAction; // 0x9C
	public FieldPlaceId _CurrentFieldPlaceId; // 0xA0
	public NpcPatrolPoint CurrentPatrolPoint; // 0xA8
	public GameObject _NextPatrolPoint; // 0xB0
	public LifecycleState PrevLifecycleState; // 0xB8
	public int _CurrentLifecycleTime; // 0xBC
	public LifecycleState _CurrentLifecycleState; // 0xC0
	public LifecycleState NextLifecycleState; // 0xC4
	public LifecycleState BeforeResetLifecycleState; // 0xC8
	[HeaderAttribute] // RVA: 0x16B250 Offset: 0x16B351 VA: 0x16B250
	public Place PrevPlace; // 0xCC
	public Place _CurrentPlace; // 0xD0
	public Place _TargetPlace; // 0xD4
	private NpcPatrolPoint _seatPatrolPoint; // 0xD8
	private string _seatPatrolPointName; // 0xE0
	public NpcPatrolPoint JobPatrolPoint; // 0xE8
	public string BedPatrolPointName; // 0xF0
	public NpcPatrolPoint BedPatrolPoint; // 0xF8
	public string DoorPatrolPointName; // 0x100
	public string TargetDoorPatrolPointName; // 0x108
	private GameObject _targetDoor; // 0x110
	private string _targetDoorName; // 0x118
	public Vector3 targetPosition; // 0x120
	public int CurrentPositionIndex; // 0x12C
	public int _RotatePatternNumber; // 0x130
	public string[] PatrolPoints; // 0x138
	public Vector3[] positions; // 0x140
	public string[] pointNames; // 0x148
	public bool IsWarp; // 0x150
	[HeaderAttribute] // RVA: 0x16B290 Offset: 0x16B391 VA: 0x16B290
	public int m_hour; // 0x154
	public int m_minutes; // 0x158
	public int currentTimeListExtractTime; // 0x15C
	public float ElapsedTime; // 0x160
	public float WaitTime; // 0x164
	public int ArriveTime; // 0x168
	public float _walkSpeed; // 0x16C
	public ConflictSpeedType conflictSpeedType; // 0x170
	public float arriveDistance; // 0x174
	public int StayStartTime; // 0x178
	public int NpcStayTime; // 0x17C
	public float StoppingTime; // 0x180
	public bool IsStandup; // 0x184
	[HeaderAttribute] // RVA: 0x16B2D0 Offset: 0x16B3D1 VA: 0x16B2D0
	public bool IsConflict; // 0x185
	public bool IsNpcConflict; // 0x186
	public bool IsAlreadyNpcConflict; // 0x187
	public List<CharacterBase> ConflictCharacters; // 0x188
	public float TotalConflictTime; // 0x190
	public float NpcConflictTime; // 0x194
	public LookAtTargetType LookAtTargetType; // 0x198
	[HideInInspector] // RVA: 0x16B310 Offset: 0x16B411 VA: 0x16B310
	private Vector3 avoidPosition; // 0x19C
	[HeaderAttribute] // RVA: 0x16B320 Offset: 0x16B421 VA: 0x16B320
	public bool MotionCancel; // 0x1A8
	public LookAtState _lookAtState; // 0x1AC
	public bool _IsTalking; // 0x1B0
	public bool IsFirstRotate; // 0x1B1
	public bool IsFirstMoveRotate; // 0x1B2
	public bool IsLookTarget; // 0x1B3
	public int _TodayTalkCount; // 0x1B4
	public int _NowEventId; // 0x1B8
	[HeaderAttribute] // RVA: 0x16B360 Offset: 0x16B461 VA: 0x16B360
	public Place CurrentEatPlace; // 0x1BC
	public Place _Home; // 0x1C0
	public Place _Job; // 0x1C4
	public NpcStatusData statusData; // 0x1C8
	private NpcPatrolPointMotionData npcPatrolPointMotionData; // 0x1D0
	public Weather CheckedWeather; // 0x1D8
	public int CheckedNpcTimeActionTime; // 0x1DC
	public float TargetNaviSpeed; // 0x1E0
	public float CurrentNaviSpeed; // 0x1E4
	public float diffSpeed; // 0x1E8
	public int SlowDownTime; // 0x1EC
	public bool IsDeletedModel; // 0x1F0
	public bool standby; // 0x1F1
	public NpcFadeState fadeState; // 0x1F4
	public float CurrentFadeAlpha; // 0x1F8
	[HideInInspector] // RVA: 0x16B3A0 Offset: 0x16B4A1 VA: 0x16B3A0
	private IEnumerator iEnumerator; // 0x200
	[HideInInspector] // RVA: 0x16B3B0 Offset: 0x16B4B1 VA: 0x16B3B0
	public bool IsPartnerToNpcSettingCalled; // 0x208
	public NpcLifeCycleDataManager LifeCycleData; // 0x210
	private bool IsReady; // 0x218
	private IEnumerator iEnumeratorSlowDown; // 0x220
	public NpcMoveControl TargetActor; // 0x228
	[SerializeField] // RVA: 0x16B3C0 Offset: 0x16B4C1 VA: 0x16B3C0
	private SpeedData[] MoveSpeedTable; // 0x230
	[SerializeField] // RVA: 0x16B3D0 Offset: 0x16B4D1 VA: 0x16B3D0
	private SPEED MoveSpeed; // 0x238
	public bool IsShortPlayFromCommonDate; // 0x23C
	public bool IsShortPlayFromPartner; // 0x23D
	public VariationNo variationNo; // 0x240
	public VariationNo changeVariationNo; // 0x244
	private NavMeshPath path; // 0x248
	private Vector3[] corners; // 0x250
	public bool pathPending; // 0x258
	public LifeCycleAdvMain lifeCycleAdvMain; // 0x260
	private bool IsOpenDoor; // 0x268
	public bool HaveItemFailed; // 0x269
	public bool _IsDateReserved; // 0x26A
	public int _dateDay; // 0x26C
	public bool _IsPartner; // 0x270
	private static Dictionary<ActorID, Master> patrolPointLoadIds; // 0x0
	public bool ForceEnable; // 0x271

	// Properties
	public bool forceDisabled { get; set; }
	public bool IsShortPlay { get; set; }
	public bool IsStop { get; set; }
	public bool IsSlowDown { get; set; }
	public NpcAnimState AnimationState { get; set; }
	public bool AnimationSitting { get; set; }
	public Vector3 SavePosition { get; set; }
	public Quaternion SaveRotation { get; set; }
	public int NpcGroupId { get; set; }
	public bool IsReached { get; set; }
	public Weather HomeBackWeather { get; set; }
	public FieldPlaceId CurrentFieldPlaceId { get; set; }
	public GameObject NextPatrolPoint { get; set; }
	public int CurrentLifecycleTime { get; set; }
	public LifecycleState CurrentLifecycleState { get; set; }
	public Place CurrentPlace { get; set; }
	public Place TargetPlace { get; set; }
	public NpcPatrolPoint SeatPatrolPoint { get; set; }
	public GameObject targetDoor { get; set; }
	public int RotatePatternNumber { get; set; }
	public float walkSpeed { get; set; }
	public LookAtState lookAtState { get; set; }
	public bool IsTalking { get; set; }
	public int TodayTalkCount { get; set; }
	public int NowEventId { get; set; }
	public Place Home { get; set; }
	public Place Job { get; set; }
	private Place[] FavoritePlace { get; }
	public bool IsControllerWaitPrepare { get; }
	public bool IsDateReserved { get; set; }
	public int dateDay { get; set; }
	public bool CheckNpcSaveParameters { get; }
	public NpcSaveParameter NpcSaveParameters { get; }
	public List<LovePointManager.FavoriteType> PresentItemTypes { get; set; }
	public bool IsPartner { get; set; }
	public bool IsSpouses { get; set; }
	public bool IsLover { get; set; }
	public bool IsRefused { get; set; }
	public bool IsJealousy { get; set; }
	public bool IsDateRefrain { get; set; }
	public bool IsExclamation { get; set; }
	public int AngryStep { get; set; }
	public int LovePoint { get; set; }
	public int DatingNum { get; set; }
	public int PresentCount { get; set; }
	public int NickNameToPlayerId { get; set; }
	public int NickNameFromPlayerId { get; set; }
	public int WeddingAnniversary { get; set; }
	public bool IsVoiceSleepPlayed { get; set; }
	public bool IsVoiceGreeted { get; set; }
	public long[] TalkedTime { get; set; }
	public int FriendlyMilestoneTalk { get; set; }
	public int ChatTalkLv { get; set; }
	public int ChatTalkCount { get; set; }
	public int ChatTalkLotteryType { get; set; }
	public int ChatTalkLotteryID { get; set; }
	public int HomeTalkedLv { get; set; }
	public int LoveStroyState { get; set; }
	public bool IsWeddingAnniversary { get; }
	public bool IsShopOpend { get; }
	public bool IsMob { get; }
	public bool IsHomeBack { get; }
	public bool IsAlreadySleep { get; }
	public HairType HairType { get; }
	public bool IconEnabled { get; }
	public bool IsExsitNpc { get; }
	public bool IsOuting { get; }
	public bool IsInHospital { get; }

	// Methods

	// RVA: 0x23EB0B0 Offset: 0x23EB1B1 VA: 0x23EB0B0
	public void SetNpcController(NpcController npcController) { }

	// RVA: 0x23EB0C0 Offset: 0x23EB1C1 VA: 0x23EB0C0
	public bool get_forceDisabled() { }

	// RVA: 0x23EB0D0 Offset: 0x23EB1D1 VA: 0x23EB0D0
	public void set_forceDisabled(bool value) { }

	// RVA: 0x23EB0E0 Offset: 0x23EB1E1 VA: 0x23EB0E0
	public bool get_IsShortPlay() { }

	// RVA: 0x23EB0F0 Offset: 0x23EB1F1 VA: 0x23EB0F0
	public void set_IsShortPlay(bool value) { }

	// RVA: 0x23EB1F0 Offset: 0x23EB2F1 VA: 0x23EB1F0
	public bool get_IsStop() { }

	// RVA: 0x23EB200 Offset: 0x23EB301 VA: 0x23EB200
	public void set_IsStop(bool value) { }

	// RVA: 0x23EB350 Offset: 0x23EB451 VA: 0x23EB350
	public bool get_IsSlowDown() { }

	// RVA: 0x23EB360 Offset: 0x23EB461 VA: 0x23EB360
	public void set_IsSlowDown(bool value) { }

	// RVA: 0x23EB4B0 Offset: 0x23EB5B1 VA: 0x23EB4B0
	public NpcAnimState get_AnimationState() { }

	// RVA: 0x23EB4C0 Offset: 0x23EB5C1 VA: 0x23EB4C0
	public void set_AnimationState(NpcAnimState value) { }

	// RVA: 0x23EB5E0 Offset: 0x23EB6E1 VA: 0x23EB5E0
	public bool get_AnimationSitting() { }

	// RVA: 0x23EB5F0 Offset: 0x23EB6F1 VA: 0x23EB5F0
	public void set_AnimationSitting(bool value) { }

	// RVA: 0x23EB600 Offset: 0x23EB701 VA: 0x23EB600
	public Vector3 get_SavePosition() { }

	// RVA: 0x23EB630 Offset: 0x23EB731 VA: 0x23EB630
	public void set_SavePosition(Vector3 value) { }

	// RVA: 0x23EB680 Offset: 0x23EB781 VA: 0x23EB680
	public Quaternion get_SaveRotation() { }

	// RVA: 0x23EB6B0 Offset: 0x23EB7B1 VA: 0x23EB6B0
	public void set_SaveRotation(Quaternion value) { }

	// RVA: 0x23EB700 Offset: 0x23EB801 VA: 0x23EB700
	public int get_NpcGroupId() { }

	// RVA: 0x23EB710 Offset: 0x23EB811 VA: 0x23EB710
	public void set_NpcGroupId(int value) { }

	// RVA: 0x23EB720 Offset: 0x23EB821 VA: 0x23EB720
	public bool get_IsReached() { }

	// RVA: 0x23EB730 Offset: 0x23EB831 VA: 0x23EB730
	public void set_IsReached(bool value) { }

	// RVA: 0x23EB880 Offset: 0x23EB981 VA: 0x23EB880
	public Weather get_HomeBackWeather() { }

	// RVA: 0x23EB890 Offset: 0x23EB991 VA: 0x23EB890
	public void set_HomeBackWeather(Weather value) { }

	// RVA: 0x23EB8A0 Offset: 0x23EB9A1 VA: 0x23EB8A0
	public FieldPlaceId get_CurrentFieldPlaceId() { }

	// RVA: 0x23EB8B0 Offset: 0x23EB9B1 VA: 0x23EB8B0
	public void set_CurrentFieldPlaceId(FieldPlaceId value) { }

	// RVA: 0x23EB8C0 Offset: 0x23EB9C1 VA: 0x23EB8C0
	public GameObject get_NextPatrolPoint() { }

	// RVA: 0x23EB8D0 Offset: 0x23EB9D1 VA: 0x23EB8D0
	public void set_NextPatrolPoint(GameObject value) { }

	// RVA: 0x23EB8E0 Offset: 0x23EB9E1 VA: 0x23EB8E0
	public int get_CurrentLifecycleTime() { }

	// RVA: 0x23EB8F0 Offset: 0x23EB9F1 VA: 0x23EB8F0
	public void set_CurrentLifecycleTime(int value) { }

	// RVA: 0x23EB900 Offset: 0x23EBA01 VA: 0x23EB900
	public LifecycleState get_CurrentLifecycleState() { }

	// RVA: 0x23EB910 Offset: 0x23EBA11 VA: 0x23EB910
	public void set_CurrentLifecycleState(LifecycleState value) { }

	// RVA: 0x23EB920 Offset: 0x23EBA21 VA: 0x23EB920
	public Place get_CurrentPlace() { }

	// RVA: 0x23EB930 Offset: 0x23EBA31 VA: 0x23EB930
	public void set_CurrentPlace(Place value) { }

	// RVA: 0x23EB940 Offset: 0x23EBA41 VA: 0x23EB940
	public Place get_TargetPlace() { }

	// RVA: 0x23EB950 Offset: 0x23EBA51 VA: 0x23EB950
	public void set_TargetPlace(Place value) { }

	// RVA: 0x23EB960 Offset: 0x23EBA61 VA: 0x23EB960
	public NpcPatrolPoint get_SeatPatrolPoint() { }

	// RVA: 0x23EB970 Offset: 0x23EBA71 VA: 0x23EB970
	public void set_SeatPatrolPoint(NpcPatrolPoint value) { }

	// RVA: 0x23EBA50 Offset: 0x23EBB51 VA: 0x23EBA50
	public GameObject get_targetDoor() { }

	// RVA: 0x23EBA60 Offset: 0x23EBB61 VA: 0x23EBA60
	public void set_targetDoor(GameObject value) { }

	// RVA: 0x23EBB40 Offset: 0x23EBC41 VA: 0x23EBB40
	public int get_RotatePatternNumber() { }

	// RVA: 0x23EBB50 Offset: 0x23EBC51 VA: 0x23EBB50
	public void set_RotatePatternNumber(int value) { }

	// RVA: 0x23EBB60 Offset: 0x23EBC61 VA: 0x23EBB60
	public float get_walkSpeed() { }

	// RVA: 0x23EBB70 Offset: 0x23EBC71 VA: 0x23EBB70
	public void set_walkSpeed(float value) { }

	// RVA: 0x23EBB80 Offset: 0x23EBC81 VA: 0x23EBB80
	public LookAtState get_lookAtState() { }

	// RVA: 0x23EBB90 Offset: 0x23EBC91 VA: 0x23EBB90
	public void set_lookAtState(LookAtState value) { }

	// RVA: 0x23EBBA0 Offset: 0x23EBCA1 VA: 0x23EBBA0
	public bool get_IsTalking() { }

	// RVA: 0x23EBBB0 Offset: 0x23EBCB1 VA: 0x23EBBB0
	public void set_IsTalking(bool value) { }

	// RVA: 0x23EBBC0 Offset: 0x23EBCC1 VA: 0x23EBBC0
	public int get_TodayTalkCount() { }

	// RVA: 0x23EBBD0 Offset: 0x23EBCD1 VA: 0x23EBBD0
	public void set_TodayTalkCount(int value) { }

	// RVA: 0x23EBBE0 Offset: 0x23EBCE1 VA: 0x23EBBE0
	public int get_NowEventId() { }

	// RVA: 0x23EBBF0 Offset: 0x23EBCF1 VA: 0x23EBBF0
	public void set_NowEventId(int value) { }

	// RVA: 0x23EBC00 Offset: 0x23EBD01 VA: 0x23EBC00
	public Place get_Home() { }

	// RVA: 0x23EBC10 Offset: 0x23EBD11 VA: 0x23EBC10
	public void set_Home(Place value) { }

	// RVA: 0x23EBC20 Offset: 0x23EBD21 VA: 0x23EBC20
	public Place get_Job() { }

	// RVA: 0x23EBC30 Offset: 0x23EBD31 VA: 0x23EBC30
	public void set_Job(Place value) { }

	// RVA: 0x23EBC40 Offset: 0x23EBD41 VA: 0x23EBC40
	private Place[] get_FavoritePlace() { }

	// RVA: 0x23EBCF0 Offset: 0x23EBDF1 VA: 0x23EBCF0
	public bool get_IsControllerWaitPrepare() { }

	// RVA: 0x23EBD90 Offset: 0x23EBE91 VA: 0x23EBD90
	public bool get_IsDateReserved() { }

	// RVA: 0x23EBDA0 Offset: 0x23EBEA1 VA: 0x23EBDA0
	public void set_IsDateReserved(bool value) { }

	// RVA: 0x23EBDB0 Offset: 0x23EBEB1 VA: 0x23EBDB0
	public int get_dateDay() { }

	// RVA: 0x23EBDC0 Offset: 0x23EBEC1 VA: 0x23EBDC0
	public void set_dateDay(int value) { }

	// RVA: 0x23EBDD0 Offset: 0x23EBED1 VA: 0x23EBDD0
	public bool get_CheckNpcSaveParameters() { }

	// RVA: 0x23EB140 Offset: 0x23EB241 VA: 0x23EB140
	public NpcSaveParameter get_NpcSaveParameters() { }

	// RVA: 0x23EBE90 Offset: 0x23EBF91 VA: 0x23EBE90
	public List<LovePointManager.FavoriteType> get_PresentItemTypes() { }

	// RVA: 0x23EBEB0 Offset: 0x23EBFB1 VA: 0x23EBEB0
	public void set_PresentItemTypes(List<LovePointManager.FavoriteType> value) { }

	// RVA: 0x23EBEE0 Offset: 0x23EBFE1 VA: 0x23EBEE0
	public bool get_IsPartner() { }

	// RVA: 0x23EBEF0 Offset: 0x23EBFF1 VA: 0x23EBEF0
	public void set_IsPartner(bool value) { }

	// RVA: 0x23EBF20 Offset: 0x23EC021 VA: 0x23EBF20
	public bool get_IsSpouses() { }

	// RVA: 0x23EBF40 Offset: 0x23EC041 VA: 0x23EBF40
	public void set_IsSpouses(bool value) { }

	// RVA: 0x23EBF70 Offset: 0x23EC071 VA: 0x23EBF70
	public bool get_IsLover() { }

	// RVA: 0x23EBF90 Offset: 0x23EC091 VA: 0x23EBF90
	public void set_IsLover(bool value) { }

	// RVA: 0x23EBFC0 Offset: 0x23EC0C1 VA: 0x23EBFC0
	public bool get_IsRefused() { }

	// RVA: 0x23EBFE0 Offset: 0x23EC0E1 VA: 0x23EBFE0
	public void set_IsRefused(bool value) { }

	// RVA: 0x23EC010 Offset: 0x23EC111 VA: 0x23EC010
	public bool get_IsJealousy() { }

	// RVA: 0x23EC030 Offset: 0x23EC131 VA: 0x23EC030
	public void set_IsJealousy(bool value) { }

	// RVA: 0x23EC060 Offset: 0x23EC161 VA: 0x23EC060
	public bool get_IsDateRefrain() { }

	// RVA: 0x23EC080 Offset: 0x23EC181 VA: 0x23EC080
	public void set_IsDateRefrain(bool value) { }

	// RVA: 0x23EC0B0 Offset: 0x23EC1B1 VA: 0x23EC0B0
	public bool get_IsExclamation() { }

	// RVA: 0x23EC0D0 Offset: 0x23EC1D1 VA: 0x23EC0D0
	public void set_IsExclamation(bool value) { }

	// RVA: 0x23EC100 Offset: 0x23EC201 VA: 0x23EC100
	public int get_AngryStep() { }

	// RVA: 0x23EC120 Offset: 0x23EC221 VA: 0x23EC120
	public void set_AngryStep(int value) { }

	// RVA: 0x23EC150 Offset: 0x23EC251 VA: 0x23EC150
	public int get_LovePoint() { }

	// RVA: 0x23EC170 Offset: 0x23EC271 VA: 0x23EC170
	public void set_LovePoint(int value) { }

	// RVA: 0x23EC1A0 Offset: 0x23EC2A1 VA: 0x23EC1A0
	public int get_DatingNum() { }

	// RVA: 0x23EC1C0 Offset: 0x23EC2C1 VA: 0x23EC1C0
	public void set_DatingNum(int value) { }

	// RVA: 0x23EC280 Offset: 0x23EC381 VA: 0x23EC280
	public int get_PresentCount() { }

	// RVA: 0x23EC2A0 Offset: 0x23EC3A1 VA: 0x23EC2A0
	public void set_PresentCount(int value) { }

	// RVA: 0x23EC2D0 Offset: 0x23EC3D1 VA: 0x23EC2D0
	public int get_NickNameToPlayerId() { }

	// RVA: 0x23EC2F0 Offset: 0x23EC3F1 VA: 0x23EC2F0
	public void set_NickNameToPlayerId(int value) { }

	// RVA: 0x23EC320 Offset: 0x23EC421 VA: 0x23EC320
	public int get_NickNameFromPlayerId() { }

	// RVA: 0x23EC340 Offset: 0x23EC441 VA: 0x23EC340
	public void set_NickNameFromPlayerId(int value) { }

	// RVA: 0x23EC370 Offset: 0x23EC471 VA: 0x23EC370
	public int get_WeddingAnniversary() { }

	// RVA: 0x23EC390 Offset: 0x23EC491 VA: 0x23EC390
	public void set_WeddingAnniversary(int value) { }

	// RVA: 0x23EC3C0 Offset: 0x23EC4C1 VA: 0x23EC3C0
	public bool get_IsVoiceSleepPlayed() { }

	// RVA: 0x23EC3E0 Offset: 0x23EC4E1 VA: 0x23EC3E0
	public void set_IsVoiceSleepPlayed(bool value) { }

	// RVA: 0x23EC410 Offset: 0x23EC511 VA: 0x23EC410
	public bool get_IsVoiceGreeted() { }

	// RVA: 0x23EC430 Offset: 0x23EC531 VA: 0x23EC430
	public void set_IsVoiceGreeted(bool value) { }

	// RVA: 0x23EC460 Offset: 0x23EC561 VA: 0x23EC460
	public long[] get_TalkedTime() { }

	// RVA: 0x23EC480 Offset: 0x23EC581 VA: 0x23EC480
	public void set_TalkedTime(long[] value) { }

	// RVA: 0x23EC4B0 Offset: 0x23EC5B1 VA: 0x23EC4B0
	public int get_FriendlyMilestoneTalk() { }

	// RVA: 0x23EC4D0 Offset: 0x23EC5D1 VA: 0x23EC4D0
	public void set_FriendlyMilestoneTalk(int value) { }

	// RVA: 0x23EC500 Offset: 0x23EC601 VA: 0x23EC500
	public int get_ChatTalkLv() { }

	// RVA: 0x23EC520 Offset: 0x23EC621 VA: 0x23EC520
	public void set_ChatTalkLv(int value) { }

	// RVA: 0x23EC550 Offset: 0x23EC651 VA: 0x23EC550
	public int get_ChatTalkCount() { }

	// RVA: 0x23EC570 Offset: 0x23EC671 VA: 0x23EC570
	public void set_ChatTalkCount(int value) { }

	// RVA: 0x23EC5A0 Offset: 0x23EC6A1 VA: 0x23EC5A0
	public int get_ChatTalkLotteryType() { }

	// RVA: 0x23EC5C0 Offset: 0x23EC6C1 VA: 0x23EC5C0
	public void set_ChatTalkLotteryType(int value) { }

	// RVA: 0x23EC5F0 Offset: 0x23EC6F1 VA: 0x23EC5F0
	public int get_ChatTalkLotteryID() { }

	// RVA: 0x23EC610 Offset: 0x23EC711 VA: 0x23EC610
	public void set_ChatTalkLotteryID(int value) { }

	// RVA: 0x23EC640 Offset: 0x23EC741 VA: 0x23EC640
	public int get_HomeTalkedLv() { }

	// RVA: 0x23EC660 Offset: 0x23EC761 VA: 0x23EC660
	public void set_HomeTalkedLv(int value) { }

	// RVA: 0x23EC690 Offset: 0x23EC791 VA: 0x23EC690
	public int get_LoveStroyState() { }

	// RVA: 0x23EC6B0 Offset: 0x23EC7B1 VA: 0x23EC6B0
	public void set_LoveStroyState(int value) { }

	// RVA: 0x23EC6E0 Offset: 0x23EC7E1 VA: 0x23EC6E0
	private bool IsTalked(TimeManager.RFTimeInt talkTime) { }

	// RVA: 0x23EC810 Offset: 0x23EC911 VA: 0x23EC810
	private bool IsTodayTalked(TimeManager.RFTimeInt talkTime) { }

	// RVA: 0x23EC8A0 Offset: 0x23EC9A1 VA: 0x23EC8A0
	public bool IsLongtimeTalk() { }

	// RVA: 0x23EC9B0 Offset: 0x23ECAB1 VA: 0x23EC9B0
	public bool IsTalked(NpcTalkedType type) { }

	// RVA: 0x23ECA00 Offset: 0x23ECB01 VA: 0x23ECA00
	public bool IsTodayTalked(NpcTalkedType type) { }

	// RVA: 0x23ECAC0 Offset: 0x23ECBC1 VA: 0x23ECAC0
	public bool IsTalkedOne(NpcTalkedType type) { }

	// RVA: 0x23ECB20 Offset: 0x23ECC21 VA: 0x23ECB20
	public void SetTalkedTime(NpcTalkedType type, TimeManager.RFTimeInt timeInt) { }

	// RVA: 0x23ECB80 Offset: 0x23ECC81 VA: 0x23ECB80
	public bool get_IsWeddingAnniversary() { }

	// RVA: 0x23ECCA0 Offset: 0x23ECDA1 VA: 0x23ECCA0
	public bool get_IsShopOpend() { }

	// RVA: 0x23ECDE0 Offset: 0x23ECEE1 VA: 0x23ECDE0
	public bool get_IsMob() { }

	// RVA: 0x23ECDF0 Offset: 0x23ECEF1 VA: 0x23ECDF0
	public bool get_IsHomeBack() { }

	// RVA: 0x23ECE00 Offset: 0x23ECF01 VA: 0x23ECE00
	public bool get_IsAlreadySleep() { }

	// RVA: 0x23ECE30 Offset: 0x23ECF31 VA: 0x23ECE30
	public HairType get_HairType() { }

	// RVA: 0x23ED1F0 Offset: 0x23ED2F1 VA: 0x23ED1F0
	public bool get_IconEnabled() { }

	// RVA: 0x23ED430 Offset: 0x23ED531 VA: 0x23ED430
	public bool get_IsExsitNpc() { }

	// RVA: 0x23ED3A0 Offset: 0x23ED4A1 VA: 0x23ED3A0
	public bool get_IsOuting() { }

	// RVA: 0x23ED550 Offset: 0x23ED651 VA: 0x23ED550
	public bool get_IsInHospital() { }

	// RVA: 0x23ED5E0 Offset: 0x23ED6E1 VA: 0x23ED5E0
	public bool CanTalkEndRotation() { }

	// RVA: 0x23ED640 Offset: 0x23ED741 VA: 0x23ED640
	public bool CheckAnimationStateTurnAround() { }

	// RVA: 0x23ED680 Offset: 0x23ED781 VA: 0x23ED680
	public Actor CreateActor() { }

	// RVA: 0x23ED730 Offset: 0x23ED831 VA: 0x23ED730
	public void DeleteNpc() { }

	// RVA: 0x23EDB20 Offset: 0x23EDC21 VA: 0x23EDB20
	public void ResetDateAction() { }

	// RVA: 0x23EDC00 Offset: 0x23EDD01 VA: 0x23EDC00
	public void ResetAction() { }

	// RVA: 0x23EDD70 Offset: 0x23EDE71 VA: 0x23EDD70
	public void SetStandbyPositionRotation(Transform srcTrans) { }

	// RVA: 0x23EDDD0 Offset: 0x23EDED1 VA: 0x23EDDD0
	public void SetStandbyAnimationState() { }

	// RVA: 0x23EDDE0 Offset: 0x23EDEE1 VA: 0x23EDDE0
	public void SaveNpcPositionData() { }

	// RVA: 0x23EDF70 Offset: 0x23EE071 VA: 0x23EDF70
	public void BeforeSaveNpcData() { }

	// RVA: 0x23EE140 Offset: 0x23EE241 VA: 0x23EE140
	public void AfterLoadNpcData() { }

	// RVA: 0x23EE3E0 Offset: 0x23EE4E1 VA: 0x23EE3E0
	public void SetRotatePointForUpdateSimulatePosition(GameObject npcPatrolPoints) { }

	// RVA: 0x23EE700 Offset: 0x23EE801 VA: 0x23EE700
	public void SetLifecycleForUpdateSimulatePosition(int _hour, int _minutes) { }

	// RVA: 0x23EF7A0 Offset: 0x23EF8A1 VA: 0x23EF7A0
	public void SetControllerWaitPrepare() { }

	// RVA: 0x23EF840 Offset: 0x23EF941 VA: 0x23EF840
	public void ForceControllerPrepared() { }

	// RVA: 0x23EF8E0 Offset: 0x23EF9E1 VA: 0x23EF8E0
	public void InitializeForLifeCycle(GameObject npcDataGameObject) { }

	// RVA: 0x23EFB10 Offset: 0x23EFC11 VA: 0x23EFB10
	private bool IsRotateWalk() { }

	// RVA: 0x23EFB20 Offset: 0x23EFC21 VA: 0x23EFB20
	public void RemoveResources() { }

	// RVA: 0x23EFB40 Offset: 0x23EFC41 VA: 0x23EFB40
	public void FadeInStandby() { }

	// RVA: 0x23EFBD0 Offset: 0x23EFCD1 VA: 0x23EFBD0
	public void SetFadeState(NpcFadeState _fadeState) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5DF0 Offset: 0x1A5EF1 VA: 0x1A5DF0
	// RVA: 0x23EFBE0 Offset: 0x23EFCE1 VA: 0x23EFBE0
	public IEnumerator FadeInOutNpc(UnityAction _fadeEndAction) { }

	// RVA: 0x23EFCB0 Offset: 0x23EFDB1 VA: 0x23EFCB0
	public void RefreshNpcFadeIn() { }

	// RVA: 0x23EFDE0 Offset: 0x23EFEE1 VA: 0x23EFDE0
	public void ForceNpcFadeIn() { }

	// RVA: 0x23EFEA0 Offset: 0x23EFFA1 VA: 0x23EFEA0
	public void UpdateMoveSpeed() { }

	// RVA: 0x23F0040 Offset: 0x23F0141 VA: 0x23F0040
	public void CalcMoveSpeed() { }

	// RVA: 0x23F0530 Offset: 0x23F0631 VA: 0x23F0530
	public bool CheckObjectEnabled() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5E60 Offset: 0x1A5F61 VA: 0x1A5E60
	// RVA: 0x23F0AB0 Offset: 0x23F0BB1 VA: 0x23F0AB0
	public IEnumerator WalkStop(float waitMinutes, int targetNpcId, bool firstMotion) { }

	// RVA: 0x23F0B90 Offset: 0x23F0C91 VA: 0x23F0B90
	public void SlowDown(float waitMinutes) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5ED0 Offset: 0x1A5FD1 VA: 0x1A5ED0
	// RVA: 0x23F0C30 Offset: 0x23F0D31 VA: 0x23F0C30
	public IEnumerator SlowDownStart(float waitMinutes) { }

	// RVA: 0x23F0CF0 Offset: 0x23F0DF1 VA: 0x23F0CF0
	public void SlowDownStart(ActorController character) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5F40 Offset: 0x1A6041 VA: 0x1A5F40
	// RVA: 0x23F10A0 Offset: 0x23F11A1 VA: 0x23F10A0
	public IEnumerator SlowDownEndStart() { }

	// RVA: 0x23F1150 Offset: 0x23F1251 VA: 0x23F1150
	public void SlowDownEnd() { }

	// RVA: 0x23F1300 Offset: 0x23F1401 VA: 0x23F1300
	public void Update() { }

	// RVA: 0x23F1410 Offset: 0x23F1511 VA: 0x23F1410
	private void UpdateNpcTime() { }

	// RVA: 0x23F1B70 Offset: 0x23F1C71 VA: 0x23F1B70
	public void SetNextState(LifecycleState nextState) { }

	// RVA: 0x23F1660 Offset: 0x23F1761 VA: 0x23F1660
	private bool ValidateTransition() { }

	// RVA: 0x23EF470 Offset: 0x23EF571 VA: 0x23EF470
	public bool UpdateCurrentLifecycleTime(int _hour, int _minutes) { }

	// RVA: 0x23F1980 Offset: 0x23F1A81 VA: 0x23F1980
	private void OnStateExit() { }

	// RVA: 0x23F1990 Offset: 0x23F1A91 VA: 0x23F1990
	private void OnStateEnter() { }

	// RVA: 0x23F1C30 Offset: 0x23F1D31 VA: 0x23F1C30
	private void OnEnterMove() { }

	// RVA: 0x23F20D0 Offset: 0x23F21D1 VA: 0x23F20D0
	private bool isSwimWearPlace(Place place) { }

	// RVA: 0x23F1C90 Offset: 0x23F1D91 VA: 0x23F1C90
	private void OnEnterReach() { }

	// RVA: 0x23F1C10 Offset: 0x23F1D11 VA: 0x23F1C10
	private void OnExitMove() { }

	// RVA: 0x23F1C20 Offset: 0x23F1D21 VA: 0x23F1C20
	private void OnExitReach() { }

	// RVA: 0x23F1D20 Offset: 0x23F1E21 VA: 0x23F1D20
	private void StandUpAction() { }

	// RVA: 0x23F3610 Offset: 0x23F3711 VA: 0x23F3610
	private void CheckNpcHurry(bool IsDoorOut = False) { }

	// RVA: 0x23F2A80 Offset: 0x23F2B81 VA: 0x23F2A80
	private LifecycleState GetMovingLifeCycle(LifecycleState lifecycleState) { }

	// RVA: 0x23F38A0 Offset: 0x23F39A1 VA: 0x23F38A0
	public void StandupFadeOutEnd() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5FB0 Offset: 0x1A60B1 VA: 0x1A5FB0
	// RVA: 0x23F3980 Offset: 0x23F3A81 VA: 0x23F3980
	private IEnumerator StandupFadeIn() { }

	// RVA: 0x23ED740 Offset: 0x23ED841 VA: 0x23ED740
	public void ItemClear() { }

	// RVA: 0x23F1A90 Offset: 0x23F1B91 VA: 0x23F1A90
	private void UpdateLifeCycle() { }

	// RVA: 0x23F2120 Offset: 0x23F2221 VA: 0x23F2120
	public void InitAction() { }

	// RVA: 0x23F0390 Offset: 0x23F0491 VA: 0x23F0390
	public bool CanMove() { }

	// RVA: 0x23F2FD0 Offset: 0x23F30D1 VA: 0x23F2FD0
	private void StartPoint() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A6020 Offset: 0x1A6121 VA: 0x1A6020
	// RVA: 0x23F3FD0 Offset: 0x23F40D1 VA: 0x23F3FD0
	private IEnumerator OpenDoor() { }

	// RVA: 0x23F0460 Offset: 0x23F0561 VA: 0x23F0460
	private void ResetMotionSpeed() { }

	// RVA: 0x23F4080 Offset: 0x23F4181 VA: 0x23F4080
	private void ArrivePoint() { }

	// RVA: 0x23F4E20 Offset: 0x23F4F21 VA: 0x23F4E20
	public bool CheckHotelStairs() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A6090 Offset: 0x1A6191 VA: 0x1A6090
	// RVA: 0x23F2F50 Offset: 0x23F3051 VA: 0x23F2F50
	private IEnumerator ArriveAction() { }

	// RVA: 0x23EE910 Offset: 0x23EEA11 VA: 0x23EE910
	public void ChangeArriveState() { }

	// RVA: 0x23F51B0 Offset: 0x23F52B1 VA: 0x23F51B0
	private void FadeOutEnd() { }

	// RVA: 0x23EF2D0 Offset: 0x23EF3D1 VA: 0x23EF2D0
	public void SetLookAtWithNpc() { }

	// RVA: 0x23F37A0 Offset: 0x23F38A1 VA: 0x23F37A0
	public bool CheckWeatherRain() { }

	// RVA: 0x23F5720 Offset: 0x23F5821 VA: 0x23F5720
	public bool CheckWeatherSunny() { }

	// RVA: 0x23F5790 Offset: 0x23F5891 VA: 0x23F5790
	public bool CheckWeatherSnow() { }

	// RVA: 0x23F3810 Offset: 0x23F3911 VA: 0x23F3810
	public bool CheckWeatherTyphoon() { }

	// RVA: 0x23F3A30 Offset: 0x23F3B31 VA: 0x23F3A30
	private void UpdateMoveAction() { }

	// RVA: 0x23F3B70 Offset: 0x23F3C71 VA: 0x23F3B70
	private void UpdateReachAction() { }

	// RVA: 0x23F2850 Offset: 0x23F2951 VA: 0x23F2850
	private void CheckReachPoint() { }

	// RVA: 0x23F1760 Offset: 0x23F1861 VA: 0x23F1760
	private void ShiftNextSimulateState() { }

	// RVA: 0x23F14D0 Offset: 0x23F15D1 VA: 0x23F14D0
	private LifecycleState GetNextSimulateState(int NpcId) { }

	// RVA: 0x23F2230 Offset: 0x23F2331 VA: 0x23F2230
	public NpcTimeAction GetCurrentTimeAction(int hour, int minutes) { }

	// RVA: 0x23F6560 Offset: 0x23F6661 VA: 0x23F6560
	public NpcTimeAction CreateLastTimeAction() { }

	// RVA: 0x23F6830 Offset: 0x23F6931 VA: 0x23F6830
	public NpcTimeAction GetNextTimeAction(int hour, int minutes) { }

	// RVA: 0x23F6980 Offset: 0x23F6A81 VA: 0x23F6980
	public int GetPrevTime(int hour, int minutes) { }

	// RVA: 0x23F6B20 Offset: 0x23F6C21 VA: 0x23F6B20
	public NpcTimeAction CreateUnscheduledTimeAction(int hour, int minutes, Weather weather) { }

	// RVA: 0x23F2550 Offset: 0x23F2651 VA: 0x23F2550
	public NpcTimeAction GetUnscheduledCurrentTimeAction(int hour, int minutes) { }

	// RVA: 0x23F5800 Offset: 0x23F5901 VA: 0x23F5800
	private void UpdateLifeCycleMoving() { }

	// RVA: 0x23F5E40 Offset: 0x23F5F41 VA: 0x23F5E40
	private void UpdateAvoidConflict() { }

	// RVA: 0x23EEC30 Offset: 0x23EED31 VA: 0x23EEC30
	public void SetSeatRotation() { }

	// RVA: 0x23F7A10 Offset: 0x23F7B11 VA: 0x23F7A10
	public Place WakeUpAction(int hour, int minutes) { }

	// RVA: 0x23F7B90 Offset: 0x23F7C91 VA: 0x23F7B90
	public Place EatAction(int hour, int minutes) { }

	// RVA: 0x23F7E20 Offset: 0x23F7F21 VA: 0x23F7E20
	public Place WorkingAction(int hour, int minutes) { }

	// RVA: 0x23F7F80 Offset: 0x23F8081 VA: 0x23F7F80
	public Place BathTimeAction(int hour, int minutes) { }

	// RVA: 0x23F8180 Offset: 0x23F8281 VA: 0x23F8180
	public Place FreeTimeAction(int EventId, int hour, int minutes) { }

	// RVA: 0x23F84C0 Offset: 0x23F85C1 VA: 0x23F84C0
	public Place HomeTimeAction(int hour, int minutes) { }

	// RVA: 0x23F8570 Offset: 0x23F8671 VA: 0x23F8570
	public Place SleepAction(int hour, int minutes) { }

	// RVA: 0x23F7460 Offset: 0x23F7561 VA: 0x23F7460
	public NpcPatrolPoint GetBathPoint() { }

	// RVA: 0x23F8710 Offset: 0x23F8811 VA: 0x23F8710
	public bool DecideSimulateTargetRoute() { }

	// RVA: 0x23F2AF0 Offset: 0x23F2BF1 VA: 0x23F2AF0
	public bool DecideTargetRoute() { }

	// RVA: 0x23F3D20 Offset: 0x23F3E21 VA: 0x23F3D20
	public string GetTargetPointName(string TargetSeatName) { }

	// RVA: 0x23F4D40 Offset: 0x23F4E41 VA: 0x23F4D40
	public NpcPatrolPoint GetTargetPoint() { }

	// RVA: 0x23EE810 Offset: 0x23EE911 VA: 0x23EE810
	public LifecycleState GetNextState(int hour, int minutes) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A6100 Offset: 0x1A6201 VA: 0x1A6100
	// RVA: 0x23F8B90 Offset: 0x23F8C91 VA: 0x23F8B90
	public IEnumerator TyphoonAction() { }

	// RVA: 0x23F5F30 Offset: 0x23F6031 VA: 0x23F5F30
	public void CheckWeatherAction(HomeBackType homeBackType) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A6170 Offset: 0x1A6271 VA: 0x1A6170
	// RVA: 0x23F8C40 Offset: 0x23F8D41 VA: 0x23F8C40
	private IEnumerator RainBackWaitAction(HomeBackType homeBackType) { }

	// RVA: 0x23F8D00 Offset: 0x23F8E01 VA: 0x23F8D00
	public void RainBackAction(HomeBackType homeBackType) { }

	// RVA: 0x23F4A70 Offset: 0x23F4B71 VA: 0x23F4A70
	private bool SwitchNextPatrolPointForRotate() { }

	// RVA: 0x23F8E40 Offset: 0x23F8F41 VA: 0x23F8E40
	private string[] ChangeRouteToNextTargetPoint(NpcTimeAction NpcTimeAction) { }

	// RVA: 0x23F9290 Offset: 0x23F9391 VA: 0x23F9290
	public int GetCurrentStateRemainingTime(int hour, int minutes) { }

	// RVA: 0x23F92A0 Offset: 0x23F93A1 VA: 0x23F92A0
	public LifecycleState GetCurrentState(int hour, int minutes) { }

	// RVA: 0x23F92B0 Offset: 0x23F93B1 VA: 0x23F92B0
	public void SetStartPoint() { }

	// RVA: 0x23F23A0 Offset: 0x23F24A1 VA: 0x23F23A0
	public void SetCurrentTimeAction(NpcTimeAction npcCurrentTimeAction) { }

	// RVA: 0x23F97F0 Offset: 0x23F98F1 VA: 0x23F97F0
	public void releasePoint() { }

	// RVA: 0x23F9AA0 Offset: 0x23F9BA1 VA: 0x23F9AA0
	public void WakeupParamSetting() { }

	// RVA: 0x23F0510 Offset: 0x23F0611 VA: 0x23F0510
	public void NavMeshStop(bool stop) { }

	// RVA: 0x23F9D40 Offset: 0x23F9E41 VA: 0x23F9D40
	public void NavMeshIdle() { }

	// RVA: 0x23F03F0 Offset: 0x23F04F1 VA: 0x23F03F0
	public void NavMeshSetDestination(Vector3 position) { }

	// RVA: 0x23F3EF0 Offset: 0x23F3FF1 VA: 0x23F3EF0
	public void SetTargetPosition(Vector3 position) { }

	// RVA: 0x23F7600 Offset: 0x23F7701 VA: 0x23F7600
	public void MoveNavTarget() { }

	// RVA: 0x23F76A0 Offset: 0x23F77A1 VA: 0x23F76A0
	public void MovePatrolPoint(NpcController npc) { }

	// RVA: 0x23F9DC0 Offset: 0x23F9EC1 VA: 0x23F9DC0
	public void SetOutdoorNavTarget() { }

	// RVA: 0x23FA370 Offset: 0x23FA471 VA: 0x23FA370
	public float DistanceXZ(Vector3 src, Vector3 dst) { }

	// RVA: 0x23FA420 Offset: 0x23FA521 VA: 0x23FA420
	public void ChatTalked(int r) { }

	// RVA: 0x23FA4F0 Offset: 0x23FA5F1 VA: 0x23FA4F0
	public void ChatTalkLvUp() { }

	// RVA: 0x23FA530 Offset: 0x23FA631 VA: 0x23FA530
	public void SetChatTalkLv(int lv, bool force = False) { }

	// RVA: 0x23F9C70 Offset: 0x23F9D71 VA: 0x23F9C70
	public void ChatTalkLottery() { }

	// RVA: 0x23FA5E0 Offset: 0x23FA6E1 VA: 0x23FA5E0
	private bool CheckChatTalkLv(int lv, int randnum) { }

	// RVA: 0x23FA7B0 Offset: 0x23FA8B1 VA: 0x23FA7B0
	public void UpdateTalking(float deltaTime) { }

	// RVA: 0x23FA890 Offset: 0x23FA991 VA: 0x23FA890
	public void ChangeModel(int modelType, bool isSpc = False) { }

	// RVA: 0x23F9990 Offset: 0x23F9A91 VA: 0x23F9990
	public void SetCurrentPlaceId(FieldPlaceId FieldPlaceId) { }

	// RVA: 0x23FAC20 Offset: 0x23FAD21 VA: 0x23FAC20
	public void AnimationIdle() { }

	// RVA: 0x23FAC30 Offset: 0x23FAD31 VA: 0x23FAC30
	public void AnimationForceIdle() { }

	// RVA: 0x23FAD30 Offset: 0x23FAE31 VA: 0x23FAD30
	public void AnimIdxIdle() { }

	// RVA: 0x23F72A0 Offset: 0x23F73A1 VA: 0x23F72A0
	public NpcLifeCycleTimeData GetNpcLifeCycleTimeData(int hour, int minutes, Weather weather = 0) { }

	// RVA: 0x23F1B80 Offset: 0x23F1C81 VA: 0x23F1B80
	public NpcLifeCycleTime GetCurrentTimeList(int hour, int minutes) { }

	// RVA: 0x23F73A0 Offset: 0x23F74A1 VA: 0x23F73A0
	public Place ConvertPlaceTag(Place TargetPlace) { }

	// RVA: 0x23FADD0 Offset: 0x23FAED1 VA: 0x23FADD0
	public void PlayLoopAction() { }

	// RVA: 0x23F5200 Offset: 0x23F5301 VA: 0x23F5200
	public bool PlayLifecycleScript(bool IsStartScript) { }

	// RVA: 0x23FAEC0 Offset: 0x23FAFC1 VA: 0x23FAEC0
	private PatrolPointMotionData GetCurrentPatrolPointMotionData() { }

	// RVA: 0x23FADE0 Offset: 0x23FAEE1 VA: 0x23FADE0
	private string LotteryCurrentPatrolPointMotionScript(bool eating, bool isStartMotion) { }

	// RVA: 0x23FB090 Offset: 0x23FB191 VA: 0x23FB090
	public void ItemClearAction(bool motionReset = True) { }

	// RVA: 0x23FB0E0 Offset: 0x23FB1E1 VA: 0x23FB0E0
	public void DoPartner(Action<PartnerNPCBehaviorController> callBack) { }

	// RVA: 0x23FB2A0 Offset: 0x23FB3A1 VA: 0x23FB2A0
	public void ReleasePartner(Action<NpcController> callBack) { }

	// RVA: 0x23FB430 Offset: 0x23FB531 VA: 0x23FB430
	public void ReleasePartnerNpc(ActorID actorId, Action<NpcController> callBack) { }

	// RVA: 0x23FB620 Offset: 0x23FB721 VA: 0x23FB620
	public void ReleasePartnerByTime() { }

	// RVA: 0x23FB680 Offset: 0x23FB781 VA: 0x23FB680
	private void CallAfterLeavePartner(NpcController npc, UnityAction callBack) { }

	// RVA: 0x23FB730 Offset: 0x23FB831 VA: 0x23FB730
	public void DoBecomeLover() { }

	// RVA: 0x23FB780 Offset: 0x23FB881 VA: 0x23FB780
	public void DoMarriage() { }

	// RVA: 0x23FB9F0 Offset: 0x23FBAF1 VA: 0x23FB9F0
	public void SetAngryStep(int step = -1) { }

	// RVA: 0x23F9BF0 Offset: 0x23F9CF1 VA: 0x23F9BF0
	private void WakeUpAngryStepProceed() { }

	// RVA: 0x23FBA30 Offset: 0x23FBB31 VA: 0x23FBA30
	public bool IsAngry() { }

	// RVA: 0x23FBA60 Offset: 0x23FBB61 VA: 0x23FBA60
	public bool Isjealous() { }

	// RVA: 0x23F50E0 Offset: 0x23F51E1 VA: 0x23F50E0
	public void SetLifeCycleTransfromPosition(Vector3 pos) { }

	// RVA: 0x23F5130 Offset: 0x23F5231 VA: 0x23F5130
	public void SetLifeCycleTransfromRotation(Quaternion rot) { }

	// RVA: 0x23FBA80 Offset: 0x23FBB81 VA: 0x23FBA80
	public void ReserveFesDate(Event eventId) { }

	// RVA: 0x23FBE40 Offset: 0x23FBF41 VA: 0x23FBE40
	public void ReserveLoveStoryDate(bool isKokuhaku, EventScriptID reserveScriptId, DateSpotID dateSpot, int dateTime) { }

	// RVA: 0x23FC080 Offset: 0x23FC181 VA: 0x23FC080
	public void ReserveNomalDate(DateSpotID dateSpot) { }

	// RVA: 0x23FBD30 Offset: 0x23FBE31 VA: 0x23FBD30
	private void ReserveDate(DateType dateType, DateSpotID dateSpot, int dateStartTime, int limitTime, GameFlagData flag, bool doSuupo) { }

	// RVA: 0x23FC160 Offset: 0x23FC261 VA: 0x23FC160
	public void AddFlowerFesDateNum() { }

	// RVA: 0x23FC200 Offset: 0x23FC301 VA: 0x23FC200
	public bool IsDateStandby() { }

	// RVA: 0x23FC210 Offset: 0x23FC311 VA: 0x23FC210
	public void ResetDateReserve() { }

	// RVA: 0x23EF540 Offset: 0x23EF641 VA: 0x23EF540
	public void CheckWear() { }

	// RVA: 0x23FC250 Offset: 0x23FC351 VA: 0x23FC250
	public void ChangeToNomalWearNonCreate() { }

	// RVA: 0x23F20E0 Offset: 0x23F21E1 VA: 0x23F20E0
	public void ChangeToNomalWear() { }

	// RVA: 0x23FAA10 Offset: 0x23FAB11 VA: 0x23FAA10
	public VariationNo GetNormalWearVariationNo() { }

	// RVA: 0x23F2110 Offset: 0x23F2211 VA: 0x23F2110
	public void ChangeToSwimWear() { }

	// RVA: 0x23FC240 Offset: 0x23FC341 VA: 0x23FC240
	public void ChangeToPajama() { }

	// RVA: 0x23FC300 Offset: 0x23FC401 VA: 0x23FC300
	public void ChangeWear(VariationNo targetVariationNo) { }

	// RVA: 0x23FC450 Offset: 0x23FC551 VA: 0x23FC450
	public void RotateLookAtTarget(Character character) { }

	// RVA: 0x23FC8E0 Offset: 0x23FC9E1 VA: 0x23FC8E0
	public void LookAtTarget() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A61E0 Offset: 0x1A62E1 VA: 0x1A61E0
	// RVA: 0x23FCA30 Offset: 0x23FCB31 VA: 0x23FCA30
	public IEnumerator LookAtTargetRotationEnd(bool IsTalkStart) { }

	// RVA: 0x23FCAC0 Offset: 0x23FCBC1 VA: 0x23FCAC0
	public void TalkEnd(bool setIdle = True) { }

	// RVA: 0x23FCC30 Offset: 0x23FCD31 VA: 0x23FCC30
	public void LookAtEnd() { }

	// RVA: 0x23F7580 Offset: 0x23F7681 VA: 0x23F7580
	private bool HasArrived() { }

	// RVA: 0x23FCF70 Offset: 0x23FD071 VA: 0x23FCF70
	private void SleepChangeEquip() { }

	// RVA: 0x23FD2B0 Offset: 0x23FD3B1 VA: 0x23FD2B0
	public void HeadChangeModel() { }

	// RVA: 0x23FD300 Offset: 0x23FD401 VA: 0x23FD300
	public void .ctor() { }

	// RVA: 0x23FD4B0 Offset: 0x23FD5B1 VA: 0x23FD4B0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6250 Offset: 0x1A6351 VA: 0x1A6250
	// RVA: 0x23FD790 Offset: 0x23FD891 VA: 0x23FD790
	private void <CheckObjectEnabled>b__352_0() { }
}

