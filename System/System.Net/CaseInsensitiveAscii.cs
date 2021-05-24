internal class CaseInsensitiveAscii : IEqualityComparer, IComparer // TypeDefIndex: 1904
{
	// Fields
	internal static readonly CaseInsensitiveAscii StaticInstance; // 0x0
	internal static readonly byte[] AsciiToLower; // 0x8

	// Methods

	// RVA: 0x28F4160 Offset: 0x28F4261 VA: 0x28F4160 Slot: 5
	public int GetHashCode(object myObject) { }

	// RVA: 0x28F42B0 Offset: 0x28F43B1 VA: 0x28F42B0 Slot: 6
	public int Compare(object firstObject, object secondObject) { }

	// RVA: 0x28F4430 Offset: 0x28F4531 VA: 0x28F4430
	private int FastGetHashCode(string myString) { }

	// RVA: 0x28F4550 Offset: 0x28F4651 VA: 0x28F4550 Slot: 4
	public bool Equals(object firstObject, object secondObject) { }

	// RVA: 0x28F46E0 Offset: 0x28F47E1 VA: 0x28F46E0
	public void .ctor() { }

	// RVA: 0x28F46F0 Offset: 0x28F47F1 VA: 0x28F46F0
	private static void .cctor() { }
}

