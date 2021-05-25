internal sealed class TokenizerStream // TypeDefIndex: 908
{
	// Fields
	private int m_countTokens; // 0x10
	private TokenizerShortBlock m_headTokens; // 0x18
	private TokenizerShortBlock m_lastTokens; // 0x20
	private TokenizerShortBlock m_currentTokens; // 0x28
	private int m_indexTokens; // 0x30
	private TokenizerStringBlock m_headStrings; // 0x38
	private TokenizerStringBlock m_currentStrings; // 0x40
	private int m_indexStrings; // 0x48

	// Methods

	// RVA: 0x2644C00 Offset: 0x2644D01 VA: 0x2644C00
	internal void .ctor() { }

	// RVA: 0x2645330 Offset: 0x2645431 VA: 0x2645330
	internal void AddToken(short token) { }

	// RVA: 0x2645900 Offset: 0x2645A01 VA: 0x2645900
	internal void AddString(string str) { }

	// RVA: 0x2644D90 Offset: 0x2644E91 VA: 0x2644D90
	internal void Reset() { }

	// RVA: 0x2644DF0 Offset: 0x2644EF1 VA: 0x2644DF0
	internal short GetNextFullToken() { }

	// RVA: 0x2643250 Offset: 0x2643351 VA: 0x2643250
	internal short GetNextToken() { }

	// RVA: 0x2643300 Offset: 0x2643401 VA: 0x2643300
	internal string GetNextString() { }

	// RVA: 0x2643270 Offset: 0x2643371 VA: 0x2643270
	internal void ThrowAwayNextString() { }

	// RVA: 0x2643280 Offset: 0x2643381 VA: 0x2643280
	internal void TagLastToken(short tag) { }

	// RVA: 0x2645EE0 Offset: 0x2645FE1 VA: 0x2645EE0
	internal int GetTokenCount() { }

	// RVA: 0x2644120 Offset: 0x2644221 VA: 0x2644120
	internal void GoToPosition(int position) { }
}

