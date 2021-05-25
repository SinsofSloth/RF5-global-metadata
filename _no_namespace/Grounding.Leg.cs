public class Grounding.Leg // TypeDefIndex: 9434
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x196320 Offset: 0x196421 VA: 0x196320
	private bool <isGrounded>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x196330 Offset: 0x196431 VA: 0x196330
	private Vector3 <IKPosition>k__BackingField; // 0x14
	public Quaternion rotationOffset; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x196340 Offset: 0x196441 VA: 0x196340
	private bool <initiated>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x196350 Offset: 0x196451 VA: 0x196350
	private float <heightFromGround>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x196360 Offset: 0x196461 VA: 0x196360
	private Vector3 <velocity>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x196370 Offset: 0x196471 VA: 0x196370
	private Transform <transform>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x196380 Offset: 0x196481 VA: 0x196380
	private float <IKOffset>k__BackingField; // 0x50
	public bool invertFootCenter; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x196390 Offset: 0x196491 VA: 0x196390
	private RaycastHit <heelHit>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x1963A0 Offset: 0x1964A1 VA: 0x1963A0
	private RaycastHit <capsuleHit>k__BackingField; // 0x84
	private Grounding grounding; // 0xB0
	private float lastTime; // 0xB8
	private float deltaTime; // 0xBC
	private Vector3 lastPosition; // 0xC0
	private Quaternion toHitNormal; // 0xCC
	private Quaternion r; // 0xDC
	private Vector3 up; // 0xEC
	private bool doOverrideFootPosition; // 0xF8
	private Vector3 overrideFootPosition; // 0xFC
	private Vector3 transformPosition; // 0x108

	// Properties
	public bool isGrounded { get; set; }
	public Vector3 IKPosition { get; set; }
	public bool initiated { get; set; }
	public float heightFromGround { get; set; }
	public Vector3 velocity { get; set; }
	public Transform transform { get; set; }
	public float IKOffset { get; set; }
	public RaycastHit heelHit { get; set; }
	public RaycastHit capsuleHit { get; set; }
	public RaycastHit GetHitPoint { get; }
	public float stepHeightFromGround { get; }
	private float rootYOffset { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1B5380 Offset: 0x1B5481 VA: 0x1B5380
	// RVA: 0x2B398D0 Offset: 0x2B399D1 VA: 0x2B398D0
	public bool get_isGrounded() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5390 Offset: 0x1B5491 VA: 0x1B5390
	// RVA: 0x2B398E0 Offset: 0x2B399E1 VA: 0x2B398E0
	private void set_isGrounded(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B53A0 Offset: 0x1B54A1 VA: 0x1B53A0
	// RVA: 0x2B398F0 Offset: 0x2B399F1 VA: 0x2B398F0
	public Vector3 get_IKPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B53B0 Offset: 0x1B54B1 VA: 0x1B53B0
	// RVA: 0x2B39900 Offset: 0x2B39A01 VA: 0x2B39900
	private void set_IKPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B53C0 Offset: 0x1B54C1 VA: 0x1B53C0
	// RVA: 0x2B39910 Offset: 0x2B39A11 VA: 0x2B39910
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B53D0 Offset: 0x1B54D1 VA: 0x1B53D0
	// RVA: 0x2B39920 Offset: 0x2B39A21 VA: 0x2B39920
	private void set_initiated(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B53E0 Offset: 0x1B54E1 VA: 0x1B53E0
	// RVA: 0x2B39930 Offset: 0x2B39A31 VA: 0x2B39930
	public float get_heightFromGround() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B53F0 Offset: 0x1B54F1 VA: 0x1B53F0
	// RVA: 0x2B39940 Offset: 0x2B39A41 VA: 0x2B39940
	private void set_heightFromGround(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5400 Offset: 0x1B5501 VA: 0x1B5400
	// RVA: 0x2B39950 Offset: 0x2B39A51 VA: 0x2B39950
	public Vector3 get_velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5410 Offset: 0x1B5511 VA: 0x1B5410
	// RVA: 0x2B39960 Offset: 0x2B39A61 VA: 0x2B39960
	private void set_velocity(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5420 Offset: 0x1B5521 VA: 0x1B5420
	// RVA: 0x2B39970 Offset: 0x2B39A71 VA: 0x2B39970
	public Transform get_transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5430 Offset: 0x1B5531 VA: 0x1B5430
	// RVA: 0x2B39980 Offset: 0x2B39A81 VA: 0x2B39980
	private void set_transform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5440 Offset: 0x1B5541 VA: 0x1B5440
	// RVA: 0x2B39990 Offset: 0x2B39A91 VA: 0x2B39990
	public float get_IKOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5450 Offset: 0x1B5551 VA: 0x1B5450
	// RVA: 0x2B399A0 Offset: 0x2B39AA1 VA: 0x2B399A0
	private void set_IKOffset(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5460 Offset: 0x1B5561 VA: 0x1B5460
	// RVA: 0x2B399B0 Offset: 0x2B39AB1 VA: 0x2B399B0
	public RaycastHit get_heelHit() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5470 Offset: 0x1B5571 VA: 0x1B5470
	// RVA: 0x2B399E0 Offset: 0x2B39AE1 VA: 0x2B399E0
	private void set_heelHit(RaycastHit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5480 Offset: 0x1B5581 VA: 0x1B5480
	// RVA: 0x2B39A00 Offset: 0x2B39B01 VA: 0x2B39A00
	public RaycastHit get_capsuleHit() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B5490 Offset: 0x1B5591 VA: 0x1B5490
	// RVA: 0x2B39A30 Offset: 0x2B39B31 VA: 0x2B39A30
	private void set_capsuleHit(RaycastHit value) { }

	// RVA: 0x2B39A50 Offset: 0x2B39B51 VA: 0x2B39A50
	public RaycastHit get_GetHitPoint() { }

	// RVA: 0x2B39AC0 Offset: 0x2B39BC1 VA: 0x2B39AC0
	public void SetFootPosition(Vector3 position) { }

	// RVA: 0x2B38500 Offset: 0x2B38601 VA: 0x2B38500
	public void Initiate(Grounding grounding, Transform transform) { }

	// RVA: 0x2B39AE0 Offset: 0x2B39BE1 VA: 0x2B39AE0
	public void OnEnable() { }

	// RVA: 0x2B393D0 Offset: 0x2B394D1 VA: 0x2B393D0
	public void Reset() { }

	// RVA: 0x2B38670 Offset: 0x2B38771 VA: 0x2B38670
	public void Process() { }

	// RVA: 0x2B3A850 Offset: 0x2B3A951 VA: 0x2B3A850
	public float get_stepHeightFromGround() { }

	// RVA: 0x2B3A2F0 Offset: 0x2B3A3F1 VA: 0x2B3A2F0
	private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel) { }

	// RVA: 0x2B39B30 Offset: 0x2B39C31 VA: 0x2B39B30
	private RaycastHit GetRaycastHit(Vector3 offsetFromHeel) { }

	// RVA: 0x2B3A9E0 Offset: 0x2B3AAE1 VA: 0x2B3A9E0
	private Vector3 RotateNormal(Vector3 normal) { }

	// RVA: 0x2B39F40 Offset: 0x2B3A041 VA: 0x2B39F40
	private void SetFootToPoint(Vector3 normal, Vector3 point) { }

	// RVA: 0x2B3A070 Offset: 0x2B3A171 VA: 0x2B3A070
	private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint) { }

	// RVA: 0x2B3AAE0 Offset: 0x2B3ABE1 VA: 0x2B3AAE0
	private float GetHeightFromGround(Vector3 hitPoint) { }

	// RVA: 0x2B3A8E0 Offset: 0x2B3A9E1 VA: 0x2B3A8E0
	private void RotateFoot() { }

	// RVA: 0x2B3AC70 Offset: 0x2B3AD71 VA: 0x2B3AC70
	private Quaternion GetRotationOffsetTarget() { }

	// RVA: 0x2B3AB40 Offset: 0x2B3AC41 VA: 0x2B3AB40
	private float get_rootYOffset() { }

	// RVA: 0x2B38440 Offset: 0x2B38541 VA: 0x2B38440
	public void .ctor() { }
}

