public class ArmIKBlender : CharaMotionBehaviour // TypeDefIndex: 6517
{
	// Fields
	[SerializeField] // RVA: 0x15D160 Offset: 0x15D261 VA: 0x15D160
	private bool isLeftArmIK; // 0x28
	[SerializeField] // RVA: 0x15D170 Offset: 0x15D271 VA: 0x15D170
	private bool isRightArmIK; // 0x29
	[SerializeField] // RVA: 0x15D180 Offset: 0x15D281 VA: 0x15D180
	private string blendParamName; // 0x30
	[SerializeField] // RVA: 0x15D190 Offset: 0x15D291 VA: 0x15D190
	private AnimationCurve weightCurve; // 0x38
	private int hashBlendParam; // 0x40

	// Methods

	// RVA: 0x2287740 Offset: 0x2287841 VA: 0x2287740
	private void Awake() { }

	// RVA: 0x2287770 Offset: 0x2287871 VA: 0x2287770 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x2287910 Offset: 0x2287A11 VA: 0x2287910 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x2287830 Offset: 0x2287931 VA: 0x2287830
	private void OvserveBlendParamater(Animator animator) { }

	// RVA: 0x2287920 Offset: 0x2287A21 VA: 0x2287920
	public void .ctor() { }
}

