public abstract class MemoryManager<T> : IMemoryOwner<T>, IDisposable // TypeDefIndex: 4409
{
	// Properties
	public virtual Memory<T> Memory { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public virtual Memory<T> get_Memory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B42750 Offset: 0x2B42851 VA: 0x2B42750
	|-MemoryManager<byte>.get_Memory
	|
	|-RVA: 0x2B42860 Offset: 0x2B42961 VA: 0x2B42860
	|-MemoryManager<char>.get_Memory
	|
	|-RVA: 0x2B42970 Offset: 0x2B42A71 VA: 0x2B42970
	|-MemoryManager<object>.get_Memory
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Span<T> GetSpan() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemoryManager<object>.GetSpan
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected internal virtual bool TryGetArray(out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B427C0 Offset: 0x2B428C1 VA: 0x2B427C0
	|-MemoryManager<byte>.TryGetArray
	|
	|-RVA: 0x2B428D0 Offset: 0x2B429D1 VA: 0x2B428D0
	|-MemoryManager<char>.TryGetArray
	|
	|-RVA: 0x2B429E0 Offset: 0x2B42AE1 VA: 0x2B429E0
	|-MemoryManager<object>.TryGetArray
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B427D0 Offset: 0x2B428D1 VA: 0x2B427D0
	|-MemoryManager<byte>.System.IDisposable.Dispose
	|
	|-RVA: 0x2B428E0 Offset: 0x2B429E1 VA: 0x2B428E0
	|-MemoryManager<char>.System.IDisposable.Dispose
	|
	|-RVA: 0x2B429F0 Offset: 0x2B42AF1 VA: 0x2B429F0
	|-MemoryManager<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemoryManager<object>.Dispose
	*/
}

