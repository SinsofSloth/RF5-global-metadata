public class PlaySEObserve : NormalizedTimeObserve // TypeDefIndex: 6559
{
	// Fields
	public SoundID SoundID; // 0x24
	private Animator Animator; // 0x28
	public string ParameterNameFloat; // 0x30
	public float ParamMinFloat; // 0x38
	public float ParamMaxFloat; // 0x3C
	public bool IsRepeat; // 0x40
	public string TargetTransformName; // 0x48
	private Transform TargetTransform; // 0x50

	// Properties
	protected override bool IsUseClamp { get; }

	// Methods

	// RVA: 0x1FE7C10 Offset: 0x1FE7D11 VA: 0x1FE7C10 Slot: 18
	protected override bool get_IsUseClamp() { }

	// RVA: 0x1FE7C20 Offset: 0x1FE7D21 VA: 0x1FE7C20 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1FE7DE0 Offset: 0x1FE7EE1 VA: 0x1FE7DE0 Slot: 19
	public override void DoEvent() { }

	// RVA: 0x1FE7EA0 Offset: 0x1FE7FA1 VA: 0x1FE7EA0
	public void .ctor() { }
}

