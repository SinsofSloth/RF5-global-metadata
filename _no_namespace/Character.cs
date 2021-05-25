[DisallowMultipleComponent] // RVA: 0x145DF0 Offset: 0x145EF1 VA: 0x145DF0
[DefaultExecutionOrder] // RVA: 0x145DF0 Offset: 0x145EF1 VA: 0x145DF0
public class Character : ActorController // TypeDefIndex: 6611
{
	// Fields
	[HeaderAttribute] // RVA: 0x15DAF0 Offset: 0x15DBF1 VA: 0x15DAF0
	[SerializeField] // RVA: 0x15DAF0 Offset: 0x15DBF1 VA: 0x15DAF0
	protected UnityEvent[] m_ActionEvents; // 0x70
	protected static readonly float DefaultHumanScale; // 0x0
	protected static readonly Vector3 LOCKON_OFFSET; // 0x4
	private const float APPROACH_MAX_RANGE = 6;
	private const float BOSSBATTLE_LOCKON_RANGE = 1000;
	[CompilerGeneratedAttribute] // RVA: 0x15DB40 Offset: 0x15DC41 VA: 0x15DB40
	private readonly CharacterStatusBase <Status>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x15DB50 Offset: 0x15DC51 VA: 0x15DB50
	private float <InvincibleTimer>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x15DB60 Offset: 0x15DC61 VA: 0x15DB60
	private bool <IsShortPlayMove>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x15DB70 Offset: 0x15DC71 VA: 0x15DB70
	private Vector3 <ShortPlayTargetPosition>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x15DB80 Offset: 0x15DC81 VA: 0x15DB80
	private CharacterBase <LockedTarget>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x15DB90 Offset: 0x15DC91 VA: 0x15DB90
	private CharacterAnimationParam <AnimationParam>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x15DBA0 Offset: 0x15DCA1 VA: 0x15DBA0
	private float <Locomotion>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x15DBB0 Offset: 0x15DCB1 VA: 0x15DBB0
	private readonly bool <IsBattleMode>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x15DBC0 Offset: 0x15DCC1 VA: 0x15DBC0
	private NavMeshAgent <NavMeshAgent>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x15DBD0 Offset: 0x15DCD1 VA: 0x15DBD0
	private CharacterController <CharacterController>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x15DBE0 Offset: 0x15DCE1 VA: 0x15DBE0
	private ActionScriptControllerBase <ActionScriptControllerBase>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x15DBF0 Offset: 0x15DCF1 VA: 0x15DBF0
	private Vector3 <DeltaPosition>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x15DC00 Offset: 0x15DD01 VA: 0x15DC00
	private Quaternion <DeltRotation>k__BackingField; // 0xD4
	[CompilerGeneratedAttribute] // RVA: 0x15DC10 Offset: 0x15DD11 VA: 0x15DC10
	private bool <InFarm>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x15DC20 Offset: 0x15DD21 VA: 0x15DC20
	private int <InDoorCnt>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x15DC30 Offset: 0x15DD31 VA: 0x15DC30
	private bool <IsFreeseXZRootMotion>k__BackingField; // 0xEC
	[CompilerGeneratedAttribute] // RVA: 0x15DC40 Offset: 0x15DD41 VA: 0x15DC40
	private Transform <EffectPoint>k__BackingField; // 0xF0
	[HeaderAttribute] // RVA: 0x15DC50 Offset: 0x15DD51 VA: 0x15DC50
	[SerializeField] // RVA: 0x15DC50 Offset: 0x15DD51 VA: 0x15DC50
	protected CharacterMovement m_Movement; // 0xF8
	[SerializeField] // RVA: 0x15DCA0 Offset: 0x15DDA1 VA: 0x15DCA0
	protected DamageActionController m_DamageAction; // 0x100
	[SerializeField] // RVA: 0x15DCB0 Offset: 0x15DDB1 VA: 0x15DCB0
	protected ActorVoiceController m_VoiceController; // 0x108
	[SerializeField] // RVA: 0x15DCC0 Offset: 0x15DDC1 VA: 0x15DCC0
	protected RestraintController m_RestraintController; // 0x110
	[SerializeField] // RVA: 0x15DCD0 Offset: 0x15DDD1 VA: 0x15DCD0
	protected SlowStateController m_SlowStateController; // 0x118
	[SerializeField] // RVA: 0x15DCE0 Offset: 0x15DDE1 VA: 0x15DCE0
	protected FootSteps m_FootSteps; // 0x120
	[SerializeField] // RVA: 0x15DCF0 Offset: 0x15DDF1 VA: 0x15DCF0
	protected CharaFaceController m_FaceController; // 0x128
	[SerializeField] // RVA: 0x15DD00 Offset: 0x15DE01 VA: 0x15DD00
	protected PersonalMotionController m_PersonalMotion; // 0x130
	[SerializeField] // RVA: 0x15DD10 Offset: 0x15DE11 VA: 0x15DD10
	protected MagicMotionController m_MagicMotionController; // 0x138
	[SerializeField] // RVA: 0x15DD20 Offset: 0x15DE21 VA: 0x15DD20
	protected EscapeController m_EscapeController; // 0x140
	[SerializeField] // RVA: 0x15DD30 Offset: 0x15DE31 VA: 0x15DD30
	protected RideController m_RideController; // 0x148
	[SerializeField] // RVA: 0x15DD40 Offset: 0x15DE41 VA: 0x15DD40
	protected LazyController m_LazyController; // 0x150
	[SerializeField] // RVA: 0x15DD50 Offset: 0x15DE51 VA: 0x15DD50
	protected SuperArmorController m_SuperArmor; // 0x158
	[HeaderAttribute] // RVA: 0x15DD60 Offset: 0x15DE61 VA: 0x15DD60
	[SerializeField] // RVA: 0x15DD60 Offset: 0x15DE61 VA: 0x15DD60
	protected float m_LockonRadius; // 0x160
	[SerializeField] // RVA: 0x15DDB0 Offset: 0x15DEB1 VA: 0x15DDB0
	protected float m_LockonAngle; // 0x164
	protected float m_ApproachEnemyRadius; // 0x168
	protected float m_ApproachEnemyAngle; // 0x16C
	private bool _IsShortPlay; // 0x170
	private Dictionary<string, int> m_HashParam; // 0x178
	protected float FreeseXZRootMotionTimer; // 0x180

