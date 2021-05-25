[Serializable]
private class Queue.QueueEnumerator : IEnumerator, ICloneable // TypeDefIndex: 1381
{
	// Fields
	private Queue _q; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x2972820 Offset: 0x2972921 VA: 0x2972820
	internal void .ctor(Queue q) { }

	// RVA: 0x2972BC0 Offset: 0x2972CC1 VA: 0x2972BC0 Slot: 7
	public object Clone() { }

	// RVA: 0x2972BD0 Offset: 0x2972CD1 VA: 0x2972BD0 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x2972D10 Offset: 0x2972E11 VA: 0x2972D10 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x2972DD0 Offset: 0x2972ED1 VA: 0x2972DD0 Slot: 10
	public virtual void Reset() { }
}

