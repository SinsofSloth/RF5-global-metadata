internal static class IPv6AddressHelper // TypeDefIndex: 1755
{
	// Methods

	// RVA: 0x28F0130 Offset: 0x28F0231 VA: 0x28F0130
	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	// RVA: 0x28F0830 Offset: 0x28F0931 VA: 0x28F0830
	internal static string CreateCanonicalName(ushort* numbers) { }

	// RVA: 0x28F1030 Offset: 0x28F1131 VA: 0x28F1030
	private static KeyValuePair<int, int> FindCompressionRange(ushort* numbers) { }

	// RVA: 0x28F1210 Offset: 0x28F1311 VA: 0x28F1210
	private static bool ShouldHaveIpv4Embedded(ushort* numbers) { }

	// RVA: 0x28F12B0 Offset: 0x28F13B1 VA: 0x28F12B0
	private static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress) { }

	// RVA: 0x28F16E0 Offset: 0x28F17E1 VA: 0x28F16E0
	internal static bool IsValid(char* name, int start, ref int end) { }

	// RVA: 0x28F16F0 Offset: 0x28F17F1 VA: 0x28F16F0
	internal static bool IsValidStrict(char* name, int start, ref int end) { }

	// RVA: 0x28F01F0 Offset: 0x28F02F1 VA: 0x28F01F0
	internal static bool Parse(string address, ushort* numbers, int start, ref string scopeId) { }
}

