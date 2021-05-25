[Serializable]
public class HitReaction.HitPointBone : HitReaction.HitPoint // TypeDefIndex: 9554
{
	// Fields
	[TooltipAttribute] // RVA: 0x198A40 Offset: 0x198B41 VA: 0x198A40
	public AnimationCurve aroundCenterOfMass; // 0x50
	[TooltipAttribute] // RVA: 0x198A80 Offset: 0x198B81 VA: 0x198A80
	public HitReaction.HitPointBone.BoneLink[] boneLinks; // 0x58
	private Rigidbody rigidbody; // 0x60

	// Methods

	// RVA: 0x2B3BCD0 Offset: 0x2B3BDD1 VA: 0x2B3BCD0 Slot: 4
	protected override float GetLength() { }

	// RVA: 0x2B3BD70 Offset: 0x2B3BE71 VA: 0x2B3BD70 Slot: 5
	protected override void CrossFadeStart() { }

	// RVA: 0x2B3BE00 Offset: 0x2B3BF01 VA: 0x2B3BE00 Slot: 6
	protected override void OnApply(IKSolverFullBodyBiped solver, float weight) { }

	// RVA: 0x2B3C1E0 Offset: 0x2B3C2E1 VA: 0x2B3C1E0
	public void .ctor() { }
}

