[Serializable]
public class MonsterBehaviorController : AIInput, MonsterEventReceiverInterface // TypeDefIndex: 8072
{
	// Fields
	protected MonsterControllerBase _MonsterController; // 0x78
	protected List<MonsterActionInformation> ActiveActionInformationList; // 0x80
	private float ModelScaleRate; // 0x88
	private MonsterActionInformation _CurrentSelectAction; // 0x90
	protected SharedBool IsEndAction; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x16A2D0 Offset: 0x16A3D1 VA: 0x16A2D0
	private SharedGameObject <Target>k__BackingField; // 0xA0
	public HateController HateController; // 0xA8
	protected SharedBool IsEndAnimationStartJump; // 0xB0
	protected SharedBool IsEndAnimationEndJump; // 0xB8
	protected SharedBool UseNavMeshAgent; // 0xC0
	public List<MonsterActionBehaviorType> MonsterActionTypeList; // 0xC8
	protected Dictionary<int, List<MonsterBehaviorController.BehaviorActionParam>> ActionBehaviorParamListDic; // 0xD0
	protected List<MonsterBehaviorController.BehaviorActionParam> CurrentBehaviorActionParamList; // 0xD8
	public int CurrentActionParamListIndex; // 0xE0
	protected Dictionary<int, MonsterBehaviorController.BehaviorActionParam> ActionBehaviorParamDic; // 0xE8
	public int CurrentLotteryType; // 0xF0
	protected MonsterBehaviorController.BehaviorActionParam CurrentBehaviorActionParam; // 0xF8
	public int CurrentActionParamIndex; // 0x100
	public MonsterActionBehaviorType CurrentMonsterActionBehaviorType; // 0x104
	public int ActionCodeBaseNo; // 0x108
	public MonsterBehaviorController.BehaviorStateMachine StateMachine; // 0x110
	public int DeadCount; // 0x118

	// Properties
	public MonsterControllerBase MonsterController { get; }
	public MonsterActionInformation CurrentSelectAction { get; set; }
	public SharedGameObject Target { get; set; }

	// Methods

	// RVA: 0x1CC3FD0 Offset: 0x1CC40D1 VA: 0x1CC3FD0
	public MonsterControllerBase get_MonsterController() { }

	// RVA: 0x1CC8B90 Offset: 0x1CC8C91 VA: 0x1CC8B90
	public MonsterActionInformation get_CurrentSelectAction() { }

