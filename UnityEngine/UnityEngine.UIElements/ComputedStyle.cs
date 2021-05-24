internal struct ComputedStyle // TypeDefIndex: 4229
{
	// Fields
	private VisualElement m_Element; // 0x0

	// Properties
	private VisualElementStylesData stylesData { get; }
	private InheritedStylesData inheritedStylesData { get; }
	public StyleEnum<Overflow> overflow { get; }
	public StyleEnum<DisplayStyle> display { get; }
	public StyleEnum<Visibility> visibility { get; }

	// Methods

	// RVA: 0x4040 Offset: 0x4141 VA: 0x4040
	private VisualElementStylesData get_stylesData() { }

	// RVA: 0x4060 Offset: 0x4161 VA: 0x4060
	private InheritedStylesData get_inheritedStylesData() { }

	// RVA: 0x4080 Offset: 0x4181 VA: 0x4080
	public StyleEnum<Overflow> get_overflow() { }

	// RVA: 0x4100 Offset: 0x4201 VA: 0x4100
	public StyleEnum<DisplayStyle> get_display() { }

	// RVA: 0x4190 Offset: 0x4291 VA: 0x4190
	public StyleEnum<Visibility> get_visibility() { }
}

