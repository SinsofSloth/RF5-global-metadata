internal class WebConnectionStream : Stream // TypeDefIndex: 2002
{
	// Fields
	private static byte[] crlf; // 0x0
	private bool isRead; // 0x28
	private WebConnection cnc; // 0x30
	private HttpWebRequest request; // 0x38
	private byte[] readBuffer; // 0x40
	private int readBufferOffset; // 0x48
	private int readBufferSize; // 0x4C
	private int stream_length; // 0x50
	private long contentLength; // 0x58
	private long totalRead; // 0x60
	internal long totalWritten; // 0x68
	private bool nextReadCalled; // 0x70
	private int pendingReads; // 0x74
	private int pendingWrites; // 0x78
	private ManualResetEvent pending; // 0x80
	private bool allowBuffering; // 0x88
	private bool sendChunked; // 0x89
	private MemoryStream writeBuffer; // 0x90
	private bool requestWritten; // 0x98
	private byte[] headers; // 0xA0
	private bool disposed; // 0xA8
	private bool headersSent; // 0xA9
	private object locker; // 0xB0
	private bool initRead; // 0xB8
	private bool read_eof; // 0xB9
	private bool complete_request_written; // 0xBA
	private int read_timeout; // 0xBC
	private int write_timeout; // 0xC0
	private AsyncCallback cb_wrapper; // 0xC8
	internal bool IgnoreIOErrors; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0xBCF80 Offset: 0xBD081 VA: 0xBCF80
	private bool <GetResponseOnClose>k__BackingField; // 0xD1

	// Properties
	internal WebConnection Connection { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	internal bool CompleteRequestWritten { get; }
	internal bool SendChunked { set; }
	internal byte[] ReadBuffer { set; }
	internal int ReadBufferOffset { set; }
	internal int ReadBufferSize { set; }
	internal byte[] WriteBuffer { get; }
	internal int WriteBufferLength { get; }
	internal bool RequestWritten { get; }
	internal bool GetResponseOnClose { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1704360 Offset: 0x1704461 VA: 0x1704360
	public void .ctor(WebConnection cnc, WebConnectionData data) { }

	// RVA: 0x1704CC0 Offset: 0x1704DC1 VA: 0x1704CC0
	public void .ctor(WebConnection cnc, HttpWebRequest request) { }

	// RVA: 0x1704E60 Offset: 0x1704F61 VA: 0x1704E60
	private bool CheckAuthHeader(string headerName) { }

	// RVA: 0x17046B0 Offset: 0x17047B1 VA: 0x17046B0
	private bool IsNtlmAuth() { }

	// RVA: 0x1704F00 Offset: 0x1705001 VA: 0x1704F00
	internal void CheckResponseInBuffer() { }

	// RVA: 0x1704F60 Offset: 0x1705061 VA: 0x1704F60
	internal WebConnection get_Connection() { }

	// RVA: 0x1704F70 Offset: 0x1705071 VA: 0x1704F70 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x1704F80 Offset: 0x1705081 VA: 0x1704F80 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x1704F90 Offset: 0x1705091 VA: 0x1704F90
	internal bool get_CompleteRequestWritten() { }

	// RVA: 0x1704FA0 Offset: 0x17050A1 VA: 0x1704FA0
	internal void set_SendChunked(bool value) { }

	// RVA: 0x1704FB0 Offset: 0x17050B1 VA: 0x1704FB0
	internal void set_ReadBuffer(byte[] value) { }

	// RVA: 0x1704FC0 Offset: 0x17050C1 VA: 0x1704FC0
	internal void set_ReadBufferOffset(int value) { }

	// RVA: 0x1704FD0 Offset: 0x17050D1 VA: 0x1704FD0
	internal void set_ReadBufferSize(int value) { }

	// RVA: 0x1704FE0 Offset: 0x17050E1 VA: 0x1704FE0
	internal byte[] get_WriteBuffer() { }

	// RVA: 0x1705010 Offset: 0x1705111 VA: 0x1705010
	internal int get_WriteBufferLength() { }

	// RVA: 0x1705040 Offset: 0x1705141 VA: 0x1705040
	internal void ForceCompletion() { }

	// RVA: 0x1705090 Offset: 0x1705191 VA: 0x1705090
	internal void CheckComplete() { }

	// RVA: 0x1704800 Offset: 0x1704901 VA: 0x1704800
	internal void ReadAll() { }

	// RVA: 0x17050E0 Offset: 0x17051E1 VA: 0x17050E0
	private void WriteCallbackWrapper(IAsyncResult r) { }

	// RVA: 0x1705360 Offset: 0x1705461 VA: 0x1705360
	private void ReadCallbackWrapper(IAsyncResult r) { }

	// RVA: 0x17055A0 Offset: 0x17056A1 VA: 0x17055A0 Slot: 25
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1705720 Offset: 0x1705821 VA: 0x1705720 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1705A70 Offset: 0x1705B71 VA: 0x1705A70 Slot: 19
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x1705E10 Offset: 0x1705F11 VA: 0x1705E10
	private void WriteAsyncCB(IAsyncResult r) { }

	// RVA: 0x1706140 Offset: 0x1706241 VA: 0x1706140 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1706840 Offset: 0x1706941 VA: 0x1706840
	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	// RVA: 0x1706920 Offset: 0x1706A21 VA: 0x1706920 Slot: 22
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x1706B30 Offset: 0x1706C31 VA: 0x1706B30 Slot: 27
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1706CC0 Offset: 0x1706DC1 VA: 0x1706CC0 Slot: 17
	public override void Flush() { }

	// RVA: 0x1706CD0 Offset: 0x1706DD1 VA: 0x1706CD0
	internal void SetHeadersAsync(bool setInternalLength, SimpleAsyncCallback callback) { }

	// RVA: 0x1706DB0 Offset: 0x1706EB1 VA: 0x1706DB0
	private bool SetHeadersAsync(SimpleAsyncResult result, bool setInternalLength) { }

	// RVA: 0x17070D0 Offset: 0x17071D1 VA: 0x17070D0
	internal bool get_RequestWritten() { }

	// RVA: 0x17070E0 Offset: 0x17071E1 VA: 0x17070E0
	internal bool WriteRequestAsync(SimpleAsyncResult result) { }

	// RVA: 0x1707380 Offset: 0x1707481 VA: 0x1707380
	internal void InternalClose() { }

	[CompilerGeneratedAttribute] // RVA: 0xBDB10 Offset: 0xBDC11 VA: 0xBDB10
	// RVA: 0x1707390 Offset: 0x1707491 VA: 0x1707390
	internal bool get_GetResponseOnClose() { }

	// RVA: 0x17073A0 Offset: 0x17074A1 VA: 0x17073A0 Slot: 15
	public override void Close() { }

	// RVA: 0x1706130 Offset: 0x1706231 VA: 0x1706130
	internal void KillBuffer() { }

	// RVA: 0x17077A0 Offset: 0x17078A1 VA: 0x17077A0 Slot: 24
	public override long Seek(long a, SeekOrigin b) { }

	// RVA: 0x1707800 Offset: 0x1707901 VA: 0x1707800 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1707810 Offset: 0x1707911 VA: 0x1707810 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1707830 Offset: 0x1707931 VA: 0x1707830 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1707850 Offset: 0x1707951 VA: 0x1707850 Slot: 10
	public override long get_Length() { }

	// RVA: 0x17078D0 Offset: 0x17079D1 VA: 0x17078D0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1707930 Offset: 0x1707A31 VA: 0x1707930 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1707990 Offset: 0x1707A91 VA: 0x1707990
	private static void .cctor() { }
}

