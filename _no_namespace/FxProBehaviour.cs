[Serializable]
public class FxProBehaviour : PlayableBehaviour // TypeDefIndex: 8344
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16EF50 Offset: 0x16F051 VA: 0x16EF50
	private FxPro <FxPro>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x16EF60 Offset: 0x16F061 VA: 0x16EF60
	private bool <IsChangeFocusTarget>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16EF70 Offset: 0x16F071 VA: 0x16EF70
	private Transform <FocusTargetStart>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x16EF80 Offset: 0x16F081 VA: 0x16EF80
	private Transform <FocusTargetEnd>k__BackingField; // 0x28
	[RangeAttribute] // RVA: 0x16EF90 Offset: 0x16F091 VA: 0x16EF90
	public float FocalLengthMultiplierStart; // 0x30
	[RangeAttribute] // RVA: 0x16EFB0 Offset: 0x16F0B1 VA: 0x16EFB0
	public float FocalLengthMultiplierEnd; // 0x34
	public AnimationCurve FocalLengthMultiplierCurve; // 0x38
	[RangeAttribute] // RVA: 0x16EFD0 Offset: 0x16F0D1 VA: 0x16EFD0
	public float DOFStrengthStart; // 0x40
	[RangeAttribute] // RVA: 0x16EFF0 Offset: 0x16F0F1 VA: 0x16EFF0
	public float DOFStrengthEnd; // 0x44
	public AnimationCurve DOFStrengthCurve; // 0x48

	// Properties
	public FxPro FxPro { get; set; }
	public bool IsChangeFocusTarget { get; set; }
	public Transform FocusTargetStart { get; set; }
	public Transform FocusTargetEnd { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6FA0 Offset: 0x1A70A1 VA: 0x1A6FA0
	// RVA: 0x22A0340 Offset: 0x22A0441 VA: 0x22A0340
	public FxPro get_FxPro() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6FB0 Offset: 0x1A70B1 VA: 0x1A6FB0
	// RVA: 0x22A0350 Offset: 0x22A0451 VA: 0x22A0350
	public void set_FxPro(FxPro value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6FC0 Offset: 0x1A70C1 VA: 0x1A6FC0
	// RVA: 0x22A0360 Offset: 0x22A0461 VA: 0x22A0360
	public bool get_IsChangeFocusTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6FD0 Offset: 0x1A70D1 VA: 0x1A6FD0
	// RVA: 0x22A0370 Offset: 0x22A0471 VA: 0x22A0370
	public void set_IsChangeFocusTarget(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6FE0 Offset: 0x1A70E1 VA: 0x1A6FE0
	// RVA: 0x22A0380 Offset: 0x22A0481 VA: 0x22A0380
	public Transform get_FocusTargetStart() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6FF0 Offset: 0x1A70F1 VA: 0x1A6FF0
	// RVA: 0x22A0390 Offset: 0x22A0491 VA: 0x22A0390
	public void set_FocusTargetStart(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7000 Offset: 0x1A7101 VA: 0x1A7000
	// RVA: 0x22A03A0 Offset: 0x22A04A1 VA: 0x22A03A0
	public Transform get_FocusTargetEnd() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7010 Offset: 0x1A7111 VA: 0x1A7010
	// RVA: 0x22A03B0 Offset: 0x22A04B1 VA: 0x22A03B0
	public void set_FocusTargetEnd(Transform value) { }

	// RVA: 0x22A03C0 Offset: 0x22A04C1 VA: 0x22A03C0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x22A0400 Offset: 0x22A0501 VA: 0x22A0400 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x22A0440 Offset: 0x22A0541 VA: 0x22A0440
	public void .ctor() { }
}

