[Serializable]
public class IKSolverLeg : IKSolver // TypeDefIndex: 9487
{
	// Fields
	[RangeAttribute] // RVA: 0x17B220 Offset: 0x17B321 VA: 0x17B220
	public float IKRotationWeight; // 0x58
	public Quaternion IKRotation; // 0x5C
	public IKSolver.Point pelvis; // 0x70
	public IKSolver.Point thigh; // 0x78
	public IKSolver.Point calf; // 0x80
	public IKSolver.Point foot; // 0x88
	public IKSolver.Point toe; // 0x90
	public IKSolverVR.Leg leg; // 0x98
	public Vector3 heelOffset; // 0xA0
	private Vector3[] positions; // 0xB0
	private Quaternion[] rotations; // 0xB8

	// Methods

	// RVA: 0x258F830 Offset: 0x258F931 VA: 0x258F830 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x258FBF0 Offset: 0x258FCF1 VA: 0x258FBF0
	public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root) { }

	// RVA: 0x258FCB0 Offset: 0x258FDB1 VA: 0x258FCB0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x258FE50 Offset: 0x258FF51 VA: 0x258FE50 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x258FFF0 Offset: 0x25900F1 VA: 0x258FFF0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x25900F0 Offset: 0x25901F1 VA: 0x25900F0 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x2590150 Offset: 0x2590251 VA: 0x2590150 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x25904E0 Offset: 0x25905E1 VA: 0x25904E0 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2590510 Offset: 0x2590611 VA: 0x2590510
	private void Solve() { }

	// RVA: 0x25901C0 Offset: 0x25902C1 VA: 0x25901C0
	private void Read() { }

	// RVA: 0x2590620 Offset: 0x2590721 VA: 0x2590620
	private void Write() { }

	// RVA: 0x25907B0 Offset: 0x25908B1 VA: 0x25907B0
	public void .ctor() { }
}

[Serializable]
public class IKSolverLeg : IKSolver // TypeDefIndex: 9487
{
	// Fields
	[RangeAttribute] // RVA: 0x17B220 Offset: 0x17B321 VA: 0x17B220
	public float IKRotationWeight; // 0x58
	public Quaternion IKRotation; // 0x5C
	public IKSolver.Point pelvis; // 0x70
	public IKSolver.Point thigh; // 0x78
	public IKSolver.Point calf; // 0x80
	public IKSolver.Point foot; // 0x88
	public IKSolver.Point toe; // 0x90
	public IKSolverVR.Leg leg; // 0x98
	public Vector3 heelOffset; // 0xA0
	private Vector3[] positions; // 0xB0
	private Quaternion[] rotations; // 0xB8

	// Methods

	// RVA: 0x258F830 Offset: 0x258F931 VA: 0x258F830 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x258FBF0 Offset: 0x258FCF1 VA: 0x258FBF0
	public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root) { }

	// RVA: 0x258FCB0 Offset: 0x258FDB1 VA: 0x258FCB0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x258FE50 Offset: 0x258FF51 VA: 0x258FE50 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x258FFF0 Offset: 0x25900F1 VA: 0x258FFF0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x25900F0 Offset: 0x25901F1 VA: 0x25900F0 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x2590150 Offset: 0x2590251 VA: 0x2590150 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x25904E0 Offset: 0x25905E1 VA: 0x25904E0 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2590510 Offset: 0x2590611 VA: 0x2590510
	private void Solve() { }

	// RVA: 0x25901C0 Offset: 0x25902C1 VA: 0x25901C0
	private void Read() { }

	// RVA: 0x2590620 Offset: 0x2590721 VA: 0x2590620
	private void Write() { }

	// RVA: 0x25907B0 Offset: 0x25908B1 VA: 0x25907B0
	public void .ctor() { }
}

[Serializable]
public class IKSolverLeg : IKSolver // TypeDefIndex: 9487
{
	// Fields
	[RangeAttribute] // RVA: 0x17B220 Offset: 0x17B321 VA: 0x17B220
	public float IKRotationWeight; // 0x58
	public Quaternion IKRotation; // 0x5C
	public IKSolver.Point pelvis; // 0x70
	public IKSolver.Point thigh; // 0x78
	public IKSolver.Point calf; // 0x80
	public IKSolver.Point foot; // 0x88
	public IKSolver.Point toe; // 0x90
	public IKSolverVR.Leg leg; // 0x98
	public Vector3 heelOffset; // 0xA0
	private Vector3[] positions; // 0xB0
	private Quaternion[] rotations; // 0xB8

	// Methods

