[DebuggerTypeProxyAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
[IsReadOnlyAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
[DebuggerDisplayAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
public struct Memory<T> // TypeDefIndex: 4377
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _index; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public bool IsEmpty { get; }
	public Span<T> Span { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3098E0 Offset: 0x3099E1 VA: 0x3098E0
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309CB0 Offset: 0x309DB1 VA: 0x309CB0
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A080 Offset: 0x30A181 VA: 0x30A080
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309970 Offset: 0x309A71 VA: 0x309970
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309D40 Offset: 0x309E41 VA: 0x309D40
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A090 Offset: 0x30A191 VA: 0x30A090
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(MemoryManager<T> manager, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309A30 Offset: 0x309B31 VA: 0x309A30
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309E00 Offset: 0x309F01 VA: 0x309E00
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A0A0 Offset: 0x30A1A1 VA: 0x30A0A0
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object obj, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309A90 Offset: 0x309B91 VA: 0x309A90
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309E60 Offset: 0x309F61 VA: 0x309E60
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A100 Offset: 0x30A201 VA: 0x30A100
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24485E0 Offset: 0x24486E1 VA: 0x24485E0
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x2449730 Offset: 0x2449831 VA: 0x2449730
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244A970 Offset: 0x244AA71 VA: 0x244A970
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> op_Implicit(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2448690 Offset: 0x2448791 VA: 0x2448690
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x24497E0 Offset: 0x24498E1 VA: 0x24497E0
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244A9D0 Offset: 0x244AAD1 VA: 0x244A9D0
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlyMemory<T> op_Implicit(Memory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24487C0 Offset: 0x24488C1 VA: 0x24487C0
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x2449910 Offset: 0x2449A11 VA: 0x2449910
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244AAA0 Offset: 0x244ABA1 VA: 0x244AAA0
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AD0 Offset: 0x309BD1 VA: 0x309AD0
	|-Memory<byte>.get_Length
	|
	|-RVA: 0x309EA0 Offset: 0x309FA1 VA: 0x309EA0
	|-Memory<char>.get_Length
	|
	|-RVA: 0x30A140 Offset: 0x30A241 VA: 0x30A140
	|-Memory<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AE0 Offset: 0x309BE1 VA: 0x309AE0
	|-Memory<byte>.get_IsEmpty
	|
	|-RVA: 0x309EB0 Offset: 0x309FB1 VA: 0x309EB0
	|-Memory<char>.get_IsEmpty
	|
	|-RVA: 0x30A150 Offset: 0x30A251 VA: 0x30A150
	|-Memory<object>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AF0 Offset: 0x309BF1 VA: 0x309AF0
	|-Memory<byte>.ToString
	|
	|-RVA: 0x309EC0 Offset: 0x309FC1 VA: 0x309EC0
	|-Memory<char>.ToString
	|
	|-RVA: 0x30A160 Offset: 0x30A261 VA: 0x30A160
	|-Memory<object>.ToString
	*/

	// RVA: -1 Offset: -1
	public Memory<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309B00 Offset: 0x309C01 VA: 0x309B00
	|-Memory<byte>.Slice
	|
	|-RVA: 0x309ED0 Offset: 0x309FD1 VA: 0x309ED0
	|-Memory<char>.Slice
	|
	|-RVA: 0x30A170 Offset: 0x30A271 VA: 0x30A170
	|-Memory<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public Memory<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309BA0 Offset: 0x309CA1 VA: 0x309BA0
	|-Memory<byte>.Slice
	|
	|-RVA: 0x309F70 Offset: 0x30A071 VA: 0x309F70
	|-Memory<char>.Slice
	|
	|-RVA: 0x30A210 Offset: 0x30A311 VA: 0x30A210
	|-Memory<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public Span<T> get_Span() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C40 Offset: 0x309D41 VA: 0x309C40
	|-Memory<byte>.get_Span
	|
	|-RVA: 0x30A010 Offset: 0x30A111 VA: 0x30A010
	|-Memory<char>.get_Span
	|
	|-RVA: 0x30A2B0 Offset: 0x30A3B1 VA: 0x30A2B0
	|-Memory<object>.get_Span
	*/

	[EditorBrowsableAttribute] // RVA: 0x128CB0 Offset: 0x128DB1 VA: 0x128CB0
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C50 Offset: 0x309D51 VA: 0x309C50
	|-Memory<byte>.Equals
	|
	|-RVA: 0x30A020 Offset: 0x30A121 VA: 0x30A020
	|-Memory<char>.Equals
	|
	|-RVA: 0x30A2C0 Offset: 0x30A3C1 VA: 0x30A2C0
	|-Memory<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool Equals(Memory<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C60 Offset: 0x309D61 VA: 0x309C60
	|-Memory<byte>.Equals
	|
	|-RVA: 0x30A030 Offset: 0x30A131 VA: 0x30A030
	|-Memory<char>.Equals
	|
	|-RVA: 0x30A2D0 Offset: 0x30A3D1 VA: 0x30A2D0
	|-Memory<object>.Equals
	*/

	[EditorBrowsableAttribute] // RVA: 0x128CD0 Offset: 0x128DD1 VA: 0x128CD0
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309CA0 Offset: 0x309DA1 VA: 0x309CA0
	|-Memory<byte>.GetHashCode
	|
	|-RVA: 0x30A070 Offset: 0x30A171 VA: 0x30A070
	|-Memory<char>.GetHashCode
	|
	|-RVA: 0x30A310 Offset: 0x30A411 VA: 0x30A310
	|-Memory<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2449480 Offset: 0x2449581 VA: 0x2449480
	|-Memory<byte>.CombineHashCodes
	|
	|-RVA: 0x244A5D0 Offset: 0x244A6D1 VA: 0x244A5D0
	|-Memory<char>.CombineHashCodes
	|
	|-RVA: 0x244B760 Offset: 0x244B861 VA: 0x244B760
	|-Memory<object>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int h1, int h2, int h3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2449490 Offset: 0x2449591 VA: 0x2449490
	|-Memory<byte>.CombineHashCodes
	|
	|-RVA: 0x244A5E0 Offset: 0x244A6E1 VA: 0x244A5E0
	|-Memory<char>.CombineHashCodes
	|
	|-RVA: 0x244B770 Offset: 0x244B871 VA: 0x244B770
	|-Memory<object>.CombineHashCodes
	*/
}

[DebuggerTypeProxyAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
[IsReadOnlyAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
[DebuggerDisplayAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
public struct Memory<T> // TypeDefIndex: 4377
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _index; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public bool IsEmpty { get; }
	public Span<T> Span { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3098E0 Offset: 0x3099E1 VA: 0x3098E0
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309CB0 Offset: 0x309DB1 VA: 0x309CB0
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A080 Offset: 0x30A181 VA: 0x30A080
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309970 Offset: 0x309A71 VA: 0x309970
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309D40 Offset: 0x309E41 VA: 0x309D40
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A090 Offset: 0x30A191 VA: 0x30A090
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(MemoryManager<T> manager, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309A30 Offset: 0x309B31 VA: 0x309A30
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309E00 Offset: 0x309F01 VA: 0x309E00
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A0A0 Offset: 0x30A1A1 VA: 0x30A0A0
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object obj, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309A90 Offset: 0x309B91 VA: 0x309A90
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309E60 Offset: 0x309F61 VA: 0x309E60
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A100 Offset: 0x30A201 VA: 0x30A100
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24485E0 Offset: 0x24486E1 VA: 0x24485E0
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x2449730 Offset: 0x2449831 VA: 0x2449730
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244A970 Offset: 0x244AA71 VA: 0x244A970
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> op_Implicit(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2448690 Offset: 0x2448791 VA: 0x2448690
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x24497E0 Offset: 0x24498E1 VA: 0x24497E0
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244A9D0 Offset: 0x244AAD1 VA: 0x244A9D0
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlyMemory<T> op_Implicit(Memory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24487C0 Offset: 0x24488C1 VA: 0x24487C0
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x2449910 Offset: 0x2449A11 VA: 0x2449910
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244AAA0 Offset: 0x244ABA1 VA: 0x244AAA0
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AD0 Offset: 0x309BD1 VA: 0x309AD0
	|-Memory<byte>.get_Length
	|
	|-RVA: 0x309EA0 Offset: 0x309FA1 VA: 0x309EA0
	|-Memory<char>.get_Length
	|
	|-RVA: 0x30A140 Offset: 0x30A241 VA: 0x30A140
	|-Memory<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AE0 Offset: 0x309BE1 VA: 0x309AE0
	|-Memory<byte>.get_IsEmpty
	|
	|-RVA: 0x309EB0 Offset: 0x309FB1 VA: 0x309EB0
	|-Memory<char>.get_IsEmpty
	|
	|-RVA: 0x30A150 Offset: 0x30A251 VA: 0x30A150
	|-Memory<object>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AF0 Offset: 0x309BF1 VA: 0x309AF0
	|-Memory<byte>.ToString
	|
	|-RVA: 0x309EC0 Offset: 0x309FC1 VA: 0x309EC0
	|-Memory<char>.ToString
	|
	|-RVA: 0x30A160 Offset: 0x30A261 VA: 0x30A160
	|-Memory<object>.ToString
	*/

	// RVA: -1 Offset: -1
	public Memory<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309B00 Offset: 0x309C01 VA: 0x309B00
	|-Memory<byte>.Slice
	|
	|-RVA: 0x309ED0 Offset: 0x309FD1 VA: 0x309ED0
	|-Memory<char>.Slice
	|
	|-RVA: 0x30A170 Offset: 0x30A271 VA: 0x30A170
	|-Memory<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public Memory<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309BA0 Offset: 0x309CA1 VA: 0x309BA0
	|-Memory<byte>.Slice
	|
	|-RVA: 0x309F70 Offset: 0x30A071 VA: 0x309F70
	|-Memory<char>.Slice
	|
	|-RVA: 0x30A210 Offset: 0x30A311 VA: 0x30A210
	|-Memory<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public Span<T> get_Span() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C40 Offset: 0x309D41 VA: 0x309C40
	|-Memory<byte>.get_Span
	|
	|-RVA: 0x30A010 Offset: 0x30A111 VA: 0x30A010
	|-Memory<char>.get_Span
	|
	|-RVA: 0x30A2B0 Offset: 0x30A3B1 VA: 0x30A2B0
	|-Memory<object>.get_Span
	*/

	[EditorBrowsableAttribute] // RVA: 0x128CB0 Offset: 0x128DB1 VA: 0x128CB0
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C50 Offset: 0x309D51 VA: 0x309C50
	|-Memory<byte>.Equals
	|
	|-RVA: 0x30A020 Offset: 0x30A121 VA: 0x30A020
	|-Memory<char>.Equals
	|
	|-RVA: 0x30A2C0 Offset: 0x30A3C1 VA: 0x30A2C0
	|-Memory<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool Equals(Memory<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C60 Offset: 0x309D61 VA: 0x309C60
	|-Memory<byte>.Equals
	|
	|-RVA: 0x30A030 Offset: 0x30A131 VA: 0x30A030
	|-Memory<char>.Equals
	|
	|-RVA: 0x30A2D0 Offset: 0x30A3D1 VA: 0x30A2D0
	|-Memory<object>.Equals
	*/

	[EditorBrowsableAttribute] // RVA: 0x128CD0 Offset: 0x128DD1 VA: 0x128CD0
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309CA0 Offset: 0x309DA1 VA: 0x309CA0
	|-Memory<byte>.GetHashCode
	|
	|-RVA: 0x30A070 Offset: 0x30A171 VA: 0x30A070
	|-Memory<char>.GetHashCode
	|
	|-RVA: 0x30A310 Offset: 0x30A411 VA: 0x30A310
	|-Memory<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2449480 Offset: 0x2449581 VA: 0x2449480
	|-Memory<byte>.CombineHashCodes
	|
	|-RVA: 0x244A5D0 Offset: 0x244A6D1 VA: 0x244A5D0
	|-Memory<char>.CombineHashCodes
	|
	|-RVA: 0x244B760 Offset: 0x244B861 VA: 0x244B760
	|-Memory<object>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int h1, int h2, int h3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2449490 Offset: 0x2449591 VA: 0x2449490
	|-Memory<byte>.CombineHashCodes
	|
	|-RVA: 0x244A5E0 Offset: 0x244A6E1 VA: 0x244A5E0
	|-Memory<char>.CombineHashCodes
	|
	|-RVA: 0x244B770 Offset: 0x244B871 VA: 0x244B770
	|-Memory<object>.CombineHashCodes
	*/
}

[DebuggerTypeProxyAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
[IsReadOnlyAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
[DebuggerDisplayAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
public struct Memory<T> // TypeDefIndex: 4377
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _index; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public bool IsEmpty { get; }
	public Span<T> Span { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3098E0 Offset: 0x3099E1 VA: 0x3098E0
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309CB0 Offset: 0x309DB1 VA: 0x309CB0
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A080 Offset: 0x30A181 VA: 0x30A080
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309970 Offset: 0x309A71 VA: 0x309970
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309D40 Offset: 0x309E41 VA: 0x309D40
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A090 Offset: 0x30A191 VA: 0x30A090
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(MemoryManager<T> manager, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309A30 Offset: 0x309B31 VA: 0x309A30
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309E00 Offset: 0x309F01 VA: 0x309E00
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A0A0 Offset: 0x30A1A1 VA: 0x30A0A0
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object obj, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309A90 Offset: 0x309B91 VA: 0x309A90
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309E60 Offset: 0x309F61 VA: 0x309E60
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A100 Offset: 0x30A201 VA: 0x30A100
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24485E0 Offset: 0x24486E1 VA: 0x24485E0
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x2449730 Offset: 0x2449831 VA: 0x2449730
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244A970 Offset: 0x244AA71 VA: 0x244A970
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> op_Implicit(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2448690 Offset: 0x2448791 VA: 0x2448690
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x24497E0 Offset: 0x24498E1 VA: 0x24497E0
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244A9D0 Offset: 0x244AAD1 VA: 0x244A9D0
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlyMemory<T> op_Implicit(Memory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24487C0 Offset: 0x24488C1 VA: 0x24487C0
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x2449910 Offset: 0x2449A11 VA: 0x2449910
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244AAA0 Offset: 0x244ABA1 VA: 0x244AAA0
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AD0 Offset: 0x309BD1 VA: 0x309AD0
	|-Memory<byte>.get_Length
	|
	|-RVA: 0x309EA0 Offset: 0x309FA1 VA: 0x309EA0
	|-Memory<char>.get_Length
	|
	|-RVA: 0x30A140 Offset: 0x30A241 VA: 0x30A140
	|-Memory<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AE0 Offset: 0x309BE1 VA: 0x309AE0
	|-Memory<byte>.get_IsEmpty
	|
	|-RVA: 0x309EB0 Offset: 0x309FB1 VA: 0x309EB0
	|-Memory<char>.get_IsEmpty
	|
	|-RVA: 0x30A150 Offset: 0x30A251 VA: 0x30A150
	|-Memory<object>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AF0 Offset: 0x309BF1 VA: 0x309AF0
	|-Memory<byte>.ToString
	|
	|-RVA: 0x309EC0 Offset: 0x309FC1 VA: 0x309EC0
	|-Memory<char>.ToString
	|
	|-RVA: 0x30A160 Offset: 0x30A261 VA: 0x30A160
	|-Memory<object>.ToString
	*/

	// RVA: -1 Offset: -1
	public Memory<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309B00 Offset: 0x309C01 VA: 0x309B00
	|-Memory<byte>.Slice
	|
	|-RVA: 0x309ED0 Offset: 0x309FD1 VA: 0x309ED0
	|-Memory<char>.Slice
	|
	|-RVA: 0x30A170 Offset: 0x30A271 VA: 0x30A170
	|-Memory<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public Memory<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309BA0 Offset: 0x309CA1 VA: 0x309BA0
	|-Memory<byte>.Slice
	|
	|-RVA: 0x309F70 Offset: 0x30A071 VA: 0x309F70
	|-Memory<char>.Slice
	|
	|-RVA: 0x30A210 Offset: 0x30A311 VA: 0x30A210
	|-Memory<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public Span<T> get_Span() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C40 Offset: 0x309D41 VA: 0x309C40
	|-Memory<byte>.get_Span
	|
	|-RVA: 0x30A010 Offset: 0x30A111 VA: 0x30A010
	|-Memory<char>.get_Span
	|
	|-RVA: 0x30A2B0 Offset: 0x30A3B1 VA: 0x30A2B0
	|-Memory<object>.get_Span
	*/

	[EditorBrowsableAttribute] // RVA: 0x128CB0 Offset: 0x128DB1 VA: 0x128CB0
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C50 Offset: 0x309D51 VA: 0x309C50
	|-Memory<byte>.Equals
	|
	|-RVA: 0x30A020 Offset: 0x30A121 VA: 0x30A020
	|-Memory<char>.Equals
	|
	|-RVA: 0x30A2C0 Offset: 0x30A3C1 VA: 0x30A2C0
	|-Memory<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool Equals(Memory<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C60 Offset: 0x309D61 VA: 0x309C60
	|-Memory<byte>.Equals
	|
	|-RVA: 0x30A030 Offset: 0x30A131 VA: 0x30A030
	|-Memory<char>.Equals
	|
	|-RVA: 0x30A2D0 Offset: 0x30A3D1 VA: 0x30A2D0
	|-Memory<object>.Equals
	*/

	[EditorBrowsableAttribute] // RVA: 0x128CD0 Offset: 0x128DD1 VA: 0x128CD0
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309CA0 Offset: 0x309DA1 VA: 0x309CA0
	|-Memory<byte>.GetHashCode
	|
	|-RVA: 0x30A070 Offset: 0x30A171 VA: 0x30A070
	|-Memory<char>.GetHashCode
	|
	|-RVA: 0x30A310 Offset: 0x30A411 VA: 0x30A310
	|-Memory<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2449480 Offset: 0x2449581 VA: 0x2449480
	|-Memory<byte>.CombineHashCodes
	|
	|-RVA: 0x244A5D0 Offset: 0x244A6D1 VA: 0x244A5D0
	|-Memory<char>.CombineHashCodes
	|
	|-RVA: 0x244B760 Offset: 0x244B861 VA: 0x244B760
	|-Memory<object>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int h1, int h2, int h3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2449490 Offset: 0x2449591 VA: 0x2449490
	|-Memory<byte>.CombineHashCodes
	|
	|-RVA: 0x244A5E0 Offset: 0x244A6E1 VA: 0x244A5E0
	|-Memory<char>.CombineHashCodes
	|
	|-RVA: 0x244B770 Offset: 0x244B871 VA: 0x244B770
	|-Memory<object>.CombineHashCodes
	*/
}

[DebuggerTypeProxyAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
[IsReadOnlyAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
[DebuggerDisplayAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
public struct Memory<T> // TypeDefIndex: 4377
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _index; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public bool IsEmpty { get; }
	public Span<T> Span { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3098E0 Offset: 0x3099E1 VA: 0x3098E0
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309CB0 Offset: 0x309DB1 VA: 0x309CB0
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A080 Offset: 0x30A181 VA: 0x30A080
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309970 Offset: 0x309A71 VA: 0x309970
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309D40 Offset: 0x309E41 VA: 0x309D40
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A090 Offset: 0x30A191 VA: 0x30A090
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(MemoryManager<T> manager, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309A30 Offset: 0x309B31 VA: 0x309A30
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309E00 Offset: 0x309F01 VA: 0x309E00
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A0A0 Offset: 0x30A1A1 VA: 0x30A0A0
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object obj, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309A90 Offset: 0x309B91 VA: 0x309A90
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309E60 Offset: 0x309F61 VA: 0x309E60
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A100 Offset: 0x30A201 VA: 0x30A100
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24485E0 Offset: 0x24486E1 VA: 0x24485E0
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x2449730 Offset: 0x2449831 VA: 0x2449730
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244A970 Offset: 0x244AA71 VA: 0x244A970
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> op_Implicit(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2448690 Offset: 0x2448791 VA: 0x2448690
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x24497E0 Offset: 0x24498E1 VA: 0x24497E0
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244A9D0 Offset: 0x244AAD1 VA: 0x244A9D0
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlyMemory<T> op_Implicit(Memory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24487C0 Offset: 0x24488C1 VA: 0x24487C0
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x2449910 Offset: 0x2449A11 VA: 0x2449910
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244AAA0 Offset: 0x244ABA1 VA: 0x244AAA0
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AD0 Offset: 0x309BD1 VA: 0x309AD0
	|-Memory<byte>.get_Length
	|
	|-RVA: 0x309EA0 Offset: 0x309FA1 VA: 0x309EA0
	|-Memory<char>.get_Length
	|
	|-RVA: 0x30A140 Offset: 0x30A241 VA: 0x30A140
	|-Memory<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AE0 Offset: 0x309BE1 VA: 0x309AE0
	|-Memory<byte>.get_IsEmpty
	|
	|-RVA: 0x309EB0 Offset: 0x309FB1 VA: 0x309EB0
	|-Memory<char>.get_IsEmpty
	|
	|-RVA: 0x30A150 Offset: 0x30A251 VA: 0x30A150
	|-Memory<object>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AF0 Offset: 0x309BF1 VA: 0x309AF0
	|-Memory<byte>.ToString
	|
	|-RVA: 0x309EC0 Offset: 0x309FC1 VA: 0x309EC0
	|-Memory<char>.ToString
	|
	|-RVA: 0x30A160 Offset: 0x30A261 VA: 0x30A160
	|-Memory<object>.ToString
	*/

	// RVA: -1 Offset: -1
	public Memory<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309B00 Offset: 0x309C01 VA: 0x309B00
	|-Memory<byte>.Slice
	|
	|-RVA: 0x309ED0 Offset: 0x309FD1 VA: 0x309ED0
	|-Memory<char>.Slice
	|
	|-RVA: 0x30A170 Offset: 0x30A271 VA: 0x30A170
	|-Memory<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public Memory<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309BA0 Offset: 0x309CA1 VA: 0x309BA0
	|-Memory<byte>.Slice
	|
	|-RVA: 0x309F70 Offset: 0x30A071 VA: 0x309F70
	|-Memory<char>.Slice
	|
	|-RVA: 0x30A210 Offset: 0x30A311 VA: 0x30A210
	|-Memory<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public Span<T> get_Span() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C40 Offset: 0x309D41 VA: 0x309C40
	|-Memory<byte>.get_Span
	|
	|-RVA: 0x30A010 Offset: 0x30A111 VA: 0x30A010
	|-Memory<char>.get_Span
	|
	|-RVA: 0x30A2B0 Offset: 0x30A3B1 VA: 0x30A2B0
	|-Memory<object>.get_Span
	*/

	[EditorBrowsableAttribute] // RVA: 0x128CB0 Offset: 0x128DB1 VA: 0x128CB0
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C50 Offset: 0x309D51 VA: 0x309C50
	|-Memory<byte>.Equals
	|
	|-RVA: 0x30A020 Offset: 0x30A121 VA: 0x30A020
	|-Memory<char>.Equals
	|
	|-RVA: 0x30A2C0 Offset: 0x30A3C1 VA: 0x30A2C0
	|-Memory<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool Equals(Memory<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C60 Offset: 0x309D61 VA: 0x309C60
	|-Memory<byte>.Equals
	|
	|-RVA: 0x30A030 Offset: 0x30A131 VA: 0x30A030
	|-Memory<char>.Equals
	|
	|-RVA: 0x30A2D0 Offset: 0x30A3D1 VA: 0x30A2D0
	|-Memory<object>.Equals
	*/

	[EditorBrowsableAttribute] // RVA: 0x128CD0 Offset: 0x128DD1 VA: 0x128CD0
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309CA0 Offset: 0x309DA1 VA: 0x309CA0
	|-Memory<byte>.GetHashCode
	|
	|-RVA: 0x30A070 Offset: 0x30A171 VA: 0x30A070
	|-Memory<char>.GetHashCode
	|
	|-RVA: 0x30A310 Offset: 0x30A411 VA: 0x30A310
	|-Memory<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2449480 Offset: 0x2449581 VA: 0x2449480
	|-Memory<byte>.CombineHashCodes
	|
	|-RVA: 0x244A5D0 Offset: 0x244A6D1 VA: 0x244A5D0
	|-Memory<char>.CombineHashCodes
	|
	|-RVA: 0x244B760 Offset: 0x244B861 VA: 0x244B760
	|-Memory<object>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int h1, int h2, int h3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2449490 Offset: 0x2449591 VA: 0x2449490
	|-Memory<byte>.CombineHashCodes
	|
	|-RVA: 0x244A5E0 Offset: 0x244A6E1 VA: 0x244A5E0
	|-Memory<char>.CombineHashCodes
	|
	|-RVA: 0x244B770 Offset: 0x244B871 VA: 0x244B770
	|-Memory<object>.CombineHashCodes
	*/
}

[DebuggerTypeProxyAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
[IsReadOnlyAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
[DebuggerDisplayAttribute] // RVA: 0x128730 Offset: 0x128831 VA: 0x128730
public struct Memory<T> // TypeDefIndex: 4377
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _index; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public bool IsEmpty { get; }
	public Span<T> Span { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3098E0 Offset: 0x3099E1 VA: 0x3098E0
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309CB0 Offset: 0x309DB1 VA: 0x309CB0
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A080 Offset: 0x30A181 VA: 0x30A080
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309970 Offset: 0x309A71 VA: 0x309970
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309D40 Offset: 0x309E41 VA: 0x309D40
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A090 Offset: 0x30A191 VA: 0x30A090
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(MemoryManager<T> manager, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309A30 Offset: 0x309B31 VA: 0x309A30
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309E00 Offset: 0x309F01 VA: 0x309E00
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A0A0 Offset: 0x30A1A1 VA: 0x30A0A0
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object obj, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309A90 Offset: 0x309B91 VA: 0x309A90
	|-Memory<byte>..ctor
	|
	|-RVA: 0x309E60 Offset: 0x309F61 VA: 0x309E60
	|-Memory<char>..ctor
	|
	|-RVA: 0x30A100 Offset: 0x30A201 VA: 0x30A100
	|-Memory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24485E0 Offset: 0x24486E1 VA: 0x24485E0
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x2449730 Offset: 0x2449831 VA: 0x2449730
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244A970 Offset: 0x244AA71 VA: 0x244A970
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> op_Implicit(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2448690 Offset: 0x2448791 VA: 0x2448690
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x24497E0 Offset: 0x24498E1 VA: 0x24497E0
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244A9D0 Offset: 0x244AAD1 VA: 0x244A9D0
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlyMemory<T> op_Implicit(Memory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24487C0 Offset: 0x24488C1 VA: 0x24487C0
	|-Memory<byte>.op_Implicit
	|
	|-RVA: 0x2449910 Offset: 0x2449A11 VA: 0x2449910
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x244AAA0 Offset: 0x244ABA1 VA: 0x244AAA0
	|-Memory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AD0 Offset: 0x309BD1 VA: 0x309AD0
	|-Memory<byte>.get_Length
	|
	|-RVA: 0x309EA0 Offset: 0x309FA1 VA: 0x309EA0
	|-Memory<char>.get_Length
	|
	|-RVA: 0x30A140 Offset: 0x30A241 VA: 0x30A140
	|-Memory<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AE0 Offset: 0x309BE1 VA: 0x309AE0
	|-Memory<byte>.get_IsEmpty
	|
	|-RVA: 0x309EB0 Offset: 0x309FB1 VA: 0x309EB0
	|-Memory<char>.get_IsEmpty
	|
	|-RVA: 0x30A150 Offset: 0x30A251 VA: 0x30A150
	|-Memory<object>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309AF0 Offset: 0x309BF1 VA: 0x309AF0
	|-Memory<byte>.ToString
	|
	|-RVA: 0x309EC0 Offset: 0x309FC1 VA: 0x309EC0
	|-Memory<char>.ToString
	|
	|-RVA: 0x30A160 Offset: 0x30A261 VA: 0x30A160
	|-Memory<object>.ToString
	*/

	// RVA: -1 Offset: -1
	public Memory<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309B00 Offset: 0x309C01 VA: 0x309B00
	|-Memory<byte>.Slice
	|
	|-RVA: 0x309ED0 Offset: 0x309FD1 VA: 0x309ED0
	|-Memory<char>.Slice
	|
	|-RVA: 0x30A170 Offset: 0x30A271 VA: 0x30A170
	|-Memory<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public Memory<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309BA0 Offset: 0x309CA1 VA: 0x309BA0
	|-Memory<byte>.Slice
	|
	|-RVA: 0x309F70 Offset: 0x30A071 VA: 0x309F70
	|-Memory<char>.Slice
	|
	|-RVA: 0x30A210 Offset: 0x30A311 VA: 0x30A210
	|-Memory<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public Span<T> get_Span() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C40 Offset: 0x309D41 VA: 0x309C40
	|-Memory<byte>.get_Span
	|
	|-RVA: 0x30A010 Offset: 0x30A111 VA: 0x30A010
	|-Memory<char>.get_Span
	|
	|-RVA: 0x30A2B0 Offset: 0x30A3B1 VA: 0x30A2B0
	|-Memory<object>.get_Span
	*/

	[EditorBrowsableAttribute] // RVA: 0x128CB0 Offset: 0x128DB1 VA: 0x128CB0
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C50 Offset: 0x309D51 VA: 0x309C50
	|-Memory<byte>.Equals
	|
	|-RVA: 0x30A020 Offset: 0x30A121 VA: 0x30A020
	|-Memory<char>.Equals
	|
	|-RVA: 0x30A2C0 Offset: 0x30A3C1 VA: 0x30A2C0
	|-Memory<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool Equals(Memory<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309C60 Offset: 0x309D61 VA: 0x309C60
	|-Memory<byte>.Equals
	|
	|-RVA: 0x30A030 Offset: 0x30A131 VA: 0x30A030
	|-Memory<char>.Equals
	|
	|-RVA: 0x30A2D0 Offset: 0x30A3D1 VA: 0x30A2D0
	|-Memory<object>.Equals
	*/

	[EditorBrowsableAttribute] // RVA: 0x128CD0 Offset: 0x128DD1 VA: 0x128CD0
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309CA0 Offset: 0x309DA1 VA: 0x309CA0
	|-Memory<byte>.GetHashCode
	|
	|-RVA: 0x30A070 Offset: 0x30A171 VA: 0x30A070
	|-Memory<char>.GetHashCode
	|
	|-RVA: 0x30A310 Offset: 0x30A411 VA: 0x30A310
	|-Memory<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2449480 Offset: 0x2449581 VA: 0x2449480
	|-Memory<byte>.CombineHashCodes
	|
	|-RVA: 0x244A5D0 Offset: 0x244A6D1 VA: 0x244A5D0
	|-Memory<char>.CombineHashCodes
	|
	|-RVA: 0x244B760 Offset: 0x244B861 VA: 0x244B760
	|-Memory<object>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int h1, int h2, int h3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2449490 Offset: 0x2449591 VA: 0x2449490
	|-Memory<byte>.CombineHashCodes
	|
	|-RVA: 0x244A5E0 Offset: 0x244A6E1 VA: 0x244A5E0
	|-Memory<char>.CombineHashCodes
	|
	|-RVA: 0x244B770 Offset: 0x244B871 VA: 0x244B770
	|-Memory<object>.CombineHashCodes
	*/
}

