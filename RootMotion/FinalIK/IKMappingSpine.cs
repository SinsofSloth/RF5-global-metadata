[Serializable]
public class IKMappingSpine : IKMapping // TypeDefIndex: 9470
{
	// Fields
	public Transform[] spineBones; // 0x10
	public Transform leftUpperArmBone; // 0x18
	public Transform rightUpperArmBone; // 0x20
	public Transform leftThighBone; // 0x28
	public Transform rightThighBone; // 0x30
	[RangeAttribute] // RVA: 0x17AFF0 Offset: 0x17B0F1 VA: 0x17AFF0
	public int iterations; // 0x38
	[RangeAttribute] // RVA: 0x17B010 Offset: 0x17B111 VA: 0x17B010
	public float twistWeight; // 0x3C
	private int rootNodeIndex; // 0x40
	private IKMapping.BoneMap[] spine; // 0x48
	private IKMapping.BoneMap leftUpperArm; // 0x50
	private IKMapping.BoneMap rightUpperArm; // 0x58
	private IKMapping.BoneMap leftThigh; // 0x60
	private IKMapping.BoneMap rightThigh; // 0x68
	private bool useFABRIK; // 0x70

	// Methods

	// RVA: 0x257DF70 Offset: 0x257E071 VA: 0x257DF70 Slot: 4
	public override bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x257E270 Offset: 0x257E371 VA: 0x257E270
	public void .ctor() { }

	// RVA: 0x257E390 Offset: 0x257E491 VA: 0x257E390
	public void .ctor(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	// RVA: 0x257E520 Offset: 0x257E621 VA: 0x257E520
	public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	// RVA: 0x257E5A0 Offset: 0x257E6A1 VA: 0x257E5A0
	public void StoreDefaultLocalState() { }

	// RVA: 0x257E610 Offset: 0x257E711 VA: 0x257E610
	public void FixTransforms() { }

	// RVA: 0x257E6A0 Offset: 0x257E7A1 VA: 0x257E6A0 Slot: 5
	public override void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x257ED90 Offset: 0x257EE91 VA: 0x257ED90
	private bool UseFABRIK() { }

	// RVA: 0x257EDD0 Offset: 0x257EED1 VA: 0x257EDD0
	public void ReadPose() { }

	// RVA: 0x257F0D0 Offset: 0x257F1D1 VA: 0x257F0D0
	public void WritePose(IKSolverFullBody solver) { }

	// RVA: 0x257F490 Offset: 0x257F591 VA: 0x257F490
	public void ForwardReach(Vector3 position) { }

	// RVA: 0x257F590 Offset: 0x257F691 VA: 0x257F590
	private void BackwardReach(Vector3 position) { }

	// RVA: 0x257F660 Offset: 0x257F761 VA: 0x257F660
	private void MapToSolverPositions(IKSolverFullBody solver) { }
}

[Serializable]
public class IKMappingSpine : IKMapping // TypeDefIndex: 9470
{
	// Fields
	public Transform[] spineBones; // 0x10
	public Transform leftUpperArmBone; // 0x18
	public Transform rightUpperArmBone; // 0x20
	public Transform leftThighBone; // 0x28
	public Transform rightThighBone; // 0x30
	[RangeAttribute] // RVA: 0x17AFF0 Offset: 0x17B0F1 VA: 0x17AFF0
	public int iterations; // 0x38
	[RangeAttribute] // RVA: 0x17B010 Offset: 0x17B111 VA: 0x17B010
	public float twistWeight; // 0x3C
	private int rootNodeIndex; // 0x40
	private IKMapping.BoneMap[] spine; // 0x48
	private IKMapping.BoneMap leftUpperArm; // 0x50
	private IKMapping.BoneMap rightUpperArm; // 0x58
	private IKMapping.BoneMap leftThigh; // 0x60
	private IKMapping.BoneMap rightThigh; // 0x68
	private bool useFABRIK; // 0x70

	// Methods

	// RVA: 0x257DF70 Offset: 0x257E071 VA: 0x257DF70 Slot: 4
	public override bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x257E270 Offset: 0x257E371 VA: 0x257E270
	public void .ctor() { }

