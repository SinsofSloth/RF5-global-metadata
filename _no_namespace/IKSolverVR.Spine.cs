[Serializable]
public class IKSolverVR.Spine : IKSolverVR.BodyPart // TypeDefIndex: 9502
{
	// Fields
	[TooltipAttribute] // RVA: 0x197570 Offset: 0x197671 VA: 0x197570
	public Transform headTarget; // 0x48
	[TooltipAttribute] // RVA: 0x1975B0 Offset: 0x1976B1 VA: 0x1975B0
	public Transform pelvisTarget; // 0x50
	[TooltipAttribute] // RVA: 0x1975F0 Offset: 0x1976F1 VA: 0x1975F0
	[RangeAttribute] // RVA: 0x1975F0 Offset: 0x1976F1 VA: 0x1975F0
	public float positionWeight; // 0x58
	[TooltipAttribute] // RVA: 0x197650 Offset: 0x197751 VA: 0x197650
	[RangeAttribute] // RVA: 0x197650 Offset: 0x197751 VA: 0x197650
	public float rotationWeight; // 0x5C
	[TooltipAttribute] // RVA: 0x1976B0 Offset: 0x1977B1 VA: 0x1976B0
	[RangeAttribute] // RVA: 0x1976B0 Offset: 0x1977B1 VA: 0x1976B0
	public float pelvisPositionWeight; // 0x60
	[TooltipAttribute] // RVA: 0x197710 Offset: 0x197811 VA: 0x197710
	[RangeAttribute] // RVA: 0x197710 Offset: 0x197811 VA: 0x197710
	public float pelvisRotationWeight; // 0x64
	[TooltipAttribute] // RVA: 0x197770 Offset: 0x197871 VA: 0x197770
	public Transform chestGoal; // 0x68
	[TooltipAttribute] // RVA: 0x1977B0 Offset: 0x1978B1 VA: 0x1977B0
	[RangeAttribute] // RVA: 0x1977B0 Offset: 0x1978B1 VA: 0x1977B0
	public float chestGoalWeight; // 0x70
	[TooltipAttribute] // RVA: 0x197810 Offset: 0x197911 VA: 0x197810
	public float minHeadHeight; // 0x74
	[TooltipAttribute] // RVA: 0x197850 Offset: 0x197951 VA: 0x197850
	[RangeAttribute] // RVA: 0x197850 Offset: 0x197951 VA: 0x197850
	public float bodyPosStiffness; // 0x78
	[TooltipAttribute] // RVA: 0x1978B0 Offset: 0x1979B1 VA: 0x1978B0
	[RangeAttribute] // RVA: 0x1978B0 Offset: 0x1979B1 VA: 0x1978B0
	public float bodyRotStiffness; // 0x7C
	[TooltipAttribute] // RVA: 0x197910 Offset: 0x197A11 VA: 0x197910
	[FormerlySerializedAsAttribute] // RVA: 0x197910 Offset: 0x197A11 VA: 0x197910
	[RangeAttribute] // RVA: 0x197910 Offset: 0x197A11 VA: 0x197910
	public float neckStiffness; // 0x80
	[TooltipAttribute] // RVA: 0x197990 Offset: 0x197A91 VA: 0x197990
	[RangeAttribute] // RVA: 0x197990 Offset: 0x197A91 VA: 0x197990
	public float rotateChestByHands; // 0x84
	[TooltipAttribute] // RVA: 0x1979F0 Offset: 0x197AF1 VA: 0x1979F0
	[RangeAttribute] // RVA: 0x1979F0 Offset: 0x197AF1 VA: 0x1979F0
	public float chestClampWeight; // 0x88
	[TooltipAttribute] // RVA: 0x197A50 Offset: 0x197B51 VA: 0x197A50
	[RangeAttribute] // RVA: 0x197A50 Offset: 0x197B51 VA: 0x197A50
	public float headClampWeight; // 0x8C
	[TooltipAttribute] // RVA: 0x197AB0 Offset: 0x197BB1 VA: 0x197AB0
	public float moveBodyBackWhenCrouching; // 0x90
	[TooltipAttribute] // RVA: 0x197AF0 Offset: 0x197BF1 VA: 0x197AF0
	[RangeAttribute] // RVA: 0x197AF0 Offset: 0x197BF1 VA: 0x197AF0
	public float maintainPelvisPosition; // 0x94
	[TooltipAttribute] // RVA: 0x197B50 Offset: 0x197C51 VA: 0x197B50
	[RangeAttribute] // RVA: 0x197B50 Offset: 0x197C51 VA: 0x197B50
	public float maxRootAngle; // 0x98
	[TooltipAttribute] // RVA: 0x197BB0 Offset: 0x197CB1 VA: 0x197BB0
	[RangeAttribute] // RVA: 0x197BB0 Offset: 0x197CB1 VA: 0x197BB0
	public float rootHeadingOffset; // 0x9C
	[HideInInspector] // RVA: 0x197C10 Offset: 0x197D11 VA: 0x197C10
	public Vector3 IKPositionHead; // 0xA0
	[HideInInspector] // RVA: 0x197C20 Offset: 0x197D21 VA: 0x197C20
	public Quaternion IKRotationHead; // 0xAC
	[HideInInspector] // RVA: 0x197C30 Offset: 0x197D31 VA: 0x197C30
	public Vector3 IKPositionPelvis; // 0xBC
	[HideInInspector] // RVA: 0x197C40 Offset: 0x197D41 VA: 0x197C40
	public Quaternion IKRotationPelvis; // 0xC8
	[HideInInspector] // RVA: 0x197C50 Offset: 0x197D51 VA: 0x197C50
	public Vector3 goalPositionChest; // 0xD8
	[HideInInspector] // RVA: 0x197C60 Offset: 0x197D61 VA: 0x197C60
	public Vector3 pelvisPositionOffset; // 0xE4
	[HideInInspector] // RVA: 0x197C70 Offset: 0x197D71 VA: 0x197C70
	public Vector3 chestPositionOffset; // 0xF0
	[HideInInspector] // RVA: 0x197C80 Offset: 0x197D81 VA: 0x197C80
	public Vector3 headPositionOffset; // 0xFC
	[HideInInspector] // RVA: 0x197C90 Offset: 0x197D91 VA: 0x197C90
	public Quaternion pelvisRotationOffset; // 0x108
	[HideInInspector] // RVA: 0x197CA0 Offset: 0x197DA1 VA: 0x197CA0
	public Quaternion chestRotationOffset; // 0x118
	[HideInInspector] // RVA: 0x197CB0 Offset: 0x197DB1 VA: 0x197CB0
	public Quaternion headRotationOffset; // 0x128
	[HideInInspector] // RVA: 0x197CC0 Offset: 0x197DC1 VA: 0x197CC0
	public Vector3 faceDirection; // 0x138
	[HideInInspector] // RVA: 0x197CD0 Offset: 0x197DD1 VA: 0x197CD0
	public Vector3 locomotionHeadPositionOffset; // 0x144
	[HideInInspector] // RVA: 0x197CE0 Offset: 0x197DE1 VA: 0x197CE0
	public Vector3 headPosition; // 0x150
	[CompilerGeneratedAttribute] // RVA: 0x197CF0 Offset: 0x197DF1 VA: 0x197CF0
	private Quaternion <anchorRotation>k__BackingField; // 0x15C
	[CompilerGeneratedAttribute] // RVA: 0x197D00 Offset: 0x197E01 VA: 0x197D00
	private Quaternion <anchorRelativeToHead>k__BackingField; // 0x16C
	private Quaternion headRotation; // 0x17C
	private Quaternion pelvisRotation; // 0x18C
	private Quaternion anchorRelativeToPelvis; // 0x19C
	private Quaternion pelvisRelativeRotation; // 0x1AC
	private Quaternion chestRelativeRotation; // 0x1BC
	private Vector3 headDeltaPosition; // 0x1CC
	private Quaternion pelvisDeltaRotation; // 0x1D8
	private Quaternion chestTargetRotation; // 0x1E8
	private int pelvisIndex; // 0x1F8
	private int spineIndex; // 0x1FC
	private int chestIndex; // 0x200
	private int neckIndex; // 0x204
	private int headIndex; // 0x208
	private float length; // 0x20C
	private bool hasChest; // 0x210
	private bool hasNeck; // 0x211
	private bool hasLegs; // 0x212
	private float headHeight; // 0x214
	private float sizeMlp; // 0x218
	private Vector3 chestForward; // 0x21C

