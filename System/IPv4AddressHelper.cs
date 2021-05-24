internal static class IPv4AddressHelper // TypeDefIndex: 1754
{
	// Methods

	// RVA: 0x28EF350 Offset: 0x28EF451 VA: 0x28EF350
	internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) { }

	// RVA: 0x28EF720 Offset: 0x28EF821 VA: 0x28EF720
	internal static int ParseHostNumber(string str, int start, int end) { }

	// RVA: 0x28EF970 Offset: 0x28EFA71 VA: 0x28EF970
	internal static bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	// RVA: 0x28EF9B0 Offset: 0x28EFAB1 VA: 0x28EF9B0
	internal static bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) { }

	// RVA: 0x28EFCA0 Offset: 0x28EFDA1 VA: 0x28EFCA0
	internal static long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile) { }

	// RVA: 0x28EF690 Offset: 0x28EF791 VA: 0x28EF690
	private static bool Parse(string name, byte* numbers, int start, int end) { }

	// RVA: 0x28EF760 Offset: 0x28EF861 VA: 0x28EF760
	private static bool ParseCanonical(string name, byte* numbers, int start, int end) { }
}

