[UsedByNativeCodeAttribute] // RVA: 0xE0F90 Offset: 0xE1091 VA: 0xE0F90
[NativeHeaderAttribute] // RVA: 0xE0F90 Offset: 0xE1091 VA: 0xE0F90
[NativeHeaderAttribute] // RVA: 0xE0F90 Offset: 0xE1091 VA: 0xE0F90
[NativeHeaderAttribute] // RVA: 0xE0F90 Offset: 0xE1091 VA: 0xE0F90
public struct RaycastHit // TypeDefIndex: 3428
{
	// Fields
	[NativeNameAttribute] // RVA: 0xE15B0 Offset: 0xE16B1 VA: 0xE15B0
	internal Vector3 m_Point; // 0x0
	[NativeNameAttribute] // RVA: 0xE15F0 Offset: 0xE16F1 VA: 0xE15F0
	internal Vector3 m_Normal; // 0xC
	[NativeNameAttribute] // RVA: 0xE1630 Offset: 0xE1731 VA: 0xE1630
	internal uint m_FaceID; // 0x18
	[NativeNameAttribute] // RVA: 0xE1670 Offset: 0xE1771 VA: 0xE1670
	internal float m_Distance; // 0x1C
	[NativeNameAttribute] // RVA: 0xE16B0 Offset: 0xE17B1 VA: 0xE16B0
	internal Vector2 m_UV; // 0x20
	[NativeNameAttribute] // RVA: 0xE16F0 Offset: 0xE17F1 VA: 0xE16F0
	internal int m_Collider; // 0x28

	// Properties
	public Collider collider { get; }
	public Vector3 point { get; set; }
	public Vector3 normal { get; set; }
	public float distance { get; set; }
	public Transform transform { get; }
	public Rigidbody rigidbody { get; }

	// Methods

	// RVA: 0x3A3140 Offset: 0x3A3241 VA: 0x3A3140
	public Collider get_collider() { }

	// RVA: 0x3A3220 Offset: 0x3A3321 VA: 0x3A3220
	public Vector3 get_point() { }

	// RVA: 0x3A3230 Offset: 0x3A3331 VA: 0x3A3230
	public void set_point(Vector3 value) { }

	// RVA: 0x3A3240 Offset: 0x3A3341 VA: 0x3A3240
	public Vector3 get_normal() { }

	// RVA: 0x3A3250 Offset: 0x3A3351 VA: 0x3A3250
	public void set_normal(Vector3 value) { }

	// RVA: 0x3A3260 Offset: 0x3A3361 VA: 0x3A3260
	public float get_distance() { }

	// RVA: 0x3A3270 Offset: 0x3A3371 VA: 0x3A3270
	public void set_distance(float value) { }

	// RVA: 0x3A3280 Offset: 0x3A3381 VA: 0x3A3280
	public Transform get_transform() { }

	// RVA: 0x3A3290 Offset: 0x3A3391 VA: 0x3A3290
	public Rigidbody get_rigidbody() { }
}

