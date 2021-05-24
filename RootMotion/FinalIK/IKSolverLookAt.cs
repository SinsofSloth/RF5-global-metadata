[Serializable]
public class IKSolverLookAt : IKSolver // TypeDefIndex: 9491
{
	// Fields
	public Transform target; // 0x58
	public IKSolverLookAt.LookAtBone[] spine; // 0x60
	public IKSolverLookAt.LookAtBone head; // 0x68
	public IKSolverLookAt.LookAtBone[] eyes; // 0x70
	[RangeAttribute] // RVA: 0x17B280 Offset: 0x17B381 VA: 0x17B280
	public float bodyWeight; // 0x78
	[RangeAttribute] // RVA: 0x17B2A0 Offset: 0x17B3A1 VA: 0x17B2A0
	public float headWeight; // 0x7C
	[RangeAttribute] // RVA: 0x17B2C0 Offset: 0x17B3C1 VA: 0x17B2C0
	public float eyesWeight; // 0x80
	[RangeAttribute] // RVA: 0x17B2E0 Offset: 0x17B3E1 VA: 0x17B2E0
	public float clampWeight; // 0x84
	[RangeAttribute] // RVA: 0x17B300 Offset: 0x17B401 VA: 0x17B300
	public float clampWeightHead; // 0x88
	[RangeAttribute] // RVA: 0x17B320 Offset: 0x17B421 VA: 0x17B320
	public float clampWeightEyes; // 0x8C
	[RangeAttribute] // RVA: 0x17B340 Offset: 0x17B441 VA: 0x17B340
	public int clampSmoothing; // 0x90
	public AnimationCurve spineWeightCurve; // 0x98
	public Vector3 spineTargetOffset; // 0xA0
	protected Vector3[] spineForwards; // 0xB0
	protected Vector3[] headForwards; // 0xB8
	protected Vector3[] eyeForward; // 0xC0

	// Properties
	protected bool spineIsValid { get; }
	protected bool spineIsEmpty { get; }
	protected bool headIsValid { get; }
	protected bool headIsEmpty { get; }
	protected bool eyesIsValid { get; }
	protected bool eyesIsEmpty { get; }

	// Methods

	// RVA: 0x2592320 Offset: 0x2592421 VA: 0x2592320
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x25923B0 Offset: 0x25924B1 VA: 0x25923B0
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x2592460 Offset: 0x2592561 VA: 0x2592460
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x2592540 Offset: 0x2592641 VA: 0x2592540
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x2592630 Offset: 0x2592731 VA: 0x2592630
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x2592750 Offset: 0x2592851 VA: 0x2592750
	public void SetLookAtWeight(float weight, float bodyWeight = 0, float headWeight = 1, float eyesWeight = 0.5, float clampWeight = 0.5, float clampWeightHead = 0.5, float clampWeightEyes = 0.3) { }

	// RVA: 0x25928B0 Offset: 0x25929B1 VA: 0x25928B0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x2592A70 Offset: 0x2592B71 VA: 0x2592A70 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x2592BB0 Offset: 0x2592CB1 VA: 0x2592BB0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x25930E0 Offset: 0x25931E1 VA: 0x25930E0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x2593380 Offset: 0x2593481 VA: 0x2593380 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x2593500 Offset: 0x2593601 VA: 0x2593500
	public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root) { }

	// RVA: 0x25937A0 Offset: 0x25938A1 VA: 0x25937A0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x2593C40 Offset: 0x2593D41 VA: 0x2593C40 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2592DB0 Offset: 0x2592EB1 VA: 0x2592DB0
	protected bool get_spineIsValid() { }

	// RVA: 0x2593000 Offset: 0x2593101 VA: 0x2593000
	protected bool get_spineIsEmpty() { }

	// RVA: 0x2593D50 Offset: 0x2593E51 VA: 0x2593D50
	protected void SolveSpine() { }

	// RVA: 0x2592ED0 Offset: 0x2592FD1 VA: 0x2592ED0
	protected bool get_headIsValid() { }

	// RVA: 0x2593030 Offset: 0x2593131 VA: 0x2593030
	protected bool get_headIsEmpty() { }

	// RVA: 0x2593F80 Offset: 0x2594081 VA: 0x2593F80
	protected void SolveHead() { }

	// RVA: 0x2592EE0 Offset: 0x2592FE1 VA: 0x2592EE0
	protected bool get_eyesIsValid() { }

	// RVA: 0x25930B0 Offset: 0x25931B1 VA: 0x25930B0
	protected bool get_eyesIsEmpty() { }

	// RVA: 0x2594230 Offset: 0x2594331 VA: 0x2594230
	protected void SolveEyes() { }

	// RVA: 0x2594770 Offset: 0x2594871 VA: 0x2594770
	protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp) { }

	// RVA: 0x25935C0 Offset: 0x25936C1 VA: 0x25935C0
	protected void SetBones(Transform[] array, ref IKSolverLookAt.LookAtBone[] bones) { }

	// RVA: 0x2594C30 Offset: 0x2594D31 VA: 0x2594C30
	public void .ctor() { }
}