	// RVA: 0x1CC8BA0 Offset: 0x1CC8CA1 VA: 0x1CC8BA0
	public void set_CurrentSelectAction(MonsterActionInformation value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A58B0 Offset: 0x1A59B1 VA: 0x1A58B0
	// RVA: 0x1CC8D10 Offset: 0x1CC8E11 VA: 0x1CC8D10
	public SharedGameObject get_Target() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A58C0 Offset: 0x1A59C1 VA: 0x1A58C0
	// RVA: 0x1CC8D20 Offset: 0x1CC8E21 VA: 0x1CC8D20
	private void set_Target(SharedGameObject value) { }

	// RVA: 0x1CC8D30 Offset: 0x1CC8E31 VA: 0x1CC8D30 Slot: 9
	protected override void Update() { }

	// RVA: 0x1CC8D70 Offset: 0x1CC8E71 VA: 0x1CC8D70 Slot: 49
	protected virtual void OnDestroy() { }

	// RVA: 0x1CC8E10 Offset: 0x1CC8F11 VA: 0x1CC8E10 Slot: 10
	protected override void OnSetup() { }

	// RVA: 0x1CC8F00 Offset: 0x1CC9001 VA: 0x1CC8F00 Slot: 11
	protected override void OnRelese() { }

	// RVA: 0x1CC8FE0 Offset: 0x1CC90E1 VA: 0x1CC8FE0 Slot: 6
	public override void SetCharacter(Character character) { }

	// RVA: 0x1CC9020 Offset: 0x1CC9121 VA: 0x1CC9020 Slot: 19
	protected override void OnGetVariableBehaviorParameter() { }

	// RVA: 0x1CC9370 Offset: 0x1CC9471 VA: 0x1CC9370 Slot: 15
	public override void SetupSearchCharacterController() { }

	// RVA: 0x1CC94F0 Offset: 0x1CC95F1 VA: 0x1CC94F0 Slot: 13
	public override void OnNotReturnNavMesh() { }

	// RVA: 0x1CC9510 Offset: 0x1CC9611 VA: 0x1CC9510 Slot: 50
	protected virtual void AddMonsterSearchParameter() { }

	// RVA: 0x1CC95B0 Offset: 0x1CC96B1 VA: 0x1CC95B0 Slot: 51
	public virtual void SetTarget(CharacterBase target) { }

	// RVA: 0x1CC9700 Offset: 0x1CC9801 VA: 0x1CC9700 Slot: 52
	public virtual void StartActionCode() { }

	// RVA: 0x1CC9740 Offset: 0x1CC9841 VA: 0x1CC9740 Slot: 53
	public virtual void StartActionCodeBase() { }

	// RVA: 0x1CC9840 Offset: 0x1CC9941 VA: 0x1CC9840 Slot: 54
	public virtual void UpdateActiveActionInformation() { }

	// RVA: 0x1CC98F0 Offset: 0x1CC99F1 VA: 0x1CC98F0
	public void SortActiveActionInformation() { }

	// RVA: 0x1CC9A10 Offset: 0x1CC9B11 VA: 0x1CC9A10
	public bool IsActiveAction(MonsterActionInformation info) { }

	// RVA: 0x1CC9A90 Offset: 0x1CC9B91 VA: 0x1CC9A90
	public void PopupEmotion() { }

	// RVA: 0x1CC9AA0 Offset: 0x1CC9BA1 VA: 0x1CC9AA0
	public MonsterActionInformation GetMonsterActionInformation(string actionScriptName) { }

	// RVA: 0x1CC9B40 Offset: 0x1CC9C41 VA: 0x1CC9B40 Slot: 55
	public virtual MovementBehaviorType GetEndAttackMovementType(out float moveSpeedScale) { }

	// RVA: 0x1CC9B50 Offset: 0x1CC9C51 VA: 0x1CC9B50 Slot: 56
	public virtual void OnHitAttack() { }

	// RVA: 0x1CC9B60 Offset: 0x1CC9C61 VA: 0x1CC9B60 Slot: 57
	public virtual void OnChangeShortPlay(bool isEnable) { }

	// RVA: 0x1CC9BB0 Offset: 0x1CC9CB1 VA: 0x1CC9BB0
	public bool IsMimicryType() { }

	// RVA: 0x1CC9D00 Offset: 0x1CC9E01 VA: 0x1CC9D00 Slot: 58
	public virtual void BeforeTakeDamage(ref DamageInfo damageInfo) { }

	// RVA: 0x1CC9D10 Offset: 0x1CC9E11 VA: 0x1CC9D10 Slot: 59
	public virtual void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult) { }

	// RVA: 0x1CC9E10 Offset: 0x1CC9F11 VA: 0x1CC9E10
	private void LockStopBehavior() { }

	// RVA: 0x1CC9E50 Offset: 0x1CC9F51 VA: 0x1CC9E50
	private void UnLockStartBehavior() { }

	// RVA: 0x1CC9F30 Offset: 0x1CCA031 VA: 0x1CC9F30 Slot: 60
	public virtual void OnFreeze() { }

	// RVA: 0x1CC9F90 Offset: 0x1CCA091 VA: 0x1CC9F90 Slot: 61
	public virtual void OnKnockBack() { }

	// RVA: 0x1CC9FF0 Offset: 0x1CCA0F1 VA: 0x1CC9FF0 Slot: 62
	public virtual void OnBlow() { }

	// RVA: 0x1CCA060 Offset: 0x1CCA161 VA: 0x1CCA060 Slot: 63
	public virtual void OnDead() { }

	// RVA: 0x1CCA0B0 Offset: 0x1CCA1B1 VA: 0x1CCA0B0 Slot: 64
	public virtual void OnBadStatus(BadStatus badStatus, bool isEnable) { }

	// RVA: 0x1CCA1D0 Offset: 0x1CCA2D1 VA: 0x1CCA1D0 Slot: 65
	public virtual void OnEndActionScript() { }

	// RVA: 0x1CCA230 Offset: 0x1CCA331 VA: 0x1CCA230 Slot: 66
	public virtual void OnEndAnimEventDamageState() { }

	// RVA: 0x1CCA2E0 Offset: 0x1CCA3E1 VA: 0x1CCA2E0 Slot: 67
	public virtual void OnEndAnimEventDeadState() { }

