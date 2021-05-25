public class LandingMotionObserve : CharaMotionBehaviour // TypeDefIndex: 6551
{
	// Fields
	[SerializeField] // RVA: 0x15D420 Offset: 0x15D521 VA: 0x15D420
	private string m_ParameterName; // 0x28
	[SerializeField] // RVA: 0x15D430 Offset: 0x15D531 VA: 0x15D430
	private float m_SoundPlayThreshold; // 0x30
	[SerializeField] // RVA: 0x15D440 Offset: 0x15D541 VA: 0x15D440
	private float m_EffectPlayThreshold; // 0x34
	[SerializeField] // RVA: 0x15D450 Offset: 0x15D551 VA: 0x15D450
	private float m_MoveNormalizedTime; // 0x38

	// Methods

	// RVA: 0x217FFF0 Offset: 0x21800F1 VA: 0x217FFF0 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x2180170 Offset: 0x2180271 VA: 0x2180170 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x21801A0 Offset: 0x21802A1 VA: 0x21801A0
	private void CheckNormalizeTime(float normalizeTime) { }

	// RVA: 0x2180250 Offset: 0x2180351 VA: 0x2180250
	public void .ctor() { }
}

