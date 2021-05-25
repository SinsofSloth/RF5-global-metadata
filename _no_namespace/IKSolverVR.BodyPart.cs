[Serializable]
public abstract class IKSolverVR.BodyPart // TypeDefIndex: 9498
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x196C50 Offset: 0x196D51 VA: 0x196C50
	private float <sqrMag>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x196C60 Offset: 0x196D61 VA: 0x196C60
	private float <mag>k__BackingField; // 0x14
	[HideInInspector] // RVA: 0x196C70 Offset: 0x196D71 VA: 0x196C70
	public IKSolverVR.VirtualBone[] bones; // 0x18
	protected bool initiated; // 0x20
	protected Vector3 rootPosition; // 0x24
	protected Quaternion rootRotation; // 0x30
	protected int index; // 0x40
	protected int LOD; // 0x44

	// Properties
	public float sqrMag { get; set; }
	public float mag { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void PreSolve() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ApplyOffsets() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ResetOffsets() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5560 Offset: 0x1B5661 VA: 0x1B5560
	// RVA: 0x2BE4240 Offset: 0x2BE4341 VA: 0x2BE4240
	public float get_sqrMag() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5570 Offset: 0x1B5671 VA: 0x1B5570
	// RVA: 0x2BE4250 Offset: 0x2BE4351 VA: 0x2BE4250
	private void set_sqrMag(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5580 Offset: 0x1B5681 VA: 0x1B5580
	// RVA: 0x2BE4260 Offset: 0x2BE4361 VA: 0x2BE4260
	public float get_mag() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5590 Offset: 0x1B5691 VA: 0x1B5590
	// RVA: 0x2BE4270 Offset: 0x2BE4371 VA: 0x2BE4270
	private void set_mag(float value) { }

	// RVA: 0x2BE4280 Offset: 0x2BE4381 VA: 0x2BE4280
	public void SetLOD(int LOD) { }

	// RVA: 0x2BDCA60 Offset: 0x2BDCB61 VA: 0x2BDCA60
	public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) { }

	// RVA: 0x2BE45A0 Offset: 0x2BE46A1 VA: 0x2BE45A0
	public void MovePosition(Vector3 position) { }

	// RVA: 0x2BE4710 Offset: 0x2BE4811 VA: 0x2BE4710
	public void MoveRotation(Quaternion rotation) { }

	// RVA: 0x2BE49B0 Offset: 0x2BE4AB1 VA: 0x2BE49B0
	public void Translate(Vector3 position, Quaternion rotation) { }

	// RVA: 0x2BDED70 Offset: 0x2BDEE71 VA: 0x2BDED70
	public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot) { }

	// RVA: 0x2BE3B50 Offset: 0x2BE3C51 VA: 0x2BE3B50
	public void RotateTo(IKSolverVR.VirtualBone bone, Quaternion rotation, float weight = 1) { }

	// RVA: 0x2BE4A10 Offset: 0x2BE4B11 VA: 0x2BE4A10
	public void Visualize(Color color) { }

	// RVA: 0x2BE4B60 Offset: 0x2BE4C61 VA: 0x2BE4B60
	public void Visualize() { }

	// RVA: 0x2BE4190 Offset: 0x2BE4291 VA: 0x2BE4190
	protected void .ctor() { }
}

