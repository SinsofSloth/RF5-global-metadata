[DebuggerDisplayAttribute] // RVA: 0x1287E0 Offset: 0x1288E1 VA: 0x1287E0
[IsReadOnlyAttribute] // RVA: 0x1287E0 Offset: 0x1288E1 VA: 0x1287E0
[DebuggerTypeProxyAttribute] // RVA: 0x1287E0 Offset: 0x1288E1 VA: 0x1287E0
public struct ReadOnlyMemory<T> // TypeDefIndex: 4380
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _index; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public bool IsEmpty { get; }
	public ReadOnlySpan<T> Span { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x371850 Offset: 0x371951 VA: 0x371850
	|-ReadOnlyMemory<byte>..ctor
	|
	|-RVA: 0x371B80 Offset: 0x371C81 VA: 0x371B80
	|-ReadOnlyMemory<char>..ctor
	|
	|-RVA: 0x371EB0 Offset: 0x371FB1 VA: 0x371EB0
	|-ReadOnlyMemory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3718A0 Offset: 0x3719A1 VA: 0x3718A0
	|-ReadOnlyMemory<byte>..ctor
	|
	|-RVA: 0x371BD0 Offset: 0x371CD1 VA: 0x371BD0
	|-ReadOnlyMemory<char>..ctor
	|
	|-RVA: 0x371F00 Offset: 0x372001 VA: 0x371F00
	|-ReadOnlyMemory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object obj, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x371930 Offset: 0x371A31 VA: 0x371930
	|-ReadOnlyMemory<byte>..ctor
	|
	|-RVA: 0x371C60 Offset: 0x371D61 VA: 0x371C60
	|-ReadOnlyMemory<char>..ctor
	|
	|-RVA: 0x371F90 Offset: 0x372091 VA: 0x371F90
	|-ReadOnlyMemory<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlyMemory<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2951BD0 Offset: 0x2951CD1 VA: 0x2951BD0
	|-ReadOnlyMemory<byte>.op_Implicit
	|
	|-RVA: 0x2952C20 Offset: 0x2952D21 VA: 0x2952C20
	|-ReadOnlyMemory<char>.op_Implicit
	|
	|-RVA: 0x2953C70 Offset: 0x2953D71 VA: 0x2953C70
	|-ReadOnlyMemory<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x371970 Offset: 0x371A71 VA: 0x371970
	|-ReadOnlyMemory<byte>.get_Length
	|
	|-RVA: 0x371CA0 Offset: 0x371DA1 VA: 0x371CA0
	|-ReadOnlyMemory<char>.get_Length
	|
	|-RVA: 0x371FD0 Offset: 0x3720D1 VA: 0x371FD0
	|-ReadOnlyMemory<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x371980 Offset: 0x371A81 VA: 0x371980
	|-ReadOnlyMemory<byte>.get_IsEmpty
	|
	|-RVA: 0x371CB0 Offset: 0x371DB1 VA: 0x371CB0
	|-ReadOnlyMemory<char>.get_IsEmpty
	|
	|-RVA: 0x371FE0 Offset: 0x3720E1 VA: 0x371FE0
	|-ReadOnlyMemory<object>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x371990 Offset: 0x371A91 VA: 0x371990
	|-ReadOnlyMemory<byte>.ToString
	|
	|-RVA: 0x371CC0 Offset: 0x371DC1 VA: 0x371CC0
	|-ReadOnlyMemory<char>.ToString
	|
	|-RVA: 0x371FF0 Offset: 0x3720F1 VA: 0x371FF0
	|-ReadOnlyMemory<object>.ToString
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyMemory<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3719A0 Offset: 0x371AA1 VA: 0x3719A0
	|-ReadOnlyMemory<byte>.Slice
	|
	|-RVA: 0x371CD0 Offset: 0x371DD1 VA: 0x371CD0
	|-ReadOnlyMemory<char>.Slice
	|
	|-RVA: 0x372000 Offset: 0x372101 VA: 0x372000
	|-ReadOnlyMemory<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyMemory<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x371A40 Offset: 0x371B41 VA: 0x371A40
	|-ReadOnlyMemory<byte>.Slice
	|
	|-RVA: 0x371D70 Offset: 0x371E71 VA: 0x371D70
	|-ReadOnlyMemory<char>.Slice
	|
	|-RVA: 0x3720A0 Offset: 0x3721A1 VA: 0x3720A0
	|-ReadOnlyMemory<object>.Slice
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> get_Span() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x371AE0 Offset: 0x371BE1 VA: 0x371AE0
	|-ReadOnlyMemory<byte>.get_Span
	|
	|-RVA: 0x371E10 Offset: 0x371F11 VA: 0x371E10
	|-ReadOnlyMemory<char>.get_Span
	|
	|-RVA: 0x372140 Offset: 0x372241 VA: 0x372140
	|-ReadOnlyMemory<object>.get_Span
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Memory<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x371AF0 Offset: 0x371BF1 VA: 0x371AF0
	|-ReadOnlyMemory<byte>.CopyTo
	|
	|-RVA: 0x371E20 Offset: 0x371F21 VA: 0x371E20
	|-ReadOnlyMemory<char>.CopyTo
	|
	|-RVA: 0x372150 Offset: 0x372251 VA: 0x372150
	|-ReadOnlyMemory<object>.CopyTo
	*/

	[EditorBrowsableAttribute] // RVA: 0x128D80 Offset: 0x128E81 VA: 0x128D80
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x371B00 Offset: 0x371C01 VA: 0x371B00
	|-ReadOnlyMemory<byte>.Equals
	|
	|-RVA: 0x371E30 Offset: 0x371F31 VA: 0x371E30
	|-ReadOnlyMemory<char>.Equals
	|
	|-RVA: 0x372160 Offset: 0x372261 VA: 0x372160
	|-ReadOnlyMemory<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool Equals(ReadOnlyMemory<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x371B10 Offset: 0x371C11 VA: 0x371B10
	|-ReadOnlyMemory<byte>.Equals
	|
	|-RVA: 0x371E40 Offset: 0x371F41 VA: 0x371E40
	|-ReadOnlyMemory<char>.Equals
	|
	|-RVA: 0x372170 Offset: 0x372271 VA: 0x372170
	|-ReadOnlyMemory<object>.Equals
	*/

	[EditorBrowsableAttribute] // RVA: 0x128DA0 Offset: 0x128EA1 VA: 0x128DA0
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x371B50 Offset: 0x371C51 VA: 0x371B50
	|-ReadOnlyMemory<byte>.GetHashCode
	|
	|-RVA: 0x371E80 Offset: 0x371F81 VA: 0x371E80
	|-ReadOnlyMemory<char>.GetHashCode
	|
	|-RVA: 0x3721B0 Offset: 0x3722B1 VA: 0x3721B0
	|-ReadOnlyMemory<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29529F0 Offset: 0x2952AF1 VA: 0x29529F0
	|-ReadOnlyMemory<byte>.CombineHashCodes
	|
	|-RVA: 0x2953A40 Offset: 0x2953B41 VA: 0x2953A40
	|-ReadOnlyMemory<char>.CombineHashCodes
	|
	|-RVA: 0x2954A60 Offset: 0x2954B61 VA: 0x2954A60
	|-ReadOnlyMemory<object>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int h1, int h2, int h3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2952A00 Offset: 0x2952B01 VA: 0x2952A00
	|-ReadOnlyMemory<byte>.CombineHashCodes
	|
	|-RVA: 0x2953A50 Offset: 0x2953B51 VA: 0x2953A50
	|-ReadOnlyMemory<char>.CombineHashCodes
	|
	|-RVA: 0x2954A70 Offset: 0x2954B71 VA: 0x2954A70
	|-ReadOnlyMemory<object>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	internal object GetObjectStartLength(out int start, out int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x371B60 Offset: 0x371C61 VA: 0x371B60
	|-ReadOnlyMemory<byte>.GetObjectStartLength
	|
	|-RVA: 0x371E90 Offset: 0x371F91 VA: 0x371E90
	|-ReadOnlyMemory<char>.GetObjectStartLength
	|
	|-RVA: 0x3721C0 Offset: 0x3722C1 VA: 0x3721C0
	|-ReadOnlyMemory<object>.GetObjectStartLength
	*/
}

