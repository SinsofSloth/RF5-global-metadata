public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 1583
{
	// Methods

	// RVA: 0x1A6D010 Offset: 0x1A6D111 VA: 0x1A6D010
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A6D030 Offset: 0x1A6D131 VA: 0x1A6D030 Slot: 13
	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x1A6D4B0 Offset: 0x1A6D5B1 VA: 0x1A6D4B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	// RVA: 0x1A6D560 Offset: 0x1A6D661 VA: 0x1A6D560 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

