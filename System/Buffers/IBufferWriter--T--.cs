public interface IBufferWriter<T> // TypeDefIndex: 4399
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Advance(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IBufferWriter<object>.Advance
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Memory<T> GetMemory(int sizeHint = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IBufferWriter<object>.GetMemory
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Span<T> GetSpan(int sizeHint = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IBufferWriter<object>.GetSpan
	*/
}

