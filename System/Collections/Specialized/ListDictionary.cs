[DefaultMemberAttribute] // RVA: 0xBC4E0 Offset: 0xBC5E1 VA: 0xBC4E0
[Serializable]
public class ListDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 2053
{
	// Fields
	private ListDictionary.DictionaryNode head; // 0x10
	private int version; // 0x18
	private int count; // 0x1C
	private IComparer comparer; // 0x20

	// Properties
	public object Item { get; set; }
	public int Count { get; }
	public ICollection Keys { get; }

	// Methods

	// RVA: 0x28E26A0 Offset: 0x28E27A1 VA: 0x28E26A0
	public void .ctor() { }

	// RVA: 0x28E1790 Offset: 0x28E1891 VA: 0x28E1790
	public void .ctor(IComparer comparer) { }

	// RVA: 0x28E0DD0 Offset: 0x28E0ED1 VA: 0x28E0DD0 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x28E1580 Offset: 0x28E1681 VA: 0x28E1580 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x28E26C0 Offset: 0x28E27C1 VA: 0x28E26C0 Slot: 11
	public int get_Count() { }

	// RVA: 0x28E1AB0 Offset: 0x28E1BB1 VA: 0x28E1AB0 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x28E1CC0 Offset: 0x28E1DC1 VA: 0x28E1CC0 Slot: 8
	public void Add(object key, object value) { }

	// RVA: 0x28E1FD0 Offset: 0x28E20D1 VA: 0x28E1FD0 Slot: 7
	public bool Contains(object key) { }

	// RVA: 0x28E21B0 Offset: 0x28E22B1 VA: 0x28E21B0 Slot: 10
	public void CopyTo(Array array, int index) { }

	// RVA: 0x28E1920 Offset: 0x28E1A21 VA: 0x28E1920 Slot: 9
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x28E2780 Offset: 0x28E2881 VA: 0x28E2780 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

