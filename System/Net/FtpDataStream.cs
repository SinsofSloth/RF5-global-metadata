internal class FtpDataStream : Stream, IDisposable // TypeDefIndex: 1966
{
	// Fields
	private FtpWebRequest request; // 0x28
	private Stream networkStream; // 0x30
	private bool disposed; // 0x38
	private bool isRead; // 0x39
	private int totalRead; // 0x3C

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x17814F0 Offset: 0x17815F1 VA: 0x17814F0
	internal void .ctor(FtpWebRequest request, Stream stream, bool isRead) { }

	// RVA: 0x17815E0 Offset: 0x17816E1 VA: 0x17815E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x17815F0 Offset: 0x17816F1 VA: 0x17815F0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1781600 Offset: 0x1781701 VA: 0x1781600 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1781610 Offset: 0x1781711 VA: 0x1781610 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1781670 Offset: 0x1781771 VA: 0x1781670 Slot: 11
	public override long get_Position() { }

	// RVA: 0x17816D0 Offset: 0x17817D1 VA: 0x17816D0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1781730 Offset: 0x1781831 VA: 0x1781730 Slot: 15
	public override void Close() { }

	// RVA: 0x1781750 Offset: 0x1781851 VA: 0x1781750 Slot: 17
	public override void Flush() { }

	// RVA: 0x1781760 Offset: 0x1781861 VA: 0x1781760 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x17817C0 Offset: 0x17818C1 VA: 0x17817C0
	private int ReadInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1781B70 Offset: 0x1781C71 VA: 0x1781B70 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1781EF0 Offset: 0x1781FF1 VA: 0x1781EF0 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1782060 Offset: 0x1782161 VA: 0x1782060 Slot: 25
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782260 Offset: 0x1782361 VA: 0x1782260
	private void WriteInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782390 Offset: 0x1782491 VA: 0x1782390 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1782660 Offset: 0x1782761 VA: 0x1782660 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1782790 Offset: 0x1782891 VA: 0x1782790 Slot: 27
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782990 Offset: 0x1782A91 VA: 0x1782990 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1782A10 Offset: 0x1782B11 VA: 0x1782A10 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1782A90 Offset: 0x1782B91 VA: 0x1782A90 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1781D70 Offset: 0x1781E71 VA: 0x1781D70
	private void CheckDisposed() { }
}

internal class FtpDataStream : Stream, IDisposable // TypeDefIndex: 1966
{
	// Fields
	private FtpWebRequest request; // 0x28
	private Stream networkStream; // 0x30
	private bool disposed; // 0x38
	private bool isRead; // 0x39
	private int totalRead; // 0x3C

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x17814F0 Offset: 0x17815F1 VA: 0x17814F0
	internal void .ctor(FtpWebRequest request, Stream stream, bool isRead) { }

	// RVA: 0x17815E0 Offset: 0x17816E1 VA: 0x17815E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x17815F0 Offset: 0x17816F1 VA: 0x17815F0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1781600 Offset: 0x1781701 VA: 0x1781600 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1781610 Offset: 0x1781711 VA: 0x1781610 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1781670 Offset: 0x1781771 VA: 0x1781670 Slot: 11
	public override long get_Position() { }

	// RVA: 0x17816D0 Offset: 0x17817D1 VA: 0x17816D0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1781730 Offset: 0x1781831 VA: 0x1781730 Slot: 15
	public override void Close() { }

	// RVA: 0x1781750 Offset: 0x1781851 VA: 0x1781750 Slot: 17
	public override void Flush() { }

