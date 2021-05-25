private sealed class ArrayMemoryPool.ArrayMemoryPoolBuffer<T> : IMemoryOwner<T>, IDisposable // TypeDefIndex: 4397
{
	// Fields
	private T[] _array; // 0x0

	// Properties
	public Memory<T> Memory { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96840 Offset: 0x2A96941 VA: 0x2A96840
	|-ArrayMemoryPool.ArrayMemoryPoolBuffer<byte>..ctor
	|
	|-RVA: 0x2A969C0 Offset: 0x2A96AC1 VA: 0x2A969C0
	|-ArrayMemoryPool.ArrayMemoryPoolBuffer<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public Memory<T> get_Memory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A968B0 Offset: 0x2A969B1 VA: 0x2A968B0
	|-ArrayMemoryPool.ArrayMemoryPoolBuffer<byte>.get_Memory
	|
	|-RVA: 0x2A96A30 Offset: 0x2A96B31 VA: 0x2A96A30
	|-ArrayMemoryPool.ArrayMemoryPoolBuffer<object>.get_Memory
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96950 Offset: 0x2A96A51 VA: 0x2A96950
	|-ArrayMemoryPool.ArrayMemoryPoolBuffer<byte>.Dispose
	|
	|-RVA: 0x2A96A90 Offset: 0x2A96B91 VA: 0x2A96A90
	|-ArrayMemoryPool.ArrayMemoryPoolBuffer<object>.Dispose
	*/
}

