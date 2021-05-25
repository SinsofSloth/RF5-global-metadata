[Serializable]
public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 3909
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x11AFC0 Offset: 0x11B0C1 VA: 0x11AFC0
	[SerializeField] // RVA: 0x11AFC0 Offset: 0x11B0C1 VA: 0x11AFC0
	private Color m_NormalColor; // 0x0
	[FormerlySerializedAsAttribute] // RVA: 0x11B010 Offset: 0x11B111 VA: 0x11B010
	[SerializeField] // RVA: 0x11B010 Offset: 0x11B111 VA: 0x11B010
	private Color m_HighlightedColor; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0x11B060 Offset: 0x11B161 VA: 0x11B060
	[SerializeField] // RVA: 0x11B060 Offset: 0x11B161 VA: 0x11B060
	private Color m_PressedColor; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0x11B0B0 Offset: 0x11B1B1 VA: 0x11B0B0
	[SerializeField] // RVA: 0x11B0B0 Offset: 0x11B1B1 VA: 0x11B0B0
	private Color m_SelectedColor; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0x11B100 Offset: 0x11B201 VA: 0x11B100
	[SerializeField] // RVA: 0x11B100 Offset: 0x11B201 VA: 0x11B100
	private Color m_DisabledColor; // 0x40
	[RangeAttribute] // RVA: 0x11B150 Offset: 0x11B251 VA: 0x11B150
	[SerializeField] // RVA: 0x11B150 Offset: 0x11B251 VA: 0x11B150
	private float m_ColorMultiplier; // 0x50
	[FormerlySerializedAsAttribute] // RVA: 0x11B190 Offset: 0x11B291 VA: 0x11B190
	[SerializeField] // RVA: 0x11B190 Offset: 0x11B291 VA: 0x11B190
	private float m_FadeDuration; // 0x54

	// Properties
	public Color normalColor { get; set; }
	public Color highlightedColor { get; set; }
	public Color pressedColor { get; set; }
	public Color selectedColor { get; set; }
	public Color disabledColor { get; set; }
	public float colorMultiplier { get; set; }
	public float fadeDuration { get; set; }
	public static ColorBlock defaultColorBlock { get; }

	// Methods

	// RVA: 0x5650 Offset: 0x5751 VA: 0x5650
	public Color get_normalColor() { }

	// RVA: 0x5660 Offset: 0x5761 VA: 0x5660
	public void set_normalColor(Color value) { }

	// RVA: 0x5680 Offset: 0x5781 VA: 0x5680
	public Color get_highlightedColor() { }

	// RVA: 0x5690 Offset: 0x5791 VA: 0x5690
	public void set_highlightedColor(Color value) { }

	// RVA: 0x56B0 Offset: 0x57B1 VA: 0x56B0
	public Color get_pressedColor() { }

	// RVA: 0x56C0 Offset: 0x57C1 VA: 0x56C0
	public void set_pressedColor(Color value) { }

	// RVA: 0x56E0 Offset: 0x57E1 VA: 0x56E0
	public Color get_selectedColor() { }

	// RVA: 0x56F0 Offset: 0x57F1 VA: 0x56F0
	public void set_selectedColor(Color value) { }

	// RVA: 0x5710 Offset: 0x5811 VA: 0x5710
	public Color get_disabledColor() { }

	// RVA: 0x5720 Offset: 0x5821 VA: 0x5720
	public void set_disabledColor(Color value) { }

	// RVA: 0x5740 Offset: 0x5841 VA: 0x5740
	public float get_colorMultiplier() { }

	// RVA: 0x5750 Offset: 0x5851 VA: 0x5750
	public void set_colorMultiplier(float value) { }

	// RVA: 0x5760 Offset: 0x5861 VA: 0x5760
	public float get_fadeDuration() { }

	// RVA: 0x5770 Offset: 0x5871 VA: 0x5770
	public void set_fadeDuration(float value) { }

	// RVA: 0x16492D0 Offset: 0x16493D1 VA: 0x16492D0
	public static ColorBlock get_defaultColorBlock() { }

	// RVA: 0x5780 Offset: 0x5881 VA: 0x5780 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5850 Offset: 0x5951 VA: 0x5850 Slot: 4
	public bool Equals(ColorBlock other) { }

	// RVA: 0x16496B0 Offset: 0x16497B1 VA: 0x16496B0
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x1649710 Offset: 0x1649811 VA: 0x1649710
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x58B0 Offset: 0x59B1 VA: 0x58B0 Slot: 2
	public override int GetHashCode() { }
}

