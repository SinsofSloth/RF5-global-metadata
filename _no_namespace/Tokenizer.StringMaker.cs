[Serializable]
internal sealed class Tokenizer.StringMaker // TypeDefIndex: 903
{
	// Fields
	private string[] aStrings; // 0x10
	private uint cStringsMax; // 0x18
	private uint cStringsUsed; // 0x1C
	public StringBuilder _outStringBuilder; // 0x20
	public char[] _outChars; // 0x28
	public int _outIndex; // 0x30

	// Methods

	// RVA: 0x2645AE0 Offset: 0x2645BE1 VA: 0x2645AE0
	private static uint HashString(string str) { }

	// RVA: 0x2645BC0 Offset: 0x2645CC1 VA: 0x2645BC0
	private static uint HashCharArray(char[] a, int l) { }

	// RVA: 0x2645C30 Offset: 0x2645D31 VA: 0x2645C30
	public void .ctor() { }

	// RVA: 0x2645CD0 Offset: 0x2645DD1 VA: 0x2645CD0
	private bool CompareStringAndChars(string str, char[] a, int l) { }

	// RVA: 0x263F780 Offset: 0x263F881 VA: 0x263F780
	public string MakeString() { }
}

