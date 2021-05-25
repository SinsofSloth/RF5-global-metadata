[UsedByNativeCodeAttribute] // RVA: 0xC6160 Offset: 0xC6261 VA: 0xC6160
[DefaultMemberAttribute] // RVA: 0xC6160 Offset: 0xC6261 VA: 0xC6160
public struct Vector3Int : IEquatable<Vector3Int> // TypeDefIndex: 2970
{
	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private int m_Z; // 0x8
	private static readonly Vector3Int s_Zero; // 0x0
	private static readonly Vector3Int s_One; // 0xC
	private static readonly Vector3Int s_Up; // 0x18
	private static readonly Vector3Int s_Down; // 0x24
	private static readonly Vector3Int s_Left; // 0x30
	private static readonly Vector3Int s_Right; // 0x3C

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public int z { get; set; }
	public static Vector3Int zero { get; }

	// Methods

	// RVA: 0x21A20 Offset: 0x21B21 VA: 0x21A20
	public int get_x() { }

	// RVA: 0x21A30 Offset: 0x21B31 VA: 0x21A30
	public void set_x(int value) { }

	// RVA: 0x21A40 Offset: 0x21B41 VA: 0x21A40
	public int get_y() { }

	// RVA: 0x21A50 Offset: 0x21B51 VA: 0x21A50
	public void set_y(int value) { }

	// RVA: 0x21A60 Offset: 0x21B61 VA: 0x21A60
	public int get_z() { }

	// RVA: 0x21A70 Offset: 0x21B71 VA: 0x21A70
	public void set_z(int value) { }

	// RVA: 0x21A80 Offset: 0x21B81 VA: 0x21A80
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x1B7E250 Offset: 0x1B7E351 VA: 0x1B7E250
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x21A90 Offset: 0x21B91 VA: 0x21A90 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x21AA0 Offset: 0x21BA1 VA: 0x21AA0 Slot: 4
	public bool Equals(Vector3Int other) { }

	// RVA: 0x21B60 Offset: 0x21C61 VA: 0x21B60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21BE0 Offset: 0x21CE1 VA: 0x21BE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B7E650 Offset: 0x1B7E751 VA: 0x1B7E650
	public static Vector3Int get_zero() { }

	// RVA: 0x1B7E6C0 Offset: 0x1B7E7C1 VA: 0x1B7E6C0
	private static void .cctor() { }
}

