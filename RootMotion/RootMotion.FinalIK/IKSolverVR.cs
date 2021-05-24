[Serializable]
public class IKSolverVR : IKSolver // TypeDefIndex: 9495
{
	// Fields
	private Transform[] solverTransforms; // 0x58
	private bool hasChest; // 0x60
	private bool hasNeck; // 0x61
	private bool hasShoulders; // 0x62
	private bool hasToes; // 0x63
	private bool hasLegs; // 0x64
	private Vector3[] readPositions; // 0x68
	private Quaternion[] readRotations; // 0x70
	private Vector3[] solvedPositions; // 0x78
	private Quaternion[] solvedRotations; // 0x80
	private Quaternion[] defaultLocalRotations; // 0x88
	private Vector3[] defaultLocalPositions; // 0x90
	private Vector3 rootV; // 0x98
	private Vector3 rootVelocity; // 0xA4
	private Vector3 bodyOffset; // 0xB0
	private int supportLegIndex; // 0xBC
	private int lastLOD; // 0xC0
	[TooltipAttribute] // RVA: 0x17B380 Offset: 0x17B481 VA: 0x17B380
	[RangeAttribute] // RVA: 0x17B380 Offset: 0x17B481 VA: 0x17B380
	public int LOD; // 0xC4
	[TooltipAttribute] // RVA: 0x17B3E0 Offset: 0x17B4E1 VA: 0x17B3E0
	public bool plantFeet; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x17B420 Offset: 0x17B521 VA: 0x17B420
	private IKSolverVR.VirtualBone <rootBone>k__BackingField; // 0xD0
	[TooltipAttribute] // RVA: 0x17B430 Offset: 0x17B531 VA: 0x17B430
	public IKSolverVR.Spine spine; // 0xD8
	[TooltipAttribute] // RVA: 0x17B470 Offset: 0x17B571 VA: 0x17B470
	public IKSolverVR.Arm leftArm; // 0xE0
	[TooltipAttribute] // RVA: 0x17B4B0 Offset: 0x17B5B1 VA: 0x17B4B0
	public IKSolverVR.Arm rightArm; // 0xE8
	[TooltipAttribute] // RVA: 0x17B4F0 Offset: 0x17B5F1 VA: 0x17B4F0
	public IKSolverVR.Leg leftLeg; // 0xF0
	[TooltipAttribute] // RVA: 0x17B530 Offset: 0x17B631 VA: 0x17B530
	public IKSolverVR.Leg rightLeg; // 0xF8
	[TooltipAttribute] // RVA: 0x17B570 Offset: 0x17B671 VA: 0x17B570
	public IKSolverVR.Locomotion locomotion; // 0x100
	private IKSolverVR.Leg[] legs; // 0x108
	private IKSolverVR.Arm[] arms; // 0x110
	private Vector3 headPosition; // 0x118
	private Vector3 headDeltaPosition; // 0x124
	private Vector3 raycastOriginPelvis; // 0x130
	private Vector3 lastOffset; // 0x13C
	private Vector3 debugPos1; // 0x148
	private Vector3 debugPos2; // 0x154
	private Vector3 debugPos3; // 0x160
	private Vector3 debugPos4; // 0x16C

	// Properties
	[HideInInspector] // RVA: 0x1B92B0 Offset: 0x1B93B1 VA: 0x1B92B0
	public IKSolverVR.VirtualBone rootBone { get; set; }

	// Methods

	// RVA: 0x2BD7BF0 Offset: 0x2BD7CF1 VA: 0x2BD7BF0
	public void SetToReferences(VRIK.References references) { }

	// RVA: 0x2BD80B0 Offset: 0x2BD81B1 VA: 0x2BD80B0
	public void GuessHandOrientations(VRIK.References references, bool onlyIfZero) { }

	// RVA: 0x2BD7F30 Offset: 0x2BD8031 VA: 0x2BD7F30
	public void DefaultAnimationCurves() { }

