[Serializable]
public class HitReaction.HitPointEffector.EffectorLink // TypeDefIndex: 9553
{
	// Fields
	[TooltipAttribute] // RVA: 0x199F20 Offset: 0x19A021 VA: 0x199F20
	public FullBodyBipedEffector effector; // 0x10
	[TooltipAttribute] // RVA: 0x199F60 Offset: 0x19A061 VA: 0x199F60
	public float weight; // 0x14
	private Vector3 lastValue; // 0x18
	private Vector3 current; // 0x24

	// Methods

	// RVA: 0x2B3C6B0 Offset: 0x2B3C7B1 VA: 0x2B3C6B0
	public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader) { }

	// RVA: 0x2B3C490 Offset: 0x2B3C591 VA: 0x2B3C490
	public void CrossFadeStart() { }

	// RVA: 0x2B3C800 Offset: 0x2B3C901 VA: 0x2B3C800
	public void .ctor() { }
}

