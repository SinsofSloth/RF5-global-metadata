public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont> // TypeDefIndex: 4236
{
	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private Font m_Value; // 0x8
	private int m_Specificity; // 0x10

	// Properties
	public Font value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x4BB0 Offset: 0x4CB1 VA: 0x4BB0 Slot: 4
	public Font get_value() { }

	// RVA: 0x4BD0 Offset: 0x4CD1 VA: 0x4BD0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x15C9280 Offset: 0x15C9381 VA: 0x15C9280
	public static bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	// RVA: 0x4BE0 Offset: 0x4CE1 VA: 0x4BE0 Slot: 6
	public bool Equals(StyleFont other) { }

	// RVA: 0x4C90 Offset: 0x4D91 VA: 0x4C90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4CA0 Offset: 0x4DA1 VA: 0x4CA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4D50 Offset: 0x4E51 VA: 0x4D50 Slot: 3
	public override string ToString() { }
}

