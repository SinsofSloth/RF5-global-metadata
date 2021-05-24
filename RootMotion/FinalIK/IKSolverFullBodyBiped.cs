[Serializable]
public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 9485
{
	// Fields
	public Transform rootNode; // 0xD0
	[RangeAttribute] // RVA: 0x17B1B0 Offset: 0x17B2B1 VA: 0x17B1B0
	public float spineStiffness; // 0xD8
	[RangeAttribute] // RVA: 0x17B1D0 Offset: 0x17B2D1 VA: 0x17B1D0
	public float pullBodyVertical; // 0xDC
	[RangeAttribute] // RVA: 0x17B1F0 Offset: 0x17B2F1 VA: 0x17B1F0
	public float pullBodyHorizontal; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x17B210 Offset: 0x17B311 VA: 0x17B210
	private Vector3 <pullBodyOffset>k__BackingField; // 0xE4
	private Vector3 offset; // 0xF0

	// Properties
	public IKEffector bodyEffector { get; }
	public IKEffector leftShoulderEffector { get; }
	public IKEffector rightShoulderEffector { get; }
	public IKEffector leftThighEffector { get; }
	public IKEffector rightThighEffector { get; }
	public IKEffector leftHandEffector { get; }
	public IKEffector rightHandEffector { get; }
	public IKEffector leftFootEffector { get; }
	public IKEffector rightFootEffector { get; }
	public FBIKChain leftArmChain { get; }
	public FBIKChain rightArmChain { get; }
	public FBIKChain leftLegChain { get; }
	public FBIKChain rightLegChain { get; }
	public IKMappingLimb leftArmMapping { get; }
	public IKMappingLimb rightArmMapping { get; }
	public IKMappingLimb leftLegMapping { get; }
	public IKMappingLimb rightLegMapping { get; }
	public IKMappingBone headMapping { get; }
	public Vector3 pullBodyOffset { get; set; }

	// Methods

	// RVA: 0x258B170 Offset: 0x258B271 VA: 0x258B170
	public IKEffector get_bodyEffector() { }

	// RVA: 0x258B320 Offset: 0x258B421 VA: 0x258B320
	public IKEffector get_leftShoulderEffector() { }

	// RVA: 0x258B360 Offset: 0x258B461 VA: 0x258B360
	public IKEffector get_rightShoulderEffector() { }

	// RVA: 0x258B3A0 Offset: 0x258B4A1 VA: 0x258B3A0
	public IKEffector get_leftThighEffector() { }

	// RVA: 0x258B3E0 Offset: 0x258B4E1 VA: 0x258B3E0
	public IKEffector get_rightThighEffector() { }

	// RVA: 0x258B420 Offset: 0x258B521 VA: 0x258B420
	public IKEffector get_leftHandEffector() { }

	// RVA: 0x258B460 Offset: 0x258B561 VA: 0x258B460
	public IKEffector get_rightHandEffector() { }

	// RVA: 0x258B4A0 Offset: 0x258B5A1 VA: 0x258B4A0
	public IKEffector get_leftFootEffector() { }

	// RVA: 0x258B4E0 Offset: 0x258B5E1 VA: 0x258B4E0
	public IKEffector get_rightFootEffector() { }

	// RVA: 0x258B520 Offset: 0x258B621 VA: 0x258B520
	public FBIKChain get_leftArmChain() { }

	// RVA: 0x258B560 Offset: 0x258B661 VA: 0x258B560
	public FBIKChain get_rightArmChain() { }

	// RVA: 0x258B5A0 Offset: 0x258B6A1 VA: 0x258B5A0
	public FBIKChain get_leftLegChain() { }

	// RVA: 0x258B5E0 Offset: 0x258B6E1 VA: 0x258B5E0
	public FBIKChain get_rightLegChain() { }

	// RVA: 0x258B620 Offset: 0x258B721 VA: 0x258B620
	public IKMappingLimb get_leftArmMapping() { }

	// RVA: 0x258B660 Offset: 0x258B761 VA: 0x258B660
	public IKMappingLimb get_rightArmMapping() { }

	// RVA: 0x258B6A0 Offset: 0x258B7A1 VA: 0x258B6A0
	public IKMappingLimb get_leftLegMapping() { }

	// RVA: 0x258B6E0 Offset: 0x258B7E1 VA: 0x258B6E0
	public IKMappingLimb get_rightLegMapping() { }

	// RVA: 0x258B720 Offset: 0x258B821 VA: 0x258B720
	public IKMappingBone get_headMapping() { }

	// RVA: 0x258B760 Offset: 0x258B861 VA: 0x258B760
	public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0) { }

	// RVA: 0x258B890 Offset: 0x258B991 VA: 0x258B890
	public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight) { }

	// RVA: 0x258B7C0 Offset: 0x258B8C1 VA: 0x258B7C0
	public FBIKChain GetChain(FullBodyBipedChain c) { }

	// RVA: 0x258B970 Offset: 0x258BA71 VA: 0x258B970
	public FBIKChain GetChain(FullBodyBipedEffector effector) { }

	// RVA: 0x258B1B0 Offset: 0x258B2B1 VA: 0x258B1B0
	public IKEffector GetEffector(FullBodyBipedEffector effector) { }

	// RVA: 0x258BAC0 Offset: 0x258BBC1 VA: 0x258BAC0
	public IKEffector GetEndEffector(FullBodyBipedChain c) { }

	// RVA: 0x258BB90 Offset: 0x258BC91 VA: 0x258BB90
	public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain) { }

	// RVA: 0x258BC60 Offset: 0x258BD61 VA: 0x258BC60
	public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector) { }

	// RVA: 0x258BD80 Offset: 0x258BE81 VA: 0x258BD80
	public IKMappingSpine GetSpineMapping() { }

	// RVA: 0x258BD90 Offset: 0x258BE91 VA: 0x258BD90
	public IKMappingBone GetHeadMapping() { }

	// RVA: 0x258BDD0 Offset: 0x258BED1 VA: 0x258BDD0
	public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb) { }

	// RVA: 0x258BEA0 Offset: 0x258BFA1 VA: 0x258BEA0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x258C040 Offset: 0x258C141 VA: 0x258C040
	public void SetToReferences(BipedReferences references, Transform rootNode) { }

	// RVA: 0x258D530 Offset: 0x258D631 VA: 0x258D530
	public static Transform DetectRootNodeBone(BipedReferences references) { }

	// RVA: 0x258D9D0 Offset: 0x258DAD1 VA: 0x258D9D0
	public void SetLimbOrientations(BipedLimbOrientations o) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB490 Offset: 0x1AB591 VA: 0x1AB490
	// RVA: 0x258DC20 Offset: 0x258DD21 VA: 0x258DC20
	public Vector3 get_pullBodyOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB4A0 Offset: 0x1AB5A1 VA: 0x1AB4A0
	// RVA: 0x258DC30 Offset: 0x258DD31 VA: 0x258DC30
	private void set_pullBodyOffset(Vector3 value) { }

	// RVA: 0x258DA30 Offset: 0x258DB31 VA: 0x258DA30
	private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation) { }

	// RVA: 0x258D850 Offset: 0x258D951 VA: 0x258D850
	private static Transform GetLeftClavicle(BipedReferences references) { }

	// RVA: 0x258D910 Offset: 0x258DA11 VA: 0x258D910
	private static Transform GetRightClavicle(BipedReferences references) { }

	// RVA: 0x258DC40 Offset: 0x258DD41 VA: 0x258DC40
	private static bool Contains(Transform[] array, Transform transform) { }

	// RVA: 0x258DD10 Offset: 0x258DE11 VA: 0x258DD10 Slot: 12
	protected override void ReadPose() { }

	// RVA: 0x258DE60 Offset: 0x258DF61 VA: 0x258DE60
	private void PullBody() { }

	// RVA: 0x258E010 Offset: 0x258E111 VA: 0x258E010
	private Vector3 GetBodyOffset() { }

	// RVA: 0x258E250 Offset: 0x258E351 VA: 0x258E250
	private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset) { }

	// RVA: 0x258E450 Offset: 0x258E551 VA: 0x258E450 Slot: 14
	protected override void ApplyBendConstraints() { }

	// RVA: 0x258E9E0 Offset: 0x258EAE1 VA: 0x258E9E0 Slot: 15
	protected override void WritePose() { }

	// RVA: 0x258EAE0 Offset: 0x258EBE1 VA: 0x258EAE0
	public void .ctor() { }
}

