[Serializable]
public class IKSolverTrigonometric : IKSolver // TypeDefIndex: 9493
{
	// Fields
	public Transform target; // 0x58
	[RangeAttribute] // RVA: 0x17B360 Offset: 0x17B461 VA: 0x17B360
	public float IKRotationWeight; // 0x60
	public Quaternion IKRotation; // 0x64
	public Vector3 bendNormal; // 0x74
	public IKSolverTrigonometric.TrigonometricBone bone1; // 0x80
	public IKSolverTrigonometric.TrigonometricBone bone2; // 0x88
	public IKSolverTrigonometric.TrigonometricBone bone3; // 0x90
	protected Vector3 weightIKPosition; // 0x98
	protected bool directHierarchy; // 0xA4

	// Methods

	// RVA: 0x2594EB0 Offset: 0x2594FB1 VA: 0x2594EB0
	public void SetBendGoalPosition(Vector3 goalPosition, float weight) { }

	// RVA: 0x25950A0 Offset: 0x25951A1 VA: 0x25950A0
	public void SetBendPlaneToCurrent() { }

	// RVA: 0x2595260 Offset: 0x2595361 VA: 0x2595260
	public void SetIKRotation(Quaternion rotation) { }

	// RVA: 0x2595280 Offset: 0x2595381 VA: 0x2595280
	public void SetIKRotationWeight(float weight) { }

	// RVA: 0x2595310 Offset: 0x2595411 VA: 0x2595310
	public Quaternion GetIKRotation() { }

	// RVA: 0x2595320 Offset: 0x2595421 VA: 0x2595320
	public float GetIKRotationWeight() { }

	// RVA: 0x2595330 Offset: 0x2595431 VA: 0x2595330 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x2595460 Offset: 0x2595561 VA: 0x2595460 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x2595580 Offset: 0x2595681 VA: 0x2595580 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x2595650 Offset: 0x2595751 VA: 0x2595650 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x25956B0 Offset: 0x25957B1 VA: 0x25956B0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x2595AC0 Offset: 0x2595BC1 VA: 0x2595AC0
	public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root) { }

	// RVA: 0x2595B40 Offset: 0x2595C41 VA: 0x2595B40
	public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight) { }

	// RVA: 0x25960E0 Offset: 0x25961E1 VA: 0x25960E0
	private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2) { }

	// RVA: 0x2596310 Offset: 0x2596411 VA: 0x2596310 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x25964E0 Offset: 0x25965E1 VA: 0x25964E0
	private bool IsDirectHierarchy() { }

	// RVA: 0x2596450 Offset: 0x2596551 VA: 0x2596450
	private void InitiateBones() { }

	// RVA: 0x2596600 Offset: 0x2596701 VA: 0x2596600 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2597030 Offset: 0x2597131 VA: 0x2597030 Slot: 12
	protected virtual void OnInitiateVirtual() { }

	// RVA: 0x2597040 Offset: 0x2597141 VA: 0x2597040 Slot: 13
	protected virtual void OnUpdateVirtual() { }

	// RVA: 0x2597050 Offset: 0x2597151 VA: 0x2597050 Slot: 14
	protected virtual void OnPostSolveVirtual() { }

	// RVA: 0x2596D10 Offset: 0x2596E11 VA: 0x2596D10
	protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal) { }

	// RVA: 0x25920B0 Offset: 0x25921B1 VA: 0x25920B0
	public void .ctor() { }
}

