[Serializable]
private class BitArray.BitArrayEnumeratorSimple : IEnumerator, ICloneable // TypeDefIndex: 1349
{
	// Fields
	private BitArray bitarray; // 0x10
	private int index; // 0x18
	private int version; // 0x1C
	private bool currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x185CD90 Offset: 0x185CE91 VA: 0x185CD90
	internal void .ctor(BitArray bitarray) { }

	// RVA: 0x185CDF0 Offset: 0x185CEF1 VA: 0x185CDF0 Slot: 7
	public object Clone() { }

	// RVA: 0x185CE00 Offset: 0x185CF01 VA: 0x185CE00 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x185CEF0 Offset: 0x185CFF1 VA: 0x185CEF0 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x185CFD0 Offset: 0x185D0D1 VA: 0x185CFD0 Slot: 6
	public void Reset() { }
}

