public class MonsterControllerBase : Character, GrapInterface, InteractionInterface, FocusInterface, ScissorsInteractionInterface, ToolInteractionInterface, BrushInteractionInterface, ItemInteractionInterface // TypeDefIndex: 8080
{
	// Fields
	private const float SHAKE_TIME = 0.2;
	private const float SHAKE_STRANGTH = 0.1;
	private const int SHAKE_VIBRATO = 115;
	protected const float DROPITEMRANGE = 1.5;
	[CompilerGeneratedAttribute] // RVA: 0x16A2E0 Offset: 0x16A3E1 VA: 0x16A2E0
	private MonsterStatusBase <MonsterStatus>k__BackingField; // 0x188
	[CompilerGeneratedAttribute] // RVA: 0x16A2F0 Offset: 0x16A3F1 VA: 0x16A2F0
	private bool <IsRestraintBehaviorTiming>k__BackingField; // 0x190
	[CompilerGeneratedAttribute] // RVA: 0x16A300 Offset: 0x16A401 VA: 0x16A300
	private bool <IsRotateLocomotion>k__BackingField; // 0x191
	[CompilerGeneratedAttribute] // RVA: 0x16A310 Offset: 0x16A411 VA: 0x16A310
	private MonsterType <MonsterType>k__BackingField; // 0x194
	[CompilerGeneratedAttribute] // RVA: 0x16A320 Offset: 0x16A421 VA: 0x16A320
	private GameObject <ModelObject>k__BackingField; // 0x198
	[CompilerGeneratedAttribute] // RVA: 0x16A330 Offset: 0x16A431 VA: 0x16A330
	private MonsterModel <MonsterModel>k__BackingField; // 0x1A0
	[CompilerGeneratedAttribute] // RVA: 0x16A340 Offset: 0x16A441 VA: 0x16A340
	private MonsterSoulController <SoulController>k__BackingField; // 0x1A8
	[CompilerGeneratedAttribute] // RVA: 0x16A350 Offset: 0x16A451 VA: 0x16A350
	private float <BehaviorWaitRate>k__BackingField; // 0x1B0
	private MonsterControllerBase.State _CurrentState; // 0x1B4
	public MonsterDataTable MonsterDataTable; // 0x1B8
	public MonsterBehaviorDataTable MonsterBehaviorDataTable; // 0x280
	public MonsterDropItemDataTable MonsterDropItemDataTable; // 0x298
	public MonsterYieldItemDataTable MonsterYieldItemDataTable; // 0x2B8
	public MonsterActionScriptsController ActionScriptsController; // 0x2C8
	protected List<MonsterProjectileActionScriptsController> MonsterProjectileList; // 0x2D0
	private List<BulletBase> BulletBaseList; // 0x2D8
	public List<Collider> BodyColliderList; // 0x2E0
	public OnDeadMonster OnFinishDead; // 0x2E8
	protected MonsterEventReceiverInterface Receiver; // 0x2F0
	private Vector3 PrevTickPosition; // 0x2F8
	protected List<BodyPartsCollision> BodyPartsCollisionList; // 0x308
	private bool ExistRotateAnimatorParam; // 0x310
	private bool IsDamageActionDeadAnimation; // 0x311
	private bool IsHandcuffsDroped; // 0x312
	private Action OnStopBlow; // 0x318
	private Tweener shake; // 0x320
	private List<MonsterControllerBase.DropItemDataParameter> DropItemDataParameterList; // 0x328
	protected string FocusName; // 0x330
	protected bool _IsBattleMode; // 0x338
	private Sequence DOJumpSequence; // 0x340
	protected bool IsSummonedFromEvent; // 0x348
	private const float DeadFadeTime = 0.25;
	protected List<SkinnedMeshRenderer> SkinnedMeshRendererList; // 0x350
	protected List<Material> MaterialList; // 0x358
	private float Timer; // 0x360
	private float Duration; // 0x364
	private float AlphaLerp; // 0x368
	private float FadeStartParam; // 0x36C
	private Action EndCallback; // 0x370
	private MonsterControllerBase.FadeType _FadeType; // 0x378
	[HeaderAttribute] // RVA: 0x16A360 Offset: 0x16A461 VA: 0x16A360
	public float LookAtSpeed; // 0x37C
	private float WeightValue; // 0x380
	protected bool IsLookTarget; // 0x384
	[CompilerGeneratedAttribute] // RVA: 0x16A3A0 Offset: 0x16A4A1 VA: 0x16A3A0
	private LookAtIK <LookAtIK>k__BackingField; // 0x388
	private DamageInfo m_ThrowDamageInfo1; // 0x390
	private DamageInfo m_ThrowDamageInfo2; // 0x410
	[CompilerGeneratedAttribute] // RVA: 0x16A3B0 Offset: 0x16A4B1 VA: 0x16A3B0
	private bool <IsCanGrapple>k__BackingField; // 0x490
	[CompilerGeneratedAttribute] // RVA: 0x16A3C0 Offset: 0x16A4C1 VA: 0x16A3C0
	private bool <IsGrappled>k__BackingField; // 0x491
	[CompilerGeneratedAttribute] // RVA: 0x16A3D0 Offset: 0x16A4D1 VA: 0x16A3D0
	private Character <GrappleChara>k__BackingField; // 0x498
	public Action<bool> OnThrowEvent; // 0x4A0
	private static readonly Vector3 MonsterGrappleOffset; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x16A3E0 Offset: 0x16A4E1 VA: 0x16A3E0
	private bool <Focusable>k__BackingField; // 0x4A8
	public MonsterControllerBase.MoveActionScriptState MoveAction_CurrentScriptState; // 0x4AC
	private float MoveAction_MaxSpeed; // 0x4B0
	private float MoveAction_MinSpeed; // 0x4B4
	public float MoveAction_EasingTime; // 0x4B8
	public bool MoveAction_IsNotRotate; // 0x4BC
	public bool MoveAction_IsInversionVector; // 0x4BD
	private float MoveAction_T; // 0x4C0
	private float MoveAction_EasingSpeed; // 0x4C4
	protected float MoveAction_CurrentSpeed; // 0x4C8
	protected Vector3 MoveAction_CurrentVelocity; // 0x4CC
	private Vector3 StartDirection; // 0x4D8
	private float Rate; // 0x4E4
	public bool RotateAction_IsRotate; // 0x4E8
	public float RatateAction_SpeedScale; // 0x4EC
	public bool RotateAction_IsInversionVector; // 0x4F0
	private const float SizeRateSmall = 0;
	private const float SizeRateMiddle = 0.5;
	private const float SizeRateLarge = 1;
	[CompilerGeneratedAttribute] // RVA: 0x16A3F0 Offset: 0x16A4F1 VA: 0x16A3F0
	private bool <CanReciveItemBehaviorTiming>k__BackingField; // 0x4F1
	[CompilerGeneratedAttribute] // RVA: 0x16A400 Offset: 0x16A501 VA: 0x16A400
	private MonsterTameRateController <MonsterTameRateController>k__BackingField; // 0x4F8

