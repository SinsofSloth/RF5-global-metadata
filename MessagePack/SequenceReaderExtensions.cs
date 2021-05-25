[ExtensionAttribute] // RVA: 0x139300 Offset: 0x139401 VA: 0x139300
internal static class SequenceReaderExtensions // TypeDefIndex: 5173
{
	// Methods

	[ExtensionAttribute] // RVA: 0x13A410 Offset: 0x13A511 VA: 0x13A410
	// RVA: -1 Offset: -1
	internal static bool TryRead<T>(ref SequenceReader<byte> reader, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519420 Offset: 0x2519521 VA: 0x2519420
	|-SequenceReaderExtensions.TryRead<byte>
	|
	|-RVA: 0x2519520 Offset: 0x2519621 VA: 0x2519520
	|-SequenceReaderExtensions.TryRead<short>
	|
	|-RVA: 0x2519620 Offset: 0x2519721 VA: 0x2519620
	|-SequenceReaderExtensions.TryRead<int>
	|
	|-RVA: 0x2519720 Offset: 0x2519821 VA: 0x2519720
	|-SequenceReaderExtensions.TryRead<long>
	*/

	// RVA: -1 Offset: -1
	private static bool TryReadMultisegment<T>(ref SequenceReader<byte> reader, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519820 Offset: 0x2519921 VA: 0x2519820
	|-SequenceReaderExtensions.TryReadMultisegment<byte>
	|
	|-RVA: 0x2519930 Offset: 0x2519A31 VA: 0x2519930
	|-SequenceReaderExtensions.TryReadMultisegment<short>
	|
	|-RVA: 0x2519A40 Offset: 0x2519B41 VA: 0x2519A40
	|-SequenceReaderExtensions.TryReadMultisegment<int>
	|
	|-RVA: 0x2519B50 Offset: 0x2519C51 VA: 0x2519B50
	|-SequenceReaderExtensions.TryReadMultisegment<long>
	*/

	[ExtensionAttribute] // RVA: 0x13A420 Offset: 0x13A521 VA: 0x13A420
	// RVA: 0x14F9B00 Offset: 0x14F9C01 VA: 0x14F9B00
	public static bool TryRead(ref SequenceReader<byte> reader, out sbyte value) { }

	[ExtensionAttribute] // RVA: 0x13A430 Offset: 0x13A531 VA: 0x13A430
	// RVA: 0x14F9C50 Offset: 0x14F9D51 VA: 0x14F9C50
	public static bool TryReadBigEndian(ref SequenceReader<byte> reader, out short value) { }

	[ExtensionAttribute] // RVA: 0x13A440 Offset: 0x13A541 VA: 0x13A440
	// RVA: 0x14F9F30 Offset: 0x14FA031 VA: 0x14F9F30
	public static bool TryReadBigEndian(ref SequenceReader<byte> reader, out ushort value) { }

	// RVA: 0x14F9DE0 Offset: 0x14F9EE1 VA: 0x14F9DE0
	private static bool TryReadReverseEndianness(ref SequenceReader<byte> reader, out short value) { }

	[ExtensionAttribute] // RVA: 0x13A450 Offset: 0x13A551 VA: 0x13A450
	// RVA: 0x14F9F70 Offset: 0x14FA071 VA: 0x14F9F70
	public static bool TryReadBigEndian(ref SequenceReader<byte> reader, out int value) { }

	[ExtensionAttribute] // RVA: 0x13A460 Offset: 0x13A561 VA: 0x13A460
	// RVA: 0x14FA240 Offset: 0x14FA341 VA: 0x14FA240
	public static bool TryReadBigEndian(ref SequenceReader<byte> reader, out uint value) { }

	// RVA: 0x14FA100 Offset: 0x14FA201 VA: 0x14FA100
	private static bool TryReadReverseEndianness(ref SequenceReader<byte> reader, out int value) { }

	[ExtensionAttribute] // RVA: 0x13A470 Offset: 0x13A571 VA: 0x13A470
	// RVA: 0x14FA280 Offset: 0x14FA381 VA: 0x14FA280
	public static bool TryReadBigEndian(ref SequenceReader<byte> reader, out long value) { }

	[ExtensionAttribute] // RVA: 0x13A480 Offset: 0x13A581 VA: 0x13A480
	// RVA: 0x14FA560 Offset: 0x14FA661 VA: 0x14FA560
	public static bool TryReadBigEndian(ref SequenceReader<byte> reader, out ulong value) { }

	// RVA: 0x14FA410 Offset: 0x14FA511 VA: 0x14FA410
	private static bool TryReadReverseEndianness(ref SequenceReader<byte> reader, out long value) { }

	[ExtensionAttribute] // RVA: 0x13A490 Offset: 0x13A591 VA: 0x13A490
	// RVA: 0x14FA5A0 Offset: 0x14FA6A1 VA: 0x14FA5A0
	public static bool TryReadBigEndian(ref SequenceReader<byte> reader, out float value) { }

	[ExtensionAttribute] // RVA: 0x13A4A0 Offset: 0x13A5A1 VA: 0x13A4A0
	// RVA: 0x14FA5F0 Offset: 0x14FA6F1 VA: 0x14FA5F0
	public static bool TryReadBigEndian(ref SequenceReader<byte> reader, out double value) { }
}

