[Serializable]
public class HitReactionVRIK.PositionOffset.PositionOffsetLink // TypeDefIndex: 9559
{
	// Fields
	[TooltipAttribute] // RVA: 0x19A040 Offset: 0x19A141 VA: 0x19A040
	public IKSolverVR.PositionOffset positionOffset; // 0x10
	[TooltipAttribute] // RVA: 0x19A080 Offset: 0x19A181 VA: 0x19A080
	public float weight; // 0x14
	private Vector3 lastValue; // 0x18
	private Vector3 current; // 0x24

	// Methods

	// RVA: 0x2B3D360 Offset: 0x2B3D461 VA: 0x2B3D360
	public void Apply(VRIK ik, Vector3 offset, float crossFader) { }

	// RVA: 0x2B3D110 Offset: 0x2B3D211 VA: 0x2B3D110
	public void CrossFadeStart() { }

	// RVA: 0x2B3D480 Offset: 0x2B3D581 VA: 0x2B3D480
	public void .ctor() { }
}

