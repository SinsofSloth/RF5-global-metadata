public class FarmMonsterBehaviorController : MonsterBehaviorController // TypeDefIndex: 8159
{
	// Fields
	private MonsterHutAreaInterface MonsterHutAreaInterface; // 0x120
	private SharedFarmMonsterState SharedFarmMonsterState; // 0x128
	private SharedFarmMonsterHutState SharedFarmMonsterHutState; // 0x130
	private SharedFarmMonsterWorkState SharedFarmMonsterWorkState; // 0x138
	private SharedFloat SharedWaitBehaviorTime; // 0x140
	private SharedVector3 SharedMovePosition; // 0x148
	private SharedBool SharedUseEmotion; // 0x150
	private SharedEmotionType SharedEmotionType; // 0x158
	private Action[] MonsterHutStateUpdate; // 0x160
	private int CurrentIndex; // 0x168
	private bool IsPlayerInArea; // 0x16C
	private FriendMonsterStatus _FriendMonsterStatus; // 0x170

	// Properties
	private FriendMonsterStatus FriendMonsterStatus { get; }

	// Methods

	// RVA: 0x202CD70 Offset: 0x202CE71 VA: 0x202CD70
	private FriendMonsterStatus get_FriendMonsterStatus() { }

	// RVA: 0x202CE30 Offset: 0x202CF31 VA: 0x202CE30
	public bool IsEndWorkState() { }

	// RVA: 0x202CEA0 Offset: 0x202CFA1 VA: 0x202CEA0
	public void OrderChangeState(FarmMonsterState state) { }

	// RVA: 0x202CF40 Offset: 0x202D041 VA: 0x202CF40
	public void OrderChangeWorkState(FarmMonsterWorkState state) { }

	// RVA: 0x202CFF0 Offset: 0x202D0F1 VA: 0x202CFF0
	public void SetMovePosition(Vector3 position) { }

	// RVA: 0x202D070 Offset: 0x202D171 VA: 0x202D070
	public void SetMonsterHutArea(MonsterHutAreaInterface monsterHutAreaInterface) { }

	// RVA: 0x202D4E0 Offset: 0x202D5E1 VA: 0x202D4E0
	public void UpdateBehavior() { }

	// RVA: 0x202DD40 Offset: 0x202DE41 VA: 0x202DD40
	public void UpdateClosePlayerPosition() { }

	// RVA: 0x202E4A0 Offset: 0x202E5A1 VA: 0x202E4A0
	public void UpdateLeavePlayerPosition() { }

	// RVA: 0x202E160 Offset: 0x202E261 VA: 0x202E160
	public void UpdateWanderPosition() { }

	// RVA: 0x202E810 Offset: 0x202E911 VA: 0x202E810
	private Vector3 GetNavmeshRayCastPoint(Vector3 sorcePosition, Vector3 targetPosition) { }

	// RVA: 0x202E890 Offset: 0x202E991 VA: 0x202E890
	public void SetPlayerInArea(bool isPlayerInArea) { }

	// RVA: 0x202D7D0 Offset: 0x202D8D1 VA: 0x202D7D0
	public void UpdateHutBehaviorState() { }

	// RVA: 0x202E8A0 Offset: 0x202E9A1 VA: 0x202E8A0 Slot: 49
	protected override void OnDestroy() { }

	// RVA: 0x202E980 Offset: 0x202EA81 VA: 0x202E980 Slot: 20
	public override void SetStopBehavior(bool isStopBehavior) { }

	// RVA: 0x202EA10 Offset: 0x202EB11 VA: 0x202EA10 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x202EA40 Offset: 0x202EB41 VA: 0x202EA40 Slot: 19
	protected override void OnGetVariableBehaviorParameter() { }

	// RVA: 0x202EF30 Offset: 0x202F031 VA: 0x202EF30 Slot: 16
	protected override void OnSetupSearchCharacterController() { }

	// RVA: 0x202EF70 Offset: 0x202F071 VA: 0x202EF70 Slot: 51
	public override void SetTarget(CharacterBase target) { }

	// RVA: 0x202EF80 Offset: 0x202F081 VA: 0x202EF80 Slot: 53
	public override void StartActionCodeBase() { }

	// RVA: 0x202EFB0 Offset: 0x202F0B1 VA: 0x202EFB0 Slot: 63
	public override void OnDead() { }

	// RVA: 0x202EFC0 Offset: 0x202F0C1 VA: 0x202EFC0
	public void .ctor() { }
}

