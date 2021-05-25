[Serializable]
private class SortedList.SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 1385
{
	// Fields
	private SortedList sortedList; // 0x10
	private object key; // 0x18
	private object value; // 0x20
	private int index; // 0x28
	private int startIndex; // 0x2C
	private int endIndex; // 0x30
	private int version; // 0x34
	private bool current; // 0x38
	private int getObjectRetType; // 0x3C

	// Properties
	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }

	// Methods

	// RVA: 0x2973D50 Offset: 0x2973E51 VA: 0x2973D50
	internal void .ctor(SortedList sortedList, int index, int count, int getObjRetType) { }

	// RVA: 0x2974DF0 Offset: 0x2974EF1 VA: 0x2974DF0 Slot: 10
	public object Clone() { }

	// RVA: 0x2974E00 Offset: 0x2974F01 VA: 0x2974E00 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x2974EC0 Offset: 0x2974FC1 VA: 0x2974EC0 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x2975030 Offset: 0x2975131 VA: 0x2975030 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x2975110 Offset: 0x2975211 VA: 0x2975110 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x2975220 Offset: 0x2975321 VA: 0x2975220 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x29752E0 Offset: 0x29753E1 VA: 0x29752E0 Slot: 16
	public virtual void Reset() { }
}

