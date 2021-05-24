public class SslStream : AuthenticatedStream // TypeDefIndex: 2036
{
	// Fields
	private MonoTlsProvider provider; // 0x38
	private IMonoSslStream impl; // 0x40

	// Properties
	internal IMonoSslStream Impl { get; }
	public override bool IsAuthenticated { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x16CB0C0 Offset: 0x16CB1C1 VA: 0x16CB0C0
	internal IMonoSslStream get_Impl() { }

	// RVA: 0x16CB1E0 Offset: 0x16CB2E1 VA: 0x16CB1E0
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16CB270 Offset: 0x16CB371 VA: 0x16CB270
	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16CB3B0 Offset: 0x16CB4B1 VA: 0x16CB3B0 Slot: 29
	public override bool get_IsAuthenticated() { }

	// RVA: 0x16CB4E0 Offset: 0x16CB5E1 VA: 0x16CB4E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x16CB4F0 Offset: 0x16CB5F1 VA: 0x16CB4F0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x16CB5B0 Offset: 0x16CB6B1 VA: 0x16CB5B0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16CB670 Offset: 0x16CB771 VA: 0x16CB670 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x16CB7A0 Offset: 0x16CB8A1 VA: 0x16CB7A0 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x16CB8D0 Offset: 0x16CB9D1 VA: 0x16CB8D0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x16CBA00 Offset: 0x16CBB01 VA: 0x16CBA00 Slot: 11
	public override long get_Position() { }

	// RVA: 0x16CBB30 Offset: 0x16CBC31 VA: 0x16CBB30 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x16CBBB0 Offset: 0x16CBCB1 VA: 0x16CBBB0 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x16CBC30 Offset: 0x16CBD31 VA: 0x16CBC30 Slot: 17
	public override void Flush() { }

	// RVA: 0x16CB150 Offset: 0x16CB251 VA: 0x16CB150
	private void CheckDisposed() { }

	// RVA: 0x16CBC60 Offset: 0x16CBD61 VA: 0x16CBC60 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16CBD80 Offset: 0x16CBE81 VA: 0x16CBD80 Slot: 25
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x16CBED0 Offset: 0x16CBFD1 VA: 0x16CBED0 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x16CC020 Offset: 0x16CC121 VA: 0x16CC020 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16CC190 Offset: 0x16CC291 VA: 0x16CC190 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x16CC2D0 Offset: 0x16CC3D1 VA: 0x16CC2D0 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16CC440 Offset: 0x16CC541 VA: 0x16CC440 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }
}

public class SslStream : AuthenticatedStream // TypeDefIndex: 2036
{
	// Fields
	private MonoTlsProvider provider; // 0x38
	private IMonoSslStream impl; // 0x40

	// Properties
	internal IMonoSslStream Impl { get; }
	public override bool IsAuthenticated { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x16CB0C0 Offset: 0x16CB1C1 VA: 0x16CB0C0
	internal IMonoSslStream get_Impl() { }

	// RVA: 0x16CB1E0 Offset: 0x16CB2E1 VA: 0x16CB1E0
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16CB270 Offset: 0x16CB371 VA: 0x16CB270
	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16CB3B0 Offset: 0x16CB4B1 VA: 0x16CB3B0 Slot: 29
	public override bool get_IsAuthenticated() { }

	// RVA: 0x16CB4E0 Offset: 0x16CB5E1 VA: 0x16CB4E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x16CB4F0 Offset: 0x16CB5F1 VA: 0x16CB4F0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x16CB5B0 Offset: 0x16CB6B1 VA: 0x16CB5B0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16CB670 Offset: 0x16CB771 VA: 0x16CB670 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x16CB7A0 Offset: 0x16CB8A1 VA: 0x16CB7A0 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x16CB8D0 Offset: 0x16CB9D1 VA: 0x16CB8D0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x16CBA00 Offset: 0x16CBB01 VA: 0x16CBA00 Slot: 11
	public override long get_Position() { }

	// RVA: 0x16CBB30 Offset: 0x16CBC31 VA: 0x16CBB30 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x16CBBB0 Offset: 0x16CBCB1 VA: 0x16CBBB0 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x16CBC30 Offset: 0x16CBD31 VA: 0x16CBC30 Slot: 17
	public override void Flush() { }

	// RVA: 0x16CB150 Offset: 0x16CB251 VA: 0x16CB150
	private void CheckDisposed() { }

	// RVA: 0x16CBC60 Offset: 0x16CBD61 VA: 0x16CBC60 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16CBD80 Offset: 0x16CBE81 VA: 0x16CBD80 Slot: 25
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x16CBED0 Offset: 0x16CBFD1 VA: 0x16CBED0 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x16CC020 Offset: 0x16CC121 VA: 0x16CC020 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16CC190 Offset: 0x16CC291 VA: 0x16CC190 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x16CC2D0 Offset: 0x16CC3D1 VA: 0x16CC2D0 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16CC440 Offset: 0x16CC541 VA: 0x16CC440 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }
}

