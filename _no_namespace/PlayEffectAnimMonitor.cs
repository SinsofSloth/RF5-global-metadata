public class PlayEffectAnimMonitor : StateMachineBehaviour // TypeDefIndex: 6343
{
	// Fields
	public bool m_RightHand; // 0x18
	public bool m_LeftHand; // 0x19
	public float m_offsetX; // 0x1C
	public float m_offsetY; // 0x20
	public float m_offsetZ; // 0x24
	public float m_Scale; // 0x28
	public float m_DispTime; // 0x2C
	public float m_Wait; // 0x30
	public EffectID m_EffectID; // 0x34
	public SoundID m_SoundID; // 0x38
	private Animator m_Animator; // 0x40
	private bool IsCalled; // 0x48
	private float WaitNormalizedTime; // 0x4C

	// Methods

	// RVA: 0x1FE7700 Offset: 0x1FE7801 VA: 0x1FE7700 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1FE7720 Offset: 0x1FE7821 VA: 0x1FE7720 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1FE77B0 Offset: 0x1FE78B1 VA: 0x1FE77B0
	public void PlayAnimEffect() { }

	// RVA: 0x1FE7BF0 Offset: 0x1FE7CF1 VA: 0x1FE7BF0
	public void .ctor() { }
}

