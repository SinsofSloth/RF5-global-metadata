[DefaultExecutionOrder] // RVA: 0x145E70 Offset: 0x145F71 VA: 0x145E70
public class HumanController : Character // TypeDefIndex: 6637
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15E400 Offset: 0x15E501 VA: 0x15E400
	private CharacterAnimationMonitor <AnimationMonitor>k__BackingField; // 0x188
	[CompilerGeneratedAttribute] // RVA: 0x15E410 Offset: 0x15E511 VA: 0x15E410
	private HumanEquipment <Equipment>k__BackingField; // 0x190
	[CompilerGeneratedAttribute] // RVA: 0x15E420 Offset: 0x15E521 VA: 0x15E420
	private HumanItemHold <ItemHolder>k__BackingField; // 0x198
	[CompilerGeneratedAttribute] // RVA: 0x15E430 Offset: 0x15E531 VA: 0x15E430
	private HumanLookIK <LookIK>k__BackingField; // 0x1A0
	[CompilerGeneratedAttribute] // RVA: 0x15E440 Offset: 0x15E541 VA: 0x15E440
	private AvoidController <AvoidController>k__BackingField; // 0x1A8
	[CompilerGeneratedAttribute] // RVA: 0x15E450 Offset: 0x15E551 VA: 0x15E450
	private BattleModeController <BattleModeController>k__BackingField; // 0x1B0
	[CompilerGeneratedAttribute] // RVA: 0x15E460 Offset: 0x15E561 VA: 0x15E460
	private HumanMotionType <MotionType>k__BackingField; // 0x1B8
	public CharacterBase JustAvoidTarget; // 0x1C0
	[CompilerGeneratedAttribute] // RVA: 0x15E470 Offset: 0x15E571 VA: 0x15E470
	private DamageResult <currentDamageResult>k__BackingField; // 0x1C8
	private bool isLeftArmIK; // 0x208
	private float weightLeftArmIK; // 0x20C
	private int paramLeftArmIKWeight; // 0x210
	[HeaderAttribute] // RVA: 0x15E480 Offset: 0x15E581 VA: 0x15E480
	[SerializeField] // RVA: 0x15E480 Offset: 0x15E581 VA: 0x15E480
	private float m_FarmApproachForce; // 0x214
	[HeaderAttribute] // RVA: 0x15E4D0 Offset: 0x15E5D1 VA: 0x15E4D0
	[SerializeField] // RVA: 0x15E4D0 Offset: 0x15E5D1 VA: 0x15E4D0
	private GrappleController m_GrappleController; // 0x218
	private HumanController.HitSystemInfo CurrentHitSystemInfo; // 0x220
	[CompilerGeneratedAttribute] // RVA: 0x15E520 Offset: 0x15E621 VA: 0x15E520
	private bool <IsWalking>k__BackingField; // 0x228
	private readonly string[] MotionStateName; // 0x230

	// Properties
	public CharacterAnimationMonitor AnimationMonitor { get; set; }
	public HumanEquipment Equipment { get; set; }
	public HumanItemHold ItemHolder { get; set; }
	public HumanLookIK LookIK { get; set; }
	public AvoidController AvoidController { get; set; }
	public BattleModeController BattleModeController { get; set; }
	public HumanMotionType MotionType { get; set; }
	private DamageResult currentDamageResult { get; set; }
	public HumanModel HumanModel { get; }
	protected virtual bool FadeEnable { get; }
	public override CharacterStatusBase Status { get; }
	public HumanStatus HumanStatus { get; }
	public override bool IsInvincible { get; }
	protected virtual HumanEquip EquipItem { get; }
	public ItemData CurrentWeaponData { get; }
	protected virtual bool EnableEquipWeaponAndTool { get; }
	public bool IsWalking { get; set; }
	public override bool IsBattleMode { get; }
	public override bool IsItemHold { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19C360 Offset: 0x19C461 VA: 0x19C360
	// RVA: 0x1E84210 Offset: 0x1E84311 VA: 0x1E84210
	public CharacterAnimationMonitor get_AnimationMonitor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C370 Offset: 0x19C471 VA: 0x19C370
	// RVA: 0x1E84220 Offset: 0x1E84321 VA: 0x1E84220
	protected void set_AnimationMonitor(CharacterAnimationMonitor value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C380 Offset: 0x19C481 VA: 0x19C380
	// RVA: 0x1E84230 Offset: 0x1E84331 VA: 0x1E84230
	public HumanEquipment get_Equipment() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C390 Offset: 0x19C491 VA: 0x19C390
	// RVA: 0x1E84240 Offset: 0x1E84341 VA: 0x1E84240
	protected void set_Equipment(HumanEquipment value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C3A0 Offset: 0x19C4A1 VA: 0x19C3A0
	// RVA: 0x1E84250 Offset: 0x1E84351 VA: 0x1E84250
	public HumanItemHold get_ItemHolder() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C3B0 Offset: 0x19C4B1 VA: 0x19C3B0
	// RVA: 0x1E84260 Offset: 0x1E84361 VA: 0x1E84260
	protected void set_ItemHolder(HumanItemHold value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C3C0 Offset: 0x19C4C1 VA: 0x19C3C0
	// RVA: 0x1E84270 Offset: 0x1E84371 VA: 0x1E84270
	public HumanLookIK get_LookIK() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C3D0 Offset: 0x19C4D1 VA: 0x19C3D0
	// RVA: 0x1E84280 Offset: 0x1E84381 VA: 0x1E84280
	protected void set_LookIK(HumanLookIK value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C3E0 Offset: 0x19C4E1 VA: 0x19C3E0
	// RVA: 0x1E84290 Offset: 0x1E84391 VA: 0x1E84290
	public AvoidController get_AvoidController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C3F0 Offset: 0x19C4F1 VA: 0x19C3F0
	// RVA: 0x1E842A0 Offset: 0x1E843A1 VA: 0x1E842A0
	protected void set_AvoidController(AvoidController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C400 Offset: 0x19C501 VA: 0x19C400
	// RVA: 0x1E842B0 Offset: 0x1E843B1 VA: 0x1E842B0
	public BattleModeController get_BattleModeController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C410 Offset: 0x19C511 VA: 0x19C410
	// RVA: 0x1E842C0 Offset: 0x1E843C1 VA: 0x1E842C0
	protected void set_BattleModeController(BattleModeController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C420 Offset: 0x19C521 VA: 0x19C420
	// RVA: 0x1E842D0 Offset: 0x1E843D1 VA: 0x1E842D0
	public HumanMotionType get_MotionType() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C430 Offset: 0x19C531 VA: 0x19C430
	// RVA: 0x1E842E0 Offset: 0x1E843E1 VA: 0x1E842E0
	private void set_MotionType(HumanMotionType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C440 Offset: 0x19C541 VA: 0x19C440
	// RVA: 0x1E842F0 Offset: 0x1E843F1 VA: 0x1E842F0
	private DamageResult get_currentDamageResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C450 Offset: 0x19C551 VA: 0x19C450
	// RVA: 0x1E84320 Offset: 0x1E84421 VA: 0x1E84320
	private void set_currentDamageResult(DamageResult value) { }

	// RVA: 0x1E84350 Offset: 0x1E84451 VA: 0x1E84350
	public HumanModel get_HumanModel() { }

	// RVA: 0x1E84430 Offset: 0x1E84531 VA: 0x1E84430 Slot: 76
	protected virtual bool get_FadeEnable() { }

	// RVA: 0x1E84440 Offset: 0x1E84541 VA: 0x1E84440 Slot: 27
	public override CharacterStatusBase get_Status() { }

	// RVA: 0x1E83450 Offset: 0x1E83551 VA: 0x1E83450
	public HumanStatus get_HumanStatus() { }

	// RVA: 0x1E84450 Offset: 0x1E84551 VA: 0x1E84450 Slot: 29
	public override bool get_IsInvincible() { }

	// RVA: 0x1E84510 Offset: 0x1E84611 VA: 0x1E84510 Slot: 77
	protected virtual HumanEquip get_EquipItem() { }

	// RVA: 0x1E845B0 Offset: 0x1E846B1 VA: 0x1E845B0
	public ItemData get_CurrentWeaponData() { }

	// RVA: 0x1E846C0 Offset: 0x1E847C1 VA: 0x1E846C0 Slot: 78
	protected virtual bool get_EnableEquipWeaponAndTool() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C460 Offset: 0x19C561 VA: 0x19C460
	// RVA: 0x1E846D0 Offset: 0x1E847D1 VA: 0x1E846D0
	public bool get_IsWalking() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C470 Offset: 0x19C571 VA: 0x19C470
	// RVA: 0x1E846E0 Offset: 0x1E847E1 VA: 0x1E846E0
	public void set_IsWalking(bool value) { }

	// RVA: 0x1E846F0 Offset: 0x1E847F1 VA: 0x1E846F0 Slot: 35
	public override bool get_IsBattleMode() { }

	// RVA: 0x1E84790 Offset: 0x1E84891 VA: 0x1E84790 Slot: 36
	public override bool get_IsItemHold() { }

	// RVA: 0x1E84840 Offset: 0x1E84941 VA: 0x1E84840
	private void InitComponent() { }

	// RVA: 0x1E84BE0 Offset: 0x1E84CE1 VA: 0x1E84BE0 Slot: 11
	protected override void Awake() { }

	// RVA: 0x1E84C10 Offset: 0x1E84D11 VA: 0x1E84C10 Slot: 12
	protected override void Start() { }

	// RVA: 0x1E84C90 Offset: 0x1E84D91 VA: 0x1E84C90 Slot: 75
	public override void CreateEffectPoint() { }

	// RVA: 0x1E84EE0 Offset: 0x1E84FE1 VA: 0x1E84EE0 Slot: 18
	public override void OnSwitchActorBase(bool on) { }

	// RVA: 0x1E866B0 Offset: 0x1E867B1 VA: 0x1E866B0 Slot: 45
	protected override void InitAnimator() { }

	// RVA: 0x1E86780 Offset: 0x1E86881 VA: 0x1E86780 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x1E86790 Offset: 0x1E86891 VA: 0x1E86790 Slot: 40
	protected override void Update() { }

	// RVA: 0x1E862F0 Offset: 0x1E863F1 VA: 0x1E862F0
	public void ApplyEquipVisible() { }

	// RVA: 0x1E83A30 Offset: 0x1E83B31 VA: 0x1E83A30
	public bool UpdateMotionType() { }

	// RVA: 0x1E872D0 Offset: 0x1E873D1 VA: 0x1E872D0 Slot: 14
	public override void ResetAnimator() { }

	// RVA: 0x1E874D0 Offset: 0x1E875D1 VA: 0x1E874D0 Slot: 79
	protected virtual void UpdateLookIK() { }

	// RVA: 0x1E87C60 Offset: 0x1E87D61 VA: 0x1E87C60
	public void SetLeftArmIK(bool isIk) { }

	// RVA: 0x1E87C70 Offset: 0x1E87D71 VA: 0x1E87C70
	public void SetLeftArmIKWeight(float weight) { }

	// RVA: 0x1E868B0 Offset: 0x1E869B1 VA: 0x1E868B0
	public void UpdateArmIK() { }

	// RVA: 0x1E87C80 Offset: 0x1E87D81 VA: 0x1E87C80 Slot: 80
	protected virtual float UpdateArmIKWeight(float currentWeight, bool isArmIk) { }

	// RVA: 0x1E87D30 Offset: 0x1E87E31 VA: 0x1E87D30 Slot: 62
	public override void SetGrounderIKWeight(float weight) { }

	// RVA: 0x1E87F20 Offset: 0x1E88021 VA: 0x1E87F20 Slot: 63
	public override void SetLookIKWeight(float weight) { }

	// RVA: 0x1E87FC0 Offset: 0x1E880C1 VA: 0x1E87FC0 Slot: 64
	public override void SetNavMeshAgentEnable(bool enable) { }

	// RVA: 0x1E88070 Offset: 0x1E88171 VA: 0x1E88070 Slot: 81
	public virtual void SetItemLayerWeight(float weight) { }

	// RVA: 0x1E88130 Offset: 0x1E88231 VA: 0x1E88130 Slot: 82
	public virtual void SetConstraintWeight(ConstraintPresetID presetId) { }

	// RVA: 0x1E88320 Offset: 0x1E88421 VA: 0x1E88320 Slot: 83
	public virtual void StopAction() { }

	// RVA: 0x1E883C0 Offset: 0x1E884C1 VA: 0x1E883C0 Slot: 43
	public override void PlayMotion(string name, float fadeTime = 0) { }

	// RVA: 0x1E88450 Offset: 0x1E88551 VA: 0x1E88450
	public void PlayMotionBasic(string name, float fadeTime = 0) { }

	// RVA: 0x1E884D0 Offset: 0x1E885D1 VA: 0x1E884D0
	public void ShowCurrentToolEquip() { }

	// RVA: 0x1E88500 Offset: 0x1E88601 VA: 0x1E88500
	public void HideCurrentToolEquip() { }

	// RVA: 0x1E88530 Offset: 0x1E88631 VA: 0x1E88530 Slot: 58
	public override void StartBattleMode() { }

	// RVA: 0x1E88540 Offset: 0x1E88641 VA: 0x1E88540
	public void StartBattleMode(bool immediate) { }

	// RVA: 0x1E886D0 Offset: 0x1E887D1 VA: 0x1E886D0 Slot: 59
	public override void EndBattleMode() { }

	// RVA: 0x1E88750 Offset: 0x1E88851 VA: 0x1E88750
	public void EndBattleMode(bool immediate) { }

	// RVA: 0x1E887F0 Offset: 0x1E888F1 VA: 0x1E887F0 Slot: 60
	public override void ForceEndBattleMode() { }

	// RVA: 0x1E88860 Offset: 0x1E88961 VA: 0x1E88860 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x1E88E20 Offset: 0x1E88F21 VA: 0x1E88E20 Slot: 66
	public override bool OnBeforeDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x1E88EA0 Offset: 0x1E88FA1 VA: 0x1E88EA0
	private void PlayDamageMotion() { }

	// RVA: 0x1E88FD0 Offset: 0x1E890D1 VA: 0x1E88FD0 Slot: 67
	public override void OnPlayDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x1E89910 Offset: 0x1E89A11 VA: 0x1E89910 Slot: 69
	public override void OnAfterDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x1E89CD0 Offset: 0x1E89DD1 VA: 0x1E89CD0 Slot: 49
	public override bool InputMove(Vector3 vector) { }

	// RVA: 0x1E8A350 Offset: 0x1E8A451 VA: 0x1E8A350 Slot: 52
	protected override void UpdateRotate(float deltaTime) { }

	// RVA: 0x1E8A8A0 Offset: 0x1E8A9A1 VA: 0x1E8A8A0 Slot: 51
	protected override void UpdateMove(float deltaTime) { }

	// RVA: 0x1E8A8B0 Offset: 0x1E8A9B1 VA: 0x1E8A8B0 Slot: 53
	protected override float GetSlowMoveScale() { }

	// RVA: 0x1E8A9D0 Offset: 0x1E8AAD1 VA: 0x1E8A9D0 Slot: 72
	public override void OnLanding() { }

	// RVA: 0x1E8AC30 Offset: 0x1E8AD31 VA: 0x1E8AC30 Slot: 73
	public override void OnFalling() { }

	// RVA: 0x1E8AF40 Offset: 0x1E8B041 VA: 0x1E8AF40 Slot: 74
	public override void OnSliding() { }

	// RVA: 0x1E8B140 Offset: 0x1E8B241 VA: 0x1E8B140 Slot: 84
	public virtual void OnGroundRightFoot() { }

	// RVA: 0x1E8B150 Offset: 0x1E8B251 VA: 0x1E8B150 Slot: 85
	public virtual void OnGroundLeftFoot() { }

	// RVA: 0x1E8B160 Offset: 0x1E8B261 VA: 0x1E8B160 Slot: 86
	protected virtual void FallingEnemyCheck() { }

	// RVA: 0x1E8B6E0 Offset: 0x1E8B7E1 VA: 0x1E8B6E0 Slot: 87
	protected virtual void OnChangeEquip_ForNoticeStatus() { }

	// RVA: 0x1E8B710 Offset: 0x1E8B811 VA: 0x1E8B710 Slot: 65
	public override void OnBadStatus(BadStatus badStatus, bool isEnable) { }

	// RVA: 0x1E8B7D0 Offset: 0x1E8B8D1 VA: 0x1E8B7D0
	public EquipSlotType CheckEquipSlot(ItemData item_data) { }

	// RVA: 0x1E8B830 Offset: 0x1E8B931 VA: 0x1E8B830 Slot: 88
	public virtual void ResetEquip(bool force = False) { }

	// RVA: 0x1E8BD90 Offset: 0x1E8BE91 VA: 0x1E8BD90 Slot: 89
	public virtual void Equip(EquipSlotType slot_type) { }

	// RVA: 0x1E8C0B0 Offset: 0x1E8C1B1 VA: 0x1E8C0B0 Slot: 90
	public virtual ItemData UnEquip(EquipSlotType slot_type) { }

	// RVA: 0x1E8C2E0 Offset: 0x1E8C3E1 VA: 0x1E8C2E0 Slot: 91
	public virtual bool Equip(EquipSlotType slot_type, ItemData item_data) { }

	// RVA: 0x1E8C540 Offset: 0x1E8C641 VA: 0x1E8C540 Slot: 92
	public virtual bool Equip(ItemData item_data) { }

	// RVA: 0x1E8C5E0 Offset: 0x1E8C6E1 VA: 0x1E8C5E0
	public bool IsEquipToolCategory(ItemCategory itemCategory) { }

	// RVA: 0x1E8C6F0 Offset: 0x1E8C7F1 VA: 0x1E8C6F0 Slot: 93
	public virtual void DoEquipedTool(bool visible) { }

	// RVA: 0x1E8C7B0 Offset: 0x1E8C8B1 VA: 0x1E8C7B0 Slot: 94
	public virtual void SwitchEquipedTool(EquipSlotType slotType) { }

	// RVA: 0x1E8C8A0 Offset: 0x1E8C9A1 VA: 0x1E8C8A0 Slot: 95
	public virtual void Avoid() { }

	// RVA: 0x1E8C980 Offset: 0x1E8CA81 VA: 0x1E8C980
	public void Attack() { }

	// RVA: 0x1E8CA70 Offset: 0x1E8CB71 VA: 0x1E8CA70
	public void ChargeStart() { }

	// RVA: 0x1E8CC80 Offset: 0x1E8CD81 VA: 0x1E8CC80
	public void ChargeEnd() { }

	// RVA: 0x1E8CD60 Offset: 0x1E8CE61 VA: 0x1E8CD60
	public void RapidPickUpOnGroundItem_WithItemDataAppend(ItemData itemData) { }

	// RVA: 0x1E8D130 Offset: 0x1E8D231 VA: 0x1E8D130
	public void PutOnGroundItem() { }

	// RVA: 0x1E8D3A0 Offset: 0x1E8D4A1 VA: 0x1E8D3A0
	public void ThrowItem() { }

	// RVA: 0x1E8D5D0 Offset: 0x1E8D6D1 VA: 0x1E8D5D0
	public void RuckInItem() { }

	// RVA: 0x1E8D8C0 Offset: 0x1E8D9C1 VA: 0x1E8D8C0
	public void UseItem() { }

	// RVA: 0x1E8DDE0 Offset: 0x1E8DEE1 VA: 0x1E8DDE0
	public void RuneAbility(int index) { }

	// RVA: 0x1E8DF40 Offset: 0x1E8E041 VA: 0x1E8DF40 Slot: 5
	public override void OnEnableHitSystem() { }

	// RVA: 0x1E8DFD0 Offset: 0x1E8E0D1 VA: 0x1E8DFD0 Slot: 6
	public override void OnHitSystemTriggerEnter(Collider collider, CharacterBase characterBase, Vector3 direction, HitOptionParamID paramID, Collider attackCollider) { }

	// RVA: 0x1E8EC50 Offset: 0x1E8ED51 VA: 0x1E8EC50
	private void CreateDamageInfoHitSystem(out DamageInfo damageInfo, float DamageRate, float KnockBackRate, AttackAttribute attackAttribute, int BlowPower, float BlowPowerRate, float AttackPoison, float AttackParalysis, float AttackSleep, float AttackTire, float AttackSick, float AttackDeath, float AttackHpDrain, float AttackSeal) { }

	// RVA: 0x1E8EE80 Offset: 0x1E8EF81 VA: 0x1E8EE80 Slot: 70
	public override void AddDamagedPost(DamageInfo damageInfo, DamageResult result) { }

	// RVA: 0x1E8F250 Offset: 0x1E8F351 VA: 0x1E8F250 Slot: 96
	public virtual void AddDamagedPost(DamageInfo damageInfo, DamageResult result, ItemData itemData_) { }

	// RVA: 0x1E8F4F0 Offset: 0x1E8F5F1 VA: 0x1E8F4F0 Slot: 71
	public override void PlayDamageEffect(DamageInfo damageInfo, DamageResult result) { }

	// RVA: 0x1E8FCE0 Offset: 0x1E8FDE1 VA: 0x1E8FCE0
	public void LeftHandIkOff() { }

	// RVA: 0x1E8FCF0 Offset: 0x1E8FDF1 VA: 0x1E8FCF0
	public void LeftHandIkOn() { }

	// RVA: 0x1E8FD00 Offset: 0x1E8FE01 VA: 0x1E8FD00
	public void ApproachFarm(GameObject approachTarget) { }

	// RVA: 0x1E90230 Offset: 0x1E90331 VA: 0x1E90230 Slot: 61
	protected override bool CheckEnemySearchList(CharacterBase characterBase) { }

	// RVA: 0x1E90330 Offset: 0x1E90431 VA: 0x1E90330 Slot: 48
	protected override void OnWince() { }

	// RVA: 0x1E8AD40 Offset: 0x1E8AE41 VA: 0x1E8AD40
	private void DoActCancel() { }

	// RVA: 0x1E903E0 Offset: 0x1E904E1 VA: 0x1E903E0
	public void .ctor() { }
}

