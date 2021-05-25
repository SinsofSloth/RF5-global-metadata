public class CharacterAnimationMonitor : CharaMotionBehaviour // TypeDefIndex: 6520
{
	// Fields
	public CharacterAnimationParam param; // 0x28
	public bool m_StopMove; // 0x30
	public FaceType m_FaceType; // 0x34
	private float m_Deltatime; // 0x38
	private HitSystem m_HitSystem; // 0x40
	public bool m_enablePersonalMotion; // 0x48
	public bool m_enableEnemyCollision; // 0x49
	public bool m_ignoreShieldVisible; // 0x4A
	public bool m_IsAutoRPHeal; // 0x4B
	[RangeAttribute] // RVA: 0x15D1D0 Offset: 0x15D2D1 VA: 0x15D1D0
	public float m_AutoRPHeal_Delta; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x15D1F0 Offset: 0x15D2F1 VA: 0x15D1F0
	private PlayerStatus <m_PlayerStatus>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x15D200 Offset: 0x15D301 VA: 0x15D200
	private float <m_Elapsed>k__BackingField; // 0x58

	// Properties
	private PlayerStatus m_PlayerStatus { get; set; }
	private float m_Elapsed { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B670 Offset: 0x19B771 VA: 0x19B670
	// RVA: 0x1E4C1F0 Offset: 0x1E4C2F1 VA: 0x1E4C1F0
	private PlayerStatus get_m_PlayerStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B680 Offset: 0x19B781 VA: 0x19B680
	// RVA: 0x1E4C200 Offset: 0x1E4C301 VA: 0x1E4C200
	private void set_m_PlayerStatus(PlayerStatus value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B690 Offset: 0x19B791 VA: 0x19B690
	// RVA: 0x1E4C210 Offset: 0x1E4C311 VA: 0x1E4C210
	private float get_m_Elapsed() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B6A0 Offset: 0x19B7A1 VA: 0x19B6A0
	// RVA: 0x1E4C220 Offset: 0x1E4C321 VA: 0x1E4C220
	private void set_m_Elapsed(float value) { }

	// RVA: 0x1E4C230 Offset: 0x1E4C331 VA: 0x1E4C230 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1E4CBD0 Offset: 0x1E4CCD1 VA: 0x1E4CBD0 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1E4CE70 Offset: 0x1E4CF71 VA: 0x1E4CE70
	public void .ctor() { }
}

