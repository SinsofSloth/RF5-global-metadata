private class ListDictionaryInternal.NodeEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 1376
{
	// Fields
	private ListDictionaryInternal list; // 0x10
	private ListDictionaryInternal.DictionaryNode current; // 0x18
	private int version; // 0x20
	private bool start; // 0x24

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x2970F60 Offset: 0x2971061 VA: 0x2970F60
	public void .ctor(ListDictionaryInternal list) { }

	// RVA: 0x2971060 Offset: 0x2971161 VA: 0x2971060 Slot: 8
	public object get_Current() { }

	// RVA: 0x29710D0 Offset: 0x29711D1 VA: 0x29710D0 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x2971190 Offset: 0x2971291 VA: 0x2971190 Slot: 4
	public object get_Key() { }

	// RVA: 0x2971230 Offset: 0x2971331 VA: 0x2971230 Slot: 5
	public object get_Value() { }

	// RVA: 0x29712D0 Offset: 0x29713D1 VA: 0x29712D0 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x29713C0 Offset: 0x29714C1 VA: 0x29713C0 Slot: 9
	public void Reset() { }
}

