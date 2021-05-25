internal class SmallXmlParser // TypeDefIndex: 23
{
	// Fields
	private SmallXmlParser.IContentHandler handler; // 0x10
	private TextReader reader; // 0x18
	private Stack elementNames; // 0x20
	private Stack xmlSpaces; // 0x28
	private string xmlSpace; // 0x30
	private StringBuilder buffer; // 0x38
	private char[] nameBuffer; // 0x40
	private bool isWhitespace; // 0x48
	private SmallXmlParser.AttrListImpl attributes; // 0x50
	private int line; // 0x58
	private int column; // 0x5C
	private bool resetColumn; // 0x60

	// Methods

	// RVA: 0x19074D0 Offset: 0x19075D1 VA: 0x19074D0
	public void .ctor() { }

	// RVA: 0x1907CF0 Offset: 0x1907DF1 VA: 0x1907CF0
	private Exception Error(string msg) { }

	// RVA: 0x1907EC0 Offset: 0x1907FC1 VA: 0x1907EC0
	private Exception UnexpectedEndError() { }

	// RVA: 0x1907F90 Offset: 0x1908091 VA: 0x1907F90
	private bool IsNameChar(char c, bool start) { }

	// RVA: 0x19080B0 Offset: 0x19081B1 VA: 0x19080B0
	private bool IsWhitespace(int c) { }

	// RVA: 0x19080E0 Offset: 0x19081E1 VA: 0x19080E0
	public void SkipWhitespaces() { }

	// RVA: 0x1908210 Offset: 0x1908311 VA: 0x1908210
	private void HandleWhitespaces() { }

	// RVA: 0x19080F0 Offset: 0x19081F1 VA: 0x19080F0
	public void SkipWhitespaces(bool expected) { }

	// RVA: 0x19083B0 Offset: 0x19084B1 VA: 0x19083B0
	private int Peek() { }

	// RVA: 0x1908330 Offset: 0x1908431 VA: 0x1908330
	private int Read() { }

	// RVA: 0x19083D0 Offset: 0x19084D1 VA: 0x19083D0
	public void Expect(int c) { }

	// RVA: 0x1908510 Offset: 0x1908611 VA: 0x1908510
	private string ReadUntil(char until, bool handleReferences) { }

	// RVA: 0x1908920 Offset: 0x1908A21 VA: 0x1908920
	public string ReadName() { }

	// RVA: 0x1907600 Offset: 0x1907701 VA: 0x1907600
	public void Parse(TextReader input, SmallXmlParser.IContentHandler handler) { }

	// RVA: 0x1909740 Offset: 0x1909841 VA: 0x1909740
	private void Cleanup() { }

	// RVA: 0x1908CB0 Offset: 0x1908DB1 VA: 0x1908CB0
	public void ReadContent() { }

	// RVA: 0x19095E0 Offset: 0x19096E1 VA: 0x19095E0
	private void HandleBufferedContent() { }

	// RVA: 0x1909E10 Offset: 0x1909F11 VA: 0x1909E10
	private void ReadCharacters() { }

	// RVA: 0x1908710 Offset: 0x1908811 VA: 0x1908710
	private void ReadReference() { }

	// RVA: 0x1909F50 Offset: 0x190A051 VA: 0x1909F50
	private int ReadCharacterReference() { }

	// RVA: 0x1909C10 Offset: 0x1909D11 VA: 0x1909C10
	private void ReadAttribute(SmallXmlParser.AttrListImpl a) { }

	// RVA: 0x19098B0 Offset: 0x19099B1 VA: 0x19098B0
	private void ReadCDATASection() { }

	// RVA: 0x1909A50 Offset: 0x1909B51 VA: 0x1909A50
	private void ReadComment() { }
}

