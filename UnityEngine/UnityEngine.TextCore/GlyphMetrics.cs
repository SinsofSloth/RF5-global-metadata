[UsedByNativeCodeAttribute] // RVA: 0x100B90 Offset: 0x100C91 VA: 0x100B90
[Serializable]
public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 3679
{
	// Fields
	[SerializeField] // RVA: 0x101410 Offset: 0x101511 VA: 0x101410
	[NativeNameAttribute] // RVA: 0x101410 Offset: 0x101511 VA: 0x101410
	private float m_Width; // 0x0
	[NativeNameAttribute] // RVA: 0x101460 Offset: 0x101561 VA: 0x101460
	[SerializeField] // RVA: 0x101460 Offset: 0x101561 VA: 0x101460
	private float m_Height; // 0x4
	[SerializeField] // RVA: 0x1014B0 Offset: 0x1015B1 VA: 0x1014B0
	[NativeNameAttribute] // RVA: 0x1014B0 Offset: 0x1015B1 VA: 0x1014B0
	private float m_HorizontalBearingX; // 0x8
	[SerializeField] // RVA: 0x101500 Offset: 0x101601 VA: 0x101500
	[NativeNameAttribute] // RVA: 0x101500 Offset: 0x101601 VA: 0x101500
	private float m_HorizontalBearingY; // 0xC
	[SerializeField] // RVA: 0x101550 Offset: 0x101651 VA: 0x101550
	[NativeNameAttribute] // RVA: 0x101550 Offset: 0x101651 VA: 0x101550
	private float m_HorizontalAdvance; // 0x10

	// Properties
	public float width { get; }
	public float height { get; }
	public float horizontalBearingX { get; }
	public float horizontalBearingY { get; }
	public float horizontalAdvance { get; }

	// Methods

	// RVA: 0x24C80 Offset: 0x24D81 VA: 0x24C80
	public float get_width() { }

	// RVA: 0x24C90 Offset: 0x24D91 VA: 0x24C90
	public float get_height() { }

	// RVA: 0x24CA0 Offset: 0x24DA1 VA: 0x24CA0
	public float get_horizontalBearingX() { }

	// RVA: 0x24CB0 Offset: 0x24DB1 VA: 0x24CB0
	public float get_horizontalBearingY() { }

	// RVA: 0x24CC0 Offset: 0x24DC1 VA: 0x24CC0
	public float get_horizontalAdvance() { }

	// RVA: 0x24CD0 Offset: 0x24DD1 VA: 0x24CD0
	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	// RVA: 0x24CF0 Offset: 0x24DF1 VA: 0x24CF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24D70 Offset: 0x24E71 VA: 0x24D70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x24E00 Offset: 0x24F01 VA: 0x24E00 Slot: 4
	public bool Equals(GlyphMetrics other) { }
}

