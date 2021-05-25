public sealed class RemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 2033
{
	// Methods

	// RVA: 0x16CAB40 Offset: 0x16CAC41 VA: 0x16CAB40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16CAB60 Offset: 0x16CAC61 VA: 0x16CAB60 Slot: 13
	public virtual bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x16CAFE0 Offset: 0x16CB0E1 VA: 0x16CAFE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	// RVA: 0x16CB090 Offset: 0x16CB191 VA: 0x16CB090 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

