[Serializable]
public class IKSolverVR.Leg : IKSolverVR.BodyPart // TypeDefIndex: 9500
{
	// Fields
	[TooltipAttribute] // RVA: 0x196C90 Offset: 0x196D91 VA: 0x196C90
	public Transform target; // 0x48
	[TooltipAttribute] // RVA: 0x196CD0 Offset: 0x196DD1 VA: 0x196CD0
	public Transform bendGoal; // 0x50
	[TooltipAttribute] // RVA: 0x196D10 Offset: 0x196E11 VA: 0x196D10
	[RangeAttribute] // RVA: 0x196D10 Offset: 0x196E11 VA: 0x196D10
	public float positionWeight; // 0x58
	[TooltipAttribute] // RVA: 0x196D70 Offset: 0x196E71 VA: 0x196D70
	[RangeAttribute] // RVA: 0x196D70 Offset: 0x196E71 VA: 0x196D70
	public float rotationWeight; // 0x5C
	[TooltipAttribute] // RVA: 0x196DD0 Offset: 0x196ED1 VA: 0x196DD0
	[RangeAttribute] // RVA: 0x196DD0 Offset: 0x196ED1 VA: 0x196DD0
	public float bendGoalWeight; // 0x60
	[TooltipAttribute] // RVA: 0x196E30 Offset: 0x196F31 VA: 0x196E30
	[RangeAttribute] // RVA: 0x196E30 Offset: 0x196F31 VA: 0x196E30
	public float swivelOffset; // 0x64
	[TooltipAttribute] // RVA: 0x196E90 Offset: 0x196F91 VA: 0x196E90
	[RangeAttribute] // RVA: 0x196E90 Offset: 0x196F91 VA: 0x196E90
	public float bendToTargetWeight; // 0x68
	[TooltipAttribute] // RVA: 0x196EF0 Offset: 0x196FF1 VA: 0x196EF0
	[RangeAttribute] // RVA: 0x196EF0 Offset: 0x196FF1 VA: 0x196EF0
	public float legLengthMlp; // 0x6C
	[TooltipAttribute] // RVA: 0x196F50 Offset: 0x197051 VA: 0x196F50
	public AnimationCurve stretchCurve; // 0x70
	[HideInInspector] // RVA: 0x196F90 Offset: 0x197091 VA: 0x196F90
	public Vector3 IKPosition; // 0x78
	[HideInInspector] // RVA: 0x196FA0 Offset: 0x1970A1 VA: 0x196FA0
	public Quaternion IKRotation; // 0x84
	[HideInInspector] // RVA: 0x196FB0 Offset: 0x1970B1 VA: 0x196FB0
	public Vector3 footPositionOffset; // 0x94
	[HideInInspector] // RVA: 0x196FC0 Offset: 0x1970C1 VA: 0x196FC0
	public Vector3 heelPositionOffset; // 0xA0
	[HideInInspector] // RVA: 0x196FD0 Offset: 0x1970D1 VA: 0x196FD0
	public Quaternion footRotationOffset; // 0xAC
	[HideInInspector] // RVA: 0x196FE0 Offset: 0x1970E1 VA: 0x196FE0
	public float currentMag; // 0xBC
	[HideInInspector] // RVA: 0x196FF0 Offset: 0x1970F1 VA: 0x196FF0
	public bool useAnimatedBendNormal; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x197000 Offset: 0x197101 VA: 0x197000
	private Vector3 <position>k__BackingField; // 0xC4
	[CompilerGeneratedAttribute] // RVA: 0x197010 Offset: 0x197111 VA: 0x197010
	private Quaternion <rotation>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x197020 Offset: 0x197121 VA: 0x197020
	private bool <hasToes>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x197030 Offset: 0x197131 VA: 0x197030
	private Vector3 <thighRelativeToPelvis>k__BackingField; // 0xE4
	private Vector3 footPosition; // 0xF0
	private Quaternion footRotation; // 0xFC
	private Vector3 bendNormal; // 0x10C
	private Quaternion calfRelToThigh; // 0x118
	private Quaternion thighRelToFoot; // 0x128
	private Vector3 bendNormalRelToPelvis; // 0x138
	private Vector3 bendNormalRelToTarget; // 0x144

