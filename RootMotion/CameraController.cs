public class CameraController : MonoBehaviour // TypeDefIndex: 9303
{
	// Fields
	public Transform target; // 0x18
	public Transform rotationSpace; // 0x20
	public CameraController.UpdateMode updateMode; // 0x28
	public bool lockCursor; // 0x2C
	[HeaderAttribute] // RVA: 0x1779C0 Offset: 0x177AC1 VA: 0x1779C0
	public bool smoothFollow; // 0x2D
	public Vector3 offset; // 0x30
	public float followSpeed; // 0x3C
	[HeaderAttribute] // RVA: 0x177A00 Offset: 0x177B01 VA: 0x177A00
	public float rotationSensitivity; // 0x40
	public float yMinLimit; // 0x44
	public float yMaxLimit; // 0x48
	public bool rotateAlways; // 0x4C
	public bool rotateOnLeftButton; // 0x4D
	public bool rotateOnRightButton; // 0x4E
	public bool rotateOnMiddleButton; // 0x4F
	[HeaderAttribute] // RVA: 0x177A40 Offset: 0x177B41 VA: 0x177A40
	public float distance; // 0x50
	public float minDistance; // 0x54
	public float maxDistance; // 0x58
	public float zoomSpeed; // 0x5C
	public float zoomSensitivity; // 0x60
	[HeaderAttribute] // RVA: 0x177A80 Offset: 0x177B81 VA: 0x177A80
	public LayerMask blockingLayers; // 0x64
	public float blockingRadius; // 0x68
	public float blockingSmoothTime; // 0x6C
	[RangeAttribute] // RVA: 0x177AC0 Offset: 0x177BC1 VA: 0x177AC0
	public float blockedOffset; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x177AE0 Offset: 0x177BE1 VA: 0x177AE0
	private float <x>k__BackingField; // 0x74
	[CompilerGeneratedAttribute] // RVA: 0x177AF0 Offset: 0x177BF1 VA: 0x177AF0
	private float <y>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x177B00 Offset: 0x177C01 VA: 0x177B00
	private float <distanceTarget>k__BackingField; // 0x7C
	private Vector3 targetDistance; // 0x80
	private Vector3 position; // 0x8C
	private Quaternion rotation; // 0x98
	private Vector3 smoothPosition; // 0xA8
	private Camera cam; // 0xB8
	private bool fixedFrame; // 0xC0
	private float fixedDeltaTime; // 0xC4
	private Quaternion r; // 0xC8
	private Vector3 lastUp; // 0xD8
	private float blockedDistance; // 0xE4
	private float blockedDistanceV; // 0xE8

	// Properties
	public float x { get; set; }
	public float y { get; set; }
	public float distanceTarget { get; set; }
	private float zoomAdd { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A9EB0 Offset: 0x1A9FB1 VA: 0x1A9EB0
	// RVA: 0x26BD620 Offset: 0x26BD721 VA: 0x26BD620
	public float get_x() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9EC0 Offset: 0x1A9FC1 VA: 0x1A9EC0
	// RVA: 0x26BD630 Offset: 0x26BD731 VA: 0x26BD630
	private void set_x(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9ED0 Offset: 0x1A9FD1 VA: 0x1A9ED0
	// RVA: 0x26BD640 Offset: 0x26BD741 VA: 0x26BD640
	public float get_y() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9EE0 Offset: 0x1A9FE1 VA: 0x1A9EE0
	// RVA: 0x26BD650 Offset: 0x26BD751 VA: 0x26BD650
	private void set_y(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9EF0 Offset: 0x1A9FF1 VA: 0x1A9EF0
	// RVA: 0x26BD660 Offset: 0x26BD761 VA: 0x26BD660
	public float get_distanceTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9F00 Offset: 0x1AA001 VA: 0x1A9F00
	// RVA: 0x26BD670 Offset: 0x26BD771 VA: 0x26BD670
	private void set_distanceTarget(float value) { }

	// RVA: 0x26BD680 Offset: 0x26BD781 VA: 0x26BD680
	public void SetAngles(Quaternion rotation) { }

	// RVA: 0x26BD6C0 Offset: 0x26BD7C1 VA: 0x26BD6C0
	public void SetAngles(float yaw, float pitch) { }

	// RVA: 0x26BD6D0 Offset: 0x26BD7D1 VA: 0x26BD6D0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x26BD800 Offset: 0x26BD901 VA: 0x26BD800 Slot: 5
	protected virtual void Update() { }

	// RVA: 0x26BD870 Offset: 0x26BD971 VA: 0x26BD870 Slot: 6
	protected virtual void FixedUpdate() { }

	// RVA: 0x26BD8E0 Offset: 0x26BD9E1 VA: 0x26BD8E0 Slot: 7
	protected virtual void LateUpdate() { }

	// RVA: 0x26BD950 Offset: 0x26BDA51 VA: 0x26BD950
	public void UpdateInput() { }

	// RVA: 0x26BD840 Offset: 0x26BD941 VA: 0x26BD840
	public void UpdateTransform() { }

	// RVA: 0x26BDBA0 Offset: 0x26BDCA1 VA: 0x26BDBA0
	public void UpdateTransform(float deltaTime) { }

	// RVA: 0x26BE250 Offset: 0x26BE351 VA: 0x26BE250
	private float get_zoomAdd() { }

	// RVA: 0x26BE1A0 Offset: 0x26BE2A1 VA: 0x26BE1A0
	private float ClampAngle(float angle, float min, float max) { }

	// RVA: 0x26BE2E0 Offset: 0x26BE3E1 VA: 0x26BE2E0
	public void .ctor() { }
}

