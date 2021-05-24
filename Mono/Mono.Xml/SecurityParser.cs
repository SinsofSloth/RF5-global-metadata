internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler // TypeDefIndex: 22
{
	// Fields
	private SecurityElement root; // 0x68
	private SecurityElement current; // 0x70
	private Stack stack; // 0x78

	// Methods

	// RVA: 0x18F37F0 Offset: 0x18F38F1 VA: 0x18F37F0
	public void .ctor() { }

	// RVA: 0x18F3860 Offset: 0x18F3961 VA: 0x18F3860
	public void LoadXml(string xml) { }

	// RVA: 0x1907800 Offset: 0x1907901 VA: 0x1907800
	public SecurityElement ToXml() { }

	// RVA: 0x1907810 Offset: 0x1907911 VA: 0x1907810 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x1907820 Offset: 0x1907921 VA: 0x1907820 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x1907830 Offset: 0x1907931 VA: 0x1907830 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x1907840 Offset: 0x1907941 VA: 0x1907840 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1907B10 Offset: 0x1907C11 VA: 0x1907B10 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x1907BA0 Offset: 0x1907CA1 VA: 0x1907BA0 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x1907C30 Offset: 0x1907D31 VA: 0x1907C30 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }
}

