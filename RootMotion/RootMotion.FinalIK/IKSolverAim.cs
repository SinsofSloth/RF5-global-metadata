[Serializable]
public class IKSolverAim : IKSolverHeuristic // TypeDefIndex: 9477
{
	// Fields
	public Transform transform; // 0x88
	public Vector3 axis; // 0x90
	public Vector3 poleAxis; // 0x9C
	public Vector3 polePosition; // 0xA8
	[RangeAttribute] // RVA: 0x17B0F0 Offset: 0x17B1F1 VA: 0x17B0F0
	public float poleWeight; // 0xB4
	public Transform poleTarget; // 0xB8
	[RangeAttribute] // RVA: 0x17B110 Offset: 0x17B211 VA: 0x17B110
	public float clampWeight; // 0xC0
	[RangeAttribute] // RVA: 0x17B130 Offset: 0x17B231 VA: 0x17B130
	public int clampSmoothing; // 0xC4
	public IKSolver.IterationDelegate OnPreIteration; // 0xC8
	private float step; // 0xD0
	private Vector3 clampedIKPosition; // 0xD4
	private RotationLimit transformLimit; // 0xE0
	private Transform lastTransform; // 0xE8

	// Properties
	public Vector3 transformAxis { get; }
	public Vector3 transformPoleAxis { get; }
	protected override int minBones { get; }
	protected override Vector3 localDirection { get; }

	// Methods

	// RVA: 0x2581B30 Offset: 0x2581C31 VA: 0x2581B30
	public float GetAngle() { }

	// RVA: 0x2581C30 Offset: 0x2581D31 VA: 0x2581C30
	public Vector3 get_transformAxis() { }

	// RVA: 0x2581D00 Offset: 0x2581E01 VA: 0x2581D00
	public Vector3 get_transformPoleAxis() { }

	// RVA: 0x2581DD0 Offset: 0x2581ED1 VA: 0x2581DD0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x2582050 Offset: 0x2582151 VA: 0x2582050 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2582AA0 Offset: 0x2582BA1 VA: 0x2582AA0 Slot: 12
	protected override int get_minBones() { }

	// RVA: 0x25829E0 Offset: 0x2582AE1 VA: 0x25829E0
	private void Solve() { }

	// RVA: 0x2582600 Offset: 0x2582701 VA: 0x2582600
	private Vector3 GetClampedIKPosition() { }

	// RVA: 0x2582AB0 Offset: 0x2582BB1 VA: 0x2582AB0
	private void RotateToTarget(Vector3 targetPosition, IKSolver.Bone bone, float weight) { }

	// RVA: 0x2583050 Offset: 0x2583151 VA: 0x2583050 Slot: 15
	protected override Vector3 get_localDirection() { }

	// RVA: 0x25830D0 Offset: 0x25831D1 VA: 0x25830D0
	public void .ctor() { }
}

