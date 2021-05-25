[Serializable]
public class FBIKChain // TypeDefIndex: 9460
{
	// Fields
	[RangeAttribute] // RVA: 0x17AE50 Offset: 0x17AF51 VA: 0x17AE50
	public float pin; // 0x10
	[RangeAttribute] // RVA: 0x17AE70 Offset: 0x17AF71 VA: 0x17AE70
	public float pull; // 0x14
	[RangeAttribute] // RVA: 0x17AE90 Offset: 0x17AF91 VA: 0x17AE90
	public float push; // 0x18
	[RangeAttribute] // RVA: 0x17AEB0 Offset: 0x17AFB1 VA: 0x17AEB0
	public float pushParent; // 0x1C
	[RangeAttribute] // RVA: 0x17AED0 Offset: 0x17AFD1 VA: 0x17AED0
	public float reach; // 0x20
	public FBIKChain.Smoothing reachSmoothing; // 0x24
	public FBIKChain.Smoothing pushSmoothing; // 0x28
	public IKSolver.Node[] nodes; // 0x30
	public int[] children; // 0x38
	public FBIKChain.ChildConstraint[] childConstraints; // 0x40
	public IKConstraintBend bendConstraint; // 0x48
	private float rootLength; // 0x50
	private bool initiated; // 0x54
	private float length; // 0x58
	private float distance; // 0x5C
	private IKSolver.Point p; // 0x60
	private float reachForce; // 0x68
	private float pullParentSum; // 0x6C
	private float[] crossFades; // 0x70
	private float sqrMag1; // 0x78
	private float sqrMag2; // 0x7C
	private float sqrMagDif; // 0x80
	private const float maxLimbLength = 0.99999;

	// Methods

	// RVA: 0x2B294C0 Offset: 0x2B295C1 VA: 0x2B294C0
	public void .ctor() { }

	// RVA: 0x2B296C0 Offset: 0x2B297C1 VA: 0x2B296C0
	public void .ctor(float pin, float pull, Transform[] nodeTransforms) { }

	// RVA: 0x2B29880 Offset: 0x2B29981 VA: 0x2B29880
	public void SetNodes(Transform[] boneTransforms) { }

	// RVA: 0x2B299C0 Offset: 0x2B29AC1 VA: 0x2B299C0
	public int GetNodeIndex(Transform boneTransform) { }

	// RVA: 0x2B29AA0 Offset: 0x2B29BA1 VA: 0x2B29AA0
	public bool IsValid(ref string message) { }

	// RVA: 0x2B29BB0 Offset: 0x2B29CB1 VA: 0x2B29BB0
	public void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x2B2A6B0 Offset: 0x2B2A7B1 VA: 0x2B2A6B0
	public void ReadPose(IKSolverFullBody solver, bool fullBody) { }

	// RVA: 0x2B29DB0 Offset: 0x2B29EB1 VA: 0x2B29DB0
	private void CalculateBoneLengths(IKSolverFullBody solver) { }

	// RVA: 0x2B2AE00 Offset: 0x2B2AF01 VA: 0x2B2AE00
	public void Reach(IKSolverFullBody solver) { }

	// RVA: 0x2B2B1B0 Offset: 0x2B2B2B1 VA: 0x2B2B1B0
	public Vector3 Push(IKSolverFullBody solver) { }

	// RVA: 0x2B2B5A0 Offset: 0x2B2B6A1 VA: 0x2B2B5A0
	public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = False) { }

	// RVA: 0x2B2C150 Offset: 0x2B2C251 VA: 0x2B2C150
	public void Stage1(IKSolverFullBody solver) { }

	// RVA: 0x2B2C770 Offset: 0x2B2C871 VA: 0x2B2C770
	public void Stage2(IKSolverFullBody solver, Vector3 position) { }

	// RVA: 0x2B2CA00 Offset: 0x2B2CB01 VA: 0x2B2CA00
	public void SolveConstraintSystems(IKSolverFullBody solver) { }

	// RVA: 0x2B2C660 Offset: 0x2B2C761 VA: 0x2B2C660
	private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) { }

	// RVA: 0x2B2BF20 Offset: 0x2B2C021 VA: 0x2B2BF20
	protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude) { }

	// RVA: 0x2B2C5E0 Offset: 0x2B2C6E1 VA: 0x2B2C5E0
	private void SolveChildConstraints(IKSolverFullBody solver) { }

	// RVA: 0x2B2CB40 Offset: 0x2B2CC41 VA: 0x2B2CB40
	private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance) { }

	// RVA: 0x2B2C500 Offset: 0x2B2C601 VA: 0x2B2C500
	public void ForwardReach(Vector3 position) { }

	// RVA: 0x2B2C8F0 Offset: 0x2B2C9F1 VA: 0x2B2C8F0
	private void BackwardReach(Vector3 position) { }
}

