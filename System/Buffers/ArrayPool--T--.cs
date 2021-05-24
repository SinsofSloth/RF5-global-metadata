public abstract class ArrayPool<T> // TypeDefIndex: 3747
{
	// Fields
	private static ArrayPool<T> s_sharedInstance; // 0x0

	// Properties
	public static ArrayPool<T> Shared { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArrayPool<T> get_Shared() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96DE0 Offset: 0x2A96EE1 VA: 0x2A96DE0
	|-ArrayPool<byte>.get_Shared
	|
	|-RVA: 0x2A97130 Offset: 0x2A97231 VA: 0x2A97130
	|-ArrayPool<char>.get_Shared
	|
	|-RVA: 0x2A97480 Offset: 0x2A97581 VA: 0x2A97480
	|-ArrayPool<int>.get_Shared
	|
	|-RVA: 0x2A977D0 Offset: 0x2A978D1 VA: 0x2A977D0
	|-ArrayPool<object>.get_Shared
	*/

	// RVA: -1 Offset: -1
	private static ArrayPool<T> EnsureSharedCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96EC0 Offset: 0x2A96FC1 VA: 0x2A96EC0
	|-ArrayPool<byte>.EnsureSharedCreated
	|
	|-RVA: 0x2A97210 Offset: 0x2A97311 VA: 0x2A97210
	|-ArrayPool<char>.EnsureSharedCreated
	|
	|-RVA: 0x2A97560 Offset: 0x2A97661 VA: 0x2A97560
	|-ArrayPool<int>.EnsureSharedCreated
	|
	|-RVA: 0x2A978B0 Offset: 0x2A979B1 VA: 0x2A978B0
	|-ArrayPool<object>.EnsureSharedCreated
	*/

	// RVA: -1 Offset: -1
	public static ArrayPool<T> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96FA0 Offset: 0x2A970A1 VA: 0x2A96FA0
	|-ArrayPool<byte>.Create
	|
	|-RVA: 0x2A972F0 Offset: 0x2A973F1 VA: 0x2A972F0
	|-ArrayPool<char>.Create
	|
	|-RVA: 0x2A97640 Offset: 0x2A97741 VA: 0x2A97640
	|-ArrayPool<int>.Create
	|
	|-RVA: 0x2A97990 Offset: 0x2A97A91 VA: 0x2A97990
	|-ArrayPool<object>.Create
	*/

	// RVA: -1 Offset: -1
	public static ArrayPool<T> Create(int maxArrayLength, int maxArraysPerBucket) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A97050 Offset: 0x2A97151 VA: 0x2A97050
	|-ArrayPool<byte>.Create
	|
	|-RVA: 0x2A973A0 Offset: 0x2A974A1 VA: 0x2A973A0
	|-ArrayPool<char>.Create
	|
	|-RVA: 0x2A976F0 Offset: 0x2A977F1 VA: 0x2A976F0
	|-ArrayPool<int>.Create
	|
	|-RVA: 0x2A97A40 Offset: 0x2A97B41 VA: 0x2A97A40
	|-ArrayPool<object>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T[] Rent(int minimumLength) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<object>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Return(T[] array, bool clearArray = False) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<object>.Return
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A97110 Offset: 0x2A97211 VA: 0x2A97110
	|-ArrayPool<byte>..ctor
	|
	|-RVA: 0x2A97460 Offset: 0x2A97561 VA: 0x2A97460
	|-ArrayPool<char>..ctor
	|
	|-RVA: 0x2A977B0 Offset: 0x2A978B1 VA: 0x2A977B0
	|-ArrayPool<int>..ctor
	|
	|-RVA: 0x2A97B00 Offset: 0x2A97C01 VA: 0x2A97B00
	|-ArrayPool<object>..ctor
	*/
}

public abstract class ArrayPool<T> // TypeDefIndex: 3747
{
	// Fields
	private static ArrayPool<T> s_sharedInstance; // 0x0

	// Properties
	public static ArrayPool<T> Shared { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArrayPool<T> get_Shared() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96DE0 Offset: 0x2A96EE1 VA: 0x2A96DE0
	|-ArrayPool<byte>.get_Shared
	|
	|-RVA: 0x2A97130 Offset: 0x2A97231 VA: 0x2A97130
	|-ArrayPool<char>.get_Shared
	|
	|-RVA: 0x2A97480 Offset: 0x2A97581 VA: 0x2A97480
	|-ArrayPool<int>.get_Shared
	|
	|-RVA: 0x2A977D0 Offset: 0x2A978D1 VA: 0x2A977D0
	|-ArrayPool<object>.get_Shared
	*/

	// RVA: -1 Offset: -1
	private static ArrayPool<T> EnsureSharedCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96EC0 Offset: 0x2A96FC1 VA: 0x2A96EC0
	|-ArrayPool<byte>.EnsureSharedCreated
	|
	|-RVA: 0x2A97210 Offset: 0x2A97311 VA: 0x2A97210
	|-ArrayPool<char>.EnsureSharedCreated
	|
	|-RVA: 0x2A97560 Offset: 0x2A97661 VA: 0x2A97560
	|-ArrayPool<int>.EnsureSharedCreated
	|
	|-RVA: 0x2A978B0 Offset: 0x2A979B1 VA: 0x2A978B0
	|-ArrayPool<object>.EnsureSharedCreated
	*/

	// RVA: -1 Offset: -1
	public static ArrayPool<T> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96FA0 Offset: 0x2A970A1 VA: 0x2A96FA0
	|-ArrayPool<byte>.Create
	|
	|-RVA: 0x2A972F0 Offset: 0x2A973F1 VA: 0x2A972F0
	|-ArrayPool<char>.Create
	|
	|-RVA: 0x2A97640 Offset: 0x2A97741 VA: 0x2A97640
	|-ArrayPool<int>.Create
	|
	|-RVA: 0x2A97990 Offset: 0x2A97A91 VA: 0x2A97990
	|-ArrayPool<object>.Create
	*/

	// RVA: -1 Offset: -1
	public static ArrayPool<T> Create(int maxArrayLength, int maxArraysPerBucket) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A97050 Offset: 0x2A97151 VA: 0x2A97050
	|-ArrayPool<byte>.Create
	|
	|-RVA: 0x2A973A0 Offset: 0x2A974A1 VA: 0x2A973A0
	|-ArrayPool<char>.Create
	|
	|-RVA: 0x2A976F0 Offset: 0x2A977F1 VA: 0x2A976F0
	|-ArrayPool<int>.Create
	|
	|-RVA: 0x2A97A40 Offset: 0x2A97B41 VA: 0x2A97A40
	|-ArrayPool<object>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T[] Rent(int minimumLength) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<object>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Return(T[] array, bool clearArray = False) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<object>.Return
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A97110 Offset: 0x2A97211 VA: 0x2A97110
	|-ArrayPool<byte>..ctor
	|
	|-RVA: 0x2A97460 Offset: 0x2A97561 VA: 0x2A97460
	|-ArrayPool<char>..ctor
	|
	|-RVA: 0x2A977B0 Offset: 0x2A978B1 VA: 0x2A977B0
	|-ArrayPool<int>..ctor
	|
	|-RVA: 0x2A97B00 Offset: 0x2A97C01 VA: 0x2A97B00
	|-ArrayPool<object>..ctor
	*/
}

public abstract class ArrayPool<T> // TypeDefIndex: 3747
{
	// Fields
	private static ArrayPool<T> s_sharedInstance; // 0x0

	// Properties
	public static ArrayPool<T> Shared { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArrayPool<T> get_Shared() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96DE0 Offset: 0x2A96EE1 VA: 0x2A96DE0
	|-ArrayPool<byte>.get_Shared
	|
	|-RVA: 0x2A97130 Offset: 0x2A97231 VA: 0x2A97130
	|-ArrayPool<char>.get_Shared
	|
	|-RVA: 0x2A97480 Offset: 0x2A97581 VA: 0x2A97480
	|-ArrayPool<int>.get_Shared
	|
	|-RVA: 0x2A977D0 Offset: 0x2A978D1 VA: 0x2A977D0
	|-ArrayPool<object>.get_Shared
	*/

	// RVA: -1 Offset: -1
	private static ArrayPool<T> EnsureSharedCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96EC0 Offset: 0x2A96FC1 VA: 0x2A96EC0
	|-ArrayPool<byte>.EnsureSharedCreated
	|
	|-RVA: 0x2A97210 Offset: 0x2A97311 VA: 0x2A97210
	|-ArrayPool<char>.EnsureSharedCreated
	|
	|-RVA: 0x2A97560 Offset: 0x2A97661 VA: 0x2A97560
	|-ArrayPool<int>.EnsureSharedCreated
	|
	|-RVA: 0x2A978B0 Offset: 0x2A979B1 VA: 0x2A978B0
	|-ArrayPool<object>.EnsureSharedCreated
	*/

	// RVA: -1 Offset: -1
	public static ArrayPool<T> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96FA0 Offset: 0x2A970A1 VA: 0x2A96FA0
	|-ArrayPool<byte>.Create
	|
	|-RVA: 0x2A972F0 Offset: 0x2A973F1 VA: 0x2A972F0
	|-ArrayPool<char>.Create
	|
	|-RVA: 0x2A97640 Offset: 0x2A97741 VA: 0x2A97640
	|-ArrayPool<int>.Create
	|
	|-RVA: 0x2A97990 Offset: 0x2A97A91 VA: 0x2A97990
	|-ArrayPool<object>.Create
	*/

	// RVA: -1 Offset: -1
	public static ArrayPool<T> Create(int maxArrayLength, int maxArraysPerBucket) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A97050 Offset: 0x2A97151 VA: 0x2A97050
	|-ArrayPool<byte>.Create
	|
	|-RVA: 0x2A973A0 Offset: 0x2A974A1 VA: 0x2A973A0
	|-ArrayPool<char>.Create
	|
	|-RVA: 0x2A976F0 Offset: 0x2A977F1 VA: 0x2A976F0
	|-ArrayPool<int>.Create
	|
	|-RVA: 0x2A97A40 Offset: 0x2A97B41 VA: 0x2A97A40
	|-ArrayPool<object>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T[] Rent(int minimumLength) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<object>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Return(T[] array, bool clearArray = False) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<object>.Return
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A97110 Offset: 0x2A97211 VA: 0x2A97110
	|-ArrayPool<byte>..ctor
	|
	|-RVA: 0x2A97460 Offset: 0x2A97561 VA: 0x2A97460
	|-ArrayPool<char>..ctor
	|
	|-RVA: 0x2A977B0 Offset: 0x2A978B1 VA: 0x2A977B0
	|-ArrayPool<int>..ctor
	|
	|-RVA: 0x2A97B00 Offset: 0x2A97C01 VA: 0x2A97B00
	|-ArrayPool<object>..ctor
	*/
}

public abstract class ArrayPool<T> // TypeDefIndex: 3747
{
	// Fields
	private static ArrayPool<T> s_sharedInstance; // 0x0

	// Properties
	public static ArrayPool<T> Shared { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArrayPool<T> get_Shared() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96DE0 Offset: 0x2A96EE1 VA: 0x2A96DE0
	|-ArrayPool<byte>.get_Shared
	|
	|-RVA: 0x2A97130 Offset: 0x2A97231 VA: 0x2A97130
	|-ArrayPool<char>.get_Shared
	|
	|-RVA: 0x2A97480 Offset: 0x2A97581 VA: 0x2A97480
	|-ArrayPool<int>.get_Shared
	|
	|-RVA: 0x2A977D0 Offset: 0x2A978D1 VA: 0x2A977D0
	|-ArrayPool<object>.get_Shared
	*/

	// RVA: -1 Offset: -1
	private static ArrayPool<T> EnsureSharedCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96EC0 Offset: 0x2A96FC1 VA: 0x2A96EC0
	|-ArrayPool<byte>.EnsureSharedCreated
	|
	|-RVA: 0x2A97210 Offset: 0x2A97311 VA: 0x2A97210
	|-ArrayPool<char>.EnsureSharedCreated
	|
	|-RVA: 0x2A97560 Offset: 0x2A97661 VA: 0x2A97560
	|-ArrayPool<int>.EnsureSharedCreated
	|
	|-RVA: 0x2A978B0 Offset: 0x2A979B1 VA: 0x2A978B0
	|-ArrayPool<object>.EnsureSharedCreated
	*/

	// RVA: -1 Offset: -1
	public static ArrayPool<T> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96FA0 Offset: 0x2A970A1 VA: 0x2A96FA0
	|-ArrayPool<byte>.Create
	|
	|-RVA: 0x2A972F0 Offset: 0x2A973F1 VA: 0x2A972F0
	|-ArrayPool<char>.Create
	|
	|-RVA: 0x2A97640 Offset: 0x2A97741 VA: 0x2A97640
	|-ArrayPool<int>.Create
	|
	|-RVA: 0x2A97990 Offset: 0x2A97A91 VA: 0x2A97990
	|-ArrayPool<object>.Create
	*/

	// RVA: -1 Offset: -1
	public static ArrayPool<T> Create(int maxArrayLength, int maxArraysPerBucket) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A97050 Offset: 0x2A97151 VA: 0x2A97050
	|-ArrayPool<byte>.Create
	|
	|-RVA: 0x2A973A0 Offset: 0x2A974A1 VA: 0x2A973A0
	|-ArrayPool<char>.Create
	|
	|-RVA: 0x2A976F0 Offset: 0x2A977F1 VA: 0x2A976F0
	|-ArrayPool<int>.Create
	|
	|-RVA: 0x2A97A40 Offset: 0x2A97B41 VA: 0x2A97A40
	|-ArrayPool<object>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T[] Rent(int minimumLength) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<object>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Return(T[] array, bool clearArray = False) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<object>.Return
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A97110 Offset: 0x2A97211 VA: 0x2A97110
	|-ArrayPool<byte>..ctor
	|
	|-RVA: 0x2A97460 Offset: 0x2A97561 VA: 0x2A97460
	|-ArrayPool<char>..ctor
	|
	|-RVA: 0x2A977B0 Offset: 0x2A978B1 VA: 0x2A977B0
	|-ArrayPool<int>..ctor
	|
	|-RVA: 0x2A97B00 Offset: 0x2A97C01 VA: 0x2A97B00
	|-ArrayPool<object>..ctor
	*/
}

public abstract class ArrayPool<T> // TypeDefIndex: 3747
{
	// Fields
	private static ArrayPool<T> s_sharedInstance; // 0x0

	// Properties
	public static ArrayPool<T> Shared { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ArrayPool<T> get_Shared() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96DE0 Offset: 0x2A96EE1 VA: 0x2A96DE0
	|-ArrayPool<byte>.get_Shared
	|
	|-RVA: 0x2A97130 Offset: 0x2A97231 VA: 0x2A97130
	|-ArrayPool<char>.get_Shared
	|
	|-RVA: 0x2A97480 Offset: 0x2A97581 VA: 0x2A97480
	|-ArrayPool<int>.get_Shared
	|
	|-RVA: 0x2A977D0 Offset: 0x2A978D1 VA: 0x2A977D0
	|-ArrayPool<object>.get_Shared
	*/

	// RVA: -1 Offset: -1
	private static ArrayPool<T> EnsureSharedCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96EC0 Offset: 0x2A96FC1 VA: 0x2A96EC0
	|-ArrayPool<byte>.EnsureSharedCreated
	|
	|-RVA: 0x2A97210 Offset: 0x2A97311 VA: 0x2A97210
	|-ArrayPool<char>.EnsureSharedCreated
	|
	|-RVA: 0x2A97560 Offset: 0x2A97661 VA: 0x2A97560
	|-ArrayPool<int>.EnsureSharedCreated
	|
	|-RVA: 0x2A978B0 Offset: 0x2A979B1 VA: 0x2A978B0
	|-ArrayPool<object>.EnsureSharedCreated
	*/

	// RVA: -1 Offset: -1
	public static ArrayPool<T> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A96FA0 Offset: 0x2A970A1 VA: 0x2A96FA0
	|-ArrayPool<byte>.Create
	|
	|-RVA: 0x2A972F0 Offset: 0x2A973F1 VA: 0x2A972F0
	|-ArrayPool<char>.Create
	|
	|-RVA: 0x2A97640 Offset: 0x2A97741 VA: 0x2A97640
	|-ArrayPool<int>.Create
	|
	|-RVA: 0x2A97990 Offset: 0x2A97A91 VA: 0x2A97990
	|-ArrayPool<object>.Create
	*/

	// RVA: -1 Offset: -1
	public static ArrayPool<T> Create(int maxArrayLength, int maxArraysPerBucket) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A97050 Offset: 0x2A97151 VA: 0x2A97050
	|-ArrayPool<byte>.Create
	|
	|-RVA: 0x2A973A0 Offset: 0x2A974A1 VA: 0x2A973A0
	|-ArrayPool<char>.Create
	|
	|-RVA: 0x2A976F0 Offset: 0x2A977F1 VA: 0x2A976F0
	|-ArrayPool<int>.Create
	|
	|-RVA: 0x2A97A40 Offset: 0x2A97B41 VA: 0x2A97A40
	|-ArrayPool<object>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T[] Rent(int minimumLength) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<object>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Return(T[] array, bool clearArray = False) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<object>.Return
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A97110 Offset: 0x2A97211 VA: 0x2A97110
	|-ArrayPool<byte>..ctor
	|
	|-RVA: 0x2A97460 Offset: 0x2A97561 VA: 0x2A97460
	|-ArrayPool<char>..ctor
	|
	|-RVA: 0x2A977B0 Offset: 0x2A978B1 VA: 0x2A977B0
	|-ArrayPool<int>..ctor
	|
	|-RVA: 0x2A97B00 Offset: 0x2A97C01 VA: 0x2A97B00
	|-ArrayPool<object>..ctor
	*/
}

