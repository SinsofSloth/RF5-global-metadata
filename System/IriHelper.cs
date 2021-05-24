internal static class IriHelper // TypeDefIndex: 1734
{
	// Methods

	// RVA: 0x28F1700 Offset: 0x28F1801 VA: 0x28F1700
	internal static bool CheckIriUnicodeRange(char unicode, bool isQuery) { }

	// RVA: 0x28F1760 Offset: 0x28F1861 VA: 0x28F1760
	internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery) { }

	// RVA: 0x28F1C20 Offset: 0x28F1D21 VA: 0x28F1C20
	internal static bool CheckIsReserved(char ch, UriComponents component) { }

	// RVA: 0x28F1D90 Offset: 0x28F1E91 VA: 0x28F1D90
	internal static string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component) { }
}

