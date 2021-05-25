internal class GroupEnumerator : IEnumerator // TypeDefIndex: 1782
{
	// Fields
	internal GroupCollection _rgc; // 0x10
	internal int _curindex; // 0x18

	// Properties
	public object Current { get; }
	public Capture Capture { get; }

	// Methods

	// RVA: 0x171C3C0 Offset: 0x171C4C1 VA: 0x171C3C0
	internal void .ctor(GroupCollection rgc) { }

	// RVA: 0x171C440 Offset: 0x171C541 VA: 0x171C440 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x171C4A0 Offset: 0x171C5A1 VA: 0x171C4A0 Slot: 5
	public object get_Current() { }

	// RVA: 0x171C4B0 Offset: 0x171C5B1 VA: 0x171C4B0
	public Capture get_Capture() { }

	// RVA: 0x171C570 Offset: 0x171C671 VA: 0x171C570 Slot: 6
	public void Reset() { }
}

