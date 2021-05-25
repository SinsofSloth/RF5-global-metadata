[NativeHeaderAttribute] // RVA: 0xFAFF0 Offset: 0xFB0F1 VA: 0xFAFF0
[RequireComponent] // RVA: 0xFAFF0 Offset: 0xFB0F1 VA: 0xFAFF0
public sealed class Rigidbody2D : Component // TypeDefIndex: 3645
{
	// Properties
	public Vector2 position { get; set; }
	public float rotation { get; }
	public Vector2 velocity { get; set; }
	public float angularVelocity { get; set; }
	public float mass { get; set; }
	public float drag { get; set; }
	public float angularDrag { get; set; }
	public float gravityScale { get; set; }
	public RigidbodyType2D bodyType { get; set; }
	public bool isKinematic { get; set; }

	// Methods

	// RVA: 0x1BC6770 Offset: 0x1BC6871 VA: 0x1BC6770
	public Vector2 get_position() { }

	// RVA: 0x1BC6820 Offset: 0x1BC6921 VA: 0x1BC6820
	public void set_position(Vector2 value) { }

	// RVA: 0x1BC68D0 Offset: 0x1BC69D1 VA: 0x1BC68D0
	public float get_rotation() { }

	// RVA: 0x1BC6920 Offset: 0x1BC6A21 VA: 0x1BC6920
	public void MovePosition(Vector2 position) { }

	// RVA: 0x1BC69D0 Offset: 0x1BC6AD1 VA: 0x1BC69D0
	public void MoveRotation(float angle) { }

	[NativeMethodAttribute] // RVA: 0xFBD90 Offset: 0xFBE91 VA: 0xFBD90
	// RVA: 0x1BC6A20 Offset: 0x1BC6B21 VA: 0x1BC6A20
	private void MoveRotation_Angle(float angle) { }

	// RVA: 0x1BC6A70 Offset: 0x1BC6B71 VA: 0x1BC6A70
	public Vector2 get_velocity() { }

	// RVA: 0x1BC6B20 Offset: 0x1BC6C21 VA: 0x1BC6B20
	public void set_velocity(Vector2 value) { }

	// RVA: 0x1BC6BD0 Offset: 0x1BC6CD1 VA: 0x1BC6BD0
	public float get_angularVelocity() { }

	// RVA: 0x1BC6C20 Offset: 0x1BC6D21 VA: 0x1BC6C20
	public void set_angularVelocity(float value) { }

	// RVA: 0x1BC6C70 Offset: 0x1BC6D71 VA: 0x1BC6C70
	public float get_mass() { }

	// RVA: 0x1BC6CC0 Offset: 0x1BC6DC1 VA: 0x1BC6CC0
	public void set_mass(float value) { }

	// RVA: 0x1BC6D10 Offset: 0x1BC6E11 VA: 0x1BC6D10
	public float get_drag() { }

	// RVA: 0x1BC6D60 Offset: 0x1BC6E61 VA: 0x1BC6D60
	public void set_drag(float value) { }

	// RVA: 0x1BC6DB0 Offset: 0x1BC6EB1 VA: 0x1BC6DB0
	public float get_angularDrag() { }

	// RVA: 0x1BC6E00 Offset: 0x1BC6F01 VA: 0x1BC6E00
	public void set_angularDrag(float value) { }

	// RVA: 0x1BC6E50 Offset: 0x1BC6F51 VA: 0x1BC6E50
	public float get_gravityScale() { }

	// RVA: 0x1BC6EA0 Offset: 0x1BC6FA1 VA: 0x1BC6EA0
	public void set_gravityScale(float value) { }

	// RVA: 0x1BC6EF0 Offset: 0x1BC6FF1 VA: 0x1BC6EF0
	public RigidbodyType2D get_bodyType() { }

	[NativeMethodAttribute] // RVA: 0xFBDD0 Offset: 0xFBED1 VA: 0xFBDD0
	// RVA: 0x1BC6F40 Offset: 0x1BC7041 VA: 0x1BC6F40
	public void set_bodyType(RigidbodyType2D value) { }

	// RVA: 0x1BC6F90 Offset: 0x1BC7091 VA: 0x1BC6F90
	public bool get_isKinematic() { }

	// RVA: 0x1BC6FE0 Offset: 0x1BC70E1 VA: 0x1BC6FE0
	public void set_isKinematic(bool value) { }

	// RVA: 0x1BC7040 Offset: 0x1BC7141 VA: 0x1BC7040
	public bool IsSleeping() { }

	// RVA: 0x1BC7090 Offset: 0x1BC7191 VA: 0x1BC7090
	public void Sleep() { }

	[NativeMethodAttribute] // RVA: 0xFBE10 Offset: 0xFBF11 VA: 0xFBE10
	// RVA: 0x1BC70E0 Offset: 0x1BC71E1 VA: 0x1BC70E0
	public void WakeUp() { }

	[ExcludeFromDocsAttribute] // RVA: 0xFBE50 Offset: 0xFBF51 VA: 0xFBE50
	// RVA: 0x1BC7130 Offset: 0x1BC7231 VA: 0x1BC7130
	public void AddForce(Vector2 force) { }

	// RVA: 0x1BC7190 Offset: 0x1BC7291 VA: 0x1BC7190
	public void AddForce(Vector2 force, ForceMode2D mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xFBE60 Offset: 0xFBF61 VA: 0xFBE60
	// RVA: 0x1BC7250 Offset: 0x1BC7351 VA: 0x1BC7250
	public void AddForceAtPosition(Vector2 force, Vector2 position) { }

	// RVA: 0x1BC72B0 Offset: 0x1BC73B1 VA: 0x1BC72B0
	public void AddForceAtPosition(Vector2 force, Vector2 position, ForceMode2D mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xFBE70 Offset: 0xFBF71 VA: 0xFBE70
	// RVA: 0x1BC7390 Offset: 0x1BC7491 VA: 0x1BC7390
	public void AddTorque(float torque) { }

	// RVA: 0x1BC73F0 Offset: 0x1BC74F1 VA: 0x1BC73F0
	public void AddTorque(float torque, ForceMode2D mode) { }

	// RVA: 0x1BC7450 Offset: 0x1BC7551 VA: 0x1BC7450
	public void .ctor() { }

	// RVA: 0x1BC67D0 Offset: 0x1BC68D1 VA: 0x1BC67D0
	private void get_position_Injected(out Vector2 ret) { }

	// RVA: 0x1BC6880 Offset: 0x1BC6981 VA: 0x1BC6880
	private void set_position_Injected(ref Vector2 value) { }

	// RVA: 0x1BC6980 Offset: 0x1BC6A81 VA: 0x1BC6980
	private void MovePosition_Injected(ref Vector2 position) { }

	// RVA: 0x1BC6AD0 Offset: 0x1BC6BD1 VA: 0x1BC6AD0
	private void get_velocity_Injected(out Vector2 ret) { }

	// RVA: 0x1BC6B80 Offset: 0x1BC6C81 VA: 0x1BC6B80
	private void set_velocity_Injected(ref Vector2 value) { }

	// RVA: 0x1BC71F0 Offset: 0x1BC72F1 VA: 0x1BC71F0
	private void AddForce_Injected(ref Vector2 force, ForceMode2D mode) { }

	// RVA: 0x1BC7320 Offset: 0x1BC7421 VA: 0x1BC7320
	private void AddForceAtPosition_Injected(ref Vector2 force, ref Vector2 position, ForceMode2D mode) { }
}

