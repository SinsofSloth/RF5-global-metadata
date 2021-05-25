public class PartnerNPCBehaviorController : AIInput, PartnerNPCEventReceiverInterface // TypeDefIndex: 8167
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16B740 Offset: 0x16B841 VA: 0x16B740
	private PartnerBehaviorType <PartnerBehaviorType>k__BackingField; // 0x78
	public HateController HateController; // 0x80
	public PartnerMovementController PartnerMovementController; // 0x88
	private PartnerNPCController _PartnerNPCController; // 0x90
	private NPCActionBehaviorController NPCActionBehaviorController; // 0x98
	public List<PartnerNPCActionBehaviorType> ActionTypeList; // 0xA0

	// Properties
	public PartnerBehaviorType PartnerBehaviorType { get; set; }
	public override SearchCharacterController SearchCharacterController { get; set; }
	public PartnerNPCController PartnerNPCController { get; }
	public NpcData NPCData { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6480 Offset: 0x1A6581 VA: 0x1A6480
	// RVA: 0x1FD9910 Offset: 0x1FD9A11 VA: 0x1FD9910
	public PartnerBehaviorType get_PartnerBehaviorType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6490 Offset: 0x1A6591 VA: 0x1A6490
	// RVA: 0x1FD9920 Offset: 0x1FD9A21 VA: 0x1FD9920
	protected void set_PartnerBehaviorType(PartnerBehaviorType value) { }

	// RVA: 0x1FD9930 Offset: 0x1FD9A31 VA: 0x1FD9930 Slot: 7
	public override SearchCharacterController get_SearchCharacterController() { }

	// RVA: 0x1FD9940 Offset: 0x1FD9A41 VA: 0x1FD9940 Slot: 8
	protected override void set_SearchCharacterController(SearchCharacterController value) { }

	// RVA: 0x1FD8D30 Offset: 0x1FD8E31 VA: 0x1FD8D30
	public PartnerNPCController get_PartnerNPCController() { }

	// RVA: 0x1FD9950 Offset: 0x1FD9A51 VA: 0x1FD9950
	public NpcData get_NPCData() { }

	// RVA: 0x1FD9970 Offset: 0x1FD9A71 VA: 0x1FD9970
	private void SetupActionBehaviorContriller() { }

	// RVA: 0x1FD9A00 Offset: 0x1FD9B01 VA: 0x1FD9A00
	public void SetupAction() { }

	// RVA: 0x1FD9A50 Offset: 0x1FD9B51 VA: 0x1FD9A50
	public void ExecuteAction(int index) { }

	// RVA: 0x1FD9A70 Offset: 0x1FD9B71 VA: 0x1FD9A70
	public bool EnableTarget() { }

	// RVA: 0x1FD98E0 Offset: 0x1FD99E1 VA: 0x1FD98E0
	public void AbortAction(int index) { }

	// RVA: 0x1FD9BA0 Offset: 0x1FD9CA1 VA: 0x1FD9BA0
	public void EndAction() { }

	// RVA: 0x1FD9BB0 Offset: 0x1FD9CB1 VA: 0x1FD9BB0 Slot: 4
	protected override void Start() { }

	// RVA: 0x1FD9BC0 Offset: 0x1FD9CC1 VA: 0x1FD9BC0 Slot: 9
	protected override void Update() { }

	// RVA: 0x1FD9C00 Offset: 0x1FD9D01 VA: 0x1FD9C00
	private bool IgnoreCharacter(Character character) { }

	// RVA: 0x1FD9D00 Offset: 0x1FD9E01 VA: 0x1FD9D00 Slot: 15
	public override void SetupSearchCharacterController() { }

	// RVA: 0x1FD9ED0 Offset: 0x1FD9FD1 VA: 0x1FD9ED0 Slot: 16
	protected override void OnSetupSearchCharacterController() { }

	// RVA: 0x1FD9FC0 Offset: 0x1FDA0C1 VA: 0x1FD9FC0 Slot: 17
	public override void ResetSearchCharacterController() { }

	// RVA: 0x1FDA010 Offset: 0x1FDA111 VA: 0x1FDA010 Slot: 6
	public override void SetCharacter(Character character) { }

	// RVA: 0x1FDA0A0 Offset: 0x1FDA1A1 VA: 0x1FDA0A0 Slot: 30
	public virtual void SetPartnerBehaviorType(PartnerBehaviorType type) { }

	// RVA: 0x1FDA0B0 Offset: 0x1FDA1B1 VA: 0x1FDA0B0 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x1FDA150 Offset: 0x1FDA251 VA: 0x1FDA150 Slot: 19
	protected override void OnGetVariableBehaviorParameter() { }

	// RVA: 0x1FDA220 Offset: 0x1FDA321 VA: 0x1FDA220
	public bool CheckSameMovementOrder(PartnerMovementOrderType order) { }

	// RVA: 0x1FDA270 Offset: 0x1FDA371 VA: 0x1FDA270
	public bool CheckSameBattleOrder(PartnerBattleOrder order) { }

	// RVA: 0x1FDA280 Offset: 0x1FDA381 VA: 0x1FDA280
	public void SetPartnerBattleOrder(PartnerBattleOrder order) { }

	// RVA: 0x1FDA290 Offset: 0x1FDA391 VA: 0x1FDA290 Slot: 22
	public void OnChangeShortPlay(bool isEnable) { }

	// RVA: 0x1FDA2E0 Offset: 0x1FDA3E1 VA: 0x1FDA2E0 Slot: 23
	public void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult) { }

	// RVA: 0x1FDA390 Offset: 0x1FDA491 VA: 0x1FDA390 Slot: 24
	public void OnFreeze() { }

	// RVA: 0x1FDA3F0 Offset: 0x1FDA4F1 VA: 0x1FDA3F0 Slot: 25
	public void OnBlow() { }

	// RVA: 0x1FDA410 Offset: 0x1FDA511 VA: 0x1FDA410 Slot: 26
	public void OnKnockBack() { }

	// RVA: 0x1FDA430 Offset: 0x1FDA531 VA: 0x1FDA430 Slot: 27
	public void OnDead() { }

	// RVA: 0x1FDA450 Offset: 0x1FDA551 VA: 0x1FDA450 Slot: 31
	public virtual void OnBadStatus(BadStatus badStatus, bool isEnable) { }

	// RVA: 0x1FDA510 Offset: 0x1FDA611 VA: 0x1FDA510 Slot: 28
	public void EndDamageAction() { }

	// RVA: 0x1FDA5E0 Offset: 0x1FDA6E1 VA: 0x1FDA5E0
	public void .ctor() { }
}

