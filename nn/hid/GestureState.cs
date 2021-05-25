public struct GestureState // TypeDefIndex: 11554
{
	// Fields
	public long eventNumber; // 0x0
	public long contextNumber; // 0x8
	public int _type; // 0x10
	public int _direction; // 0x14
	public int x; // 0x18
	public int y; // 0x1C
	public int deltaX; // 0x20
	public int deltaY; // 0x24
	public Float2 velocity; // 0x28
	public GestureAttribute attributes; // 0x30
	public float scale; // 0x34
	public float rotationAngle; // 0x38
	public int pointCount; // 0x3C
	public GestureState.GesturePointArray4 points; // 0x40

	// Properties
	public GestureType type { get; }
	public GestureDirection direction { get; }
	public bool isDoubleTap { get; }

	// Methods

	// RVA: 0x3646A0 Offset: 0x3647A1 VA: 0x3646A0
	public void SetDefault() { }

	// RVA: 0x3646B0 Offset: 0x3647B1 VA: 0x3646B0
	public GestureType get_type() { }

	// RVA: 0x3646C0 Offset: 0x3647C1 VA: 0x3646C0
	public GestureDirection get_direction() { }

	// RVA: 0x3646D0 Offset: 0x3647D1 VA: 0x3646D0
	public bool get_isDoubleTap() { }

	// RVA: 0x3646E0 Offset: 0x3647E1 VA: 0x3646E0 Slot: 3
	public override string ToString() { }
}