	// Properties
	public IKSolverVR.VirtualBone pelvis { get; }
	public IKSolverVR.VirtualBone firstSpineBone { get; }
	public IKSolverVR.VirtualBone chest { get; }
	private IKSolverVR.VirtualBone neck { get; }
	public IKSolverVR.VirtualBone head { get; }
	public Quaternion anchorRotation { get; set; }
	public Quaternion anchorRelativeToHead { get; set; }

	// Methods

	// RVA: 0x2BDA2A0 Offset: 0x2BDA3A1 VA: 0x2BDA2A0
	public IKSolverVR.VirtualBone get_pelvis() { }

	// RVA: 0x2BE8030 Offset: 0x2BE8131 VA: 0x2BE8030
	public IKSolverVR.VirtualBone get_firstSpineBone() { }

	// RVA: 0x2BDF1B0 Offset: 0x2BDF2B1 VA: 0x2BDF1B0
	public IKSolverVR.VirtualBone get_chest() { }

	// RVA: 0x2BE8070 Offset: 0x2BE8171 VA: 0x2BE8070
	private IKSolverVR.VirtualBone get_neck() { }

	// RVA: 0x2BE7AE0 Offset: 0x2BE7BE1 VA: 0x2BE7AE0
	public IKSolverVR.VirtualBone get_head() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5660 Offset: 0x1B5761 VA: 0x1B5660
	// RVA: 0x2BE80B0 Offset: 0x2BE81B1 VA: 0x2BE80B0
	public Quaternion get_anchorRotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5670 Offset: 0x1B5771 VA: 0x1B5670
	// RVA: 0x2BE80D0 Offset: 0x2BE81D1 VA: 0x2BE80D0
	private void set_anchorRotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5680 Offset: 0x1B5781 VA: 0x1B5680
	// RVA: 0x2BE80F0 Offset: 0x2BE81F1 VA: 0x2BE80F0
	public Quaternion get_anchorRelativeToHead() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5690 Offset: 0x1B5791 VA: 0x1B5690
	// RVA: 0x2BE8110 Offset: 0x2BE8211 VA: 0x2BE8110
	private void set_anchorRelativeToHead(Quaternion value) { }

