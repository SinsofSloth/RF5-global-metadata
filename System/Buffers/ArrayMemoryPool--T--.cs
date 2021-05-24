internal sealed class ArrayMemoryPool<T> : MemoryPool<T> // TypeDefIndex: 4396
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public sealed override IMemoryOwner<T> Rent(int minimumBufferSize = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96B00 Offset: 0x2A96C01 VA: 0x2A96B00
	|-ArrayMemoryPool<byte>.Rent
	|
	|-RVA: 0x2A96C70 Offset: 0x2A96D71 VA: 0x2A96C70
	|-ArrayMemoryPool<object>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected sealed override void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96BB0 Offset: 0x2A96CB1 VA: 0x2A96BB0
	|-ArrayMemoryPool<byte>.Dispose
	|
	|-RVA: 0x2A96D20 Offset: 0x2A96E21 VA: 0x2A96D20
	|-ArrayMemoryPool<object>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96BC0 Offset: 0x2A96CC1 VA: 0x2A96BC0
	|-ArrayMemoryPool<byte>..ctor
	|
	|-RVA: 0x2A96D30 Offset: 0x2A96E31 VA: 0x2A96D30
	|-ArrayMemoryPool<object>..ctor
	*/
}

