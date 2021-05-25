[DefaultMemberAttribute] // RVA: 0xC6110 Offset: 0xC6211 VA: 0xC6110
[UsedByNativeCodeAttribute] // RVA: 0xC6110 Offset: 0xC6211 VA: 0xC6110
public struct Vector2Int : IEquatable<Vector2Int> // TypeDefIndex: 2969
{
	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private static readonly Vector2Int s_Zero; // 0x0
	private static readonly Vector2Int s_One; // 0x8
	private static readonly Vector2Int s_Up; // 0x10
	private static readonly Vector2Int s_Down; // 0x18
	private static readonly Vector2Int s_Left; // 0x20
	private static readonly Vector2Int s_Right; // 0x28

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public static Vector2Int zero { get; }

	// Methods

	// RVA: 0x21380 Offset: 0x21481 VA: 0x21380
	public int get_x() { }

	// RVA: 0x21390 Offset: 0x21491 VA: 0x21390
	public void set_x(int value) { }

	// RVA: 0x213A0 Offset: 0x214A1 VA: 0x213A0
	public int get_y() { }

	// RVA: 0x213B0 Offset: 0x214B1 VA: 0x213B0
	public void set_y(int value) { }

	// RVA: 0x213C0 Offset: 0x214C1 VA: 0x213C0
	public void .ctor(int x, int y) { }

	// RVA: 0x1B7B840 Offset: 0x1B7B941 VA: 0x1B7B840
	public static Vector2 op_Implicit(Vector2Int v) { }

	// RVA: 0x213D0 Offset: 0x214D1 VA: 0x213D0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x21490 Offset: 0x21591 VA: 0x21490 Slot: 4
	public bool Equals(Vector2Int other) { }

	// RVA: 0x21500 Offset: 0x21601 VA: 0x21500 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21560 Offset: 0x21661 VA: 0x21560 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B7BB20 Offset: 0x1B7BC21 VA: 0x1B7BB20
	public static Vector2Int get_zero() { }

	// RVA: 0x1B7BB90 Offset: 0x1B7BC91 VA: 0x1B7BB90
	private static void .cctor() { }
}

