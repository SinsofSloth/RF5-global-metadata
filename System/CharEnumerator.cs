[ComVisibleAttribute] // RVA: 0xABC40 Offset: 0xABD41 VA: 0xABC40
[Serializable]
public sealed class CharEnumerator : IEnumerator, ICloneable, IEnumerator<char>, IDisposable // TypeDefIndex: 194
{
	// Fields
	private string str; // 0x10
	private int index; // 0x18
	private char currentElement; // 0x1C

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public char Current { get; }

	// Methods

	// RVA: 0x18591E0 Offset: 0x18592E1 VA: 0x18591E0
	internal void .ctor(string str) { }

	// RVA: 0x1859220 Offset: 0x1859321 VA: 0x1859220 Slot: 7
	public object Clone() { }

	// RVA: 0x1859230 Offset: 0x1859331 VA: 0x1859230 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x18592A0 Offset: 0x18593A1 VA: 0x18592A0 Slot: 9
	public void Dispose() { }

	// RVA: 0x18592C0 Offset: 0x18593C1 VA: 0x18592C0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x18593A0 Offset: 0x18594A1 VA: 0x18593A0 Slot: 8
	public char get_Current() { }

	// RVA: 0x1859460 Offset: 0x1859561 VA: 0x1859460 Slot: 6
	public void Reset() { }

	// RVA: 0x1859470 Offset: 0x1859571 VA: 0x1859470
	internal void .ctor() { }
}

