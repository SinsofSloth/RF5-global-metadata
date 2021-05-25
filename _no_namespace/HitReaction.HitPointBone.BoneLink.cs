[Serializable]
public class HitReaction.HitPointBone.BoneLink // TypeDefIndex: 9555
{
	// Fields
	[TooltipAttribute] // RVA: 0x199FA0 Offset: 0x19A0A1 VA: 0x199FA0
	public Transform bone; // 0x10
	[TooltipAttribute] // RVA: 0x199FE0 Offset: 0x19A0E1 VA: 0x199FE0
	[RangeAttribute] // RVA: 0x199FE0 Offset: 0x19A0E1 VA: 0x199FE0
	public float weight; // 0x18
	private Quaternion lastValue; // 0x1C
	private Quaternion current; // 0x2C

	// Methods

	// RVA: 0x2B3C070 Offset: 0x2B3C171 VA: 0x2B3C070
	public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader) { }

	// RVA: 0x2B3BDE0 Offset: 0x2B3BEE1 VA: 0x2B3BDE0
	public void CrossFadeStart() { }

	// RVA: 0x2B3C200 Offset: 0x2B3C301 VA: 0x2B3C200
	public void .ctor() { }
}

