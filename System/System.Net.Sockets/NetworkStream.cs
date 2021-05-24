public class NetworkStream : Stream // TypeDefIndex: 2012
{
	// Fields
	private Socket m_StreamSocket; // 0x28
	private bool m_Readable; // 0x30
	private bool m_Writeable; // 0x31
	private bool m_OwnsSocket; // 0x32
	private int m_CloseTimeout; // 0x34
	private bool m_CleanedUp; // 0x38
	private int m_CurrentReadTimeout; // 0x3C
	private int m_CurrentWriteTimeout; // 0x40

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x16D1450 Offset: 0x16D1551 VA: 0x16D1450
	public void .ctor(Socket socket) { }

	// RVA: 0x16D1660 Offset: 0x16D1761 VA: 0x16D1660
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x16D1750 Offset: 0x16D1851 VA: 0x16D1750 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x16D1760 Offset: 0x16D1861 VA: 0x16D1760 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x16D1770 Offset: 0x16D1871 VA: 0x16D1770 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16D1780 Offset: 0x16D1881 VA: 0x16D1780 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x16D1990 Offset: 0x16D1A91 VA: 0x16D1990 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x16D1A20 Offset: 0x16D1B21 VA: 0x16D1A20 Slot: 10
	public override long get_Length() { }

	// RVA: 0x16D1AA0 Offset: 0x16D1BA1 VA: 0x16D1AA0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x16D1B20 Offset: 0x16D1C21 VA: 0x16D1B20 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x16D1BA0 Offset: 0x16D1CA1 VA: 0x16D1BA0 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x16D1530 Offset: 0x16D1631 VA: 0x16D1530
	internal void InitNetworkStream(Socket socket, FileAccess Access) { }

	// RVA: 0x16D1C20 Offset: 0x16D1D21 VA: 0x16D1C20 Slot: 25
	public override int Read([In] [Out] byte[] buffer, int offset, int size) { }

	// RVA: 0x16D2190 Offset: 0x16D2291 VA: 0x16D2190 Slot: 27
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x16D2700 Offset: 0x16D2801 VA: 0x16D2700 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16D2970 Offset: 0x16D2A71 VA: 0x16D2970 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x16D29F0 Offset: 0x16D2AF1 VA: 0x16D29F0 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x16D2FA0 Offset: 0x16D30A1 VA: 0x16D2FA0 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x16D3410 Offset: 0x16D3511 VA: 0x16D3410 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x16D39C0 Offset: 0x16D3AC1 VA: 0x16D39C0 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x16D3E30 Offset: 0x16D3F31 VA: 0x16D3E30 Slot: 17
	public override void Flush() { }
}

