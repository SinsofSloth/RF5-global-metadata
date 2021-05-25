public class ShortPlayCameraController : CameraControllerBase // TypeDefIndex: 6510
{
	// Fields
	private Transform TargetPoint; // 0x28
	private float m_Elapsed; // 0x30
	[SerializeField] // RVA: 0x15D040 Offset: 0x15D141 VA: 0x15D040
	private CinemachineImpulseSource CinemachineImpulseSource; // 0x38
	[SerializeField] // RVA: 0x15D050 Offset: 0x15D151 VA: 0x15D050
	private Animator Animator; // 0x40
	[SerializeField] // RVA: 0x15D060 Offset: 0x15D161 VA: 0x15D060
	private float boomLengthBase; // 0x48
	[SerializeField] // RVA: 0x15D070 Offset: 0x15D171 VA: 0x15D070
	private float boolHight; // 0x4C
	[SerializeField] // RVA: 0x15D080 Offset: 0x15D181 VA: 0x15D080
	private float smooth; // 0x50
	[SerializeField] // RVA: 0x15D090 Offset: 0x15D191 VA: 0x15D090
	private float PositionLag; // 0x54
	[SerializeField] // RVA: 0x15D0A0 Offset: 0x15D1A1 VA: 0x15D0A0
	private float HighAngleLength; // 0x58
	[SerializeField] // RVA: 0x15D0B0 Offset: 0x15D1B1 VA: 0x15D0B0
	private float BoomHorizontal; // 0x5C
	[SerializeField] // RVA: 0x15D0C0 Offset: 0x15D1C1 VA: 0x15D0C0
	private float PitchAngleMin; // 0x60
	[SerializeField] // RVA: 0x15D0D0 Offset: 0x15D1D1 VA: 0x15D0D0
	private float PitchAngleMax; // 0x64
	[SerializeField] // RVA: 0x15D0E0 Offset: 0x15D1E1 VA: 0x15D0E0
	private float IndoorBoomHeight; // 0x68
	[SerializeField] // RVA: 0x15D0F0 Offset: 0x15D1F1 VA: 0x15D0F0
	private float IndoorBoomHorizontal; // 0x6C
	public bool EnptyLockOn; // 0x70
	public float shake_decay; // 0x74
	public float coef_shake_intensity; // 0x78
	private Vector3 originPosition; // 0x7C
	private Quaternion originRotation; // 0x88
	private float shake_intensity; // 0x98
	private Quaternion boomAngle; // 0x9C
	private Quaternion targetBoomAngle; // 0xAC
	private RaycastHit cameraHit; // 0xBC
	private Vector3 ownerPosition; // 0xE8
	private Vector3 pos; // 0xF4
	[SerializeField] // RVA: 0x15D100 Offset: 0x15D201 VA: 0x15D100
	private Vector3 TargetPosition; // 0x100
	private Vector3 TargetRotation; // 0x10C
	private float MoveSpeed; // 0x118
	private Vector3 velocity; // 0x11C
	public bool IsReach; // 0x128

	// Methods

	// RVA: 0x1C8F520 Offset: 0x1C8F621 VA: 0x1C8F520 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1C8F5E0 Offset: 0x1C8F6E1 VA: 0x1C8F5E0 Slot: 5
	protected override void Start() { }

	// RVA: 0x1C8F5F0 Offset: 0x1C8F6F1 VA: 0x1C8F5F0
	private void OnDisable() { }

	// RVA: 0x1C8F750 Offset: 0x1C8F851 VA: 0x1C8F750 Slot: 6
	public override void EnableCameraSetup(UseCameraType prevCameraType, CinemachineVirtualCamera vcam) { }

	// RVA: 0x1C8F8F0 Offset: 0x1C8F9F1 VA: 0x1C8F8F0
	public void SetPosition(Vector3 position, Quaternion rotation) { }

	[IteratorStateMachineAttribute] // RVA: 0x19B450 Offset: 0x19B551 VA: 0x19B450
	// RVA: 0x1C8F9C0 Offset: 0x1C8FAC1 VA: 0x1C8F9C0
	public IEnumerator SetPosition(float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ) { }

	[IteratorStateMachineAttribute] // RVA: 0x19B4C0 Offset: 0x19B5C1 VA: 0x19B4C0
	// RVA: 0x1C8FAD0 Offset: 0x1C8FBD1 VA: 0x1C8FAD0
	public IEnumerator SetTargetPosition(float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float moveSpeed) { }

	[IteratorStateMachineAttribute] // RVA: 0x19B530 Offset: 0x19B631 VA: 0x19B530
	// RVA: 0x1C8FBE0 Offset: 0x1C8FCE1 VA: 0x1C8FBE0
	private IEnumerator StartCameraReset() { }

	// RVA: 0x1C8FC70 Offset: 0x1C8FD71 VA: 0x1C8FC70
	public void CameraReset() { }

	// RVA: 0x1C90000 Offset: 0x1C90101 VA: 0x1C90000
	public void CameraResetRotateX() { }

	// RVA: 0x1C8FCD0 Offset: 0x1C8FDD1 VA: 0x1C8FCD0
	public Vector3 GetOwnerPosition() { }

	// RVA: 0x1C90250 Offset: 0x1C90351 VA: 0x1C90250
	private void UpdateCameraPosition() { }

	// RVA: 0x1C906C0 Offset: 0x1C907C1 VA: 0x1C906C0
	private void UpdateShortPlayCameraPosition() { }

	// RVA: 0x1C90A70 Offset: 0x1C90B71 VA: 0x1C90A70 Slot: 9
	public override void FrameUpdate() { }

	// RVA: 0x1C90A80 Offset: 0x1C90B81 VA: 0x1C90A80 Slot: 10
	public override void TimeStepUpdate() { }

	// RVA: 0x1C906A0 Offset: 0x1C907A1 VA: 0x1C906A0
	private static float Recal360to180(float val) { }

	// RVA: 0x1C90A90 Offset: 0x1C90B91 VA: 0x1C90A90
	public void AnimationStart(string motionId, float posX, float posY, float posZ, float rotX, float rotY, float rotZ) { }

	// RVA: 0x1C90B70 Offset: 0x1C90C71 VA: 0x1C90B70
	public void Shake(float amplitudeGain, float frequencyGain, float attackTime, float sutainTime, float decayTime) { }

	// RVA: 0x1C8F6A0 Offset: 0x1C8F7A1 VA: 0x1C8F6A0
	public void SetAnimatorEnable(bool enable) { }

	// RVA: 0x1C90C30 Offset: 0x1C90D31 VA: 0x1C90C30
	public void ForceUpdateMainCameraTransform() { }

	// RVA: 0x1C90D00 Offset: 0x1C90E01 VA: 0x1C90D00
	public void .ctor() { }
}

