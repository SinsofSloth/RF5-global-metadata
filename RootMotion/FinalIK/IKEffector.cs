[Serializable]
public class IKEffector // TypeDefIndex: 9464
{
	// Fields
	public Transform bone; // 0x10
	public Transform target; // 0x18
	[RangeAttribute] // RVA: 0x17AF20 Offset: 0x17B021 VA: 0x17AF20
	public float positionWeight; // 0x20
	[RangeAttribute] // RVA: 0x17AF40 Offset: 0x17B041 VA: 0x17AF40
	public float rotationWeight; // 0x24
	public Vector3 position; // 0x28
	public Quaternion rotation; // 0x34
	public Vector3 positionOffset; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x17AF60 Offset: 0x17B061 VA: 0x17AF60
	private bool <isEndEffector>k__BackingField; // 0x50
	public bool effectChildNodes; // 0x51
	[RangeAttribute] // RVA: 0x17AF70 Offset: 0x17B071 VA: 0x17AF70
	public float maintainRelativePositionWeight; // 0x54
	public Transform[] childBones; // 0x58
	public Transform planeBone1; // 0x60
	public Transform planeBone2; // 0x68
	public Transform planeBone3; // 0x70
	public Quaternion planeRotationOffset; // 0x78
	private float posW; // 0x88
	private float rotW; // 0x8C
	private Vector3[] localPositions; // 0x90
	private bool usePlaneNodes; // 0x98
	private Quaternion animatedPlaneRotation; // 0x9C
	private Vector3 animatedPosition; // 0xAC
	private bool firstUpdate; // 0xB8
	private int chainIndex; // 0xBC
	private int nodeIndex; // 0xC0
	private int plane1ChainIndex; // 0xC4
	private int plane1NodeIndex; // 0xC8
	private int plane2ChainIndex; // 0xCC
	private int plane2NodeIndex; // 0xD0
	private int plane3ChainIndex; // 0xD4
	private int plane3NodeIndex; // 0xD8
	private int[] childChainIndexes; // 0xE0
	private int[] childNodeIndexes; // 0xE8

	// Properties
	public bool isEndEffector { get; set; }

	// Methods

	// RVA: 0x2B3E870 Offset: 0x2B3E971 VA: 0x2B3E870
	public IKSolver.Node GetNode(IKSolverFullBody solver) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB450 Offset: 0x1AB551 VA: 0x1AB450
	// RVA: 0x2B3E8E0 Offset: 0x2B3E9E1 VA: 0x2B3E8E0
	public bool get_isEndEffector() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB460 Offset: 0x1AB561 VA: 0x1AB460
	// RVA: 0x2B3E8F0 Offset: 0x2B3E9F1 VA: 0x2B3E8F0
	private void set_isEndEffector(bool value) { }

	// RVA: 0x2B3E900 Offset: 0x2B3EA01 VA: 0x2B3E900
	public void PinToBone(float positionWeight, float rotationWeight) { }

	// RVA: 0x2B3E9E0 Offset: 0x2B3EAE1 VA: 0x2B3E9E0
	public void .ctor() { }

	// RVA: 0x2B3EB50 Offset: 0x2B3EC51 VA: 0x2B3EB50
	public void .ctor(Transform bone, Transform[] childBones) { }

	// RVA: 0x2B3ED00 Offset: 0x2B3EE01 VA: 0x2B3ED00
	public bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x2B3EFE0 Offset: 0x2B3F0E1 VA: 0x2B3EFE0
	public void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x2B3F2C0 Offset: 0x2B3F3C1 VA: 0x2B3F2C0
	public void ResetOffset(IKSolverFullBody solver) { }

	// RVA: 0x2B3F400 Offset: 0x2B3F501 VA: 0x2B3F400
	public void SetToTarget() { }

	// RVA: 0x2B3F4B0 Offset: 0x2B3F5B1 VA: 0x2B3F4B0
	public void OnPreSolve(IKSolverFullBody solver) { }

	// RVA: 0x2B3FB10 Offset: 0x2B3FC11 VA: 0x2B3FB10
	public void OnPostWrite() { }

	// RVA: 0x2B3FB80 Offset: 0x2B3FC81 VA: 0x2B3FB80
	private Quaternion GetPlaneRotation(IKSolverFullBody solver) { }

	// RVA: 0x2B3FDA0 Offset: 0x2B3FEA1 VA: 0x2B3FDA0
	public void Update(IKSolverFullBody solver) { }

	// RVA: 0x2B400D0 Offset: 0x2B401D1 VA: 0x2B400D0
	private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset) { }
}

