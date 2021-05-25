[DebuggerDisplayAttribute] // RVA: 0xB3690 Offset: 0xB3791 VA: 0xB3690
private sealed class ConcurrentQueue.Segment<T> // TypeDefIndex: 1407
{
	// Fields
	internal readonly ConcurrentQueue.Segment.Slot<T>[] _slots; // 0x0
	internal readonly int _slotsMask; // 0x0
	internal PaddedHeadAndTail _headAndTail; // 0x0
	internal bool _preservedForObservation; // 0x0
	internal bool _frozenForEnqueues; // 0x0
	internal ConcurrentQueue.Segment<T> _nextSegment; // 0x0

	// Properties
	internal int Capacity { get; }
	internal int FreezeOffset { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int boundedLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5A7E0 Offset: 0x2B5A8E1 VA: 0x2B5A7E0
	|-ConcurrentQueue.Segment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5A8A0 Offset: 0x2B5A9A1 VA: 0x2B5A8A0
	|-ConcurrentQueue.Segment<object>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	internal int get_FreezeOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5A8C0 Offset: 0x2B5A9C1 VA: 0x2B5A8C0
	|-ConcurrentQueue.Segment<object>.get_FreezeOffset
	*/

	// RVA: -1 Offset: -1
	internal void EnsureFrozenForEnqueues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5A8E0 Offset: 0x2B5A9E1 VA: 0x2B5A8E0
	|-ConcurrentQueue.Segment<object>.EnsureFrozenForEnqueues
	*/

	// RVA: -1 Offset: -1
	public bool TryEnqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5A980 Offset: 0x2B5AA81 VA: 0x2B5A980
	|-ConcurrentQueue.Segment<object>.TryEnqueue
	*/
}