public class SslStream : AuthenticatedStream // TypeDefIndex: 2036
{
	// Fields
	private MonoTlsProvider provider; // 0x38
	private IMonoSslStream impl; // 0x40

	// Properties
	internal IMonoSslStream Impl { get; }
	public override bool IsAuthenticated { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x16CB0C0 Offset: 0x16CB1C1 VA: 0x16CB0C0
	internal IMonoSslStream get_Impl() { }

	// RVA: 0x16CB1E0 Offset: 0x16CB2E1 VA: 0x16CB1E0
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16CB270 Offset: 0x16CB371 VA: 0x16CB270
	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16CB3B0 Offset: 0x16CB4B1 VA: 0x16CB3B0 Slot: 29
	public override bool get_IsAuthenticated() { }

	// RVA: 0x16CB4E0 Offset: 0x16CB5E1 VA: 0x16CB4E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x16CB4F0 Offset: 0x16CB5F1 VA: 0x16CB4F0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x16CB5B0 Offset: 0x16CB6B1 VA: 0x16CB5B0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16CB670 Offset: 0x16CB771 VA: 0x16CB670 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x16CB7A0 Offset: 0x16CB8A1 VA: 0x16CB7A0 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x16CB8D0 Offset: 0x16CB9D1 VA: 0x16CB8D0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x16CBA00 Offset: 0x16CBB01 VA: 0x16CBA00 Slot: 11
	public override long get_Position() { }

	// RVA: 0x16CBB30 Offset: 0x16CBC31 VA: 0x16CBB30 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x16CBBB0 Offset: 0x16CBCB1 VA: 0x16CBBB0 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x16CBC30 Offset: 0x16CBD31 VA: 0x16CBC30 Slot: 17
	public override void Flush() { }

	// RVA: 0x16CB150 Offset: 0x16CB251 VA: 0x16CB150
	private void CheckDisposed() { }

	// RVA: 0x16CBC60 Offset: 0x16CBD61 VA: 0x16CBC60 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16CBD80 Offset: 0x16CBE81 VA: 0x16CBD80 Slot: 25
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x16CBED0 Offset: 0x16CBFD1 VA: 0x16CBED0 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x16CC020 Offset: 0x16CC121 VA: 0x16CC020 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16CC190 Offset: 0x16CC291 VA: 0x16CC190 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x16CC2D0 Offset: 0x16CC3D1 VA: 0x16CC2D0 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16CC440 Offset: 0x16CC541 VA: 0x16CC440 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }
}

public class SslStream : AuthenticatedStream // TypeDefIndex: 2036
{
	// Fields
	private MonoTlsProvider provider; // 0x38
	private IMonoSslStream impl; // 0x40

