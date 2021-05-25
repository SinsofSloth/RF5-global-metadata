[RequireComponent] // RVA: 0x148290 Offset: 0x148391 VA: 0x148290
[RequireComponent] // RVA: 0x148290 Offset: 0x148391 VA: 0x148290
public abstract class CharacterBase : MonoBehaviour // TypeDefIndex: 9398
{
	// Fields
	[HeaderAttribute] // RVA: 0x178970 Offset: 0x178A71 VA: 0x178970
	[TooltipAttribute] // RVA: 0x178970 Offset: 0x178A71 VA: 0x178970
	public Transform gravityTarget; // 0x18
	[TooltipAttribute] // RVA: 0x1789D0 Offset: 0x178AD1 VA: 0x1789D0
	public float gravityMultiplier; // 0x20
	public float airborneThreshold; // 0x24
	public float slopeStartAngle; // 0x28
	public float slopeEndAngle; // 0x2C
	public float spherecastRadius; // 0x30
	public LayerMask groundLayers; // 0x34
	private PhysicMaterial zeroFrictionMaterial; // 0x38
	private PhysicMaterial highFrictionMaterial; // 0x40
	protected Rigidbody r; // 0x48
	protected const float half = 0.5;
	protected float originalHeight; // 0x50
	protected Vector3 originalCenter; // 0x54
	protected CapsuleCollider capsule; // 0x60

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation) { }

	// RVA: 0x26C2250 Offset: 0x26C2351 VA: 0x26C2250
	protected Vector3 GetGravity() { }

	// RVA: 0x26C23E0 Offset: 0x26C24E1 VA: 0x26C23E0 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x26C25B0 Offset: 0x26C26B1 VA: 0x26C25B0 Slot: 6
	protected virtual RaycastHit GetSpherecastHit() { }

	// RVA: 0x26C2840 Offset: 0x26C2941 VA: 0x26C2840
	public float GetAngleFromForward(Vector3 worldDirection) { }

	// RVA: 0x26C2910 Offset: 0x26C2A11 VA: 0x26C2910
	protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle) { }

	// RVA: 0x26C2B00 Offset: 0x26C2C01 VA: 0x26C2B00
	protected void ScaleCapsule(float mlp) { }

	// RVA: 0x26C2CB0 Offset: 0x26C2DB1 VA: 0x26C2CB0
	protected void HighFriction() { }

	// RVA: 0x26C2CE0 Offset: 0x26C2DE1 VA: 0x26C2CE0
	protected void ZeroFriction() { }

	// RVA: 0x26C2D10 Offset: 0x26C2E11 VA: 0x26C2D10
	protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal) { }

	// RVA: 0x26C2E20 Offset: 0x26C2F21 VA: 0x26C2E20
	protected void .ctor() { }
}