	// Properties
	public override bool IsActive { get; }
	public virtual CharacterStatusBase Status { get; }
	public virtual bool IsDead { get; }
	public virtual bool IsInvincible { get; }
	public float InvincibleTimer { get; set; }
	public override Alliance Alliance { get; }
	public virtual Parameter Parameter { get; }
	public override Vector3 GetTakeLockonPos { get; }
	public virtual bool IsShortPlay { get; set; }
	public virtual bool IsShortPlayMove { get; set; }
	public Vector3 ShortPlayTargetPosition { get; set; }
	public CharacterBase LockedTarget { get; set; }
	public CharacterAnimationParam AnimationParam { get; set; }
	public float Locomotion { get; set; }
	public virtual bool IsBattleMode { get; }
	public NavMeshAgent NavMeshAgent { get; set; }
	protected CharacterController CharacterController { get; set; }
	public ActionScriptControllerBase ActionScriptControllerBase { get; set; }
	public bool IsPC { get; }
	public InteractionCollider InteractionCollider { get; }
	public CharacterMovement Movement { get; set; }
	public bool IsGrounded { get; }
	public bool IsDamageAction { get; }
	public DamageActionController DamageAction { get; set; }
	public ActorVoiceController VoiceController { get; set; }
	public RestraintController Restraint { get; set; }
	public SlowStateController SlowState { get; set; }
	public FootSteps FootSteps { get; set; }
	public CharaFaceController FaceController { get; set; }
	public MagicMotionController MagicMotion { get; set; }
	public EscapeController Escape { get; set; }
	public bool IsEscaping { get; }
	public RideController RideController { get; set; }
	public bool IsRiding { get; }
	public LazyController LazyController { get; set; }
	public PersonalMotionController PersonalMotion { get; set; }
	public SuperArmorController SuperArmor { get; set; }
	public bool IsSuperArmor { get; }
	public virtual bool IsItemHold { get; }
	public Vector3 DeltaPosition { get; set; }
	public Quaternion DeltRotation { get; set; }
	public bool InFarm { get; set; }
	public int InDoorCnt { get; set; }
	public bool IsFreeseXZRootMotion { get; set; }
	public Transform EffectPoint { get; set; }
	protected virtual bool KeepAnimatorControllerStateOnDisable { get; }
	public virtual float LookIKWeight { set; }
	protected virtual bool UseGravityOnNavMeshEnabled { get; }

	// Methods

	// RVA: 0x1D433D0 Offset: 0x1D434D1 VA: 0x1D433D0 Slot: 21
	public virtual void OnEvent(int index) { }

