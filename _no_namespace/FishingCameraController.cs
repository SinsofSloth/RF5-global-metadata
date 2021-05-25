public class FishingCameraController : CameraControllerBase // TypeDefIndex: 6492
{
	// Fields
	[SerializeField] // RVA: 0x15CE30 Offset: 0x15CF31 VA: 0x15CE30
	private FishingCameraController.InputAxisSetting m_InputYAxis; // 0x28
	[SerializeField] // RVA: 0x15CE40 Offset: 0x15CF41 VA: 0x15CE40
	private AxisSetting m_YAxisSetting; // 0x30
	[RangeAttribute] // RVA: 0x15CE50 Offset: 0x15CF51 VA: 0x15CE50
	public float m_PlayerAhedLookForwardRange; // 0x38
	[RangeAttribute] // RVA: 0x15CE70 Offset: 0x15CF71 VA: 0x15CE70
	public float m_PlayerAheadLookForwardSpeed; // 0x3C
	[RangeAttribute] // RVA: 0x15CE90 Offset: 0x15CF91 VA: 0x15CE90
	public float m_RotatingLookPlayerSpeed; // 0x40
	public float m_CameraDistance; // 0x44
	public float m_AngleX; // 0x48
	private float m_SpeedYAxis; // 0x4C
	private float m_RotateYAxis; // 0x50
	private CinemachineFramingTransposer m_FramingTransposer; // 0x58
	private GameObject m_PlayerTarget; // 0x60
	private Vector3 m_FollowTargetPosition; // 0x68
	private Vector3 m_PrevAheadOffset; // 0x74

	// Properties
	public float RotateYAxis { get; set; }

	// Methods

	// RVA: 0x1D4E3B0 Offset: 0x1D4E4B1 VA: 0x1D4E3B0
	public float get_RotateYAxis() { }

	// RVA: 0x1D4E3C0 Offset: 0x1D4E4C1 VA: 0x1D4E3C0
	public void set_RotateYAxis(float value) { }

	// RVA: 0x1D4E3D0 Offset: 0x1D4E4D1 VA: 0x1D4E3D0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1D4E570 Offset: 0x1D4E671 VA: 0x1D4E570 Slot: 6
	public override void EnableCameraSetup(UseCameraType prevCameraType, CinemachineVirtualCamera vcam) { }

	// RVA: 0x1D4E6E0 Offset: 0x1D4E7E1 VA: 0x1D4E6E0 Slot: 9
	public override void FrameUpdate() { }

	// RVA: 0x1D4E810 Offset: 0x1D4E911 VA: 0x1D4E810
	private void BlendRotUpdate() { }

	// RVA: 0x1D4E9B0 Offset: 0x1D4EAB1 VA: 0x1D4E9B0
	private void TargetPositionUpdate() { }

	// RVA: 0x1D4E7D0 Offset: 0x1D4E8D1 VA: 0x1D4E7D0
	private void UpdateInputAxis() { }

	// RVA: 0x1D4E880 Offset: 0x1D4E981 VA: 0x1D4E880
	public void PositionUpdate() { }

	// RVA: 0x1D4ED40 Offset: 0x1D4EE41 VA: 0x1D4ED40
	public void .ctor() { }
}

