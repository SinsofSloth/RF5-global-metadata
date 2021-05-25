[NativeHeaderAttribute] // RVA: 0xE1160 Offset: 0xE1261 VA: 0xE1160
public class CharacterController : Collider // TypeDefIndex: 3431
{
	// Properties
	public Vector3 velocity { get; }
	public bool isGrounded { get; }
	public CollisionFlags collisionFlags { get; }
	public float radius { get; set; }
	public float height { get; set; }
	public Vector3 center { get; set; }
	public float slopeLimit { get; set; }
	public float stepOffset { get; set; }
	public float skinWidth { get; set; }
	public float minMoveDistance { get; set; }
	public bool detectCollisions { get; set; }
	public bool enableOverlapRecovery { get; set; }

	// Methods

	// RVA: 0x350B090 Offset: 0x350B191 VA: 0x350B090
	public bool SimpleMove(Vector3 speed) { }

	// RVA: 0x350B140 Offset: 0x350B241 VA: 0x350B140
	public CollisionFlags Move(Vector3 motion) { }

	// RVA: 0x350B1F0 Offset: 0x350B2F1 VA: 0x350B1F0
	public Vector3 get_velocity() { }

	[NativeNameAttribute] // RVA: 0xE19E0 Offset: 0xE1AE1 VA: 0xE19E0
	// RVA: 0x350B2A0 Offset: 0x350B3A1 VA: 0x350B2A0
	public bool get_isGrounded() { }

	// RVA: 0x350B2F0 Offset: 0x350B3F1 VA: 0x350B2F0
	public CollisionFlags get_collisionFlags() { }

	// RVA: 0x350B340 Offset: 0x350B441 VA: 0x350B340
	public float get_radius() { }

	// RVA: 0x350B390 Offset: 0x350B491 VA: 0x350B390
	public void set_radius(float value) { }

	// RVA: 0x350B3E0 Offset: 0x350B4E1 VA: 0x350B3E0
	public float get_height() { }

	// RVA: 0x350B430 Offset: 0x350B531 VA: 0x350B430
	public void set_height(float value) { }

	// RVA: 0x350B480 Offset: 0x350B581 VA: 0x350B480
	public Vector3 get_center() { }

	// RVA: 0x350B530 Offset: 0x350B631 VA: 0x350B530
	public void set_center(Vector3 value) { }

	// RVA: 0x350B5E0 Offset: 0x350B6E1 VA: 0x350B5E0
	public float get_slopeLimit() { }

	// RVA: 0x350B630 Offset: 0x350B731 VA: 0x350B630
	public void set_slopeLimit(float value) { }

	// RVA: 0x350B680 Offset: 0x350B781 VA: 0x350B680
	public float get_stepOffset() { }

	// RVA: 0x350B6D0 Offset: 0x350B7D1 VA: 0x350B6D0
	public void set_stepOffset(float value) { }

	// RVA: 0x350B720 Offset: 0x350B821 VA: 0x350B720
	public float get_skinWidth() { }

	// RVA: 0x350B770 Offset: 0x350B871 VA: 0x350B770
	public void set_skinWidth(float value) { }

	// RVA: 0x350B7C0 Offset: 0x350B8C1 VA: 0x350B7C0
	public float get_minMoveDistance() { }

	// RVA: 0x350B810 Offset: 0x350B911 VA: 0x350B810
	public void set_minMoveDistance(float value) { }

	// RVA: 0x350B860 Offset: 0x350B961 VA: 0x350B860
	public bool get_detectCollisions() { }

	// RVA: 0x350B8B0 Offset: 0x350B9B1 VA: 0x350B8B0
	public void set_detectCollisions(bool value) { }

	// RVA: 0x350B900 Offset: 0x350BA01 VA: 0x350B900
	public bool get_enableOverlapRecovery() { }

	// RVA: 0x350B950 Offset: 0x350BA51 VA: 0x350B950
	public void set_enableOverlapRecovery(bool value) { }

	// RVA: 0x350B9A0 Offset: 0x350BAA1 VA: 0x350B9A0
	public void .ctor() { }

	// RVA: 0x350B0F0 Offset: 0x350B1F1 VA: 0x350B0F0
	private bool SimpleMove_Injected(ref Vector3 speed) { }

	// RVA: 0x350B1A0 Offset: 0x350B2A1 VA: 0x350B1A0
	private CollisionFlags Move_Injected(ref Vector3 motion) { }

	// RVA: 0x350B250 Offset: 0x350B351 VA: 0x350B250
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x350B4E0 Offset: 0x350B5E1 VA: 0x350B4E0
	private void get_center_Injected(out Vector3 ret) { }

	// RVA: 0x350B590 Offset: 0x350B691 VA: 0x350B590
	private void set_center_Injected(ref Vector3 value) { }
}

