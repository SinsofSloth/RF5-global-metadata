internal static class UnityTlsConversions // TypeDefIndex: 1681
{
	// Methods

	// RVA: 0x28DF3B0 Offset: 0x28DF4B1 VA: 0x28DF3B0
	public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0x28DF4F0 Offset: 0x28DF5F1 VA: 0x28DF4F0
	public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0x28DF630 Offset: 0x28DF731 VA: 0x28DF630
	public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol) { }

	// RVA: 0x28DF650 Offset: 0x28DF751 VA: 0x28DF650
	public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	// RVA: 0x28DFA30 Offset: 0x28DFB31 VA: 0x28DFA30
	public static MonoSslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult) { }
}

