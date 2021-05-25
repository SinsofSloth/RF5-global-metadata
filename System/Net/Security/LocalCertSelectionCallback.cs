internal sealed class LocalCertSelectionCallback : MulticastDelegate // TypeDefIndex: 2035
{
	// Methods

	// RVA: 0x16CA650 Offset: 0x16CA751 VA: 0x16CA650
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16CA670 Offset: 0x16CA771 VA: 0x16CA670 Slot: 13
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x16CAAF0 Offset: 0x16CABF1 VA: 0x16CAAF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	// RVA: 0x16CAB30 Offset: 0x16CAC31 VA: 0x16CAB30 Slot: 15
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }
}

