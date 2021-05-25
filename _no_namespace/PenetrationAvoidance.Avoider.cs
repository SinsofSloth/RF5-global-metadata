[Serializable]
public class PenetrationAvoidance.Avoider // TypeDefIndex: 9574
{
	// Fields
	[TooltipAttribute] // RVA: 0x199170 Offset: 0x199271 VA: 0x199170
	public Transform[] raycastFrom; // 0x10
	[TooltipAttribute] // RVA: 0x1991B0 Offset: 0x1992B1 VA: 0x1991B0
	public Transform raycastTo; // 0x18
	[TooltipAttribute] // RVA: 0x1991F0 Offset: 0x1992F1 VA: 0x1991F0
	[RangeAttribute] // RVA: 0x1991F0 Offset: 0x1992F1 VA: 0x1991F0
	public float raycastRadius; // 0x20
	[TooltipAttribute] // RVA: 0x199250 Offset: 0x199351 VA: 0x199250
	public PenetrationAvoidance.Avoider.EffectorLink[] effectors; // 0x28
	[TooltipAttribute] // RVA: 0x199290 Offset: 0x199391 VA: 0x199290
	public float smoothTimeIn; // 0x30
	[TooltipAttribute] // RVA: 0x1992D0 Offset: 0x1993D1 VA: 0x1992D0
	public float smoothTimeOut; // 0x34
	[TooltipAttribute] // RVA: 0x199310 Offset: 0x199411 VA: 0x199310
	public LayerMask layers; // 0x38
	private Vector3 offset; // 0x3C
	private Vector3 offsetTarget; // 0x48
	private Vector3 offsetV; // 0x54

	// Methods

	// RVA: 0x291C620 Offset: 0x291C721 VA: 0x291C620
	public void Solve(IKSolverFullBodyBiped solver, float weight) { }

	// RVA: 0x291C850 Offset: 0x291C951 VA: 0x291C850
	private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver) { }

	// RVA: 0x291C9F0 Offset: 0x291CAF1 VA: 0x291C9F0
	private Vector3 Raycast(Vector3 from, Vector3 to) { }

	// RVA: 0x291CC60 Offset: 0x291CD61 VA: 0x291CC60
	public void .ctor() { }
}

