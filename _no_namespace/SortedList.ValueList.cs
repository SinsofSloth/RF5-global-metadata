[DefaultMemberAttribute] // RVA: 0xB3110 Offset: 0xB3211 VA: 0xB3110
[Serializable]
private class SortedList.ValueList : IList, ICollection, IEnumerable // TypeDefIndex: 1387
{
	// Fields
	private SortedList sortedList; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x2974100 Offset: 0x2974201 VA: 0x2974100
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0x2976210 Offset: 0x2976311 VA: 0x2976210 Slot: 17
	public virtual int get_Count() { }

	// RVA: 0x2976230 Offset: 0x2976331 VA: 0x2976230 Slot: 18
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x2976240 Offset: 0x2976341 VA: 0x2976240 Slot: 19
	public virtual int Add(object key) { }

	// RVA: 0x29762C0 Offset: 0x29763C1 VA: 0x29762C0 Slot: 20
	public virtual void Clear() { }

	// RVA: 0x2976340 Offset: 0x2976441 VA: 0x2976340 Slot: 21
	public virtual bool Contains(object value) { }

	// RVA: 0x2976370 Offset: 0x2976471 VA: 0x2976370 Slot: 22
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2976460 Offset: 0x2976561 VA: 0x2976460 Slot: 23
	public virtual void Insert(int index, object value) { }

	// RVA: 0x29764E0 Offset: 0x29765E1 VA: 0x29764E0 Slot: 24
	public virtual object get_Item(int index) { }

	// RVA: 0x2976510 Offset: 0x2976611 VA: 0x2976510 Slot: 25
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x2976590 Offset: 0x2976691 VA: 0x2976590 Slot: 26
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2976650 Offset: 0x2976751 VA: 0x2976650 Slot: 27
	public virtual int IndexOf(object value) { }

	// RVA: 0x29766E0 Offset: 0x29767E1 VA: 0x29766E0 Slot: 28
	public virtual void Remove(object value) { }

	// RVA: 0x2976760 Offset: 0x2976861 VA: 0x2976760 Slot: 29
	public virtual void RemoveAt(int index) { }
}