[Serializable]
public class IKSolverLookAt : IKSolver // TypeDefIndex: 9491
{
	// Fields
	public Transform target; // 0x58
	public IKSolverLookAt.LookAtBone[] spine; // 0x60
	public IKSolverLookAt.LookAtBone head; // 0x68
	public IKSolverLookAt.LookAtBone[] eyes; // 0x70
	[RangeAttribute] // RVA: 0x17B280 Offset: 0x17B381 VA: 0x17B280
	public float bodyWeight; // 0x78
	[RangeAttribute] // RVA: 0x17B2A0 Offset: 0x17B3A1 VA: 0x17B2A0
	public float headWeight; // 0x7C
	[RangeAttribute] // RVA: 0x17B2C0 Offset: 0x17B3C1 VA: 0x17B2C0
	public float eyesWeight; // 0x80
	[RangeAttribute] // RVA: 0x17B2E0 Offset: 0x17B3E1 VA: 0x17B2E0
	public float clampWeight; // 0x84
	[RangeAttribute] // RVA: 0x17B300 Offset: 0x17B401 VA: 0x17B300
	public float clampWeightHead; // 0x88
	[RangeAttribute] // RVA: 0x17B320 Offset: 0x17B421 VA: 0x17B320
	public float clampWeightEyes; // 0x8C
	[RangeAttribute] // RVA: 0x17B340 Offset: 0x17B441 VA: 0x17B340
	public int clampSmoothing; // 0x90
	public AnimationCurve spineWeightCurve; // 0x98
	public Vector3 spineTargetOffset; // 0xA0
	protected Vector3[] spineForwards; // 0xB0
	protected Vector3[] headForwards; // 0xB8
	protected Vector3[] eyeForward; // 0xC0

	// Properties
	protected bool spineIsValid { get; }
	protected bool spineIsEmpty { get; }
	protected bool headIsValid { get; }
	protected bool headIsEmpty { get; }
	protected bool eyesIsValid { get; }
	protected bool eyesIsEmpty { get; }

	// Methods

	// RVA: 0x2592320 Offset: 0x2592421 VA: 0x2592320
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x25923B0 Offset: 0x25924B1 VA: 0x25923B0
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x2592460 Offset: 0x2592561 VA: 0x2592460
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x2592540 Offset: 0x2592641 VA: 0x2592540
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x2592630 Offset: 0x2592731 VA: 0x2592630
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x2592750 Offset: 0x2592851 VA: 0x2592750
	public void SetLookAtWeight(float weight, float bodyWeight = 0, float headWeight = 1, float eyesWeight = 0.5, float clampWeight = 0.5, float clampWeightHead = 0.5, float clampWeightEyes = 0.3) { }

