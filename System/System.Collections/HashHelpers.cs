[FriendAccessAllowedAttribute] // RVA: 0xB2CD0 Offset: 0xB2DD1 VA: 0xB2CD0
internal static class HashHelpers // TypeDefIndex: 1363
{
	// Fields
	public static readonly int[] primes; // 0x0
	private static ConditionalWeakTable<object, SerializationInfo> s_SerializationInfoTable; // 0x8

	// Properties
	internal static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable { get; }

	// Methods

	// RVA: 0x1860280 Offset: 0x1860381 VA: 0x1860280
	internal static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	[ReliabilityContractAttribute] // RVA: 0xB9A70 Offset: 0xB9B71 VA: 0xB9A70
	// RVA: 0x1860380 Offset: 0x1860481 VA: 0x1860380
	public static bool IsPrime(int candidate) { }

	[ReliabilityContractAttribute] // RVA: 0xB9A90 Offset: 0xB9B91 VA: 0xB9A90
	// RVA: 0x1860480 Offset: 0x1860581 VA: 0x1860480
	public static int GetPrime(int min) { }

	// RVA: 0x18606F0 Offset: 0x18607F1 VA: 0x18606F0
	public static int ExpandPrime(int oldSize) { }

	// RVA: 0x18607A0 Offset: 0x18608A1 VA: 0x18607A0
	private static void .cctor() { }
}

