internal static class UriHelper // TypeDefIndex: 1748
{
	// Fields
	private static readonly char[] HexUpperChars; // 0x0

	// Methods

	// RVA: 0x1BB7BE0 Offset: 0x1BB7CE1 VA: 0x1BB7BE0
	internal static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) { }

	// RVA: 0x1BB8270 Offset: 0x1BB8371 VA: 0x1BB8270
	private static char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) { }

	// RVA: 0x1BB88A0 Offset: 0x1BB89A1 VA: 0x1BB88A0
	internal static char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x1BB8990 Offset: 0x1BB8A91 VA: 0x1BB8990
	internal static char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x1BB9780 Offset: 0x1BB9881 VA: 0x1BB9780
	internal static void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	// RVA: 0x1BB83B0 Offset: 0x1BB84B1 VA: 0x1BB83B0
	internal static void EscapeAsciiChar(char ch, char[] to, ref int pos) { }

	// RVA: 0x1BB8500 Offset: 0x1BB8601 VA: 0x1BB8500
	internal static char EscapedAscii(char digit, char next) { }

	// RVA: 0x1BB96F0 Offset: 0x1BB97F1 VA: 0x1BB96F0
	internal static bool IsNotSafeForUnescape(char ch) { }

	// RVA: 0x1BB8720 Offset: 0x1BB8821 VA: 0x1BB8720
	private static bool IsReservedUnreservedOrHash(char c) { }

	// RVA: 0x1BB85C0 Offset: 0x1BB86C1 VA: 0x1BB85C0
	internal static bool IsUnreserved(char c) { }

	// RVA: 0x1BB9DC0 Offset: 0x1BB9EC1 VA: 0x1BB9DC0
	internal static bool Is3986Unreserved(char c) { }

	// RVA: 0x1BB9E80 Offset: 0x1BB9F81 VA: 0x1BB9E80
	private static void .cctor() { }
}

