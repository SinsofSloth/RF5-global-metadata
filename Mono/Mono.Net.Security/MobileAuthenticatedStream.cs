internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IMonoSslStream, IDisposable // TypeDefIndex: 1715
{
	// Fields
	private MobileTlsContext xobileTlsContext; // 0x38
	private ExceptionDispatchInfo lastException; // 0x40
	private AsyncProtocolRequest asyncHandshakeRequest; // 0x48
	private AsyncProtocolRequest asyncReadRequest; // 0x50
	private AsyncProtocolRequest asyncWriteRequest; // 0x58
	private BufferOffsetSize2 readBuffer; // 0x60
	private BufferOffsetSize2 writeBuffer; // 0x68
	private object ioLock; // 0x70
	private int closeRequested; // 0x78
	private bool shutdown; // 0x7C
	private static int uniqueNameInteger; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xBCDF0 Offset: 0xBCEF1 VA: 0xBCDF0
	private readonly SslStream <SslStream>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0xBCE00 Offset: 0xBCF01 VA: 0xBCE00
	private readonly MonoTlsSettings <Settings>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0xBCE10 Offset: 0xBCF11 VA: 0xBCE10
	private readonly MonoTlsProvider <Provider>k__BackingField; // 0x90
	private static int nextId; // 0x4
	internal readonly int ID; // 0x98

	// Properties
	public MonoTlsSettings Settings { get; }
	public MonoTlsProvider Provider { get; }
	public AuthenticatedStream AuthenticatedStream { get; }
	public override bool IsAuthenticated { get; }
	public X509Certificate InternalLocalCertificate { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }

	// Methods

	// RVA: 0x16F22A0 Offset: 0x16F23A1 VA: 0x16F22A0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	[CompilerGeneratedAttribute] // RVA: 0xBD450 Offset: 0xBD551 VA: 0xBD450
	// RVA: 0x16F2490 Offset: 0x16F2591 VA: 0x16F2490
	public MonoTlsSettings get_Settings() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD460 Offset: 0xBD561 VA: 0xBD460
	// RVA: 0x16F24A0 Offset: 0x16F25A1 VA: 0x16F24A0 Slot: 46
	public MonoTlsProvider get_Provider() { }

	// RVA: 0x16F24B0 Offset: 0x16F25B1 VA: 0x16F24B0
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = False) { }

	// RVA: 0x16F0220 Offset: 0x16F0321 VA: 0x16F0220
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0x16F2590 Offset: 0x16F2691 VA: 0x16F2590
	internal static Exception GetIOException(Exception e, string message) { }

	// RVA: 0x16F0360 Offset: 0x16F0461 VA: 0x16F0360
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0x16F26D0 Offset: 0x16F27D1 VA: 0x16F26D0 Slot: 30
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x16F2900 Offset: 0x16F2A01 VA: 0x16F2900 Slot: 42
	public AuthenticatedStream get_AuthenticatedStream() { }

	[AsyncStateMachineAttribute] // RVA: 0xBD470 Offset: 0xBD571 VA: 0xBD470
	// RVA: 0x16F2720 Offset: 0x16F2821 VA: 0x16F2720
	private Task ProcessAuthentication(bool runSynchronously, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool clientCertRequired) { }

	// RVA: -1 Offset: -1 Slot: 47
	protected abstract MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x16F2910 Offset: 0x16F2A11 VA: 0x16F2910 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16F2B80 Offset: 0x16F2C81 VA: 0x16F2B80 Slot: 19
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x16F2BD0 Offset: 0x16F2CD1 VA: 0x16F2BD0 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x16F2CB0 Offset: 0x16F2DB1 VA: 0x16F2CB0 Slot: 22
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x16F2CC0 Offset: 0x16F2DC1 VA: 0x16F2CC0 Slot: 25
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x16F2DA0 Offset: 0x16F2EA1 VA: 0x16F2DA0 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x16F2E70 Offset: 0x16F2F71 VA: 0x16F2E70 Slot: 20
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x16F2F10 Offset: 0x16F3011 VA: 0x16F2F10 Slot: 23
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD4E0 Offset: 0xBD5E1 VA: 0xBD4E0
	// RVA: 0x16F29F0 Offset: 0x16F2AF1 VA: 0x16F29F0
	private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0x16F2FB0 Offset: 0x16F30B1 VA: 0x16F2FB0
	internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore) { }

	// RVA: 0x16F3100 Offset: 0x16F3201 VA: 0x16F3100
	private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size) { }

	// RVA: 0x16F32F0 Offset: 0x16F33F1 VA: 0x16F32F0
	internal bool InternalWrite(byte[] buffer, int offset, int size) { }

	// RVA: 0x16F3440 Offset: 0x16F3541 VA: 0x16F3440
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD550 Offset: 0xBD651 VA: 0xBD550
	// RVA: 0x16EF640 Offset: 0x16EF741 VA: 0x16EF640
	internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xBD5C0 Offset: 0xBD6C1 VA: 0xBD5C0
	// RVA: 0x16EFCB0 Offset: 0x16EFDB1 VA: 0x16EFCB0
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0x16EEAC0 Offset: 0x16EEBC1 VA: 0x16EEAC0
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status) { }

	// RVA: 0x16F0800 Offset: 0x16F0901 VA: 0x16F0800
	internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0x16F09D0 Offset: 0x16F0AD1 VA: 0x16F09D0
	internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0x16F3600 Offset: 0x16F3701 VA: 0x16F3600 Slot: 29
	public override bool get_IsAuthenticated() { }

	// RVA: 0x16F36D0 Offset: 0x16F37D1 VA: 0x16F36D0 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16F3960 Offset: 0x16F3A61 VA: 0x16F3960 Slot: 17
	public override void Flush() { }

	// RVA: 0x16F3990 Offset: 0x16F3A91 VA: 0x16F3990 Slot: 45
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0x16F3AB0 Offset: 0x16F3BB1 VA: 0x16F3AB0 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x16F3B10 Offset: 0x16F3C11 VA: 0x16F3B10 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x16F3B70 Offset: 0x16F3C71 VA: 0x16F3B70 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16F3BE0 Offset: 0x16F3CE1 VA: 0x16F3BE0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x16F3BF0 Offset: 0x16F3CF1 VA: 0x16F3BF0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x16F3C10 Offset: 0x16F3D11 VA: 0x16F3C10 Slot: 11
	public override long get_Position() { }

	// RVA: 0x16F3C30 Offset: 0x16F3D31 VA: 0x16F3C30 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x16F3C90 Offset: 0x16F3D91 VA: 0x16F3C90 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x16F3CC0 Offset: 0x16F3DC1 VA: 0x16F3CC0 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x16F3CF0 Offset: 0x16F3DF1 VA: 0x16F3CF0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD630 Offset: 0xBD731 VA: 0xBD630
	// RVA: 0x16F3D50 Offset: 0x16F3E51 VA: 0x16F3D50
	private void <InnerWrite>b__67_0() { }
}

