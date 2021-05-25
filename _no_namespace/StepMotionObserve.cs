public class StepMotionObserve : CharaMotionBehaviour // TypeDefIndex: 6562
{
	// Fields
	public StepEventSetting[] m_WalkStepEvents; // 0x28
	[SerializeField] // RVA: 0x15D5C0 Offset: 0x15D6C1 VA: 0x15D5C0
	public StepEventSetting[] m_StepEvents; // 0x30
	[SerializeField] // RVA: 0x15D5D0 Offset: 0x15D6D1 VA: 0x15D5D0
	private string m_ParameterName; // 0x38
	[SerializeField] // RVA: 0x15D5E0 Offset: 0x15D6E1 VA: 0x15D5E0
	private float m_Threshold; // 0x40
	private float m_NormalizedTime; // 0x44

	// Methods

	// RVA: 0x224D5E0 Offset: 0x224D6E1 VA: 0x224D5E0 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x224D990 Offset: 0x224DA91 VA: 0x224D990 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x224D720 Offset: 0x224D821 VA: 0x224D720
	private void CheckNormalizeTime(float normalizeTime, float locomotion) { }

	// RVA: 0x224DA30 Offset: 0x224DB31 VA: 0x224DA30
	public void .ctor() { }
}

