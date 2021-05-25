[Serializable]
public class FBIKChain.ChildConstraint // TypeDefIndex: 9461
{
	// Fields
	public float pushElasticity; // 0x10
	public float pullElasticity; // 0x14
	[SerializeField] // RVA: 0x196770 Offset: 0x196871 VA: 0x196770
	private Transform bone1; // 0x18
	[SerializeField] // RVA: 0x196780 Offset: 0x196881 VA: 0x196780
	private Transform bone2; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x196790 Offset: 0x196891 VA: 0x196790
	private float <nominalDistance>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1967A0 Offset: 0x1968A1 VA: 0x1967A0
	private bool <isRigid>k__BackingField; // 0x2C
	private float crossFade; // 0x30
	private float inverseCrossFade; // 0x34
	private int chain1Index; // 0x38
	private int chain2Index; // 0x3C

	// Properties
	public float nominalDistance { get; set; }
	public bool isRigid { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1B54E0 Offset: 0x1B55E1 VA: 0x1B54E0
	// RVA: 0x2B2D030 Offset: 0x2B2D131 VA: 0x2B2D030
	public float get_nominalDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B54F0 Offset: 0x1B55F1 VA: 0x1B54F0
	// RVA: 0x2B2D040 Offset: 0x2B2D141 VA: 0x2B2D040
	private void set_nominalDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5500 Offset: 0x1B5601 VA: 0x1B5500
	// RVA: 0x2B2D050 Offset: 0x2B2D151 VA: 0x2B2D050
	public bool get_isRigid() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5510 Offset: 0x1B5611 VA: 0x1B5510
	// RVA: 0x2B2D060 Offset: 0x2B2D161 VA: 0x2B2D060
	private void set_isRigid(bool value) { }

	// RVA: 0x2B2D070 Offset: 0x2B2D171 VA: 0x2B2D070
	public void .ctor(Transform bone1, Transform bone2, float pushElasticity = 0, float pullElasticity = 0) { }

	// RVA: 0x2B2A350 Offset: 0x2B2A451 VA: 0x2B2A350
	public void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x2B2ABF0 Offset: 0x2B2ACF1 VA: 0x2B2ABF0
	public void OnPreSolve(IKSolverFullBody solver) { }

	// RVA: 0x2B2CD20 Offset: 0x2B2CE21 VA: 0x2B2CD20
	public void Solve(IKSolverFullBody solver) { }
}

