[DefaultMemberAttribute] // RVA: 0xB2A50 Offset: 0xB2B51 VA: 0xB2A50
[Serializable]
private class ArrayList.ReadOnlyArrayList : ArrayList // TypeDefIndex: 1345
{
	// Fields
	private ArrayList _list; // 0x28

	// Properties
	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }
	public override int Capacity { set; }

	// Methods

	// RVA: 0x185A8F0 Offset: 0x185A9F1 VA: 0x185A8F0
	internal void .ctor(ArrayList l) { }

	// RVA: 0x185B390 Offset: 0x185B491 VA: 0x185B390 Slot: 19
	public override int get_Count() { }

	// RVA: 0x185B3C0 Offset: 0x185B4C1 VA: 0x185B3C0 Slot: 20
	public override bool get_IsReadOnly() { }

	// RVA: 0x185B3D0 Offset: 0x185B4D1 VA: 0x185B3D0 Slot: 22
	public override object get_Item(int index) { }

	// RVA: 0x185B400 Offset: 0x185B501 VA: 0x185B400 Slot: 23
	public override void set_Item(int index, object value) { }

	// RVA: 0x185B480 Offset: 0x185B581 VA: 0x185B480 Slot: 21
	public override object get_SyncRoot() { }

	// RVA: 0x185B4B0 Offset: 0x185B5B1 VA: 0x185B4B0 Slot: 24
	public override int Add(object obj) { }

	// RVA: 0x185B530 Offset: 0x185B631 VA: 0x185B530 Slot: 25
	public override void AddRange(ICollection c) { }

	// RVA: 0x185B5B0 Offset: 0x185B6B1 VA: 0x185B5B0 Slot: 18
	public override void set_Capacity(int value) { }

	// RVA: 0x185B630 Offset: 0x185B731 VA: 0x185B630 Slot: 26
	public override void Clear() { }

	// RVA: 0x185B6B0 Offset: 0x185B7B1 VA: 0x185B6B0 Slot: 27
	public override object Clone() { }

	// RVA: 0x185B790 Offset: 0x185B891 VA: 0x185B790 Slot: 28
	public override bool Contains(object obj) { }

	// RVA: 0x185B7C0 Offset: 0x185B8C1 VA: 0x185B7C0 Slot: 30
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x185B7F0 Offset: 0x185B8F1 VA: 0x185B7F0 Slot: 31
	public override void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x185B820 Offset: 0x185B921 VA: 0x185B820 Slot: 32
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x185B850 Offset: 0x185B951 VA: 0x185B850 Slot: 33
	public override int IndexOf(object value) { }

	// RVA: 0x185B880 Offset: 0x185B981 VA: 0x185B880 Slot: 34
	public override void Insert(int index, object obj) { }

	// RVA: 0x185B900 Offset: 0x185BA01 VA: 0x185B900 Slot: 35
	public override void InsertRange(int index, ICollection c) { }

	// RVA: 0x185B980 Offset: 0x185BA81 VA: 0x185B980 Slot: 36
	public override void Remove(object value) { }

	// RVA: 0x185BA00 Offset: 0x185BB01 VA: 0x185BA00 Slot: 37
	public override void RemoveAt(int index) { }

	// RVA: 0x185BA80 Offset: 0x185BB81 VA: 0x185BA80 Slot: 38
	public override void RemoveRange(int index, int count) { }

	// RVA: 0x185BB00 Offset: 0x185BC01 VA: 0x185BB00 Slot: 39
	public override object[] ToArray() { }

	// RVA: 0x185BB30 Offset: 0x185BC31 VA: 0x185BB30 Slot: 40
	public override Array ToArray(Type type) { }
}

