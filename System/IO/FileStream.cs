[ComVisibleAttribute] // RVA: 0xAEC60 Offset: 0xAED61 VA: 0xAEC60
public class FileStream : Stream // TypeDefIndex: 685
{
	// Fields
	private static byte[] buf_recycle; // 0x0
	private static readonly object buf_recycle_lock; // 0x8
	private byte[] buf; // 0x28
	private string name; // 0x30
	private SafeFileHandle safeHandle; // 0x38
	private bool isExposed; // 0x40
	private long append_startpos; // 0x48
	private FileAccess access; // 0x50
	private bool owner; // 0x54
	private bool async; // 0x55
	private bool canseek; // 0x56
	private bool anonymous; // 0x57
	private bool buf_dirty; // 0x58
	private int buf_size; // 0x5C
	private int buf_length; // 0x60
	private int buf_offset; // 0x64
	private long buf_start; // 0x68

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public virtual SafeFileHandle SafeFileHandle { get; }

	// Methods

	// RVA: 0x18A4B70 Offset: 0x18A4C71 VA: 0x18A4B70
	internal void .ctor(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x18A5040 Offset: 0x18A5141 VA: 0x18A5040
	public void .ctor(string path, FileMode mode, FileAccess access) { }

	// RVA: 0x18A25F0 Offset: 0x18A26F1 VA: 0x18A25F0
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x18A1980 Offset: 0x18A1A81 VA: 0x18A1980
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	// RVA: 0x18A5910 Offset: 0x18A5A11 VA: 0x18A5910
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	// RVA: 0x18A5950 Offset: 0x18A5A51 VA: 0x18A5950
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	// RVA: 0x18A5980 Offset: 0x18A5A81 VA: 0x18A5980
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, string msgPath, bool bFromProxy, bool useLongPath = False, bool checkHost = False) { }

	// RVA: 0x18A5080 Offset: 0x18A5181 VA: 0x18A5080
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous) { }

	// RVA: 0x18A50B0 Offset: 0x18A51B1 VA: 0x18A50B0
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	// RVA: 0x18A4D10 Offset: 0x18A4E11 VA: 0x18A4D10
	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x18A6BB0 Offset: 0x18A6CB1 VA: 0x18A6BB0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x18A6BD0 Offset: 0x18A6CD1 VA: 0x18A6BD0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x18A6BF0 Offset: 0x18A6CF1 VA: 0x18A6BF0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x18A6C00 Offset: 0x18A6D01 VA: 0x18A6C00 Slot: 10
	public override long get_Length() { }

	// RVA: 0x18A6E90 Offset: 0x18A6F91 VA: 0x18A6E90 Slot: 11
	public override long get_Position() { }

	// RVA: 0x18A7020 Offset: 0x18A7121 VA: 0x18A7020 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x18A70E0 Offset: 0x18A71E1 VA: 0x18A70E0 Slot: 29
	public virtual SafeFileHandle get_SafeFileHandle() { }

	// RVA: 0x18A6A00 Offset: 0x18A6B01 VA: 0x18A6A00
	private void ExposeHandle() { }

	// RVA: 0x18A7330 Offset: 0x18A7431 VA: 0x18A7330 Slot: 26
	public override int ReadByte() { }

	// RVA: 0x18A7650 Offset: 0x18A7751 VA: 0x18A7650 Slot: 28
	public override void WriteByte(byte value) { }

	// RVA: 0x18A77D0 Offset: 0x18A78D1 VA: 0x18A77D0 Slot: 25
	public override int Read([In] [Out] byte[] array, int offset, int count) { }

	// RVA: 0x18A7A20 Offset: 0x18A7B21 VA: 0x18A7A20
	private int ReadInternal(byte[] dest, int offset, int count) { }

	// RVA: 0x18A7CB0 Offset: 0x18A7DB1 VA: 0x18A7CB0 Slot: 18
	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x18A8050 Offset: 0x18A8151 VA: 0x18A8050 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x18A8400 Offset: 0x18A8501 VA: 0x18A8400 Slot: 27
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x18A8620 Offset: 0x18A8721 VA: 0x18A8620
	private void WriteInternal(byte[] src, int offset, int count) { }

	// RVA: 0x18A8A00 Offset: 0x18A8B01 VA: 0x18A8A00 Slot: 21
	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x18A8EC0 Offset: 0x18A8FC1 VA: 0x18A8EC0 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x18A9220 Offset: 0x18A9321 VA: 0x18A9220 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x18A9470 Offset: 0x18A9571 VA: 0x18A9470 Slot: 17
	public override void Flush() { }

	// RVA: 0x18A9510 Offset: 0x18A9611 VA: 0x18A9510 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18A9590 Offset: 0x18A9691 VA: 0x18A9590 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18A98F0 Offset: 0x18A99F1 VA: 0x18A98F0 Slot: 20
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18A9A70 Offset: 0x18A9B71 VA: 0x18A9A70 Slot: 23
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18A7BE0 Offset: 0x18A7CE1 VA: 0x18A7BE0
	private int ReadSegment(byte[] dest, int dest_offset, int count) { }

	// RVA: 0x18A8980 Offset: 0x18A8A81 VA: 0x18A8980
	private int WriteSegment(byte[] src, int src_offset, int count) { }

	// RVA: 0x18A7170 Offset: 0x18A7271 VA: 0x18A7170
	private void FlushBuffer() { }

	// RVA: 0x18A6D70 Offset: 0x18A6E71 VA: 0x18A6D70
	private void FlushBufferIfDirty() { }

	// RVA: 0x18A7610 Offset: 0x18A7711 VA: 0x18A7610
	private void RefillBuffer() { }

	// RVA: 0x18A74D0 Offset: 0x18A75D1 VA: 0x18A74D0
	private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count) { }

	// RVA: 0x18A6750 Offset: 0x18A6851 VA: 0x18A6750
	private void InitBuffer(int size, bool isZeroSize) { }

	// RVA: 0x18A6550 Offset: 0x18A6651 VA: 0x18A6550
	private string GetSecureFileName(string filename) { }

	// RVA: 0x18A6380 Offset: 0x18A6481 VA: 0x18A6380
	private string GetSecureFileName(string filename, bool full) { }

	// RVA: 0x18A9DB0 Offset: 0x18A9EB1 VA: 0x18A9DB0
	private static void .cctor() { }
}

