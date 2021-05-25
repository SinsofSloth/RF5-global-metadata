public class CharacterMotionQueue : CharaMotionBehaviour // TypeDefIndex: 6532
{
	// Fields
	[SerializeField] // RVA: 0x15D320 Offset: 0x15D421 VA: 0x15D320
	private string m_QueueMotionName; // 0x28
	[SerializeField] // RVA: 0x15D330 Offset: 0x15D431 VA: 0x15D330
	private float m_CrossFadeTime; // 0x30
	private bool m_IsQueued; // 0x34

	// Methods

	// RVA: 0x1E4F770 Offset: 0x1E4F871 VA: 0x1E4F770 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1E4F830 Offset: 0x1E4F931 VA: 0x1E4F830 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1E4F930 Offset: 0x1E4FA31 VA: 0x1E4F930
	public void .ctor() { }
}

