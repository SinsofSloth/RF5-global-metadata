internal class DeflateStreamNative // TypeDefIndex: 1868
{
	// Fields
	private DeflateStreamNative.UnmanagedReadOrWrite feeder; // 0x10
	private Stream base_stream; // 0x18
	private DeflateStreamNative.SafeDeflateStreamHandle z_stream; // 0x20
	private GCHandle data; // 0x28
	private bool disposed; // 0x2C
	private byte[] io_buffer; // 0x30

	// Methods

	// RVA: 0x28ED950 Offset: 0x28EDA51 VA: 0x28ED950
	private void .ctor() { }

	// RVA: 0x28EB7C0 Offset: 0x28EB8C1 VA: 0x28EB7C0
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x28EDA50 Offset: 0x28EDB51 VA: 0x28EDA50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x28EBA60 Offset: 0x28EBB61 VA: 0x28EBA60
	public void Dispose(bool disposing) { }

	// RVA: 0x28EC280 Offset: 0x28EC381 VA: 0x28EC280
	public void Flush() { }

	// RVA: 0x28EBB90 Offset: 0x28EBC91 VA: 0x28EBB90
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x28EBEC0 Offset: 0x28EBFC1 VA: 0x28EBEC0
	public void WriteZStream(IntPtr buffer, int length) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xBD740 Offset: 0xBD841 VA: 0xBD740
	// RVA: 0x28ED7B0 Offset: 0x28ED8B1 VA: 0x28ED7B0
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x28EDD40 Offset: 0x28EDE41 VA: 0x28EDD40
	private int UnmanagedRead(IntPtr buffer, int length) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xBD7B0 Offset: 0xBD8B1 VA: 0xBD7B0
	// RVA: 0x28ED880 Offset: 0x28ED981 VA: 0x28ED880
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x28EDE80 Offset: 0x28EDF81 VA: 0x28EDE80
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x28EDB70 Offset: 0x28EDC71 VA: 0x28EDB70
	private static void CheckResult(int result, string where) { }

	// RVA: 0x28ED980 Offset: 0x28EDA81 VA: 0x28ED980
	private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x28EE040 Offset: 0x28EE141 VA: 0x28EE040
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x28EDB00 Offset: 0x28EDC01 VA: 0x28EDB00
	private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream) { }

	// RVA: 0x28EDC40 Offset: 0x28EDD41 VA: 0x28EDC40
	private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x28EDCC0 Offset: 0x28EDDC1 VA: 0x28EDCC0
	private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }
}

