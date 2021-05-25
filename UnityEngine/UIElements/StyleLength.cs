public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength> // TypeDefIndex: 4238
{
	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private Length m_Value; // 0x4
	private int m_Specificity; // 0xC

	// Properties
	public Length value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x5000 Offset: 0x5101 VA: 0x5000 Slot: 4
	public Length get_value() { }

	// RVA: 0x5020 Offset: 0x5121 VA: 0x5020 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x5030 Offset: 0x5131 VA: 0x5030
	internal void .ctor(Length v, StyleKeyword keyword) { }

	// RVA: 0x15C9880 Offset: 0x15C9981 VA: 0x15C9880
	public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	// RVA: 0x5040 Offset: 0x5141 VA: 0x5040 Slot: 6
	public bool Equals(StyleLength other) { }

	// RVA: 0x5090 Offset: 0x5191 VA: 0x5090 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5150 Offset: 0x5251 VA: 0x5150 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x51D0 Offset: 0x52D1 VA: 0x51D0 Slot: 3
	public override string ToString() { }
}

