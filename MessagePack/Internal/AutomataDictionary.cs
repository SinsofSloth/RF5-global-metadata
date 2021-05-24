public class AutomataDictionary : IEnumerable<KeyValuePair<string, int>>, IEnumerable // TypeDefIndex: 5278
{
	// Fields
	private readonly AutomataDictionary.AutomataNode root; // 0x10

	// Methods

	// RVA: 0x16633E0 Offset: 0x16634E1 VA: 0x16633E0
	public void .ctor() { }

	// RVA: 0x1663630 Offset: 0x1663731 VA: 0x1663630
	public void Add(string str, int value) { }

	// RVA: 0x1664420 Offset: 0x1664521 VA: 0x1664420
	public bool TryGetValue(in ReadOnlySequence<byte> bytes, out int value) { }

	// RVA: 0x1664520 Offset: 0x1664621 VA: 0x1664520
	public bool TryGetValue(ReadOnlySpan<byte> bytes, out int value) { }

	// RVA: 0x1664780 Offset: 0x1664881 VA: 0x1664780 Slot: 3
	public override string ToString() { }

	// RVA: 0x1664910 Offset: 0x1664A11 VA: 0x1664910
	private static void ToStringCore(IEnumerable<AutomataDictionary.AutomataNode> nexts, StringBuilder sb, int depth) { }

	// RVA: 0x1664E10 Offset: 0x1664F11 VA: 0x1664E10 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1664E20 Offset: 0x1664F21 VA: 0x1664E20 Slot: 4
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0x13A640 Offset: 0x13A741 VA: 0x13A640
	// RVA: 0x1664FA0 Offset: 0x16650A1 VA: 0x1664FA0
	private static IEnumerable<KeyValuePair<string, int>> YieldCore(IEnumerable<AutomataDictionary.AutomataNode> nexts) { }

	// RVA: 0x1665070 Offset: 0x1665171 VA: 0x1665070
	public void EmitMatch(ILGenerator il, LocalBuilder bytesSpan, LocalBuilder key, Action<KeyValuePair<string, int>> onFound, Action onNotFound) { }
}

public class AutomataDictionary : IEnumerable<KeyValuePair<string, int>>, IEnumerable // TypeDefIndex: 5278
{
	// Fields
	private readonly AutomataDictionary.AutomataNode root; // 0x10

	// Methods

	// RVA: 0x16633E0 Offset: 0x16634E1 VA: 0x16633E0
	public void .ctor() { }

	// RVA: 0x1663630 Offset: 0x1663731 VA: 0x1663630
	public void Add(string str, int value) { }

	// RVA: 0x1664420 Offset: 0x1664521 VA: 0x1664420
	public bool TryGetValue(in ReadOnlySequence<byte> bytes, out int value) { }

	// RVA: 0x1664520 Offset: 0x1664621 VA: 0x1664520
	public bool TryGetValue(ReadOnlySpan<byte> bytes, out int value) { }

	// RVA: 0x1664780 Offset: 0x1664881 VA: 0x1664780 Slot: 3
	public override string ToString() { }

	// RVA: 0x1664910 Offset: 0x1664A11 VA: 0x1664910
	private static void ToStringCore(IEnumerable<AutomataDictionary.AutomataNode> nexts, StringBuilder sb, int depth) { }

	// RVA: 0x1664E10 Offset: 0x1664F11 VA: 0x1664E10 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1664E20 Offset: 0x1664F21 VA: 0x1664E20 Slot: 4
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0x13A640 Offset: 0x13A741 VA: 0x13A640
	// RVA: 0x1664FA0 Offset: 0x16650A1 VA: 0x1664FA0
	private static IEnumerable<KeyValuePair<string, int>> YieldCore(IEnumerable<AutomataDictionary.AutomataNode> nexts) { }

	// RVA: 0x1665070 Offset: 0x1665171 VA: 0x1665070
	public void EmitMatch(ILGenerator il, LocalBuilder bytesSpan, LocalBuilder key, Action<KeyValuePair<string, int>> onFound, Action onNotFound) { }
}

public class AutomataDictionary : IEnumerable<KeyValuePair<string, int>>, IEnumerable // TypeDefIndex: 5278
{
	// Fields
	private readonly AutomataDictionary.AutomataNode root; // 0x10

	// Methods

	// RVA: 0x16633E0 Offset: 0x16634E1 VA: 0x16633E0
	public void .ctor() { }

	// RVA: 0x1663630 Offset: 0x1663731 VA: 0x1663630
	public void Add(string str, int value) { }

	// RVA: 0x1664420 Offset: 0x1664521 VA: 0x1664420
	public bool TryGetValue(in ReadOnlySequence<byte> bytes, out int value) { }

	// RVA: 0x1664520 Offset: 0x1664621 VA: 0x1664520
	public bool TryGetValue(ReadOnlySpan<byte> bytes, out int value) { }

	// RVA: 0x1664780 Offset: 0x1664881 VA: 0x1664780 Slot: 3
	public override string ToString() { }

