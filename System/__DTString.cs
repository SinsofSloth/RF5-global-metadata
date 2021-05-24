internal struct __DTString // TypeDefIndex: 241
{
	// Fields
	internal string Value; // 0x0
	internal int Index; // 0x8
	internal int len; // 0xC
	internal char m_current; // 0x10
	private CompareInfo m_info; // 0x18
	private bool m_checkDigitToken; // 0x20
	private static char[] WhiteSpaceChecks; // 0x0

	// Properties
	internal CompareInfo CompareInfo { get; }

	// Methods

	// RVA: 0x1B870 Offset: 0x1B971 VA: 0x1B870
	internal void .ctor(string str, DateTimeFormatInfo dtfi, bool checkDigitToken) { }

	// RVA: 0x1B8A0 Offset: 0x1B9A1 VA: 0x1B8A0
	internal void .ctor(string str, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1B8B0 Offset: 0x1B9B1 VA: 0x1B8B0
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x1B8C0 Offset: 0x1B9C1 VA: 0x1B8C0
	internal bool GetNext() { }

	// RVA: 0x1B920 Offset: 0x1BA21 VA: 0x1B920
	internal bool AtEnd() { }

	// RVA: 0x1B930 Offset: 0x1BA31 VA: 0x1B930
	internal bool Advance(int count) { }

	// RVA: 0x1B990 Offset: 0x1BA91 VA: 0x1B990
	internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1B9A0 Offset: 0x1BAA1 VA: 0x1B9A0
	internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator) { }

	// RVA: 0x1B9B0 Offset: 0x1BAB1 VA: 0x1B9B0
	internal bool MatchSpecifiedWord(string target) { }

	// RVA: 0x1BA30 Offset: 0x1BB31 VA: 0x1BA30
	internal bool MatchSpecifiedWord(string target, int endIndex) { }

	// RVA: 0x1BAD0 Offset: 0x1BBD1 VA: 0x1BAD0
	internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength) { }

	// RVA: 0x1BAE0 Offset: 0x1BBE1 VA: 0x1BAE0
	internal bool Match(string str) { }

	// RVA: 0x1BBD0 Offset: 0x1BCD1 VA: 0x1BBD0
	internal bool Match(char ch) { }

	// RVA: 0x1BC60 Offset: 0x1BD61 VA: 0x1BC60
	internal int MatchLongestWords(string[] words, ref int maxMatchStrLen) { }

	// RVA: 0x1BD30 Offset: 0x1BE31 VA: 0x1BD30
	internal int GetRepeatCount() { }

	// RVA: 0x1BDC0 Offset: 0x1BEC1 VA: 0x1BDC0
	internal bool GetNextDigit() { }

	// RVA: 0x1BDD0 Offset: 0x1BED1 VA: 0x1BDD0
	internal char GetChar() { }

	// RVA: 0x1BE00 Offset: 0x1BF01 VA: 0x1BE00
	internal int GetDigit() { }

	// RVA: 0x1BE40 Offset: 0x1BF41 VA: 0x1BE40
	internal void SkipWhiteSpaces() { }

	// RVA: 0x1BE50 Offset: 0x1BF51 VA: 0x1BE50
	internal bool SkipWhiteSpaceCurrent() { }

	// RVA: 0x1BE60 Offset: 0x1BF61 VA: 0x1BE60
	internal void TrimTail() { }

	// RVA: 0x1BE70 Offset: 0x1BF71 VA: 0x1BE70
	internal void RemoveTrailingInQuoteSpaces() { }

	// RVA: 0x1BE80 Offset: 0x1BF81 VA: 0x1BE80
	internal void RemoveLeadingInQuoteSpaces() { }

	// RVA: 0x1BE90 Offset: 0x1BF91 VA: 0x1BE90
	internal DTSubString GetSubString() { }

	// RVA: 0x1BEA0 Offset: 0x1BFA1 VA: 0x1BEA0
	internal void ConsumeSubString(DTSubString sub) { }

	// RVA: 0x1AEA6A0 Offset: 0x1AEA7A1 VA: 0x1AEA6A0
	private static void .cctor() { }
}

