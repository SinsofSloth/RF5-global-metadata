[Serializable]
public class IKSolverLimb : IKSolverTrigonometric // TypeDefIndex: 9488
{
	// Fields
	public AvatarIKGoal goal; // 0xA8
	public IKSolverLimb.BendModifier bendModifier; // 0xAC
	[RangeAttribute] // RVA: 0x17B240 Offset: 0x17B341 VA: 0x17B240
	public float maintainRotationWeight; // 0xB0
	[RangeAttribute] // RVA: 0x17B260 Offset: 0x17B361 VA: 0x17B260
	public float bendModifierWeight; // 0xB4
	public Transform bendGoal; // 0xB8
	private bool maintainBendFor1Frame; // 0xC0
	private bool maintainRotationFor1Frame; // 0xC1
	private Quaternion defaultRootRotation; // 0xC4
	private Quaternion parentDefaultRotation; // 0xD4
	private Quaternion bone3RotationBeforeSolve; // 0xE4
	private Quaternion maintainRotation; // 0xF4
	private Quaternion bone3DefaultRotation; // 0x104
	private Vector3 _bendNormal; // 0x114
	private Vector3 animationNormal; // 0x120
	private IKSolverLimb.AxisDirection[] axisDirectionsLeft; // 0x130
	private IKSolverLimb.AxisDirection[] axisDirectionsRight; // 0x138

	// Properties
	private IKSolverLimb.AxisDirection[] axisDirections { get; }

	// Methods

	// RVA: 0x2590B30 Offset: 0x2590C31 VA: 0x2590B30
	public void MaintainRotation() { }

	// RVA: 0x2590B80 Offset: 0x2590C81 VA: 0x2590B80
	public void MaintainBend() { }

	// RVA: 0x2590BD0 Offset: 0x2590CD1 VA: 0x2590BD0 Slot: 12
	protected override void OnInitiateVirtual() { }

	// RVA: 0x2591290 Offset: 0x2591391 VA: 0x2591290 Slot: 13
	protected override void OnUpdateVirtual() { }

	// RVA: 0x2591EB0 Offset: 0x2591FB1 VA: 0x2591EB0 Slot: 14
	protected override void OnPostSolveVirtual() { }

	// RVA: 0x2592020 Offset: 0x2592121 VA: 0x2592020
	public void .ctor() { }

	// RVA: 0x25921F0 Offset: 0x25922F1 VA: 0x25921F0
	public void .ctor(AvatarIKGoal goal) { }

	// RVA: 0x2592290 Offset: 0x2592391 VA: 0x2592290
	private IKSolverLimb.AxisDirection[] get_axisDirections() { }

	// RVA: 0x2590F40 Offset: 0x2591041 VA: 0x2590F40
	private void StoreAxisDirections(ref IKSolverLimb.AxisDirection[] axisDirections) { }

	// RVA: 0x25913E0 Offset: 0x25914E1 VA: 0x25913E0
	private Vector3 GetModifiedBendNormal() { }
}