	// RVA: 0x1CCA2F0 Offset: 0x1CCA3F1 VA: 0x1CCA2F0 Slot: 68
	public virtual void OnEndAnimEventGetupState() { }

	// RVA: 0x1CCA3A0 Offset: 0x1CCA4A1 VA: 0x1CCA3A0 Slot: 69
	public virtual void OnEndAnimEventJumpStart() { }

	// RVA: 0x1CCA430 Offset: 0x1CCA531 VA: 0x1CCA430 Slot: 70
	public virtual void OnEndAnimEventJumpEnd() { }

	// RVA: 0x1CCA4C0 Offset: 0x1CCA5C1 VA: 0x1CCA4C0 Slot: 71
	public virtual void OnEndAnimEventMadnessState() { }

	// RVA: 0x1CCA4D0 Offset: 0x1CCA5D1 VA: 0x1CCA4D0 Slot: 72
	public virtual void OnEndAnimEventHappyState() { }

	// RVA: 0x1CCA4E0 Offset: 0x1CCA5E1 VA: 0x1CCA4E0 Slot: 73
	public virtual void OnEndAnimEventWait_2State() { }

	// RVA: 0x1CCA4F0 Offset: 0x1CCA5F1 VA: 0x1CCA4F0 Slot: 74
	public virtual void OnEndAnimEventSleepStart() { }

	// RVA: 0x1CCA500 Offset: 0x1CCA601 VA: 0x1CCA500 Slot: 75
	public virtual void OnEndAnimEventSleepEnd() { }

	// RVA: 0x1CCA560 Offset: 0x1CCA661 VA: 0x1CCA560 Slot: 76
	public virtual void SetupMonsterAction() { }

	// RVA: 0x1CCA570 Offset: 0x1CCA671 VA: 0x1CCA570 Slot: 77
	public virtual void ExecuteMonsterAction(int index) { }

	// RVA: 0x1CCA580 Offset: 0x1CCA681 VA: 0x1CCA580 Slot: 78
	public virtual void AbortMonsterAction(int index) { }

	// RVA: 0x1CCA590 Offset: 0x1CCA691 VA: 0x1CCA590 Slot: 79
	public virtual void EndMonsterAction() { }

	// RVA: 0x1CCA5A0 Offset: 0x1CCA6A1 VA: 0x1CCA5A0 Slot: 80
	public virtual void OnHearFootSteps() { }

	// RVA: 0x1CCA5B0 Offset: 0x1CCA6B1 VA: 0x1CCA5B0 Slot: 81
	public virtual void OnRestraint() { }

	// RVA: 0x1CCA5F0 Offset: 0x1CCA6F1 VA: 0x1CCA5F0 Slot: 82
	public virtual void OnRelease() { }

	// RVA: 0x1CCA600 Offset: 0x1CCA701 VA: 0x1CCA600 Slot: 26
	public void OnGrap() { }

	// RVA: 0x1CCA640 Offset: 0x1CCA741 VA: 0x1CCA640 Slot: 27
	public void OnThrow() { }

	// RVA: 0x1CCA650 Offset: 0x1CCA751 VA: 0x1CCA650 Slot: 32
	public void OnChangeModel() { }

	// RVA: 0x1CCA6B0 Offset: 0x1CCA7B1 VA: 0x1CCA6B0 Slot: 22
	public void TameStart() { }

	// RVA: 0x1CCA6D0 Offset: 0x1CCA7D1 VA: 0x1CCA6D0 Slot: 23
	public void TameEnd() { }

	// RVA: 0x1CCA710 Offset: 0x1CCA811 VA: 0x1CCA710 Slot: 83
	protected virtual void OnEndContDeadFade() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A58D0 Offset: 0x1A59D1 VA: 0x1A58D0
	// RVA: 0x1CCA7B0 Offset: 0x1CCA8B1 VA: 0x1CCA7B0
	protected IEnumerator CountDead() { }

	// RVA: 0x1CCA830 Offset: 0x1CCA931 VA: 0x1CCA830
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5940 Offset: 0x1A5A41 VA: 0x1A5940
	// RVA: 0x1CCA9A0 Offset: 0x1CCAAA1 VA: 0x1CCA9A0
	private void <OnEndContDeadFade>b__86_0() { }
}