	// RVA: 0x1781760 Offset: 0x1781861 VA: 0x1781760 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x17817C0 Offset: 0x17818C1 VA: 0x17817C0
	private int ReadInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1781B70 Offset: 0x1781C71 VA: 0x1781B70 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1781EF0 Offset: 0x1781FF1 VA: 0x1781EF0 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1782060 Offset: 0x1782161 VA: 0x1782060 Slot: 25
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782260 Offset: 0x1782361 VA: 0x1782260
	private void WriteInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782390 Offset: 0x1782491 VA: 0x1782390 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1782660 Offset: 0x1782761 VA: 0x1782660 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1782790 Offset: 0x1782891 VA: 0x1782790 Slot: 27
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782990 Offset: 0x1782A91 VA: 0x1782990 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1782A10 Offset: 0x1782B11 VA: 0x1782A10 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1782A90 Offset: 0x1782B91 VA: 0x1782A90 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1781D70 Offset: 0x1781E71 VA: 0x1781D70
	private void CheckDisposed() { }
}

internal class FtpDataStream : Stream, IDisposable // TypeDefIndex: 1966
{
	// Fields
	private FtpWebRequest request; // 0x28
	private Stream networkStream; // 0x30
	private bool disposed; // 0x38
	private bool isRead; // 0x39
	private int totalRead; // 0x3C

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x17814F0 Offset: 0x17815F1 VA: 0x17814F0
	internal void .ctor(FtpWebRequest request, Stream stream, bool isRead) { }

	// RVA: 0x17815E0 Offset: 0x17816E1 VA: 0x17815E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x17815F0 Offset: 0x17816F1 VA: 0x17815F0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1781600 Offset: 0x1781701 VA: 0x1781600 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1781610 Offset: 0x1781711 VA: 0x1781610 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1781670 Offset: 0x1781771 VA: 0x1781670 Slot: 11
	public override long get_Position() { }

	// RVA: 0x17816D0 Offset: 0x17817D1 VA: 0x17816D0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1781730 Offset: 0x1781831 VA: 0x1781730 Slot: 15
	public override void Close() { }

	// RVA: 0x1781750 Offset: 0x1781851 VA: 0x1781750 Slot: 17
	public override void Flush() { }

	// RVA: 0x1781760 Offset: 0x1781861 VA: 0x1781760 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x17817C0 Offset: 0x17818C1 VA: 0x17817C0
	private int ReadInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1781B70 Offset: 0x1781C71 VA: 0x1781B70 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1781EF0 Offset: 0x1781FF1 VA: 0x1781EF0 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1782060 Offset: 0x1782161 VA: 0x1782060 Slot: 25
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782260 Offset: 0x1782361 VA: 0x1782260
	private void WriteInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782390 Offset: 0x1782491 VA: 0x1782390 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1782660 Offset: 0x1782761 VA: 0x1782660 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1782790 Offset: 0x1782891 VA: 0x1782790 Slot: 27
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782990 Offset: 0x1782A91 VA: 0x1782990 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1782A10 Offset: 0x1782B11 VA: 0x1782A10 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1782A90 Offset: 0x1782B91 VA: 0x1782A90 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1781D70 Offset: 0x1781E71 VA: 0x1781D70
	private void CheckDisposed() { }
}

internal class FtpDataStream : Stream, IDisposable // TypeDefIndex: 1966
{
	// Fields
	private FtpWebRequest request; // 0x28
	private Stream networkStream; // 0x30
	private bool disposed; // 0x38
	private bool isRead; // 0x39
	private int totalRead; // 0x3C

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x17814F0 Offset: 0x17815F1 VA: 0x17814F0
	internal void .ctor(FtpWebRequest request, Stream stream, bool isRead) { }

	// RVA: 0x17815E0 Offset: 0x17816E1 VA: 0x17815E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x17815F0 Offset: 0x17816F1 VA: 0x17815F0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1781600 Offset: 0x1781701 VA: 0x1781600 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1781610 Offset: 0x1781711 VA: 0x1781610 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1781670 Offset: 0x1781771 VA: 0x1781670 Slot: 11
	public override long get_Position() { }

	// RVA: 0x17816D0 Offset: 0x17817D1 VA: 0x17816D0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1781730 Offset: 0x1781831 VA: 0x1781730 Slot: 15
	public override void Close() { }

