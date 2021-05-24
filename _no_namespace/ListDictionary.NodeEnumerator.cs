private class ListDictionary.NodeEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 2054
{
	// Fields
	private ListDictionary list; // 0x10
	private ListDictionary.DictionaryNode current; // 0x18
	private int version; // 0x20
	private bool start; // 0x24

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x28E2720 Offset: 0x28E2821 VA: 0x28E2720
	public void .ctor(ListDictionary list) { }

	// RVA: 0x28E2820 Offset: 0x28E2921 VA: 0x28E2820 Slot: 8
	public object get_Current() { }

	// RVA: 0x28E2890 Offset: 0x28E2991 VA: 0x28E2890 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x28E2940 Offset: 0x28E2A41 VA: 0x28E2940 Slot: 4
	public object get_Key() { }

	// RVA: 0x28E29D0 Offset: 0x28E2AD1 VA: 0x28E29D0 Slot: 5
	public object get_Value() { }

	// RVA: 0x28E2A60 Offset: 0x28E2B61 VA: 0x28E2A60 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x28E2B50 Offset: 0x28E2C51 VA: 0x28E2B50 Slot: 9
	public void Reset() { }
}

