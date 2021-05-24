[HelpURLAttribute] // RVA: 0x148E00 Offset: 0x148F01 VA: 0x148E00
[AddComponentMenu] // RVA: 0x148E00 Offset: 0x148F01 VA: 0x148E00
public class RotationLimitSpline : RotationLimit // TypeDefIndex: 9540
{
	// Fields
	[RangeAttribute] // RVA: 0x17C1A0 Offset: 0x17C2A1 VA: 0x17C1A0
	public float twistLimit; // 0x38
	[SerializeField] // RVA: 0x17C1C0 Offset: 0x17C2C1 VA: 0x17C1C0
	[HideInInspector] // RVA: 0x17C1C0 Offset: 0x17C2C1 VA: 0x17C1C0
	public AnimationCurve spline; // 0x40

	// Methods

	[ContextMenu] // RVA: 0x1AC0A0 Offset: 0x1AC1A1 VA: 0x1AC0A0
	// RVA: 0x2923A20 Offset: 0x2923B21 VA: 0x2923A20
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x1AC0E0 Offset: 0x1AC1E1 VA: 0x1AC0E0
	// RVA: 0x2923A70 Offset: 0x2923B71 VA: 0x2923A70
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x1AC120 Offset: 0x1AC221 VA: 0x1AC120
	// RVA: 0x2923AC0 Offset: 0x2923BC1 VA: 0x2923AC0
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x1AC160 Offset: 0x1AC261 VA: 0x1AC160
	// RVA: 0x2923B10 Offset: 0x2923C11 VA: 0x2923B10
	private void ASThread() { }

	// RVA: 0x2923B60 Offset: 0x2923C61 VA: 0x2923B60
	public void SetSpline(Keyframe[] keyframes) { }

	// RVA: 0x2923B80 Offset: 0x2923C81 VA: 0x2923B80 Slot: 4
	protected override Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x2923C40 Offset: 0x2923D41 VA: 0x2923C40
	public Quaternion LimitSwing(Quaternion rotation) { }

	// RVA: 0x2923F70 Offset: 0x2924071 VA: 0x2923F70
	public void .ctor() { }
}

