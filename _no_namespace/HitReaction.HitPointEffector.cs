[Serializable]
public class HitReaction.HitPointEffector : HitReaction.HitPoint // TypeDefIndex: 9552
{
	// Fields
	[TooltipAttribute] // RVA: 0x198980 Offset: 0x198A81 VA: 0x198980
	public AnimationCurve offsetInForceDirection; // 0x50
	[TooltipAttribute] // RVA: 0x1989C0 Offset: 0x198AC1 VA: 0x1989C0
	public AnimationCurve offsetInUpDirection; // 0x58
	[TooltipAttribute] // RVA: 0x198A00 Offset: 0x198B01 VA: 0x198A00
	public HitReaction.HitPointEffector.EffectorLink[] effectorLinks; // 0x60

	// Methods

	// RVA: 0x2B3C2A0 Offset: 0x2B3C3A1 VA: 0x2B3C2A0 Slot: 4
	protected override float GetLength() { }

	// RVA: 0x2B3C420 Offset: 0x2B3C521 VA: 0x2B3C420 Slot: 5
	protected override void CrossFadeStart() { }

	// RVA: 0x2B3C4B0 Offset: 0x2B3C5B1 VA: 0x2B3C4B0 Slot: 6
	protected override void OnApply(IKSolverFullBodyBiped solver, float weight) { }

	// RVA: 0x2B3C7E0 Offset: 0x2B3C8E1 VA: 0x2B3C7E0
	public void .ctor() { }
}

