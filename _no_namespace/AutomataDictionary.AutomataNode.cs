private class AutomataDictionary.AutomataNode : IComparable<AutomataDictionary.AutomataNode> // TypeDefIndex: 5279
{
	// Fields
	internal ulong Key; // 0x10
	internal int Value; // 0x18
	internal string OriginalKey; // 0x20
	private AutomataDictionary.AutomataNode[] nexts; // 0x28
	private ulong[] nextKeys; // 0x30
	private int count; // 0x38

	// Properties
	public bool HasChildren { get; }

	// Methods

	// RVA: 0x1665DC0 Offset: 0x1665EC1 VA: 0x1665DC0
	public bool get_HasChildren() { }

	// RVA: 0x1663460 Offset: 0x1663561 VA: 0x1663460
	public void .ctor(ulong key) { }

	// RVA: 0x1664240 Offset: 0x1664341 VA: 0x1664240
	public AutomataDictionary.AutomataNode Add(ulong key) { }

	// RVA: 0x16641F0 Offset: 0x16642F1 VA: 0x16641F0
	public AutomataDictionary.AutomataNode Add(ulong key, int value, string originalKey) { }

	// RVA: 0x16645C0 Offset: 0x16646C1 VA: 0x16645C0
	public AutomataDictionary.AutomataNode SearchNext(ref ReadOnlySpan<byte> value) { }

	// RVA: 0x1665DD0 Offset: 0x1665ED1 VA: 0x1665DD0
	internal static int BinarySearch(ulong[] array, int index, int length, ulong value) { }

	// RVA: 0x1665E60 Offset: 0x1665F61 VA: 0x1665E60 Slot: 4
	public int CompareTo(AutomataDictionary.AutomataNode other) { }

	[IteratorStateMachineAttribute] // RVA: 0x13ABB0 Offset: 0x13ACB1 VA: 0x13ABB0
	// RVA: 0x1664880 Offset: 0x1664981 VA: 0x1664880
	public IEnumerable<AutomataDictionary.AutomataNode> YieldChildren() { }

	// RVA: 0x1665090 Offset: 0x1665191 VA: 0x1665090
	public void EmitSearchNext(ILGenerator il, LocalBuilder bytesSpan, LocalBuilder key, Action<KeyValuePair<string, int>> onFound, Action onNotFound) { }

	// RVA: 0x1665EC0 Offset: 0x1665FC1 VA: 0x1665EC0
	private static void EmitSearchNextCore(ILGenerator il, LocalBuilder bytesSpan, LocalBuilder key, Action<KeyValuePair<string, int>> onFound, Action onNotFound, AutomataDictionary.AutomataNode[] nexts, int count) { }
}

