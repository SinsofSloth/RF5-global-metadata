public struct TMP_Offset // TypeDefIndex: 5754
{
	// Fields
	private float m_Left; // 0x0
	private float m_Right; // 0x4
	private float m_Top; // 0x8
	private float m_Bottom; // 0xC
	private static readonly TMP_Offset k_ZeroOffset; // 0x0

	// Properties
	public float left { get; set; }
	public float right { get; set; }
	public float top { get; set; }
	public float bottom { get; set; }
	public float horizontal { get; set; }
	public float vertical { get; set; }
	public static TMP_Offset zero { get; }

	// Methods

	// RVA: 0x3F0 Offset: 0x4F1 VA: 0x3F0
	public float get_left() { }

	// RVA: 0x400 Offset: 0x501 VA: 0x400
	public void set_left(float value) { }

	// RVA: 0x410 Offset: 0x511 VA: 0x410
	public float get_right() { }

	// RVA: 0x420 Offset: 0x521 VA: 0x420
	public void set_right(float value) { }

	// RVA: 0x430 Offset: 0x531 VA: 0x430
	public float get_top() { }

	// RVA: 0x440 Offset: 0x541 VA: 0x440
	public void set_top(float value) { }

	// RVA: 0x450 Offset: 0x551 VA: 0x450
	public float get_bottom() { }

	// RVA: 0x460 Offset: 0x561 VA: 0x460
	public void set_bottom(float value) { }

	// RVA: 0x470 Offset: 0x571 VA: 0x470
	public float get_horizontal() { }

	// RVA: 0x480 Offset: 0x581 VA: 0x480
	public void set_horizontal(float value) { }

	// RVA: 0x490 Offset: 0x591 VA: 0x490
	public float get_vertical() { }

	// RVA: 0x4A0 Offset: 0x5A1 VA: 0x4A0
	public void set_vertical(float value) { }

	// RVA: 0x14C58A0 Offset: 0x14C59A1 VA: 0x14C58A0
	public static TMP_Offset get_zero() { }

	// RVA: 0x4B0 Offset: 0x5B1 VA: 0x4B0
	public void .ctor(float left, float right, float top, float bottom) { }

	// RVA: 0x4D0 Offset: 0x5D1 VA: 0x4D0
	public void .ctor(float horizontal, float vertical) { }

	// RVA: 0x14C5950 Offset: 0x14C5A51 VA: 0x14C5950
	public static bool op_Equality(TMP_Offset lhs, TMP_Offset rhs) { }

	// RVA: 0x14C5980 Offset: 0x14C5A81 VA: 0x14C5980
	public static bool op_Inequality(TMP_Offset lhs, TMP_Offset rhs) { }

	// RVA: 0x14C5A50 Offset: 0x14C5B51 VA: 0x14C5A50
	public static TMP_Offset op_Multiply(TMP_Offset a, float b) { }

	// RVA: 0x4F0 Offset: 0x5F1 VA: 0x4F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x570 Offset: 0x671 VA: 0x570 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x600 Offset: 0x701 VA: 0x600
	public bool Equals(TMP_Offset other) { }

	// RVA: 0x14C5C40 Offset: 0x14C5D41 VA: 0x14C5C40
	private static void .cctor() { }
}

