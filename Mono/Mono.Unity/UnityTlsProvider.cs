internal class UnityTlsProvider : MonoTlsProvider // TypeDefIndex: 1682
{
	// Properties
	public override string Name { get; }
	public override Guid ID { get; }
	public override bool SupportsSslStream { get; }
	public override bool SupportsMonoExtensions { get; }
	public override bool SupportsConnectionInfo { get; }
	internal override bool SupportsCleanShutdown { get; }
	public override SslProtocols SupportedProtocols { get; }

	// Methods

	// RVA: 0x28DFB00 Offset: 0x28DFC01 VA: 0x28DFB00 Slot: 5
	public override string get_Name() { }

	// RVA: 0x28DFB50 Offset: 0x28DFC51 VA: 0x28DFB50 Slot: 4
	public override Guid get_ID() { }

	// RVA: 0x28DFBC0 Offset: 0x28DFCC1 VA: 0x28DFBC0 Slot: 6
	public override bool get_SupportsSslStream() { }

	// RVA: 0x28DFBD0 Offset: 0x28DFCD1 VA: 0x28DFBD0 Slot: 8
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0x28DFBE0 Offset: 0x28DFCE1 VA: 0x28DFBE0 Slot: 7
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0x28DFBF0 Offset: 0x28DFCF1 VA: 0x28DFBF0 Slot: 13
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0x28DFC00 Offset: 0x28DFD01 VA: 0x28DFC00 Slot: 9
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0x28DFC10 Offset: 0x28DFD11 VA: 0x28DFC10 Slot: 10
	public override IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0x28DFC30 Offset: 0x28DFD31 VA: 0x28DFC30 Slot: 11
	internal override IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0x28DFDD0 Offset: 0x28DFED1 VA: 0x28DFDD0 Slot: 12
	internal override bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11) { }

	// RVA: 0x28E04B0 Offset: 0x28E05B1 VA: 0x28E04B0
	public void .ctor() { }
}

