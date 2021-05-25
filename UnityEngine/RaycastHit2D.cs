[RequiredByNativeCodeAttribute] // RVA: 0xFAF60 Offset: 0xFB061 VA: 0xFAF60
[NativeHeaderAttribute] // RVA: 0xFAF60 Offset: 0xFB061 VA: 0xFAF60
[NativeClassAttribute] // RVA: 0xFAF60 Offset: 0xFB061 VA: 0xFAF60
public struct RaycastHit2D // TypeDefIndex: 3644
{
	// Fields
	[NativeNameAttribute] // RVA: 0xFB800 Offset: 0xFB901 VA: 0xFB800
	private Vector2 m_Centroid; // 0x0
	[NativeNameAttribute] // RVA: 0xFB840 Offset: 0xFB941 VA: 0xFB840
	private Vector2 m_Point; // 0x8
	[NativeNameAttribute] // RVA: 0xFB880 Offset: 0xFB981 VA: 0xFB880
	private Vector2 m_Normal; // 0x10
	[NativeNameAttribute] // RVA: 0xFB8C0 Offset: 0xFB9C1 VA: 0xFB8C0
	private float m_Distance; // 0x18
	[NativeNameAttribute] // RVA: 0xFB900 Offset: 0xFBA01 VA: 0xFB900
	private float m_Fraction; // 0x1C
	[NativeNameAttribute] // RVA: 0xFB940 Offset: 0xFBA41 VA: 0xFB940
	private int m_Collider; // 0x20

	// Properties
	public Vector2 point { get; }
	public Vector2 normal { get; }
	public float distance { get; }
	public Collider2D collider { get; }

	// Methods

	// RVA: 0x246D0 Offset: 0x247D1 VA: 0x246D0
	public Vector2 get_point() { }

	// RVA: 0x246E0 Offset: 0x247E1 VA: 0x246E0
	public Vector2 get_normal() { }

	// RVA: 0x246F0 Offset: 0x247F1 VA: 0x246F0
	public float get_distance() { }

	// RVA: 0x24700 Offset: 0x24801 VA: 0x24700
	public Collider2D get_collider() { }

	// RVA: 0x1BC6640 Offset: 0x1BC6741 VA: 0x1BC6640
	public static bool op_Implicit(RaycastHit2D hit) { }
}