[Serializable]
public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 9485
{
	// Fields
	public Transform rootNode; // 0xD0
	[RangeAttribute] // RVA: 0x17B1B0 Offset: 0x17B2B1 VA: 0x17B1B0
	public float spineStiffness; // 0xD8
	[RangeAttribute] // RVA: 0x17B1D0 Offset: 0x17B2D1 VA: 0x17B1D0
	public float pullBodyVertical; // 0xDC
	[RangeAttribute] // RVA: 0x17B1F0 Offset: 0x17B2F1 VA: 0x17B1F0
	public float pullBodyHorizontal; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x17B210 Offset: 0x17B311 VA: 0x17B210
	private Vector3 <pullBodyOffset>k__BackingField; // 0xE4
	private Vector3 offset; // 0xF0

	// Properties
	public IKEffector bodyEffector { get; }
	public IKEffector leftShoulderEffector { get; }
	public IKEffector rightShoulderEffector { get; }
	public IKEffector leftThighEffector { get; }
	public IKEffector rightThighEffector { get; }
	public IKEffector leftHandEffector { get; }
	public IKEffector rightHandEffector { get; }
	public IKEffector leftFootEffector { get; }
	public IKEffector rightFootEffector { get; }
	public FBIKChain leftArmChain { get; }
	public FBIKChain rightArmChain { get; }
	public FBIKChain leftLegChain { get; }
	public FBIKChain rightLegChain { get; }
	public IKMappingLimb leftArmMapping { get; }
	public IKMappingLimb rightArmMapping { get; }
	public IKMappingLimb leftLegMapping { get; }
	public IKMappingLimb rightLegMapping { get; }
	public IKMappingBone headMapping { get; }
	public Vector3 pullBodyOffset { get; set; }

	// Methods

	// RVA: 0x258B170 Offset: 0x258B271 VA: 0x258B170
	public IKEffector get_bodyEffector() { }

	// RVA: 0x258B320 Offset: 0x258B421 VA: 0x258B320
	public IKEffector get_leftShoulderEffector() { }

	// RVA: 0x258B360 Offset: 0x258B461 VA: 0x258B360
	public IKEffector get_rightShoulderEffector() { }

	// RVA: 0x258B3A0 Offset: 0x258B4A1 VA: 0x258B3A0
	public IKEffector get_leftThighEffector() { }

	// RVA: 0x258B3E0 Offset: 0x258B4E1 VA: 0x258B3E0
	public IKEffector get_rightThighEffector() { }

	// RVA: 0x258B420 Offset: 0x258B521 VA: 0x258B420
	public IKEffector get_leftHandEffector() { }

	// RVA: 0x258B460 Offset: 0x258B561 VA: 0x258B460
	public IKEffector get_rightHandEffector() { }

	// RVA: 0x258B4A0 Offset: 0x258B5A1 VA: 0x258B4A0
	public IKEffector get_leftFootEffector() { }

	// RVA: 0x258B4E0 Offset: 0x258B5E1 VA: 0x258B4E0
	public IKEffector get_rightFootEffector() { }

	// RVA: 0x258B520 Offset: 0x258B621 VA: 0x258B520
	public FBIKChain get_leftArmChain() { }

	// RVA: 0x258B560 Offset: 0x258B661 VA: 0x258B560
	public FBIKChain get_rightArmChain() { }

	// RVA: 0x258B5A0 Offset: 0x258B6A1 VA: 0x258B5A0
	public FBIKChain get_leftLegChain() { }

	// RVA: 0x258B5E0 Offset: 0x258B6E1 VA: 0x258B5E0
	public FBIKChain get_rightLegChain() { }

	// RVA: 0x258B620 Offset: 0x258B721 VA: 0x258B620
	public IKMappingLimb get_leftArmMapping() { }

	// RVA: 0x258B660 Offset: 0x258B761 VA: 0x258B660
	public IKMappingLimb get_rightArmMapping() { }

	// RVA: 0x258B6A0 Offset: 0x258B7A1 VA: 0x258B6A0
	public IKMappingLimb get_leftLegMapping() { }

	// RVA: 0x258B6E0 Offset: 0x258B7E1 VA: 0x258B6E0
	public IKMappingLimb get_rightLegMapping() { }

	// RVA: 0x258B720 Offset: 0x258B821 VA: 0x258B720
	public IKMappingBone get_headMapping() { }

	// RVA: 0x258B760 Offset: 0x258B861 VA: 0x258B760
	public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0) { }

	// RVA: 0x258B890 Offset: 0x258B991 VA: 0x258B890
	public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight) { }

	// RVA: 0x258B7C0 Offset: 0x258B8C1 VA: 0x258B7C0
	public FBIKChain GetChain(FullBodyBipedChain c) { }

	// RVA: 0x258B970 Offset: 0x258BA71 VA: 0x258B970
	public FBIKChain GetChain(FullBodyBipedEffector effector) { }

	// RVA: 0x258B1B0 Offset: 0x258B2B1 VA: 0x258B1B0
	public IKEffector GetEffector(FullBodyBipedEffector effector) { }

	// RVA: 0x258BAC0 Offset: 0x258BBC1 VA: 0x258BAC0
	public IKEffector GetEndEffector(FullBodyBipedChain c) { }

	// RVA: 0x258BB90 Offset: 0x258BC91 VA: 0x258BB90
	public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain) { }

	// RVA: 0x258BC60 Offset: 0x258BD61 VA: 0x258BC60
	public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector) { }

	// RVA: 0x258BD80 Offset: 0x258BE81 VA: 0x258BD80
	public IKMappingSpine GetSpineMapping() { }

	// RVA: 0x258BD90 Offset: 0x258BE91 VA: 0x258BD90
	public IKMappingBone GetHeadMapping() { }

	// RVA: 0x258BDD0 Offset: 0x258BED1 VA: 0x258BDD0
	public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb) { }

	// RVA: 0x258BEA0 Offset: 0x258BFA1 VA: 0x258BEA0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x258C040 Offset: 0x258C141 VA: 0x258C040
	public void SetToReferences(BipedReferences references, Transform rootNode) { }

	// RVA: 0x258D530 Offset: 0x258D631 VA: 0x258D530
	public static Transform DetectRootNodeBone(BipedReferences references) { }

	// RVA: 0x258D9D0 Offset: 0x258DAD1 VA: 0x258D9D0
	public void SetLimbOrientations(BipedLimbOrientations o) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB490 Offset: 0x1AB591 VA: 0x1AB490
	// RVA: 0x258DC20 Offset: 0x258DD21 VA: 0x258DC20
	public Vector3 get_pullBodyOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB4A0 Offset: 0x1AB5A1 VA: 0x1AB4A0
	// RVA: 0x258DC30 Offset: 0x258DD31 VA: 0x258DC30
	private void set_pullBodyOffset(Vector3 value) { }

	// RVA: 0x258DA30 Offset: 0x258DB31 VA: 0x258DA30
	private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation) { }

	// RVA: 0x258D850 Offset: 0x258D951 VA: 0x258D850
	private static Transform GetLeftClavicle(BipedReferences references) { }

	// RVA: 0x258D910 Offset: 0x258DA11 VA: 0x258D910
	private static Transform GetRightClavicle(BipedReferences references) { }

	// RVA: 0x258DC40 Offset: 0x258DD41 VA: 0x258DC40
	private static bool Contains(Transform[] array, Transform transform) { }

	// RVA: 0x258DD10 Offset: 0x258DE11 VA: 0x258DD10 Slot: 12
	protected override void ReadPose() { }

	// RVA: 0x258DE60 Offset: 0x258DF61 VA: 0x258DE60
	private void PullBody() { }

	// RVA: 0x258E010 Offset: 0x258E111 VA: 0x258E010
	private Vector3 GetBodyOffset() { }

	// RVA: 0x258E250 Offset: 0x258E351 VA: 0x258E250
	private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset) { }

	// RVA: 0x258E450 Offset: 0x258E551 VA: 0x258E450 Slot: 14
	protected override void ApplyBendConstraints() { }

	// RVA: 0x258E9E0 Offset: 0x258EAE1 VA: 0x258E9E0 Slot: 15
	protected override void WritePose() { }

	// RVA: 0x258EAE0 Offset: 0x258EBE1 VA: 0x258EAE0
	public void .ctor() { }
}