	// RVA: 0x2BE8130 Offset: 0x2BE8231 VA: 0x2BE8130 Slot: 4
	protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) { }

	// RVA: 0x2BE8D20 Offset: 0x2BE8E21 VA: 0x2BE8D20 Slot: 5
	public override void PreSolve() { }

	// RVA: 0x2BE8F90 Offset: 0x2BE9091 VA: 0x2BE8F90 Slot: 7
	public override void ApplyOffsets() { }

	// RVA: 0x2BE9640 Offset: 0x2BE9741 VA: 0x2BE9640
	private void CalculateChestTargetRotation(IKSolverVR.VirtualBone rootBone, IKSolverVR.Arm[] arms) { }

	// RVA: 0x2BDCE70 Offset: 0x2BDCF71 VA: 0x2BDCE70
	public void Solve(IKSolverVR.VirtualBone rootBone, IKSolverVR.Leg[] legs, IKSolverVR.Arm[] arms) { }

	// RVA: 0x2BEA070 Offset: 0x2BEA171 VA: 0x2BEA070
	private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight) { }

	// RVA: 0x2BEA8E0 Offset: 0x2BEA9E1 VA: 0x2BEA8E0
	private void SolvePelvis() { }

	// RVA: 0x2BEB100 Offset: 0x2BEB201 VA: 0x2BEB100 Slot: 6
	public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) { }

	// RVA: 0x2BEB320 Offset: 0x2BEB421 VA: 0x2BEB320 Slot: 8
	public override void ResetOffsets() { }

	// RVA: 0x2BE9870 Offset: 0x2BE9971 VA: 0x2BE9870
	private void AdjustChestByHands(ref Quaternion chestTargetRotation, IKSolverVR.Arm[] arms) { }

	// RVA: 0x2BDEBE0 Offset: 0x2BDECE1 VA: 0x2BDEBE0
	public void InverseTranslateToHead(IKSolverVR.Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w) { }

	// RVA: 0x2BE9C10 Offset: 0x2BE9D11 VA: 0x2BE9C10
	private void TranslatePelvis(IKSolverVR.Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation) { }

	// RVA: 0x2BEB430 Offset: 0x2BEB531 VA: 0x2BEB430
	private Vector3 LimitPelvisPosition(IKSolverVR.Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2) { }

	// RVA: 0x2BEA5D0 Offset: 0x2BEA6D1 VA: 0x2BEA5D0
	private void Bend(IKSolverVR.VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w) { }

	// RVA: 0x2BEA240 Offset: 0x2BEA341 VA: 0x2BEA240
	private void Bend(IKSolverVR.VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w) { }

	// RVA: 0x2BE1360 Offset: 0x2BE1461 VA: 0x2BE1360
	public void .ctor() { }
}