	// Properties
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public bool hasToes { get; set; }
	public IKSolverVR.VirtualBone thigh { get; }
	private IKSolverVR.VirtualBone calf { get; }
	private IKSolverVR.VirtualBone foot { get; }
	private IKSolverVR.VirtualBone toes { get; }
	public IKSolverVR.VirtualBone lastBone { get; }
	public Vector3 thighRelativeToPelvis { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1B55C0 Offset: 0x1B56C1 VA: 0x1B55C0
	// RVA: 0x2BE5620 Offset: 0x2BE5721 VA: 0x2BE5620
	public Vector3 get_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B55D0 Offset: 0x1B56D1 VA: 0x1B55D0
	// RVA: 0x2BE5630 Offset: 0x2BE5731 VA: 0x2BE5630
	private void set_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B55E0 Offset: 0x1B56E1 VA: 0x1B55E0
	// RVA: 0x2BE5640 Offset: 0x2BE5741 VA: 0x2BE5640
	public Quaternion get_rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B55F0 Offset: 0x1B56F1 VA: 0x1B55F0
	// RVA: 0x2BE5650 Offset: 0x2BE5751 VA: 0x2BE5650
	private void set_rotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5600 Offset: 0x1B5701 VA: 0x1B5600
	// RVA: 0x2BE5670 Offset: 0x2BE5771 VA: 0x2BE5670
	public bool get_hasToes() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5610 Offset: 0x1B5711 VA: 0x1B5610
	// RVA: 0x2BE5680 Offset: 0x2BE5781 VA: 0x2BE5680
	private void set_hasToes(bool value) { }

	// RVA: 0x2BE5690 Offset: 0x2BE5791 VA: 0x2BE5690
	public IKSolverVR.VirtualBone get_thigh() { }

	// RVA: 0x2BE56D0 Offset: 0x2BE57D1 VA: 0x2BE56D0
	private IKSolverVR.VirtualBone get_calf() { }

	// RVA: 0x2BE5710 Offset: 0x2BE5811 VA: 0x2BE5710
	private IKSolverVR.VirtualBone get_foot() { }

	// RVA: 0x2BE5750 Offset: 0x2BE5851 VA: 0x2BE5750
	private IKSolverVR.VirtualBone get_toes() { }

	// RVA: 0x2BDEBA0 Offset: 0x2BDECA1 VA: 0x2BDEBA0
	public IKSolverVR.VirtualBone get_lastBone() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5620 Offset: 0x1B5721 VA: 0x1B5620
	// RVA: 0x2BE5790 Offset: 0x2BE5891 VA: 0x2BE5790
	public Vector3 get_thighRelativeToPelvis() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5630 Offset: 0x1B5731 VA: 0x1B5630
	// RVA: 0x2BE57A0 Offset: 0x2BE58A1 VA: 0x2BE57A0
	private void set_thighRelativeToPelvis(Vector3 value) { }

	// RVA: 0x2BE57B0 Offset: 0x2BE58B1 VA: 0x2BE57B0 Slot: 4
	protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) { }

	// RVA: 0x2BE5E70 Offset: 0x2BE5F71 VA: 0x2BE5E70 Slot: 5
	public override void PreSolve() { }

	// RVA: 0x2BE67C0 Offset: 0x2BE68C1 VA: 0x2BE67C0 Slot: 7
	public override void ApplyOffsets() { }

	// RVA: 0x2BE66C0 Offset: 0x2BE67C1 VA: 0x2BE66C0
	private void ApplyPositionOffset(Vector3 offset, float weight) { }

	// RVA: 0x2BE6480 Offset: 0x2BE6581 VA: 0x2BE6480
	private void ApplyRotationOffset(Quaternion offset, float weight) { }

	// RVA: 0x2BDEF60 Offset: 0x2BDF061 VA: 0x2BDEF60
	public void Solve(bool stretch) { }

	// RVA: 0x2BE7300 Offset: 0x2BE7401 VA: 0x2BE7300
	private void FixTwistRotations() { }

	// RVA: 0x2BE6D70 Offset: 0x2BE6E71 VA: 0x2BE6D70
	private void Stretching() { }

	// RVA: 0x2BE7760 Offset: 0x2BE7861 VA: 0x2BE7760 Slot: 6
	public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) { }

	// RVA: 0x2BE7A00 Offset: 0x2BE7B01 VA: 0x2BE7A00 Slot: 8
	public override void ResetOffsets() { }

	// RVA: 0x2BE16B0 Offset: 0x2BE17B1 VA: 0x2BE16B0
	public void .ctor() { }
}

