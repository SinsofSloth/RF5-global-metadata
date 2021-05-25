public struct CCDIKJob : IAnimationJob // TypeDefIndex: 9453
{
	// Fields
	public TransformSceneHandle _target; // 0x0
	public PropertySceneHandle _IKPositionWeight; // 0x8
	public PropertySceneHandle _maxIterations; // 0x10
	public PropertySceneHandle _tolerance; // 0x18
	public PropertySceneHandle _XY; // 0x20
	public PropertySceneHandle _useRotationLimits; // 0x28
	private NativeArray<TransformStreamHandle> bones; // 0x30
	private NativeArray<PropertySceneHandle> boneWeights; // 0x40
	private NativeArray<float> boneSqrMags; // 0x50
	private float chainSqrMag; // 0x60
	private Vector3 lastLocalDirection; // 0x64
	private NativeArray<Quaternion> limitDefaultLocalRotationArray; // 0x70
	private NativeArray<Vector3> limitAxisArray; // 0x80
	private NativeArray<int> hingeFlags; // 0x90
	private NativeArray<PropertySceneHandle> hingeMinArray; // 0xA0
	private NativeArray<PropertySceneHandle> hingeMaxArray; // 0xB0
	private NativeArray<PropertySceneHandle> hingeUseLimitsArray; // 0xC0
	private NativeArray<Quaternion> hingeLastRotations; // 0xD0
	private NativeArray<float> hingeLastAngles; // 0xE0
	private NativeArray<int> angleFlags; // 0xF0
	private NativeArray<Vector3> angleSecondaryAxisArray; // 0x100
	private NativeArray<PropertySceneHandle> angleLimitArray; // 0x110
	private NativeArray<PropertySceneHandle> angleTwistLimitArray; // 0x120

	// Methods

	// RVA: 0x36A440 Offset: 0x36A541 VA: 0x36A440
	public void Setup(Animator animator, Transform[] bones, Transform target) { }

	// RVA: 0x36A450 Offset: 0x36A551 VA: 0x36A450
	private void SetUpRotationLimits(Animator animator, Transform[] bones) { }

	// RVA: 0x36A460 Offset: 0x36A561 VA: 0x36A460
	private void DisposeRotationLimits() { }

	// RVA: 0x36A470 Offset: 0x36A571 VA: 0x36A470 Slot: 5
	public void ProcessRootMotion(AnimationStream stream) { }

	// RVA: 0x36A480 Offset: 0x36A581 VA: 0x36A480 Slot: 4
	public void ProcessAnimation(AnimationStream stream) { }

	// RVA: 0x36A4D0 Offset: 0x36A5D1 VA: 0x36A4D0
	private void Update(AnimationStream s) { }

	// RVA: 0x36A520 Offset: 0x36A621 VA: 0x36A520
	private void Read(AnimationStream s) { }

	// RVA: 0x36A570 Offset: 0x36A671 VA: 0x36A570
	private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits) { }

	// RVA: 0x36A5C0 Offset: 0x36A6C1 VA: 0x36A5C0
	private Vector3 GetLocalDirection(AnimationStream s) { }

	// RVA: 0x36A610 Offset: 0x36A711 VA: 0x36A610
	private float GetPositionOffset(AnimationStream s, Vector3 localDirection) { }

	// RVA: 0x36A620 Offset: 0x36A721 VA: 0x36A620
	private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits) { }

	// RVA: 0x36A670 Offset: 0x36A771 VA: 0x36A670
	private bool SingularityDetected(AnimationStream s, Vector3 IKPosition) { }

	// RVA: 0x36A6C0 Offset: 0x36A7C1 VA: 0x36A6C0
	public void Dispose() { }
}

