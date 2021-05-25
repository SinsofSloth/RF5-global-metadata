public struct TouchState : IEquatable<TouchState> // TypeDefIndex: 11590
{
	// Fields
	public long deltaTimeNanoSeconds; // 0x0
	public TouchAttribute attributes; // 0x8
	public int fingerId; // 0xC
	public int x; // 0x10
	public int y; // 0x14
	public int diameterX; // 0x18
	public int diameterY; // 0x1C
	public int rotationAngle; // 0x20
	private int _reserved; // 0x24

	// Methods

	// RVA: 0x38A440 Offset: 0x38A541 VA: 0x38A440 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C65760 Offset: 0x2C65861 VA: 0x2C65760
	public static bool op_Equality(TouchState lhs, TouchState rhs) { }

	// RVA: 0x2C797C0 Offset: 0x2C798C1 VA: 0x2C797C0
	public static bool op_Inequality(TouchState lhs, TouchState rhs) { }

	// RVA: 0x38A450 Offset: 0x38A551 VA: 0x38A450 Slot: 0
	public override bool Equals(object right) { }

	// RVA: 0x38A570 Offset: 0x38A671 VA: 0x38A570 Slot: 4
	public bool Equals(TouchState other) { }

	// RVA: 0x38A600 Offset: 0x38A701 VA: 0x38A600 Slot: 2
	public override int GetHashCode() { }
}

