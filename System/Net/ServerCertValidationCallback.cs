internal class ServerCertValidationCallback // TypeDefIndex: 1954
{
	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Methods

	// RVA: 0x16CC580 Offset: 0x16CC681 VA: 0x16CC580
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0x16CC620 Offset: 0x16CC721 VA: 0x16CC620
	internal void Callback(object state) { }

	// RVA: 0x16CC6D0 Offset: 0x16CC7D1 VA: 0x16CC6D0
	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}

