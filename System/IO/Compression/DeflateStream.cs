public class DeflateStream : Stream // TypeDefIndex: 1865
{
	// Fields
	private Stream base_stream; // 0x28
	private CompressionMode mode; // 0x30
	private bool leaveOpen; // 0x34
	private bool disposed; // 0x35
	private DeflateStreamNative native; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x28EB620 Offset: 0x28EB721 VA: 0x28EB620
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x28EB7B0 Offset: 0x28EB8B1 VA: 0x28EB7B0
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x28EB630 Offset: 0x28EB731 VA: 0x28EB630
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x28EB9C0 Offset: 0x28EBAC1 VA: 0x28EB9C0 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x28EBB40 Offset: 0x28EBC41 VA: 0x28EBB40
	private int ReadInternal(byte[] array, int offset, int count) { }

	// RVA: 0x28EBC60 Offset: 0x28EBD61 VA: 0x28EBC60 Slot: 25
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x28EBE70 Offset: 0x28EBF71 VA: 0x28EBE70
	private void WriteInternal(byte[] array, int offset, int count) { }

	// RVA: 0x28EBF90 Offset: 0x28EC091 VA: 0x28EBF90 Slot: 27
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x28EC1A0 Offset: 0x28EC2A1 VA: 0x28EC1A0 Slot: 17
	public override void Flush() { }

	// RVA: 0x28EC330 Offset: 0x28EC431 VA: 0x28EC330 Slot: 18
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x28EC6A0 Offset: 0x28EC7A1 VA: 0x28EC6A0 Slot: 21
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x28ECA10 Offset: 0x28ECB11 VA: 0x28ECA10 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x28ECB80 Offset: 0x28ECC81 VA: 0x28ECB80 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x28ECCB0 Offset: 0x28ECDB1 VA: 0x28ECCB0 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x28ECD10 Offset: 0x28ECE11 VA: 0x28ECD10 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x28ECD50 Offset: 0x28ECE51 VA: 0x28ECD50 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x28ECD60 Offset: 0x28ECE61 VA: 0x28ECD60 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x28ECDA0 Offset: 0x28ECEA1 VA: 0x28ECDA0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x28ECE00 Offset: 0x28ECF01 VA: 0x28ECE00 Slot: 11
	public override long get_Position() { }

	// RVA: 0x28ECE60 Offset: 0x28ECF61 VA: 0x28ECE60 Slot: 12
	public override void set_Position(long value) { }
}

