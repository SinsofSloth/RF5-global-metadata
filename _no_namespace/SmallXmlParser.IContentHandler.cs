public interface SmallXmlParser.IContentHandler // TypeDefIndex: 24
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnStartParsing(SmallXmlParser parser) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEndParsing(SmallXmlParser parser) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnEndElement(string name) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnProcessingInstruction(string name, string text) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnChars(string text) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnIgnorableWhitespace(string text) { }
}

