[UsedByNativeCodeAttribute] // RVA: 0xC4870 Offset: 0xC4971 VA: 0xC4870
public struct RectInt : IEquatable<RectInt> // TypeDefIndex: 2862
{
	// Fields
	private int m_XMin; // 0x0
	private int m_YMin; // 0x4
	private int m_Width; // 0x8
	private int m_Height; // 0xC

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public int width { get; set; }
	public int height { get; set; }
	public int xMax { get; }
	public int yMax { get; }

	// Methods

	// RVA: 0x3826A0 Offset: 0x3827A1 VA: 0x3826A0
	public int get_x() { }

	// RVA: 0x3826B0 Offset: 0x3827B1 VA: 0x3826B0
	public void set_x(int value) { }

	// RVA: 0x3826C0 Offset: 0x3827C1 VA: 0x3826C0
	public int get_y() { }

	// RVA: 0x3826D0 Offset: 0x3827D1 VA: 0x3826D0
	public void set_y(int value) { }

	// RVA: 0x3826E0 Offset: 0x3827E1 VA: 0x3826E0
	public int get_width() { }

	// RVA: 0x3826F0 Offset: 0x3827F1 VA: 0x3826F0
	public void set_width(int value) { }

	// RVA: 0x382700 Offset: 0x382801 VA: 0x382700
	public int get_height() { }

	// RVA: 0x382710 Offset: 0x382811 VA: 0x382710
	public void set_height(int value) { }

	// RVA: 0x382720 Offset: 0x382821 VA: 0x382720
	public int get_xMax() { }

	// RVA: 0x3827A0 Offset: 0x3828A1 VA: 0x3827A0
	public int get_yMax() { }

	// RVA: 0x382820 Offset: 0x382921 VA: 0x382820
	public void .ctor(int xMin, int yMin, int width, int height) { }

	// RVA: 0x382830 Offset: 0x382931 VA: 0x382830 Slot: 3
	public override string ToString() { }

	// RVA: 0x382840 Offset: 0x382941 VA: 0x382840 Slot: 4
	public bool Equals(RectInt other) { }
}

