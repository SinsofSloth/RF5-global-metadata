[Serializable]
public class IKMapping.BoneMap // TypeDefIndex: 9466
{
	// Fields
	public Transform transform; // 0x10
	public int chainIndex; // 0x18
	public int nodeIndex; // 0x1C
	public Vector3 defaultLocalPosition; // 0x20
	public Quaternion defaultLocalRotation; // 0x2C
	public Vector3 localSwingAxis; // 0x3C
	public Vector3 localTwistAxis; // 0x48
	public Vector3 planePosition; // 0x54
	public Vector3 ikPosition; // 0x60
	public Quaternion defaultLocalTargetRotation; // 0x6C
	private Quaternion maintainRotation; // 0x7C
	public float length; // 0x8C
	public Quaternion animatedRotation; // 0x90
	private Transform planeBone1; // 0xA0
	private Transform planeBone2; // 0xA8
	private Transform planeBone3; // 0xB0
	private int plane1ChainIndex; // 0xB8
	private int plane1NodeIndex; // 0xBC
	private int plane2ChainIndex; // 0xC0
	private int plane2NodeIndex; // 0xC4
	private int plane3ChainIndex; // 0xC8
	private int plane3NodeIndex; // 0xCC

	// Properties
	public Vector3 swingDirection { get; }
	public bool isNodeBone { get; }
	private Quaternion lastAnimatedTargetRotation { get; }

	// Methods

	// RVA: 0x2B40A80 Offset: 0x2B40B81 VA: 0x2B40A80
	public void Initiate(Transform transform, IKSolverFullBody solver) { }

	// RVA: 0x2B40AD0 Offset: 0x2B40BD1 VA: 0x2B40AD0
	public Vector3 get_swingDirection() { }

	// RVA: 0x2B40BA0 Offset: 0x2B40CA1 VA: 0x2B40BA0
	public void StoreDefaultLocalState() { }

	// RVA: 0x2B40C00 Offset: 0x2B40D01 VA: 0x2B40C00
	public void FixTransform(bool position) { }

	// RVA: 0x2B40C50 Offset: 0x2B40D51 VA: 0x2B40C50
	public bool get_isNodeBone() { }

	// RVA: 0x2B40C60 Offset: 0x2B40D61 VA: 0x2B40C60
	public void SetLength(IKMapping.BoneMap nextBone) { }

	// RVA: 0x2B40D50 Offset: 0x2B40E51 VA: 0x2B40D50
	public void SetLocalSwingAxis(IKMapping.BoneMap swingTarget) { }

	// RVA: 0x2B40D60 Offset: 0x2B40E61 VA: 0x2B40D60
	public void SetLocalSwingAxis(IKMapping.BoneMap bone1, IKMapping.BoneMap bone2) { }

	// RVA: 0x2B40EF0 Offset: 0x2B40FF1 VA: 0x2B40EF0
	public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection) { }

	// RVA: 0x2B41000 Offset: 0x2B41101 VA: 0x2B41000
	public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3) { }

	// RVA: 0x2B410D0 Offset: 0x2B411D1 VA: 0x2B410D0
	public void UpdatePlane(bool rotation, bool position) { }

	// RVA: 0x2B414B0 Offset: 0x2B415B1 VA: 0x2B414B0
	public void SetIKPosition() { }

	// RVA: 0x2B414F0 Offset: 0x2B415F1 VA: 0x2B414F0
	public void MaintainRotation() { }

	// RVA: 0x2B41530 Offset: 0x2B41631 VA: 0x2B41530
	public void SetToIKPosition() { }

	// RVA: 0x2B41560 Offset: 0x2B41661 VA: 0x2B41560
	public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode) { }

	// RVA: 0x2B416A0 Offset: 0x2B417A1 VA: 0x2B416A0
	public Vector3 GetPlanePosition(IKSolverFullBody solver) { }

	// RVA: 0x2B419F0 Offset: 0x2B41AF1 VA: 0x2B419F0
	public void PositionToPlane(IKSolverFullBody solver) { }

	// RVA: 0x2B41A20 Offset: 0x2B41B21 VA: 0x2B41A20
	public void RotateToPlane(IKSolverFullBody solver, float weight) { }

	// RVA: 0x2B41BC0 Offset: 0x2B41CC1 VA: 0x2B41BC0
	public void Swing(Vector3 swingTarget, float weight) { }

	// RVA: 0x2B41C30 Offset: 0x2B41D31 VA: 0x2B41C30
	public void Swing(Vector3 pos1, Vector3 pos2, float weight) { }

	// RVA: 0x2B41E70 Offset: 0x2B41F71 VA: 0x2B41E70
	public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight) { }

	// RVA: 0x2B420A0 Offset: 0x2B421A1 VA: 0x2B420A0
	public void RotateToMaintain(float weight) { }

	// RVA: 0x2B421C0 Offset: 0x2B422C1 VA: 0x2B421C0
	public void RotateToEffector(IKSolverFullBody solver, float weight) { }

	// RVA: 0x2B417F0 Offset: 0x2B418F1 VA: 0x2B417F0
	private Quaternion GetTargetRotation(IKSolverFullBody solver) { }

	// RVA: 0x2B41280 Offset: 0x2B41381 VA: 0x2B41280
	private Quaternion get_lastAnimatedTargetRotation() { }

	// RVA: 0x2B42360 Offset: 0x2B42461 VA: 0x2B42360
	public void .ctor() { }
}