	// RVA: 0x1664910 Offset: 0x1664A11 VA: 0x1664910
	private static void ToStringCore(IEnumerable<AutomataDictionary.AutomataNode> nexts, StringBuilder sb, int depth) { }

	// RVA: 0x1664E10 Offset: 0x1664F11 VA: 0x1664E10 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1664E20 Offset: 0x1664F21 VA: 0x1664E20 Slot: 4
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0x13A640 Offset: 0x13A741 VA: 0x13A640
	// RVA: 0x1664FA0 Offset: 0x16650A1 VA: 0x1664FA0
	private static IEnumerable<KeyValuePair<string, int>> YieldCore(IEnumerable<AutomataDictionary.AutomataNode> nexts) { }

	// RVA: 0x1665070 Offset: 0x1665171 VA: 0x1665070
	public void EmitMatch(ILGenerator il, LocalBuilder bytesSpan, LocalBuilder key, Action<KeyValuePair<string, int>> onFound, Action onNotFound) { }
}

public class AutomataDictionary : IEnumerable<KeyValuePair<string, int>>, IEnumerable // TypeDefIndex: 5278
{
	// Fields
	private readonly AutomataDictionary.AutomataNode root; // 0x10

	// Methods

	// RVA: 0x16633E0 Offset: 0x16634E1 VA: 0x16633E0
	public void .ctor() { }

	// RVA: 0x1663630 Offset: 0x1663731 VA: 0x1663630
	public void Add(string str, int value) { }

	// RVA: 0x1664420 Offset: 0x1664521 VA: 0x1664420
	public bool TryGetValue(in ReadOnlySequence<byte> bytes, out int value) { }

	// RVA: 0x1664520 Offset: 0x1664621 VA: 0x1664520
	public bool TryGetValue(ReadOnlySpan<byte> bytes, out int value) { }

	// RVA: 0x1664780 Offset: 0x1664881 VA: 0x1664780 Slot: 3
	public override string ToString() { }

	// RVA: 0x1664910 Offset: 0x1664A11 VA: 0x1664910
	private static void ToStringCore(IEnumerable<AutomataDictionary.AutomataNode> nexts, StringBuilder sb, int depth) { }

	// RVA: 0x1664E10 Offset: 0x1664F11 VA: 0x1664E10 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1664E20 Offset: 0x1664F21 VA: 0x1664E20 Slot: 4
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0x13A640 Offset: 0x13A741 VA: 0x13A640
	// RVA: 0x1664FA0 Offset: 0x16650A1 VA: 0x1664FA0
	private static IEnumerable<KeyValuePair<string, int>> YieldCore(IEnumerable<AutomataDictionary.AutomataNode> nexts) { }

	// RVA: 0x1665070 Offset: 0x1665171 VA: 0x1665070
	public void EmitMatch(ILGenerator il, LocalBuilder bytesSpan, LocalBuilder key, Action<KeyValuePair<string, int>> onFound, Action onNotFound) { }
}

public class AutomataDictionary : IEnumerable<KeyValuePair<string, int>>, IEnumerable // TypeDefIndex: 5278
{
	// Fields
	private readonly AutomataDictionary.AutomataNode root; // 0x10

	// Methods

	// RVA: 0x16633E0 Offset: 0x16634E1 VA: 0x16633E0
	public void .ctor() { }

	// RVA: 0x1663630 Offset: 0x1663731 VA: 0x1663630
	public void Add(string str, int value) { }

	// RVA: 0x1664420 Offset: 0x1664521 VA: 0x1664420
	public bool TryGetValue(in ReadOnlySequence<byte> bytes, out int value) { }

	// RVA: 0x1664520 Offset: 0x1664621 VA: 0x1664520
	public bool TryGetValue(ReadOnlySpan<byte> bytes, out int value) { }

	// RVA: 0x1664780 Offset: 0x1664881 VA: 0x1664780 Slot: 3
	public override string ToString() { }

	// RVA: 0x1664910 Offset: 0x1664A11 VA: 0x1664910
	private static void ToStringCore(IEnumerable<AutomataDictionary.AutomataNode> nexts, StringBuilder sb, int depth) { }

	// RVA: 0x1664E10 Offset: 0x1664F11 VA: 0x1664E10 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1664E20 Offset: 0x1664F21 VA: 0x1664E20 Slot: 4
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0x13A640 Offset: 0x13A741 VA: 0x13A640
	// RVA: 0x1664FA0 Offset: 0x16650A1 VA: 0x1664FA0
	private static IEnumerable<KeyValuePair<string, int>> YieldCore(IEnumerable<AutomataDictionary.AutomataNode> nexts) { }

	// RVA: 0x1665070 Offset: 0x1665171 VA: 0x1665070
	public void EmitMatch(ILGenerator il, LocalBuilder bytesSpan, LocalBuilder key, Action<KeyValuePair<string, int>> onFound, Action onNotFound) { }
}

