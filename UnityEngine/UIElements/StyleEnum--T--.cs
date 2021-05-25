public struct StyleEnum<T> : IStyleValue<T>, IEquatable<StyleEnum<T>> // TypeDefIndex: 4234
{
	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private T m_Value; // 0x0
	private int m_Specificity; // 0x0

	// Properties
	public T value { get; }
	internal int specificity { set; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public T get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378FA0 Offset: 0x3790A1 VA: 0x378FA0
	|-StyleEnum<Int32Enum>.get_value
	|-StyleEnum<DisplayStyle>.get_value
	|-StyleEnum<Overflow>.get_value
	|-StyleEnum<Visibility>.get_value
	*/

	// RVA: -1 Offset: -1
	internal void set_specificity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378FC0 Offset: 0x3790C1 VA: 0x378FC0
	|-StyleEnum<Int32Enum>.set_specificity
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public StyleKeyword get_keyword() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378FD0 Offset: 0x3790D1 VA: 0x378FD0
	|-StyleEnum<Int32Enum>.get_keyword
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(T v, StyleKeyword keyword) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378FE0 Offset: 0x3790E1 VA: 0x378FE0
	|-StyleEnum<Int32Enum>..ctor
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(StyleEnum<T> lhs, StyleEnum<T> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AB5060 Offset: 0x2AB5161 VA: 0x2AB5060
	|-StyleEnum<Int32Enum>.op_Equality
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool Equals(StyleEnum<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x378FF0 Offset: 0x3790F1 VA: 0x378FF0
	|-StyleEnum<Int32Enum>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x379090 Offset: 0x379191 VA: 0x379090
	|-StyleEnum<Int32Enum>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3790A0 Offset: 0x3791A1 VA: 0x3790A0
	|-StyleEnum<Int32Enum>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3790B0 Offset: 0x3791B1 VA: 0x3790B0
	|-StyleEnum<Int32Enum>.ToString
	*/
}

