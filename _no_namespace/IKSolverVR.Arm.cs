[Serializable]
public class IKSolverVR.Arm : IKSolverVR.BodyPart // TypeDefIndex: 9496
{
	// Fields
	[TooltipAttribute] // RVA: 0x1967D0 Offset: 0x1968D1 VA: 0x1967D0
	public Transform target; // 0x48
	[TooltipAttribute] // RVA: 0x196810 Offset: 0x196911 VA: 0x196810
	public Transform bendGoal; // 0x50
	[TooltipAttribute] // RVA: 0x196850 Offset: 0x196951 VA: 0x196850
	[RangeAttribute] // RVA: 0x196850 Offset: 0x196951 VA: 0x196850
	public float positionWeight; // 0x58
	[TooltipAttribute] // RVA: 0x1968B0 Offset: 0x1969B1 VA: 0x1968B0
	[RangeAttribute] // RVA: 0x1968B0 Offset: 0x1969B1 VA: 0x1968B0
	public float rotationWeight; // 0x5C
	[TooltipAttribute] // RVA: 0x196910 Offset: 0x196A11 VA: 0x196910
	public IKSolverVR.Arm.ShoulderRotationMode shoulderRotationMode; // 0x60
	[TooltipAttribute] // RVA: 0x196950 Offset: 0x196A51 VA: 0x196950
	[RangeAttribute] // RVA: 0x196950 Offset: 0x196A51 VA: 0x196950
	public float shoulderRotationWeight; // 0x64
	[TooltipAttribute] // RVA: 0x1969B0 Offset: 0x196AB1 VA: 0x1969B0
	[RangeAttribute] // RVA: 0x1969B0 Offset: 0x196AB1 VA: 0x1969B0
	public float shoulderTwistWeight; // 0x68
	[TooltipAttribute] // RVA: 0x196A10 Offset: 0x196B11 VA: 0x196A10
	[RangeAttribute] // RVA: 0x196A10 Offset: 0x196B11 VA: 0x196A10
	public float bendGoalWeight; // 0x6C
	[TooltipAttribute] // RVA: 0x196A70 Offset: 0x196B71 VA: 0x196A70
	[RangeAttribute] // RVA: 0x196A70 Offset: 0x196B71 VA: 0x196A70
	public float swivelOffset; // 0x70
	[TooltipAttribute] // RVA: 0x196AD0 Offset: 0x196BD1 VA: 0x196AD0
	public Vector3 wristToPalmAxis; // 0x74
	[TooltipAttribute] // RVA: 0x196B10 Offset: 0x196C11 VA: 0x196B10
	public Vector3 palmToThumbAxis; // 0x80
	[TooltipAttribute] // RVA: 0x196B50 Offset: 0x196C51 VA: 0x196B50
	[RangeAttribute] // RVA: 0x196B50 Offset: 0x196C51 VA: 0x196B50
	public float armLengthMlp; // 0x8C
	[TooltipAttribute] // RVA: 0x196BB0 Offset: 0x196CB1 VA: 0x196BB0
	public AnimationCurve stretchCurve; // 0x90
	[HideInInspector] // RVA: 0x196BF0 Offset: 0x196CF1 VA: 0x196BF0
	public Vector3 IKPosition; // 0x98
	[HideInInspector] // RVA: 0x196C00 Offset: 0x196D01 VA: 0x196C00
	public Quaternion IKRotation; // 0xA4
	[HideInInspector] // RVA: 0x196C10 Offset: 0x196D11 VA: 0x196C10
	public Vector3 bendDirection; // 0xB4
	[HideInInspector] // RVA: 0x196C20 Offset: 0x196D21 VA: 0x196C20
	public Vector3 handPositionOffset; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x196C30 Offset: 0x196D31 VA: 0x196C30
	private Vector3 <position>k__BackingField; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x196C40 Offset: 0x196D41 VA: 0x196C40
	private Quaternion <rotation>k__BackingField; // 0xD8
	private bool hasShoulder; // 0xE8
	private Vector3 chestForwardAxis; // 0xEC
	private Vector3 chestUpAxis; // 0xF8
	private Quaternion chestRotation; // 0x104
	private Vector3 chestForward; // 0x114
	private Vector3 chestUp; // 0x120
	private Quaternion forearmRelToUpperArm; // 0x12C
	private Vector3 upperArmBendAxis; // 0x13C
	private const float yawOffsetAngle = 45;
	private const float pitchOffsetAngle = -30;

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	private IKSolverVR.VirtualBone shoulder { get; }
	private IKSolverVR.VirtualBone upperArm { get; }
	private IKSolverVR.VirtualBone forearm { get; }
	private IKSolverVR.VirtualBone hand { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1B5520 Offset: 0x1B5621 VA: 0x1B5520
	// RVA: 0x2BE1900 Offset: 0x2BE1A01 VA: 0x2BE1900
	public Vector3 get_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5530 Offset: 0x1B5631 VA: 0x1B5530
	// RVA: 0x2BE1910 Offset: 0x2BE1A11 VA: 0x2BE1910
	private void set_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5540 Offset: 0x1B5641 VA: 0x1B5540
	// RVA: 0x2BE1920 Offset: 0x2BE1A21 VA: 0x2BE1920
	public Quaternion get_rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5550 Offset: 0x1B5651 VA: 0x1B5550
	// RVA: 0x2BE1930 Offset: 0x2BE1A31 VA: 0x2BE1930
	private void set_rotation(Quaternion value) { }

	// RVA: 0x2BE1950 Offset: 0x2BE1A51 VA: 0x2BE1950
	private IKSolverVR.VirtualBone get_shoulder() { }

	// RVA: 0x2BE1990 Offset: 0x2BE1A91 VA: 0x2BE1990
	private IKSolverVR.VirtualBone get_upperArm() { }

	// RVA: 0x2BE19D0 Offset: 0x2BE1AD1 VA: 0x2BE19D0
	private IKSolverVR.VirtualBone get_forearm() { }

	// RVA: 0x2BE1A20 Offset: 0x2BE1B21 VA: 0x2BE1A20
	private IKSolverVR.VirtualBone get_hand() { }

	// RVA: 0x2BE1A70 Offset: 0x2BE1B71 VA: 0x2BE1A70 Slot: 4
	protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) { }

