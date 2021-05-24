[RequireComponent] // RVA: 0xE10C0 Offset: 0xE11C1 VA: 0xE10C0
[NativeHeaderAttribute] // RVA: 0xE10C0 Offset: 0xE11C1 VA: 0xE10C0
[RequiredByNativeCodeAttribute] // RVA: 0xE10C0 Offset: 0xE11C1 VA: 0xE10C0
public class Collider : Component // TypeDefIndex: 3430
{
	// Properties
	public bool enabled { get; set; }
	public Rigidbody attachedRigidbody { get; }
	public bool isTrigger { get; set; }
	public Bounds bounds { get; }
	[NativeMethodAttribute] // RVA: 0xE4630 Offset: 0xE4731 VA: 0xE4630
	public PhysicMaterial sharedMaterial { get; }
	public PhysicMaterial material { get; set; }

	// Methods

	// RVA: 0x350B9B0 Offset: 0x350BAB1 VA: 0x350B9B0
	public bool get_enabled() { }

	// RVA: 0x350BA00 Offset: 0x350BB01 VA: 0x350BA00
	public void set_enabled(bool value) { }

	[NativeMethodAttribute] // RVA: 0xE18E0 Offset: 0xE19E1 VA: 0xE18E0
	// RVA: 0x350BA50 Offset: 0x350BB51 VA: 0x350BA50
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x350BAA0 Offset: 0x350BBA1 VA: 0x350BAA0
	public bool get_isTrigger() { }

	// RVA: 0x350BAF0 Offset: 0x350BBF1 VA: 0x350BAF0
	public void set_isTrigger(bool value) { }

	// RVA: 0x350BB40 Offset: 0x350BC41 VA: 0x350BB40
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x350BC10 Offset: 0x350BD11 VA: 0x350BC10
	public Bounds get_bounds() { }

	// RVA: 0x350BCD0 Offset: 0x350BDD1 VA: 0x350BCD0
	public PhysicMaterial get_sharedMaterial() { }

	[NativeMethodAttribute] // RVA: 0xE1920 Offset: 0xE1A21 VA: 0xE1920
	// RVA: 0x350BD20 Offset: 0x350BE21 VA: 0x350BD20
	public PhysicMaterial get_material() { }

	[NativeMethodAttribute] // RVA: 0xE1960 Offset: 0xE1A61 VA: 0xE1960
	// RVA: 0x350BD70 Offset: 0x350BE71 VA: 0x350BD70
	public void set_material(PhysicMaterial value) { }

	// RVA: 0x350BDC0 Offset: 0x350BEC1 VA: 0x350BDC0
	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	// RVA: 0x350BF00 Offset: 0x350C001 VA: 0x350BF00
	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[NativeNameAttribute] // RVA: 0xE19A0 Offset: 0xE1AA1 VA: 0xE19A0
	// RVA: 0x350BFE0 Offset: 0x350C0E1 VA: 0x350BFE0
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x350C0C0 Offset: 0x350C1C1 VA: 0x350C0C0
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x350ABA0 Offset: 0x350ACA1 VA: 0x350ABA0
	public void .ctor() { }

	// RVA: 0x350BBB0 Offset: 0x350BCB1 VA: 0x350BBB0
	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x350BC80 Offset: 0x350BD81 VA: 0x350BC80
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x350BE80 Offset: 0x350BF81 VA: 0x350BE80
	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	// RVA: 0x350C050 Offset: 0x350C151 VA: 0x350C050
	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }
}

