[Serializable]
public class IKSolverFABRIK : IKSolverHeuristic // TypeDefIndex: 9480
{
	// Fields
	public IKSolver.IterationDelegate OnPreIteration; // 0x88
	private bool[] limitedBones; // 0x90
	private Vector3[] solverLocalPositions; // 0x98

	// Properties
	protected override bool boneLengthCanBeZero { get; }

	// Methods

	// RVA: 0x2585AC0 Offset: 0x2585BC1 VA: 0x2585AC0
	public void SolveForward(Vector3 position) { }

	// RVA: 0x2586230 Offset: 0x2586331 VA: 0x2586230
	public void SolveBackward(Vector3 position) { }

	// RVA: 0x25863C0 Offset: 0x25864C1 VA: 0x25863C0 Slot: 5
	public override Vector3 GetIKPosition() { }

	// RVA: 0x2586460 Offset: 0x2586561 VA: 0x2586460 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x2586A40 Offset: 0x2586B41 VA: 0x2586A40 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2586DE0 Offset: 0x2586EE1 VA: 0x2586DE0 Slot: 13
	protected override bool get_boneLengthCanBeZero() { }

	// RVA: 0x2586DF0 Offset: 0x2586EF1 VA: 0x2586DF0
	private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length) { }

	// RVA: 0x2585BA0 Offset: 0x2585CA1 VA: 0x2585BA0
	private void OnPreSolve() { }

	// RVA: 0x2586360 Offset: 0x2586461 VA: 0x2586360
	private void OnPostSolve() { }

	// RVA: 0x2586D60 Offset: 0x2586E61 VA: 0x2586D60
	private void Solve(Vector3 targetPosition) { }

	// RVA: 0x2586050 Offset: 0x2586151 VA: 0x2586050
	private void ForwardReach(Vector3 position) { }

	// RVA: 0x2587660 Offset: 0x2587761 VA: 0x2587660
	private void SolverMove(int index, Vector3 offset) { }

	// RVA: 0x2587770 Offset: 0x2587871 VA: 0x2587770
	private void SolverRotate(int index, Quaternion rotation, bool recursive) { }

	// RVA: 0x2587900 Offset: 0x2587A01 VA: 0x2587900
	private void SolverRotateChildren(int index, Quaternion rotation) { }

	// RVA: 0x2587A20 Offset: 0x2587B21 VA: 0x2587A20
	private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation) { }

	// RVA: 0x2586780 Offset: 0x2586881 VA: 0x2586780
	private Quaternion GetParentSolverRotation(int index) { }

	// RVA: 0x25868E0 Offset: 0x25869E1 VA: 0x25868E0
	private Vector3 GetParentSolverPosition(int index) { }

	// RVA: 0x2587C10 Offset: 0x2587D11 VA: 0x2587C10
	private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed) { }

	// RVA: 0x25870D0 Offset: 0x25871D1 VA: 0x25870D0
	private void LimitForward(int rotateBone, int limitBone) { }

	// RVA: 0x2586350 Offset: 0x2586451 VA: 0x2586350
	private void BackwardReach(Vector3 position) { }

	// RVA: 0x2588380 Offset: 0x2588481 VA: 0x2588380
	private void BackwardReachUnlimited(Vector3 position) { }

	// RVA: 0x2587DF0 Offset: 0x2587EF1 VA: 0x2587DF0
	private void BackwardReachLimited(Vector3 position) { }

	// RVA: 0x2586F10 Offset: 0x2587011 VA: 0x2586F10
	private void MapToSolverPositions() { }

	// RVA: 0x2587000 Offset: 0x2587101 VA: 0x2587000
	private void MapToSolverPositionsLimited() { }

	// RVA: 0x2588450 Offset: 0x2588551 VA: 0x2588450
	public void .ctor() { }
}

