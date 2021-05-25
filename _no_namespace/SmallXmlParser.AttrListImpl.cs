private class SmallXmlParser.AttrListImpl : SmallXmlParser.IAttrList // TypeDefIndex: 26
{
	// Fields
	private List<string> attrNames; // 0x10
	private List<string> attrValues; // 0x18

	// Properties
	public int Length { get; }
	public string[] Names { get; }
	public string[] Values { get; }

	// Methods

	// RVA: 0x190A230 Offset: 0x190A331 VA: 0x190A230 Slot: 4
	public int get_Length() { }

	// RVA: 0x190A280 Offset: 0x190A381 VA: 0x190A280 Slot: 5
	public string GetName(int i) { }

	// RVA: 0x190A300 Offset: 0x190A401 VA: 0x190A300 Slot: 6
	public string GetValue(int i) { }

	// RVA: 0x190A380 Offset: 0x190A481 VA: 0x190A380 Slot: 7
	public string GetValue(string name) { }

	// RVA: 0x190A460 Offset: 0x190A561 VA: 0x190A460 Slot: 8
	public string[] get_Names() { }

	// RVA: 0x190A4C0 Offset: 0x190A5C1 VA: 0x190A4C0 Slot: 9
	public string[] get_Values() { }

	// RVA: 0x1909840 Offset: 0x1909941 VA: 0x1909840
	internal void Clear() { }

	// RVA: 0x190A1B0 Offset: 0x190A2B1 VA: 0x190A1B0
	internal void Add(string name, string value) { }

	// RVA: 0x1907C40 Offset: 0x1907D41 VA: 0x1907C40
	public void .ctor() { }
}

