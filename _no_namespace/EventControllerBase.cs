public class EventControllerBase : SingletonMonoBehaviour<EventControllerBase> // TypeDefIndex: 7131
{
	// Fields
	private const int D_SKILL_TALK_LV1 = 10;
	private const int D_SKILL_TALK_LV2 = 35;
	private const int D_SKILL_TALK_LV3 = 50;
	private const int D_SKILL_TALK_LV4 = 99;
	private const int DATE_LATENESSTIME = 2;
	private readonly GameFlagData[] KokuhakuCancelFlags; // 0x18
	private List<int> PtnPresentNpcIds; // 0x20
	private ItemID PtnPresentItemId; // 0x28
	private int TemporaryID01; // 0x2C
	private int ExclamationID; // 0x30
	private int ExclamationSkillIDA; // 0x34
	private int ExclamationSkillIDB; // 0x38
	private ItemData PrevPresentItemData; // 0x40
	private bool IsPrevOriginalPresent; // 0x48
	private bool IsBythewayFesDateOn; // 0x49
	public NPCID[] MarriageCandidateList; // 0x50
	public bool OnTouch; // 0x58
	public EventFlagManager _FlagManager; // 0x60
	private bool FirstFadeCheck; // 0x68
	private List<EventStartData> EventStartDataQueue; // 0x70
	private List<EventStartData> TutorialStartDataQueue; // 0x78
	private List<string> EventFlagCheckList; // 0x80
	private List<int> talkedNpcIdList; // 0x88
	private List<int> callLookatEndNpcIdList; // 0x90
	public EventFestivalManager FestivalManager; // 0x98
	public bool IsCallCallFestivalResult; // 0xA0
	private bool IsSelectShopDefalutTalk; // 0xA1
	private bool doGreeting; // 0xA2
	private bool doLongTimeTalk; // 0xA3
	[CompilerGeneratedAttribute] // RVA: 0x163020 Offset: 0x163121 VA: 0x163020
	private bool <IsEventStarted>k__BackingField; // 0xA4
	[CompilerGeneratedAttribute] // RVA: 0x163030 Offset: 0x163131 VA: 0x163030
	private bool <IsEventFinished>k__BackingField; // 0xA5
	public bool IsStartVegetableContestResult; // 0xA6
	public bool IsStartHalloweenContestResult; // 0xA7
	public string CallScriptName; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x163040 Offset: 0x163141 VA: 0x163040
	private FocusObjectID <ObjectInteractionId>k__BackingField; // 0xB0
	private TimeManager timeManager; // 0xB8
	public bool IsCollectFestivalNPC; // 0xC0
	private AdvMain _advMain; // 0xC8
	private ShortplayAdvController _ShortplayAdvController; // 0xD0
	private List<int> listNpcId_UpdateSimPosOnAdvComp; // 0xD8
	[SerializeField] // RVA: 0x163050 Offset: 0x163151 VA: 0x163050
	public bool EventDebugLogOn; // 0xE0
	[SerializeField] // RVA: 0x163060 Offset: 0x163161 VA: 0x163060
	public NpcEventType Debug_ActiveNpcEventType; // 0xE4
	[SerializeField] // RVA: 0x163070 Offset: 0x163171 VA: 0x163070
	public int DEBUG_ActiveEventId; // 0xE8
	[SerializeField] // RVA: 0x163080 Offset: 0x163181 VA: 0x163080
	public int DEBUG_ActiveEventStep; // 0xEC
	[SerializeField] // RVA: 0x163090 Offset: 0x163191 VA: 0x163090
	public int DEBUG_ActiveNpcId; // 0xF0
	[SerializeField] // RVA: 0x1630A0 Offset: 0x1631A1 VA: 0x1630A0
	public int DEBUG_ActiveNpcStep; // 0xF4
	public EventCameraResetType CameraResetFlag; // 0xF8
	private int DEBUG_EventLimit; // 0xFC
	public bool IsBossBattleStart; // 0x100
	public Character _owner; // 0x108
	public NpcController TargetNpc; // 0x110
	private const int PartnerEventDailyTalkStep = 99;
	public PartnerAdvChoice partnerAdvSelect; // 0x118
	[HideInInspector] // RVA: 0x1630B0 Offset: 0x1631B1 VA: 0x1630B0
	public SubEventManager subEventManager; // 0x120
	private GameObject fieldEventCanvas; // 0x128
	public bool _IsReadable; // 0x130
	public bool IsAssetReadable; // 0x131
	private GameObject cameraFade; // 0x138
	public ShopBuyState ShopOpenStep; // 0x140
	private int ShopStep; // 0x144
	public bool IsGenderSelect; // 0x148
	public bool FirstStepTalked; // 0x149
	private bool IsEventTriggerCheck; // 0x14A
	private ScenarioTalk ScenarioTalkDatas; // 0x150
	private int ScenarioSupportFlagId; // 0x158
	private bool IsEventMultiBoys; // 0x15C
	public List<string> debugPrintStrs; // 0x160
	public int debugPrintIndex; // 0x168
	public GameObject NavMeshObstacle; // 0x170
	public bool IsRunScript; // 0x178
	private BirthTalk BirthTalkDatas; // 0x180
	private CharacterCalling CharacterCallingDatas; // 0x188
	private bool isHidingAdvDialog; // 0x190
	public int[] IKOffAnimState; // 0x198
	private static Dictionary<string, GameFlagData> BossKillFlagDict; // 0x0
	private static readonly Dictionary<int, EventControllerBase.FirstMatchInfo> FirstEventPointDict; // 0x8
	private static readonly EventPointID[] FirstRematchOnlyEventStartPoints; // 0x10
	public static readonly int BossRebattleFlagOffset; // 0x18
	public bool IsFieldLoadFade; // 0x1A0
	private LoveEventTextConvertData _LoveEventTextConvertData; // 0x1A8
	[CompilerGeneratedAttribute] // RVA: 0x1630C0 Offset: 0x1631C1 VA: 0x1630C0
	private bool <IsInit>k__BackingField; // 0x1B0
	private List<int> ChoiceNextStepList; // 0x1B8
	private List<int> ChoiceAnswerIdList; // 0x1C0
	[CompilerGeneratedAttribute] // RVA: 0x1630D0 Offset: 0x1631D1 VA: 0x1630D0
	private int <LastSelect>k__BackingField; // 0x1C8

	// Properties
	public EventSaveParameter EventSaveParameters { get; }
	public EventFlagManager FlagManager { get; }
	public bool IsEventStarted { get; set; }
	public bool IsEventFinished { get; set; }
	public int CurrentEventId { get; set; }
	public int CurrentEventStep { get; set; }
	public bool IsTalking { get; set; }
	public int SelectMenuGroupId { get; set; }
	public bool IsSelectMenu { get; set; }
	public int TargetNpcId { get; set; }
	public int[] OrderNpcIds { get; set; }
	public FocusObjectID ObjectInteractionId { get; set; }
	public bool SP4CharaOn { get; set; }
	public AdvMain advMain { get; }
	public ShortplayAdvController ShortplayAdv { get; }
	public EventScheduleData[] EventScheduleDatas { get; set; }
	public string ForceScriptName { get; set; }
	public bool ForceEvent { get; set; }
	public int orderOccuredId { get; set; }
	public Character owner { get; }
	public int bythewayMenuCommandNo { get; set; }
	public int bythewayEventStep { get; set; }
	public bool Is1stBytheWay { get; set; }
	public int partnerMenuCommandNo { get; set; }
	public int partnerEventStep { get; set; }
	public int eventValue { get; set; }
	public bool UseRetentionEventType { get; set; }
	public bool IsReadable { get; set; }
	public List<EventUnlockFlagData> ReservedEventStartPoints { get; set; }
	public Place NowPlace { get; set; }
	public int FlagTalkIndex { get; set; }
	public bool IsSleepScriptCalled { get; set; }
	public bool IsWakeUpReserve { get; set; }
	public bool[] EventCheckTypeFlag { get; set; }
	public int[] EventCheckType { get; set; }
	public List<EventCheckId> EventCheckIds { get; set; }
	public LoveEventTextConvertData LoveEventTextConvertData { get; }
	public bool IsInit { get; set; }
	public EventScheduleData CurrentEventScheduleData { get; }
	public EventData CurrentNpcEventData { get; }
	public EventData CommonNpcEventData { get; }
	public NpcEventType NowType { get; set; }
	public int LastSelect { get; set; }

	// Methods

	// RVA: 0x1C1A970 Offset: 0x1C1AA71 VA: 0x1C1A970
	public bool IsComplimentTalkOcc(int id) { }

	// RVA: 0x1C1A9E0 Offset: 0x1C1AAE1 VA: 0x1C1A9E0
	public int GetComplimentTalkOcc(int id) { }

	// RVA: 0x1C1B410 Offset: 0x1C1B511 VA: 0x1C1B410
	private void RunKokuhakuScript(int npcid) { }

	// RVA: 0x1C1BBA0 Offset: 0x1C1BCA1 VA: 0x1C1BBA0
	private void RunDateEventReserveScript(string scriptName) { }

	// RVA: 0x1C1BC90 Offset: 0x1C1BD91 VA: 0x1C1BC90
	private void DoSuppo() { }

	// RVA: 0x1C1BDB0 Offset: 0x1C1BEB1 VA: 0x1C1BDB0
	private void OnDayCarryDate(int diff) { }

	// RVA: 0x1C1BF10 Offset: 0x1C1C011 VA: 0x1C1BF10
	public void OnHourCarryDate(int diff) { }

	// RVA: 0x1C1C0F0 Offset: 0x1C1C1F1 VA: 0x1C1C0F0
	public void RunDateTalkScript(int npcid) { }

	// RVA: 0x1C1C890 Offset: 0x1C1C991 VA: 0x1C1C890
	public int BythewayInviteDateResult(int playerSuggStep, int npcSuggStep, int missStep) { }

	// RVA: 0x1C1CAD0 Offset: 0x1C1CBD1 VA: 0x1C1CAD0
	public int LottelyNpcSuggestionDateSpot(int spotStep, int homeStep, int fesStep) { }

	// RVA: 0x1C1CD30 Offset: 0x1C1CE31 VA: 0x1C1CD30
	public int GetInviteFesDateStep(int NextDayFesId, int nextStep) { }

	// RVA: 0x1C1CC90 Offset: 0x1C1CD91 VA: 0x1C1CC90
	public int GetInveteFesDateId() { }

	// RVA: 0x1C1CD50 Offset: 0x1C1CE51 VA: 0x1C1CD50
	public bool GetCanDate(int npcid) { }

	// RVA: 0x1C1CED0 Offset: 0x1C1CFD1 VA: 0x1C1CED0
	public void DateEnd(int type) { }

	// RVA: 0x1C1D6A0 Offset: 0x1C1D7A1 VA: 0x1C1D6A0
	private void DateFlagOff() { }

	// RVA: 0x1C1BD70 Offset: 0x1C1BE71 VA: 0x1C1BD70
	public void ResetDateReserve() { }

	// RVA: 0x1C1D830 Offset: 0x1C1D931 VA: 0x1C1D830
	private void ReserveQueueCheckContains(string scriptName) { }

	// RVA: 0x1C1DA10 Offset: 0x1C1DB11 VA: 0x1C1DA10
	public int GetNpcLoveStoryProgress(int npcid) { }

	// RVA: 0x1C1DB40 Offset: 0x1C1DC41 VA: 0x1C1DB40
	public string BathingGiveItemName() { }

	// RVA: 0x1C1DBC0 Offset: 0x1C1DCC1 VA: 0x1C1DBC0
	public void HotSpringPresent(int returnStep, int baseNextStep, bool research) { }

	// RVA: 0x1C1DE70 Offset: 0x1C1DF71 VA: 0x1C1DE70
	private void CheckHotSpringPresent() { }

	// RVA: 0x1C1E150 Offset: 0x1C1E251 VA: 0x1C1E150
	public void InitPtnPresentNpcIds() { }

	// RVA: 0x1C1E1B0 Offset: 0x1C1E2B1 VA: 0x1C1E1B0
	private NpcEventType CheckTutorialAdv() { }

	// RVA: 0x1C1F050 Offset: 0x1C1F151 VA: 0x1C1F050
	private NpcEventType GetRetentionEventType() { }

	// RVA: 0x1C1F1F0 Offset: 0x1C1F2F1 VA: 0x1C1F1F0
	private NpcEventType GetNpcTalkTypeBefore() { }

	// RVA: 0x1C1F410 Offset: 0x1C1F511 VA: 0x1C1F410
	private NpcEventType GetNpcTalkType(NpcTalkType startType = 0) { }

	// RVA: 0x1C1F540 Offset: 0x1C1F641 VA: 0x1C1F540
	private NpcEventType GetNpcTalkType2(NpcTalkType type, NpcTalkType startType = 0) { }

	// RVA: 0x1C22ED0 Offset: 0x1C22FD1 VA: 0x1C22ED0
	public int GetTemporaryID() { }

	// RVA: 0x1C22EE0 Offset: 0x1C22FE1 VA: 0x1C22EE0
	public int GetExclamationID() { }

	// RVA: 0x1C22EF0 Offset: 0x1C22FF1 VA: 0x1C22EF0
	public int GetExclamationSkillIDA() { }

	// RVA: 0x1C22F00 Offset: 0x1C23001 VA: 0x1C22F00
	public int GetExclamationSkillIDB() { }

	// RVA: 0x1C22F10 Offset: 0x1C23011 VA: 0x1C22F10
	public void DEBUG_SetExclamationSkill() { }

	// RVA: 0x1C21500 Offset: 0x1C21601 VA: 0x1C21500
	private int ExclamationTalkType(NpcData data) { }

	// RVA: 0x1C22F30 Offset: 0x1C23031 VA: 0x1C22F30
	public string GetExclamationItemName() { }

	// RVA: 0x1C22F60 Offset: 0x1C23061 VA: 0x1C22F60
	public string GetExclamationRecipeName() { }

	// RVA: 0x1C230A0 Offset: 0x1C231A1 VA: 0x1C230A0
	public string GetExclamationSkillName() { }

	// RVA: 0x1C213E0 Offset: 0x1C214E1 VA: 0x1C213E0
	private bool CheckSickTalkType() { }

	// RVA: 0x1C22DA0 Offset: 0x1C22EA1 VA: 0x1C22DA0
	private void SickTalkType() { }

	// RVA: 0x1C22C30 Offset: 0x1C22D31 VA: 0x1C22C30
	private bool CheckSeasonTalkType() { }

	// RVA: 0x1C22190 Offset: 0x1C22291 VA: 0x1C22190
	public bool CheckRestaurantEventFinished() { }

	// RVA: 0x1C22070 Offset: 0x1C22171 VA: 0x1C22070
	private ValueTuple<Season, int> GetDiffDay(Season season, int day) { }

	// RVA: 0x1C23300 Offset: 0x1C23401 VA: 0x1C23300
	public bool IsNpcOrderTalk(NpcData data) { }

	// RVA: 0x1C23540 Offset: 0x1C23641 VA: 0x1C23540
	public bool IsNpcSubEventTalk(NpcData data) { }

	// RVA: 0x1C22520 Offset: 0x1C22621 VA: 0x1C22520
	public bool IsGuestNpc(NPCID id) { }

	// RVA: 0x1C22120 Offset: 0x1C22221 VA: 0x1C22120
	public bool IsWantedFinishedTalk() { }

	// RVA: 0x1C235E0 Offset: 0x1C236E1 VA: 0x1C235E0
	public bool CheckCallTutorialScript_BySkill(TutorialScriptType type, SkillID id) { }

	// RVA: 0x1C1EF40 Offset: 0x1C1F041 VA: 0x1C1EF40
	public bool CheckCallTutorialScript(TutorialScriptType type) { }

	// RVA: 0x1C23680 Offset: 0x1C23781 VA: 0x1C23680
	public void ReserveTutorialScript(string scriptName, bool onlyForceScriptName) { }

	// RVA: 0x1C23930 Offset: 0x1C23A31 VA: 0x1C23930
	public void ReserveScriptBase(string scriptName, int npcid = 0) { }

	// RVA: 0x1C23B70 Offset: 0x1C23C71 VA: 0x1C23B70
	public bool TutorialStartQueueLoad() { }

	// RVA: 0x1C240B0 Offset: 0x1C241B1 VA: 0x1C240B0
	public void BythewayLethargy(int npcid = 0) { }

	// RVA: 0x1C243F0 Offset: 0x1C244F1 VA: 0x1C243F0
	private bool BythewayFesDateScript() { }

	// RVA: 0x1C245B0 Offset: 0x1C246B1 VA: 0x1C245B0
	private void RunBythewayFesDateScript(int type = 1) { }

	// RVA: 0x1C24B50 Offset: 0x1C24C51 VA: 0x1C24B50
	public void RunBythewayStartScript() { }

	// RVA: 0x1C25170 Offset: 0x1C25271 VA: 0x1C25170
	public bool GetCanPartySelect(int npcid) { }

	// RVA: 0x1C24F20 Offset: 0x1C25021 VA: 0x1C24F20
	public void RunBythewaySelectScript() { }

	// RVA: 0x1C25640 Offset: 0x1C25741 VA: 0x1C25640
	public void RunInvitedScript() { }

	// RVA: 0x1C259E0 Offset: 0x1C25AE1 VA: 0x1C259E0
	public void RunItemPresentScript(NpcData npc, ItemData item, bool isOriginal) { }

	// RVA: 0x1C25D40 Offset: 0x1C25E41 VA: 0x1C25D40
	public bool RunWeddingRingScript(int npcid, int type) { }

	// RVA: 0x1C26200 Offset: 0x1C26301 VA: 0x1C26200
	public bool CheckRunProposeEventScript(int npcId) { }

	// RVA: 0x1C26300 Offset: 0x1C26401 VA: 0x1C26300
	public void SetPrevPresentItemData(ItemData item) { }

	// RVA: 0x1C26310 Offset: 0x1C26411 VA: 0x1C26310
	public void ReleasePrevPresentItemData() { }

	// RVA: 0x1C26320 Offset: 0x1C26421 VA: 0x1C26320
	public void ReturnPresent(Vector3 position, int npcId = 0) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E0E0 Offset: 0x19E1E1 VA: 0x19E0E0
	// RVA: 0x1C26400 Offset: 0x1C26501 VA: 0x1C26400
	public IEnumerator ReturnPresentCoroutine(Vector3 position, int npcId = 0) { }

	// RVA: 0x1C264B0 Offset: 0x1C265B1 VA: 0x1C264B0
	public void PresentAtSeriousScript(int npcid) { }

	// RVA: 0x1C26580 Offset: 0x1C26681 VA: 0x1C26580
	public void RunGiveBirthScript(int type) { }

	// RVA: 0x1C26590 Offset: 0x1C26691 VA: 0x1C26590
	public void RunLeavePartnerScript(int npcid) { }

	// RVA: 0x1C26790 Offset: 0x1C26891 VA: 0x1C26790
	private void RunMakingScript(string scriptName) { }

	// RVA: 0x1C269C0 Offset: 0x1C26AC1 VA: 0x1C269C0
	public void RunMakingLicenseScript(MakingID id) { }

	// RVA: 0x1C26BD0 Offset: 0x1C26CD1 VA: 0x1C26BD0
	public void RunMakingSuccessScript() { }

	// RVA: 0x1C26CE0 Offset: 0x1C26DE1 VA: 0x1C26CE0
	public void RunMakingSuccessEndScript(string scriptName) { }

	// RVA: 0x1C26CF0 Offset: 0x1C26DF1 VA: 0x1C26CF0
	public void RunRiviaWantedEndShopScript() { }

	// RVA: 0x1C26FD0 Offset: 0x1C270D1 VA: 0x1C26FD0
	public void RunRiviaWantedCompleteScript() { }

	// RVA: 0x1C27230 Offset: 0x1C27331 VA: 0x1C27230
	public void RunRiviaWantedCompleteRewardScript() { }

	// RVA: 0x1C27490 Offset: 0x1C27591 VA: 0x1C27490
	public void RunRiviaWantedCompleteFinishScript() { }

	// RVA: 0x1C27700 Offset: 0x1C27801 VA: 0x1C27700
	public void RunRiviaSeedRankUpUIScript() { }

	// RVA: 0x1C277A0 Offset: 0x1C278A1 VA: 0x1C277A0
	public void RunRiviaSeedRankUpScript(int rank = 1) { }

	// RVA: 0x1C279A0 Offset: 0x1C27AA1 VA: 0x1C279A0
	public void RunRiviaGetBadgeUIScript() { }

	// RVA: 0x1C27A40 Offset: 0x1C27B41 VA: 0x1C27A40
	public void RunRiviaGetBadgeScript(int type) { }

	// RVA: 0x1C27B50 Offset: 0x1C27C51 VA: 0x1C27B50
	public void RunRiviaWantedCompleteNextScript() { }

	// RVA: 0x1C27BC0 Offset: 0x1C27CC1 VA: 0x1C27BC0
	public void RunEndMobRenameEndScript(int varNo) { }

	// RVA: 0x1C24160 Offset: 0x1C24261 VA: 0x1C24160
	public string GetLethargyScriptName(int npcid) { }

	// RVA: 0x1C285A0 Offset: 0x1C286A1 VA: 0x1C285A0
	public void RunOrderCompleteScript(int orderId = -1) { }

	// RVA: 0x1C26020 Offset: 0x1C26121 VA: 0x1C26020
	public void MarriageInit(int npcid) { }

	// RVA: 0x1C287C0 Offset: 0x1C288C1 VA: 0x1C287C0
	public EventSaveParameter get_EventSaveParameters() { }

	// RVA: 0x1C287F0 Offset: 0x1C288F1 VA: 0x1C287F0
	public void BeforeSaveEventData() { }

	// RVA: 0x1C288E0 Offset: 0x1C289E1 VA: 0x1C288E0
	public void AfterLoadEventData() { }

	// RVA: 0x1C1DAB0 Offset: 0x1C1DBB1 VA: 0x1C1DAB0
	public EventFlagManager get_FlagManager() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E150 Offset: 0x19E251 VA: 0x19E150
	// RVA: 0x1C297F0 Offset: 0x1C298F1 VA: 0x1C297F0
	public bool get_IsEventStarted() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E160 Offset: 0x19E261 VA: 0x19E160
	// RVA: 0x1C29800 Offset: 0x1C29901 VA: 0x1C29800
	public void set_IsEventStarted(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19E170 Offset: 0x19E271 VA: 0x19E170
	// RVA: 0x1C29810 Offset: 0x1C29911 VA: 0x1C29810
	public bool get_IsEventFinished() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E180 Offset: 0x19E281 VA: 0x19E180
	// RVA: 0x1C29820 Offset: 0x1C29921 VA: 0x1C29820
	private void set_IsEventFinished(bool value) { }

	// RVA: 0x1C22200 Offset: 0x1C22301 VA: 0x1C22200
	public int get_CurrentEventId() { }

	// RVA: 0x1C22300 Offset: 0x1C22401 VA: 0x1C22300
	public void set_CurrentEventId(int value) { }

	// RVA: 0x1C29830 Offset: 0x1C29931 VA: 0x1C29830
	public int get_CurrentEventStep() { }

	// RVA: 0x1C29870 Offset: 0x1C29971 VA: 0x1C29870
	public void set_CurrentEventStep(int value) { }

	// RVA: 0x1C238A0 Offset: 0x1C239A1 VA: 0x1C238A0
	public bool get_IsTalking() { }

	// RVA: 0x1C298B0 Offset: 0x1C299B1 VA: 0x1C298B0
	public void set_IsTalking(bool value) { }

	// RVA: 0x1C299B0 Offset: 0x1C29AB1 VA: 0x1C299B0
	public int get_SelectMenuGroupId() { }

	// RVA: 0x1C299F0 Offset: 0x1C29AF1 VA: 0x1C299F0
	public void set_SelectMenuGroupId(int value) { }

	// RVA: 0x1C29A30 Offset: 0x1C29B31 VA: 0x1C29A30
	public bool get_IsSelectMenu() { }

	// RVA: 0x1C29A70 Offset: 0x1C29B71 VA: 0x1C29A70
	public void set_IsSelectMenu(bool value) { }

	// RVA: 0x1C1B290 Offset: 0x1C1B391 VA: 0x1C1B290
	public int get_TargetNpcId() { }

	// RVA: 0x1C29AC0 Offset: 0x1C29BC1 VA: 0x1C29AC0
	public void set_TargetNpcId(int value) { }

	// RVA: 0x1C29B00 Offset: 0x1C29C01 VA: 0x1C29B00
	public int[] get_OrderNpcIds() { }

	// RVA: 0x1C29B40 Offset: 0x1C29C41 VA: 0x1C29B40
	public void set_OrderNpcIds(int[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19E190 Offset: 0x19E291 VA: 0x19E190
	// RVA: 0x1C29B90 Offset: 0x1C29C91 VA: 0x1C29B90
	public FocusObjectID get_ObjectInteractionId() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E1A0 Offset: 0x19E2A1 VA: 0x19E1A0
	// RVA: 0x1C29BA0 Offset: 0x1C29CA1 VA: 0x1C29BA0
	private void set_ObjectInteractionId(FocusObjectID value) { }

	// RVA: 0x1C29BB0 Offset: 0x1C29CB1 VA: 0x1C29BB0
	public bool get_SP4CharaOn() { }

	// RVA: 0x1C29BF0 Offset: 0x1C29CF1 VA: 0x1C29BF0
	public void set_SP4CharaOn(bool value) { }

	// RVA: 0x1C1D590 Offset: 0x1C1D691 VA: 0x1C1D590
	public AdvMain get_advMain() { }

	// RVA: 0x1C29C40 Offset: 0x1C29D41 VA: 0x1C29C40
	public ShortplayAdvController get_ShortplayAdv() { }

	// RVA: 0x1C29CD0 Offset: 0x1C29DD1 VA: 0x1C29CD0
	public EventScheduleData[] get_EventScheduleDatas() { }

	// RVA: 0x1C29D10 Offset: 0x1C29E11 VA: 0x1C29D10
	public void set_EventScheduleDatas(EventScheduleData[] value) { }

	// RVA: 0x1C23D50 Offset: 0x1C23E51 VA: 0x1C23D50
	public string get_ForceScriptName() { }

	// RVA: 0x1C238E0 Offset: 0x1C239E1 VA: 0x1C238E0
	public void set_ForceScriptName(string value) { }

	// RVA: 0x1C22340 Offset: 0x1C22441 VA: 0x1C22340
	public bool get_ForceEvent() { }

	// RVA: 0x1C22380 Offset: 0x1C22481 VA: 0x1C22380
	public void set_ForceEvent(bool value) { }

	// RVA: 0x1C29D60 Offset: 0x1C29E61 VA: 0x1C29D60
	public int get_orderOccuredId() { }

	// RVA: 0x1C22240 Offset: 0x1C22341 VA: 0x1C22240
	public void set_orderOccuredId(int value) { }

	// RVA: 0x1C29DA0 Offset: 0x1C29EA1 VA: 0x1C29DA0
	public Character get_owner() { }

	// RVA: 0x1C1F350 Offset: 0x1C1F451 VA: 0x1C1F350
	public int get_bythewayMenuCommandNo() { }

	// RVA: 0x1C25290 Offset: 0x1C25391 VA: 0x1C25290
	public void set_bythewayMenuCommandNo(int value) { }

	// RVA: 0x1C29E70 Offset: 0x1C29F71 VA: 0x1C29E70
	public int get_bythewayEventStep() { }

	// RVA: 0x1C252D0 Offset: 0x1C253D1 VA: 0x1C252D0
	public void set_bythewayEventStep(int value) { }

	// RVA: 0x1C29EB0 Offset: 0x1C29FB1 VA: 0x1C29EB0
	public bool get_Is1stBytheWay() { }

	// RVA: 0x1C24B00 Offset: 0x1C24C01 VA: 0x1C24B00
	public void set_Is1stBytheWay(bool value) { }

	// RVA: 0x1C1F3D0 Offset: 0x1C1F4D1 VA: 0x1C1F3D0
	public int get_partnerMenuCommandNo() { }

	// RVA: 0x1C29EF0 Offset: 0x1C29FF1 VA: 0x1C29EF0
	public void set_partnerMenuCommandNo(int value) { }

	// RVA: 0x1C1F390 Offset: 0x1C1F491 VA: 0x1C1F390
	public int get_partnerEventStep() { }

	// RVA: 0x1C29F30 Offset: 0x1C2A031 VA: 0x1C29F30
	public void set_partnerEventStep(int value) { }

	// RVA: 0x1C1B250 Offset: 0x1C1B351 VA: 0x1C1B250
	public int get_eventValue() { }

	// RVA: 0x1C1B210 Offset: 0x1C1B311 VA: 0x1C1B210
	public void set_eventValue(int value) { }

	// RVA: 0x1C29F70 Offset: 0x1C2A071 VA: 0x1C29F70
	public bool get_UseRetentionEventType() { }

	// RVA: 0x1C1F1A0 Offset: 0x1C1F2A1 VA: 0x1C1F1A0
	public void set_UseRetentionEventType(bool value) { }

	// RVA: 0x1C29FB0 Offset: 0x1C2A0B1 VA: 0x1C29FB0
	public bool get_IsReadable() { }

	// RVA: 0x1C29FC0 Offset: 0x1C2A0C1 VA: 0x1C29FC0
	public void set_IsReadable(bool value) { }

	// RVA: 0x1C29FD0 Offset: 0x1C2A0D1 VA: 0x1C29FD0
	public List<EventUnlockFlagData> get_ReservedEventStartPoints() { }

	// RVA: 0x1C2A010 Offset: 0x1C2A111 VA: 0x1C2A010
	public void set_ReservedEventStartPoints(List<EventUnlockFlagData> value) { }

	// RVA: 0x1C22280 Offset: 0x1C22381 VA: 0x1C22280
	public Place get_NowPlace() { }

	// RVA: 0x1C2A060 Offset: 0x1C2A161 VA: 0x1C2A060
	public void set_NowPlace(Place value) { }

	// RVA: 0x1C2A0A0 Offset: 0x1C2A1A1 VA: 0x1C2A0A0
	public int get_FlagTalkIndex() { }

	// RVA: 0x1C2A0E0 Offset: 0x1C2A1E1 VA: 0x1C2A0E0
	public void set_FlagTalkIndex(int value) { }

	// RVA: 0x1C2A120 Offset: 0x1C2A221 VA: 0x1C2A120
	public bool get_IsSleepScriptCalled() { }

	// RVA: 0x1C2A160 Offset: 0x1C2A261 VA: 0x1C2A160
	public void set_IsSleepScriptCalled(bool value) { }

	// RVA: 0x1C2A1B0 Offset: 0x1C2A2B1 VA: 0x1C2A1B0
	public bool get_IsWakeUpReserve() { }

	// RVA: 0x1C2A1F0 Offset: 0x1C2A2F1 VA: 0x1C2A1F0
	public void set_IsWakeUpReserve(bool value) { }

	// RVA: 0x1C2A240 Offset: 0x1C2A341 VA: 0x1C2A240
	public bool[] get_EventCheckTypeFlag() { }

	// RVA: 0x1C2A280 Offset: 0x1C2A381 VA: 0x1C2A280
	public void set_EventCheckTypeFlag(bool[] value) { }

	// RVA: 0x1C2A2D0 Offset: 0x1C2A3D1 VA: 0x1C2A2D0
	public int[] get_EventCheckType() { }

	// RVA: 0x1C2A310 Offset: 0x1C2A411 VA: 0x1C2A310
	public void set_EventCheckType(int[] value) { }

	// RVA: 0x1C2A360 Offset: 0x1C2A461 VA: 0x1C2A360
	public List<EventCheckId> get_EventCheckIds() { }

	// RVA: 0x1C2A3A0 Offset: 0x1C2A4A1 VA: 0x1C2A3A0
	public void set_EventCheckIds(List<EventCheckId> value) { }

	// RVA: 0x1C2A3F0 Offset: 0x1C2A4F1 VA: 0x1C2A3F0
	public LoveEventTextConvertData get_LoveEventTextConvertData() { }

	// RVA: 0x1C2A4F0 Offset: 0x1C2A5F1 VA: 0x1C2A4F0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1C2A540 Offset: 0x1C2A641 VA: 0x1C2A540
	private void Update() { }

	// RVA: 0x1C2B6A0 Offset: 0x1C2B7A1 VA: 0x1C2B6A0
	private void FixedUpdate() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E1B0 Offset: 0x19E2B1 VA: 0x19E1B0
	// RVA: 0x1C2BE70 Offset: 0x1C2BF71 VA: 0x1C2BE70
	public bool get_IsInit() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E1C0 Offset: 0x19E2C1 VA: 0x19E1C0
	// RVA: 0x1C2BE80 Offset: 0x1C2BF81 VA: 0x1C2BE80
	private void set_IsInit(bool value) { }

	// RVA: 0x1C2BE90 Offset: 0x1C2BF91 VA: 0x1C2BE90
	private void LoadAsset() { }

	// RVA: 0x1C2AAF0 Offset: 0x1C2ABF1 VA: 0x1C2AAF0
	public void Init() { }

	// RVA: 0x1C2BFB0 Offset: 0x1C2C0B1 VA: 0x1C2BFB0
	public void ClearTargetNpc() { }

	// RVA: 0x1C2C010 Offset: 0x1C2C111 VA: 0x1C2C010
	public static void EventDataInitializeForNewGame() { }

	// RVA: 0x1C22920 Offset: 0x1C22A21 VA: 0x1C22920
	public void SetEventIdStep(int eventId, int eventStep) { }

	// RVA: 0x1C2C780 Offset: 0x1C2C881 VA: 0x1C2C780
	public void StopEvent() { }

	// RVA: 0x1C2C7C0 Offset: 0x1C2C8C1 VA: 0x1C2C7C0
	public void ResetEventStep() { }

	// RVA: 0x1C2C850 Offset: 0x1C2C951 VA: 0x1C2C850
	public void ResetFesEventStep() { }

	// RVA: 0x1C2C8D0 Offset: 0x1C2C9D1 VA: 0x1C2C8D0
	public bool IsEventActive() { }

	// RVA: 0x1C2C910 Offset: 0x1C2CA11 VA: 0x1C2C910
	public bool IsEventCheck(EventTriggerType eventCheckType) { }

	// RVA: 0x1C2C980 Offset: 0x1C2CA81 VA: 0x1C2C980
	public void AddEventCheck(int eventCheckType, int checkTriggerId, string checkScriptName, string checkEnemyName = "") { }

	// RVA: 0x1C2CCA0 Offset: 0x1C2CDA1 VA: 0x1C2CCA0
	public void ReduceEventCheck(int eventCheckType, int checkTriggerId) { }

	// RVA: 0x1C2D200 Offset: 0x1C2D301 VA: 0x1C2D200
	public EventScheduleData get_CurrentEventScheduleData() { }

	// RVA: 0x1C1BA40 Offset: 0x1C1BB41 VA: 0x1C1BA40
	public EventData get_CurrentNpcEventData() { }

	// RVA: 0x1C2D2B0 Offset: 0x1C2D3B1 VA: 0x1C2D2B0
	public EventData get_CommonNpcEventData() { }

	// RVA: 0x1C222C0 Offset: 0x1C223C1 VA: 0x1C222C0
	public NpcEventType get_NowType() { }

	// RVA: 0x1C2D3E0 Offset: 0x1C2D4E1 VA: 0x1C2D3E0
	public void set_NowType(NpcEventType value) { }

	// RVA: 0x1C2D420 Offset: 0x1C2D521 VA: 0x1C2D420
	public void SetEnable(bool isEnable) { }

	// RVA: 0x1C2D430 Offset: 0x1C2D531 VA: 0x1C2D430
	public void WakeUpUpdate(int diffDay) { }

	// RVA: 0x1C28EC0 Offset: 0x1C28FC1 VA: 0x1C28EC0
	public void ResetEvent(EventPointResetType resetType) { }

	// RVA: 0x1C2D500 Offset: 0x1C2D601 VA: 0x1C2D500
	public void SetBossBattleStart(bool val) { }

	// RVA: 0x1C2BF00 Offset: 0x1C2C001 VA: 0x1C2BF00
	public void LoadCanvas() { }

	// RVA: 0x1C2D510 Offset: 0x1C2D611 VA: 0x1C2D510
	public void ResetGreeting() { }

	// RVA: 0x1C2D520 Offset: 0x1C2D621 VA: 0x1C2D520
	public bool onAdvComplete(string filePath) { }

	// RVA: 0x1C2ED00 Offset: 0x1C2EE01 VA: 0x1C2ED00
	public void ReserveUpdateSimPosOnAdvComp(int NpcId) { }

	// RVA: 0x1C2E7B0 Offset: 0x1C2E8B1 VA: 0x1C2E7B0
	public void EventEndCameraReset(string filePath) { }

	// RVA: 0x1C25180 Offset: 0x1C25281 VA: 0x1C25180
	public void InitNpcEventType() { }

	// RVA: 0x1C2FE50 Offset: 0x1C2FF51 VA: 0x1C2FE50
	public void InitInvitedParameter() { }

	// RVA: 0x1C28800 Offset: 0x1C28901 VA: 0x1C28800
	public void SaveEventStartPoints(GameObject eventStartPoints) { }

	// RVA: 0x1C30080 Offset: 0x1C30181 VA: 0x1C30080
	public void DebugPrintAll(int charaId, int faceId, int positionId, string nametext, string msgtext, string[] selmenumsg) { }

	// RVA: 0x1C30200 Offset: 0x1C30301 VA: 0x1C30200
	public void SetText(string nametext, string chattext) { }

	// RVA: 0x1C30260 Offset: 0x1C30361 VA: 0x1C30260
	public void SetText(string nametext, string chattext, UnityAction callBackAction) { }

	// RVA: 0x1C302D0 Offset: 0x1C303D1 VA: 0x1C302D0
	public void NpcFirstTalk() { }

	// RVA: 0x1C24CD0 Offset: 0x1C24DD1 VA: 0x1C24CD0
	private string GetBythewayMenuText(int id) { }

	// RVA: 0x1C30390 Offset: 0x1C30491 VA: 0x1C30390
	private string GetPartnerMenuText(int id) { }

	// RVA: 0x1C25550 Offset: 0x1C25651 VA: 0x1C25550
	public string GetAdvChoiceNothing() { }

	// RVA: 0x1C30620 Offset: 0x1C30721 VA: 0x1C30620
	public bool EventEndFinish(float wait, string filePath = "") { }

	// RVA: 0x1C2E6C0 Offset: 0x1C2E7C1 VA: 0x1C2E6C0
	public bool IsBedScriptName(string scriptName) { }

	// RVA: 0x1C241E0 Offset: 0x1C242E1 VA: 0x1C241E0
	protected void EventStart(string fileName, bool research = False) { }

	// RVA: 0x1C2C020 Offset: 0x1C2C121 VA: 0x1C2C020
	public void Resize(int npcId) { }

	// RVA: 0x1C31420 Offset: 0x1C31521 VA: 0x1C31420
	public bool NpcEventStart() { }

	// RVA: 0x1C314B0 Offset: 0x1C315B1 VA: 0x1C314B0
	public bool NpcEventStart(int npcId) { }

	// RVA: 0x1C31540 Offset: 0x1C31641 VA: 0x1C31540
	public bool NpcEventStart(NpcController npc, string scriptName) { }

	// RVA: 0x1C1BBF0 Offset: 0x1C1BCF1 VA: 0x1C1BBF0
	public bool ForceEventStart(string scriptName) { }

	// RVA: 0x1C1BB30 Offset: 0x1C1BC31 VA: 0x1C1BB30
	public bool ForceEventStart(string scriptName, int npcid) { }

	// RVA: 0x1C315B0 Offset: 0x1C316B1 VA: 0x1C315B0
	public bool ObjectEventStart(FocusObjectID interactionId) { }

	// RVA: 0x1C315F0 Offset: 0x1C316F1 VA: 0x1C315F0
	public bool ObjectEventStart() { }

	// RVA: 0x1C269B0 Offset: 0x1C26AB1 VA: 0x1C269B0
	public bool NpcEventStart(NpcController npc) { }

	// RVA: 0x1C23D90 Offset: 0x1C23E91 VA: 0x1C23D90
	public bool NpcEventStart(NpcController npc, int npcId) { }

	// RVA: 0x1C31630 Offset: 0x1C31731 VA: 0x1C31630
	public bool CanGreeting(NpcData npcData) { }

	// RVA: 0x1C31770 Offset: 0x1C31871 VA: 0x1C31770
	public bool CanGreetingWeather(int npcId, Weather weather) { }

	// RVA: 0x1C317D0 Offset: 0x1C318D1 VA: 0x1C317D0
	public bool CanGreetingPregnancy(int npcId) { }

	// RVA: 0x1C317F0 Offset: 0x1C318F1 VA: 0x1C317F0
	public bool IsTraveler(NpcData npcData) { }

	// RVA: 0x1C31810 Offset: 0x1C31911 VA: 0x1C31810
	public bool IsSerious() { }

	// RVA: 0x1C316B0 Offset: 0x1C317B1 VA: 0x1C316B0
	public bool IsSub(NpcData npcData) { }

	// RVA: 0x1C31820 Offset: 0x1C31921 VA: 0x1C31820
	public bool IsScenarioSupport(int npcId, bool isTalk = False) { }

	// RVA: 0x1C31B10 Offset: 0x1C31C11 VA: 0x1C31B10
	public bool IsPartyTalk() { }

	// RVA: 0x1C31B20 Offset: 0x1C31C21 VA: 0x1C31B20
	public bool IsLongTimeTalk(NpcData npcData) { }

	// RVA: 0x1C31B40 Offset: 0x1C31C41 VA: 0x1C31B40
	public bool IsParty() { }

	// RVA: 0x1C31B50 Offset: 0x1C31C51 VA: 0x1C31B50
	public bool IsSlipDownTalk() { }

	// RVA: 0x1C31B60 Offset: 0x1C31C61 VA: 0x1C31B60
	public bool IsLethargy(int npcid = 0) { }

	// RVA: 0x1C31BE0 Offset: 0x1C31CE1 VA: 0x1C31BE0
	public bool IsViewByTheWay() { }

	// RVA: 0x1C31D50 Offset: 0x1C31E51 VA: 0x1C31D50
	private NpcEventType GetFirstTalkEventType() { }

	// RVA: 0x1C31FC0 Offset: 0x1C320C1 VA: 0x1C31FC0
	public void SetNpcLookPlayer() { }

	// RVA: 0x1C32130 Offset: 0x1C32231 VA: 0x1C32130
	public void ShopEnd() { }

	// RVA: 0x1C32610 Offset: 0x1C32711 VA: 0x1C32610
	public void ShopEnd_Furniture() { }

	// RVA: 0x1C32680 Offset: 0x1C32781 VA: 0x1C32680
	public void ShopEnd_Restaurent() { }

	// RVA: 0x1C328A0 Offset: 0x1C329A1 VA: 0x1C328A0
	private void EatPlayTimelineAfter() { }

	// RVA: 0x1C27950 Offset: 0x1C27A51 VA: 0x1C27950
	public void inWantedEnd() { }

	// RVA: 0x1C27D60 Offset: 0x1C27E61 VA: 0x1C27D60
	public bool NpcEventNext(bool research = False) { }

	// RVA: 0x1C32F70 Offset: 0x1C33071 VA: 0x1C32F70
	public bool SetNpcLookPlayerEnd() { }

	// RVA: 0x1C32FD0 Offset: 0x1C330D1 VA: 0x1C32FD0
	private bool ForceScriptEventStart() { }

	// RVA: 0x1C33100 Offset: 0x1C33201 VA: 0x1C33100
	public void RunScript(NpcEventType NowType) { }

	// RVA: 0x1C3BF60 Offset: 0x1C3C061 VA: 0x1C3BF60
	public void PlayerEventProceed(int EventId, int EventStep, int NpcId) { }

	// RVA: 0x1C3C1A0 Offset: 0x1C3C2A1 VA: 0x1C3C1A0
	public void FestivalJoin(string join_scriptname, string join_ng_scriptname) { }

	// RVA: 0x1C3C310 Offset: 0x1C3C411 VA: 0x1C3C310
	public void EventLoad(string scriptname) { }

	// RVA: 0x1C3C390 Offset: 0x1C3C491 VA: 0x1C3C390
	public void SelectedQuest(int questIdx) { }

	// RVA: 0x1C22670 Offset: 0x1C22771 VA: 0x1C22670
	public EventScheduleData GetCurrentEventScheduleData(NpcController npc) { }

	// RVA: 0x1C3C410 Offset: 0x1C3C511 VA: 0x1C3C410
	public EventScheduleData GetCurrentEventScheduleData() { }

	// RVA: 0x1C3C560 Offset: 0x1C3C661 VA: 0x1C3C560
	public void SetEventFlagPoint(int[] FlagIndexs, bool FlagValue) { }

	// RVA: 0x1C3C5E0 Offset: 0x1C3C6E1 VA: 0x1C3C5E0
	public void CheckEventFlagPoint(int[] FlagIndexs, bool FlagValue, int thenStep, int elseStep) { }

	// RVA: 0x1C3C710 Offset: 0x1C3C811 VA: 0x1C3C710
	public void NpcEventTalkReserve(int EventId, int EventStep, int[] npcIds) { }

	// RVA: 0x1C3C8E0 Offset: 0x1C3C9E1 VA: 0x1C3C8E0
	public void NpcEventTalkRelease(int[] npcIds) { }

	// RVA: 0x1C3CAB0 Offset: 0x1C3CBB1 VA: 0x1C3CAB0
	public void ContitionalJudgment(stCommand_t cmd) { }

	// RVA: 0x1C40B90 Offset: 0x1C40C91 VA: 0x1C40B90
	public void CompareParam(int comparisonOperator, long value1, long value2, int thenStep, int elseStep) { }

	// RVA: 0x1C40CA0 Offset: 0x1C40DA1 VA: 0x1C40CA0
	public void AddPoint(int NpcId, int value1, string value2) { }

	// RVA: 0x1C40E70 Offset: 0x1C40F71 VA: 0x1C40E70
	public void SetBossKillFlag(string bossName) { }

	// RVA: 0x1C40FB0 Offset: 0x1C410B1 VA: 0x1C40FB0
	public void EventTriggerCheck(EventTriggerType eventTriggerType, string enemyName = "") { }

	// RVA: 0x1C2B1C0 Offset: 0x1C2B2C1 VA: 0x1C2B1C0
	private void DoEventTrigger() { }

	// RVA: 0x1C41250 Offset: 0x1C41351 VA: 0x1C41250
	public void SetActiveEvent_DEBUG(int eventtype, int eventid, int eventstep, int npcid, int npcstep) { }

	// RVA: 0x1C2B820 Offset: 0x1C2B921 VA: 0x1C2B820
	private void EventStartCheck() { }

	// RVA: 0x1C22540 Offset: 0x1C22641 VA: 0x1C22540
	public void EventScheduleProceed() { }

	// RVA: 0x1C2B100 Offset: 0x1C2B201 VA: 0x1C2B100
	public void EventProceed() { }

	// RVA: 0x1C41290 Offset: 0x1C41391 VA: 0x1C41290
	public bool ProceedWithOrder(OrderType orderType) { }

	// RVA: 0x1C41390 Offset: 0x1C41491 VA: 0x1C41390
	public bool ProceedWithOrder(OrderType orderType, GameObject gameObject) { }

	// RVA: 0x1C41410 Offset: 0x1C41511 VA: 0x1C41410
	public bool ProceedWithOrder(OrderType orderType, ItemData item) { }

	// RVA: 0x1C41490 Offset: 0x1C41591 VA: 0x1C41490
	public bool ProceedWithOrder(OrderType orderType, int targetId) { }

	// RVA: 0x1C415A0 Offset: 0x1C416A1 VA: 0x1C415A0
	public bool ProceedWithOrder(OrderType orderType, int targetId, int type) { }

	// RVA: 0x1C41300 Offset: 0x1C41401 VA: 0x1C41300
	public bool ProceedWithOrder(OrderType orderType, int npcId, GameObject gameObject, ItemData item) { }

	// RVA: 0x1C41510 Offset: 0x1C41611 VA: 0x1C41510
	public bool ProceedWithOrder(OrderType orderType, int npcId, int targetId, GameObject gameObject, ItemData item) { }

	// RVA: 0x1C31360 Offset: 0x1C31461 VA: 0x1C31360
	public void OffChatWindow() { }

	// RVA: 0x1C41620 Offset: 0x1C41721 VA: 0x1C41620
	private void ChoiceListAdd(int nextStep, int answerId) { }

	// RVA: 0x1C416A0 Offset: 0x1C417A1 VA: 0x1C416A0
	private void ChoiceListClear() { }

	// RVA: 0x1C25310 Offset: 0x1C25411 VA: 0x1C25310
	public void AppearSelectMenu(string charaName, int groupId, int answerId, string message, int nextStep, bool useCancelButton = False) { }

	// RVA: 0x1C41950 Offset: 0x1C41A51 VA: 0x1C41950
	public void AppearSelectMenuWithHintMsg(string charaName, int groupId, int answerId, string message, string hintMsg, string hintName, int nextStep, bool useCancelButton = False) { }

	// RVA: 0x1C41710 Offset: 0x1C41811 VA: 0x1C41710
	private string SettingAppearSelectMenuMessage(int groupId, int answerId, string message) { }

	// RVA: 0x1C329E0 Offset: 0x1C32AE1 VA: 0x1C329E0
	public void SetCurrentNpcEventStep(int npcId, int currentStep) { }

	// RVA: 0x1C41BB0 Offset: 0x1C41CB1 VA: 0x1C41BB0
	public void SetCurrentNpcEventStep(int currentStep) { }

	// RVA: 0x1C1E090 Offset: 0x1C1E191 VA: 0x1C1E090
	public void SetNextNpcEventStep(int npcId, int nextStep) { }

	// RVA: 0x1C41C30 Offset: 0x1C41D31 VA: 0x1C41C30
	public void SetNextNpcEventStep(int nextStep) { }

	// RVA: 0x1C3AF90 Offset: 0x1C3B091 VA: 0x1C3AF90
	public int EventStepProceedReserve(int orderId) { }

	// RVA: 0x1C41CB0 Offset: 0x1C41DB1 VA: 0x1C41CB0
	public void EventStepProceed() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E1D0 Offset: 0x19E2D1 VA: 0x19E1D0
	// RVA: 0x1C41D00 Offset: 0x1C41E01 VA: 0x1C41D00
	public int get_LastSelect() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E1E0 Offset: 0x19E2E1 VA: 0x19E1E0
	// RVA: 0x1C41D10 Offset: 0x1C41E11 VA: 0x1C41D10
	private void set_LastSelect(int value) { }

	// RVA: 0x1C41D20 Offset: 0x1C41E21 VA: 0x1C41D20
	public void SelectedMenu(int nextStep) { }

	// RVA: 0x1C43850 Offset: 0x1C43951 VA: 0x1C43850
	public void SelectedGender() { }

	// RVA: 0x1C438F0 Offset: 0x1C439F1 VA: 0x1C438F0
	public void EndNext() { }

	// RVA: 0x1C43750 Offset: 0x1C43851 VA: 0x1C43750
	private void SelectedMenuEnd() { }

	// RVA: 0x1C422E0 Offset: 0x1C423E1 VA: 0x1C422E0
	private void SelectedMenuGroup(int nextStep) { }

	// RVA: 0x1C32B30 Offset: 0x1C32C31 VA: 0x1C32B30
	public void onEventStart() { }

	// RVA: 0x1C439A0 Offset: 0x1C43AA1 VA: 0x1C439A0
	private void ResetChara(Character chara) { }

	// RVA: 0x1C1BA30 Offset: 0x1C1BB31 VA: 0x1C1BA30
	public void onTalkEnd() { }

	// RVA: 0x1C31020 Offset: 0x1C31121 VA: 0x1C31020
	public void onEventFinished(string filePath = "") { }

	// RVA: 0x1C43B60 Offset: 0x1C43C61 VA: 0x1C43B60
	public void SetCameraResetFlag(EventCameraResetType value) { }

	// RVA: 0x1C2EDA0 Offset: 0x1C2EEA1 VA: 0x1C2EDA0
	public void CameraReset(NpcEventType eventType, NpcData npcData) { }

	// RVA: 0x1C43C40 Offset: 0x1C43D41 VA: 0x1C43C40
	public void ChangePlayerCamera() { }

	// RVA: 0x1C43B70 Offset: 0x1C43C71 VA: 0x1C43B70
	public void ChangePlayerCamera(bool cameraReset) { }

	// RVA: 0x1C1B2D0 Offset: 0x1C1B3D1 VA: 0x1C1B2D0
	private NpcData GetNpcData(int npcId) { }

	// RVA: 0x1C43C50 Offset: 0x1C43D51 VA: 0x1C43C50
	public void SetTargetNpc(int npcId) { }

	// RVA: 0x1C1B680 Offset: 0x1C1B781 VA: 0x1C1B680
	public void SetByTheWayActive(bool value, NpcData data) { }

	// RVA: 0x1C3BEA0 Offset: 0x1C3BFA1 VA: 0x1C3BEA0
	public void AdvStartByCmd(stCommand_t[] cmdList, int npcId = -1, bool resetStep = True) { }

	// RVA: 0x1C43D60 Offset: 0x1C43E61 VA: 0x1C43D60
	public stCommand_t MakeCmd(int CmdId, int[] Arg, string[] ArgText) { }

	// RVA: 0x1C43DD0 Offset: 0x1C43ED1 VA: 0x1C43DD0
	public stCommand_t MakeCmd_Message(string charaName, int charaNameId, int faceNameId, int positionNameId, string message, string voiceName) { }

	// RVA: 0x1C441B0 Offset: 0x1C442B1 VA: 0x1C441B0
	public stCommand_t MakeCmd_SelectMessage(string charaName, int npcId, int groupId, int answerId, string message, int nextStep) { }

	// RVA: 0x1C44450 Offset: 0x1C44551 VA: 0x1C44450
	public stCommand_t MakeCmd_GoToStepNext(int step = 1) { }

	// RVA: 0x1C3BDD0 Offset: 0x1C3BED1 VA: 0x1C3BDD0
	public stCommand_t MakeCmd_End(int wait = -1) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E1F0 Offset: 0x19E2F1 VA: 0x19E1F0
	// RVA: 0x1C44520 Offset: 0x1C44621 VA: 0x1C44520
	public IEnumerator LifeCycleEventEndFinish(float wait) { }

	// RVA: 0x1C2EEC0 Offset: 0x1C2EFC1 VA: 0x1C2EEC0
	public NpcEventType GetNpcEventTypeFromPath(string Path, bool setEventId = True) { }

	// RVA: 0x1C1C5E0 Offset: 0x1C1C6E1 VA: 0x1C1C5E0
	public bool CheckQueueSameScriptType(string scriptName) { }

	// RVA: 0x1C223D0 Offset: 0x1C224D1 VA: 0x1C223D0
	public bool IsHintTalkNPC(NpcData npcData) { }

	// RVA: 0x1C21E60 Offset: 0x1C21F61 VA: 0x1C21E60
	public int GetBaybBirthTalk() { }

	// RVA: 0x1C44580 Offset: 0x1C44681 VA: 0x1C44580
	public SoundID GetCharaCalling(int npcid) { }

	// RVA: 0x1C44740 Offset: 0x1C44841 VA: 0x1C44740
	public void DEBUG_EventFlagCancel() { }

	// RVA: 0x1C44830 Offset: 0x1C44931 VA: 0x1C44830
	public void DEBUG_SubEventCheck(int id) { }

	// RVA: 0x1C44840 Offset: 0x1C44941 VA: 0x1C44840
	public void DEBUG_EventPicDisplay(int value, bool onoff) { }

	// RVA: 0x1C448B0 Offset: 0x1C449B1 VA: 0x1C448B0
	public void DisableTextWindow() { }

	// RVA: 0x1C44950 Offset: 0x1C44A51 VA: 0x1C44950
	public void SetAnimationUpdateMode(AnimatorUpdateMode mode) { }

	// RVA: 0x1C44960 Offset: 0x1C44A61 VA: 0x1C44960
	public void SetAnimationUpdateMode(Character character, AnimatorUpdateMode mode) { }

	// RVA: 0x1C30EF0 Offset: 0x1C30FF1 VA: 0x1C30EF0
	public PartyBase GetPartyBase(int npcId) { }

	// RVA: 0x1C44A50 Offset: 0x1C44B51 VA: 0x1C44A50
	public void DEBUG_SetLoveStoryProgress(int idx, int state) { }

	// RVA: 0x1C3B1F0 Offset: 0x1C3B2F1 VA: 0x1C3B1F0
	public void CollectFestivalNPC() { }

	// RVA: 0x1C44AF0 Offset: 0x1C44BF1 VA: 0x1C44AF0
	public void CallFestivalResult() { }

	// RVA: 0x1C44CD0 Offset: 0x1C44DD1 VA: 0x1C44CD0
	public void FlagPointUpdateData(bool value, GameFlagData flag) { }

	// RVA: 0x1C45000 Offset: 0x1C45101 VA: 0x1C45000
	public void FlagPointUpdateVisible(bool value, GameFlagData flag) { }

	// RVA: 0x1C45400 Offset: 0x1C45501 VA: 0x1C45400
	public void SelectChild2Personality(bool isMan) { }

	// RVA: 0x1C28A70 Offset: 0x1C28B71 VA: 0x1C28A70
	public void AfterLoadFlagUpdateData() { }

	// RVA: 0x1C45B40 Offset: 0x1C45C41 VA: 0x1C45B40
	public void TimeSkipResetFlag() { }

	// RVA: 0x1C45BE0 Offset: 0x1C45CE1 VA: 0x1C45BE0
	public void .ctor() { }

	// RVA: 0x1C45E50 Offset: 0x1C45F51 VA: 0x1C45E50
	private static void .cctor() { }
}

