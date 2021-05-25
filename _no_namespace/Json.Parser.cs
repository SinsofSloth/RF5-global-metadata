private sealed class Json.Parser : IDisposable // TypeDefIndex: 4293
{
	// Fields
	private const string WORD_BREAK = "{}[],:\"";
	private StringReader json; // 0x10

	// Properties
	private char PeekChar { get; }
	private char NextChar { get; }
	private string NextWord { get; }
	private Json.Parser.TOKEN NextToken { get; }

	// Methods

	// RVA: 0x1A7E2A0 Offset: 0x1A7E3A1 VA: 0x1A7E2A0
	private void .ctor(string jsonString) { }

	// RVA: 0x1A7E330 Offset: 0x1A7E431 VA: 0x1A7E330
	private char get_PeekChar() { }

	// RVA: 0x1A7E3C0 Offset: 0x1A7E4C1 VA: 0x1A7E3C0
	private char get_NextChar() { }

	// RVA: 0x1A7E450 Offset: 0x1A7E551 VA: 0x1A7E450
	private string get_NextWord() { }

	// RVA: 0x1A7E730 Offset: 0x1A7E831 VA: 0x1A7E730
	private Json.Parser.TOKEN get_NextToken() { }

	// RVA: 0x1A7EAC0 Offset: 0x1A7EBC1 VA: 0x1A7EAC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A7E670 Offset: 0x1A7E771 VA: 0x1A7E670
	public static bool IsWordBreak(char c) { }

	// RVA: 0x1A7E010 Offset: 0x1A7E111 VA: 0x1A7E010
	public static object Parse(string jsonString) { }

	// RVA: 0x1A7EB30 Offset: 0x1A7EC31 VA: 0x1A7EB30
	private Dictionary<string, object> ParseObject() { }

	// RVA: 0x1A7F1A0 Offset: 0x1A7F2A1 VA: 0x1A7F1A0
	private List<object> ParseArray() { }

	// RVA: 0x1A7EB00 Offset: 0x1A7EC01 VA: 0x1A7EB00
	private object ParseValue() { }

	// RVA: 0x1A7F2B0 Offset: 0x1A7F3B1 VA: 0x1A7F2B0
	private object ParseByToken(Json.Parser.TOKEN token) { }

	// RVA: 0x1A7ECB0 Offset: 0x1A7EDB1 VA: 0x1A7ECB0
	private string ParseString() { }

	// RVA: 0x1A7F3C0 Offset: 0x1A7F4C1 VA: 0x1A7F3C0
	private object ParseNumber() { }

	// RVA: 0x1A7E990 Offset: 0x1A7EA91 VA: 0x1A7E990
	private void EatWhitespace() { }
}

