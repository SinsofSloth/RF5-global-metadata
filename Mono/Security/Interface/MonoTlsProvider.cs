public abstract class MonoTlsProvider // TypeDefIndex: 1585
{
	// Properties
	public abstract Guid ID { get; }
	public abstract string Name { get; }
	public abstract bool SupportsSslStream { get; }
	public abstract bool SupportsConnectionInfo { get; }
	public abstract bool SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal abstract bool SupportsCleanShutdown { get; }

	// Methods

	// RVA: 0x1A6D690 Offset: 0x1A6D791 VA: 0x1A6D690
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_ID() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSslStream() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_SupportsConnectionInfo() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_SupportsMonoExtensions() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SslProtocols get_SupportedProtocols() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract bool get_SupportsCleanShutdown() { }
}

public abstract class MonoTlsProvider // TypeDefIndex: 1585
{
	// Properties
	public abstract Guid ID { get; }
	public abstract string Name { get; }
	public abstract bool SupportsSslStream { get; }
	public abstract bool SupportsConnectionInfo { get; }
	public abstract bool SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal abstract bool SupportsCleanShutdown { get; }

	// Methods

	// RVA: 0x1A6D690 Offset: 0x1A6D791 VA: 0x1A6D690
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_ID() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSslStream() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_SupportsConnectionInfo() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_SupportsMonoExtensions() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SslProtocols get_SupportedProtocols() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract bool get_SupportsCleanShutdown() { }
}

public abstract class MonoTlsProvider // TypeDefIndex: 1585
{
	// Properties
	public abstract Guid ID { get; }
	public abstract string Name { get; }
	public abstract bool SupportsSslStream { get; }
	public abstract bool SupportsConnectionInfo { get; }
	public abstract bool SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal abstract bool SupportsCleanShutdown { get; }

	// Methods

	// RVA: 0x1A6D690 Offset: 0x1A6D791 VA: 0x1A6D690
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_ID() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSslStream() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_SupportsConnectionInfo() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_SupportsMonoExtensions() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SslProtocols get_SupportedProtocols() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract bool get_SupportsCleanShutdown() { }
}

public abstract class MonoTlsProvider // TypeDefIndex: 1585
{
	// Properties
	public abstract Guid ID { get; }
	public abstract string Name { get; }
	public abstract bool SupportsSslStream { get; }
	public abstract bool SupportsConnectionInfo { get; }
	public abstract bool SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal abstract bool SupportsCleanShutdown { get; }

	// Methods

	// RVA: 0x1A6D690 Offset: 0x1A6D791 VA: 0x1A6D690
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_ID() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSslStream() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_SupportsConnectionInfo() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_SupportsMonoExtensions() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SslProtocols get_SupportedProtocols() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract bool get_SupportsCleanShutdown() { }
}

public abstract class MonoTlsProvider // TypeDefIndex: 1585
{
	// Properties
	public abstract Guid ID { get; }
	public abstract string Name { get; }
	public abstract bool SupportsSslStream { get; }
	public abstract bool SupportsConnectionInfo { get; }
	public abstract bool SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal abstract bool SupportsCleanShutdown { get; }

	// Methods

	// RVA: 0x1A6D690 Offset: 0x1A6D791 VA: 0x1A6D690
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_ID() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSslStream() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_SupportsConnectionInfo() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_SupportsMonoExtensions() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SslProtocols get_SupportedProtocols() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract bool get_SupportsCleanShutdown() { }
}

public abstract class MonoTlsProvider // TypeDefIndex: 1585
{
	// Properties
	public abstract Guid ID { get; }
	public abstract string Name { get; }
	public abstract bool SupportsSslStream { get; }
	public abstract bool SupportsConnectionInfo { get; }
	public abstract bool SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal abstract bool SupportsCleanShutdown { get; }

	// Methods

	// RVA: 0x1A6D690 Offset: 0x1A6D791 VA: 0x1A6D690
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_ID() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSslStream() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_SupportsConnectionInfo() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_SupportsMonoExtensions() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SslProtocols get_SupportedProtocols() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract bool get_SupportsCleanShutdown() { }
}