	// RVA: 0x1D43430 Offset: 0x1D43531 VA: 0x1D43430 Slot: 22
	public virtual void OnEvent(int index, int param) { }

	// RVA: 0x1D43490 Offset: 0x1D43591 VA: 0x1D43490 Slot: 23
	public virtual void OnEvent(int index, float param) { }

	// RVA: 0x1D434F0 Offset: 0x1D435F1 VA: 0x1D434F0 Slot: 24
	public virtual void OnEvent(int index, string param) { }

	// RVA: 0x1D3E600 Offset: 0x1D3E701 VA: 0x1D3E600 Slot: 25
	public virtual void OnEvent(int index, bool param) { }

	// RVA: 0x1D43500 Offset: 0x1D43601 VA: 0x1D43500 Slot: 26
	public virtual void OnEvent(int index, Object param) { }

	// RVA: 0x1D43560 Offset: 0x1D43661 VA: 0x1D43560 Slot: 17
	public override bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BA80 Offset: 0x19BB81 VA: 0x19BA80
	// RVA: 0x1D435F0 Offset: 0x1D436F1 VA: 0x1D435F0 Slot: 27
	public virtual CharacterStatusBase get_Status() { }

	// RVA: 0x1D43600 Offset: 0x1D43701 VA: 0x1D43600 Slot: 28
	public virtual bool get_IsDead() { }

	// RVA: 0x1D43660 Offset: 0x1D43761 VA: 0x1D43660 Slot: 29
	public virtual bool get_IsInvincible() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BA90 Offset: 0x19BB91 VA: 0x19BA90
	// RVA: 0x1D436E0 Offset: 0x1D437E1 VA: 0x1D436E0
	public float get_InvincibleTimer() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BAA0 Offset: 0x19BBA1 VA: 0x19BAA0
	// RVA: 0x1D436F0 Offset: 0x1D437F1 VA: 0x1D436F0
	private void set_InvincibleTimer(float value) { }

	// RVA: 0x1D43700 Offset: 0x1D43801 VA: 0x1D43700 Slot: 8
	public override Alliance get_Alliance() { }

	// RVA: 0x1D43760 Offset: 0x1D43861 VA: 0x1D43760 Slot: 30
	public virtual Parameter get_Parameter() { }

	// RVA: 0x1D437D0 Offset: 0x1D438D1 VA: 0x1D437D0 Slot: 9
	public override bool IsCanNotLockon(CharacterBase lockonCharacter) { }

	// RVA: 0x1D438A0 Offset: 0x1D439A1 VA: 0x1D438A0 Slot: 10
	public override Vector3 get_GetTakeLockonPos() { }

	// RVA: 0x1D43A50 Offset: 0x1D43B51 VA: 0x1D43A50 Slot: 31
	public virtual bool get_IsShortPlay() { }