[Serializable]
public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 9485
{
	// Fields
	public Transform rootNode; // 0xD0
	[RangeAttribute] // RVA: 0x17B1B0 Offset: 0x17B2B1 VA: 0x17B1B0
	public float spineStiffness; // 0xD8
	[RangeAttribute] // RVA: 0x17B1D0 Offset: 0x17B2D1 VA: 0x17B1D0
	public float pullBodyVertical; // 0xDC
	[RangeAttribute] // RVA: 0x17B1F0 Offset: 0x17B2F1 VA: 0x17B1F0
	public float pullBodyHorizontal; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x17B210 Offset: 0x17B311 VA: 0x17B210
	private Vector3 <pullBodyOffset>k__BackingField; // 0xE4
	private Vector3 offset; // 0xF0

	// Properties
	public IKEffector bodyEffector { get; }
	public IKEffector leftShoulderEffector { get; }
	public IKEffector rightShoulderEffector { get; }
	public IKEffector leftThighEffector { get; }
	public IKEffector rightThighEffector { get; }
	public IKEffector leftHandEffector { get; }
	public IKEffector rightHandEffector { get; }
	public IKEffector leftFootEffector { get; }
	public IKEffector rightFootEffector { get; }
	public FBIKChain leftArmChain { get; }
	public FBIKChain rightArmChain { get; }
	public FBIKChain leftLegChain { get; }
	public FBIKChain rightLegChain { get; }
	public IKMappingLimb leftArmMapping { get; }
	public IKMappingLimb rightArmMapping { get; }
	public IKMappingLimb leftLegMapping { get; }
	public IKMappingLimb rightLegMapping { get; }
	public IKMappingBone headMapping { get; }
	public Vector3 pullBodyOffset { get; set; }

	// Methods

	// RVA: 0x258B170 Offset: 0x258B271 VA: 0x258B170
	public IKEffector get_bodyEffector() { }

	// RVA: 0x258B320 Offset: 0x258B421 VA: 0x258B320
	public IKEffector get_leftShoulderEffector() { }

	// RVA: 0x258B360 Offset: 0x258B461 VA: 0x258B360
	public IKEffector get_rightShoulderEffector() { }

	// RVA: 0x258B3A0 Offset: 0x258B4A1 VA: 0x258B3A0
	public IKEffector get_leftThighEffector() { }

	// RVA: 0x258B3E0 Offset: 0x258B4E1 VA: 0x258B3E0
	public IKEffector get_rightThighEffector() { }

	// RVA: 0x258B420 Offset: 0x258B521 VA: 0x258B420
	public IKEffector get_leftHandEffector() { }

	// RVA: 0x258B460 Offset: 0x258B561 VA: 0x258B460
	public IKEffector get_rightHandEffector() { }

	// RVA: 0x258B4A0 Offset: 0x258B5A1 VA: 0x258B4A0
	public IKEffector get_leftFootEffector() { }

	// RVA: 0x258B4E0 Offset: 0x258B5E1 VA: 0x258B4E0
	public IKEffector get_rightFootEffector() { }

	// RVA: 0x258B520 Offset: 0x258B621 VA: 0x258B520
	public FBIKChain get_leftArmChain() { }

	// RVA: 0x258B560 Offset: 0x258B661 VA: 0x258B560
	public FBIKChain get_rightArmChain() { }

	// RVA: 0x258B5A0 Offset: 0x258B6A1 VA: 0x258B5A0
	public FBIKChain get_leftLegChain() { }

	// RVA: 0x258B5E0 Offset: 0x258B6E1 VA: 0x258B5E0
	public FBIKChain get_rightLegChain() { }

	// RVA: 0x258B620 Offset: 0x258B721 VA: 0x258B620
	public IKMappingLimb get_leftArmMapping() { }

	// RVA: 0x258B660 Offset: 0x258B761 VA: 0x258B660
	public IKMappingLimb get_rightArmMapping() { }

	// RVA: 0x258B6A0 Offset: 0x258B7A1 VA: 0x258B6A0
	public IKMappingLimb get_leftLegMapping() { }

	// RVA: 0x258B6E0 Offset: 0x258B7E1 VA: 0x258B6E0
	public IKMappingLimb get_rightLegMapping() { }

	// RVA: 0x258B720 Offset: 0x258B821 VA: 0x258B720
	public IKMappingBone get_headMapping() { }

	// RVA: 0x258B760 Offset: 0x258B861 VA: 0x258B760
	public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0) { }

	// RVA: 0x258B890 Offset: 0x258B991 VA: 0x258B890
	public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight) { }

	// RVA: 0x258B7C0 Offset: 0x258B8C1 VA: 0x258B7C0
	public FBIKChain GetChain(FullBodyBipedChain c) { }

	// RVA: 0x258B970 Offset: 0x258BA71 VA: 0x258B970
	public FBIKChain GetChain(FullBodyBipedEffector effector) { }

	// RVA: 0x258B1B0 Offset: 0x258B2B1 VA: 0x258B1B0
	public IKEffector GetEffector(FullBodyBipedEffector effector) { }

	// RVA: 0x258BAC0 Offset: 0x258BBC1 VA: 0x258BAC0
	public IKEffector GetEndEffector(FullBodyBipedChain c) { }

	// RVA: 0x258BB90 Offset: 0x258BC91 VA: 0x258BB90
	public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain) { }

	// RVA: 0x258BC60 Offset: 0x258BD61 VA: 0x258BC60
	public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector) { }

	// RVA: 0x258BD80 Offset: 0x258BE81 VA: 0x258BD80
	public IKMappingSpine GetSpineMapping() { }

	// RVA: 0x258BD90 Offset: 0x258BE91 VA: 0x258BD90
	public IKMappingBone GetHeadMapping() { }

	// RVA: 0x258BDD0 Offset: 0x258BED1 VA: 0x258BDD0
	public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb) { }

	// RVA: 0x258BEA0 Offset: 0x258BFA1 VA: 0x258BEA0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x258C040 Offset: 0x258C141 VA: 0x258C040
	public void SetToReferences(BipedReferences references, Transform rootNode) { }

	// RVA: 0x258D530 Offset: 0x258D631 VA: 0x258D530
	public static Transform DetectRootNodeBone(BipedReferences references) { }

	// RVA: 0x258D9D0 Offset: 0x258DAD1 VA: 0x258D9D0
	public void SetLimbOrientations(BipedLimbOrientations o) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB490 Offset: 0x1AB591 VA: 0x1AB490
	// RVA: 0x258DC20 Offset: 0x258DD21 VA: 0x258DC20
	public Vector3 get_pullBodyOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB4A0 Offset: 0x1AB5A1 VA: 0x1AB4A0
	// RVA: 0x258DC30 Offset: 0x258DD31 VA: 0x258DC30
	private void set_pullBodyOffset(Vector3 value) { }

	// RVA: 0x258DA30 Offset: 0x258DB31 VA: 0x258DA30
	private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation) { }

	// RVA: 0x258D850 Offset: 0x258D951 VA: 0x258D850
	private static Transform GetLeftClavicle(BipedReferences references) { }

	// RVA: 0x258D910 Offset: 0x258DA11 VA: 0x258D910
	private static Transform GetRightClavicle(BipedReferences references) { }

	// RVA: 0x258DC40 Offset: 0x258DD41 VA: 0x258DC40
	private static bool Contains(Transform[] array, Transform transform) { }

	// RVA: 0x258DD10 Offset: 0x258DE11 VA: 0x258DD10 Slot: 12
	protected override void ReadPose() { }

	// RVA: 0x258DE60 Offset: 0x258DF61 VA: 0x258DE60
	private void PullBody() { }

	// RVA: 0x258E010 Offset: 0x258E111 VA: 0x258E010
	private Vector3 GetBodyOffset() { }

	// RVA: 0x258E250 Offset: 0x258E351 VA: 0x258E250
	private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset) { }

	// RVA: 0x258E450 Offset: 0x258E551 VA: 0x258E450 Slot: 14
	protected override void ApplyBendConstraints() { }

	// RVA: 0x258E9E0 Offset: 0x258EAE1 VA: 0x258E9E0 Slot: 15
	protected override void WritePose() { }

	// RVA: 0x258EAE0 Offset: 0x258EBE1 VA: 0x258EAE0
	public void .ctor() { }
}

