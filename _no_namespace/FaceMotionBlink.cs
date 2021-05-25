public class FaceMotionBlink : StateMachineBehaviour // TypeDefIndex: 6538
{
	// Fields
	[SerializeField] // RVA: 0x15D360 Offset: 0x15D461 VA: 0x15D360
	private float m_MinTime; // 0x18
	[SerializeField] // RVA: 0x15D370 Offset: 0x15D471 VA: 0x15D370
	private float m_MaxTime; // 0x1C
	[SerializeField] // RVA: 0x15D380 Offset: 0x15D481 VA: 0x15D380
	private string m_StateName; // 0x20
	private float m_Elapsed; // 0x28
	private float m_NextTime; // 0x2C

	// Methods

	// RVA: 0x207D1A0 Offset: 0x207D2A1 VA: 0x207D1A0 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x207D1D0 Offset: 0x207D2D1 VA: 0x207D1D0 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x207D240 Offset: 0x207D341 VA: 0x207D240
	public void .ctor() { }
}

