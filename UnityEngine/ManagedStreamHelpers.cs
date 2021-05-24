internal static class ManagedStreamHelpers // TypeDefIndex: 3016
{
	// Methods

	// RVA: 0x1A31530 Offset: 0x1A31631 VA: 0x1A31530
	internal static void ValidateLoadFromStream(Stream stream) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD6C80 Offset: 0xD6D81 VA: 0xD6C80
	// RVA: 0x1A31640 Offset: 0x1A31741 VA: 0x1A31640
	internal static void ManagedStreamRead(byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD6C90 Offset: 0xD6D91 VA: 0xD6C90
	// RVA: 0x1A31740 Offset: 0x1A31841 VA: 0x1A31740
	internal static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD6CA0 Offset: 0xD6DA1 VA: 0xD6CA0
	// RVA: 0x1A31840 Offset: 0x1A31941 VA: 0x1A31840
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }
}

