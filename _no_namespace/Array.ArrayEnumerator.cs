private sealed class Array.ArrayEnumerator : IEnumerator, ICloneable // TypeDefIndex: 121
{
	// Fields
	private Array _array; // 0x10
	private int _index; // 0x18
	private int _endIndex; // 0x1C

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x184D420 Offset: 0x184D521 VA: 0x184D420
	internal void .ctor(Array array) { }

	// RVA: 0x184E100 Offset: 0x184E201 VA: 0x184E100 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x184E130 Offset: 0x184E231 VA: 0x184E130 Slot: 6
	public void Reset() { }

	// RVA: 0x184E140 Offset: 0x184E241 VA: 0x184E140 Slot: 7
	public object Clone() { }

	// RVA: 0x184E150 Offset: 0x184E251 VA: 0x184E150 Slot: 5
	public object get_Current() { }
}

