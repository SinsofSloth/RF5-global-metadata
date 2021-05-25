internal sealed class Tokenizer // TypeDefIndex: 901
{
	// Fields
	public int LineNo; // 0x10
	private int _inProcessingTag; // 0x14
	private byte[] _inBytes; // 0x18
	private char[] _inChars; // 0x20
	private string _inString; // 0x28
	private int _inIndex; // 0x30
	private int _inSize; // 0x34
	private int _inSavedCharacter; // 0x38
	private Tokenizer.TokenSource _inTokenSource; // 0x3C
	private Tokenizer.ITokenReader _inTokenReader; // 0x40
	private Tokenizer.StringMaker _maker; // 0x48
	private string[] _searchStrings; // 0x50
	private string[] _replaceStrings; // 0x58
	private int _inNestedIndex; // 0x60
	private int _inNestedSize; // 0x64
	private string _inNestedString; // 0x68

	// Methods

	// RVA: 0x2645160 Offset: 0x2645261 VA: 0x2645160
	internal void BasicInitialization() { }

	// RVA: 0x2644FA0 Offset: 0x26450A1 VA: 0x2644FA0
	public void Recycle() { }

	// RVA: 0x2645090 Offset: 0x2645191 VA: 0x2645090
	internal void .ctor(string input) { }

	// RVA: 0x26441B0 Offset: 0x26442B1 VA: 0x26441B0
	internal void ChangeFormat(Encoding encoding) { }

	// RVA: 0x26437E0 Offset: 0x26438E1 VA: 0x26437E0
	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	// RVA: 0x26458E0 Offset: 0x26459E1 VA: 0x26458E0
	private string GetStringToken() { }
}

