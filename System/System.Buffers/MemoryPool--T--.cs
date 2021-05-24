public abstract class MemoryPool<T> : IDisposable // TypeDefIndex: 4400
{
	// Fields
	private static readonly MemoryPool<T> s_shared; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IMemoryOwner<T> Rent(int minBufferSize = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemoryPool<object>.Rent
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B42A80 Offset: 0x2B42B81 VA: 0x2B42A80
	|-MemoryPool<byte>..ctor
	|
	|-RVA: 0x2B42C10 Offset: 0x2B42D11 VA: 0x2B42C10
	|-MemoryPool<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B42AA0 Offset: 0x2B42BA1 VA: 0x2B42AA0
	|-MemoryPool<byte>.Dispose
	|
	|-RVA: 0x2B42C30 Offset: 0x2B42D31 VA: 0x2B42C30
	|-MemoryPool<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemoryPool<object>.Dispose
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B42B30 Offset: 0x2B42C31 VA: 0x2B42B30
	|-MemoryPool<byte>..cctor
	|
	|-RVA: 0x2B42CC0 Offset: 0x2B42DC1 VA: 0x2B42CC0
	|-MemoryPool<object>..cctor
	*/
}

