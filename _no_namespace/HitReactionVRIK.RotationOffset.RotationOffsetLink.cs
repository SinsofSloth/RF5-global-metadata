[Serializable]
public class HitReactionVRIK.RotationOffset.RotationOffsetLink // TypeDefIndex: 9561
{
	// Fields
	[TooltipAttribute] // RVA: 0x19A0C0 Offset: 0x19A1C1 VA: 0x19A0C0
	public IKSolverVR.RotationOffset rotationOffset; // 0x10
	[TooltipAttribute] // RVA: 0x19A100 Offset: 0x19A201 VA: 0x19A100
	[RangeAttribute] // RVA: 0x19A100 Offset: 0x19A201 VA: 0x19A100
	public float weight; // 0x14
	private Quaternion lastValue; // 0x18
	private Quaternion current; // 0x28

	// Methods

	// RVA: 0x2B3D930 Offset: 0x2B3DA31 VA: 0x2B3D930
	public void Apply(VRIK ik, Quaternion offset, float crossFader) { }

	// RVA: 0x2B3D5F0 Offset: 0x2B3D6F1 VA: 0x2B3D5F0
	public void CrossFadeStart() { }

	// RVA: 0x2B3DA80 Offset: 0x2B3DB81 VA: 0x2B3DA80
	public void .ctor() { }
}