	// RVA: 0x1781750 Offset: 0x1781851 VA: 0x1781750 Slot: 17
	public override void Flush() { }

	// RVA: 0x1781760 Offset: 0x1781861 VA: 0x1781760 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x17817C0 Offset: 0x17818C1 VA: 0x17817C0
	private int ReadInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1781B70 Offset: 0x1781C71 VA: 0x1781B70 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1781EF0 Offset: 0x1781FF1 VA: 0x1781EF0 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1782060 Offset: 0x1782161 VA: 0x1782060 Slot: 25
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782260 Offset: 0x1782361 VA: 0x1782260
	private void WriteInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782390 Offset: 0x1782491 VA: 0x1782390 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1782660 Offset: 0x1782761 VA: 0x1782660 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1782790 Offset: 0x1782891 VA: 0x1782790 Slot: 27
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782990 Offset: 0x1782A91 VA: 0x1782990 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1782A10 Offset: 0x1782B11 VA: 0x1782A10 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1782A90 Offset: 0x1782B91 VA: 0x1782A90 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1781D70 Offset: 0x1781E71 VA: 0x1781D70
	private void CheckDisposed() { }
}

internal class FtpDataStream : Stream, IDisposable // TypeDefIndex: 1966
{
	// Fields
	private FtpWebRequest request; // 0x28
	private Stream networkStream; // 0x30
	private bool disposed; // 0x38
	private bool isRead; // 0x39
	private int totalRead; // 0x3C

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x17814F0 Offset: 0x17815F1 VA: 0x17814F0
	internal void .ctor(FtpWebRequest request, Stream stream, bool isRead) { }

	// RVA: 0x17815E0 Offset: 0x17816E1 VA: 0x17815E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x17815F0 Offset: 0x17816F1 VA: 0x17815F0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1781600 Offset: 0x1781701 VA: 0x1781600 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1781610 Offset: 0x1781711 VA: 0x1781610 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1781670 Offset: 0x1781771 VA: 0x1781670 Slot: 11
	public override long get_Position() { }

	// RVA: 0x17816D0 Offset: 0x17817D1 VA: 0x17816D0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1781730 Offset: 0x1781831 VA: 0x1781730 Slot: 15
	public override void Close() { }

	// RVA: 0x1781750 Offset: 0x1781851 VA: 0x1781750 Slot: 17
	public override void Flush() { }

	// RVA: 0x1781760 Offset: 0x1781861 VA: 0x1781760 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x17817C0 Offset: 0x17818C1 VA: 0x17817C0
	private int ReadInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1781B70 Offset: 0x1781C71 VA: 0x1781B70 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1781EF0 Offset: 0x1781FF1 VA: 0x1781EF0 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1782060 Offset: 0x1782161 VA: 0x1782060 Slot: 25
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782260 Offset: 0x1782361 VA: 0x1782260
	private void WriteInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782390 Offset: 0x1782491 VA: 0x1782390 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1782660 Offset: 0x1782761 VA: 0x1782660 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1782790 Offset: 0x1782891 VA: 0x1782790 Slot: 27
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782990 Offset: 0x1782A91 VA: 0x1782990 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1782A10 Offset: 0x1782B11 VA: 0x1782A10 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1782A90 Offset: 0x1782B91 VA: 0x1782A90 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1781D70 Offset: 0x1781E71 VA: 0x1781D70
	private void CheckDisposed() { }
}

internal class FtpDataStream : Stream, IDisposable // TypeDefIndex: 1966
{
	// Fields
	private FtpWebRequest request; // 0x28
	private Stream networkStream; // 0x30
	private bool disposed; // 0x38
	private bool isRead; // 0x39
	private int totalRead; // 0x3C

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x17814F0 Offset: 0x17815F1 VA: 0x17814F0
	internal void .ctor(FtpWebRequest request, Stream stream, bool isRead) { }

