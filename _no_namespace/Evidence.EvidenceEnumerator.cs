private class Evidence.EvidenceEnumerator : IEnumerator // TypeDefIndex: 895
{
	// Fields
	private IEnumerator currentEnum; // 0x10
	private IEnumerator hostEnum; // 0x18
	private IEnumerator assemblyEnum; // 0x20

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x263E3B0 Offset: 0x263E4B1 VA: 0x263E3B0
	public void .ctor(IEnumerator hostenum, IEnumerator assemblyenum) { }

	// RVA: 0x263E420 Offset: 0x263E521 VA: 0x263E420 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x263E5A0 Offset: 0x263E6A1 VA: 0x263E5A0 Slot: 6
	public void Reset() { }

	// RVA: 0x263E6F0 Offset: 0x263E7F1 VA: 0x263E6F0 Slot: 5
	public object get_Current() { }
}

