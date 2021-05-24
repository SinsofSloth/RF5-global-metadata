public struct ReadOnlySequence.Enumerator<T> // TypeDefIndex: 4402
{
	// Fields
	private readonly ReadOnlySequence<T> _sequence; // 0x0
	private SequencePosition _next; // 0x0
	private ReadOnlyMemory<T> _currentMemory; // 0x0

	// Properties
	public ReadOnlyMemory<T> Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(in ReadOnlySequence<T> sequence) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D310 Offset: 0x37D411 VA: 0x37D310
	|-ReadOnlySequence.Enumerator<byte>..ctor
	|
	|-RVA: 0x37D440 Offset: 0x37D541 VA: 0x37D440
	|-ReadOnlySequence.Enumerator<char>..ctor
	|
	|-RVA: 0x37D570 Offset: 0x37D671 VA: 0x37D570
	|-ReadOnlySequence.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyMemory<T> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D380 Offset: 0x37D481 VA: 0x37D380
	|-ReadOnlySequence.Enumerator<byte>.get_Current
	|
	|-RVA: 0x37D4B0 Offset: 0x37D5B1 VA: 0x37D4B0
	|-ReadOnlySequence.Enumerator<char>.get_Current
	|
	|-RVA: 0x37D5E0 Offset: 0x37D6E1 VA: 0x37D5E0
	|-ReadOnlySequence.Enumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37D390 Offset: 0x37D491 VA: 0x37D390
	|-ReadOnlySequence.Enumerator<byte>.MoveNext
	|
	|-RVA: 0x37D4C0 Offset: 0x37D5C1 VA: 0x37D4C0
	|-ReadOnlySequence.Enumerator<char>.MoveNext
	|
	|-RVA: 0x37D5F0 Offset: 0x37D6F1 VA: 0x37D5F0
	|-ReadOnlySequence.Enumerator<object>.MoveNext
	*/
}

