[Serializable]
public class IKMappingLimb : IKMapping // TypeDefIndex: 9468
{
	// Fields
	public Transform parentBone; // 0x10
	public Transform bone1; // 0x18
	public Transform bone2; // 0x20
	public Transform bone3; // 0x28
	[RangeAttribute] // RVA: 0x17AFB0 Offset: 0x17B0B1 VA: 0x17AFB0
	public float maintainRotationWeight; // 0x30
	[RangeAttribute] // RVA: 0x17AFD0 Offset: 0x17B0D1 VA: 0x17AFD0
	public float weight; // 0x34
	public bool updatePlaneRotations; // 0x38
	private IKMapping.BoneMap boneMapParent; // 0x40
	private IKMapping.BoneMap boneMap1; // 0x48
	private IKMapping.BoneMap boneMap2; // 0x50
	private IKMapping.BoneMap boneMap3; // 0x58

	// Methods

	// RVA: 0x257D0A0 Offset: 0x257D1A1 VA: 0x257D0A0 Slot: 4
	public override bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x257D150 Offset: 0x257D251 VA: 0x257D150
	public IKMapping.BoneMap GetBoneMap(IKMappingLimb.BoneMapType boneMap) { }

	// RVA: 0x257D230 Offset: 0x257D331 VA: 0x257D230
	public void SetLimbOrientation(Vector3 upper, Vector3 lower) { }

	// RVA: 0x257D5A0 Offset: 0x257D6A1 VA: 0x257D5A0
	public void .ctor() { }

	// RVA: 0x257D6A0 Offset: 0x257D7A1 VA: 0x257D6A0
	public void .ctor(Transform bone1, Transform bone2, Transform bone3, Transform parentBone) { }

	// RVA: 0x257D800 Offset: 0x257D901 VA: 0x257D800
	public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone) { }

	// RVA: 0x257D870 Offset: 0x257D971 VA: 0x257D870
	public void StoreDefaultLocalState() { }

	// RVA: 0x257D930 Offset: 0x257DA31 VA: 0x257D930
	public void FixTransforms() { }

	// RVA: 0x257DA00 Offset: 0x257DB01 VA: 0x257DA00 Slot: 5
	public override void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x257DCD0 Offset: 0x257DDD1 VA: 0x257DCD0
	public void ReadPose() { }

	// RVA: 0x257DDA0 Offset: 0x257DEA1 VA: 0x257DDA0
	public void WritePose(IKSolverFullBody solver, bool fullBody) { }
}

