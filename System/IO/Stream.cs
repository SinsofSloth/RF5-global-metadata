[ComVisibleAttribute] // RVA: 0xAE9E0 Offset: 0xAEAE1 VA: 0xAE9E0
[Serializable]
public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 656
{
	// Fields
	public static readonly Stream Null; // 0x0
	private Stream.ReadWriteTask _activeReadWriteTask; // 0x18
	private SemaphoreSlim _asyncActiveSemaphore; // 0x20

	// Properties
	public abstract bool CanRead { get; }
	public abstract bool CanSeek { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA190 Offset: 0xBA291 VA: 0xBA190
	public virtual int ReadTimeout { get; }
	[ComVisibleAttribute] // RVA: 0xBA1B0 Offset: 0xBA2B1 VA: 0xBA1B0
	public virtual int WriteTimeout { get; }

	// Methods

	// RVA: 0x18B0AC0 Offset: 0x18B0BC1 VA: 0x18B0AC0
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_CanRead() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanSeek() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_CanWrite() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_Length() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Position() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_Position(long value) { }

	// RVA: 0x18B0BD0 Offset: 0x18B0CD1 VA: 0x18B0BD0 Slot: 13
	public virtual int get_ReadTimeout() { }

	// RVA: 0x18B0C50 Offset: 0x18B0D51 VA: 0x18B0C50 Slot: 14
	public virtual int get_WriteTimeout() { }

	// RVA: 0x18B0CD0 Offset: 0x18B0DD1 VA: 0x18B0CD0 Slot: 15
	public virtual void Close() { }

	// RVA: 0x18B0D50 Offset: 0x18B0E51 VA: 0x18B0D50 Slot: 6
	public void Dispose() { }

	// RVA: 0x18AB0A0 Offset: 0x18AB1A1 VA: 0x18AB0A0 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Flush() { }

	// RVA: 0x18A7F70 Offset: 0x18A8071 VA: 0x18A7F70 Slot: 18
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B0D60 Offset: 0x18B0E61 VA: 0x18B0D60
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x18A81B0 Offset: 0x18A82B1 VA: 0x18A81B0 Slot: 19
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0xB8710 Offset: 0xB8811 VA: 0xB8710
	// RVA: 0x18A99B0 Offset: 0x18A9AB1 VA: 0x18A99B0 Slot: 20
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B15F0 Offset: 0x18B16F1 VA: 0x18B15F0
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x18A8CF0 Offset: 0x18A8DF1 VA: 0x18A8CF0 Slot: 21
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B17F0 Offset: 0x18B18F1 VA: 0x18B17F0
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x18B12D0 Offset: 0x18B13D1 VA: 0x18B12D0
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x18B14D0 Offset: 0x18B15D1 VA: 0x18B14D0
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x18A9010 Offset: 0x18A9111 VA: 0x18A9010 Slot: 22
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0xB8730 Offset: 0xB8831 VA: 0xB8730
	// RVA: 0x18B1BD0 Offset: 0x18B1CD1 VA: 0x18B1BD0
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8750 Offset: 0xB8851 VA: 0xB8750
	// RVA: 0x18A9B30 Offset: 0x18A9C31 VA: 0x18A9B30 Slot: 23
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B1C80 Offset: 0x18B1D81 VA: 0x18B1C80
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract long Seek(long offset, SeekOrigin origin) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x18B1E80 Offset: 0x18B1F81 VA: 0x18B1E80 Slot: 26
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x18B1F30 Offset: 0x18B2031 VA: 0x18B1F30 Slot: 28
	public virtual void WriteByte(byte value) { }

	// RVA: 0x18B0F80 Offset: 0x18B1081 VA: 0x18B0F80
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B15E0 Offset: 0x18B16E1 VA: 0x18B15E0
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x18B1A10 Offset: 0x18B1B11 VA: 0x18B1A10
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B1BC0 Offset: 0x18B1CC1 VA: 0x18B1BC0
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x18A4D00 Offset: 0x18A4E01 VA: 0x18A4D00
	protected void .ctor() { }

	// RVA: 0x18B2230 Offset: 0x18B2331 VA: 0x18B2230
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAE9E0 Offset: 0xAEAE1 VA: 0xAE9E0
[Serializable]
public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 656
{
	// Fields
	public static readonly Stream Null; // 0x0
	private Stream.ReadWriteTask _activeReadWriteTask; // 0x18
	private SemaphoreSlim _asyncActiveSemaphore; // 0x20

	// Properties
	public abstract bool CanRead { get; }
	public abstract bool CanSeek { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA190 Offset: 0xBA291 VA: 0xBA190
	public virtual int ReadTimeout { get; }
	[ComVisibleAttribute] // RVA: 0xBA1B0 Offset: 0xBA2B1 VA: 0xBA1B0
	public virtual int WriteTimeout { get; }

	// Methods

	// RVA: 0x18B0AC0 Offset: 0x18B0BC1 VA: 0x18B0AC0
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_CanRead() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanSeek() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_CanWrite() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_Length() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Position() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_Position(long value) { }

	// RVA: 0x18B0BD0 Offset: 0x18B0CD1 VA: 0x18B0BD0 Slot: 13
	public virtual int get_ReadTimeout() { }

	// RVA: 0x18B0C50 Offset: 0x18B0D51 VA: 0x18B0C50 Slot: 14
	public virtual int get_WriteTimeout() { }

	// RVA: 0x18B0CD0 Offset: 0x18B0DD1 VA: 0x18B0CD0 Slot: 15
	public virtual void Close() { }

	// RVA: 0x18B0D50 Offset: 0x18B0E51 VA: 0x18B0D50 Slot: 6
	public void Dispose() { }

	// RVA: 0x18AB0A0 Offset: 0x18AB1A1 VA: 0x18AB0A0 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Flush() { }

	// RVA: 0x18A7F70 Offset: 0x18A8071 VA: 0x18A7F70 Slot: 18
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B0D60 Offset: 0x18B0E61 VA: 0x18B0D60
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x18A81B0 Offset: 0x18A82B1 VA: 0x18A81B0 Slot: 19
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0xB8710 Offset: 0xB8811 VA: 0xB8710
	// RVA: 0x18A99B0 Offset: 0x18A9AB1 VA: 0x18A99B0 Slot: 20
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B15F0 Offset: 0x18B16F1 VA: 0x18B15F0
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x18A8CF0 Offset: 0x18A8DF1 VA: 0x18A8CF0 Slot: 21
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B17F0 Offset: 0x18B18F1 VA: 0x18B17F0
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x18B12D0 Offset: 0x18B13D1 VA: 0x18B12D0
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x18B14D0 Offset: 0x18B15D1 VA: 0x18B14D0
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x18A9010 Offset: 0x18A9111 VA: 0x18A9010 Slot: 22
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0xB8730 Offset: 0xB8831 VA: 0xB8730
	// RVA: 0x18B1BD0 Offset: 0x18B1CD1 VA: 0x18B1BD0
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8750 Offset: 0xB8851 VA: 0xB8750
	// RVA: 0x18A9B30 Offset: 0x18A9C31 VA: 0x18A9B30 Slot: 23
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B1C80 Offset: 0x18B1D81 VA: 0x18B1C80
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract long Seek(long offset, SeekOrigin origin) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x18B1E80 Offset: 0x18B1F81 VA: 0x18B1E80 Slot: 26
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x18B1F30 Offset: 0x18B2031 VA: 0x18B1F30 Slot: 28
	public virtual void WriteByte(byte value) { }

	// RVA: 0x18B0F80 Offset: 0x18B1081 VA: 0x18B0F80
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B15E0 Offset: 0x18B16E1 VA: 0x18B15E0
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x18B1A10 Offset: 0x18B1B11 VA: 0x18B1A10
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B1BC0 Offset: 0x18B1CC1 VA: 0x18B1BC0
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x18A4D00 Offset: 0x18A4E01 VA: 0x18A4D00
	protected void .ctor() { }

	// RVA: 0x18B2230 Offset: 0x18B2331 VA: 0x18B2230
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAE9E0 Offset: 0xAEAE1 VA: 0xAE9E0
[Serializable]
public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 656
{
	// Fields
	public static readonly Stream Null; // 0x0
	private Stream.ReadWriteTask _activeReadWriteTask; // 0x18
	private SemaphoreSlim _asyncActiveSemaphore; // 0x20

	// Properties
	public abstract bool CanRead { get; }
	public abstract bool CanSeek { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA190 Offset: 0xBA291 VA: 0xBA190
	public virtual int ReadTimeout { get; }
	[ComVisibleAttribute] // RVA: 0xBA1B0 Offset: 0xBA2B1 VA: 0xBA1B0
	public virtual int WriteTimeout { get; }

	// Methods

	// RVA: 0x18B0AC0 Offset: 0x18B0BC1 VA: 0x18B0AC0
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_CanRead() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanSeek() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_CanWrite() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_Length() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Position() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_Position(long value) { }

	// RVA: 0x18B0BD0 Offset: 0x18B0CD1 VA: 0x18B0BD0 Slot: 13
	public virtual int get_ReadTimeout() { }

	// RVA: 0x18B0C50 Offset: 0x18B0D51 VA: 0x18B0C50 Slot: 14
	public virtual int get_WriteTimeout() { }

	// RVA: 0x18B0CD0 Offset: 0x18B0DD1 VA: 0x18B0CD0 Slot: 15
	public virtual void Close() { }

	// RVA: 0x18B0D50 Offset: 0x18B0E51 VA: 0x18B0D50 Slot: 6
	public void Dispose() { }

	// RVA: 0x18AB0A0 Offset: 0x18AB1A1 VA: 0x18AB0A0 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Flush() { }

	// RVA: 0x18A7F70 Offset: 0x18A8071 VA: 0x18A7F70 Slot: 18
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B0D60 Offset: 0x18B0E61 VA: 0x18B0D60
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x18A81B0 Offset: 0x18A82B1 VA: 0x18A81B0 Slot: 19
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0xB8710 Offset: 0xB8811 VA: 0xB8710
	// RVA: 0x18A99B0 Offset: 0x18A9AB1 VA: 0x18A99B0 Slot: 20
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B15F0 Offset: 0x18B16F1 VA: 0x18B15F0
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x18A8CF0 Offset: 0x18A8DF1 VA: 0x18A8CF0 Slot: 21
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B17F0 Offset: 0x18B18F1 VA: 0x18B17F0
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x18B12D0 Offset: 0x18B13D1 VA: 0x18B12D0
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x18B14D0 Offset: 0x18B15D1 VA: 0x18B14D0
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x18A9010 Offset: 0x18A9111 VA: 0x18A9010 Slot: 22
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0xB8730 Offset: 0xB8831 VA: 0xB8730
	// RVA: 0x18B1BD0 Offset: 0x18B1CD1 VA: 0x18B1BD0
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8750 Offset: 0xB8851 VA: 0xB8750
	// RVA: 0x18A9B30 Offset: 0x18A9C31 VA: 0x18A9B30 Slot: 23
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B1C80 Offset: 0x18B1D81 VA: 0x18B1C80
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract long Seek(long offset, SeekOrigin origin) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x18B1E80 Offset: 0x18B1F81 VA: 0x18B1E80 Slot: 26
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x18B1F30 Offset: 0x18B2031 VA: 0x18B1F30 Slot: 28
	public virtual void WriteByte(byte value) { }

	// RVA: 0x18B0F80 Offset: 0x18B1081 VA: 0x18B0F80
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B15E0 Offset: 0x18B16E1 VA: 0x18B15E0
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x18B1A10 Offset: 0x18B1B11 VA: 0x18B1A10
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B1BC0 Offset: 0x18B1CC1 VA: 0x18B1BC0
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x18A4D00 Offset: 0x18A4E01 VA: 0x18A4D00
	protected void .ctor() { }

	// RVA: 0x18B2230 Offset: 0x18B2331 VA: 0x18B2230
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAE9E0 Offset: 0xAEAE1 VA: 0xAE9E0
[Serializable]
public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 656
{
	// Fields
	public static readonly Stream Null; // 0x0
	private Stream.ReadWriteTask _activeReadWriteTask; // 0x18
	private SemaphoreSlim _asyncActiveSemaphore; // 0x20

	// Properties
	public abstract bool CanRead { get; }
	public abstract bool CanSeek { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA190 Offset: 0xBA291 VA: 0xBA190
	public virtual int ReadTimeout { get; }
	[ComVisibleAttribute] // RVA: 0xBA1B0 Offset: 0xBA2B1 VA: 0xBA1B0
	public virtual int WriteTimeout { get; }

	// Methods

	// RVA: 0x18B0AC0 Offset: 0x18B0BC1 VA: 0x18B0AC0
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_CanRead() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanSeek() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_CanWrite() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_Length() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Position() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_Position(long value) { }

	// RVA: 0x18B0BD0 Offset: 0x18B0CD1 VA: 0x18B0BD0 Slot: 13
	public virtual int get_ReadTimeout() { }

	// RVA: 0x18B0C50 Offset: 0x18B0D51 VA: 0x18B0C50 Slot: 14
	public virtual int get_WriteTimeout() { }

	// RVA: 0x18B0CD0 Offset: 0x18B0DD1 VA: 0x18B0CD0 Slot: 15
	public virtual void Close() { }

	// RVA: 0x18B0D50 Offset: 0x18B0E51 VA: 0x18B0D50 Slot: 6
	public void Dispose() { }

	// RVA: 0x18AB0A0 Offset: 0x18AB1A1 VA: 0x18AB0A0 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Flush() { }

	// RVA: 0x18A7F70 Offset: 0x18A8071 VA: 0x18A7F70 Slot: 18
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B0D60 Offset: 0x18B0E61 VA: 0x18B0D60
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x18A81B0 Offset: 0x18A82B1 VA: 0x18A81B0 Slot: 19
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0xB8710 Offset: 0xB8811 VA: 0xB8710
	// RVA: 0x18A99B0 Offset: 0x18A9AB1 VA: 0x18A99B0 Slot: 20
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B15F0 Offset: 0x18B16F1 VA: 0x18B15F0
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x18A8CF0 Offset: 0x18A8DF1 VA: 0x18A8CF0 Slot: 21
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B17F0 Offset: 0x18B18F1 VA: 0x18B17F0
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x18B12D0 Offset: 0x18B13D1 VA: 0x18B12D0
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x18B14D0 Offset: 0x18B15D1 VA: 0x18B14D0
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x18A9010 Offset: 0x18A9111 VA: 0x18A9010 Slot: 22
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0xB8730 Offset: 0xB8831 VA: 0xB8730
	// RVA: 0x18B1BD0 Offset: 0x18B1CD1 VA: 0x18B1BD0
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8750 Offset: 0xB8851 VA: 0xB8750
	// RVA: 0x18A9B30 Offset: 0x18A9C31 VA: 0x18A9B30 Slot: 23
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B1C80 Offset: 0x18B1D81 VA: 0x18B1C80
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract long Seek(long offset, SeekOrigin origin) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x18B1E80 Offset: 0x18B1F81 VA: 0x18B1E80 Slot: 26
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x18B1F30 Offset: 0x18B2031 VA: 0x18B1F30 Slot: 28
	public virtual void WriteByte(byte value) { }

	// RVA: 0x18B0F80 Offset: 0x18B1081 VA: 0x18B0F80
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B15E0 Offset: 0x18B16E1 VA: 0x18B15E0
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x18B1A10 Offset: 0x18B1B11 VA: 0x18B1A10
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B1BC0 Offset: 0x18B1CC1 VA: 0x18B1BC0
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x18A4D00 Offset: 0x18A4E01 VA: 0x18A4D00
	protected void .ctor() { }

	// RVA: 0x18B2230 Offset: 0x18B2331 VA: 0x18B2230
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAE9E0 Offset: 0xAEAE1 VA: 0xAE9E0
[Serializable]
public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 656
{
	// Fields
	public static readonly Stream Null; // 0x0
	private Stream.ReadWriteTask _activeReadWriteTask; // 0x18
	private SemaphoreSlim _asyncActiveSemaphore; // 0x20

	// Properties
	public abstract bool CanRead { get; }
	public abstract bool CanSeek { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA190 Offset: 0xBA291 VA: 0xBA190
	public virtual int ReadTimeout { get; }
	[ComVisibleAttribute] // RVA: 0xBA1B0 Offset: 0xBA2B1 VA: 0xBA1B0
	public virtual int WriteTimeout { get; }

	// Methods

	// RVA: 0x18B0AC0 Offset: 0x18B0BC1 VA: 0x18B0AC0
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_CanRead() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanSeek() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_CanWrite() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_Length() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Position() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_Position(long value) { }

	// RVA: 0x18B0BD0 Offset: 0x18B0CD1 VA: 0x18B0BD0 Slot: 13
	public virtual int get_ReadTimeout() { }

	// RVA: 0x18B0C50 Offset: 0x18B0D51 VA: 0x18B0C50 Slot: 14
	public virtual int get_WriteTimeout() { }

	// RVA: 0x18B0CD0 Offset: 0x18B0DD1 VA: 0x18B0CD0 Slot: 15
	public virtual void Close() { }

	// RVA: 0x18B0D50 Offset: 0x18B0E51 VA: 0x18B0D50 Slot: 6
	public void Dispose() { }

	// RVA: 0x18AB0A0 Offset: 0x18AB1A1 VA: 0x18AB0A0 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Flush() { }

	// RVA: 0x18A7F70 Offset: 0x18A8071 VA: 0x18A7F70 Slot: 18
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B0D60 Offset: 0x18B0E61 VA: 0x18B0D60
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x18A81B0 Offset: 0x18A82B1 VA: 0x18A81B0 Slot: 19
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0xB8710 Offset: 0xB8811 VA: 0xB8710
	// RVA: 0x18A99B0 Offset: 0x18A9AB1 VA: 0x18A99B0 Slot: 20
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B15F0 Offset: 0x18B16F1 VA: 0x18B15F0
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x18A8CF0 Offset: 0x18A8DF1 VA: 0x18A8CF0 Slot: 21
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B17F0 Offset: 0x18B18F1 VA: 0x18B17F0
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x18B12D0 Offset: 0x18B13D1 VA: 0x18B12D0
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x18B14D0 Offset: 0x18B15D1 VA: 0x18B14D0
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x18A9010 Offset: 0x18A9111 VA: 0x18A9010 Slot: 22
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0xB8730 Offset: 0xB8831 VA: 0xB8730
	// RVA: 0x18B1BD0 Offset: 0x18B1CD1 VA: 0x18B1BD0
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8750 Offset: 0xB8851 VA: 0xB8750
	// RVA: 0x18A9B30 Offset: 0x18A9C31 VA: 0x18A9B30 Slot: 23
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B1C80 Offset: 0x18B1D81 VA: 0x18B1C80
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract long Seek(long offset, SeekOrigin origin) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x18B1E80 Offset: 0x18B1F81 VA: 0x18B1E80 Slot: 26
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x18B1F30 Offset: 0x18B2031 VA: 0x18B1F30 Slot: 28
	public virtual void WriteByte(byte value) { }

	// RVA: 0x18B0F80 Offset: 0x18B1081 VA: 0x18B0F80
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B15E0 Offset: 0x18B16E1 VA: 0x18B15E0
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x18B1A10 Offset: 0x18B1B11 VA: 0x18B1A10
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B1BC0 Offset: 0x18B1CC1 VA: 0x18B1BC0
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x18A4D00 Offset: 0x18A4E01 VA: 0x18A4D00
	protected void .ctor() { }

	// RVA: 0x18B2230 Offset: 0x18B2331 VA: 0x18B2230
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAE9E0 Offset: 0xAEAE1 VA: 0xAE9E0
[Serializable]
public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 656
{
	// Fields
	public static readonly Stream Null; // 0x0
	private Stream.ReadWriteTask _activeReadWriteTask; // 0x18
	private SemaphoreSlim _asyncActiveSemaphore; // 0x20

	// Properties
	public abstract bool CanRead { get; }
	public abstract bool CanSeek { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA190 Offset: 0xBA291 VA: 0xBA190
	public virtual int ReadTimeout { get; }
	[ComVisibleAttribute] // RVA: 0xBA1B0 Offset: 0xBA2B1 VA: 0xBA1B0
	public virtual int WriteTimeout { get; }

	// Methods

	// RVA: 0x18B0AC0 Offset: 0x18B0BC1 VA: 0x18B0AC0
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_CanRead() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanSeek() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_CanWrite() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_Length() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Position() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_Position(long value) { }

	// RVA: 0x18B0BD0 Offset: 0x18B0CD1 VA: 0x18B0BD0 Slot: 13
	public virtual int get_ReadTimeout() { }

	// RVA: 0x18B0C50 Offset: 0x18B0D51 VA: 0x18B0C50 Slot: 14
	public virtual int get_WriteTimeout() { }

	// RVA: 0x18B0CD0 Offset: 0x18B0DD1 VA: 0x18B0CD0 Slot: 15
	public virtual void Close() { }

	// RVA: 0x18B0D50 Offset: 0x18B0E51 VA: 0x18B0D50 Slot: 6
	public void Dispose() { }

	// RVA: 0x18AB0A0 Offset: 0x18AB1A1 VA: 0x18AB0A0 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Flush() { }

	// RVA: 0x18A7F70 Offset: 0x18A8071 VA: 0x18A7F70 Slot: 18
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B0D60 Offset: 0x18B0E61 VA: 0x18B0D60
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x18A81B0 Offset: 0x18A82B1 VA: 0x18A81B0 Slot: 19
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0xB8710 Offset: 0xB8811 VA: 0xB8710
	// RVA: 0x18A99B0 Offset: 0x18A9AB1 VA: 0x18A99B0 Slot: 20
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B15F0 Offset: 0x18B16F1 VA: 0x18B15F0
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x18A8CF0 Offset: 0x18A8DF1 VA: 0x18A8CF0 Slot: 21
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B17F0 Offset: 0x18B18F1 VA: 0x18B17F0
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x18B12D0 Offset: 0x18B13D1 VA: 0x18B12D0
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x18B14D0 Offset: 0x18B15D1 VA: 0x18B14D0
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x18A9010 Offset: 0x18A9111 VA: 0x18A9010 Slot: 22
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0xB8730 Offset: 0xB8831 VA: 0xB8730
	// RVA: 0x18B1BD0 Offset: 0x18B1CD1 VA: 0x18B1BD0
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8750 Offset: 0xB8851 VA: 0xB8750
	// RVA: 0x18A9B30 Offset: 0x18A9C31 VA: 0x18A9B30 Slot: 23
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B1C80 Offset: 0x18B1D81 VA: 0x18B1C80
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract long Seek(long offset, SeekOrigin origin) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x18B1E80 Offset: 0x18B1F81 VA: 0x18B1E80 Slot: 26
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x18B1F30 Offset: 0x18B2031 VA: 0x18B1F30 Slot: 28
	public virtual void WriteByte(byte value) { }

	// RVA: 0x18B0F80 Offset: 0x18B1081 VA: 0x18B0F80
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B15E0 Offset: 0x18B16E1 VA: 0x18B15E0
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x18B1A10 Offset: 0x18B1B11 VA: 0x18B1A10
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B1BC0 Offset: 0x18B1CC1 VA: 0x18B1BC0
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x18A4D00 Offset: 0x18A4E01 VA: 0x18A4D00
	protected void .ctor() { }

	// RVA: 0x18B2230 Offset: 0x18B2331 VA: 0x18B2230
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAE9E0 Offset: 0xAEAE1 VA: 0xAE9E0
[Serializable]
public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 656
{
	// Fields
	public static readonly Stream Null; // 0x0
	private Stream.ReadWriteTask _activeReadWriteTask; // 0x18
	private SemaphoreSlim _asyncActiveSemaphore; // 0x20

	// Properties
	public abstract bool CanRead { get; }
	public abstract bool CanSeek { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; set; }
	[ComVisibleAttribute] // RVA: 0xBA190 Offset: 0xBA291 VA: 0xBA190
	public virtual int ReadTimeout { get; }
	[ComVisibleAttribute] // RVA: 0xBA1B0 Offset: 0xBA2B1 VA: 0xBA1B0
	public virtual int WriteTimeout { get; }

	// Methods

	// RVA: 0x18B0AC0 Offset: 0x18B0BC1 VA: 0x18B0AC0
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_CanRead() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanSeek() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_CanWrite() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_Length() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Position() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_Position(long value) { }

	// RVA: 0x18B0BD0 Offset: 0x18B0CD1 VA: 0x18B0BD0 Slot: 13
	public virtual int get_ReadTimeout() { }

	// RVA: 0x18B0C50 Offset: 0x18B0D51 VA: 0x18B0C50 Slot: 14
	public virtual int get_WriteTimeout() { }

	// RVA: 0x18B0CD0 Offset: 0x18B0DD1 VA: 0x18B0CD0 Slot: 15
	public virtual void Close() { }

	// RVA: 0x18B0D50 Offset: 0x18B0E51 VA: 0x18B0D50 Slot: 6
	public void Dispose() { }

	// RVA: 0x18AB0A0 Offset: 0x18AB1A1 VA: 0x18AB0A0 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Flush() { }

	// RVA: 0x18A7F70 Offset: 0x18A8071 VA: 0x18A7F70 Slot: 18
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B0D60 Offset: 0x18B0E61 VA: 0x18B0D60
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x18A81B0 Offset: 0x18A82B1 VA: 0x18A81B0 Slot: 19
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0xB8710 Offset: 0xB8811 VA: 0xB8710
	// RVA: 0x18A99B0 Offset: 0x18A9AB1 VA: 0x18A99B0 Slot: 20
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B15F0 Offset: 0x18B16F1 VA: 0x18B15F0
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x18A8CF0 Offset: 0x18A8DF1 VA: 0x18A8CF0 Slot: 21
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B17F0 Offset: 0x18B18F1 VA: 0x18B17F0
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x18B12D0 Offset: 0x18B13D1 VA: 0x18B12D0
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x18B14D0 Offset: 0x18B15D1 VA: 0x18B14D0
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x18A9010 Offset: 0x18A9111 VA: 0x18A9010 Slot: 22
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0xB8730 Offset: 0xB8831 VA: 0xB8730
	// RVA: 0x18B1BD0 Offset: 0x18B1CD1 VA: 0x18B1BD0
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8750 Offset: 0xB8851 VA: 0xB8750
	// RVA: 0x18A9B30 Offset: 0x18A9C31 VA: 0x18A9B30 Slot: 23
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18B1C80 Offset: 0x18B1D81 VA: 0x18B1C80
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract long Seek(long offset, SeekOrigin origin) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x18B1E80 Offset: 0x18B1F81 VA: 0x18B1E80 Slot: 26
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x18B1F30 Offset: 0x18B2031 VA: 0x18B1F30 Slot: 28
	public virtual void WriteByte(byte value) { }

	// RVA: 0x18B0F80 Offset: 0x18B1081 VA: 0x18B0F80
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B15E0 Offset: 0x18B16E1 VA: 0x18B15E0
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x18B1A10 Offset: 0x18B1B11 VA: 0x18B1A10
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18B1BC0 Offset: 0x18B1CC1 VA: 0x18B1BC0
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x18A4D00 Offset: 0x18A4E01 VA: 0x18A4D00
	protected void .ctor() { }

	// RVA: 0x18B2230 Offset: 0x18B2331 VA: 0x18B2230
	private static void .cctor() { }
}