	// RVA: 0x1D43A60 Offset: 0x1D43B61 VA: 0x1D43A60 Slot: 32
	public virtual void set_IsShortPlay(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BAB0 Offset: 0x19BBB1 VA: 0x19BAB0
	// RVA: 0x1D43A90 Offset: 0x1D43B91 VA: 0x1D43A90 Slot: 33
	public virtual bool get_IsShortPlayMove() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BAC0 Offset: 0x19BBC1 VA: 0x19BAC0
	// RVA: 0x1D43AA0 Offset: 0x1D43BA1 VA: 0x1D43AA0 Slot: 34
	public virtual void set_IsShortPlayMove(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BAD0 Offset: 0x19BBD1 VA: 0x19BAD0
	// RVA: 0x1D43AB0 Offset: 0x1D43BB1 VA: 0x1D43AB0
	public Vector3 get_ShortPlayTargetPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BAE0 Offset: 0x19BBE1 VA: 0x19BAE0
	// RVA: 0x1D43AC0 Offset: 0x1D43BC1 VA: 0x1D43AC0
	public void set_ShortPlayTargetPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BAF0 Offset: 0x19BBF1 VA: 0x19BAF0
	// RVA: 0x1D43AD0 Offset: 0x1D43BD1 VA: 0x1D43AD0
	public CharacterBase get_LockedTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BB00 Offset: 0x19BC01 VA: 0x19BB00
	// RVA: 0x1D43AE0 Offset: 0x1D43BE1 VA: 0x1D43AE0
	protected void set_LockedTarget(CharacterBase value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BB10 Offset: 0x19BC11 VA: 0x19BB10
	// RVA: 0x1D43AF0 Offset: 0x1D43BF1 VA: 0x1D43AF0
	public CharacterAnimationParam get_AnimationParam() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BB20 Offset: 0x19BC21 VA: 0x19BB20
	// RVA: 0x1D43B00 Offset: 0x1D43C01 VA: 0x1D43B00
	public void set_AnimationParam(CharacterAnimationParam value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BB30 Offset: 0x19BC31 VA: 0x19BB30
	// RVA: 0x1D43B10 Offset: 0x1D43C11 VA: 0x1D43B10
	public float get_Locomotion() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BB40 Offset: 0x19BC41 VA: 0x19BB40
	// RVA: 0x1D43B20 Offset: 0x1D43C21 VA: 0x1D43B20
	public void set_Locomotion(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BB50 Offset: 0x19BC51 VA: 0x19BB50
	// RVA: 0x1D43B30 Offset: 0x1D43C31 VA: 0x1D43B30 Slot: 35
	public virtual bool get_IsBattleMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BB60 Offset: 0x19BC61 VA: 0x19BB60
	// RVA: 0x1D43B40 Offset: 0x1D43C41 VA: 0x1D43B40
	public NavMeshAgent get_NavMeshAgent() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BB70 Offset: 0x19BC71 VA: 0x19BB70
	// RVA: 0x1D43B50 Offset: 0x1D43C51 VA: 0x1D43B50
	protected void set_NavMeshAgent(NavMeshAgent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BB80 Offset: 0x19BC81 VA: 0x19BB80
	// RVA: 0x1D43B60 Offset: 0x1D43C61 VA: 0x1D43B60
	protected CharacterController get_CharacterController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BB90 Offset: 0x19BC91 VA: 0x19BB90
	// RVA: 0x1D43B70 Offset: 0x1D43C71 VA: 0x1D43B70
	protected void set_CharacterController(CharacterController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BBA0 Offset: 0x19BCA1 VA: 0x19BBA0
	// RVA: 0x1D43B80 Offset: 0x1D43C81 VA: 0x1D43B80
	public ActionScriptControllerBase get_ActionScriptControllerBase() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BBB0 Offset: 0x19BCB1 VA: 0x19BBB0
	// RVA: 0x1D43B90 Offset: 0x1D43C91 VA: 0x1D43B90
	private void set_ActionScriptControllerBase(ActionScriptControllerBase value) { }

	// RVA: 0x1D43BA0 Offset: 0x1D43CA1 VA: 0x1D43BA0
	public bool get_IsPC() { }

	// RVA: 0x1D43C50 Offset: 0x1D43D51 VA: 0x1D43C50
	public InteractionCollider get_InteractionCollider() { }

	// RVA: 0x1D43D90 Offset: 0x1D43E91 VA: 0x1D43D90
	public CharacterMovement get_Movement() { }

	// RVA: 0x1D43DA0 Offset: 0x1D43EA1 VA: 0x1D43DA0
	protected void set_Movement(CharacterMovement value) { }

	// RVA: 0x1D43DB0 Offset: 0x1D43EB1 VA: 0x1D43DB0
	public bool get_IsGrounded() { }

	// RVA: 0x1D43E50 Offset: 0x1D43F51 VA: 0x1D43E50
	public bool get_IsDamageAction() { }

	// RVA: 0x1D43EF0 Offset: 0x1D43FF1 VA: 0x1D43EF0
	public DamageActionController get_DamageAction() { }

	// RVA: 0x1D43F00 Offset: 0x1D44001 VA: 0x1D43F00
	protected void set_DamageAction(DamageActionController value) { }

	// RVA: 0x1D43F10 Offset: 0x1D44011 VA: 0x1D43F10
	public ActorVoiceController get_VoiceController() { }

	// RVA: 0x1D43F20 Offset: 0x1D44021 VA: 0x1D43F20
	protected void set_VoiceController(ActorVoiceController value) { }

	// RVA: 0x1D43F30 Offset: 0x1D44031 VA: 0x1D43F30
	public RestraintController get_Restraint() { }

	// RVA: 0x1D43F40 Offset: 0x1D44041 VA: 0x1D43F40
	protected void set_Restraint(RestraintController value) { }

	// RVA: 0x1D43F50 Offset: 0x1D44051 VA: 0x1D43F50
	public SlowStateController get_SlowState() { }

	// RVA: 0x1D43F60 Offset: 0x1D44061 VA: 0x1D43F60
	protected void set_SlowState(SlowStateController value) { }

	// RVA: 0x1D43F70 Offset: 0x1D44071 VA: 0x1D43F70
	public FootSteps get_FootSteps() { }

	// RVA: 0x1D43F80 Offset: 0x1D44081 VA: 0x1D43F80
	protected void set_FootSteps(FootSteps value) { }

	// RVA: 0x1D43F90 Offset: 0x1D44091 VA: 0x1D43F90
	public CharaFaceController get_FaceController() { }

	// RVA: 0x1D43FA0 Offset: 0x1D440A1 VA: 0x1D43FA0
	protected void set_FaceController(CharaFaceController value) { }

	// RVA: 0x1D43FB0 Offset: 0x1D440B1 VA: 0x1D43FB0
	public MagicMotionController get_MagicMotion() { }

	// RVA: 0x1D43FC0 Offset: 0x1D440C1 VA: 0x1D43FC0
	protected void set_MagicMotion(MagicMotionController value) { }

	// RVA: 0x1D43FD0 Offset: 0x1D440D1 VA: 0x1D43FD0
	public EscapeController get_Escape() { }

	// RVA: 0x1D43FE0 Offset: 0x1D440E1 VA: 0x1D43FE0
	protected void set_Escape(EscapeController value) { }

	// RVA: 0x1D43FF0 Offset: 0x1D440F1 VA: 0x1D43FF0
	public bool get_IsEscaping() { }

	// RVA: 0x1D44090 Offset: 0x1D44191 VA: 0x1D44090
	public RideController get_RideController() { }

	// RVA: 0x1D440A0 Offset: 0x1D441A1 VA: 0x1D440A0
	protected void set_RideController(RideController value) { }

	// RVA: 0x1D440B0 Offset: 0x1D441B1 VA: 0x1D440B0
	public bool get_IsRiding() { }

	// RVA: 0x1D44150 Offset: 0x1D44251 VA: 0x1D44150
	public LazyController get_LazyController() { }

	// RVA: 0x1D44160 Offset: 0x1D44261 VA: 0x1D44160
	protected void set_LazyController(LazyController value) { }

	// RVA: 0x1D44170 Offset: 0x1D44271 VA: 0x1D44170
	public PersonalMotionController get_PersonalMotion() { }

	// RVA: 0x1D44180 Offset: 0x1D44281 VA: 0x1D44180
	protected void set_PersonalMotion(PersonalMotionController value) { }

	// RVA: 0x1D44190 Offset: 0x1D44291 VA: 0x1D44190
	public SuperArmorController get_SuperArmor() { }

	// RVA: 0x1D441A0 Offset: 0x1D442A1 VA: 0x1D441A0
	protected void set_SuperArmor(SuperArmorController value) { }

	// RVA: 0x1D441B0 Offset: 0x1D442B1 VA: 0x1D441B0
	public bool get_IsSuperArmor() { }

	// RVA: 0x1D44250 Offset: 0x1D44351 VA: 0x1D44250 Slot: 36
	public virtual bool get_IsItemHold() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BBC0 Offset: 0x19BCC1 VA: 0x19BBC0
	// RVA: 0x1D44260 Offset: 0x1D44361 VA: 0x1D44260
	public Vector3 get_DeltaPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BBD0 Offset: 0x19BCD1 VA: 0x19BBD0
	// RVA: 0x1D44270 Offset: 0x1D44371 VA: 0x1D44270
	public void set_DeltaPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BBE0 Offset: 0x19BCE1 VA: 0x19BBE0
	// RVA: 0x1D44280 Offset: 0x1D44381 VA: 0x1D44280
	public Quaternion get_DeltRotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BBF0 Offset: 0x19BCF1 VA: 0x19BBF0
	// RVA: 0x1D44290 Offset: 0x1D44391 VA: 0x1D44290
	public void set_DeltRotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BC00 Offset: 0x19BD01 VA: 0x19BC00
	// RVA: 0x1D442B0 Offset: 0x1D443B1 VA: 0x1D442B0
	public bool get_InFarm() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BC10 Offset: 0x19BD11 VA: 0x19BC10
	// RVA: 0x1D442C0 Offset: 0x1D443C1 VA: 0x1D442C0
	public void set_InFarm(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BC20 Offset: 0x19BD21 VA: 0x19BC20
	// RVA: 0x1D442D0 Offset: 0x1D443D1 VA: 0x1D442D0
	public int get_InDoorCnt() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BC30 Offset: 0x19BD31 VA: 0x19BC30
	// RVA: 0x1D442E0 Offset: 0x1D443E1 VA: 0x1D442E0
	public void set_InDoorCnt(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BC40 Offset: 0x19BD41 VA: 0x19BC40
	// RVA: 0x1D442F0 Offset: 0x1D443F1 VA: 0x1D442F0
	public bool get_IsFreeseXZRootMotion() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BC50 Offset: 0x19BD51 VA: 0x19BC50
	// RVA: 0x1D44300 Offset: 0x1D44401 VA: 0x1D44300
	public void set_IsFreeseXZRootMotion(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BC60 Offset: 0x19BD61 VA: 0x19BC60
	// RVA: 0x1D44310 Offset: 0x1D44411 VA: 0x1D44310
	public Transform get_EffectPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BC70 Offset: 0x19BD71 VA: 0x19BC70
	// RVA: 0x1D44320 Offset: 0x1D44421 VA: 0x1D44320
	public void set_EffectPoint(Transform value) { }

	// RVA: 0x1D44330 Offset: 0x1D44431 VA: 0x1D44330 Slot: 37
	protected virtual bool get_KeepAnimatorControllerStateOnDisable() { }

	// RVA: 0x1D44340 Offset: 0x1D44441 VA: 0x1D44340 Slot: 38
	public virtual void set_LookIKWeight(float value) { }

	// RVA: 0x1D44350 Offset: 0x1D44451 VA: 0x1D44350 Slot: 39
	protected virtual bool get_UseGravityOnNavMeshEnabled() { }

	// RVA: 0x1D44360 Offset: 0x1D44461 VA: 0x1D44360 Slot: 11
	protected override void Awake() { }

	// RVA: 0x1D44880 Offset: 0x1D44981 VA: 0x1D44880 Slot: 12
	protected override void Start() { }

	// RVA: 0x1D44BA0 Offset: 0x1D44CA1 VA: 0x1D44BA0
	private void OnAnimatorMove() { }

	// RVA: 0x1D44CF0 Offset: 0x1D44DF1 VA: 0x1D44CF0 Slot: 40
	protected virtual void Update() { }

	// RVA: 0x1D451E0 Offset: 0x1D452E1 VA: 0x1D451E0 Slot: 41
	protected virtual void LateUpdate() { }

	// RVA: 0x1D454A0 Offset: 0x1D455A1 VA: 0x1D454A0 Slot: 42
	protected virtual void FixedUpdate() { }

	// RVA: 0x1D45650 Offset: 0x1D45751 VA: 0x1D45650 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x1D45770 Offset: 0x1D45871 VA: 0x1D45770 Slot: 43
	public virtual void PlayMotion(string name, float fadeTime = 0) { }

	// RVA: 0x1D457A0 Offset: 0x1D458A1 VA: 0x1D457A0 Slot: 44
	public virtual void RePlayMotion(string name, float fadeTime = 0) { }

	// RVA: 0x1D457E0 Offset: 0x1D458E1 VA: 0x1D457E0
	public void PlayFaceMotion(FaceType faceType) { }

	// RVA: 0x1D458A0 Offset: 0x1D459A1 VA: 0x1D458A0
	public void SetAnimatorParam(string name, int value) { }

	// RVA: 0x1D45B00 Offset: 0x1D45C01 VA: 0x1D45B00
	public void SetAnimatorParam(string name, float value) { }

	// RVA: 0x1D45C30 Offset: 0x1D45D31 VA: 0x1D45C30
	public void SetAnimatorParam(string name, bool value) { }

	// RVA: 0x1D45D50 Offset: 0x1D45E51 VA: 0x1D45D50
	public void SetAnimatorParam(string name) { }

	// RVA: 0x1D45E60 Offset: 0x1D45F61 VA: 0x1D45E60
	public bool TryGetAnimatorParamBool(string name, out bool value) { }

	// RVA: 0x1D45FB0 Offset: 0x1D460B1 VA: 0x1D45FB0
	public bool TryGetAnimatorParamFloat(string name, out float value) { }

	// RVA: 0x1D44B10 Offset: 0x1D44C11 VA: 0x1D44B10
	public bool TryAddHashParam(string name) { }

	// RVA: 0x1D459C0 Offset: 0x1D45AC1 VA: 0x1D459C0
	public int GetAnimatorParamHash(string name) { }

	// RVA: 0x1D46100 Offset: 0x1D46201 VA: 0x1D46100 Slot: 45
	protected virtual void InitAnimator() { }

	// RVA: 0x1D46200 Offset: 0x1D46301 VA: 0x1D46200 Slot: 46
	protected virtual void UpdateLocomotion(float deltaTime) { }

	// RVA: 0x1D46440 Offset: 0x1D46541 VA: 0x1D46440 Slot: 47
	protected virtual void SetLocomotion(float value) { }

	// RVA: 0x1D464B0 Offset: 0x1D465B1 VA: 0x1D464B0 Slot: 48
	protected virtual void OnWince() { }

	// RVA: 0x1D464C0 Offset: 0x1D465C1 VA: 0x1D464C0
	public void SetFreeseXZRootMotionTimer(float time) { }

	// RVA: 0x1D464D0 Offset: 0x1D465D1 VA: 0x1D464D0
	public void StopMove() { }

	// RVA: 0x1D46750 Offset: 0x1D46851 VA: 0x1D46750
	public void AddForce(Vector3 force, ForceMode mode = 0) { }

	// RVA: 0x1D46770 Offset: 0x1D46871 VA: 0x1D46770
	public void ClearForce() { }

	// RVA: 0x1D46550 Offset: 0x1D46651 VA: 0x1D46550
	public void ClearVelocity() { }

	// RVA: 0x1D46890 Offset: 0x1D46991 VA: 0x1D46890
	public void ClearVelocity(CharacterMovement.VelocityType velocityType) { }

	// RVA: 0x1D46950 Offset: 0x1D46A51 VA: 0x1D46950 Slot: 49
	public virtual bool InputMove(Vector3 vector) { }

	// RVA: 0x1D46AC0 Offset: 0x1D46BC1 VA: 0x1D46AC0
	public bool MovePosition(Vector3 vector) { }

	// RVA: 0x1D46BD0 Offset: 0x1D46CD1 VA: 0x1D46BD0
	public bool Rotate(Vector3 vector) { }

	// RVA: 0x1D46CE0 Offset: 0x1D46DE1 VA: 0x1D46CE0 Slot: 50
	protected virtual void ResetMovement() { }

	// RVA: 0x1D46E70 Offset: 0x1D46F71 VA: 0x1D46E70 Slot: 51
	protected virtual void UpdateMove(float deltaTime) { }

	// RVA: 0x1D470E0 Offset: 0x1D471E1 VA: 0x1D470E0
	public void PushPosition(Vector3 pushVector) { }

	// RVA: 0x1D47140 Offset: 0x1D47241 VA: 0x1D47140 Slot: 52
	protected virtual void UpdateRotate(float deltaTime) { }

	// RVA: 0x1D471F0 Offset: 0x1D472F1 VA: 0x1D471F0 Slot: 53
	protected virtual float GetSlowMoveScale() { }

	// RVA: 0x1D474D0 Offset: 0x1D475D1 VA: 0x1D474D0 Slot: 54
	protected virtual float GetMoveSpeedMax() { }

	// RVA: 0x1D47520 Offset: 0x1D47621 VA: 0x1D47520
	protected float GetMoveSpeedMaxEquipAttribute(float speed) { }

	// RVA: 0x1D477A0 Offset: 0x1D478A1 VA: 0x1D477A0 Slot: 55
	protected virtual float GetMoveAcceleration() { }

	// RVA: 0x1D477F0 Offset: 0x1D478F1 VA: 0x1D477F0
	protected float GetMoveAccelerationEquipAttribute(float speed) { }

	// RVA: 0x1D478D0 Offset: 0x1D479D1 VA: 0x1D478D0 Slot: 56
	protected virtual float GetMoveDeceleration() { }

	// RVA: 0x1D47900 Offset: 0x1D47A01 VA: 0x1D47900 Slot: 57
	public virtual float GetRotateSpeed() { }

	// RVA: 0x1D47AE0 Offset: 0x1D47BE1 VA: 0x1D47AE0 Slot: 58
	public virtual void StartBattleMode() { }

	// RVA: 0x1D47AF0 Offset: 0x1D47BF1 VA: 0x1D47AF0 Slot: 59
	public virtual void EndBattleMode() { }

	// RVA: 0x1D47B00 Offset: 0x1D47C01 VA: 0x1D47B00 Slot: 60
	public virtual void ForceEndBattleMode() { }

	// RVA: 0x1D47B10 Offset: 0x1D47C11 VA: 0x1D47B10
	public bool Lockon() { }

	// RVA: 0x1D481C0 Offset: 0x1D482C1 VA: 0x1D481C0
	public void LockonChange(bool checkRight, Action lockonCallback) { }

	// RVA: 0x1D48850 Offset: 0x1D48951 VA: 0x1D48850
	public void ApproachEnemy(float force, CharacterBase target, float angle = 0) { }

	// RVA: 0x1D480B0 Offset: 0x1D481B1 VA: 0x1D480B0
	public void SetLockonTarget(CharacterBase characterBase) { }

	// RVA: 0x1D481B0 Offset: 0x1D482B1 VA: 0x1D481B0
	public void ClearLockonTarget() { }

	// RVA: 0x1D44EC0 Offset: 0x1D44FC1 VA: 0x1D44EC0
	private void UpdateLockon() { }

	// RVA: 0x1D492A0 Offset: 0x1D493A1 VA: 0x1D492A0 Slot: 61
	protected virtual bool CheckEnemySearchList(CharacterBase characterBase) { }

	// RVA: -1 Offset: -1
	protected List<CharacterBase> GetEnemySearchList<T>(float radius) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AA350 Offset: 0x21AA451 VA: 0x21AA350
	|-Character.GetEnemySearchList<CharacterBase>
	|-Character.GetEnemySearchList<MonsterControllerBase>
	|-Character.GetEnemySearchList<object>
	*/

	// RVA: 0x1D49350 Offset: 0x1D49451 VA: 0x1D49350 Slot: 62
	public virtual void SetGrounderIKWeight(float weight) { }

	// RVA: 0x1D49360 Offset: 0x1D49461 VA: 0x1D49360 Slot: 63
	public virtual void SetLookIKWeight(float weight) { }

	// RVA: 0x1D49370 Offset: 0x1D49471 VA: 0x1D49370 Slot: 64
	public virtual void SetNavMeshAgentEnable(bool enable) { }

	// RVA: 0x1D49430 Offset: 0x1D49531 VA: 0x1D49430
	public void SetInvincible(float time) { }

	// RVA: 0x1D494C0 Offset: 0x1D495C1 VA: 0x1D494C0
	public void UpdateInCageWeb() { }

	// RVA: 0x1D49520 Offset: 0x1D49621 VA: 0x1D49520
	public void EndInCageWeb() { }

	// RVA: 0x1D45130 Offset: 0x1D45231 VA: 0x1D45130
	private void UpdateInvincible(float deltaTime) { }

	// RVA: 0x1D49590 Offset: 0x1D49691 VA: 0x1D49590 Slot: 18
	public override void OnSwitchActorBase(bool on) { }

	// RVA: 0x1D49780 Offset: 0x1D49881 VA: 0x1D49780 Slot: 65
	public virtual void OnBadStatus(BadStatus badStatus, bool isEnable) { }

	// RVA: 0x1D49790 Offset: 0x1D49891 VA: 0x1D49790 Slot: 66
	public virtual bool OnBeforeDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x1D497A0 Offset: 0x1D498A1 VA: 0x1D497A0 Slot: 67
	public virtual void OnPlayDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x1D497B0 Offset: 0x1D498B1 VA: 0x1D497B0 Slot: 68
	public virtual void OnStopDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x1D497C0 Offset: 0x1D498C1 VA: 0x1D497C0 Slot: 69
	public virtual void OnAfterDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x1D497D0 Offset: 0x1D498D1 VA: 0x1D497D0 Slot: 70
	public virtual void AddDamagedPost(DamageInfo damageInfo, DamageResult result) { }

	// RVA: 0x1D497E0 Offset: 0x1D498E1 VA: 0x1D497E0 Slot: 71
	public virtual void PlayDamageEffect(DamageInfo damageInfo, DamageResult result) { }

	// RVA: 0x1D497F0 Offset: 0x1D498F1 VA: 0x1D497F0
	public void PlayTakeDamageEffect(DamageInfo damageInfo, DamageResult result) { }

	// RVA: 0x1D49FE0 Offset: 0x1D4A0E1 VA: 0x1D49FE0 Slot: 72
	public virtual void OnLanding() { }

	// RVA: 0x1D4A0A0 Offset: 0x1D4A1A1 VA: 0x1D4A0A0 Slot: 73
	public virtual void OnFalling() { }

	// RVA: 0x1D4A0B0 Offset: 0x1D4A1B1 VA: 0x1D4A0B0 Slot: 74
	public virtual void OnSliding() { }

	// RVA: 0x1D4A0C0 Offset: 0x1D4A1C1 VA: 0x1D4A0C0 Slot: 75
	public virtual void CreateEffectPoint() { }

	// RVA: 0x1D4A0D0 Offset: 0x1D4A1D1 VA: 0x1D4A0D0
	public void .ctor() { }

	// RVA: 0x1D4A200 Offset: 0x1D4A301 VA: 0x1D4A200
	private static void .cctor() { }
}

