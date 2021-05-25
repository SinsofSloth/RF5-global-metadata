[DefaultMemberAttribute] // RVA: 0xB3090 Offset: 0xB3191 VA: 0xB3090
[Serializable]
private class SortedList.SyncSortedList : SortedList // TypeDefIndex: 1384
{
	// Fields
	private SortedList _list; // 0x48
	private object _root; // 0x50

	// Properties
	public override int Count { get; }
	public override object SyncRoot { get; }
	public override object Item { get; set; }
	public override int Capacity { get; }

	// Methods

	// RVA: 0x2974670 Offset: 0x2974771 VA: 0x2974670
	internal void .ctor(SortedList list) { }

	// RVA: 0x29753B0 Offset: 0x29754B1 VA: 0x29753B0 Slot: 17
	public override int get_Count() { }

	// RVA: 0x2975480 Offset: 0x2975581 VA: 0x2975480 Slot: 20
	public override object get_SyncRoot() { }

	// RVA: 0x2975490 Offset: 0x2975591 VA: 0x2975490 Slot: 30
	public override object get_Item(object key) { }

	// RVA: 0x2975560 Offset: 0x2975661 VA: 0x2975560 Slot: 31
	public override void set_Item(object key, object value) { }

	// RVA: 0x2975630 Offset: 0x2975731 VA: 0x2975630 Slot: 14
	public override void Add(object key, object value) { }

	// RVA: 0x2975700 Offset: 0x2975801 VA: 0x2975700 Slot: 15
	public override int get_Capacity() { }

	// RVA: 0x29757D0 Offset: 0x29758D1 VA: 0x29757D0 Slot: 21
	public override object Clone() { }

	// RVA: 0x29758A0 Offset: 0x29759A1 VA: 0x29758A0 Slot: 22
	public override bool Contains(object key) { }

	// RVA: 0x2975970 Offset: 0x2975A71 VA: 0x2975970 Slot: 23
	public override bool ContainsValue(object key) { }

	// RVA: 0x2975A40 Offset: 0x2975B41 VA: 0x2975A40 Slot: 24
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x2975B10 Offset: 0x2975C11 VA: 0x2975B10 Slot: 25
	public override object GetByIndex(int index) { }

	// RVA: 0x2975BE0 Offset: 0x2975CE1 VA: 0x2975BE0 Slot: 26
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x2975CB0 Offset: 0x2975DB1 VA: 0x2975CB0 Slot: 27
	public override object GetKey(int index) { }

	// RVA: 0x2975D80 Offset: 0x2975E81 VA: 0x2975D80 Slot: 28
	public override IList GetKeyList() { }

	// RVA: 0x2975E50 Offset: 0x2975F51 VA: 0x2975E50 Slot: 29
	public override IList GetValueList() { }

	// RVA: 0x2975F20 Offset: 0x2976021 VA: 0x2975F20 Slot: 32
	public override int IndexOfKey(object key) { }

	// RVA: 0x2976080 Offset: 0x2976181 VA: 0x2976080 Slot: 33
	public override int IndexOfValue(object value) { }

	// RVA: 0x2976150 Offset: 0x2976251 VA: 0x2976150 Slot: 34
	public override void RemoveAt(int index) { }
}

