[Serializable]
private class Hashtable.HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 1361
{
	// Fields
	private Hashtable hashtable; // 0x10
	private int bucket; // 0x18
	private int version; // 0x1C
	private bool current; // 0x20
	private int getObjectRetType; // 0x24
	private object currentKey; // 0x28
	private object currentValue; // 0x30

	// Properties
	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }

	// Methods

	// RVA: 0x296F010 Offset: 0x296F111 VA: 0x296F010
	internal void .ctor(Hashtable hashtable, int getObjRetType) { }

	// RVA: 0x296F080 Offset: 0x296F181 VA: 0x296F080 Slot: 10
	public object Clone() { }

	// RVA: 0x296F090 Offset: 0x296F191 VA: 0x296F090 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x296F130 Offset: 0x296F231 VA: 0x296F130 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x296F290 Offset: 0x296F391 VA: 0x296F290 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x296F350 Offset: 0x296F451 VA: 0x296F350 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x296F460 Offset: 0x296F561 VA: 0x296F460 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x296F500 Offset: 0x296F601 VA: 0x296F500 Slot: 16
	public virtual void Reset() { }
}

