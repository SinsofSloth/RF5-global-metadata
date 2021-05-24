public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 1584
{
	// Methods

	// RVA: 0x1A6CB20 Offset: 0x1A6CC21 VA: 0x1A6CB20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A6CB40 Offset: 0x1A6CC41 VA: 0x1A6CB40 Slot: 13
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x1A6CFC0 Offset: 0x1A6D0C1 VA: 0x1A6CFC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	// RVA: 0x1A6D000 Offset: 0x1A6D101 VA: 0x1A6D000 Slot: 15
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }
}

