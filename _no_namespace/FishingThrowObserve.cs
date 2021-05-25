public class FishingThrowObserve : CharaMotionBehaviour // TypeDefIndex: 6540
{
	// Fields
	protected float m_currentNormalizedTime; // 0x28
	[SerializeField] // RVA: 0x15D3B0 Offset: 0x15D4B1 VA: 0x15D3B0
	[RangeAttribute] // RVA: 0x15D3B0 Offset: 0x15D4B1 VA: 0x15D3B0
	public float m_eventNormalizedTime; // 0x2C

	// Methods

	// RVA: 0x1D4FAE0 Offset: 0x1D4FBE1 VA: 0x1D4FAE0 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1D4FB10 Offset: 0x1D4FC11 VA: 0x1D4FB10 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1D4FBC0 Offset: 0x1D4FCC1 VA: 0x1D4FBC0
	protected void CheckNormalizedTime(float motionNormalizedTime, float eventNormalizedTime, Action onEvent) { }

	// RVA: 0x1D4FCC0 Offset: 0x1D4FDC1 VA: 0x1D4FCC0 Slot: 18
	public virtual void DoEvent() { }

	// RVA: 0x1D4FD90 Offset: 0x1D4FE91 VA: 0x1D4FD90
	public void .ctor() { }
}

