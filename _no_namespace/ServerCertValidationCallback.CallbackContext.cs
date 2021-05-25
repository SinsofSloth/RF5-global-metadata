private class ServerCertValidationCallback.CallbackContext // TypeDefIndex: 1955
{
	// Fields
	internal readonly object request; // 0x10
	internal readonly X509Certificate certificate; // 0x18
	internal readonly X509Chain chain; // 0x20
	internal readonly SslPolicyErrors sslPolicyErrors; // 0x28
	internal bool result; // 0x2C

	// Methods

	// RVA: 0x16CC840 Offset: 0x16CC941 VA: 0x16CC840
	internal void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}

