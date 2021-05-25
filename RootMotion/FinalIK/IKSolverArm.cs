[Serializable]
public class IKSolverArm : IKSolver // TypeDefIndex: 9478
{
	// Fields
	[RangeAttribute] // RVA: 0x17B150 Offset: 0x17B251 VA: 0x17B150
	public float IKRotationWeight; // 0x58
	public Quaternion IKRotation; // 0x5C
	public IKSolver.Point chest; // 0x70
	public IKSolver.Point shoulder; // 0x78
	public IKSolver.Point upperArm; // 0x80
	public IKSolver.Point forearm; // 0x88
	public IKSolver.Point hand; // 0x90
	public bool isLeft; // 0x98
	public IKSolverVR.Arm arm; // 0xA0
	private Vector3[] positions; // 0xA8
	private Quaternion[] rotations; // 0xB0

	// Methods

	// RVA: 0x2583260 Offset: 0x2583361 VA: 0x2583260 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x2583620 Offset: 0x2583721 VA: 0x2583620
	public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root) { }

	// RVA: 0x25836E0 Offset: 0x25837E1 VA: 0x25836E0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x2583880 Offset: 0x2583981 VA: 0x2583880 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x2583A20 Offset: 0x2583B21 VA: 0x2583A20 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x2583B20 Offset: 0x2583C21 VA: 0x2583B20 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x2583B80 Offset: 0x2583C81 VA: 0x2583B80 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x2583F10 Offset: 0x2584011 VA: 0x2583F10 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2583F40 Offset: 0x2584041 VA: 0x2583F40
	private void Solve() { }

	// RVA: 0x2583BF0 Offset: 0x2583CF1 VA: 0x2583BF0
	private void Read() { }

	// RVA: 0x2583FB0 Offset: 0x25840B1 VA: 0x2583FB0
	private void Write() { }

	// RVA: 0x2584140 Offset: 0x2584241 VA: 0x2584140
	public void .ctor() { }
}

