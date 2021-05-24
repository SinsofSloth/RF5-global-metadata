public class GZipStream : Stream // TypeDefIndex: 1864
{
	// Fields
	private DeflateStream _deflateStream; // 0x28

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x28EE480 Offset: 0x28EE581 VA: 0x28EE480
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x28EE490 Offset: 0x28EE591 VA: 0x28EE490
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x28EE550 Offset: 0x28EE651 VA: 0x28EE550 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x28EE570 Offset: 0x28EE671 VA: 0x28EE570 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x28EE590 Offset: 0x28EE691 VA: 0x28EE590 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x28EE5B0 Offset: 0x28EE6B1 VA: 0x28EE5B0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x28EE620 Offset: 0x28EE721 VA: 0x28EE620 Slot: 11
	public override long get_Position() { }

	// RVA: 0x28EE690 Offset: 0x28EE791 VA: 0x28EE690 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x28EE700 Offset: 0x28EE801 VA: 0x28EE700 Slot: 17
	public override void Flush() { }

	// RVA: 0x28EE750 Offset: 0x28EE851 VA: 0x28EE750 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x28EE7C0 Offset: 0x28EE8C1 VA: 0x28EE7C0 Slot: 26
	public override int ReadByte() { }

	// RVA: 0x28EE7F0 Offset: 0x28EE8F1 VA: 0x28EE7F0 Slot: 18
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x28EE8C0 Offset: 0x28EE9C1 VA: 0x28EE8C0 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x28EE910 Offset: 0x28EEA11 VA: 0x28EE910 Slot: 25
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x28EE940 Offset: 0x28EEA41 VA: 0x28EE940 Slot: 21
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x28EEA10 Offset: 0x28EEB11 VA: 0x28EEA10 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x28EEA20 Offset: 0x28EEB21 VA: 0x28EEA20 Slot: 27
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x28EEA50 Offset: 0x28EEB51 VA: 0x28EEA50 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x28EEB00 Offset: 0x28EEC01 VA: 0x28EEB00 Slot: 20
	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x28EEB30 Offset: 0x28EEC31 VA: 0x28EEB30 Slot: 23
	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x28EE730 Offset: 0x28EE831 VA: 0x28EE730
	private void CheckDeflateStream() { }

	// RVA: 0x28EEB60 Offset: 0x28EEC61 VA: 0x28EEB60
	private static void ThrowStreamClosedException() { }
}

