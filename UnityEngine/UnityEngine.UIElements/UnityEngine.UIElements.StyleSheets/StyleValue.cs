[DebuggerDisplayAttribute] // RVA: 0x11E120 Offset: 0x11E221 VA: 0x11E120
internal struct StyleValue // TypeDefIndex: 4249
{
	// Fields
	public StylePropertyID id; // 0x0
	public StyleKeyword keyword; // 0x4
	public float number; // 0x8
	public Length length; // 0x8
	public Color color; // 0x8
	public GCHandle resource; // 0x8

	// Methods

	// RVA: 0x15CC160 Offset: 0x15CC261 VA: 0x15CC160
	public static StyleValue Create(StylePropertyID id) { }

	// RVA: 0x15CC130 Offset: 0x15CC231 VA: 0x15CC130
	public static StyleValue Create(StylePropertyID id, StyleKeyword keyword) { }

	// RVA: 0x15CC0F0 Offset: 0x15CC1F1 VA: 0x15CC0F0
	public static StyleValue Create(StylePropertyID id, float number) { }

	// RVA: 0x15CC110 Offset: 0x15CC211 VA: 0x15CC110
	public static StyleValue Create(StylePropertyID id, int number) { }

	// RVA: 0x15CC140 Offset: 0x15CC241 VA: 0x15CC140
	public static StyleValue Create(StylePropertyID id, Color color) { }
}

