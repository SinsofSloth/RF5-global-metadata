[Serializable]
public class IKSolverVR.Locomotion // TypeDefIndex: 9501
{
	// Fields
	[TooltipAttribute] // RVA: 0x197040 Offset: 0x197141 VA: 0x197040
	[RangeAttribute] // RVA: 0x197040 Offset: 0x197141 VA: 0x197040
	public float weight; // 0x10
	[TooltipAttribute] // RVA: 0x1970A0 Offset: 0x1971A1 VA: 0x1970A0
	public float footDistance; // 0x14
	[TooltipAttribute] // RVA: 0x1970E0 Offset: 0x1971E1 VA: 0x1970E0
	public float stepThreshold; // 0x18
	[TooltipAttribute] // RVA: 0x197120 Offset: 0x197221 VA: 0x197120
	public float angleThreshold; // 0x1C
	[TooltipAttribute] // RVA: 0x197160 Offset: 0x197261 VA: 0x197160
	public float comAngleMlp; // 0x20
	[TooltipAttribute] // RVA: 0x1971A0 Offset: 0x1972A1 VA: 0x1971A0
	public float maxVelocity; // 0x24
	[TooltipAttribute] // RVA: 0x1971E0 Offset: 0x1972E1 VA: 0x1971E0
	public float velocityFactor; // 0x28
	[TooltipAttribute] // RVA: 0x197220 Offset: 0x197321 VA: 0x197220
	[RangeAttribute] // RVA: 0x197220 Offset: 0x197321 VA: 0x197220
	public float maxLegStretch; // 0x2C
	[TooltipAttribute] // RVA: 0x197280 Offset: 0x197381 VA: 0x197280
	public float rootSpeed; // 0x30
	[TooltipAttribute] // RVA: 0x1972C0 Offset: 0x1973C1 VA: 0x1972C0
	public float stepSpeed; // 0x34
	[TooltipAttribute] // RVA: 0x197300 Offset: 0x197401 VA: 0x197300
	public AnimationCurve stepHeight; // 0x38
	[TooltipAttribute] // RVA: 0x197340 Offset: 0x197441 VA: 0x197340
	public AnimationCurve heelHeight; // 0x40
	[TooltipAttribute] // RVA: 0x197380 Offset: 0x197481 VA: 0x197380
	[RangeAttribute] // RVA: 0x197380 Offset: 0x197481 VA: 0x197380
	public float relaxLegTwistMinAngle; // 0x48
	[TooltipAttribute] // RVA: 0x1973E0 Offset: 0x1974E1 VA: 0x1973E0
	public float relaxLegTwistSpeed; // 0x4C
	[TooltipAttribute] // RVA: 0x197420 Offset: 0x197521 VA: 0x197420
	public InterpolationMode stepInterpolation; // 0x50
	[TooltipAttribute] // RVA: 0x197460 Offset: 0x197561 VA: 0x197460
	public Vector3 offset; // 0x54
	[HideInInspector] // RVA: 0x1974A0 Offset: 0x1975A1 VA: 0x1974A0
	public bool blockingEnabled; // 0x60
	[HideInInspector] // RVA: 0x1974B0 Offset: 0x1975B1 VA: 0x1974B0
	public LayerMask blockingLayers; // 0x64
	[HideInInspector] // RVA: 0x1974C0 Offset: 0x1975C1 VA: 0x1974C0
	public float raycastRadius; // 0x68
	[HideInInspector] // RVA: 0x1974D0 Offset: 0x1975D1 VA: 0x1974D0
	public float raycastHeight; // 0x6C
	[TooltipAttribute] // RVA: 0x1974E0 Offset: 0x1975E1 VA: 0x1974E0
	public UnityEvent onLeftFootstep; // 0x70
	[TooltipAttribute] // RVA: 0x197520 Offset: 0x197621 VA: 0x197520
	public UnityEvent onRightFootstep; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x197560 Offset: 0x197661 VA: 0x197560
	private Vector3 <centerOfMass>k__BackingField; // 0x80
	private IKSolverVR.Footstep[] footsteps; // 0x90
	private Vector3 lastComPosition; // 0x98
	private Vector3 comVelocity; // 0xA4
	private int leftFootIndex; // 0xB0
	private int rightFootIndex; // 0xB4

	// Properties
	public Vector3 centerOfMass { get; set; }
	public Vector3 leftFootstepPosition { get; }
	public Vector3 rightFootstepPosition { get; }
	public Quaternion leftFootstepRotation { get; }
	public Quaternion rightFootstepRotation { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1B5640 Offset: 0x1B5741 VA: 0x1B5640
	// RVA: 0x2BE7AC0 Offset: 0x2BE7BC1 VA: 0x2BE7AC0
	public Vector3 get_centerOfMass() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5650 Offset: 0x1B5751 VA: 0x1B5650
	// RVA: 0x2BE7AD0 Offset: 0x2BE7BD1 VA: 0x2BE7AD0
	private void set_centerOfMass(Vector3 value) { }

	// RVA: 0x2BDCB40 Offset: 0x2BDCC41 VA: 0x2BDCB40
	public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes) { }

	// RVA: 0x2BD9FD0 Offset: 0x2BDA0D1 VA: 0x2BD9FD0
	public void Reset(Vector3[] positions, Quaternion[] rotations) { }

	// RVA: 0x2BD9320 Offset: 0x2BD9421 VA: 0x2BD9320
	public void AddDeltaRotation(Quaternion delta, Vector3 pivot) { }

	// RVA: 0x2BD9180 Offset: 0x2BD9281 VA: 0x2BD9180
	public void AddDeltaPosition(Vector3 delta) { }

	// RVA: 0x2BDD4B0 Offset: 0x2BDD5B1 VA: 0x2BDD4B0
	public void Solve(IKSolverVR.VirtualBone rootBone, IKSolverVR.Spine spine, IKSolverVR.Leg leftLeg, IKSolverVR.Leg rightLeg, IKSolverVR.Arm leftArm, IKSolverVR.Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset) { }

	// RVA: 0x2BE7F10 Offset: 0x2BE8011 VA: 0x2BE7F10
	public Vector3 get_leftFootstepPosition() { }

	// RVA: 0x2BE7F50 Offset: 0x2BE8051 VA: 0x2BE7F50
	public Vector3 get_rightFootstepPosition() { }

	// RVA: 0x2BE7FA0 Offset: 0x2BE80A1 VA: 0x2BE7FA0
	public Quaternion get_leftFootstepRotation() { }

	// RVA: 0x2BE7FE0 Offset: 0x2BE80E1 VA: 0x2BE7FE0
	public Quaternion get_rightFootstepRotation() { }

	// RVA: 0x2BE7B20 Offset: 0x2BE7C21 VA: 0x2BE7B20
	private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition) { }

	// RVA: 0x2BE7CC0 Offset: 0x2BE7DC1 VA: 0x2BE7CC0
	private bool CanStep() { }

	// RVA: 0x2BE7D40 Offset: 0x2BE7E41 VA: 0x2BE7D40
	private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius) { }

	// RVA: 0x2BE17D0 Offset: 0x2BE18D1 VA: 0x2BE17D0
	public void .ctor() { }
}