	// RVA: 0x25928B0 Offset: 0x25929B1 VA: 0x25928B0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x2592A70 Offset: 0x2592B71 VA: 0x2592A70 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x2592BB0 Offset: 0x2592CB1 VA: 0x2592BB0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x25930E0 Offset: 0x25931E1 VA: 0x25930E0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x2593380 Offset: 0x2593481 VA: 0x2593380 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x2593500 Offset: 0x2593601 VA: 0x2593500
	public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root) { }

	// RVA: 0x25937A0 Offset: 0x25938A1 VA: 0x25937A0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x2593C40 Offset: 0x2593D41 VA: 0x2593C40 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2592DB0 Offset: 0x2592EB1 VA: 0x2592DB0
	protected bool get_spineIsValid() { }

	// RVA: 0x2593000 Offset: 0x2593101 VA: 0x2593000
	protected bool get_spineIsEmpty() { }

	// RVA: 0x2593D50 Offset: 0x2593E51 VA: 0x2593D50
	protected void SolveSpine() { }

	// RVA: 0x2592ED0 Offset: 0x2592FD1 VA: 0x2592ED0
	protected bool get_headIsValid() { }

	// RVA: 0x2593030 Offset: 0x2593131 VA: 0x2593030
	protected bool get_headIsEmpty() { }

	// RVA: 0x2593F80 Offset: 0x2594081 VA: 0x2593F80
	protected void SolveHead() { }

	// RVA: 0x2592EE0 Offset: 0x2592FE1 VA: 0x2592EE0
	protected bool get_eyesIsValid() { }

	// RVA: 0x25930B0 Offset: 0x25931B1 VA: 0x25930B0
	protected bool get_eyesIsEmpty() { }

	// RVA: 0x2594230 Offset: 0x2594331 VA: 0x2594230
	protected void SolveEyes() { }

	// RVA: 0x2594770 Offset: 0x2594871 VA: 0x2594770
	protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp) { }

	// RVA: 0x25935C0 Offset: 0x25936C1 VA: 0x25935C0
	protected void SetBones(Transform[] array, ref IKSolverLookAt.LookAtBone[] bones) { }

	// RVA: 0x2594C30 Offset: 0x2594D31 VA: 0x2594C30
	public void .ctor() { }
}

[Serializable]
public class IKSolverLookAt : IKSolver // TypeDefIndex: 9491
{
	// Fields
	public Transform target; // 0x58
	public IKSolverLookAt.LookAtBone[] spine; // 0x60
	public IKSolverLookAt.LookAtBone head; // 0x68
	public IKSolverLookAt.LookAtBone[] eyes; // 0x70
	[RangeAttribute] // RVA: 0x17B280 Offset: 0x17B381 VA: 0x17B280
	public float bodyWeight; // 0x78
	[RangeAttribute] // RVA: 0x17B2A0 Offset: 0x17B3A1 VA: 0x17B2A0
	public float headWeight; // 0x7C
	[RangeAttribute] // RVA: 0x17B2C0 Offset: 0x17B3C1 VA: 0x17B2C0
	public float eyesWeight; // 0x80
	[RangeAttribute] // RVA: 0x17B2E0 Offset: 0x17B3E1 VA: 0x17B2E0
	public float clampWeight; // 0x84
	[RangeAttribute] // RVA: 0x17B300 Offset: 0x17B401 VA: 0x17B300
	public float clampWeightHead; // 0x88
	[RangeAttribute] // RVA: 0x17B320 Offset: 0x17B421 VA: 0x17B320
	public float clampWeightEyes; // 0x8C
	[RangeAttribute] // RVA: 0x17B340 Offset: 0x17B441 VA: 0x17B340
	public int clampSmoothing; // 0x90
	public AnimationCurve spineWeightCurve; // 0x98
	public Vector3 spineTargetOffset; // 0xA0
	protected Vector3[] spineForwards; // 0xB0
	protected Vector3[] headForwards; // 0xB8
	protected Vector3[] eyeForward; // 0xC0

	// Properties
	protected bool spineIsValid { get; }
	protected bool spineIsEmpty { get; }
	protected bool headIsValid { get; }
	protected bool headIsEmpty { get; }
	protected bool eyesIsValid { get; }
	protected bool eyesIsEmpty { get; }

	// Methods

	// RVA: 0x2592320 Offset: 0x2592421 VA: 0x2592320
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x25923B0 Offset: 0x25924B1 VA: 0x25923B0
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x2592460 Offset: 0x2592561 VA: 0x2592460
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x2592540 Offset: 0x2592641 VA: 0x2592540
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x2592630 Offset: 0x2592731 VA: 0x2592630
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x2592750 Offset: 0x2592851 VA: 0x2592750
	public void SetLookAtWeight(float weight, float bodyWeight = 0, float headWeight = 1, float eyesWeight = 0.5, float clampWeight = 0.5, float clampWeightHead = 0.5, float clampWeightEyes = 0.3) { }

