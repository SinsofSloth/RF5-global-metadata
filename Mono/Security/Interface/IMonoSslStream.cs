public interface IMonoSslStream : IDisposable // TypeDefIndex: 1580
{
	// Properties
	public abstract bool IsAuthenticated { get; }
	public abstract bool CanRead { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; }
	public abstract AuthenticatedStream AuthenticatedStream { get; }
	public abstract int ReadTimeout { get; }
	public abstract int WriteTimeout { get; }
	public abstract X509Certificate InternalLocalCertificate { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int Read(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Write(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int EndRead(IAsyncResult asyncResult) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void EndWrite(IAsyncResult asyncResult) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsAuthenticated() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanRead() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_CanWrite() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_Length() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Position() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract AuthenticatedStream get_AuthenticatedStream() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int get_ReadTimeout() { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int get_WriteTimeout() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract X509Certificate get_InternalLocalCertificate() { }
}

