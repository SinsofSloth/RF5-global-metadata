public class PartnerManager : SingletonMonoBehaviour<PartnerManager> // TypeDefIndex: 8173
{
	// Fields
	private const float FadeInTime = 0.35;
	private const float ForceDeadWarpDistance = 40;
	private const float ForceWarpDistance = 20;
	private const float UpdatePartnerDirectionDistance = 0.01;
	private const float CheckCanForceWarpTime = 1;
	private const int FriendPriorityMin = 1;
	private const int FriendPriorityMax = 9;
	private const float SubNavMeshSamplePositionDistance = 1;
	public float BehaviorInterval; // 0x18
	public float WalkMargin; // 0x1C
	public const float WalkSpeedScale = 0.25;
	public List<PartnerManager.PartnerSearchRange> SearchRangeList; // 0x20
	public readonly Dictionary<PartnerMovementOrderType, float> PartnerMovementRange; // 0x28
	public readonly Dictionary<int, List<PartnerManager.DestinationAngle>> PartyDestinationAngleListDic; // 0x30
	private Vector3 LatestUpdatePlayerPositionByPartnerDirection; // 0x38
	private Vector3 LatestPlayerPosition; // 0x44
	private Vector3 LatestPlayerForward; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x16B750 Offset: 0x16B851 VA: 0x16B750
	private List<AIInput> <PartnerList>k__BackingField; // 0x60
	public MonsterControllerBase PlayMonster; // 0x68
	public float ForceWarpTimer; // 0x70
	public int NavmeshAgentPriority; // 0x74
	private NavMeshHit NavMeshHit; // 0x78
	private int LoadingPartyMonsterCount; // 0x9C
	private Vector3 PartnerDirection; // 0xA0
	private FriendJudgmentManager FriendJudgmentManager; // 0xB0
	private List<int> ExceptionPartyOutList; // 0xB8
	public bool IsHandCuffsPartner; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x16B760 Offset: 0x16B861 VA: 0x16B760
	private List<PartnerManager.NPCChangeBaseParameter> <NPCChangeBaseParameterList>k__BackingField; // 0xC8
	private bool IsOpenLeaveAdvWindow; // 0xD0
	private LinkedList<PartnerManager.LeaveHandCuffsParam> HandCuffsMonsterLeaveParamLinkedList; // 0xD8

	// Properties
	public Vector3 PlayerPosition { get; }
	public Vector3 PlayerForward { get; }
	public Vector3 PlayerBack { get; }
	public List<AIInput> PartnerList { get; set; }
	public List<PartnerManager.NPCChangeBaseParameter> NPCChangeBaseParameterList { get; set; }

	// Methods

	// RVA: 0x21C2990 Offset: 0x21C2A91 VA: 0x21C2990
	public Vector3 get_PlayerPosition() { }

	// RVA: 0x21C2AB0 Offset: 0x21C2BB1 VA: 0x21C2AB0
	public Vector3 get_PlayerForward() { }

	// RVA: 0x21C2BD0 Offset: 0x21C2CD1 VA: 0x21C2BD0
	public Vector3 get_PlayerBack() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A64A0 Offset: 0x1A65A1 VA: 0x1A64A0
	// RVA: 0x21C2C70 Offset: 0x21C2D71 VA: 0x21C2C70
	public List<AIInput> get_PartnerList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A64B0 Offset: 0x1A65B1 VA: 0x1A64B0
	// RVA: 0x21C2C80 Offset: 0x21C2D81 VA: 0x21C2C80
	private void set_PartnerList(List<AIInput> value) { }

	// RVA: 0x21C2C90 Offset: 0x21C2D91 VA: 0x21C2C90
	public void Debug_ChangePlayerDistanceList(PartnerMovementOrderType type, float distance) { }

	// RVA: 0x21C2D10 Offset: 0x21C2E11 VA: 0x21C2D10
	public void Debug_ChangeBehaviorInterval(float time) { }

	// RVA: 0x21C2D20 Offset: 0x21C2E21 VA: 0x21C2D20
	public void Debug_ChangeWalkMargin(float margin) { }

	// RVA: 0x21C2D30 Offset: 0x21C2E31 VA: 0x21C2D30
	private void SetupPartnerList() { }

	// RVA: 0x21C2D90 Offset: 0x21C2E91 VA: 0x21C2D90
	public void OnAfterGameDataLoad() { }

	// RVA: 0x21C2E90 Offset: 0x21C2F91 VA: 0x21C2E90
	public void ExcuteFriendMonsterActionScript() { }

	// RVA: 0x21C31D0 Offset: 0x21C32D1 VA: 0x21C31D0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x21C32D0 Offset: 0x21C33D1 VA: 0x21C32D0
	public void AddPartner(AIInput input) { }

	// RVA: 0x21C33F0 Offset: 0x21C34F1 VA: 0x21C33F0
	private void SetNavMeshAgentPriority(Character character) { }

	// RVA: 0x21C34E0 Offset: 0x21C35E1 VA: 0x21C34E0
	public void RemovePartner(AIInput input) { }

	// RVA: 0x21C35F0 Offset: 0x21C36F1 VA: 0x21C35F0
	public bool IsPartyCompleted() { }

	// RVA: 0x21C2E30 Offset: 0x21C2F31 VA: 0x21C2E30
	private void ResetParameterList() { }

	// RVA: 0x21C3670 Offset: 0x21C3771 VA: 0x21C3670
	private void SetDisplayAIInput(AIInput aIInput, bool isDisplay, bool isWarpTransformPosition = False) { }

	// RVA: 0x21C3C90 Offset: 0x21C3D91 VA: 0x21C3C90
	public void SetDisplayAll(bool isDisplay, bool isWarpTransformPosition = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A64C0 Offset: 0x1A65C1 VA: 0x1A64C0
	// RVA: 0x21C3E30 Offset: 0x21C3F31 VA: 0x21C3E30
	private IEnumerator AsyncAddFriendMonster(ActorID actorId, MonsterStatusBase monsterStatus, Action<MonsterBehaviorController> callBack) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6530 Offset: 0x1A6631 VA: 0x1A6530
	// RVA: 0x21C3F00 Offset: 0x21C4001 VA: 0x21C3F00
	public List<PartnerManager.NPCChangeBaseParameter> get_NPCChangeBaseParameterList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6540 Offset: 0x1A6641 VA: 0x1A6540
	// RVA: 0x21C3F10 Offset: 0x21C4011 VA: 0x21C3F10
	private void set_NPCChangeBaseParameterList(List<PartnerManager.NPCChangeBaseParameter> value) { }

	// RVA: 0x21C3F20 Offset: 0x21C4021 VA: 0x21C3F20
	private Actor CreateActor(ActorID id, NPCID nPCID, NpcData npcData) { }

	// RVA: 0x21C3FD0 Offset: 0x21C40D1 VA: 0x21C3FD0
	private bool TryGetNPCChangeBaseParameter(NPCID npcID, out PartnerManager.NPCChangeBaseParameter param) { }

	// RVA: 0x21C40B0 Offset: 0x21C41B1 VA: 0x21C40B0
	private bool TryGetPartnerNPCBehavior(ActorID id, out PartnerNPCBehaviorController partnerNPCBehaviorController) { }

	// RVA: 0x21C4170 Offset: 0x21C4271 VA: 0x21C4170
	public void AddNPCPartner(ActorID id, NPCID npcID, Action<PartnerNPCBehaviorController> callBack) { }

	// RVA: 0x21C4580 Offset: 0x21C4681 VA: 0x21C4580
	public void RemoveNPCPartner(ActorID id, ActorType actorType, NPCID npcID, Action<HumanController> callBack) { }

	// RVA: 0x21C4820 Offset: 0x21C4921 VA: 0x21C4820
	public void AddNPCPartner(ActorID id, Action<PartnerNPCBehaviorController> callBack) { }

	// RVA: 0x21C4910 Offset: 0x21C4A11 VA: 0x21C4910
	public void RemoveNPCPartner(ActorID id, ActorType actorType, Action<HumanController> callBack) { }

	// RVA: 0x21C4A10 Offset: 0x21C4B11 VA: 0x21C4A10
	public void ChangePartnerNPCModel(PartnerNPCController partnerNPC, Action<HumanController> callBack) { }

	// RVA: 0x21C4CE0 Offset: 0x21C4DE1 VA: 0x21C4CE0
	private void UpdateStatePartnerNPC() { }

	// RVA: 0x21C4FA0 Offset: 0x21C50A1 VA: 0x21C4FA0
	private void UpdateChangePartner(PartnerManager.NPCChangeBaseParameter param) { }

	// RVA: 0x21C5300 Offset: 0x21C5401 VA: 0x21C5300
	private void UpdateCreatePartnerBehavior(PartnerManager.NPCChangeBaseParameter param) { }

	// RVA: 0x21C5330 Offset: 0x21C5431 VA: 0x21C5330
	private void UpdateChangeNPC(PartnerManager.NPCChangeBaseParameter param) { }

	// RVA: 0x21C5410 Offset: 0x21C5511 VA: 0x21C5410
	private void UpdateChangeModel(PartnerManager.NPCChangeBaseParameter param) { }

	// RVA: 0x21C5560 Offset: 0x21C5661 VA: 0x21C5560
	public void RestartNPCAI(ActorID actorID) { }

	// RVA: 0x21C1680 Offset: 0x21C1781 VA: 0x21C1680
	public void StopNPCAI(ActorID actorID) { }

	// RVA: 0x21C5700 Offset: 0x21C5801 VA: 0x21C5700
	public void AddMonsterPartner(ActorID actorId, MonsterStatusBase monsterStatus, Action<MonsterBehaviorController> callBack) { }

	// RVA: 0x21C57B0 Offset: 0x21C58B1 VA: 0x21C57B0
	public void ChangeMonsterPartner(ActorID actorId, MonsterStatusBase status, MonsterControllerBase handCuffsMonster, Action<MonsterBehaviorController> callBack) { }

	// RVA: 0x21C59D0 Offset: 0x21C5AD1 VA: 0x21C59D0
	public void RemoveMonsterPartner(MonsterControllerBase controller) { }

	// RVA: 0x21C5AD0 Offset: 0x21C5BD1 VA: 0x21C5AD0
	public void RestartMonsterAI(MonsterControllerBase controller) { }

	// RVA: 0x21C5BD0 Offset: 0x21C5CD1 VA: 0x21C5BD0
	public void StopMonsterAI(MonsterControllerBase controller) { }

	// RVA: 0x21C5CE0 Offset: 0x21C5DE1 VA: 0x21C5CE0
	public void SetDisplayMonster(MonsterControllerBase controller, bool isDisplay) { }

	// RVA: 0x21C5DF0 Offset: 0x21C5EF1 VA: 0x21C5DF0
	private bool IsPartyMonsterActor(ActorID id) { }

	// RVA: 0x21C5E10 Offset: 0x21C5F11 VA: 0x21C5E10
	private void UpdatePartnerForceWarp() { }

	// RVA: 0x21C63C0 Offset: 0x21C64C1 VA: 0x21C63C0
	private void Start() { }

	// RVA: 0x21C63D0 Offset: 0x21C64D1 VA: 0x21C63D0
	private void Update() { }

	// RVA: 0x21C3850 Offset: 0x21C3951 VA: 0x21C3850
	private void WarpPartner(AIInput aIInput, Vector3 targetPosition) { }

	// RVA: 0x21C3C50 Offset: 0x21C3D51 VA: 0x21C3C50
	public void WarpPartner(AIInput aIInput, bool isFront = False) { }

	// RVA: 0x21C6E50 Offset: 0x21C6F51 VA: 0x21C6E50
	public void WarpPartner(Vector3 target) { }

	// RVA: 0x21C6F70 Offset: 0x21C7071 VA: 0x21C6F70
	public void WarpPartner(bool isFront = False) { }

	// RVA: 0x21C3DE0 Offset: 0x21C3EE1 VA: 0x21C3DE0
	private bool IsMonster(ActorID actorID) { }

	// RVA: 0x21C3E00 Offset: 0x21C3F01 VA: 0x21C3E00
	private bool IsRoom(FieldSceneId sceneId) { }

	// RVA: 0x21C71F0 Offset: 0x21C72F1 VA: 0x21C71F0
	private void OnEndTeleportFriends() { }

	// RVA: 0x21C6120 Offset: 0x21C6221 VA: 0x21C6120
	public bool IsInViewCamera(Vector3 position) { }

	// RVA: 0x21C62C0 Offset: 0x21C63C1 VA: 0x21C62C0
	public bool IsInRangePlayer(Vector3 position, float range) { }

	// RVA: 0x21C6970 Offset: 0x21C6A71 VA: 0x21C6970
	private Vector3 BlurPosition() { }

	// RVA: 0x21C76A0 Offset: 0x21C77A1 VA: 0x21C76A0
	public PartnerNPCBehaviorController GetPartnerNPCBehaviorController(NPCID id) { }

	// RVA: 0x21C78A0 Offset: 0x21C79A1 VA: 0x21C78A0
	public PartnerNPCController GetPartnerNPCController(NPCID id) { }

	// RVA: 0x21C79B0 Offset: 0x21C7AB1 VA: 0x21C79B0
	public HumanController GetCharacterControllerBase(NPCID id) { }

	// RVA: 0x21C7AC0 Offset: 0x21C7BC1 VA: 0x21C7AC0
	public bool IsExistPartner(int id) { }

	// RVA: 0x21C7CB0 Offset: 0x21C7DB1 VA: 0x21C7CB0
	public NpcData GetPartnerNpcData(NPCID id) { }

	// RVA: 0x21C6560 Offset: 0x21C6661 VA: 0x21C6560
	private void UpdatePartnerDirection() { }

	// RVA: 0x21C6A80 Offset: 0x21C6B81 VA: 0x21C6A80
	public Vector3 GetDistination(AIInput aIInput, bool isFront, PartnerMovementOrderType partnerMovementOder) { }

	// RVA: 0x21C7D70 Offset: 0x21C7E71 VA: 0x21C7D70
	public int GetPartnerNum() { }

	// RVA: 0x21C7DC0 Offset: 0x21C7EC1 VA: 0x21C7DC0
	public List<Character> CheckTargetList(PartnerNPCBehaviorController character, NPCFindTargetDataTable findData) { }

	// RVA: 0x21C6870 Offset: 0x21C6971 VA: 0x21C6870
	private bool IsOrder() { }

	// RVA: 0x21C68F0 Offset: 0x21C69F1 VA: 0x21C68F0
	private void UpdateOrderOpenWindow() { }

	// RVA: 0x21C8690 Offset: 0x21C8791 VA: 0x21C8690
	private bool IsOrderRemainingOpenHandCuffsLeaveADVWindow() { }

	// RVA: 0x21C86F0 Offset: 0x21C87F1 VA: 0x21C86F0
	private void OpenHandCuffsLeaveADVWindow() { }

	// RVA: 0x21C8B80 Offset: 0x21C8C81 VA: 0x21C8B80
	private void CloseHandCuffsLeaveADVWindow(PartnerManager.LeaveHandCuffsParam param) { }

	// RVA: 0x21C8C00 Offset: 0x21C8D01 VA: 0x21C8C00
	public void OrderOpenHandCuffsLeaveADVWindow(MonsterControllerBase monster, Action callBack) { }

	// RVA: 0x21C8CC0 Offset: 0x21C8DC1 VA: 0x21C8CC0
	public void OrderFriendJudgment(MonsterControllerBase monster, Action<bool, string> callBack) { }

	// RVA: 0x21C8CE0 Offset: 0x21C8DE1 VA: 0x21C8CE0
	public void .ctor() { }
}

