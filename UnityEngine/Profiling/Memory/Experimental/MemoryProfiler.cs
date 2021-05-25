[NativeHeaderAttribute] // RVA: 0xC7820 Offset: 0xC7921 VA: 0xC7820
public sealed class MemoryProfiler // TypeDefIndex: 3091
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0xCAC80 Offset: 0xCAD81 VA: 0xCAC80
	[CompilerGeneratedAttribute] // RVA: 0xCAC80 Offset: 0xCAD81 VA: 0xCAC80
	private static Action<string, bool> m_SnapshotFinished; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0xCACC0 Offset: 0xCADC1 VA: 0xCACC0
	[CompilerGeneratedAttribute] // RVA: 0xCACC0 Offset: 0xCADC1 VA: 0xCACC0
	private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0xCAD00 Offset: 0xCAE01 VA: 0xCAD00
	[CompilerGeneratedAttribute] // RVA: 0xCAD00 Offset: 0xCAE01 VA: 0xCAD00
	private static Action<MetaData> createMetaData; // 0x10

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xD9310 Offset: 0xD9411 VA: 0xD9310
	// RVA: 0x2B73160 Offset: 0x2B73261 VA: 0x2B73160
	private static byte[] PrepareMetadata() { }

	// RVA: 0x2B73360 Offset: 0x2B73461 VA: 0x2B73360
	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	// RVA: 0x2B73400 Offset: 0x2B73501 VA: 0x2B73400
	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9320 Offset: 0xD9421 VA: 0xD9320
	// RVA: 0x2B734C0 Offset: 0x2B735C1 VA: 0x2B734C0
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9330 Offset: 0xD9431 VA: 0xD9330
	// RVA: 0x2B73560 Offset: 0x2B73661 VA: 0x2B73560
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }
}