	// RVA: 0x257E390 Offset: 0x257E491 VA: 0x257E390
	public void .ctor(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	// RVA: 0x257E520 Offset: 0x257E621 VA: 0x257E520
	public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	// RVA: 0x257E5A0 Offset: 0x257E6A1 VA: 0x257E5A0
	public void StoreDefaultLocalState() { }

	// RVA: 0x257E610 Offset: 0x257E711 VA: 0x257E610
	public void FixTransforms() { }

	// RVA: 0x257E6A0 Offset: 0x257E7A1 VA: 0x257E6A0 Slot: 5
	public override void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x257ED90 Offset: 0x257EE91 VA: 0x257ED90
	private bool UseFABRIK() { }

	// RVA: 0x257EDD0 Offset: 0x257EED1 VA: 0x257EDD0
	public void ReadPose() { }

	// RVA: 0x257F0D0 Offset: 0x257F1D1 VA: 0x257F0D0
	public void WritePose(IKSolverFullBody solver) { }

	// RVA: 0x257F490 Offset: 0x257F591 VA: 0x257F490
	public void ForwardReach(Vector3 position) { }

	// RVA: 0x257F590 Offset: 0x257F691 VA: 0x257F590
	private void BackwardReach(Vector3 position) { }

	// RVA: 0x257F660 Offset: 0x257F761 VA: 0x257F660
	private void MapToSolverPositions(IKSolverFullBody solver) { }
}

[Serializable]
public class IKMappingSpine : IKMapping // TypeDefIndex: 9470
{
	// Fields
	public Transform[] spineBones; // 0x10
	public Transform leftUpperArmBone; // 0x18
	public Transform rightUpperArmBone; // 0x20
	public Transform leftThighBone; // 0x28
	public Transform rightThighBone; // 0x30
	[RangeAttribute] // RVA: 0x17AFF0 Offset: 0x17B0F1 VA: 0x17AFF0
	public int iterations; // 0x38
	[RangeAttribute] // RVA: 0x17B010 Offset: 0x17B111 VA: 0x17B010
	public float twistWeight; // 0x3C
	private int rootNodeIndex; // 0x40
	private IKMapping.BoneMap[] spine; // 0x48
	private IKMapping.BoneMap leftUpperArm; // 0x50
	private IKMapping.BoneMap rightUpperArm; // 0x58
	private IKMapping.BoneMap leftThigh; // 0x60
	private IKMapping.BoneMap rightThigh; // 0x68
	private bool useFABRIK; // 0x70

	// Methods

	// RVA: 0x257DF70 Offset: 0x257E071 VA: 0x257DF70 Slot: 4
	public override bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x257E270 Offset: 0x257E371 VA: 0x257E270
	public void .ctor() { }

	// RVA: 0x257E390 Offset: 0x257E491 VA: 0x257E390
	public void .ctor(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	// RVA: 0x257E520 Offset: 0x257E621 VA: 0x257E520
	public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	// RVA: 0x257E5A0 Offset: 0x257E6A1 VA: 0x257E5A0
	public void StoreDefaultLocalState() { }

	// RVA: 0x257E610 Offset: 0x257E711 VA: 0x257E610
	public void FixTransforms() { }

	// RVA: 0x257E6A0 Offset: 0x257E7A1 VA: 0x257E6A0 Slot: 5
	public override void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x257ED90 Offset: 0x257EE91 VA: 0x257ED90
	private bool UseFABRIK() { }

	// RVA: 0x257EDD0 Offset: 0x257EED1 VA: 0x257EDD0
	public void ReadPose() { }

	// RVA: 0x257F0D0 Offset: 0x257F1D1 VA: 0x257F0D0
	public void WritePose(IKSolverFullBody solver) { }

	// RVA: 0x257F490 Offset: 0x257F591 VA: 0x257F490
	public void ForwardReach(Vector3 position) { }

	// RVA: 0x257F590 Offset: 0x257F691 VA: 0x257F590
	private void BackwardReach(Vector3 position) { }

	// RVA: 0x257F660 Offset: 0x257F761 VA: 0x257F660
	private void MapToSolverPositions(IKSolverFullBody solver) { }
}

[Serializable]
public class IKMappingSpine : IKMapping // TypeDefIndex: 9470
{
	// Fields
	public Transform[] spineBones; // 0x10
	public Transform leftUpperArmBone; // 0x18
	public Transform rightUpperArmBone; // 0x20
	public Transform leftThighBone; // 0x28
	public Transform rightThighBone; // 0x30
	[RangeAttribute] // RVA: 0x17AFF0 Offset: 0x17B0F1 VA: 0x17AFF0
	public int iterations; // 0x38
	[RangeAttribute] // RVA: 0x17B010 Offset: 0x17B111 VA: 0x17B010
	public float twistWeight; // 0x3C
	private int rootNodeIndex; // 0x40
	private IKMapping.BoneMap[] spine; // 0x48
	private IKMapping.BoneMap leftUpperArm; // 0x50
	private IKMapping.BoneMap rightUpperArm; // 0x58
	private IKMapping.BoneMap leftThigh; // 0x60
	private IKMapping.BoneMap rightThigh; // 0x68
	private bool useFABRIK; // 0x70

