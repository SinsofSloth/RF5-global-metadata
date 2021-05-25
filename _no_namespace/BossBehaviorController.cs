public abstract class BossBehaviorController : MonsterBehaviorController // TypeDefIndex: 7818
{
	// Fields
	private BossMonsterContoroller _BossMonsterContoroller; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x169AF0 Offset: 0x169BF1 VA: 0x169AF0
	private BossBehaviorController.BossMadnessState <_BossMadnessState>k__BackingField; // 0x128
	[SerializeField] // RVA: 0x169B00 Offset: 0x169C01 VA: 0x169B00
	private BossDataAssetBase _BossDataAsset; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x169B10 Offset: 0x169C11 VA: 0x169B10
	private CalcLotteryBossBehavior <CalcLotteryBossBehavior>k__BackingField; // 0x138
	private bool IsHitPrevAttack; // 0x140
	protected SharedMovementBehaviorType SharedMovementBehaviorType; // 0x148
	protected SharedFloat MaxWaitInterval; // 0x150
	protected SharedFloat MinWaitInterval; // 0x158
	protected SharedFloat MoveAroundRange; // 0x160
	protected SharedFloat MoveAroundAngle; // 0x168
	protected SharedBool IsReleseEyes; // 0x170
	protected SharedFloat LeaveRange; // 0x178
	protected SharedFloat CloseRange; // 0x180
	protected SharedFloat MoveSpeedScale; // 0x188
	protected SharedFloat JumpTime; // 0x190
	protected SharedVector3 JumpArrivePosition; // 0x198
	protected SharedString CrossFadeAnimatorStateName; // 0x1A0
	protected SharedBool OnlyUseMaxRange; // 0x1A8
	protected SharedVector3 MovePosition; // 0x1B0
	protected SharedBool UseBaseActionScript; // 0x1B8
	protected SharedVector3 TargetPosition; // 0x1C0

	// Properties
	protected BossMonsterContoroller BossMonsterContoroller { get; }
	public BossBehaviorController.BossMadnessState _BossMadnessState { get; set; }
	public bool IsMadness { get; }
	public BossDataAssetBase BossDataAsset { get; }
	protected CalcLotteryBossBehavior CalcLotteryBossBehavior { get; set; }

	// Methods

	// RVA: 0x22E6C30 Offset: 0x22E6D31 VA: 0x22E6C30
	protected BossMonsterContoroller get_BossMonsterContoroller() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A30A0 Offset: 0x1A31A1 VA: 0x1A30A0
	// RVA: 0x22E6D20 Offset: 0x22E6E21 VA: 0x22E6D20
	public BossBehaviorController.BossMadnessState get__BossMadnessState() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A30B0 Offset: 0x1A31B1 VA: 0x1A30B0
	// RVA: 0x22E6D30 Offset: 0x22E6E31 VA: 0x22E6D30
	protected void set__BossMadnessState(BossBehaviorController.BossMadnessState value) { }

	// RVA: 0x22E6D40 Offset: 0x22E6E41 VA: 0x22E6D40
	public bool get_IsMadness() { }

	// RVA: 0x22E6D50 Offset: 0x22E6E51 VA: 0x22E6D50
	public BossDataAssetBase get_BossDataAsset() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A30C0 Offset: 0x1A31C1 VA: 0x1A30C0
	// RVA: 0x22E6D60 Offset: 0x22E6E61 VA: 0x22E6D60
	protected void set_CalcLotteryBossBehavior(CalcLotteryBossBehavior value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A30D0 Offset: 0x1A31D1 VA: 0x1A30D0
	// RVA: 0x22E6D70 Offset: 0x22E6E71 VA: 0x22E6D70
	protected CalcLotteryBossBehavior get_CalcLotteryBossBehavior() { }

	// RVA: 0x22DE920 Offset: 0x22DEA21 VA: 0x22DE920
	public void SetupHUDBossHpBar() { }

	// RVA: 0x22E6D80 Offset: 0x22E6E81 VA: 0x22E6D80 Slot: 9
	protected override void Update() { }

	// RVA: 0x22E6DD0 Offset: 0x22E6ED1 VA: 0x22E6DD0 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x22E6E20 Offset: 0x22E6F21 VA: 0x22E6E20
	private void OnDisable() { }

	// RVA: 0x22E6EE0 Offset: 0x22E6FE1 VA: 0x22E6EE0 Slot: 84
	public virtual void SetBossDataAsset(BossDataAssetBase bossData) { }

	// RVA: 0x22E6F50 Offset: 0x22E7051 VA: 0x22E6F50 Slot: 85
	public virtual List<MonsterActionInformation> GetActiveActionInformationList() { }

	// RVA: 0x22E6FF0 Offset: 0x22E70F1 VA: 0x22E6FF0 Slot: 19
	protected override void OnGetVariableBehaviorParameter() { }

	// RVA: 0x22E7770 Offset: 0x22E7871 VA: 0x22E7770
	private bool IgnoreCharacter(Character character) { }

	// RVA: 0x22E77B0 Offset: 0x22E78B1 VA: 0x22E77B0 Slot: 15
	public override void SetupSearchCharacterController() { }

	// RVA: 0x22E7990 Offset: 0x22E7A91 VA: 0x22E7990 Slot: 54
	public override void UpdateActiveActionInformation() { }

	// RVA: 0x22E7A50 Offset: 0x22E7B51 VA: 0x22E7A50 Slot: 59
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult) { }

	// RVA: 0x22E7B60 Offset: 0x22E7C61 VA: 0x22E7B60 Slot: 86
	public virtual void OnMadness() { }

	// RVA: 0x22E7C00 Offset: 0x22E7D01 VA: 0x22E7C00 Slot: 87
	public virtual void CreateMadnessEffect() { }

	// RVA: 0x22E7CA0 Offset: 0x22E7DA1 VA: 0x22E7CA0 Slot: 88
	public virtual void StartMadness() { }

	// RVA: 0x22E7D30 Offset: 0x22E7E31 VA: 0x22E7D30 Slot: 65
	public override void OnEndActionScript() { }

	// RVA: 0x22E7D50 Offset: 0x22E7E51 VA: 0x22E7D50 Slot: 71
	public override void OnEndAnimEventMadnessState() { }

	// RVA: 0x22E7E70 Offset: 0x22E7F71 VA: 0x22E7E70 Slot: 56
	public override void OnHitAttack() { }

	// RVA: 0x22E7E80 Offset: 0x22E7F81 VA: 0x22E7E80 Slot: 67
	public override void OnEndAnimEventDeadState() { }

	// RVA: 0x22E7EB0 Offset: 0x22E7FB1 VA: 0x22E7EB0 Slot: 89
	public virtual string GetLotteryTypeEnumToString(int SelectType) { }

	// RVA: 0x22E7F00 Offset: 0x22E8001 VA: 0x22E7F00 Slot: 90
	public virtual void OnUpdateBossDataBitArray() { }

	// RVA: 0x22E80D0 Offset: 0x22E81D1 VA: 0x22E80D0 Slot: 91
	protected virtual void UpdateMonsterActionListIndex() { }

	// RVA: 0x22E8140 Offset: 0x22E8241 VA: 0x22E8140 Slot: 92
	protected virtual void SetupMonsterActionList(int type) { }

	// RVA: 0x22E81C0 Offset: 0x22E82C1 VA: 0x22E81C0 Slot: 93
	protected virtual void UpdateMonsterActionList() { }

	// RVA: 0x22E82B0 Offset: 0x22E83B1 VA: 0x22E82B0
	private void ResetMonsterActionParamInformation() { }

	// RVA: 0x22E82C0 Offset: 0x22E83C1 VA: 0x22E82C0 Slot: 76
	public override void SetupMonsterAction() { }

	// RVA: 0x22E8430 Offset: 0x22E8531 VA: 0x22E8430 Slot: 77
	public override void ExecuteMonsterAction(int index) { }

	// RVA: 0x22E84F0 Offset: 0x22E85F1 VA: 0x22E84F0 Slot: 78
	public override void AbortMonsterAction(int index) { }

	// RVA: 0x22E85B0 Offset: 0x22E86B1 VA: 0x22E85B0 Slot: 79
	public override void EndMonsterAction() { }

	// RVA: 0x22E85F0 Offset: 0x22E86F1 VA: 0x22E85F0 Slot: 94
	protected virtual void UpdateRestraintBehaviorTiming() { }

	// RVA: 0x22E8620 Offset: 0x22E8721 VA: 0x22E8620 Slot: 95
	protected virtual void UpdateReciveItemBehaviorTiming() { }

	// RVA: 0x22E8650 Offset: 0x22E8751 VA: 0x22E8650 Slot: 81
	public override void OnRestraint() { }

	// RVA: 0x22E8680 Offset: 0x22E8781 VA: 0x22E8680
	protected void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A30E0 Offset: 0x1A31E1 VA: 0x1A30E0
	// RVA: 0x22E8690 Offset: 0x22E8791 VA: 0x22E8690
	private void <CreateMadnessEffect>b__48_0(ParticleSystem effect) { }
}