	// RVA: 0x25928B0 Offset: 0x25929B1 VA: 0x25928B0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x2592A70 Offset: 0x2592B71 VA: 0x2592A70 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x2592BB0 Offset: 0x2592CB1 VA: 0x2592BB0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x25930E0 Offset: 0x25931E1 VA: 0x25930E0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x2593380 Offset: 0x2593481 VA: 0x2593380 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x2593500 Offset: 0x2593601 VA: 0x2593500
	public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root) { }

	// RVA: 0x25937A0 Offset: 0x25938A1 VA: 0x25937A0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x2593C40 Offset: 0x2593D41 VA: 0x2593C40 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2592DB0 Offset: 0x2592EB1 VA: 0x2592DB0
	protected bool get_spineIsValid() { }

	// RVA: 0x2593000 Offset: 0x2593101 VA: 0x2593000
	protected bool get_spineIsEmpty() { }

	// RVA: 0x2593D50 Offset: 0x2593E51 VA: 0x2593D50
	protected void SolveSpine() { }

	// RVA: 0x2592ED0 Offset: 0x2592FD1 VA: 0x2592ED0
	protected bool get_headIsValid() { }

	// RVA: 0x2593030 Offset: 0x2593131 VA: 0x2593030
	protected bool get_headIsEmpty() { }

	// RVA: 0x2593F80 Offset: 0x2594081 VA: 0x2593F80
	protected void SolveHead() { }

	// RVA: 0x2592EE0 Offset: 0x2592FE1 VA: 0x2592EE0
	protected bool get_eyesIsValid() { }

	// RVA: 0x25930B0 Offset: 0x25931B1 VA: 0x25930B0
	protected bool get_eyesIsEmpty() { }

	// RVA: 0x2594230 Offset: 0x2594331 VA: 0x2594230
	protected void SolveEyes() { }

	// RVA: 0x2594770 Offset: 0x2594871 VA: 0x2594770
	protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp) { }

	// RVA: 0x25935C0 Offset: 0x25936C1 VA: 0x25935C0
	protected void SetBones(Transform[] array, ref IKSolverLookAt.LookAtBone[] bones) { }

	// RVA: 0x2594C30 Offset: 0x2594D31 VA: 0x2594C30
	public void .ctor() { }
}

[Serializable]
public class IKSolverLookAt : IKSolver // TypeDefIndex: 9491
{
	// Fields
	public Transform target; // 0x58
	public IKSolverLookAt.LookAtBone[] spine; // 0x60
	public IKSolverLookAt.LookAtBone head; // 0x68
	public IKSolverLookAt.LookAtBone[] eyes; // 0x70
	[RangeAttribute] // RVA: 0x17B280 Offset: 0x17B381 VA: 0x17B280
	public float bodyWeight; // 0x78
	[RangeAttribute] // RVA: 0x17B2A0 Offset: 0x17B3A1 VA: 0x17B2A0
	public float headWeight; // 0x7C
	[RangeAttribute] // RVA: 0x17B2C0 Offset: 0x17B3C1 VA: 0x17B2C0
	public float eyesWeight; // 0x80
	[RangeAttribute] // RVA: 0x17B2E0 Offset: 0x17B3E1 VA: 0x17B2E0
	public float clampWeight; // 0x84
	[RangeAttribute] // RVA: 0x17B300 Offset: 0x17B401 VA: 0x17B300
	public float clampWeightHead; // 0x88
	[RangeAttribute] // RVA: 0x17B320 Offset: 0x17B421 VA: 0x17B320
	public float clampWeightEyes; // 0x8C
	[RangeAttribute] // RVA: 0x17B340 Offset: 0x17B441 VA: 0x17B340
	public int clampSmoothing; // 0x90
	public AnimationCurve spineWeightCurve; // 0x98
	public Vector3 spineTargetOffset; // 0xA0
	protected Vector3[] spineForwards; // 0xB0
	protected Vector3[] headForwards; // 0xB8
	protected Vector3[] eyeForward; // 0xC0