	// Methods

	// RVA: 0x257DF70 Offset: 0x257E071 VA: 0x257DF70 Slot: 4
	public override bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x257E270 Offset: 0x257E371 VA: 0x257E270
	public void .ctor() { }

	// RVA: 0x257E390 Offset: 0x257E491 VA: 0x257E390
	public void .ctor(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	// RVA: 0x257E520 Offset: 0x257E621 VA: 0x257E520
	public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	// RVA: 0x257E5A0 Offset: 0x257E6A1 VA: 0x257E5A0
	public void StoreDefaultLocalState() { }

	// RVA: 0x257E610 Offset: 0x257E711 VA: 0x257E610
	public void FixTransforms() { }

	// RVA: 0x257E6A0 Offset: 0x257E7A1 VA: 0x257E6A0 Slot: 5
	public override void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x257ED90 Offset: 0x257EE91 VA: 0x257ED90
	private bool UseFABRIK() { }

	// RVA: 0x257EDD0 Offset: 0x257EED1 VA: 0x257EDD0
	public void ReadPose() { }

	// RVA: 0x257F0D0 Offset: 0x257F1D1 VA: 0x257F0D0
	public void WritePose(IKSolverFullBody solver) { }

	// RVA: 0x257F490 Offset: 0x257F591 VA: 0x257F490
	public void ForwardReach(Vector3 position) { }

	// RVA: 0x257F590 Offset: 0x257F691 VA: 0x257F590
	private void BackwardReach(Vector3 position) { }

	// RVA: 0x257F660 Offset: 0x257F761 VA: 0x257F660
	private void MapToSolverPositions(IKSolverFullBody solver) { }
}

[Serializable]
public class IKMappingSpine : IKMapping // TypeDefIndex: 9470
{
	// Fields
	public Transform[] spineBones; // 0x10
	public Transform leftUpperArmBone; // 0x18
	public Transform rightUpperArmBone; // 0x20
	public Transform leftThighBone; // 0x28
	public Transform rightThighBone; // 0x30
	[RangeAttribute] // RVA: 0x17AFF0 Offset: 0x17B0F1 VA: 0x17AFF0
	public int iterations; // 0x38
	[RangeAttribute] // RVA: 0x17B010 Offset: 0x17B111 VA: 0x17B010
	public float twistWeight; // 0x3C
	private int rootNodeIndex; // 0x40
	private IKMapping.BoneMap[] spine; // 0x48
	private IKMapping.BoneMap leftUpperArm; // 0x50
	private IKMapping.BoneMap rightUpperArm; // 0x58
	private IKMapping.BoneMap leftThigh; // 0x60
	private IKMapping.BoneMap rightThigh; // 0x68
	private bool useFABRIK; // 0x70

	// Methods

	// RVA: 0x257DF70 Offset: 0x257E071 VA: 0x257DF70 Slot: 4
	public override bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x257E270 Offset: 0x257E371 VA: 0x257E270
	public void .ctor() { }

	// RVA: 0x257E390 Offset: 0x257E491 VA: 0x257E390
	public void .ctor(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	// RVA: 0x257E520 Offset: 0x257E621 VA: 0x257E520
	public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	// RVA: 0x257E5A0 Offset: 0x257E6A1 VA: 0x257E5A0
	public void StoreDefaultLocalState() { }

	// RVA: 0x257E610 Offset: 0x257E711 VA: 0x257E610
	public void FixTransforms() { }

	// RVA: 0x257E6A0 Offset: 0x257E7A1 VA: 0x257E6A0 Slot: 5
	public override void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x257ED90 Offset: 0x257EE91 VA: 0x257ED90
	private bool UseFABRIK() { }

	// RVA: 0x257EDD0 Offset: 0x257EED1 VA: 0x257EDD0
	public void ReadPose() { }

	// RVA: 0x257F0D0 Offset: 0x257F1D1 VA: 0x257F0D0
	public void WritePose(IKSolverFullBody solver) { }

	// RVA: 0x257F490 Offset: 0x257F591 VA: 0x257F490
	public void ForwardReach(Vector3 position) { }

	// RVA: 0x257F590 Offset: 0x257F691 VA: 0x257F590
	private void BackwardReach(Vector3 position) { }

	// RVA: 0x257F660 Offset: 0x257F761 VA: 0x257F660
	private void MapToSolverPositions(IKSolverFullBody solver) { }
}

