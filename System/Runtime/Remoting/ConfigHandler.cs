internal class ConfigHandler : SmallXmlParser.IContentHandler // TypeDefIndex: 1111
{
	// Fields
	private ArrayList typeEntries; // 0x10
	private ArrayList channelInstances; // 0x18
	private ChannelData currentChannel; // 0x20
	private Stack currentProviderData; // 0x28
	private string currentClientUrl; // 0x30
	private string appName; // 0x38
	private string currentXmlPath; // 0x40
	private bool onlyDelayedChannels; // 0x48

	// Methods

	// RVA: 0x17420B0 Offset: 0x17421B1 VA: 0x17420B0
	public void .ctor(bool onlyDelayedChannels) { }

	// RVA: 0x1742180 Offset: 0x1742281 VA: 0x1742180
	private void ValidatePath(string element, string[] paths) { }

	// RVA: 0x1742280 Offset: 0x1742381 VA: 0x1742280
	private bool CheckPath(string path) { }

	// RVA: 0x1742370 Offset: 0x1742471 VA: 0x1742370 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x1742380 Offset: 0x1742481 VA: 0x1742380 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x1742390 Offset: 0x1742491 VA: 0x1742390 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x17423A0 Offset: 0x17424A1 VA: 0x17423A0 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1742570 Offset: 0x1742671 VA: 0x1742570
	public void ParseElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x17452E0 Offset: 0x17453E1 VA: 0x17452E0 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x17436F0 Offset: 0x17437F1 VA: 0x17436F0
	private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1743AA0 Offset: 0x1743BA1 VA: 0x1743AA0
	private void ReadLifetine(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1745390 Offset: 0x1745491 VA: 0x1745390
	private TimeSpan ParseTime(string s) { }

	// RVA: 0x1744150 Offset: 0x1744251 VA: 0x1744150
	private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0x17445E0 Offset: 0x17446E1 VA: 0x17445E0
	private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0x1744CA0 Offset: 0x1744DA1 VA: 0x1744CA0
	private void ReadClientActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1744DD0 Offset: 0x1744ED1 VA: 0x1744DD0
	private void ReadServiceActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1744A10 Offset: 0x1744B11 VA: 0x1744A10
	private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1744AF0 Offset: 0x1744BF1 VA: 0x1744AF0
	private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1744EA0 Offset: 0x1744FA1 VA: 0x1744EA0
	private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement) { }

	// RVA: 0x1745070 Offset: 0x1745171 VA: 0x1745070
	private void ReadPreload(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1745820 Offset: 0x1745921 VA: 0x1745820
	private string GetNotNull(SmallXmlParser.IAttrList attrs, string name) { }

	// RVA: 0x1745960 Offset: 0x1745A61 VA: 0x1745960
	private string ExtractAssembly(ref string type) { }

	// RVA: 0x1745A40 Offset: 0x1745B41 VA: 0x1745A40 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x1745A50 Offset: 0x1745B51 VA: 0x1745A50 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }
}

