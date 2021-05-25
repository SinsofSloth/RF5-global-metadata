private class MessageDictionary.DictionaryEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 1222
{
	// Fields
	private MessageDictionary _methodDictionary; // 0x10
	private IDictionaryEnumerator _hashtableEnum; // 0x18
	private int _posMethod; // 0x20

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x17569B0 Offset: 0x1756AB1 VA: 0x17569B0
	public void .ctor(MessageDictionary methodDictionary) { }

	// RVA: 0x1756B40 Offset: 0x1756C41 VA: 0x1756B40 Slot: 8
	public object get_Current() { }

	// RVA: 0x1756D30 Offset: 0x1756E31 VA: 0x1756D30 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x1756F60 Offset: 0x1757061 VA: 0x1756F60 Slot: 9
	public void Reset() { }

	// RVA: 0x1756BB0 Offset: 0x1756CB1 VA: 0x1756BB0 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x1757020 Offset: 0x1757121 VA: 0x1757020 Slot: 4
	public object get_Key() { }

	// RVA: 0x1757030 Offset: 0x1757131 VA: 0x1757030 Slot: 5
	public object get_Value() { }
}

