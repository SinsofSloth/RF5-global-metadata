[DefaultMemberAttribute] // RVA: 0xB2B90 Offset: 0xB2C91 VA: 0xB2B90
[Serializable]
internal sealed class EmptyReadOnlyDictionaryInternal : IDictionary, ICollection, IEnumerable // TypeDefIndex: 1355
{
	// Properties
	public int Count { get; }
	public object Item { get; set; }
	public ICollection Keys { get; }

	// Methods

	// RVA: 0x185F0D0 Offset: 0x185F1D1 VA: 0x185F0D0
	public void .ctor() { }

	// RVA: 0x185F0E0 Offset: 0x185F1E1 VA: 0x185F0E0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x185F150 Offset: 0x185F251 VA: 0x185F150 Slot: 10
	public void CopyTo(Array array, int index) { }

	// RVA: 0x185F310 Offset: 0x185F411 VA: 0x185F310 Slot: 11
	public int get_Count() { }

	// RVA: 0x185F320 Offset: 0x185F421 VA: 0x185F320 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x185F3C0 Offset: 0x185F4C1 VA: 0x185F3C0 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x185F560 Offset: 0x185F661 VA: 0x185F560 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x185F5D0 Offset: 0x185F6D1 VA: 0x185F5D0 Slot: 7
	public bool Contains(object key) { }

	// RVA: 0x185F5E0 Offset: 0x185F6E1 VA: 0x185F5E0 Slot: 8
	public void Add(object key, object value) { }

	// RVA: 0x185F780 Offset: 0x185F881 VA: 0x185F780 Slot: 9
	public IDictionaryEnumerator GetEnumerator() { }
}

