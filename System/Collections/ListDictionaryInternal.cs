[DefaultMemberAttribute] // RVA: 0xB2EF0 Offset: 0xB2FF1 VA: 0xB2EF0
[Serializable]
internal class ListDictionaryInternal : IDictionary, ICollection, IEnumerable // TypeDefIndex: 1375
{
	// Fields
	private ListDictionaryInternal.DictionaryNode head; // 0x10
	private int version; // 0x18
	private int count; // 0x1C

	// Properties
	public object Item { get; set; }
	public int Count { get; }
	public ICollection Keys { get; }

	// Methods

	// RVA: 0x29704A0 Offset: 0x29705A1 VA: 0x29704A0
	public void .ctor() { }

	// RVA: 0x29704B0 Offset: 0x29705B1 VA: 0x29704B0 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x29705A0 Offset: 0x29706A1 VA: 0x29705A0 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x2970810 Offset: 0x2970911 VA: 0x2970810 Slot: 11
	public int get_Count() { }

	// RVA: 0x2970820 Offset: 0x2970921 VA: 0x2970820 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x29708F0 Offset: 0x29709F1 VA: 0x29708F0 Slot: 8
	public void Add(object key, object value) { }

	// RVA: 0x2970BD0 Offset: 0x2970CD1 VA: 0x2970BD0 Slot: 7
	public bool Contains(object key) { }

	// RVA: 0x2970CC0 Offset: 0x2970DC1 VA: 0x2970CC0 Slot: 10
	public void CopyTo(Array array, int index) { }

	// RVA: 0x2970EC0 Offset: 0x2970FC1 VA: 0x2970EC0 Slot: 9
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x2970FC0 Offset: 0x29710C1 VA: 0x2970FC0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

