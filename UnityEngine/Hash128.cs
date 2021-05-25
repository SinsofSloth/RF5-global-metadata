[UsedByNativeCodeAttribute] // RVA: 0xC5B30 Offset: 0xC5C31 VA: 0xC5B30
[NativeHeaderAttribute] // RVA: 0xC5B30 Offset: 0xC5C31 VA: 0xC5B30
[Serializable]
public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128> // TypeDefIndex: 2950
{
	// Fields
	private uint m_u32_0; // 0x0
	private uint m_u32_1; // 0x4
	private uint m_u32_2; // 0x8
	private uint m_u32_3; // 0xC

	// Methods

	// RVA: 0x17F50 Offset: 0x18051 VA: 0x17F50 Slot: 5
	public int CompareTo(Hash128 rhs) { }

	// RVA: 0x17FD0 Offset: 0x180D1 VA: 0x17FD0 Slot: 3
	public override string ToString() { }

	[FreeFunctionAttribute] // RVA: 0xD4A90 Offset: 0xD4B91 VA: 0xD4A90
	// RVA: 0x1A2BE20 Offset: 0x1A2BF21 VA: 0x1A2BE20
	public static Hash128 Parse(string hashString) { }

	[FreeFunctionAttribute] // RVA: 0xD4AE0 Offset: 0xD4BE1 VA: 0xD4AE0
	// RVA: 0x1A2BDD0 Offset: 0x1A2BED1 VA: 0x1A2BDD0
	internal static string Internal_Hash128ToString(Hash128 hash128) { }

	[FreeFunctionAttribute] // RVA: 0xD4B30 Offset: 0xD4C31 VA: 0xD4B30
	// RVA: 0x1A2BF20 Offset: 0x1A2C021 VA: 0x1A2BF20
	public static Hash128 Compute(string hashString) { }

	// RVA: 0x18020 Offset: 0x18121 VA: 0x18020 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x18130 Offset: 0x18231 VA: 0x18130 Slot: 6
	public bool Equals(Hash128 obj) { }

	// RVA: 0x18190 Offset: 0x18291 VA: 0x18190 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18200 Offset: 0x18301 VA: 0x18200 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x1A2C0E0 Offset: 0x1A2C1E1 VA: 0x1A2C0E0
	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	// RVA: 0x1A2BCB0 Offset: 0x1A2BDB1 VA: 0x1A2BCB0
	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	// RVA: 0x1A2BCF0 Offset: 0x1A2BDF1 VA: 0x1A2BCF0
	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	// RVA: 0x1A2BE80 Offset: 0x1A2BF81 VA: 0x1A2BE80
	private static void Parse_Injected(string hashString, out Hash128 ret) { }

	// RVA: 0x1A2BED0 Offset: 0x1A2BFD1 VA: 0x1A2BED0
	private static string Internal_Hash128ToString_Injected(ref Hash128 hash128) { }

	// RVA: 0x1A2BF80 Offset: 0x1A2C081 VA: 0x1A2BF80
	private static void Compute_Injected(string hashString, out Hash128 ret) { }
}

