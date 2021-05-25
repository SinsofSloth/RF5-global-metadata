[Serializable]
public struct CoordRect // TypeDefIndex: 9727
{
	// Fields
	public Coord offset; // 0x0
	public Coord size; // 0x8

	// Properties
	public bool isZero { get; }
	public Coord Max { get; set; }
	public Coord Min { get; set; }
	public Coord Center { get; }

	// Methods

	// RVA: 0x379B90 Offset: 0x379C91 VA: 0x379B90
	public bool get_isZero() { }

	// RVA: 0x379BB0 Offset: 0x379CB1 VA: 0x379BB0
	public void .ctor(Coord offset, Coord size) { }

	// RVA: 0x379BC0 Offset: 0x379CC1 VA: 0x379BC0
	public void .ctor(int offsetX, int offsetZ, int sizeX, int sizeZ) { }

	// RVA: 0x379BE0 Offset: 0x379CE1 VA: 0x379BE0
	public void .ctor(float offsetX, float offsetZ, float sizeX, float sizeZ) { }

	// RVA: 0x379C00 Offset: 0x379D01 VA: 0x379C00
	public void .ctor(Rect r) { }

	// RVA: 0x379C90 Offset: 0x379D91 VA: 0x379C90
	public int GetPos(int x, int z) { }

	// RVA: 0x379CB0 Offset: 0x379DB1 VA: 0x379CB0
	public Coord get_Max() { }

	// RVA: 0x379CD0 Offset: 0x379DD1 VA: 0x379CD0
	public void set_Max(Coord value) { }

	// RVA: 0x379CF0 Offset: 0x379DF1 VA: 0x379CF0
	public Coord get_Min() { }

	// RVA: 0x379D00 Offset: 0x379E01 VA: 0x379D00
	public void set_Min(Coord value) { }

	// RVA: 0x379D10 Offset: 0x379E11 VA: 0x379D10
	public Coord get_Center() { }

	// RVA: 0x2AE6A70 Offset: 0x2AE6B71 VA: 0x2AE6A70
	public static bool op_GreaterThan(CoordRect c1, CoordRect c2) { }

	// RVA: 0x2AE6A90 Offset: 0x2AE6B91 VA: 0x2AE6A90
	public static bool op_LessThan(CoordRect c1, CoordRect c2) { }

	// RVA: 0x2AE6AB0 Offset: 0x2AE6BB1 VA: 0x2AE6AB0
	public static bool op_Equality(CoordRect c1, CoordRect c2) { }

	// RVA: 0x2AE6AF0 Offset: 0x2AE6BF1 VA: 0x2AE6AF0
	public static bool op_Inequality(CoordRect c1, CoordRect c2) { }

	// RVA: 0x2AE6B30 Offset: 0x2AE6C31 VA: 0x2AE6B30
	public static CoordRect op_Multiply(CoordRect c, int s) { }

	// RVA: 0x2AE6B60 Offset: 0x2AE6C61 VA: 0x2AE6B60
	public static CoordRect op_Multiply(CoordRect c, float s) { }

	// RVA: 0x2AE6BB0 Offset: 0x2AE6CB1 VA: 0x2AE6BB0
	public static CoordRect op_Division(CoordRect c, int s) { }

	// RVA: 0x379D40 Offset: 0x379E41 VA: 0x379D40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x379DD0 Offset: 0x379ED1 VA: 0x379DD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x379E00 Offset: 0x379F01 VA: 0x379E00
	public void Round(int val, bool inscribed = False) { }

	// RVA: 0x379E50 Offset: 0x379F51 VA: 0x379E50
	public void Round(CoordRect r, bool inscribed = False) { }

	// RVA: 0x379EA0 Offset: 0x379FA1 VA: 0x379EA0
	public void Clamp(Coord min, Coord max) { }

	// RVA: 0x2AE6F10 Offset: 0x2AE7011 VA: 0x2AE6F10
	public static CoordRect Intersect(CoordRect c1, CoordRect c2) { }

	// RVA: 0x379EB0 Offset: 0x379FB1 VA: 0x379EB0
	public Coord CoordByNum(int num) { }

	// RVA: 0x379ED0 Offset: 0x379FD1 VA: 0x379ED0
	public bool CheckInRange(int x, int z) { }

	// RVA: 0x379F20 Offset: 0x37A021 VA: 0x379F20
	public bool CheckInRange(Coord coord) { }

	// RVA: 0x379F80 Offset: 0x37A081 VA: 0x379F80
	public bool CheckInRangeAndBounds(int x, int z) { }

	// RVA: 0x379FE0 Offset: 0x37A0E1 VA: 0x379FE0
	public bool CheckInRangeAndBounds(Coord coord) { }

	// RVA: 0x37A040 Offset: 0x37A141 VA: 0x37A040
	public bool Divisible(float factor) { }

	// RVA: 0x37A110 Offset: 0x37A211 VA: 0x37A110 Slot: 3
	public override string ToString() { }

	// RVA: 0x37A120 Offset: 0x37A221 VA: 0x37A120
	public Vector2 ToWorldspace(Coord coord, Rect worldRect) { }

	// RVA: 0x37A210 Offset: 0x37A311 VA: 0x37A210
	public Coord ToLocalspace(Vector2 pos, Rect worldRect) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACE80 Offset: 0x1ACF81 VA: 0x1ACE80
	// RVA: 0x37A2F0 Offset: 0x37A3F1 VA: 0x37A2F0
	public IEnumerable<Coord> Cells(int cellSize) { }

	// RVA: 0x37A390 Offset: 0x37A491 VA: 0x37A390
	public CoordRect Expand(int n) { }

	// RVA: 0x37A3C0 Offset: 0x37A4C1 VA: 0x37A3C0
	public CoordRect Approximate(int val) { }
}

