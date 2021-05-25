private sealed class DefaultArrayPool.Bucket<T> // TypeDefIndex: 3751
{
	// Fields
	internal readonly int _bufferLength; // 0x0
	private readonly T[][] _buffers; // 0x0
	private readonly int _poolId; // 0x0
	private SpinLock _lock; // 0x0
	private int _index; // 0x0

	// Properties
	internal int Id { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int bufferLength, int numberOfBuffers, int poolId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A97B20 Offset: 0x2A97C21 VA: 0x2A97B20
	|-DefaultArrayPool.Bucket<byte>..ctor
	|
	|-RVA: 0x2A98020 Offset: 0x2A98121 VA: 0x2A98020
	|-DefaultArrayPool.Bucket<char>..ctor
	|
	|-RVA: 0x2A98520 Offset: 0x2A98621 VA: 0x2A98520
	|-DefaultArrayPool.Bucket<int>..ctor
	|
	|-RVA: 0x2A98A20 Offset: 0x2A98B21 VA: 0x2A98A20
	|-DefaultArrayPool.Bucket<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A97C20 Offset: 0x2A97D21 VA: 0x2A97C20
	|-DefaultArrayPool.Bucket<byte>.get_Id
	|
	|-RVA: 0x2A98120 Offset: 0x2A98221 VA: 0x2A98120
	|-DefaultArrayPool.Bucket<char>.get_Id
	|
	|-RVA: 0x2A98620 Offset: 0x2A98721 VA: 0x2A98620
	|-DefaultArrayPool.Bucket<int>.get_Id
	|
	|-RVA: 0x2A98B20 Offset: 0x2A98C21 VA: 0x2A98B20
	|-DefaultArrayPool.Bucket<object>.get_Id
	*/

	// RVA: -1 Offset: -1
	internal T[] Rent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A97C40 Offset: 0x2A97D41 VA: 0x2A97C40
	|-DefaultArrayPool.Bucket<byte>.Rent
	|
	|-RVA: 0x2A98140 Offset: 0x2A98241 VA: 0x2A98140
	|-DefaultArrayPool.Bucket<char>.Rent
	|
	|-RVA: 0x2A98640 Offset: 0x2A98741 VA: 0x2A98640
	|-DefaultArrayPool.Bucket<int>.Rent
	|
	|-RVA: 0x2A98B40 Offset: 0x2A98C41 VA: 0x2A98B40
	|-DefaultArrayPool.Bucket<object>.Rent
	*/

	// RVA: -1 Offset: -1
	internal void Return(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A97E90 Offset: 0x2A97F91 VA: 0x2A97E90
	|-DefaultArrayPool.Bucket<byte>.Return
	|
	|-RVA: 0x2A98390 Offset: 0x2A98491 VA: 0x2A98390
	|-DefaultArrayPool.Bucket<char>.Return
	|
	|-RVA: 0x2A98890 Offset: 0x2A98991 VA: 0x2A98890
	|-DefaultArrayPool.Bucket<int>.Return
	|
	|-RVA: 0x2A98D90 Offset: 0x2A98E91 VA: 0x2A98D90
	|-DefaultArrayPool.Bucket<object>.Return
	*/
}

