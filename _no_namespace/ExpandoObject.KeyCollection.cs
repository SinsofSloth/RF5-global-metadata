[DebuggerDisplayAttribute] // RVA: 0xBF060 Offset: 0xBF161 VA: 0xBF060
[DebuggerTypeProxyAttribute] // RVA: 0xBF060 Offset: 0xBF161 VA: 0xBF060
private class ExpandoObject.KeyCollection : ICollection<string>, IEnumerable<string>, IEnumerable // TypeDefIndex: 2726
{
	// Fields
	private readonly ExpandoObject _expando; // 0x10
	private readonly int _expandoVersion; // 0x18
	private readonly int _expandoCount; // 0x1C
	private readonly ExpandoObject.ExpandoData _expandoData; // 0x20

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x169DEB0 Offset: 0x169DFB1 VA: 0x169DEB0
	internal void .ctor(ExpandoObject expando) { }

	// RVA: 0x169F490 Offset: 0x169F591 VA: 0x169F490
	private void CheckVersion() { }

	// RVA: 0x169F520 Offset: 0x169F621 VA: 0x169F520 Slot: 6
	public void Add(string item) { }

	// RVA: 0x169F5E0 Offset: 0x169F6E1 VA: 0x169F5E0 Slot: 7
	public void Clear() { }

	// RVA: 0x169F630 Offset: 0x169F731 VA: 0x169F630 Slot: 8
	public bool Contains(string item) { }

	// RVA: 0x169F7B0 Offset: 0x169F8B1 VA: 0x169F7B0 Slot: 9
	public void CopyTo(string[] array, int arrayIndex) { }

	// RVA: 0x169FB80 Offset: 0x169FC81 VA: 0x169FB80 Slot: 4
	public int get_Count() { }

	// RVA: 0x169FC10 Offset: 0x169FD11 VA: 0x169FC10 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x169FC20 Offset: 0x169FD21 VA: 0x169FC20 Slot: 10
	public bool Remove(string item) { }

	[IteratorStateMachineAttribute] // RVA: 0xC1180 Offset: 0xC1281 VA: 0xC1180
	// RVA: 0x169FC70 Offset: 0x169FD71 VA: 0x169FC70 Slot: 11
	public IEnumerator<string> GetEnumerator() { }

	// RVA: 0x169FD20 Offset: 0x169FE21 VA: 0x169FD20 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

