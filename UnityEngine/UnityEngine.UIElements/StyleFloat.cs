public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat> // TypeDefIndex: 4235
{
	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private float m_Value; // 0x4
	private int m_Specificity; // 0x8

	// Properties
	public float value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x4910 Offset: 0x4A11 VA: 0x4910 Slot: 4
	public float get_value() { }

	// RVA: 0x4930 Offset: 0x4A31 VA: 0x4930 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x4940 Offset: 0x4A41 VA: 0x4940
	public void .ctor(float v) { }

	// RVA: 0x4950 Offset: 0x4A51 VA: 0x4950
	internal void .ctor(float v, StyleKeyword keyword) { }

	// RVA: 0x15C9010 Offset: 0x15C9111 VA: 0x15C9010
	public static bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	// RVA: 0x15C9040 Offset: 0x15C9141 VA: 0x15C9040
	public static StyleFloat op_Implicit(float v) { }

	// RVA: 0x4960 Offset: 0x4A61 VA: 0x4960 Slot: 6
	public bool Equals(StyleFloat other) { }

	// RVA: 0x4990 Offset: 0x4A91 VA: 0x4990 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4A70 Offset: 0x4B71 VA: 0x4A70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4AE0 Offset: 0x4BE1 VA: 0x4AE0 Slot: 3
	public override string ToString() { }
}

