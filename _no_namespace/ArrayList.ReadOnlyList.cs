[DefaultMemberAttribute] // RVA: 0xB2A10 Offset: 0xB2B11 VA: 0xB2A10
[Serializable]
private class ArrayList.ReadOnlyList : IList, ICollection, IEnumerable // TypeDefIndex: 1344
{
	// Fields
	private IList _list; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x185A810 Offset: 0x185A911 VA: 0x185A810
	internal void .ctor(IList l) { }

	// RVA: 0x185BB60 Offset: 0x185BC61 VA: 0x185BB60 Slot: 17
	public virtual int get_Count() { }

	// RVA: 0x185BC20 Offset: 0x185BD21 VA: 0x185BC20 Slot: 18
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x185BC30 Offset: 0x185BD31 VA: 0x185BC30 Slot: 19
	public virtual object get_Item(int index) { }

	// RVA: 0x185BCF0 Offset: 0x185BDF1 VA: 0x185BCF0 Slot: 20
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x185BD70 Offset: 0x185BE71 VA: 0x185BD70 Slot: 21
	public virtual int Add(object obj) { }

	// RVA: 0x185BDF0 Offset: 0x185BEF1 VA: 0x185BDF0 Slot: 22
	public virtual void Clear() { }

	// RVA: 0x185BE70 Offset: 0x185BF71 VA: 0x185BE70 Slot: 23
	public virtual bool Contains(object obj) { }

	// RVA: 0x185BF40 Offset: 0x185C041 VA: 0x185BF40 Slot: 24
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x185C010 Offset: 0x185C111 VA: 0x185C010 Slot: 25
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x185C0C0 Offset: 0x185C1C1 VA: 0x185C0C0 Slot: 26
	public virtual int IndexOf(object value) { }

	// RVA: 0x185C190 Offset: 0x185C291 VA: 0x185C190 Slot: 27
	public virtual void Insert(int index, object obj) { }

	// RVA: 0x185C210 Offset: 0x185C311 VA: 0x185C210 Slot: 28
	public virtual void Remove(object value) { }

	// RVA: 0x185C290 Offset: 0x185C391 VA: 0x185C290 Slot: 29
	public virtual void RemoveAt(int index) { }
}

