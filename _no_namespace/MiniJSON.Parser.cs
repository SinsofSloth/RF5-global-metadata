private sealed class MiniJSON.Parser : IDisposable // TypeDefIndex: 4677
{
	// Fields
	private StringReader json; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x12D580 Offset: 0x12D681 VA: 0x12D580
	private static Dictionary<string, int> <>f__switch$map0; // 0x0

	// Properties
	private char PeekChar { get; }
	private char NextChar { get; }
	private string NextWord { get; }
	private MiniJSON.Parser.TOKEN NextToken { get; }

	// Methods

	// RVA: 0x1B1F4D0 Offset: 0x1B1F5D1 VA: 0x1B1F4D0
	private void .ctor(string jsonString) { }

	// RVA: 0x1B1F560 Offset: 0x1B1F661 VA: 0x1B1F560
	public static bool IsWordBreak(char c) { }

	// RVA: 0x1B1F240 Offset: 0x1B1F341 VA: 0x1B1F240
	public static object Parse(string jsonString) { }

	// RVA: 0x1B1F650 Offset: 0x1B1F751 VA: 0x1B1F650 Slot: 4
	public void Dispose() { }

	// RVA: 0x1B1F690 Offset: 0x1B1F791 VA: 0x1B1F690
	private Dictionary<string, object> ParseObject() { }

	// RVA: 0x1B1FF80 Offset: 0x1B20081 VA: 0x1B1FF80
	private List<object> ParseArray() { }

	// RVA: 0x1B1F620 Offset: 0x1B1F721 VA: 0x1B1F620
	private object ParseValue() { }

	// RVA: 0x1B20090 Offset: 0x1B20191 VA: 0x1B20090
	private object ParseByToken(MiniJSON.Parser.TOKEN token) { }

	// RVA: 0x1B1FAE0 Offset: 0x1B1FBE1 VA: 0x1B1FAE0
	private string ParseString() { }

	// RVA: 0x1B201C0 Offset: 0x1B202C1 VA: 0x1B201C0
	private object ParseNumber() { }

	// RVA: 0x1B205C0 Offset: 0x1B206C1 VA: 0x1B205C0
	private void EatWhitespace() { }

	// RVA: 0x1B206F0 Offset: 0x1B207F1 VA: 0x1B206F0
	private char get_PeekChar() { }

	// RVA: 0x1B20310 Offset: 0x1B20411 VA: 0x1B20310
	private char get_NextChar() { }

	// RVA: 0x1B203A0 Offset: 0x1B204A1 VA: 0x1B203A0
	private string get_NextWord() { }

	// RVA: 0x1B1F810 Offset: 0x1B1F911 VA: 0x1B1F810
	private MiniJSON.Parser.TOKEN get_NextToken() { }
}