	// RVA: 0x17815E0 Offset: 0x17816E1 VA: 0x17815E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x17815F0 Offset: 0x17816F1 VA: 0x17815F0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1781600 Offset: 0x1781701 VA: 0x1781600 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1781610 Offset: 0x1781711 VA: 0x1781610 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1781670 Offset: 0x1781771 VA: 0x1781670 Slot: 11
	public override long get_Position() { }

	// RVA: 0x17816D0 Offset: 0x17817D1 VA: 0x17816D0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1781730 Offset: 0x1781831 VA: 0x1781730 Slot: 15
	public override void Close() { }

	// RVA: 0x1781750 Offset: 0x1781851 VA: 0x1781750 Slot: 17
	public override void Flush() { }

	// RVA: 0x1781760 Offset: 0x1781861 VA: 0x1781760 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x17817C0 Offset: 0x17818C1 VA: 0x17817C0
	private int ReadInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1781B70 Offset: 0x1781C71 VA: 0x1781B70 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1781EF0 Offset: 0x1781FF1 VA: 0x1781EF0 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1782060 Offset: 0x1782161 VA: 0x1782060 Slot: 25
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782260 Offset: 0x1782361 VA: 0x1782260
	private void WriteInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782390 Offset: 0x1782491 VA: 0x1782390 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1782660 Offset: 0x1782761 VA: 0x1782660 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1782790 Offset: 0x1782891 VA: 0x1782790 Slot: 27
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782990 Offset: 0x1782A91 VA: 0x1782990 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1782A10 Offset: 0x1782B11 VA: 0x1782A10 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1782A90 Offset: 0x1782B91 VA: 0x1782A90 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1781D70 Offset: 0x1781E71 VA: 0x1781D70
	private void CheckDisposed() { }
}

internal class FtpDataStream : Stream, IDisposable // TypeDefIndex: 1966
{
	// Fields
	private FtpWebRequest request; // 0x28
	private Stream networkStream; // 0x30
	private bool disposed; // 0x38
	private bool isRead; // 0x39
	private int totalRead; // 0x3C

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x17814F0 Offset: 0x17815F1 VA: 0x17814F0
	internal void .ctor(FtpWebRequest request, Stream stream, bool isRead) { }

	// RVA: 0x17815E0 Offset: 0x17816E1 VA: 0x17815E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x17815F0 Offset: 0x17816F1 VA: 0x17815F0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1781600 Offset: 0x1781701 VA: 0x1781600 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1781610 Offset: 0x1781711 VA: 0x1781610 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1781670 Offset: 0x1781771 VA: 0x1781670 Slot: 11
	public override long get_Position() { }

	// RVA: 0x17816D0 Offset: 0x17817D1 VA: 0x17816D0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1781730 Offset: 0x1781831 VA: 0x1781730 Slot: 15
	public override void Close() { }

	// RVA: 0x1781750 Offset: 0x1781851 VA: 0x1781750 Slot: 17
	public override void Flush() { }

	// RVA: 0x1781760 Offset: 0x1781861 VA: 0x1781760 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x17817C0 Offset: 0x17818C1 VA: 0x17817C0
	private int ReadInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1781B70 Offset: 0x1781C71 VA: 0x1781B70 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1781EF0 Offset: 0x1781FF1 VA: 0x1781EF0 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1782060 Offset: 0x1782161 VA: 0x1782060 Slot: 25
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782260 Offset: 0x1782361 VA: 0x1782260
	private void WriteInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782390 Offset: 0x1782491 VA: 0x1782390 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1782660 Offset: 0x1782761 VA: 0x1782660 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1782790 Offset: 0x1782891 VA: 0x1782790 Slot: 27
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1782990 Offset: 0x1782A91 VA: 0x1782990 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1782A10 Offset: 0x1782B11 VA: 0x1782A10 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1782A90 Offset: 0x1782B91 VA: 0x1782A90 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1781D70 Offset: 0x1781E71 VA: 0x1781D70
	private void CheckDisposed() { }
}

