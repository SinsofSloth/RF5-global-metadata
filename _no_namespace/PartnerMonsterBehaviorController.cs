public class PartnerMonsterBehaviorController : MonsterBehaviorController // TypeDefIndex: 8161
{
	// Fields
	private const float DEAD_INVINCIBLETIME = 1;
	private KeyAndValue<PartnerMonsterBehaviorController.ActionType, int>[] ActionLot; // 0x120
	private KeyAndValue<MovementBehaviorType, int>[] EndAttackMovementLot; // 0x128
	private KeyAndValue<float, int>[] EndAttackMoveSpeedScaleLot; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x16B700 Offset: 0x16B801 VA: 0x16B700
	private PartnerBehaviorType <PartnerBehaviorType>k__BackingField; // 0x138
	public PartnerMovementController PartnerMovementController; // 0x140
	private MonsterActionBehaviorController ActionBehaviorController; // 0x148
	public SharedBool IgnorePlayer; // 0x150
	public bool IsOrderActionScript; // 0x158

	// Properties
	public PartnerBehaviorType PartnerBehaviorType { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6460 Offset: 0x1A6561 VA: 0x1A6460
	// RVA: 0x21CA140 Offset: 0x21CA241 VA: 0x21CA140
	public PartnerBehaviorType get_PartnerBehaviorType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6470 Offset: 0x1A6571 VA: 0x1A6470
	// RVA: 0x21CA150 Offset: 0x21CA251 VA: 0x21CA150
	protected void set_PartnerBehaviorType(PartnerBehaviorType value) { }

	// RVA: 0x21CA160 Offset: 0x21CA261 VA: 0x21CA160 Slot: 4
	protected override void Start() { }

	// RVA: 0x21C3120 Offset: 0x21C3221 VA: 0x21C3120
	public void OrderExcuteActionScript() { }

	// RVA: 0x21CA170 Offset: 0x21CA271 VA: 0x21CA170 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x21CA280 Offset: 0x21CA381 VA: 0x21CA280 Slot: 19
	protected override void OnGetVariableBehaviorParameter() { }

	// RVA: 0x21CA3B0 Offset: 0x21CA4B1 VA: 0x21CA3B0
	private bool IgnoreCharacter(Character character) { }

	// RVA: 0x21CA4B0 Offset: 0x21CA5B1 VA: 0x21CA4B0 Slot: 15
	public override void SetupSearchCharacterController() { }

	// RVA: 0x21CA680 Offset: 0x21CA781 VA: 0x21CA680 Slot: 17
	public override void ResetSearchCharacterController() { }

	// RVA: 0x21CA6D0 Offset: 0x21CA7D1 VA: 0x21CA6D0 Slot: 50
	protected override void AddMonsterSearchParameter() { }

	// RVA: 0x21CA7C0 Offset: 0x21CA8C1 VA: 0x21CA7C0 Slot: 6
	public override void SetCharacter(Character character) { }

	// RVA: 0x21CA860 Offset: 0x21CA961 VA: 0x21CA860 Slot: 58
	public override void BeforeTakeDamage(ref DamageInfo damageInfo) { }

	// RVA: 0x21CA8C0 Offset: 0x21CA9C1 VA: 0x21CA8C0 Slot: 59
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult) { }

	// RVA: 0x21CA970 Offset: 0x21CAA71 VA: 0x21CA970 Slot: 84
	public virtual void SetPartnerBehaviorType(PartnerBehaviorType type) { }

	// RVA: 0x21CA980 Offset: 0x21CAA81 VA: 0x21CA980
	public bool CheckSameMovementOrder(PartnerMovementOrderType order) { }

	// RVA: 0x21CAA40 Offset: 0x21CAB41 VA: 0x21CAA40 Slot: 65
	public override void OnEndActionScript() { }

	// RVA: 0x21CA200 Offset: 0x21CA301 VA: 0x21CA200
	private void SetupActionBehaviorContriller() { }

	// RVA: 0x21CAAD0 Offset: 0x21CABD1 VA: 0x21CAAD0 Slot: 76
	public override void SetupMonsterAction() { }

	// RVA: 0x21CAB20 Offset: 0x21CAC21 VA: 0x21CAB20 Slot: 77
	public override void ExecuteMonsterAction(int index) { }

	// RVA: 0x21CAB40 Offset: 0x21CAC41 VA: 0x21CAB40
	public void .ctor() { }
}

