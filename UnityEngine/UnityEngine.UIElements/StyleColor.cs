public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor> // TypeDefIndex: 4233
{
	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private Color m_Value; // 0x4
	private int m_Specificity; // 0x14

	// Properties
	public Color value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x46C0 Offset: 0x47C1 VA: 0x46C0 Slot: 4
	public Color get_value() { }

	// RVA: 0x46F0 Offset: 0x47F1 VA: 0x46F0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x4700 Offset: 0x4801 VA: 0x4700
	public void .ctor(Color v) { }

	// RVA: 0x4720 Offset: 0x4821 VA: 0x4720
	internal void .ctor(Color v, StyleKeyword keyword) { }

	// RVA: 0x15C8DA0 Offset: 0x15C8EA1 VA: 0x15C8DA0
	public static bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	// RVA: 0x15C8DD0 Offset: 0x15C8ED1 VA: 0x15C8DD0
	public static StyleColor op_Implicit(Color v) { }

	// RVA: 0x4740 Offset: 0x4841 VA: 0x4740 Slot: 6
	public bool Equals(StyleColor other) { }

	// RVA: 0x4770 Offset: 0x4871 VA: 0x4770 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4820 Offset: 0x4921 VA: 0x4820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4890 Offset: 0x4991 VA: 0x4890 Slot: 3
	public override string ToString() { }
}

