[DefaultMemberAttribute] // RVA: 0xB2C90 Offset: 0xB2D91 VA: 0xB2C90
[Serializable]
private class Hashtable.SyncHashtable : Hashtable, IEnumerable // TypeDefIndex: 1360
{
	// Fields
	protected Hashtable _table; // 0x50

	// Properties
	public override int Count { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }
	public override ICollection Keys { get; }

	// Methods

	// RVA: 0x296F880 Offset: 0x296F981 VA: 0x296F880
	internal void .ctor(Hashtable table) { }

	// RVA: 0x296F8C0 Offset: 0x296F9C1 VA: 0x296F8C0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x296FA40 Offset: 0x296FB41 VA: 0x296FA40 Slot: 31
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x296FBD0 Offset: 0x296FCD1 VA: 0x296FBD0 Slot: 30
	public override int get_Count() { }

	// RVA: 0x296FC00 Offset: 0x296FD01 VA: 0x296FC00 Slot: 22
	public override object get_Item(object key) { }

	// RVA: 0x296FC30 Offset: 0x296FD31 VA: 0x296FC30 Slot: 23
	public override void set_Item(object key, object value) { }

	// RVA: 0x296FD20 Offset: 0x296FE21 VA: 0x296FD20 Slot: 29
	public override object get_SyncRoot() { }

	// RVA: 0x296FD50 Offset: 0x296FE51 VA: 0x296FD50 Slot: 16
	public override void Add(object key, object value) { }

	// RVA: 0x296FE40 Offset: 0x296FF41 VA: 0x296FE40 Slot: 17
	public override void Clear() { }

	// RVA: 0x296FF10 Offset: 0x2970011 VA: 0x296FF10 Slot: 19
	public override bool Contains(object key) { }

	// RVA: 0x296FF40 Offset: 0x2970041 VA: 0x296FF40 Slot: 20
	public override bool ContainsKey(object key) { }

	// RVA: 0x2970010 Offset: 0x2970111 VA: 0x2970010 Slot: 21
	public override void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2970100 Offset: 0x2970201 VA: 0x2970100 Slot: 18
	public override object Clone() { }

	// RVA: 0x2970260 Offset: 0x2970361 VA: 0x2970260 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2970290 Offset: 0x2970391 VA: 0x2970290 Slot: 24
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x29702C0 Offset: 0x29703C1 VA: 0x29702C0 Slot: 27
	public override ICollection get_Keys() { }

	// RVA: 0x29703B0 Offset: 0x29704B1 VA: 0x29703B0 Slot: 28
	public override void Remove(object key) { }

	// RVA: 0x2970490 Offset: 0x2970591 VA: 0x2970490 Slot: 32
	public override void OnDeserialization(object sender) { }
}

