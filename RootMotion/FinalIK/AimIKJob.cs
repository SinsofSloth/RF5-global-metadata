public struct AimIKJob : IAnimationJob // TypeDefIndex: 9451
{
	// Fields
	public TransformSceneHandle _target; // 0x0
	public TransformSceneHandle _poleTarget; // 0x8
	public TransformStreamHandle _transform; // 0x10
	public PropertySceneHandle _IKPositionWeight; // 0x1C
	public PropertySceneHandle _poleWeight; // 0x24
	public PropertySceneHandle _axisX; // 0x2C
	public PropertySceneHandle _axisY; // 0x34
	public PropertySceneHandle _axisZ; // 0x3C
	public PropertySceneHandle _poleAxisX; // 0x44
	public PropertySceneHandle _poleAxisY; // 0x4C
	public PropertySceneHandle _poleAxisZ; // 0x54
	public PropertySceneHandle _clampWeight; // 0x5C
	public PropertySceneHandle _clampSmoothing; // 0x64
	public PropertySceneHandle _maxIterations; // 0x6C
	public PropertySceneHandle _tolerance; // 0x74
	public PropertySceneHandle _XY; // 0x7C
	public PropertySceneHandle _useRotationLimits; // 0x84
	private NativeArray<TransformStreamHandle> bones; // 0x90
	private NativeArray<PropertySceneHandle> boneWeights; // 0xA0
	private Vector3 lastLocalDirection; // 0xB0
	private float step; // 0xBC
	private NativeArray<Quaternion> limitDefaultLocalRotationArray; // 0xC0
	private NativeArray<Vector3> limitAxisArray; // 0xD0
	private NativeArray<int> hingeFlags; // 0xE0
	private NativeArray<PropertySceneHandle> hingeMinArray; // 0xF0
	private NativeArray<PropertySceneHandle> hingeMaxArray; // 0x100
	private NativeArray<PropertySceneHandle> hingeUseLimitsArray; // 0x110
	private NativeArray<Quaternion> hingeLastRotations; // 0x120
	private NativeArray<float> hingeLastAngles; // 0x130
	private NativeArray<int> angleFlags; // 0x140
	private NativeArray<Vector3> angleSecondaryAxisArray; // 0x150
	private NativeArray<PropertySceneHandle> angleLimitArray; // 0x160
	private NativeArray<PropertySceneHandle> angleTwistLimitArray; // 0x170

	// Methods

	// RVA: 0x36A210 Offset: 0x36A311 VA: 0x36A210
	public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform) { }

	// RVA: 0x36A220 Offset: 0x36A321 VA: 0x36A220
	private void SetUpRotationLimits(Animator animator, Transform[] bones) { }

	// RVA: 0x36A230 Offset: 0x36A331 VA: 0x36A230
	private void DisposeRotationLimits() { }

	// RVA: 0x36A240 Offset: 0x36A341 VA: 0x36A240 Slot: 5
	public void ProcessRootMotion(AnimationStream stream) { }

	// RVA: 0x36A250 Offset: 0x36A351 VA: 0x36A250 Slot: 4
	public void ProcessAnimation(AnimationStream stream) { }

	// RVA: 0x36A2A0 Offset: 0x36A3A1 VA: 0x36A2A0
	private void Update(AnimationStream s) { }

	// RVA: 0x36A2F0 Offset: 0x36A3F1 VA: 0x36A2F0
	private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis) { }

	// RVA: 0x36A360 Offset: 0x36A461 VA: 0x36A360
	public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition) { }

	// RVA: 0x36A3B0 Offset: 0x36A4B1 VA: 0x36A3B0
	private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis) { }

	// RVA: 0x36A3D0 Offset: 0x36A4D1 VA: 0x36A3D0
	private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis) { }

	// RVA: 0x36A420 Offset: 0x36A521 VA: 0x36A420
	private float GetPositionOffset(AnimationStream s, Vector3 localDirection) { }

	// RVA: 0x36A430 Offset: 0x36A531 VA: 0x36A430
	public void Dispose() { }
}