	// RVA: 0x2BE2480 Offset: 0x2BE2581 VA: 0x2BE2480 Slot: 5
	public override void PreSolve() { }

	// RVA: 0x2BE26E0 Offset: 0x2BE27E1 VA: 0x2BE26E0 Slot: 7
	public override void ApplyOffsets() { }

	// RVA: 0x2BE2790 Offset: 0x2BE2891 VA: 0x2BE2790
	private void Stretching() { }

	// RVA: 0x2BDF210 Offset: 0x2BDF311 VA: 0x2BDF210
	public void Solve(bool isLeft) { }

	// RVA: 0x2BE3CF0 Offset: 0x2BE3DF1 VA: 0x2BE3CF0 Slot: 8
	public override void ResetOffsets() { }

	// RVA: 0x2BE3D60 Offset: 0x2BE3E61 VA: 0x2BE3D60 Slot: 6
	public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) { }

	// RVA: 0x2BE2D00 Offset: 0x2BE2E01 VA: 0x2BE2D00
	private float DamperValue(float value, float min, float max, float weight = 1) { }

	// RVA: 0x2BE3010 Offset: 0x2BE3111 VA: 0x2BE3010
	private Vector3 GetBendNormal(Vector3 dir) { }

	// RVA: 0x2BE4060 Offset: 0x2BE4161 VA: 0x2BE4060
	private void Visualize(IKSolverVR.VirtualBone bone1, IKSolverVR.VirtualBone bone2, IKSolverVR.VirtualBone bone3, Color color) { }

	// RVA: 0x2BE1560 Offset: 0x2BE1661 VA: 0x2BE1560
	public void .ctor() { }
}

