internal sealed class ServerCertValidationCallbackWrapper : MulticastDelegate // TypeDefIndex: 1713
{
	// Methods

	// RVA: 0x16F7D10 Offset: 0x16F7E11 VA: 0x16F7D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16F1E10 Offset: 0x16F1F11 VA: 0x16F1E10 Slot: 13
	public virtual bool Invoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x16F7D30 Offset: 0x16F7E31 VA: 0x16F7D30 Slot: 14
	public virtual IAsyncResult BeginInvoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback __callback, object object) { }

	// RVA: 0x16F7DE0 Offset: 0x16F7EE1 VA: 0x16F7DE0 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

