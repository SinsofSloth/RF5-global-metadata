public class NormalizedTimeObserve : StateMachineBehaviour // TypeDefIndex: 6556
{
	// Fields
	protected float m_currentNormalizedTime; // 0x18
	[SerializeField] // RVA: 0x15D500 Offset: 0x15D601 VA: 0x15D500
	[RangeAttribute] // RVA: 0x15D500 Offset: 0x15D601 VA: 0x15D500
	public float m_eventNormalizedTime; // 0x1C
	[SerializeField] // RVA: 0x15D540 Offset: 0x15D641 VA: 0x15D540
	protected bool m_isExitCall; // 0x20

	// Properties
	protected virtual bool IsUseClamp { get; }

	// Methods

	// RVA: 0x1FB7A10 Offset: 0x1FB7B11 VA: 0x1FB7A10 Slot: 18
	protected virtual bool get_IsUseClamp() { }

	// RVA: 0x1FB7A20 Offset: 0x1FB7B21 VA: 0x1FB7A20 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1FB7A50 Offset: 0x1FB7B51 VA: 0x1FB7A50 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1FB7C50 Offset: 0x1FB7D51 VA: 0x1FB7C50 Slot: 6
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1FB7B00 Offset: 0x1FB7C01 VA: 0x1FB7B00
	protected void CheckNormalizedTime(float motionNormalizedTime, float eventNormalizedTime, Action onEvent) { }

	// RVA: 0x1FB7CF0 Offset: 0x1FB7DF1 VA: 0x1FB7CF0 Slot: 19
	public virtual void DoEvent() { }

	// RVA: 0x1FB7D00 Offset: 0x1FB7E01 VA: 0x1FB7D00
	public void .ctor() { }
}

