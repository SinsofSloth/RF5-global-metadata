[UsedByNativeCodeAttribute] // RVA: 0x100B80 Offset: 0x100C81 VA: 0x100B80
[Serializable]
public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 3678
{
	// Fields
	[NativeNameAttribute] // RVA: 0x1012D0 Offset: 0x1013D1 VA: 0x1012D0
	[SerializeField] // RVA: 0x1012D0 Offset: 0x1013D1 VA: 0x1012D0
	private int m_X; // 0x0
	[SerializeField] // RVA: 0x101320 Offset: 0x101421 VA: 0x101320
	[NativeNameAttribute] // RVA: 0x101320 Offset: 0x101421 VA: 0x101320
	private int m_Y; // 0x4
	[SerializeField] // RVA: 0x101370 Offset: 0x101471 VA: 0x101370
	[NativeNameAttribute] // RVA: 0x101370 Offset: 0x101471 VA: 0x101370
	private int m_Width; // 0x8
	[NativeNameAttribute] // RVA: 0x1013C0 Offset: 0x1014C1 VA: 0x1013C0
	[SerializeField] // RVA: 0x1013C0 Offset: 0x1014C1 VA: 0x1013C0
	private int m_Height; // 0xC
	private static readonly GlyphRect s_ZeroGlyphRect; // 0x0

	// Properties
	public int x { get; }
	public int y { get; }
	public int width { get; }
	public int height { get; }
	public static GlyphRect zero { get; }

	// Methods

	// RVA: 0x24EC0 Offset: 0x24FC1 VA: 0x24EC0
	public int get_x() { }

	// RVA: 0x24ED0 Offset: 0x24FD1 VA: 0x24ED0
	public int get_y() { }

	// RVA: 0x24EE0 Offset: 0x24FE1 VA: 0x24EE0
	public int get_width() { }

	// RVA: 0x24EF0 Offset: 0x24FF1 VA: 0x24EF0
	public int get_height() { }

	// RVA: 0x1BC7B10 Offset: 0x1BC7C11 VA: 0x1BC7B10
	public static GlyphRect get_zero() { }

	// RVA: 0x24F00 Offset: 0x25001 VA: 0x24F00
	public void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x24F10 Offset: 0x25011 VA: 0x24F10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24F90 Offset: 0x25091 VA: 0x24F90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x25020 Offset: 0x25121 VA: 0x25020 Slot: 4
	public bool Equals(GlyphRect other) { }

	// RVA: 0x1BC7D50 Offset: 0x1BC7E51 VA: 0x1BC7D50
	private static void .cctor() { }
}

