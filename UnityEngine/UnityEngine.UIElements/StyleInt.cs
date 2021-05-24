public struct StyleInt : IStyleValue<int>, IEquatable<StyleInt> // TypeDefIndex: 4237
{
	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private int m_Value; // 0x4
	private int m_Specificity; // 0x8

	// Properties
	public int value { get; }
	internal int specificity { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x4DD0 Offset: 0x4ED1 VA: 0x4DD0 Slot: 4
	public int get_value() { }

	// RVA: 0x4DF0 Offset: 0x4EF1 VA: 0x4DF0
	internal int get_specificity() { }

	// RVA: 0x4E00 Offset: 0x4F01 VA: 0x4E00 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x4E10 Offset: 0x4F11 VA: 0x4E10
	public void .ctor(int v) { }

	// RVA: 0x4E20 Offset: 0x4F21 VA: 0x4E20
	internal void .ctor(int v, StyleKeyword keyword) { }

	// RVA: 0x15C9640 Offset: 0x15C9741 VA: 0x15C9640
	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	// RVA: 0x15C9660 Offset: 0x15C9761 VA: 0x15C9660
	public static StyleInt op_Implicit(int v) { }

	// RVA: 0x4E30 Offset: 0x4F31 VA: 0x4E30 Slot: 6
	public bool Equals(StyleInt other) { }

	// RVA: 0x4E50 Offset: 0x4F51 VA: 0x4E50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4F10 Offset: 0x5011 VA: 0x4F10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4F80 Offset: 0x5081 VA: 0x4F80 Slot: 3
	public override string ToString() { }
}