	// RVA: 0x258F830 Offset: 0x258F931 VA: 0x258F830 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x258FBF0 Offset: 0x258FCF1 VA: 0x258FBF0
	public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root) { }

	// RVA: 0x258FCB0 Offset: 0x258FDB1 VA: 0x258FCB0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x258FE50 Offset: 0x258FF51 VA: 0x258FE50 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x258FFF0 Offset: 0x25900F1 VA: 0x258FFF0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x25900F0 Offset: 0x25901F1 VA: 0x25900F0 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x2590150 Offset: 0x2590251 VA: 0x2590150 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x25904E0 Offset: 0x25905E1 VA: 0x25904E0 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2590510 Offset: 0x2590611 VA: 0x2590510
	private void Solve() { }

	// RVA: 0x25901C0 Offset: 0x25902C1 VA: 0x25901C0
	private void Read() { }

	// RVA: 0x2590620 Offset: 0x2590721 VA: 0x2590620
	private void Write() { }

	// RVA: 0x25907B0 Offset: 0x25908B1 VA: 0x25907B0
	public void .ctor() { }
}

[Serializable]
public class IKSolverLeg : IKSolver // TypeDefIndex: 9487
{
	// Fields
	[RangeAttribute] // RVA: 0x17B220 Offset: 0x17B321 VA: 0x17B220
	public float IKRotationWeight; // 0x58
	public Quaternion IKRotation; // 0x5C
	public IKSolver.Point pelvis; // 0x70
	public IKSolver.Point thigh; // 0x78
	public IKSolver.Point calf; // 0x80
	public IKSolver.Point foot; // 0x88
	public IKSolver.Point toe; // 0x90
	public IKSolverVR.Leg leg; // 0x98
	public Vector3 heelOffset; // 0xA0
	private Vector3[] positions; // 0xB0
	private Quaternion[] rotations; // 0xB8

	// Methods

	// RVA: 0x258F830 Offset: 0x258F931 VA: 0x258F830 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x258FBF0 Offset: 0x258FCF1 VA: 0x258FBF0
	public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root) { }

	// RVA: 0x258FCB0 Offset: 0x258FDB1 VA: 0x258FCB0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x258FE50 Offset: 0x258FF51 VA: 0x258FE50 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x258FFF0 Offset: 0x25900F1 VA: 0x258FFF0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x25900F0 Offset: 0x25901F1 VA: 0x25900F0 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x2590150 Offset: 0x2590251 VA: 0x2590150 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x25904E0 Offset: 0x25905E1 VA: 0x25904E0 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2590510 Offset: 0x2590611 VA: 0x2590510
	private void Solve() { }

	// RVA: 0x25901C0 Offset: 0x25902C1 VA: 0x25901C0
	private void Read() { }

	// RVA: 0x2590620 Offset: 0x2590721 VA: 0x2590620
	private void Write() { }

	// RVA: 0x25907B0 Offset: 0x25908B1 VA: 0x25907B0
	public void .ctor() { }
}

[Serializable]
public class IKSolverLeg : IKSolver // TypeDefIndex: 9487
{
	// Fields
	[RangeAttribute] // RVA: 0x17B220 Offset: 0x17B321 VA: 0x17B220
	public float IKRotationWeight; // 0x58
	public Quaternion IKRotation; // 0x5C
	public IKSolver.Point pelvis; // 0x70
	public IKSolver.Point thigh; // 0x78
	public IKSolver.Point calf; // 0x80
	public IKSolver.Point foot; // 0x88
	public IKSolver.Point toe; // 0x90
	public IKSolverVR.Leg leg; // 0x98
	public Vector3 heelOffset; // 0xA0
	private Vector3[] positions; // 0xB0
	private Quaternion[] rotations; // 0xB8

	// Methods

	// RVA: 0x258F830 Offset: 0x258F931 VA: 0x258F830 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x258FBF0 Offset: 0x258FCF1 VA: 0x258FBF0
	public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root) { }

	// RVA: 0x258FCB0 Offset: 0x258FDB1 VA: 0x258FCB0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x258FE50 Offset: 0x258FF51 VA: 0x258FE50 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x258FFF0 Offset: 0x25900F1 VA: 0x258FFF0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x25900F0 Offset: 0x25901F1 VA: 0x25900F0 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x2590150 Offset: 0x2590251 VA: 0x2590150 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x25904E0 Offset: 0x25905E1 VA: 0x25904E0 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2590510 Offset: 0x2590611 VA: 0x2590510
	private void Solve() { }

	// RVA: 0x25901C0 Offset: 0x25902C1 VA: 0x25901C0
	private void Read() { }

	// RVA: 0x2590620 Offset: 0x2590721 VA: 0x2590620
	private void Write() { }

	// RVA: 0x25907B0 Offset: 0x25908B1 VA: 0x25907B0
	public void .ctor() { }
}