	// RVA: 0x2BD8AC0 Offset: 0x2BD8BC1 VA: 0x2BD8AC0
	public void AddPositionOffset(IKSolverVR.PositionOffset positionOffset, Vector3 value) { }

	// RVA: 0x2BD8DA0 Offset: 0x2BD8EA1 VA: 0x2BD8DA0
	public void AddRotationOffset(IKSolverVR.RotationOffset rotationOffset, Vector3 value) { }

	// RVA: 0x2BD8E50 Offset: 0x2BD8F51 VA: 0x2BD8E50
	public void AddRotationOffset(IKSolverVR.RotationOffset rotationOffset, Quaternion value) { }

	// RVA: 0x2BD8FF0 Offset: 0x2BD90F1 VA: 0x2BD8FF0
	public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot) { }

	// RVA: 0x2BD96E0 Offset: 0x2BD97E1 VA: 0x2BD96E0
	public void Reset() { }

	// RVA: 0x2BDA2E0 Offset: 0x2BDA3E1 VA: 0x2BDA2E0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x2BDA460 Offset: 0x2BDA561 VA: 0x2BDA460 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x2BDA6B0 Offset: 0x2BDA7B1 VA: 0x2BDA6B0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x2BDA730 Offset: 0x2BDA831 VA: 0x2BDA730 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x2BDA7B0 Offset: 0x2BDA8B1 VA: 0x2BDA7B0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x2BDA9D0 Offset: 0x2BDAAD1 VA: 0x2BDA9D0
	private Vector3 GetNormal(Transform[] transforms) { }

	// RVA: 0x2BD8350 Offset: 0x2BD8451 VA: 0x2BD8350
	private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm) { }

	// RVA: 0x2BD8530 Offset: 0x2BD8631 VA: 0x2BD8530
	private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm) { }

	// RVA: 0x2BD8990 Offset: 0x2BD8A91 VA: 0x2BD8990
	private static Keyframe[] GetSineKeyframes(float mag) { }

	// RVA: 0x2BD9880 Offset: 0x2BD9981 VA: 0x2BD9880
	private void UpdateSolverTransforms() { }

	// RVA: 0x2BDACB0 Offset: 0x2BDADB1 VA: 0x2BDACB0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x2BDAD00 Offset: 0x2BDAE01 VA: 0x2BDAD00 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2BDC510 Offset: 0x2BDC611 VA: 0x2BDC510
	private void WriteTransforms() { }

	// RVA: 0x2BD99F0 Offset: 0x2BD9AF1 VA: 0x2BD99F0
	private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs) { }

	// RVA: 0x2BDB1F0 Offset: 0x2BDB2F1 VA: 0x2BDB1F0
	private void Solve() { }

	// RVA: 0x2BDC8E0 Offset: 0x2BDC9E1 VA: 0x2BDC8E0
	private Vector3 GetPosition(int index) { }

	// RVA: 0x2BDC930 Offset: 0x2BDCA31 VA: 0x2BDC930
	private Quaternion GetRotation(int index) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB4B0 Offset: 0x1AB5B1 VA: 0x1AB4B0
	// RVA: 0x2BE10D0 Offset: 0x2BE11D1 VA: 0x2BE10D0
	public IKSolverVR.VirtualBone get_rootBone() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB4C0 Offset: 0x1AB5C1 VA: 0x1AB4C0
	// RVA: 0x2BE10E0 Offset: 0x2BE11E1 VA: 0x2BE10E0
	private void set_rootBone(IKSolverVR.VirtualBone value) { }

	// RVA: 0x2BDC3B0 Offset: 0x2BDC4B1 VA: 0x2BDC3B0
	private void Write() { }

	// RVA: 0x2BE0AF0 Offset: 0x2BE0BF1 VA: 0x2BE0AF0
	private Vector3 GetPelvisOffset() { }

	// RVA: 0x2BE10F0 Offset: 0x2BE11F1 VA: 0x2BE10F0
	public void .ctor() { }
}

