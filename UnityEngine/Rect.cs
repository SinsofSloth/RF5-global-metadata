[NativeHeaderAttribute] // RVA: 0xC47D0 Offset: 0xC48D1 VA: 0xC47D0
[NativeClassAttribute] // RVA: 0xC47D0 Offset: 0xC48D1 VA: 0xC47D0
[RequiredByNativeCodeAttribute] // RVA: 0xC47D0 Offset: 0xC48D1 VA: 0xC47D0
public struct Rect : IEquatable<Rect> // TypeDefIndex: 2861
{
	// Fields
	[NativeNameAttribute] // RVA: 0xC9B00 Offset: 0xC9C01 VA: 0xC9B00
	private float m_XMin; // 0x0
	[NativeNameAttribute] // RVA: 0xC9B40 Offset: 0xC9C41 VA: 0xC9B40
	private float m_YMin; // 0x4
	[NativeNameAttribute] // RVA: 0xC9B80 Offset: 0xC9C81 VA: 0xC9B80
	private float m_Width; // 0x8
	[NativeNameAttribute] // RVA: 0xC9BC0 Offset: 0xC9CC1 VA: 0xC9BC0
	private float m_Height; // 0xC

	// Properties
	public static Rect zero { get; }
	public float x { get; set; }
	public float y { get; set; }
	public Vector2 position { get; set; }
	public Vector2 center { get; set; }
	public Vector2 min { get; }
	public Vector2 max { get; }
	public float width { get; set; }
	public float height { get; set; }
	public Vector2 size { get; set; }
	public float xMin { get; set; }
	public float yMin { get; set; }
	public float xMax { get; set; }
	public float yMax { get; set; }

	// Methods

	// RVA: 0x382080 Offset: 0x382181 VA: 0x382080
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x3820A0 Offset: 0x3821A1 VA: 0x3820A0
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x3820C0 Offset: 0x3821C1 VA: 0x3820C0
	public void .ctor(Rect source) { }

	// RVA: 0x2B76890 Offset: 0x2B76991 VA: 0x2B76890
	public static Rect get_zero() { }

	// RVA: 0x2B768B0 Offset: 0x2B769B1 VA: 0x2B768B0
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	// RVA: 0x3820E0 Offset: 0x3821E1 VA: 0x3820E0
	public float get_x() { }

	// RVA: 0x3820F0 Offset: 0x3821F1 VA: 0x3820F0
	public void set_x(float value) { }

	// RVA: 0x382100 Offset: 0x382201 VA: 0x382100
	public float get_y() { }

	// RVA: 0x382110 Offset: 0x382211 VA: 0x382110
	public void set_y(float value) { }

	// RVA: 0x382120 Offset: 0x382221 VA: 0x382120
	public Vector2 get_position() { }

	// RVA: 0x382150 Offset: 0x382251 VA: 0x382150
	public void set_position(Vector2 value) { }

	// RVA: 0x382160 Offset: 0x382261 VA: 0x382160
	public Vector2 get_center() { }

	// RVA: 0x3821B0 Offset: 0x3822B1 VA: 0x3821B0
	public void set_center(Vector2 value) { }

	// RVA: 0x3821E0 Offset: 0x3822E1 VA: 0x3821E0
	public Vector2 get_min() { }

	// RVA: 0x382210 Offset: 0x382311 VA: 0x382210
	public Vector2 get_max() { }

	// RVA: 0x382250 Offset: 0x382351 VA: 0x382250
	public float get_width() { }

	// RVA: 0x382260 Offset: 0x382361 VA: 0x382260
	public void set_width(float value) { }

	// RVA: 0x382270 Offset: 0x382371 VA: 0x382270
	public float get_height() { }

	// RVA: 0x382280 Offset: 0x382381 VA: 0x382280
	public void set_height(float value) { }

	// RVA: 0x382290 Offset: 0x382391 VA: 0x382290
	public Vector2 get_size() { }

	// RVA: 0x3822C0 Offset: 0x3823C1 VA: 0x3822C0
	public void set_size(Vector2 value) { }

	// RVA: 0x3822D0 Offset: 0x3823D1 VA: 0x3822D0
	public float get_xMin() { }

	// RVA: 0x3822E0 Offset: 0x3823E1 VA: 0x3822E0
	public void set_xMin(float value) { }

	// RVA: 0x382300 Offset: 0x382401 VA: 0x382300
	public float get_yMin() { }

	// RVA: 0x382310 Offset: 0x382411 VA: 0x382310
	public void set_yMin(float value) { }

	// RVA: 0x382330 Offset: 0x382431 VA: 0x382330
	public float get_xMax() { }

	// RVA: 0x382340 Offset: 0x382441 VA: 0x382340
	public void set_xMax(float value) { }

	// RVA: 0x382350 Offset: 0x382451 VA: 0x382350
	public float get_yMax() { }

	// RVA: 0x382360 Offset: 0x382461 VA: 0x382360
	public void set_yMax(float value) { }

	// RVA: 0x382370 Offset: 0x382471 VA: 0x382370
	public bool Contains(Vector2 point) { }

	// RVA: 0x3823D0 Offset: 0x3824D1 VA: 0x3823D0
	public bool Contains(Vector3 point) { }

	// RVA: 0x2B76C10 Offset: 0x2B76D11 VA: 0x2B76C10
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0x382430 Offset: 0x382531 VA: 0x382430
	public bool Overlaps(Rect other) { }

	// RVA: 0x382490 Offset: 0x382591 VA: 0x382490
	public bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x2B76D30 Offset: 0x2B76E31 VA: 0x2B76D30
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x2B76D60 Offset: 0x2B76E61 VA: 0x2B76D60
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x382520 Offset: 0x382621 VA: 0x382520 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3825C0 Offset: 0x3826C1 VA: 0x3825C0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x3825D0 Offset: 0x3826D1 VA: 0x3825D0 Slot: 4
	public bool Equals(Rect other) { }

	// RVA: 0x382690 Offset: 0x382791 VA: 0x382690 Slot: 3
	public override string ToString() { }
}

