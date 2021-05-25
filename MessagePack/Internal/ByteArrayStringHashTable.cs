public class ByteArrayStringHashTable : IEnumerable<KeyValuePair<string, int>>, IEnumerable // TypeDefIndex: 5285
{
	// Fields
	private readonly ByteArrayStringHashTable.Entry[][] buckets; // 0x10
	private readonly ulong indexFor; // 0x18
	private static readonly bool Is32Bit; // 0x0

	// Methods

	// RVA: 0x1669540 Offset: 0x1669641 VA: 0x1669540
	public void .ctor(int capacity) { }

	// RVA: 0x1669550 Offset: 0x1669651 VA: 0x1669550
	public void .ctor(int capacity, float loadFactor) { }

	// RVA: 0x1669670 Offset: 0x1669771 VA: 0x1669670
	public void Add(string key, int value) { }

	// RVA: 0x1669AA0 Offset: 0x1669BA1 VA: 0x1669AA0
	public void Add(byte[] key, int value) { }

	// RVA: 0x1669750 Offset: 0x1669851 VA: 0x1669750
	private bool TryAddInternal(byte[] key, int value) { }

	// RVA: 0x1669B60 Offset: 0x1669C61 VA: 0x1669B60
	public bool TryGetValue(in ReadOnlySequence<byte> key, out int value) { }

	// RVA: 0x1669C90 Offset: 0x1669D91 VA: 0x1669C90
	public bool TryGetValue(ReadOnlySpan<byte> key, out int value) { }

	// RVA: 0x1669E60 Offset: 0x1669F61 VA: 0x1669E60
	private bool TryGetValueSlow(ReadOnlySpan<byte> key, ByteArrayStringHashTable.Entry[] entry, out int value) { }

	// RVA: 0x1669FA0 Offset: 0x166A0A1 VA: 0x1669FA0
	private static ulong ByteArrayGetHashCode(ReadOnlySpan<byte> x) { }

	// RVA: 0x1669640 Offset: 0x1669741 VA: 0x1669640
	private static int CalculateCapacity(int collectionSize, float loadFactor) { }

	[IteratorStateMachineAttribute] // RVA: 0x13A6B0 Offset: 0x13A7B1 VA: 0x13A6B0
	// RVA: 0x166A0B0 Offset: 0x166A1B1 VA: 0x166A0B0 Slot: 4
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator() { }

	// RVA: 0x166A160 Offset: 0x166A261 VA: 0x166A160 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x166A1E0 Offset: 0x166A2E1 VA: 0x166A1E0
	private static void .cctor() { }
}

