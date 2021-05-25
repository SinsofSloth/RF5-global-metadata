[Serializable]
public class Recoil.RecoilOffset // TypeDefIndex: 9577
{
	// Fields
	[TooltipAttribute] // RVA: 0x199350 Offset: 0x199451 VA: 0x199350
	public Vector3 offset; // 0x10
	[TooltipAttribute] // RVA: 0x199390 Offset: 0x199491 VA: 0x199390
	[RangeAttribute] // RVA: 0x199390 Offset: 0x199491 VA: 0x199390
	public float additivity; // 0x1C
	[TooltipAttribute] // RVA: 0x1993F0 Offset: 0x1994F1 VA: 0x1993F0
	public float maxAdditiveOffsetMag; // 0x20
	[TooltipAttribute] // RVA: 0x199430 Offset: 0x199531 VA: 0x199430
	public Recoil.RecoilOffset.EffectorLink[] effectorLinks; // 0x28
	private Vector3 additiveOffset; // 0x30
	private Vector3 lastOffset; // 0x3C

	// Methods

	// RVA: 0x291ED60 Offset: 0x291EE61 VA: 0x291ED60
	public void Start() { }

	// RVA: 0x291FAF0 Offset: 0x291FBF1 VA: 0x291FAF0
	public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft) { }

	// RVA: 0x2920350 Offset: 0x2920451 VA: 0x2920350
	public void .ctor() { }
}

