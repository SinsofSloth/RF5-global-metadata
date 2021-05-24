[ExtensionAttribute] // RVA: 0x139310 Offset: 0x139411 VA: 0x139310
internal static class StreamPolyfillExtensions // TypeDefIndex: 5174
{
	// Methods

	[ExtensionAttribute] // RVA: 0x13A4B0 Offset: 0x13A5B1 VA: 0x13A4B0
	// RVA: 0x14FA650 Offset: 0x14FA751 VA: 0x14FA650
	internal static int Read(Stream stream, Span<byte> buffer) { }

	[ExtensionAttribute] // RVA: 0x13A4C0 Offset: 0x13A5C1 VA: 0x13A4C0
	// RVA: 0x14EBF40 Offset: 0x14EC041 VA: 0x14EBF40
	internal static ValueTask<int> ReadAsync(Stream stream, Memory<byte> buffer, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x13A4D0 Offset: 0x13A5D1 VA: 0x13A4D0
	// RVA: 0x14FAAE0 Offset: 0x14FABE1 VA: 0x14FAAE0
	internal static void Write(Stream stream, ReadOnlySpan<byte> buffer) { }

	[AsyncStateMachineAttribute] // RVA: 0x13A4E0 Offset: 0x13A5E1 VA: 0x13A4E0
	[ExtensionAttribute] // RVA: 0x13A4E0 Offset: 0x13A5E1 VA: 0x13A4E0
	// RVA: 0x14FADB0 Offset: 0x14FAEB1 VA: 0x14FADB0
	internal static ValueTask WriteAsync(Stream stream, ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x13A560 Offset: 0x13A661 VA: 0x13A560
	[CompilerGeneratedAttribute] // RVA: 0x13A560 Offset: 0x13A661 VA: 0x13A560
	// RVA: 0x14FA970 Offset: 0x14FAA71 VA: 0x14FA970
	internal static ValueTask<int> <ReadAsync>g__FinishReadAsync|1_0(Task<int> readTask, byte[] localBuffer, Memory<byte> localDestination) { }
}

