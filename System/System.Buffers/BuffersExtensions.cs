[ExtensionAttribute] // RVA: 0x128B10 Offset: 0x128C11 VA: 0x128B10
public static class BuffersExtensions // TypeDefIndex: 4398
{
	// Methods

	[ExtensionAttribute] // RVA: 0x128FF0 Offset: 0x1290F1 VA: 0x128FF0
	// RVA: -1 Offset: -1
	public static void CopyTo<T>(in ReadOnlySequence<T> source, Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24B23B0 Offset: 0x24B24B1 VA: 0x24B23B0
	|-BuffersExtensions.CopyTo<byte>
	|
	|-RVA: 0x24B24D0 Offset: 0x24B25D1 VA: 0x24B24D0
	|-BuffersExtensions.CopyTo<char>
	|
	|-RVA: 0x24B25F0 Offset: 0x24B26F1 VA: 0x24B25F0
	|-BuffersExtensions.CopyTo<object>
	*/

	// RVA: -1 Offset: -1
	private static void CopyToMultiSegment<T>(in ReadOnlySequence<T> sequence, Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24B2710 Offset: 0x24B2811 VA: 0x24B2710
	|-BuffersExtensions.CopyToMultiSegment<byte>
	|
	|-RVA: 0x24B28F0 Offset: 0x24B29F1 VA: 0x24B28F0
	|-BuffersExtensions.CopyToMultiSegment<char>
	|
	|-RVA: 0x24B2AD0 Offset: 0x24B2BD1 VA: 0x24B2AD0
	|-BuffersExtensions.CopyToMultiSegment<object>
	*/

	[ExtensionAttribute] // RVA: 0x129000 Offset: 0x129101 VA: 0x129000
	// RVA: -1 Offset: -1
	public static T[] ToArray<T>(in ReadOnlySequence<T> sequence) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2270CE0 Offset: 0x2270DE1 VA: 0x2270CE0
	|-BuffersExtensions.ToArray<byte>
	|
	|-RVA: 0x2270DC0 Offset: 0x2270EC1 VA: 0x2270DC0
	|-BuffersExtensions.ToArray<char>
	|
	|-RVA: 0x2270EA0 Offset: 0x2270FA1 VA: 0x2270EA0
	|-BuffersExtensions.ToArray<object>
	*/
}

