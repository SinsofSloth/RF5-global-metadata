public class BossStageManager : MonoBehaviour // TypeDefIndex: 7727
{
	// Fields
	[HeaderAttribute] // RVA: 0x168D00 Offset: 0x168E01 VA: 0x168D00
	[SerializeField] // RVA: 0x168D00 Offset: 0x168E01 VA: 0x168D00
	public GateDataID GateDataID; // 0x18
	[HeaderAttribute] // RVA: 0x168D50 Offset: 0x168E51 VA: 0x168D50
	[SerializeField] // RVA: 0x168D50 Offset: 0x168E51 VA: 0x168D50
	private int _StageIndex; // 0x1C
	private GateDataTable CurrentGateDataTable; // 0x20
	private GateStatusDataTable CurrentGateStatusDataTable; // 0x30
	private MonsterControllerBase InstantiateBoss; // 0x58
	[SerializeField] // RVA: 0x168DA0 Offset: 0x168EA1 VA: 0x168DA0
	public Transform AppearBossTransform; // 0x60
	[SerializeField] // RVA: 0x168DB0 Offset: 0x168EB1 VA: 0x168DB0
	public Transform WarpFriendlyTransform; // 0x68
	[SerializeField] // RVA: 0x168DC0 Offset: 0x168EC1 VA: 0x168DC0
	private List<GameObject> Walls; // 0x70
	[HeaderAttribute] // RVA: 0x168DD0 Offset: 0x168ED1 VA: 0x168DD0
	[SerializeField] // RVA: 0x168DD0 Offset: 0x168ED1 VA: 0x168DD0
	public GameFlagData FirstKill_Boss_Flag; // 0x78
	[HeaderAttribute] // RVA: 0x168E20 Offset: 0x168F21 VA: 0x168E20
	[HeaderAttribute] // RVA: 0x168E20 Offset: 0x168F21 VA: 0x168E20
	[SerializeField] // RVA: 0x168E20 Offset: 0x168F21 VA: 0x168E20
	private GameObject RematchObject; // 0x80
	[HeaderAttribute] // RVA: 0x168EA0 Offset: 0x168FA1 VA: 0x168EA0
	[SerializeField] // RVA: 0x168EA0 Offset: 0x168FA1 VA: 0x168EA0
	public GameFlagData RematchDisplayFlag; // 0x88
	[HeaderAttribute] // RVA: 0x168F00 Offset: 0x169001 VA: 0x168F00
	[SerializeField] // RVA: 0x168F00 Offset: 0x169001 VA: 0x168F00
	public GameFlagData RematchNotDisplayFlag; // 0x8C
	[HeaderAttribute] // RVA: 0x168F60 Offset: 0x169061 VA: 0x168F60
	[SerializeField] // RVA: 0x168F60 Offset: 0x169061 VA: 0x168F60
	public GameFlagData ForceActiveWallFlag; // 0x90
	private bool CheckForceActiveWallFlag; // 0x94
	private bool IsForceActiveWall; // 0x95
	private bool IsActiveRematchObject; // 0x96
	public OnDeadEventBossStage OnDeadEventBossStage; // 0x98
	protected bool _IsBattleNow; // 0xA0
	private static Dictionary<string, GameFlagData> BossRematchObjectInActiveFlagDict; // 0x0

	// Properties
	public int StageIndex { get; }
	public bool CheckBattleNow { get; set; }

	// Methods

	// RVA: 0x205CF00 Offset: 0x205D001 VA: 0x205CF00
	public int get_StageIndex() { }

	// RVA: 0x205CF10 Offset: 0x205D011 VA: 0x205CF10
	public bool get_CheckBattleNow() { }

	// RVA: 0x205CF20 Offset: 0x205D021 VA: 0x205CF20
	protected void set_CheckBattleNow(bool value) { }

	// RVA: 0x205CF30 Offset: 0x205D031 VA: 0x205CF30
	private void SetCheckForceActiveWallFlag(bool isCheck) { }

	// RVA: 0x205CF50 Offset: 0x205D051 VA: 0x205CF50 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x205CF60 Offset: 0x205D061 VA: 0x205CF60
	private void UpdateActiveWallFlag() { }

	// RVA: 0x205D250 Offset: 0x205D351 VA: 0x205D250
	private void Update() { }

	// RVA: 0x205D260 Offset: 0x205D361 VA: 0x205D260
	public void Setup(GateDataTable gateDataTable) { }

	// RVA: 0x205D2D0 Offset: 0x205D3D1 VA: 0x205D2D0
	public void Play(int eventStatusIndex = 0, Action<BossBehaviorController> callBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A2A90 Offset: 0x1A2B91 VA: 0x1A2A90
	// RVA: 0x205D380 Offset: 0x205D481 VA: 0x205D380
	private IEnumerator AsyncPlay(int eventStatusIndex = 0, Action<BossBehaviorController> callBack) { }

	// RVA: 0x205D450 Offset: 0x205D551 VA: 0x205D450 Slot: 5
	protected virtual void OnSetup() { }

	// RVA: 0x205D460 Offset: 0x205D561 VA: 0x205D460 Slot: 6
	protected virtual void OnBeforeCreateBoss() { }

	// RVA: 0x205D470 Offset: 0x205D571 VA: 0x205D470 Slot: 7
	protected virtual void OnAfterCreateBoss(BossBehaviorController controller) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A2B00 Offset: 0x1A2C01 VA: 0x1A2B00
	// RVA: 0x205D480 Offset: 0x205D581 VA: 0x205D480
	private IEnumerator CreateBoss(int eventStatusIndex, Action<BossBehaviorController> callBack) { }

	// RVA: 0x205D550 Offset: 0x205D651 VA: 0x205D550
	public void DestroyBoss() { }

	// RVA: 0x205D610 Offset: 0x205D711 VA: 0x205D610
	private void OnDeadBoss(MonsterControllerBase monsterControllerBase) { }

	// RVA: 0x205D020 Offset: 0x205D121 VA: 0x205D020
	private void SetActiveWalls(bool isActive) { }

	// RVA: 0x205D6A0 Offset: 0x205D7A1 VA: 0x205D6A0
	public string GetEmergenceBossName(int eventStatusIndex) { }

	// RVA: 0x205D7F0 Offset: 0x205D8F1 VA: 0x205D7F0
	private void UpdateRematchObjectDisplayFlag() { }

	// RVA: 0x205D8F0 Offset: 0x205D9F1 VA: 0x205D8F0
	private bool CheckRematchDisplayFlag(int RematchDisplayFlag, string objectName) { }

	// RVA: 0x205D170 Offset: 0x205D271 VA: 0x205D170
	private void SetDisplayRematchObject(bool isDisplay) { }

	// RVA: 0x205DA20 Offset: 0x205DB21 VA: 0x205DA20
	public void WarpPartnerPosition() { }

	// RVA: 0x205DB00 Offset: 0x205DC01 VA: 0x205DB00
	public void .ctor() { }

	// RVA: 0x205DB80 Offset: 0x205DC81 VA: 0x205DB80
	private static void .cctor() { }
}

