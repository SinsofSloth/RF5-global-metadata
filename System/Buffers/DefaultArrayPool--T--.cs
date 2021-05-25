internal sealed class DefaultArrayPool<T> : ArrayPool<T> // TypeDefIndex: 3750
{
	// Fields
	private static T[] s_emptyArray; // 0x0
	private readonly DefaultArrayPool.Bucket<T>[] _buckets; // 0x0

	// Properties
	private int Id { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A98F20 Offset: 0x2A99021 VA: 0x2A98F20
	|-DefaultArrayPool<byte>..ctor
	|
	|-RVA: 0x2A99830 Offset: 0x2A99931 VA: 0x2A99830
	|-DefaultArrayPool<char>..ctor
	|
	|-RVA: 0x2A9A140 Offset: 0x2A9A241 VA: 0x2A9A140
	|-DefaultArrayPool<int>..ctor
	|
	|-RVA: 0x2A9AA50 Offset: 0x2A9AB51 VA: 0x2A9AA50
	|-DefaultArrayPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int maxArrayLength, int maxArraysPerBucket) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A98F50 Offset: 0x2A99051 VA: 0x2A98F50
	|-DefaultArrayPool<byte>..ctor
	|
	|-RVA: 0x2A99860 Offset: 0x2A99961 VA: 0x2A99860
	|-DefaultArrayPool<char>..ctor
	|
	|-RVA: 0x2A9A170 Offset: 0x2A9A271 VA: 0x2A9A170
	|-DefaultArrayPool<int>..ctor
	|
	|-RVA: 0x2A9AA80 Offset: 0x2A9AB81 VA: 0x2A9AA80
	|-DefaultArrayPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A99210 Offset: 0x2A99311 VA: 0x2A99210
	|-DefaultArrayPool<byte>.get_Id
	|
	|-RVA: 0x2A99B20 Offset: 0x2A99C21 VA: 0x2A99B20
	|-DefaultArrayPool<char>.get_Id
	|
	|-RVA: 0x2A9A430 Offset: 0x2A9A531 VA: 0x2A9A430
	|-DefaultArrayPool<int>.get_Id
	|
	|-RVA: 0x2A9AD40 Offset: 0x2A9AE41 VA: 0x2A9AD40
	|-DefaultArrayPool<object>.get_Id
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override T[] Rent(int minimumLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A99230 Offset: 0x2A99331 VA: 0x2A99230
	|-DefaultArrayPool<byte>.Rent
	|
	|-RVA: 0x2A99B40 Offset: 0x2A99C41 VA: 0x2A99B40
	|-DefaultArrayPool<char>.Rent
	|
	|-RVA: 0x2A9A450 Offset: 0x2A9A551 VA: 0x2A9A450
	|-DefaultArrayPool<int>.Rent
	|
	|-RVA: 0x2A9AD60 Offset: 0x2A9AE61 VA: 0x2A9AD60
	|-DefaultArrayPool<object>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Return(T[] array, bool clearArray = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A99610 Offset: 0x2A99711 VA: 0x2A99610
	|-DefaultArrayPool<byte>.Return
	|
	|-RVA: 0x2A99F20 Offset: 0x2A9A021 VA: 0x2A99F20
	|-DefaultArrayPool<char>.Return
	|
	|-RVA: 0x2A9A830 Offset: 0x2A9A931 VA: 0x2A9A830
	|-DefaultArrayPool<int>.Return
	|
	|-RVA: 0x2A9B140 Offset: 0x2A9B241 VA: 0x2A9B140
	|-DefaultArrayPool<object>.Return
	*/
}