[Serializable]
public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 9485
{
	// Fields
	public Transform rootNode; // 0xD0
	[RangeAttribute] // RVA: 0x17B1B0 Offset: 0x17B2B1 VA: 0x17B1B0
	public float spineStiffness; // 0xD8
	[RangeAttribute] // RVA: 0x17B1D0 Offset: 0x17B2D1 VA: 0x17B1D0
	public float pullBodyVertical; // 0xDC
	[RangeAttribute] // RVA: 0x17B1F0 Offset: 0x17B2F1 VA: 0x17B1F0
	public float pullBodyHorizontal; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x17B210 Offset: 0x17B311 VA: 0x17B210
	private Vector3 <pullBodyOffset>k__BackingField; // 0xE4
	private Vector3 offset; // 0xF0

	// Properties
	public IKEffector bodyEffector { get; }
	public IKEffector leftShoulderEffector { get; }
	public IKEffector rightShoulderEffector { get; }
	public IKEffector leftThighEffector { get; }
	public IKEffector rightThighEffector { get; }
	public IKEffector leftHandEffector { get; }
	public IKEffector rightHandEffector { get; }
	public IKEffector leftFootEffector { get; }
	public IKEffector rightFootEffector { get; }
	public FBIKChain leftArmChain { get; }
	public FBIKChain rightArmChain { get; }
	public FBIKChain leftLegChain { get; }
	public FBIKChain rightLegChain { get; }
	public IKMappingLimb leftArmMapping { get; }
	public IKMappingLimb rightArmMapping { get; }
	public IKMappingLimb leftLegMapping { get; }
	public IKMappingLimb rightLegMapping { get; }
	public IKMappingBone headMapping { get; }
	public Vector3 pullBodyOffset { get; set; }

	// Methods

	// RVA: 0x258B170 Offset: 0x258B271 VA: 0x258B170
	public IKEffector get_bodyEffector() { }

	// RVA: 0x258B320 Offset: 0x258B421 VA: 0x258B320
	public IKEffector get_leftShoulderEffector() { }

	// RVA: 0x258B360 Offset: 0x258B461 VA: 0x258B360
	public IKEffector get_rightShoulderEffector() { }

	// RVA: 0x258B3A0 Offset: 0x258B4A1 VA: 0x258B3A0
	public IKEffector get_leftThighEffector() { }

	// RVA: 0x258B3E0 Offset: 0x258B4E1 VA: 0x258B3E0
	public IKEffector get_rightThighEffector() { }

	// RVA: 0x258B420 Offset: 0x258B521 VA: 0x258B420
	public IKEffector get_leftHandEffector() { }

	// RVA: 0x258B460 Offset: 0x258B561 VA: 0x258B460
	public IKEffector get_rightHandEffector() { }

	// RVA: 0x258B4A0 Offset: 0x258B5A1 VA: 0x258B4A0
	public IKEffector get_leftFootEffector() { }

	// RVA: 0x258B4E0 Offset: 0x258B5E1 VA: 0x258B4E0
	public IKEffector get_rightFootEffector() { }

	// RVA: 0x258B520 Offset: 0x258B621 VA: 0x258B520
	public FBIKChain get_leftArmChain() { }

	// RVA: 0x258B560 Offset: 0x258B661 VA: 0x258B560
	public FBIKChain get_rightArmChain() { }

	// RVA: 0x258B5A0 Offset: 0x258B6A1 VA: 0x258B5A0
	public FBIKChain get_leftLegChain() { }

	// RVA: 0x258B5E0 Offset: 0x258B6E1 VA: 0x258B5E0
	public FBIKChain get_rightLegChain() { }

	// RVA: 0x258B620 Offset: 0x258B721 VA: 0x258B620
	public IKMappingLimb get_leftArmMapping() { }

	// RVA: 0x258B660 Offset: 0x258B761 VA: 0x258B660
	public IKMappingLimb get_rightArmMapping() { }

	// RVA: 0x258B6A0 Offset: 0x258B7A1 VA: 0x258B6A0
	public IKMappingLimb get_leftLegMapping() { }

	// RVA: 0x258B6E0 Offset: 0x258B7E1 VA: 0x258B6E0
	public IKMappingLimb get_rightLegMapping() { }

	// RVA: 0x258B720 Offset: 0x258B821 VA: 0x258B720
	public IKMappingBone get_headMapping() { }

	// RVA: 0x258B760 Offset: 0x258B861 VA: 0x258B760
	public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0) { }

	// RVA: 0x258B890 Offset: 0x258B991 VA: 0x258B890
	public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight) { }

	// RVA: 0x258B7C0 Offset: 0x258B8C1 VA: 0x258B7C0
	public FBIKChain GetChain(FullBodyBipedChain c) { }

	// RVA: 0x258B970 Offset: 0x258BA71 VA: 0x258B970
	public FBIKChain GetChain(FullBodyBipedEffector effector) { }

	// RVA: 0x258B1B0 Offset: 0x258B2B1 VA: 0x258B1B0
	public IKEffector GetEffector(FullBodyBipedEffector effector) { }

	// RVA: 0x258BAC0 Offset: 0x258BBC1 VA: 0x258BAC0
	public IKEffector GetEndEffector(FullBodyBipedChain c) { }

	// RVA: 0x258BB90 Offset: 0x258BC91 VA: 0x258BB90
	public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain) { }

	// RVA: 0x258BC60 Offset: 0x258BD61 VA: 0x258BC60
	public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector) { }

	// RVA: 0x258BD80 Offset: 0x258BE81 VA: 0x258BD80
	public IKMappingSpine GetSpineMapping() { }

	// RVA: 0x258BD90 Offset: 0x258BE91 VA: 0x258BD90
	public IKMappingBone GetHeadMapping() { }

	// RVA: 0x258BDD0 Offset: 0x258BED1 VA: 0x258BDD0
	public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb) { }

	// RVA: 0x258BEA0 Offset: 0x258BFA1 VA: 0x258BEA0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x258C040 Offset: 0x258C141 VA: 0x258C040
	public void SetToReferences(BipedReferences references, Transform rootNode) { }

	// RVA: 0x258D530 Offset: 0x258D631 VA: 0x258D530
	public static Transform DetectRootNodeBone(BipedReferences references) { }

	// RVA: 0x258D9D0 Offset: 0x258DAD1 VA: 0x258D9D0
	public void SetLimbOrientations(BipedLimbOrientations o) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB490 Offset: 0x1AB591 VA: 0x1AB490
	// RVA: 0x258DC20 Offset: 0x258DD21 VA: 0x258DC20
	public Vector3 get_pullBodyOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB4A0 Offset: 0x1AB5A1 VA: 0x1AB4A0
	// RVA: 0x258DC30 Offset: 0x258DD31 VA: 0x258DC30
	private void set_pullBodyOffset(Vector3 value) { }

	// RVA: 0x258DA30 Offset: 0x258DB31 VA: 0x258DA30
	private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation) { }

	// RVA: 0x258D850 Offset: 0x258D951 VA: 0x258D850
	private static Transform GetLeftClavicle(BipedReferences references) { }

	// RVA: 0x258D910 Offset: 0x258DA11 VA: 0x258D910
	private static Transform GetRightClavicle(BipedReferences references) { }

	// RVA: 0x258DC40 Offset: 0x258DD41 VA: 0x258DC40
	private static bool Contains(Transform[] array, Transform transform) { }

	// RVA: 0x258DD10 Offset: 0x258DE11 VA: 0x258DD10 Slot: 12
	protected override void ReadPose() { }

	// RVA: 0x258DE60 Offset: 0x258DF61 VA: 0x258DE60
	private void PullBody() { }

	// RVA: 0x258E010 Offset: 0x258E111 VA: 0x258E010
	private Vector3 GetBodyOffset() { }

	// RVA: 0x258E250 Offset: 0x258E351 VA: 0x258E250
	private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset) { }

	// RVA: 0x258E450 Offset: 0x258E551 VA: 0x258E450 Slot: 14
	protected override void ApplyBendConstraints() { }

	// RVA: 0x258E9E0 Offset: 0x258EAE1 VA: 0x258E9E0 Slot: 15
	protected override void WritePose() { }

	// RVA: 0x258EAE0 Offset: 0x258EBE1 VA: 0x258EAE0
	public void .ctor() { }
}

