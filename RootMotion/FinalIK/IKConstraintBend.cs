[Serializable]
public class IKConstraintBend // TypeDefIndex: 9463
{
	// Fields
	public Transform bone1; // 0x10
	public Transform bone2; // 0x18
	public Transform bone3; // 0x20
	public Transform bendGoal; // 0x28
	public Vector3 direction; // 0x30
	public Quaternion rotationOffset; // 0x3C
	[RangeAttribute] // RVA: 0x17AEF0 Offset: 0x17AFF1 VA: 0x17AEF0
	public float weight; // 0x4C
	public Vector3 defaultLocalDirection; // 0x50
	public Vector3 defaultChildDirection; // 0x5C
	public float clampF; // 0x68
	private int chainIndex1; // 0x6C
	private int nodeIndex1; // 0x70
	private int chainIndex2; // 0x74
	private int nodeIndex2; // 0x78
	private int chainIndex3; // 0x7C
	private int nodeIndex3; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x17AF10 Offset: 0x17B011 VA: 0x17AF10
	private bool <initiated>k__BackingField; // 0x84
	private bool limbOrientationsSet; // 0x85

	// Properties
	public bool initiated { get; set; }

	// Methods

	// RVA: 0x2B3DC90 Offset: 0x2B3DD91 VA: 0x2B3DC90
	public bool IsValid(IKSolverFullBody solver, Warning.Logger logger) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB430 Offset: 0x1AB531 VA: 0x1AB430
	// RVA: 0x2B3DE60 Offset: 0x2B3DF61 VA: 0x2B3DE60
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB440 Offset: 0x1AB541 VA: 0x1AB440
	// RVA: 0x2B3DE70 Offset: 0x2B3DF71 VA: 0x2B3DE70
	private void set_initiated(bool value) { }

	// RVA: 0x2B29630 Offset: 0x2B29731 VA: 0x2B29630
	public void .ctor() { }

	// RVA: 0x2B3DE80 Offset: 0x2B3DF81 VA: 0x2B3DE80
	public void .ctor(Transform bone1, Transform bone2, Transform bone3) { }

	// RVA: 0x2B2A3B0 Offset: 0x2B2A4B1 VA: 0x2B2A3B0
	public void SetBones(Transform bone1, Transform bone2, Transform bone3) { }

	// RVA: 0x2B2A400 Offset: 0x2B2A501 VA: 0x2B2A400
	public void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x2B3E190 Offset: 0x2B3E291 VA: 0x2B3E190
	public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last) { }

	// RVA: 0x2B3E3D0 Offset: 0x2B3E4D1 VA: 0x2B3E3D0
	public void LimitBend(float solverWeight, float positionWeight) { }

	// RVA: 0x2B2B920 Offset: 0x2B2BA21 VA: 0x2B2B920
	public Vector3 GetDir(IKSolverFullBody solver) { }

	// RVA: 0x2B3DF50 Offset: 0x2B3E051 VA: 0x2B3DF50
	private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent) { }

	// RVA: 0x2B3E070 Offset: 0x2B3E171 VA: 0x2B3E070
	private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent) { }
}