	// Properties
	internal IMonoSslStream Impl { get; }
	public override bool IsAuthenticated { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x16CB0C0 Offset: 0x16CB1C1 VA: 0x16CB0C0
	internal IMonoSslStream get_Impl() { }

	// RVA: 0x16CB1E0 Offset: 0x16CB2E1 VA: 0x16CB1E0
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16CB270 Offset: 0x16CB371 VA: 0x16CB270
	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16CB3B0 Offset: 0x16CB4B1 VA: 0x16CB3B0 Slot: 29
	public override bool get_IsAuthenticated() { }

	// RVA: 0x16CB4E0 Offset: 0x16CB5E1 VA: 0x16CB4E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x16CB4F0 Offset: 0x16CB5F1 VA: 0x16CB4F0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x16CB5B0 Offset: 0x16CB6B1 VA: 0x16CB5B0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16CB670 Offset: 0x16CB771 VA: 0x16CB670 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x16CB7A0 Offset: 0x16CB8A1 VA: 0x16CB7A0 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x16CB8D0 Offset: 0x16CB9D1 VA: 0x16CB8D0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x16CBA00 Offset: 0x16CBB01 VA: 0x16CBA00 Slot: 11
	public override long get_Position() { }

	// RVA: 0x16CBB30 Offset: 0x16CBC31 VA: 0x16CBB30 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x16CBBB0 Offset: 0x16CBCB1 VA: 0x16CBBB0 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x16CBC30 Offset: 0x16CBD31 VA: 0x16CBC30 Slot: 17
	public override void Flush() { }

	// RVA: 0x16CB150 Offset: 0x16CB251 VA: 0x16CB150
	private void CheckDisposed() { }

	// RVA: 0x16CBC60 Offset: 0x16CBD61 VA: 0x16CBC60 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16CBD80 Offset: 0x16CBE81 VA: 0x16CBD80 Slot: 25
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x16CBED0 Offset: 0x16CBFD1 VA: 0x16CBED0 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x16CC020 Offset: 0x16CC121 VA: 0x16CC020 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16CC190 Offset: 0x16CC291 VA: 0x16CC190 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x16CC2D0 Offset: 0x16CC3D1 VA: 0x16CC2D0 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16CC440 Offset: 0x16CC541 VA: 0x16CC440 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }
}

public class SslStream : AuthenticatedStream // TypeDefIndex: 2036
{
	// Fields
	private MonoTlsProvider provider; // 0x38
	private IMonoSslStream impl; // 0x40

	// Properties
	internal IMonoSslStream Impl { get; }
	public override bool IsAuthenticated { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x16CB0C0 Offset: 0x16CB1C1 VA: 0x16CB0C0
	internal IMonoSslStream get_Impl() { }

	// RVA: 0x16CB1E0 Offset: 0x16CB2E1 VA: 0x16CB1E0
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16CB270 Offset: 0x16CB371 VA: 0x16CB270
	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16CB3B0 Offset: 0x16CB4B1 VA: 0x16CB3B0 Slot: 29
	public override bool get_IsAuthenticated() { }

	// RVA: 0x16CB4E0 Offset: 0x16CB5E1 VA: 0x16CB4E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x16CB4F0 Offset: 0x16CB5F1 VA: 0x16CB4F0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x16CB5B0 Offset: 0x16CB6B1 VA: 0x16CB5B0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16CB670 Offset: 0x16CB771 VA: 0x16CB670 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x16CB7A0 Offset: 0x16CB8A1 VA: 0x16CB7A0 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x16CB8D0 Offset: 0x16CB9D1 VA: 0x16CB8D0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x16CBA00 Offset: 0x16CBB01 VA: 0x16CBA00 Slot: 11
	public override long get_Position() { }

	// RVA: 0x16CBB30 Offset: 0x16CBC31 VA: 0x16CBB30 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x16CBBB0 Offset: 0x16CBCB1 VA: 0x16CBBB0 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x16CBC30 Offset: 0x16CBD31 VA: 0x16CBC30 Slot: 17
	public override void Flush() { }

	// RVA: 0x16CB150 Offset: 0x16CB251 VA: 0x16CB150
	private void CheckDisposed() { }

	// RVA: 0x16CBC60 Offset: 0x16CBD61 VA: 0x16CBC60 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16CBD80 Offset: 0x16CBE81 VA: 0x16CBD80 Slot: 25
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x16CBED0 Offset: 0x16CBFD1 VA: 0x16CBED0 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x16CC020 Offset: 0x16CC121 VA: 0x16CC020 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16CC190 Offset: 0x16CC291 VA: 0x16CC190 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x16CC2D0 Offset: 0x16CC3D1 VA: 0x16CC2D0 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16CC440 Offset: 0x16CC541 VA: 0x16CC440 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }
}

public class SslStream : AuthenticatedStream // TypeDefIndex: 2036
{
	// Fields
	private MonoTlsProvider provider; // 0x38
	private IMonoSslStream impl; // 0x40