[Serializable]
public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 9485
{
	// Fields
	public Transform rootNode; // 0xD0
	[RangeAttribute] // RVA: 0x17B1B0 Offset: 0x17B2B1 VA: 0x17B1B0
	public float spineStiffness; // 0xD8
	[RangeAttribute] // RVA: 0x17B1D0 Offset: 0x17B2D1 VA: 0x17B1D0
	public float pullBodyVertical; // 0xDC
	[RangeAttribute] // RVA: 0x17B1F0 Offset: 0x17B2F1 VA: 0x17B1F0
	public float pullBodyHorizontal; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x17B210 Offset: 0x17B311 VA: 0x17B210
	private Vector3 <pullBodyOffset>k__BackingField; // 0xE4
	private Vector3 offset; // 0xF0

	// Properties
	public IKEffector bodyEffector { get; }
	public IKEffector leftShoulderEffector { get; }
	public IKEffector rightShoulderEffector { get; }
	public IKEffector leftThighEffector { get; }
	public IKEffector rightThighEffector { get; }
	public IKEffector leftHandEffector { get; }
	public IKEffector rightHandEffector { get; }
	public IKEffector leftFootEffector { get; }
	public IKEffector rightFootEffector { get; }
	public FBIKChain leftArmChain { get; }
	public FBIKChain rightArmChain { get; }
	public FBIKChain leftLegChain { get; }
	public FBIKChain rightLegChain { get; }
	public IKMappingLimb leftArmMapping { get; }
	public IKMappingLimb rightArmMapping { get; }
	public IKMappingLimb leftLegMapping { get; }
	public IKMappingLimb rightLegMapping { get; }
	public IKMappingBone headMapping { get; }
	public Vector3 pullBodyOffset { get; set; }

	// Methods

	// RVA: 0x258B170 Offset: 0x258B271 VA: 0x258B170
	public IKEffector get_bodyEffector() { }

	// RVA: 0x258B320 Offset: 0x258B421 VA: 0x258B320
	public IKEffector get_leftShoulderEffector() { }

	// RVA: 0x258B360 Offset: 0x258B461 VA: 0x258B360
	public IKEffector get_rightShoulderEffector() { }

	// RVA: 0x258B3A0 Offset: 0x258B4A1 VA: 0x258B3A0
	public IKEffector get_leftThighEffector() { }

	// RVA: 0x258B3E0 Offset: 0x258B4E1 VA: 0x258B3E0
	public IKEffector get_rightThighEffector() { }

	// RVA: 0x258B420 Offset: 0x258B521 VA: 0x258B420
	public IKEffector get_leftHandEffector() { }

	// RVA: 0x258B460 Offset: 0x258B561 VA: 0x258B460
	public IKEffector get_rightHandEffector() { }

	// RVA: 0x258B4A0 Offset: 0x258B5A1 VA: 0x258B4A0
	public IKEffector get_leftFootEffector() { }

	// RVA: 0x258B4E0 Offset: 0x258B5E1 VA: 0x258B4E0
	public IKEffector get_rightFootEffector() { }

	// RVA: 0x258B520 Offset: 0x258B621 VA: 0x258B520
	public FBIKChain get_leftArmChain() { }

	// RVA: 0x258B560 Offset: 0x258B661 VA: 0x258B560
	public FBIKChain get_rightArmChain() { }

	// RVA: 0x258B5A0 Offset: 0x258B6A1 VA: 0x258B5A0
	public FBIKChain get_leftLegChain() { }

	// RVA: 0x258B5E0 Offset: 0x258B6E1 VA: 0x258B5E0
	public FBIKChain get_rightLegChain() { }

	// RVA: 0x258B620 Offset: 0x258B721 VA: 0x258B620
	public IKMappingLimb get_leftArmMapping() { }

	// RVA: 0x258B660 Offset: 0x258B761 VA: 0x258B660
	public IKMappingLimb get_rightArmMapping() { }

	// RVA: 0x258B6A0 Offset: 0x258B7A1 VA: 0x258B6A0
	public IKMappingLimb get_leftLegMapping() { }

	// RVA: 0x258B6E0 Offset: 0x258B7E1 VA: 0x258B6E0
	public IKMappingLimb get_rightLegMapping() { }

	// RVA: 0x258B720 Offset: 0x258B821 VA: 0x258B720
	public IKMappingBone get_headMapping() { }

	// RVA: 0x258B760 Offset: 0x258B861 VA: 0x258B760
	public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0) { }

	// RVA: 0x258B890 Offset: 0x258B991 VA: 0x258B890
	public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight) { }

	// RVA: 0x258B7C0 Offset: 0x258B8C1 VA: 0x258B7C0
	public FBIKChain GetChain(FullBodyBipedChain c) { }

	// RVA: 0x258B970 Offset: 0x258BA71 VA: 0x258B970
	public FBIKChain GetChain(FullBodyBipedEffector effector) { }

	// RVA: 0x258B1B0 Offset: 0x258B2B1 VA: 0x258B1B0
	public IKEffector GetEffector(FullBodyBipedEffector effector) { }

	// RVA: 0x258BAC0 Offset: 0x258BBC1 VA: 0x258BAC0
	public IKEffector GetEndEffector(FullBodyBipedChain c) { }

	// RVA: 0x258BB90 Offset: 0x258BC91 VA: 0x258BB90
	public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain) { }

	// RVA: 0x258BC60 Offset: 0x258BD61 VA: 0x258BC60
	public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector) { }

	// RVA: 0x258BD80 Offset: 0x258BE81 VA: 0x258BD80
	public IKMappingSpine GetSpineMapping() { }

	// RVA: 0x258BD90 Offset: 0x258BE91 VA: 0x258BD90
	public IKMappingBone GetHeadMapping() { }

	// RVA: 0x258BDD0 Offset: 0x258BED1 VA: 0x258BDD0
	public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb) { }

	// RVA: 0x258BEA0 Offset: 0x258BFA1 VA: 0x258BEA0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x258C040 Offset: 0x258C141 VA: 0x258C040
	public void SetToReferences(BipedReferences references, Transform rootNode) { }

	// RVA: 0x258D530 Offset: 0x258D631 VA: 0x258D530
	public static Transform DetectRootNodeBone(BipedReferences references) { }

	// RVA: 0x258D9D0 Offset: 0x258DAD1 VA: 0x258D9D0
	public void SetLimbOrientations(BipedLimbOrientations o) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB490 Offset: 0x1AB591 VA: 0x1AB490
	// RVA: 0x258DC20 Offset: 0x258DD21 VA: 0x258DC20
	public Vector3 get_pullBodyOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB4A0 Offset: 0x1AB5A1 VA: 0x1AB4A0
	// RVA: 0x258DC30 Offset: 0x258DD31 VA: 0x258DC30
	private void set_pullBodyOffset(Vector3 value) { }

	// RVA: 0x258DA30 Offset: 0x258DB31 VA: 0x258DA30
	private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation) { }

	// RVA: 0x258D850 Offset: 0x258D951 VA: 0x258D850
	private static Transform GetLeftClavicle(BipedReferences references) { }

	// RVA: 0x258D910 Offset: 0x258DA11 VA: 0x258D910
	private static Transform GetRightClavicle(BipedReferences references) { }

	// RVA: 0x258DC40 Offset: 0x258DD41 VA: 0x258DC40
	private static bool Contains(Transform[] array, Transform transform) { }

	// RVA: 0x258DD10 Offset: 0x258DE11 VA: 0x258DD10 Slot: 12
	protected override void ReadPose() { }

	// RVA: 0x258DE60 Offset: 0x258DF61 VA: 0x258DE60
	private void PullBody() { }

	// RVA: 0x258E010 Offset: 0x258E111 VA: 0x258E010
	private Vector3 GetBodyOffset() { }

	// RVA: 0x258E250 Offset: 0x258E351 VA: 0x258E250
	private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset) { }

	// RVA: 0x258E450 Offset: 0x258E551 VA: 0x258E450 Slot: 14
	protected override void ApplyBendConstraints() { }

	// RVA: 0x258E9E0 Offset: 0x258EAE1 VA: 0x258E9E0 Slot: 15
	protected override void WritePose() { }

	// RVA: 0x258EAE0 Offset: 0x258EBE1 VA: 0x258EAE0
	public void .ctor() { }
}