	// Properties
	public MonsterStatusBase MonsterStatus { get; set; }
	public override CharacterStatusBase Status { get; }
	public bool IsRestraintBehaviorTiming { get; set; }
	public override bool IsShortPlay { set; }
	public bool IsRotateLocomotion { get; set; }
	public MonsterType MonsterType { get; set; }
	public GameObject ModelObject { get; set; }
	public MonsterModel MonsterModel { get; set; }
	public MonsterSoulController SoulController { get; set; }
	public override bool IsBattleMode { get; }
	public float BehaviorWaitRate { get; set; }
	protected MonsterControllerBase.State CurrentState { get; set; }
	protected LookAtIK LookAtIK { get; set; }
	public bool IsCanGrapple { get; set; }
	public bool IsGrappled { get; set; }
	public Character GrappleChara { get; set; }
	public Vector3 CurrentPosition { get; }
	public bool Focusable { get; set; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }
	public bool CanReciveItemBehaviorTiming { get; set; }
	public MonsterTameRateController MonsterTameRateController { get; set; }
	public string ItemInteractionButtonHint { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A5950 Offset: 0x1A5A51 VA: 0x1A5950
	// RVA: 0x2161CB0 Offset: 0x2161DB1 VA: 0x2161CB0
	public MonsterStatusBase get_MonsterStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5960 Offset: 0x1A5A61 VA: 0x1A5960
	// RVA: 0x2161CC0 Offset: 0x2161DC1 VA: 0x2161CC0
	public void set_MonsterStatus(MonsterStatusBase value) { }

	// RVA: 0x2161CD0 Offset: 0x2161DD1 VA: 0x2161CD0 Slot: 27
	public override CharacterStatusBase get_Status() { }

	// RVA: 0x2161CE0 Offset: 0x2161DE1 VA: 0x2161CE0 Slot: 9
	public override bool IsCanNotLockon(CharacterBase lockonCharacter) { }

	// RVA: 0x2161D70 Offset: 0x2161E71 VA: 0x2161D70 Slot: 107
	public virtual bool IsCanRestraint() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5970 Offset: 0x1A5A71 VA: 0x1A5970
	// RVA: 0x2161E80 Offset: 0x2161F81 VA: 0x2161E80
	public bool get_IsRestraintBehaviorTiming() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5980 Offset: 0x1A5A81 VA: 0x1A5980
	// RVA: 0x2161E90 Offset: 0x2161F91 VA: 0x2161E90
	public void set_IsRestraintBehaviorTiming(bool value) { }

	// RVA: 0x2161EA0 Offset: 0x2161FA1 VA: 0x2161EA0 Slot: 32
	public override void set_IsShortPlay(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5990 Offset: 0x1A5A91 VA: 0x1A5990
	// RVA: 0x2161EB0 Offset: 0x2161FB1 VA: 0x2161EB0
	public bool get_IsRotateLocomotion() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A59A0 Offset: 0x1A5AA1 VA: 0x1A59A0
	// RVA: 0x2161EC0 Offset: 0x2161FC1 VA: 0x2161EC0
	public void set_IsRotateLocomotion(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A59B0 Offset: 0x1A5AB1 VA: 0x1A59B0
	// RVA: 0x2161ED0 Offset: 0x2161FD1 VA: 0x2161ED0
	public MonsterType get_MonsterType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A59C0 Offset: 0x1A5AC1 VA: 0x1A59C0
	// RVA: 0x2161EE0 Offset: 0x2161FE1 VA: 0x2161EE0
	private void set_MonsterType(MonsterType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A59D0 Offset: 0x1A5AD1 VA: 0x1A59D0
	// RVA: 0x2161EF0 Offset: 0x2161FF1 VA: 0x2161EF0
	protected void set_ModelObject(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A59E0 Offset: 0x1A5AE1 VA: 0x1A59E0
	// RVA: 0x2161F00 Offset: 0x2162001 VA: 0x2161F00
	public GameObject get_ModelObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A59F0 Offset: 0x1A5AF1 VA: 0x1A59F0
	// RVA: 0x2161F10 Offset: 0x2162011 VA: 0x2161F10
	public MonsterModel get_MonsterModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5A00 Offset: 0x1A5B01 VA: 0x1A5A00
	// RVA: 0x2161F20 Offset: 0x2162021 VA: 0x2161F20
	protected void set_MonsterModel(MonsterModel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5A10 Offset: 0x1A5B11 VA: 0x1A5A10
	// RVA: 0x2161F30 Offset: 0x2162031 VA: 0x2161F30
	public MonsterSoulController get_SoulController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5A20 Offset: 0x1A5B21 VA: 0x1A5A20
	// RVA: 0x2161F40 Offset: 0x2162041 VA: 0x2161F40
	protected void set_SoulController(MonsterSoulController value) { }

	// RVA: 0x2161F50 Offset: 0x2162051 VA: 0x2161F50 Slot: 35
	public override bool get_IsBattleMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5A30 Offset: 0x1A5B31 VA: 0x1A5A30
	// RVA: 0x2161F60 Offset: 0x2162061 VA: 0x2161F60
	public float get_BehaviorWaitRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5A40 Offset: 0x1A5B41 VA: 0x1A5A40
	// RVA: 0x2161F70 Offset: 0x2162071 VA: 0x2161F70
	protected void set_BehaviorWaitRate(float value) { }

	// RVA: 0x2161F80 Offset: 0x2162081 VA: 0x2161F80
	protected MonsterControllerBase.State get_CurrentState() { }

	// RVA: 0x2161F90 Offset: 0x2162091 VA: 0x2161F90
	protected void set_CurrentState(MonsterControllerBase.State value) { }

	// RVA: 0x2161FF0 Offset: 0x21620F1 VA: 0x2161FF0 Slot: 11
	protected override void Awake() { }

	// RVA: 0x2162490 Offset: 0x2162591 VA: 0x2162490 Slot: 12
	protected override void Start() { }

	// RVA: 0x2162590 Offset: 0x2162691 VA: 0x2162590 Slot: 40
	protected override void Update() { }

	// RVA: 0x2162970 Offset: 0x2162A71 VA: 0x2162970 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x2162B50 Offset: 0x2162C51 VA: 0x2162B50
	public void SetMonsterType(MonsterType monsterType) { }

	// RVA: 0x2162B60 Offset: 0x2162C61 VA: 0x2162B60
	public void SetModelObject(GameObject model) { }

	// RVA: 0x21634D0 Offset: 0x21635D1 VA: 0x21634D0 Slot: 75
	public override void CreateEffectPoint() { }

	// RVA: 0x2163B60 Offset: 0x2163C61 VA: 0x2163B60 Slot: 108
	public virtual void OnSetupBehavior(MonsterEventReceiverInterface receiver) { }

	// RVA: 0x2163B70 Offset: 0x2163C71 VA: 0x2163B70
	public void SetupActionScript() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5A50 Offset: 0x1A5B51 VA: 0x1A5A50
	// RVA: 0x2163D70 Offset: 0x2163E71 VA: 0x2163D70 Slot: 109
	public virtual IEnumerator SetupAsync(Action callBack) { }

	// RVA: 0x2163E40 Offset: 0x2163F41 VA: 0x2163E40 Slot: 110
	public virtual void SetupAnimator(RuntimeAnimatorController runtimeAnimatorController, Avatar avatar) { }

	// RVA: 0x21643A0 Offset: 0x21644A1 VA: 0x21643A0 Slot: 111
	public virtual void SetStatusController(MonsterStatusBase statusController) { }

	// RVA: 0x2164680 Offset: 0x2164781 VA: 0x2164680 Slot: 112
	public virtual void SetMonsterData(MonsterDataTable monsterDataTable) { }

	// RVA: 0x21646D0 Offset: 0x21647D1 VA: 0x21646D0
	public void SummonedFromEvent() { }

	// RVA: 0x21646E0 Offset: 0x21647E1 VA: 0x21646E0 Slot: 113
	protected virtual void SetupData() { }

	// RVA: 0x2164420 Offset: 0x2164521 VA: 0x2164420
	private void SetupMovementSpeed() { }

	// RVA: 0x2164990 Offset: 0x2164A91 VA: 0x2164990 Slot: 114
	protected virtual void OnUpdateState() { }

	// RVA: 0x2164A70 Offset: 0x2164B71 VA: 0x2164A70 Slot: 115
	protected virtual void OnTakeDamage(bool isDamage, ref DamageInfo damageInfo, ref DamageResult damageResult) { }

	// RVA: 0x2164B60 Offset: 0x2164C61 VA: 0x2164B60 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x21652E0 Offset: 0x21653E1 VA: 0x21652E0 Slot: 116
	protected virtual void OnDead(Character damageCauser, DamageResult damageResult) { }

	// RVA: 0x21656A0 Offset: 0x21657A1 VA: 0x21656A0 Slot: 43
	public override void PlayMotion(string name, float fadeTime = 0) { }

	// RVA: 0x21657F0 Offset: 0x21658F1 VA: 0x21657F0 Slot: 44
	public override void RePlayMotion(string name, float fadeTime = 0) { }

	// RVA: 0x2165940 Offset: 0x2165A41 VA: 0x2165940 Slot: 14
	public override void ResetAnimator() { }

	// RVA: 0x2162530 Offset: 0x2162631 VA: 0x2162530
	public void ResetAnimatorParam() { }

	// RVA: 0x2165950 Offset: 0x2165A51 VA: 0x2165950
	private void UpdateMove_CanBehindRotateAnimationParam() { }

	// RVA: 0x2165AD0 Offset: 0x2165BD1 VA: 0x2165AD0 Slot: 46
	protected override void UpdateLocomotion(float deltaTime) { }

	// RVA: 0x2165D30 Offset: 0x2165E31 VA: 0x2165D30 Slot: 47
	protected override void SetLocomotion(float value) { }

	// RVA: 0x21628A0 Offset: 0x21629A1 VA: 0x21628A0
	private void UpdateJumpAnimation() { }

	// RVA: 0x2165D90 Offset: 0x2165E91 VA: 0x2165D90 Slot: 117
	protected virtual void OnSetupMonsterAnimationEvent(MonsterAnimatorStateEvent monsterAnimatorStateEvent) { }

	// RVA: 0x2163FD0 Offset: 0x21640D1 VA: 0x2163FD0
	protected void SetupMonsterAnimationEvent() { }

	// RVA: 0x2166170 Offset: 0x2166271 VA: 0x2166170
	public void ResetNavMeshAgent() { }

	// RVA: 0x21662A0 Offset: 0x21663A1 VA: 0x21662A0 Slot: 54
	protected override float GetMoveSpeedMax() { }

	// RVA: 0x21630A0 Offset: 0x21631A1 VA: 0x21630A0
	public void RegistCollider() { }

	// RVA: 0x2166420 Offset: 0x2166521 VA: 0x2166420
	public void SetEnableCollider(bool isEnable) { }

	// RVA: 0x2166600 Offset: 0x2166701 VA: 0x2166600
	public void SetAllBodyPartsCollisionOverlap(bool isCanNotPlayerOverlap) { }

	// RVA: 0x2166710 Offset: 0x2166811 VA: 0x2166710
	private void BodyPartsOverlap(BodyPartsCollision bodyPartsCollision, Collider other) { }

	// RVA: 0x21668A0 Offset: 0x21669A1 VA: 0x21668A0
	public void EndActionScript() { }

	// RVA: 0x21627F0 Offset: 0x21628F1 VA: 0x21627F0
	private void UpdateActionScript() { }

	// RVA: 0x2166990 Offset: 0x2166A91 VA: 0x2166990 Slot: 118
	protected virtual void OnResetActionScriptAction() { }

	// RVA: 0x2166A20 Offset: 0x2166B21 VA: 0x2166A20 Slot: 119
	protected virtual void OnUpdateActionScriptAction() { }

	// RVA: 0x2166CA0 Offset: 0x2166DA1 VA: 0x2166CA0
	public bool DoDropHandcuffsDrop() { }

	// RVA: 0x2166DF0 Offset: 0x2166EF1 VA: 0x2166DF0 Slot: 120
	protected virtual MonsterControllerBase.DropItemDataParameter GetHandCuffsDropItem() { }

	// RVA: 0x2167350 Offset: 0x2167451 VA: 0x2167350 Slot: 121
	protected virtual void CalcDropItem() { }

	// RVA: 0x21677D0 Offset: 0x21678D1 VA: 0x21677D0 Slot: 122
	protected virtual List<MonsterControllerBase.DropItemDataParameter> GetDoropItemList() { }

	// RVA: 0x21677E0 Offset: 0x21678E1 VA: 0x21677E0 Slot: 123
	protected virtual MonsterControllerBase.DropItemDataParameter GetOmakeDropItem() { }

	// RVA: 0x2167A80 Offset: 0x2167B81 VA: 0x2167A80 Slot: 124
	protected virtual void DoDropItem() { }

	// RVA: 0x2167FC0 Offset: 0x21680C1 VA: 0x2167FC0 Slot: 125
	public virtual void ShortPlay() { }

	// RVA: 0x2167FE0 Offset: 0x21680E1 VA: 0x2167FE0 Slot: 126
	public virtual void ShortPlayExit() { }

	// RVA: 0x2168000 Offset: 0x2168101 VA: 0x2168000
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectile, int actionIndex) { }

	// RVA: 0x2168110 Offset: 0x2168211 VA: 0x2168110
	private void DestroyProjectileEvent(MonsterProjectileActionScriptsController projectile) { }

	// RVA: 0x21681B0 Offset: 0x21682B1 VA: 0x21681B0
	private void CreateBulletEvent(BulletBase bullet) { }

	// RVA: 0x21682C0 Offset: 0x21683C1 VA: 0x21682C0
	private void DestroyBulletEvent(BulletBase bullet) { }

	// RVA: 0x2168360 Offset: 0x2168461 VA: 0x2168360 Slot: 127
	public virtual void DestroyProjectileList() { }

	// RVA: 0x2168590 Offset: 0x2168691 VA: 0x2168590 Slot: 128
	protected virtual void OnForceDestroyProjectile(MonsterProjectileActionScriptsController projectileActionScriptsController) { }

	// RVA: 0x21685A0 Offset: 0x21686A1 VA: 0x21685A0
	public void StartFade(MonsterControllerBase.FadeType fadeType, float duration, bool isBetween = False, Action endCallback) { }

	// RVA: 0x2168770 Offset: 0x2168871 VA: 0x2168770
	public bool StartDamageBlow(Vector3 direction) { }

	// RVA: 0x21688C0 Offset: 0x21689C1 VA: 0x21688C0
	public void DoJump(Vector3 endValue, float jumpPower, int numJumps, float duration, Ease ease = 6, Action setup, Action callback, AnimationCurve customEase) { }

	// RVA: 0x21651B0 Offset: 0x21652B1 VA: 0x21651B0
	private void StartShake(float duration, float strangth, int vibrato) { }

	// RVA: 0x2168AF0 Offset: 0x2168BF1 VA: 0x2168AF0
	private void EndShake() { }

	// RVA: 0x21645B0 Offset: 0x21646B1 VA: 0x21645B0
	protected float GetBehaviorWaitRate() { }

	// RVA: 0x2168B40 Offset: 0x2168C41 VA: 0x2168B40 Slot: 129
	protected virtual void OnSetModelObject(GameObject model) { }

	// RVA: 0x2168B50 Offset: 0x2168C51 VA: 0x2168B50 Slot: 130
	protected virtual void OnSetup() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5AC0 Offset: 0x1A5BC1 VA: 0x1A5AC0
	// RVA: 0x2168B60 Offset: 0x2168C61 VA: 0x2168B60 Slot: 131
	protected virtual IEnumerator OnSetupAsync() { }

	// RVA: 0x2168BF0 Offset: 0x2168CF1 VA: 0x2168BF0 Slot: 132
	protected virtual void OnDeadEvent() { }

	// RVA: 0x2168DC0 Offset: 0x2168EC1 VA: 0x2168DC0
	public void OnDestroyBehavior() { }

	// RVA: 0x2168DE0 Offset: 0x2168EE1 VA: 0x2168DE0 Slot: 65
	public override void OnBadStatus(BadStatus badStatus, bool isEnable) { }

	// RVA: 0x2168EC0 Offset: 0x2168FC1 VA: 0x2168EC0 Slot: 18
	public override void OnSwitchActorBase(bool on) { }

	// RVA: 0x2168F70 Offset: 0x2169071 VA: 0x2168F70 Slot: 66
	public override bool OnBeforeDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x2169010 Offset: 0x2169111 VA: 0x2169010 Slot: 67
	public override void OnPlayDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x2169480 Offset: 0x2169581 VA: 0x2169480 Slot: 68
	public override void OnStopDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x21694D0 Offset: 0x21695D1 VA: 0x21694D0 Slot: 69
	public override void OnAfterDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x2169980 Offset: 0x2169A81 VA: 0x2169980 Slot: 72
	public override void OnLanding() { }

	// RVA: 0x2169A40 Offset: 0x2169B41 VA: 0x2169A40
	private void OnEndAnimEventDeadState() { }

	// RVA: 0x2169B40 Offset: 0x2169C41 VA: 0x2169B40
	private void OnEndAnimEventDamageState() { }

	// RVA: 0x2169C50 Offset: 0x2169D51 VA: 0x2169C50 Slot: 133
	protected virtual void OnEndAnimEventGetupState() { }

	// RVA: 0x2169D60 Offset: 0x2169E61 VA: 0x2169D60
	private void OnEndAnimEventJumpStartState() { }

	// RVA: 0x2169E70 Offset: 0x2169F71 VA: 0x2169E70
	private void OnEndAnimEventJumpEndState() { }

	// RVA: 0x2169F80 Offset: 0x216A081 VA: 0x2169F80
	protected void OnEndAnimMadnessState() { }

	// RVA: 0x216A090 Offset: 0x216A191 VA: 0x216A090
	private void OnEndHappyState() { }

	// RVA: 0x216A1A0 Offset: 0x216A2A1 VA: 0x216A1A0
	private void OnEndWait_2State() { }

	// RVA: 0x216A2B0 Offset: 0x216A3B1 VA: 0x216A2B0
	private void OnEndAnimEventSleepStartState() { }

	// RVA: 0x216A3C0 Offset: 0x216A4C1 VA: 0x216A3C0
	private void OnEndAnimEventSleepEndState() { }

	// RVA: 0x216A4D0 Offset: 0x216A5D1 VA: 0x216A4D0 Slot: 134
	public virtual void OnSetBodyPartsType(BodyPartsCollision bodyPartsCollision) { }

	// RVA: 0x216A4E0 Offset: 0x216A5E1 VA: 0x216A4E0 Slot: 135
	protected virtual void OnRegistCollider() { }

	// RVA: 0x216A4F0 Offset: 0x216A5F1 VA: 0x216A4F0 Slot: 136
	public virtual void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x216A500 Offset: 0x216A601 VA: 0x216A500 Slot: 137
	public virtual void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x216A510 Offset: 0x216A611 VA: 0x216A510
	protected void OnEndAction() { }

	// RVA: 0x216A630 Offset: 0x216A731 VA: 0x216A630 Slot: 138
	public virtual void OnRestraint() { }

	// RVA: 0x216A770 Offset: 0x216A871 VA: 0x216A770 Slot: 139
	public virtual void OnRelease() { }

	// RVA: 0x216A870 Offset: 0x216A971 VA: 0x216A870 Slot: 140
	protected virtual void OnHit(CharacterBase characterBase, int actionIndex) { }

	// RVA: 0x216A930 Offset: 0x216AA31 VA: 0x216A930
	public void OnHearFootSteps() { }

	// RVA: 0x216A9F0 Offset: 0x216AAF1 VA: 0x216A9F0 Slot: 58
	public override void StartBattleMode() { }

	// RVA: 0x216AA00 Offset: 0x216AB01 VA: 0x216AA00 Slot: 59
	public override void EndBattleMode() { }

	// RVA: 0x216AA10 Offset: 0x216AB11 VA: 0x216AA10
	public void Avoid() { }

	// RVA: 0x216AA20 Offset: 0x216AB21 VA: 0x216AA20
	public void Attack() { }

	// RVA: 0x216AAB0 Offset: 0x216ABB1 VA: 0x216AAB0
	public void ChargeStart() { }

	// RVA: 0x216AAC0 Offset: 0x216ABC1 VA: 0x216AAC0
	public void ChargeEnd() { }

	// RVA: 0x216AAD0 Offset: 0x216ABD1 VA: 0x216AAD0
	public void ItemHold() { }

	// RVA: 0x216AAE0 Offset: 0x216ABE1 VA: 0x216AAE0
	public void PickUpOnGroundItem(HoldableInterface item) { }

	// RVA: 0x216AAF0 Offset: 0x216ABF1 VA: 0x216AAF0
	public void PutOnGroundItem() { }

	// RVA: 0x216AB00 Offset: 0x216AC01 VA: 0x216AB00
	public void ThrowItem() { }

	// RVA: 0x216AB10 Offset: 0x216AC11 VA: 0x216AB10
	public void PutInItem() { }

	// RVA: 0x216AB20 Offset: 0x216AC21 VA: 0x216AB20
	public void UseItem() { }

	// RVA: 0x216AB30 Offset: 0x216AC31 VA: 0x216AB30
	public void RuneAbility(int index) { }

	// RVA: 0x216ABE0 Offset: 0x216ACE1 VA: 0x216ABE0 Slot: 141
	protected virtual void StartActionScript(string actionScriptName) { }

	// RVA: 0x216AC60 Offset: 0x216AD61 VA: 0x216AC60 Slot: 142
	public virtual void StartActionScript(int actionIndex) { }

	// RVA: 0x216AD00 Offset: 0x216AE01 VA: 0x216AD00
	public void StartActionBaseScript(int actionIndex) { }

	// RVA: 0x216ADA0 Offset: 0x216AEA1 VA: 0x216ADA0
	private void DeadEvent() { }

	// RVA: 0x216AF00 Offset: 0x216B001 VA: 0x216AF00 Slot: 143
	public virtual void OnFinishDeadEvent() { }

	// RVA: 0x216AF60 Offset: 0x216B061 VA: 0x216AF60
	public void ExecuteOnFinishDead() { }

	// RVA: 0x216B090 Offset: 0x216B191 VA: 0x216B090
	public void DeadActionEvent() { }

	// RVA: 0x216B3B0 Offset: 0x216B4B1 VA: 0x216B3B0 Slot: 144
	protected virtual void OnStartClearFadeOut() { }

	// RVA: 0x216B3C0 Offset: 0x216B4C1 VA: 0x216B3C0
	public void StartClearFadeOut(Action callBack) { }

	// RVA: 0x216B410 Offset: 0x216B511 VA: 0x216B410 Slot: 21
	public override void OnEvent(int index) { }

	// RVA: 0x216B440 Offset: 0x216B541 VA: 0x216B440 Slot: 22
	public override void OnEvent(int index, int param) { }

	// RVA: 0x2161D50 Offset: 0x2161E51 VA: 0x2161D50
	public bool IsFadeing() { }

	// RVA: 0x216B480 Offset: 0x216B581 VA: 0x216B480
	protected bool IsFadeIn() { }

	// RVA: 0x216B490 Offset: 0x216B591 VA: 0x216B490
	protected bool IsFadeOut() { }

	// RVA: 0x21632F0 Offset: 0x21633F1 VA: 0x21632F0
	protected void SetupFade() { }

	// RVA: 0x2162A50 Offset: 0x2162B51 VA: 0x2162A50
	protected void ClearFadeParameter() { }

	// RVA: 0x216B6A0 Offset: 0x216B7A1 VA: 0x216B6A0
	private void InvokeEndCallback() { }

	// RVA: 0x216B4B0 Offset: 0x216B5B1 VA: 0x216B4B0
	protected void EachMaterial(Action<Material> action) { }

	// RVA: 0x216B6F0 Offset: 0x216B7F1 VA: 0x216B6F0
	protected void SetEnableDither(Material material, bool enable) { }

	// RVA: 0x216B7E0 Offset: 0x216B8E1 VA: 0x216B7E0
	protected void SetEnableDitherAlpha(Material material, bool enable) { }

	// RVA: 0x21685B0 Offset: 0x21686B1 VA: 0x21685B0
	protected void OnStartFade(MonsterControllerBase.FadeType fadeType, float duration, bool isBetween, Action endCallback) { }

	// RVA: 0x21626B0 Offset: 0x21627B1 VA: 0x21626B0
	protected void OnUpdateFadeing() { }

	// RVA: 0x216B8E0 Offset: 0x216B9E1 VA: 0x216B8E0
	private void EndFade() { }

	// RVA: 0x216B980 Offset: 0x216BA81 VA: 0x216B980 Slot: 57
	public override float GetRotateSpeed() { }

	// RVA: 0x216B950 Offset: 0x216BA51 VA: 0x216B950
	public void StopFade() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5B30 Offset: 0x1A5C31 VA: 0x1A5B30
	// RVA: 0x216B990 Offset: 0x216BA91 VA: 0x216B990
	protected LookAtIK get_LookAtIK() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5B40 Offset: 0x1A5C41 VA: 0x1A5B40
	// RVA: 0x216B9A0 Offset: 0x216BAA1 VA: 0x216B9A0
	protected void set_LookAtIK(LookAtIK value) { }

	// RVA: 0x2163470 Offset: 0x2163571 VA: 0x2163470
	protected void SetupFinalIK() { }

	// RVA: 0x2162960 Offset: 0x2162A61 VA: 0x2162960
	protected void UpdateFinalIK() { }

	// RVA: 0x216B9B0 Offset: 0x216BAB1 VA: 0x216B9B0
	private void UpdateLookAtIK() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5B50 Offset: 0x1A5C51 VA: 0x1A5B50
	// RVA: 0x216BBD0 Offset: 0x216BCD1 VA: 0x216BBD0
	public bool get_IsCanGrapple() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5B60 Offset: 0x1A5C61 VA: 0x1A5B60
	// RVA: 0x216BBE0 Offset: 0x216BCE1 VA: 0x216BBE0
	private void set_IsCanGrapple(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5B70 Offset: 0x1A5C71 VA: 0x1A5B70
	// RVA: 0x216BBF0 Offset: 0x216BCF1 VA: 0x216BBF0
	public bool get_IsGrappled() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5B80 Offset: 0x1A5C81 VA: 0x1A5B80
	// RVA: 0x216BC00 Offset: 0x216BD01 VA: 0x216BC00
	private void set_IsGrappled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5B90 Offset: 0x1A5C91 VA: 0x1A5B90
	// RVA: 0x216BC10 Offset: 0x216BD11 VA: 0x216BC10
	public Character get_GrappleChara() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5BA0 Offset: 0x1A5CA1 VA: 0x1A5BA0
	// RVA: 0x216BC20 Offset: 0x216BD21 VA: 0x216BC20
	private void set_GrappleChara(Character value) { }

	// RVA: 0x216BC30 Offset: 0x216BD31 VA: 0x216BC30
	public void SetActiveGrappled(bool isActive) { }

	// RVA: 0x216BC50 Offset: 0x216BD51 VA: 0x216BC50 Slot: 145
	public virtual bool CanGrap(HumanController humanController) { }

	// RVA: 0x216BDF0 Offset: 0x216BEF1 VA: 0x216BDF0 Slot: 146
	public virtual void OnGrap(Character chara) { }

	// RVA: 0x216C010 Offset: 0x216C111 VA: 0x216C010 Slot: 147
	public virtual bool DoGrap(HumanController humanController) { }

	// RVA: 0x216C150 Offset: 0x216C251 VA: 0x216C150 Slot: 79
	public bool OnThrow(Vector3 direction, float power) { }

	// RVA: 0x216C420 Offset: 0x216C521 VA: 0x216C420
	private void EndThrow() { }

	// RVA: 0x216C490 Offset: 0x216C591 VA: 0x216C490 Slot: 148
	public virtual bool OnThrow(Vector3 direction, float power, DamageInfo damageInfo) { }

	// RVA: 0x216C7D0 Offset: 0x216C8D1 VA: 0x216C7D0 Slot: 81
	public bool OnThrow(Vector3 direction, float power, DamageInfo damageInfo1, DamageInfo damageInfo2) { }

	// RVA: 0x216C990 Offset: 0x216CA91 VA: 0x216C990 Slot: 149
	protected virtual void TakeThrowDamage() { }

	// RVA: 0x216CC40 Offset: 0x216CD41 VA: 0x216CC40
	private void TakeThrowImpactDamage() { }

	// RVA: 0x216D460 Offset: 0x216D561 VA: 0x216D460 Slot: 83
	public void UpdatePosition(Vector3 position, Vector3 foward, float rate) { }

	// RVA: 0x216D790 Offset: 0x216D891 VA: 0x216D790 Slot: 84
	public Vector3 get_CurrentPosition() { }

	// RVA: 0x216D7C0 Offset: 0x216D8C1 VA: 0x216D7C0 Slot: 85
	public void DoInteraction(HumanController character) { }

	// RVA: 0x216DA90 Offset: 0x216DB91 VA: 0x216DA90
	public void OnRide(ActorID actorID = -1) { }

	// RVA: 0x216DE50 Offset: 0x216DF51 VA: 0x216DE50 Slot: 86
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x216E1C0 Offset: 0x216E2C1 VA: 0x216E1C0
	private bool IsParty() { }

	// RVA: 0x216E1F0 Offset: 0x216E2F1 VA: 0x216E1F0 Slot: 89
	public string GetInteractionButtonHint() { }

	// RVA: 0x216E240 Offset: 0x216E341 VA: 0x216E240 Slot: 150
	public virtual string GetFocusName() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5BB0 Offset: 0x1A5CB1 VA: 0x1A5BB0
	// RVA: 0x216E270 Offset: 0x216E371 VA: 0x216E270 Slot: 91
	public bool get_Focusable() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5BC0 Offset: 0x1A5CC1 VA: 0x1A5BC0
	// RVA: 0x216E280 Offset: 0x216E381 VA: 0x216E280
	private void set_Focusable(bool value) { }

	// RVA: 0x216E290 Offset: 0x216E391 VA: 0x216E290 Slot: 94
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x216E2C0 Offset: 0x216E3C1 VA: 0x216E2C0 Slot: 95
	public int get_FocusPriority() { }

	// RVA: 0x216E2D0 Offset: 0x216E3D1 VA: 0x216E2D0 Slot: 96
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x216E2E0 Offset: 0x216E3E1 VA: 0x216E2E0 Slot: 92
	public void OnFocus() { }

	// RVA: 0x216E2F0 Offset: 0x216E3F1 VA: 0x216E2F0 Slot: 93
	public void OffFocus() { }

	// RVA: 0x216E300 Offset: 0x216E401 VA: 0x216E300 Slot: 97
	public ushort GetInteractionType() { }

	// RVA: 0x216E460 Offset: 0x216E561 VA: 0x216E460 Slot: 87
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x216E470 Offset: 0x216E571 VA: 0x216E470 Slot: 88
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x216E480 Offset: 0x216E581 VA: 0x216E480
	public void SetMoveAction_MaxSpeed(float speed) { }

	// RVA: 0x216E490 Offset: 0x216E591 VA: 0x216E490
	public void SetMoveAction_MinSpeed(float speed) { }

	// RVA: 0x216E4A0 Offset: 0x216E5A1 VA: 0x216E4A0
	protected void SetMoveSpeedActionScript(float rate = 1) { }

	// RVA: 0x216E4B0 Offset: 0x216E5B1 VA: 0x216E4B0 Slot: 151
	protected virtual void OnResetMoveActionScript() { }

	// RVA: 0x216E4D0 Offset: 0x216E5D1 VA: 0x216E4D0
	protected void OnStartMoveActionScript() { }

	// RVA: 0x2166A50 Offset: 0x2166B51 VA: 0x2166A50
	protected void OnUpdateMoveActionScript() { }

	// RVA: 0x216E650 Offset: 0x216E751 VA: 0x216E650
	public float EaseOutExpo(float s, float e, float t) { }

	// RVA: 0x216E7F0 Offset: 0x216E8F1 VA: 0x216E7F0
	public void OnEndMoveActionScript() { }

	// RVA: 0x216E6F0 Offset: 0x216E7F1 VA: 0x216E6F0
	protected void MoveNavMeshAgent(Vector3 velocity) { }

	// RVA: 0x21669E0 Offset: 0x2166AE1 VA: 0x21669E0
	protected void OnResetRotateActionScript() { }

	// RVA: 0x216E8A0 Offset: 0x216E9A1 VA: 0x216E8A0 Slot: 152
	protected virtual void OnUpdateRotateActionScript() { }

	// RVA: 0x216EB30 Offset: 0x216EC31 VA: 0x216EB30 Slot: 153
	public virtual bool DoUseScissors(out float size) { }

	// RVA: 0x216EBE0 Offset: 0x216ECE1 VA: 0x216EBE0 Slot: 154
	public virtual bool CanUseScissors(HumanController character) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5BD0 Offset: 0x1A5CD1 VA: 0x1A5BD0
	// RVA: 0x216EBF0 Offset: 0x216ECF1 VA: 0x216EBF0
	public bool get_CanReciveItemBehaviorTiming() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5BE0 Offset: 0x1A5CE1 VA: 0x1A5BE0
	// RVA: 0x216EC00 Offset: 0x216ED01 VA: 0x216EC00
	public void set_CanReciveItemBehaviorTiming(bool value) { }

	// RVA: 0x216EC10 Offset: 0x216ED11 VA: 0x216EC10 Slot: 155
	protected virtual bool CanReciveItem() { }

	// RVA: 0x216EC20 Offset: 0x216ED21 VA: 0x216EC20 Slot: 156
	protected virtual bool CanFriend() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5BF0 Offset: 0x1A5CF1 VA: 0x1A5BF0
	// RVA: 0x216EDE0 Offset: 0x216EEE1 VA: 0x216EDE0
	public MonsterTameRateController get_MonsterTameRateController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5C00 Offset: 0x1A5D01 VA: 0x1A5C00
	// RVA: 0x216EDF0 Offset: 0x216EEF1 VA: 0x216EDF0
	protected void set_MonsterTameRateController(MonsterTameRateController value) { }

	// RVA: 0x2162400 Offset: 0x2162501 VA: 0x2162400
	private void SetupMonsterTameRateController() { }

	// RVA: 0x216EE00 Offset: 0x216EF01 VA: 0x216EE00
	private bool CanFriendApprouch() { }

	// RVA: 0x21652C0 Offset: 0x21653C1 VA: 0x21652C0
	public void UpdateTameRateTakeDamage(ref DamageResult result) { }

	// RVA: 0x216EF90 Offset: 0x216F091 VA: 0x216EF90 Slot: 103
	public bool CanUseBrush(HumanController character) { }

	// RVA: 0x216EB90 Offset: 0x216EC91 VA: 0x216EB90
	protected float GetSizeRate() { }

	// RVA: 0x216EFF0 Offset: 0x216F0F1 VA: 0x216EFF0 Slot: 102
	public bool DoUseBrush(out float size) { }

	// RVA: 0x216F3E0 Offset: 0x216F4E1 VA: 0x216F3E0 Slot: 157
	protected virtual void OnUseItem(ItemData item) { }

	// RVA: 0x216F420 Offset: 0x216F521 VA: 0x216F420
	private void DoItemPresent(HumanStatus humanstatus, ItemData item) { }

	// RVA: 0x216F930 Offset: 0x216FA31 VA: 0x216F930 Slot: 104
	public void DoItemInteraction(HumanController causer, ItemData itemData, bool isThrow) { }

	// RVA: 0x216F7C0 Offset: 0x216F8C1 VA: 0x216F7C0
	public void DoFriendJudgement() { }

	// RVA: 0x216FB60 Offset: 0x216FC61 VA: 0x216FB60
	private void EndFriendJudgment(bool isSuccess, string nickName) { }

	// RVA: 0x216E450 Offset: 0x216E551 VA: 0x216E450 Slot: 105
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: 0x216FF10 Offset: 0x2170011 VA: 0x216FF10 Slot: 106
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData) { }

	// RVA: 0x216FF20 Offset: 0x2170021 VA: 0x216FF20
	public string get_ItemInteractionButtonHint() { }

	// RVA: 0x216F620 Offset: 0x216F721 VA: 0x216F620
	public void PlayEmotionEffect(EmotionType emotionType, Action callBack) { }

	// RVA: 0x216F390 Offset: 0x216F491 VA: 0x216F390
	public void PlayEmotionNoteTypeEffect(Action callBack) { }

	// RVA: 0x216FF30 Offset: 0x2170031 VA: 0x216FF30
	public void .ctor() { }

	// RVA: 0x21701A0 Offset: 0x21702A1 VA: 0x21701A0
	private static void .cctor() { }

	// RVA: 0x2170230 Offset: 0x2170331 VA: 0x2170230 Slot: 98
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x2170240 Offset: 0x2170341 VA: 0x2170240 Slot: 99
	private Transform FocusInterface.get_transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5C10 Offset: 0x1A5D11 VA: 0x1A5C10
	// RVA: 0x2170250 Offset: 0x2170351 VA: 0x2170250
	private void <SetupFade>b__201_0(Material material) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5C20 Offset: 0x1A5D21 VA: 0x1A5C20
	// RVA: 0x2170360 Offset: 0x2170461 VA: 0x2170360
	private void <OnUpdateFadeing>b__208_0(Material material) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A5C30 Offset: 0x1A5D31 VA: 0x1A5C30
	// RVA: 0x2170440 Offset: 0x2170541 VA: 0x2170440
	private void <OnUpdateFadeing>b__208_1(Material material) { }
}