	// Properties
	protected bool spineIsValid { get; }
	protected bool spineIsEmpty { get; }
	protected bool headIsValid { get; }
	protected bool headIsEmpty { get; }
	protected bool eyesIsValid { get; }
	protected bool eyesIsEmpty { get; }

	// Methods

	// RVA: 0x2592320 Offset: 0x2592421 VA: 0x2592320
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x25923B0 Offset: 0x25924B1 VA: 0x25923B0
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x2592460 Offset: 0x2592561 VA: 0x2592460
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x2592540 Offset: 0x2592641 VA: 0x2592540
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x2592630 Offset: 0x2592731 VA: 0x2592630
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x2592750 Offset: 0x2592851 VA: 0x2592750
	public void SetLookAtWeight(float weight, float bodyWeight = 0, float headWeight = 1, float eyesWeight = 0.5, float clampWeight = 0.5, float clampWeightHead = 0.5, float clampWeightEyes = 0.3) { }

	// RVA: 0x25928B0 Offset: 0x25929B1 VA: 0x25928B0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x2592A70 Offset: 0x2592B71 VA: 0x2592A70 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x2592BB0 Offset: 0x2592CB1 VA: 0x2592BB0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x25930E0 Offset: 0x25931E1 VA: 0x25930E0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x2593380 Offset: 0x2593481 VA: 0x2593380 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x2593500 Offset: 0x2593601 VA: 0x2593500
	public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root) { }

	// RVA: 0x25937A0 Offset: 0x25938A1 VA: 0x25937A0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x2593C40 Offset: 0x2593D41 VA: 0x2593C40 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2592DB0 Offset: 0x2592EB1 VA: 0x2592DB0
	protected bool get_spineIsValid() { }

	// RVA: 0x2593000 Offset: 0x2593101 VA: 0x2593000
	protected bool get_spineIsEmpty() { }

	// RVA: 0x2593D50 Offset: 0x2593E51 VA: 0x2593D50
	protected void SolveSpine() { }

	// RVA: 0x2592ED0 Offset: 0x2592FD1 VA: 0x2592ED0
	protected bool get_headIsValid() { }

	// RVA: 0x2593030 Offset: 0x2593131 VA: 0x2593030
	protected bool get_headIsEmpty() { }

	// RVA: 0x2593F80 Offset: 0x2594081 VA: 0x2593F80
	protected void SolveHead() { }

	// RVA: 0x2592EE0 Offset: 0x2592FE1 VA: 0x2592EE0
	protected bool get_eyesIsValid() { }

	// RVA: 0x25930B0 Offset: 0x25931B1 VA: 0x25930B0
	protected bool get_eyesIsEmpty() { }

	// RVA: 0x2594230 Offset: 0x2594331 VA: 0x2594230
	protected void SolveEyes() { }

	// RVA: 0x2594770 Offset: 0x2594871 VA: 0x2594770
	protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp) { }

	// RVA: 0x25935C0 Offset: 0x25936C1 VA: 0x25935C0
	protected void SetBones(Transform[] array, ref IKSolverLookAt.LookAtBone[] bones) { }

	// RVA: 0x2594C30 Offset: 0x2594D31 VA: 0x2594C30
	public void .ctor() { }
}

