[DefaultMemberAttribute] // RVA: 0xB30D0 Offset: 0xB31D1 VA: 0xB30D0
[Serializable]
private class SortedList.KeyList : IList, ICollection, IEnumerable // TypeDefIndex: 1386
{
	// Fields
	private SortedList sortedList; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x2974010 Offset: 0x2974111 VA: 0x2974010
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0x29747B0 Offset: 0x29748B1 VA: 0x29747B0 Slot: 17
	public virtual int get_Count() { }

	// RVA: 0x29747D0 Offset: 0x29748D1 VA: 0x29747D0 Slot: 18
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x29747E0 Offset: 0x29748E1 VA: 0x29747E0 Slot: 19
	public virtual int Add(object key) { }

	// RVA: 0x2974860 Offset: 0x2974961 VA: 0x2974860 Slot: 20
	public virtual void Clear() { }

	// RVA: 0x29748E0 Offset: 0x29749E1 VA: 0x29748E0 Slot: 21
	public virtual bool Contains(object key) { }

	// RVA: 0x2974910 Offset: 0x2974A11 VA: 0x2974910 Slot: 22
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2974A00 Offset: 0x2974B01 VA: 0x2974A00 Slot: 23
	public virtual void Insert(int index, object value) { }

	// RVA: 0x2974A80 Offset: 0x2974B81 VA: 0x2974A80 Slot: 24
	public virtual object get_Item(int index) { }

	// RVA: 0x2974AB0 Offset: 0x2974BB1 VA: 0x2974AB0 Slot: 25
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x2974B30 Offset: 0x2974C31 VA: 0x2974B30 Slot: 26
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2974BF0 Offset: 0x2974CF1 VA: 0x2974BF0 Slot: 27
	public virtual int IndexOf(object key) { }

	// RVA: 0x2974CF0 Offset: 0x2974DF1 VA: 0x2974CF0 Slot: 28
	public virtual void Remove(object key) { }

	// RVA: 0x2974D70 Offset: 0x2974E71 VA: 0x2974D70 Slot: 29
	public virtual void RemoveAt(int index) { }
}

