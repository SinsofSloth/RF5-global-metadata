[Serializable]
private sealed class Stream.NullStream : Stream // TypeDefIndex: 659
{
	// Fields
	private static Task<int> s_nullReadTask; // 0x0

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x18B22E0 Offset: 0x18B23E1 VA: 0x18B22E0
	internal void .ctor() { }

	// RVA: 0x18B28A0 Offset: 0x18B29A1 VA: 0x18B28A0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x18B28B0 Offset: 0x18B29B1 VA: 0x18B28B0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x18B28C0 Offset: 0x18B29C1 VA: 0x18B28C0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x18B28D0 Offset: 0x18B29D1 VA: 0x18B28D0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x18B28E0 Offset: 0x18B29E1 VA: 0x18B28E0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x18B28F0 Offset: 0x18B29F1 VA: 0x18B28F0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x18B2900 Offset: 0x18B2A01 VA: 0x18B2900 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B2910 Offset: 0x18B2A11 VA: 0x18B2910 Slot: 17
	public override void Flush() { }

	// RVA: 0x18B2920 Offset: 0x18B2A21 VA: 0x18B2920 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B2990 Offset: 0x18B2A91 VA: 0x18B2990 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x18B2A50 Offset: 0x18B2B51 VA: 0x18B2A50 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B2AC0 Offset: 0x18B2BC1 VA: 0x18B2AC0 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x18B2B80 Offset: 0x18B2C81 VA: 0x18B2B80 Slot: 25
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8770 Offset: 0xB8871 VA: 0xB8770
	// RVA: 0x18B2B90 Offset: 0x18B2C91 VA: 0x18B2B90 Slot: 20
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B2C70 Offset: 0x18B2D71 VA: 0x18B2C70 Slot: 26
	public override int ReadByte() { }

	// RVA: 0x18B2C80 Offset: 0x18B2D81 VA: 0x18B2C80 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8790 Offset: 0xB8891 VA: 0xB8790
	// RVA: 0x18B2C90 Offset: 0x18B2D91 VA: 0x18B2C90 Slot: 23
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B2D40 Offset: 0x18B2E41 VA: 0x18B2D40 Slot: 28
	public override void WriteByte(byte value) { }

	// RVA: 0x18B2D50 Offset: 0x18B2E51 VA: 0x18B2D50 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }
}

