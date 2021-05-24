internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 1722
{
	// Fields
	private MobileAuthenticatedStream parent; // 0x10
	private bool serverMode; // 0x18
	private string targetHost; // 0x20
	private string serverName; // 0x28
	private SslProtocols enabledProtocols; // 0x30
	private X509Certificate serverCertificate; // 0x38
	private X509CertificateCollection clientCertificates; // 0x40
	private bool askForClientCert; // 0x48
	private ICertificateValidator2 certificateValidator; // 0x50

	// Properties
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract bool IsAuthenticated { get; }
	public bool IsServer { get; }
	protected string TargetHost { get; }
	protected string ServerName { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; }
	internal abstract X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0x16F5CA0 Offset: 0x16F5DA1 VA: 0x16F5CA0
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x16F5E30 Offset: 0x16F5F31 VA: 0x16F5E30
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0x16F5E40 Offset: 0x16F5F41 VA: 0x16F5E40
	public MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAuthenticated() { }

	// RVA: 0x16F5E60 Offset: 0x16F5F61 VA: 0x16F5E60
	public bool get_IsServer() { }

	// RVA: 0x16F5E70 Offset: 0x16F5F71 VA: 0x16F5E70
	protected string get_TargetHost() { }

	// RVA: 0x16F5E80 Offset: 0x16F5F81 VA: 0x16F5E80
	protected string get_ServerName() { }

	// RVA: 0x16F5E90 Offset: 0x16F5F91 VA: 0x16F5E90
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StartHandshake() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ProcessHandshake() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FinishHandshake() { }

	// RVA: 0x16F5EA0 Offset: 0x16F5FA1 VA: 0x16F5EA0
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract X509Certificate get_LocalClientCertificate() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Shutdown() { }

	// RVA: 0x16F5EB0 Offset: 0x16F5FB1 VA: 0x16F5EB0
	protected bool ValidateCertificate(X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x16F5FC0 Offset: 0x16F60C1 VA: 0x16F5FC0
	protected bool ValidateCertificate(X509CertificateCollection certificates) { }

	// RVA: 0x16F60D0 Offset: 0x16F61D1 VA: 0x16F60D0
	protected X509Certificate SelectClientCertificate(X509Certificate serverCertificate, string[] acceptableIssuers) { }

	// RVA: 0x16F38E0 Offset: 0x16F39E1 VA: 0x16F38E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x16F6250 Offset: 0x16F6351 VA: 0x16F6250 Slot: 13
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16F6260 Offset: 0x16F6361 VA: 0x16F6260 Slot: 1
	protected override void Finalize() { }
}

internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 1722
{
	// Fields
	private MobileAuthenticatedStream parent; // 0x10
	private bool serverMode; // 0x18
	private string targetHost; // 0x20
	private string serverName; // 0x28
	private SslProtocols enabledProtocols; // 0x30
	private X509Certificate serverCertificate; // 0x38
	private X509CertificateCollection clientCertificates; // 0x40
	private bool askForClientCert; // 0x48
	private ICertificateValidator2 certificateValidator; // 0x50

	// Properties
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract bool IsAuthenticated { get; }
	public bool IsServer { get; }
	protected string TargetHost { get; }
	protected string ServerName { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; }
	internal abstract X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0x16F5CA0 Offset: 0x16F5DA1 VA: 0x16F5CA0
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x16F5E30 Offset: 0x16F5F31 VA: 0x16F5E30
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0x16F5E40 Offset: 0x16F5F41 VA: 0x16F5E40
	public MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAuthenticated() { }

	// RVA: 0x16F5E60 Offset: 0x16F5F61 VA: 0x16F5E60
	public bool get_IsServer() { }

	// RVA: 0x16F5E70 Offset: 0x16F5F71 VA: 0x16F5E70
	protected string get_TargetHost() { }

	// RVA: 0x16F5E80 Offset: 0x16F5F81 VA: 0x16F5E80
	protected string get_ServerName() { }

	// RVA: 0x16F5E90 Offset: 0x16F5F91 VA: 0x16F5E90
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StartHandshake() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ProcessHandshake() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FinishHandshake() { }

	// RVA: 0x16F5EA0 Offset: 0x16F5FA1 VA: 0x16F5EA0
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract X509Certificate get_LocalClientCertificate() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Shutdown() { }

	// RVA: 0x16F5EB0 Offset: 0x16F5FB1 VA: 0x16F5EB0
	protected bool ValidateCertificate(X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x16F5FC0 Offset: 0x16F60C1 VA: 0x16F5FC0
	protected bool ValidateCertificate(X509CertificateCollection certificates) { }

	// RVA: 0x16F60D0 Offset: 0x16F61D1 VA: 0x16F60D0
	protected X509Certificate SelectClientCertificate(X509Certificate serverCertificate, string[] acceptableIssuers) { }

	// RVA: 0x16F38E0 Offset: 0x16F39E1 VA: 0x16F38E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x16F6250 Offset: 0x16F6351 VA: 0x16F6250 Slot: 13
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16F6260 Offset: 0x16F6361 VA: 0x16F6260 Slot: 1
	protected override void Finalize() { }
}

internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 1722
{
	// Fields
	private MobileAuthenticatedStream parent; // 0x10
	private bool serverMode; // 0x18
	private string targetHost; // 0x20
	private string serverName; // 0x28
	private SslProtocols enabledProtocols; // 0x30
	private X509Certificate serverCertificate; // 0x38
	private X509CertificateCollection clientCertificates; // 0x40
	private bool askForClientCert; // 0x48
	private ICertificateValidator2 certificateValidator; // 0x50

	// Properties
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract bool IsAuthenticated { get; }
	public bool IsServer { get; }
	protected string TargetHost { get; }
	protected string ServerName { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; }
	internal abstract X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0x16F5CA0 Offset: 0x16F5DA1 VA: 0x16F5CA0
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x16F5E30 Offset: 0x16F5F31 VA: 0x16F5E30
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0x16F5E40 Offset: 0x16F5F41 VA: 0x16F5E40
	public MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAuthenticated() { }

	// RVA: 0x16F5E60 Offset: 0x16F5F61 VA: 0x16F5E60
	public bool get_IsServer() { }

	// RVA: 0x16F5E70 Offset: 0x16F5F71 VA: 0x16F5E70
	protected string get_TargetHost() { }

	// RVA: 0x16F5E80 Offset: 0x16F5F81 VA: 0x16F5E80
	protected string get_ServerName() { }

	// RVA: 0x16F5E90 Offset: 0x16F5F91 VA: 0x16F5E90
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StartHandshake() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ProcessHandshake() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FinishHandshake() { }

	// RVA: 0x16F5EA0 Offset: 0x16F5FA1 VA: 0x16F5EA0
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract X509Certificate get_LocalClientCertificate() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Shutdown() { }

	// RVA: 0x16F5EB0 Offset: 0x16F5FB1 VA: 0x16F5EB0
	protected bool ValidateCertificate(X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x16F5FC0 Offset: 0x16F60C1 VA: 0x16F5FC0
	protected bool ValidateCertificate(X509CertificateCollection certificates) { }

	// RVA: 0x16F60D0 Offset: 0x16F61D1 VA: 0x16F60D0
	protected X509Certificate SelectClientCertificate(X509Certificate serverCertificate, string[] acceptableIssuers) { }

	// RVA: 0x16F38E0 Offset: 0x16F39E1 VA: 0x16F38E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x16F6250 Offset: 0x16F6351 VA: 0x16F6250 Slot: 13
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16F6260 Offset: 0x16F6361 VA: 0x16F6260 Slot: 1
	protected override void Finalize() { }
}

internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 1722
{
	// Fields
	private MobileAuthenticatedStream parent; // 0x10
	private bool serverMode; // 0x18
	private string targetHost; // 0x20
	private string serverName; // 0x28
	private SslProtocols enabledProtocols; // 0x30
	private X509Certificate serverCertificate; // 0x38
	private X509CertificateCollection clientCertificates; // 0x40
	private bool askForClientCert; // 0x48
	private ICertificateValidator2 certificateValidator; // 0x50

	// Properties
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract bool IsAuthenticated { get; }
	public bool IsServer { get; }
	protected string TargetHost { get; }
	protected string ServerName { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; }
	internal abstract X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0x16F5CA0 Offset: 0x16F5DA1 VA: 0x16F5CA0
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x16F5E30 Offset: 0x16F5F31 VA: 0x16F5E30
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0x16F5E40 Offset: 0x16F5F41 VA: 0x16F5E40
	public MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAuthenticated() { }

	// RVA: 0x16F5E60 Offset: 0x16F5F61 VA: 0x16F5E60
	public bool get_IsServer() { }

	// RVA: 0x16F5E70 Offset: 0x16F5F71 VA: 0x16F5E70
	protected string get_TargetHost() { }

	// RVA: 0x16F5E80 Offset: 0x16F5F81 VA: 0x16F5E80
	protected string get_ServerName() { }

	// RVA: 0x16F5E90 Offset: 0x16F5F91 VA: 0x16F5E90
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StartHandshake() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ProcessHandshake() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FinishHandshake() { }

	// RVA: 0x16F5EA0 Offset: 0x16F5FA1 VA: 0x16F5EA0
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract X509Certificate get_LocalClientCertificate() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Shutdown() { }

	// RVA: 0x16F5EB0 Offset: 0x16F5FB1 VA: 0x16F5EB0
	protected bool ValidateCertificate(X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x16F5FC0 Offset: 0x16F60C1 VA: 0x16F5FC0
	protected bool ValidateCertificate(X509CertificateCollection certificates) { }

	// RVA: 0x16F60D0 Offset: 0x16F61D1 VA: 0x16F60D0
	protected X509Certificate SelectClientCertificate(X509Certificate serverCertificate, string[] acceptableIssuers) { }

	// RVA: 0x16F38E0 Offset: 0x16F39E1 VA: 0x16F38E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x16F6250 Offset: 0x16F6351 VA: 0x16F6250 Slot: 13
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16F6260 Offset: 0x16F6361 VA: 0x16F6260 Slot: 1
	protected override void Finalize() { }
}

internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 1722
{
	// Fields
	private MobileAuthenticatedStream parent; // 0x10
	private bool serverMode; // 0x18
	private string targetHost; // 0x20
	private string serverName; // 0x28
	private SslProtocols enabledProtocols; // 0x30
	private X509Certificate serverCertificate; // 0x38
	private X509CertificateCollection clientCertificates; // 0x40
	private bool askForClientCert; // 0x48
	private ICertificateValidator2 certificateValidator; // 0x50

	// Properties
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract bool IsAuthenticated { get; }
	public bool IsServer { get; }
	protected string TargetHost { get; }
	protected string ServerName { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; }
	internal abstract X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0x16F5CA0 Offset: 0x16F5DA1 VA: 0x16F5CA0
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x16F5E30 Offset: 0x16F5F31 VA: 0x16F5E30
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0x16F5E40 Offset: 0x16F5F41 VA: 0x16F5E40
	public MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAuthenticated() { }

	// RVA: 0x16F5E60 Offset: 0x16F5F61 VA: 0x16F5E60
	public bool get_IsServer() { }

	// RVA: 0x16F5E70 Offset: 0x16F5F71 VA: 0x16F5E70
	protected string get_TargetHost() { }

	// RVA: 0x16F5E80 Offset: 0x16F5F81 VA: 0x16F5E80
	protected string get_ServerName() { }

	// RVA: 0x16F5E90 Offset: 0x16F5F91 VA: 0x16F5E90
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StartHandshake() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ProcessHandshake() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FinishHandshake() { }

	// RVA: 0x16F5EA0 Offset: 0x16F5FA1 VA: 0x16F5EA0
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract X509Certificate get_LocalClientCertificate() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Shutdown() { }

	// RVA: 0x16F5EB0 Offset: 0x16F5FB1 VA: 0x16F5EB0
	protected bool ValidateCertificate(X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x16F5FC0 Offset: 0x16F60C1 VA: 0x16F5FC0
	protected bool ValidateCertificate(X509CertificateCollection certificates) { }

	// RVA: 0x16F60D0 Offset: 0x16F61D1 VA: 0x16F60D0
	protected X509Certificate SelectClientCertificate(X509Certificate serverCertificate, string[] acceptableIssuers) { }

	// RVA: 0x16F38E0 Offset: 0x16F39E1 VA: 0x16F38E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x16F6250 Offset: 0x16F6351 VA: 0x16F6250 Slot: 13
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16F6260 Offset: 0x16F6361 VA: 0x16F6260 Slot: 1
	protected override void Finalize() { }
}

internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 1722
{
	// Fields
	private MobileAuthenticatedStream parent; // 0x10
	private bool serverMode; // 0x18
	private string targetHost; // 0x20
	private string serverName; // 0x28
	private SslProtocols enabledProtocols; // 0x30
	private X509Certificate serverCertificate; // 0x38
	private X509CertificateCollection clientCertificates; // 0x40
	private bool askForClientCert; // 0x48
	private ICertificateValidator2 certificateValidator; // 0x50

	// Properties
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract bool IsAuthenticated { get; }
	public bool IsServer { get; }
	protected string TargetHost { get; }
	protected string ServerName { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; }
	internal abstract X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0x16F5CA0 Offset: 0x16F5DA1 VA: 0x16F5CA0
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x16F5E30 Offset: 0x16F5F31 VA: 0x16F5E30
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0x16F5E40 Offset: 0x16F5F41 VA: 0x16F5E40
	public MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAuthenticated() { }

	// RVA: 0x16F5E60 Offset: 0x16F5F61 VA: 0x16F5E60
	public bool get_IsServer() { }

	// RVA: 0x16F5E70 Offset: 0x16F5F71 VA: 0x16F5E70
	protected string get_TargetHost() { }

	// RVA: 0x16F5E80 Offset: 0x16F5F81 VA: 0x16F5E80
	protected string get_ServerName() { }

	// RVA: 0x16F5E90 Offset: 0x16F5F91 VA: 0x16F5E90
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StartHandshake() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ProcessHandshake() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FinishHandshake() { }

	// RVA: 0x16F5EA0 Offset: 0x16F5FA1 VA: 0x16F5EA0
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract X509Certificate get_LocalClientCertificate() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Shutdown() { }

	// RVA: 0x16F5EB0 Offset: 0x16F5FB1 VA: 0x16F5EB0
	protected bool ValidateCertificate(X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x16F5FC0 Offset: 0x16F60C1 VA: 0x16F5FC0
	protected bool ValidateCertificate(X509CertificateCollection certificates) { }

	// RVA: 0x16F60D0 Offset: 0x16F61D1 VA: 0x16F60D0
	protected X509Certificate SelectClientCertificate(X509Certificate serverCertificate, string[] acceptableIssuers) { }

	// RVA: 0x16F38E0 Offset: 0x16F39E1 VA: 0x16F38E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x16F6250 Offset: 0x16F6351 VA: 0x16F6250 Slot: 13
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16F6260 Offset: 0x16F6361 VA: 0x16F6260 Slot: 1
	protected override void Finalize() { }
}

internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 1722
{
	// Fields
	private MobileAuthenticatedStream parent; // 0x10
	private bool serverMode; // 0x18
	private string targetHost; // 0x20
	private string serverName; // 0x28
	private SslProtocols enabledProtocols; // 0x30
	private X509Certificate serverCertificate; // 0x38
	private X509CertificateCollection clientCertificates; // 0x40
	private bool askForClientCert; // 0x48
	private ICertificateValidator2 certificateValidator; // 0x50

	// Properties
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract bool IsAuthenticated { get; }
	public bool IsServer { get; }
	protected string TargetHost { get; }
	protected string ServerName { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; }
	internal abstract X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0x16F5CA0 Offset: 0x16F5DA1 VA: 0x16F5CA0
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x16F5E30 Offset: 0x16F5F31 VA: 0x16F5E30
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0x16F5E40 Offset: 0x16F5F41 VA: 0x16F5E40
	public MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAuthenticated() { }

	// RVA: 0x16F5E60 Offset: 0x16F5F61 VA: 0x16F5E60
	public bool get_IsServer() { }

	// RVA: 0x16F5E70 Offset: 0x16F5F71 VA: 0x16F5E70
	protected string get_TargetHost() { }

	// RVA: 0x16F5E80 Offset: 0x16F5F81 VA: 0x16F5E80
	protected string get_ServerName() { }

	// RVA: 0x16F5E90 Offset: 0x16F5F91 VA: 0x16F5E90
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StartHandshake() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ProcessHandshake() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FinishHandshake() { }

	// RVA: 0x16F5EA0 Offset: 0x16F5FA1 VA: 0x16F5EA0
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract X509Certificate get_LocalClientCertificate() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Shutdown() { }

	// RVA: 0x16F5EB0 Offset: 0x16F5FB1 VA: 0x16F5EB0
	protected bool ValidateCertificate(X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x16F5FC0 Offset: 0x16F60C1 VA: 0x16F5FC0
	protected bool ValidateCertificate(X509CertificateCollection certificates) { }

	// RVA: 0x16F60D0 Offset: 0x16F61D1 VA: 0x16F60D0
	protected X509Certificate SelectClientCertificate(X509Certificate serverCertificate, string[] acceptableIssuers) { }

	// RVA: 0x16F38E0 Offset: 0x16F39E1 VA: 0x16F38E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x16F6250 Offset: 0x16F6351 VA: 0x16F6250 Slot: 13
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16F6260 Offset: 0x16F6361 VA: 0x16F6260 Slot: 1
	protected override void Finalize() { }
}