	// Properties
	internal IMonoSslStream Impl { get; }
	public override bool IsAuthenticated { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x16CB0C0 Offset: 0x16CB1C1 VA: 0x16CB0C0
	internal IMonoSslStream get_Impl() { }

	// RVA: 0x16CB1E0 Offset: 0x16CB2E1 VA: 0x16CB1E0
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16CB270 Offset: 0x16CB371 VA: 0x16CB270
	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16CB3B0 Offset: 0x16CB4B1 VA: 0x16CB3B0 Slot: 29
	public override bool get_IsAuthenticated() { }

	// RVA: 0x16CB4E0 Offset: 0x16CB5E1 VA: 0x16CB4E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x16CB4F0 Offset: 0x16CB5F1 VA: 0x16CB4F0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x16CB5B0 Offset: 0x16CB6B1 VA: 0x16CB5B0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16CB670 Offset: 0x16CB771 VA: 0x16CB670 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x16CB7A0 Offset: 0x16CB8A1 VA: 0x16CB7A0 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x16CB8D0 Offset: 0x16CB9D1 VA: 0x16CB8D0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x16CBA00 Offset: 0x16CBB01 VA: 0x16CBA00 Slot: 11
	public override long get_Position() { }

	// RVA: 0x16CBB30 Offset: 0x16CBC31 VA: 0x16CBB30 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x16CBBB0 Offset: 0x16CBCB1 VA: 0x16CBBB0 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x16CBC30 Offset: 0x16CBD31 VA: 0x16CBC30 Slot: 17
	public override void Flush() { }

	// RVA: 0x16CB150 Offset: 0x16CB251 VA: 0x16CB150
	private void CheckDisposed() { }

	// RVA: 0x16CBC60 Offset: 0x16CBD61 VA: 0x16CBC60 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16CBD80 Offset: 0x16CBE81 VA: 0x16CBD80 Slot: 25
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x16CBED0 Offset: 0x16CBFD1 VA: 0x16CBED0 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x16CC020 Offset: 0x16CC121 VA: 0x16CC020 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16CC190 Offset: 0x16CC291 VA: 0x16CC190 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x16CC2D0 Offset: 0x16CC3D1 VA: 0x16CC2D0 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16CC440 Offset: 0x16CC541 VA: 0x16CC440 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }
}

public class SslStream : AuthenticatedStream // TypeDefIndex: 2036
{
	// Fields
	private MonoTlsProvider provider; // 0x38
	private IMonoSslStream impl; // 0x40

	// Properties
	internal IMonoSslStream Impl { get; }
	public override bool IsAuthenticated { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x16CB0C0 Offset: 0x16CB1C1 VA: 0x16CB0C0
	internal IMonoSslStream get_Impl() { }

	// RVA: 0x16CB1E0 Offset: 0x16CB2E1 VA: 0x16CB1E0
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16CB270 Offset: 0x16CB371 VA: 0x16CB270
	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x16CB3B0 Offset: 0x16CB4B1 VA: 0x16CB3B0 Slot: 29
	public override bool get_IsAuthenticated() { }

	// RVA: 0x16CB4E0 Offset: 0x16CB5E1 VA: 0x16CB4E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x16CB4F0 Offset: 0x16CB5F1 VA: 0x16CB4F0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x16CB5B0 Offset: 0x16CB6B1 VA: 0x16CB5B0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16CB670 Offset: 0x16CB771 VA: 0x16CB670 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x16CB7A0 Offset: 0x16CB8A1 VA: 0x16CB7A0 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x16CB8D0 Offset: 0x16CB9D1 VA: 0x16CB8D0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x16CBA00 Offset: 0x16CBB01 VA: 0x16CBA00 Slot: 11
	public override long get_Position() { }

	// RVA: 0x16CBB30 Offset: 0x16CBC31 VA: 0x16CBB30 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x16CBBB0 Offset: 0x16CBCB1 VA: 0x16CBBB0 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x16CBC30 Offset: 0x16CBD31 VA: 0x16CBC30 Slot: 17
	public override void Flush() { }

	// RVA: 0x16CB150 Offset: 0x16CB251 VA: 0x16CB150
	private void CheckDisposed() { }

	// RVA: 0x16CBC60 Offset: 0x16CBD61 VA: 0x16CBC60 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16CBD80 Offset: 0x16CBE81 VA: 0x16CBD80 Slot: 25
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x16CBED0 Offset: 0x16CBFD1 VA: 0x16CBED0 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x16CC020 Offset: 0x16CC121 VA: 0x16CC020 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16CC190 Offset: 0x16CC291 VA: 0x16CC190 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x16CC2D0 Offset: 0x16CC3D1 VA: 0x16CC2D0 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16CC440 Offset: 0x16CC541 VA: 0x16CC440 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }
}

