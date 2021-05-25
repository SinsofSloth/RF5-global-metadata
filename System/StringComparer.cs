[ComVisibleAttribute] // RVA: 0xAC7F0 Offset: 0xAC8F1 VA: 0xAC7F0
[Serializable]
public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 312
{
	// Fields
	private static readonly StringComparer _invariantCulture; // 0x0
	private static readonly StringComparer _invariantCultureIgnoreCase; // 0x8
	private static readonly StringComparer _ordinal; // 0x10
	private static readonly StringComparer _ordinalIgnoreCase; // 0x18

	// Properties
	public static StringComparer InvariantCultureIgnoreCase { get; }
	public static StringComparer CurrentCultureIgnoreCase { get; }
	public static StringComparer Ordinal { get; }
	public static StringComparer OrdinalIgnoreCase { get; }

	// Methods

	// RVA: 0x2A69C80 Offset: 0x2A69D81 VA: 0x2A69C80
	public static StringComparer get_InvariantCultureIgnoreCase() { }

	// RVA: 0x2A69CF0 Offset: 0x2A69DF1 VA: 0x2A69CF0
	public static StringComparer get_CurrentCultureIgnoreCase() { }

	// RVA: 0x2A69D80 Offset: 0x2A69E81 VA: 0x2A69D80
	public static StringComparer get_Ordinal() { }

	// RVA: 0x2A69DF0 Offset: 0x2A69EF1 VA: 0x2A69DF0
	public static StringComparer get_OrdinalIgnoreCase() { }

	// RVA: 0x2A69E60 Offset: 0x2A69F61 VA: 0x2A69E60 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x2A6A010 Offset: 0x2A6A111 VA: 0x2A6A010 Slot: 5
	public bool Equals(object x, object y) { }

	// RVA: 0x2A6A0E0 Offset: 0x2A6A1E1 VA: 0x2A6A0E0 Slot: 6
	public int GetHashCode(object obj) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int Compare(string x, string y) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool Equals(string x, string y) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetHashCode(string obj) { }

	// RVA: 0x2A6A1B0 Offset: 0x2A6A2B1 VA: 0x2A6A1B0
	protected void .ctor() { }

	// RVA: 0x2A6A1C0 Offset: 0x2A6A2C1 VA: 0x2A6A1C0
	private static void .cctor() { }
}

