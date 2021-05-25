[DefaultMemberAttribute] // RVA: 0xBC4A0 Offset: 0xBC5A1 VA: 0xBC4A0
[Serializable]
public class HybridDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 2051
{
	// Fields
	private ListDictionary list; // 0x10
	private Hashtable hashtable; // 0x18
	private bool caseInsensitive; // 0x20

	// Properties
	public object Item { get; set; }
	private ListDictionary List { get; }
	public int Count { get; }
	public ICollection Keys { get; }

	// Methods

	// RVA: 0x28E0CD0 Offset: 0x28E0DD1 VA: 0x28E0CD0
	public void .ctor() { }

	// RVA: 0x28E0CE0 Offset: 0x28E0DE1 VA: 0x28E0CE0 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x28E0F50 Offset: 0x28E1051 VA: 0x28E0F50 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x28E17D0 Offset: 0x28E18D1 VA: 0x28E17D0
	private ListDictionary get_List() { }

	// RVA: 0x28E10D0 Offset: 0x28E11D1 VA: 0x28E10D0
	private void ChangeOver() { }

	// RVA: 0x28E19C0 Offset: 0x28E1AC1 VA: 0x28E19C0 Slot: 11
	public int get_Count() { }

	// RVA: 0x28E1A00 Offset: 0x28E1B01 VA: 0x28E1A00 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x28E1B30 Offset: 0x28E1C31 VA: 0x28E1B30 Slot: 8
	public void Add(object key, object value) { }

	// RVA: 0x28E1EE0 Offset: 0x28E1FE1 VA: 0x28E1EE0 Slot: 7
	public bool Contains(object key) { }

	// RVA: 0x28E2140 Offset: 0x28E2241 VA: 0x28E2140 Slot: 10
	public void CopyTo(Array array, int index) { }

	// RVA: 0x28E2340 Offset: 0x28E2441 VA: 0x28E2340 Slot: 9
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x28E24F0 Offset: 0x28E25F1 VA: 0x28E24F0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