[Serializable]
public class IKSolverLookAt : IKSolver // TypeDefIndex: 9491
{
	// Fields
	public Transform target; // 0x58
	public IKSolverLookAt.LookAtBone[] spine; // 0x60
	public IKSolverLookAt.LookAtBone head; // 0x68
	public IKSolverLookAt.LookAtBone[] eyes; // 0x70
	[RangeAttribute] // RVA: 0x17B280 Offset: 0x17B381 VA: 0x17B280
	public float bodyWeight; // 0x78
	[RangeAttribute] // RVA: 0x17B2A0 Offset: 0x17B3A1 VA: 0x17B2A0
	public float headWeight; // 0x7C
	[RangeAttribute] // RVA: 0x17B2C0 Offset: 0x17B3C1 VA: 0x17B2C0
	public float eyesWeight; // 0x80
	[RangeAttribute] // RVA: 0x17B2E0 Offset: 0x17B3E1 VA: 0x17B2E0
	public float clampWeight; // 0x84
	[RangeAttribute] // RVA: 0x17B300 Offset: 0x17B401 VA: 0x17B300
	public float clampWeightHead; // 0x88
	[RangeAttribute] // RVA: 0x17B320 Offset: 0x17B421 VA: 0x17B320
	public float clampWeightEyes; // 0x8C
	[RangeAttribute] // RVA: 0x17B340 Offset: 0x17B441 VA: 0x17B340
	public int clampSmoothing; // 0x90
	public AnimationCurve spineWeightCurve; // 0x98
	public Vector3 spineTargetOffset; // 0xA0
	protected Vector3[] spineForwards; // 0xB0
	protected Vector3[] headForwards; // 0xB8
	protected Vector3[] eyeForward; // 0xC0

	// Properties
	protected bool spineIsValid { get; }
	protected bool spineIsEmpty { get; }
	protected bool headIsValid { get; }
	protected bool headIsEmpty { get; }
	protected bool eyesIsValid { get; }
	protected bool eyesIsEmpty { get; }

	// Methods

	// RVA: 0x2592320 Offset: 0x2592421 VA: 0x2592320
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x25923B0 Offset: 0x25924B1 VA: 0x25923B0
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x2592460 Offset: 0x2592561 VA: 0x2592460
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x2592540 Offset: 0x2592641 VA: 0x2592540
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x2592630 Offset: 0x2592731 VA: 0x2592630
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x2592750 Offset: 0x2592851 VA: 0x2592750
	public void SetLookAtWeight(float weight, float bodyWeight = 0, float headWeight = 1, float eyesWeight = 0.5, float clampWeight = 0.5, float clampWeightHead = 0.5, float clampWeightEyes = 0.3) { }

	// RVA: 0x25928B0 Offset: 0x25929B1 VA: 0x25928B0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x2592A70 Offset: 0x2592B71 VA: 0x2592A70 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x2592BB0 Offset: 0x2592CB1 VA: 0x2592BB0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x25930E0 Offset: 0x25931E1 VA: 0x25930E0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x2593380 Offset: 0x2593481 VA: 0x2593380 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x2593500 Offset: 0x2593601 VA: 0x2593500
	public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root) { }

	// RVA: 0x25937A0 Offset: 0x25938A1 VA: 0x25937A0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x2593C40 Offset: 0x2593D41 VA: 0x2593C40 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x2592DB0 Offset: 0x2592EB1 VA: 0x2592DB0
	protected bool get_spineIsValid() { }

	// RVA: 0x2593000 Offset: 0x2593101 VA: 0x2593000
	protected bool get_spineIsEmpty() { }

	// RVA: 0x2593D50 Offset: 0x2593E51 VA: 0x2593D50
	protected void SolveSpine() { }

	// RVA: 0x2592ED0 Offset: 0x2592FD1 VA: 0x2592ED0
	protected bool get_headIsValid() { }

	// RVA: 0x2593030 Offset: 0x2593131 VA: 0x2593030
	protected bool get_headIsEmpty() { }

	// RVA: 0x2593F80 Offset: 0x2594081 VA: 0x2593F80
	protected void SolveHead() { }

	// RVA: 0x2592EE0 Offset: 0x2592FE1 VA: 0x2592EE0
	protected bool get_eyesIsValid() { }

	// RVA: 0x25930B0 Offset: 0x25931B1 VA: 0x25930B0
	protected bool get_eyesIsEmpty() { }

	// RVA: 0x2594230 Offset: 0x2594331 VA: 0x2594230
	protected void SolveEyes() { }

	// RVA: 0x2594770 Offset: 0x2594871 VA: 0x2594770
	protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp) { }

	// RVA: 0x25935C0 Offset: 0x25936C1 VA: 0x25935C0
	protected void SetBones(Transform[] array, ref IKSolverLookAt.LookAtBone[] bones) { }

	// RVA: 0x2594C30 Offset: 0x2594D31 VA: 0x2594C30
	public void .ctor() { }
}

