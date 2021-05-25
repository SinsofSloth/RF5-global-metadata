public class LookIKWightObserve : CharaMotionBehaviour // TypeDefIndex: 6554
{
	// Fields
	[SerializeField] // RVA: 0x15D4D0 Offset: 0x15D5D1 VA: 0x15D4D0
	private string m_ParamName; // 0x28
	[SerializeField] // RVA: 0x15D4E0 Offset: 0x15D5E1 VA: 0x15D4E0
	private AnimationCurve m_Weight; // 0x30
	private int m_ParamHash; // 0x38

	// Methods

	// RVA: 0x1E09770 Offset: 0x1E09871 VA: 0x1E09770 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1E09920 Offset: 0x1E09A21 VA: 0x1E09920 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1E09850 Offset: 0x1E09951 VA: 0x1E09850
	private void OnUpdateWeight(float locomotion) { }

	// RVA: 0x1E09960 Offset: 0x1E09A61 VA: 0x1E09960
	public void .ctor() { }
}

