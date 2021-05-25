[ExtensionAttribute] // RVA: 0x1287D0 Offset: 0x1288D1 VA: 0x1287D0
public static class MemoryExtensions // TypeDefIndex: 4379
{
	// Fields
	internal static readonly IntPtr StringAdjustment; // 0x0

	// Methods

	[ExtensionAttribute] // RVA: 0x128CF0 Offset: 0x128DF1 VA: 0x128CF0
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(Span<T> span, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255C1C0 Offset: 0x255C2C1 VA: 0x255C1C0
	|-MemoryExtensions.IndexOf<byte>
	|
	|-RVA: 0x255C410 Offset: 0x255C511 VA: 0x255C410
	|-MemoryExtensions.IndexOf<object>
	*/

	[ExtensionAttribute] // RVA: 0x128D00 Offset: 0x128E01 VA: 0x128D00
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<T>(Span<T> span, ReadOnlySpan<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CCFB0 Offset: 0x22CD0B1 VA: 0x22CCFB0
	|-MemoryExtensions.SequenceEqual<byte>
	|
	|-RVA: 0x22CD2E0 Offset: 0x22CD3E1 VA: 0x22CD2E0
	|-MemoryExtensions.SequenceEqual<object>
	*/

	[ExtensionAttribute] // RVA: 0x128D10 Offset: 0x128E11 VA: 0x128D10
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CCD90 Offset: 0x22CCE91 VA: 0x22CCD90
	|-MemoryExtensions.SequenceEqual<byte>
	|
	|-RVA: 0x22CD1D0 Offset: 0x22CD2D1 VA: 0x22CD1D0
	|-MemoryExtensions.SequenceEqual<object>
	*/

	[ExtensionAttribute] // RVA: 0x128D20 Offset: 0x128E21 VA: 0x128D20
	// RVA: -1 Offset: -1
	public static Span<T> AsSpan<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2562310 Offset: 0x2562411 VA: 0x2562310
	|-MemoryExtensions.AsSpan<byte>
	|
	|-RVA: 0x25624E0 Offset: 0x25625E1 VA: 0x25624E0
	|-MemoryExtensions.AsSpan<object>
	*/

	[ExtensionAttribute] // RVA: 0x128D30 Offset: 0x128E31 VA: 0x128D30
	// RVA: -1 Offset: -1
	public static Span<T> AsSpan<T>(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2562360 Offset: 0x2562461 VA: 0x2562360
	|-MemoryExtensions.AsSpan<byte>
	|
	|-RVA: 0x2562530 Offset: 0x2562631 VA: 0x2562530
	|-MemoryExtensions.AsSpan<object>
	*/

	[ExtensionAttribute] // RVA: 0x128D40 Offset: 0x128E41 VA: 0x128D40
	// RVA: -1 Offset: -1
	public static Span<T> AsSpan<T>(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25621F0 Offset: 0x25622F1 VA: 0x25621F0
	|-MemoryExtensions.AsSpan<byte>
	|
	|-RVA: 0x25623C0 Offset: 0x25624C1 VA: 0x25623C0
	|-MemoryExtensions.AsSpan<object>
	*/

	[ExtensionAttribute] // RVA: 0x128D50 Offset: 0x128E51 VA: 0x128D50
	// RVA: -1 Offset: -1
	public static Span<T> AsSpan<T>(ArraySegment<T> segment, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2562250 Offset: 0x2562351 VA: 0x2562250
	|-MemoryExtensions.AsSpan<byte>
	|
	|-RVA: 0x2562420 Offset: 0x2562521 VA: 0x2562420
	|-MemoryExtensions.AsSpan<object>
	*/

	[ExtensionAttribute] // RVA: 0x128D60 Offset: 0x128E61 VA: 0x128D60
	// RVA: -1 Offset: -1
	public static Memory<T> AsMemory<T>(ArraySegment<T> segment, int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2561010 Offset: 0x2561111 VA: 0x2561010
	|-MemoryExtensions.AsMemory<byte>
	|
	|-RVA: 0x2561110 Offset: 0x2561211 VA: 0x2561110
	|-MemoryExtensions.AsMemory<object>
	*/

	// RVA: -1 Offset: -1
	private static bool IsTypeComparableAsBytes<T>(out NUInt size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CC610 Offset: 0x22CC711 VA: 0x22CC610
	|-MemoryExtensions.IsTypeComparableAsBytes<byte>
	|
	|-RVA: 0x22CC9D0 Offset: 0x22CCAD1 VA: 0x22CC9D0
	|-MemoryExtensions.IsTypeComparableAsBytes<object>
	*/

	[ExtensionAttribute] // RVA: 0x128D70 Offset: 0x128E71 VA: 0x128D70
	// RVA: 0x1B699D0 Offset: 0x1B69AD1 VA: 0x1B699D0
	public static ReadOnlyMemory<char> AsMemory(string text, int start, int length) { }

	// RVA: 0x1B69AC0 Offset: 0x1B69BC1 VA: 0x1B69AC0
	private static IntPtr MeasureStringAdjustment() { }

	// RVA: 0x1B69B30 Offset: 0x1B69C31 VA: 0x1B69B30
	private static void .cctor() { }
}

