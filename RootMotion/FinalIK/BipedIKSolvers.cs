[Serializable]
public class BipedIKSolvers // TypeDefIndex: 9413
{
	// Fields
	public IKSolverLimb leftFoot; // 0x10
	public IKSolverLimb rightFoot; // 0x18
	public IKSolverLimb leftHand; // 0x20
	public IKSolverLimb rightHand; // 0x28
	public IKSolverFABRIK spine; // 0x30
	public IKSolverLookAt lookAt; // 0x38
	public IKSolverAim aim; // 0x40
	public Constraints pelvis; // 0x48
	private IKSolverLimb[] _limbs; // 0x50
	private IKSolver[] _ikSolvers; // 0x58

	// Properties
	public IKSolverLimb[] limbs { get; }
	public IKSolver[] ikSolvers { get; }

	// Methods

	// RVA: 0x2735380 Offset: 0x2735481 VA: 0x2735380
	public IKSolverLimb[] get_limbs() { }

	// RVA: 0x2736130 Offset: 0x2736231 VA: 0x2736130
	public IKSolver[] get_ikSolvers() { }

	// RVA: 0x27357D0 Offset: 0x27358D1 VA: 0x27357D0
	public void AssignReferences(BipedReferences references) { }

	// RVA: 0x2735F80 Offset: 0x2736081 VA: 0x2735F80
	public void .ctor() { }
}

