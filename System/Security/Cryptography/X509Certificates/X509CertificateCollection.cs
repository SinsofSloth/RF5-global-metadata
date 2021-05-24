[DefaultMemberAttribute] // RVA: 0xBC100 Offset: 0xBC201 VA: 0xBC100
[Serializable]
public class X509CertificateCollection : CollectionBase // TypeDefIndex: 1846
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0x1716F20 Offset: 0x1717021 VA: 0x1716F20
	public void .ctor() { }

	// RVA: 0x1716F30 Offset: 0x1717031 VA: 0x1716F30
	public void .ctor(X509CertificateCollection value) { }

	// RVA: 0x1717100 Offset: 0x1717201 VA: 0x1717100
	public X509Certificate get_Item(int index) { }

	// RVA: 0x17171B0 Offset: 0x17172B1 VA: 0x17171B0
	public int Add(X509Certificate value) { }

	// RVA: 0x1716F60 Offset: 0x1717061 VA: 0x1716F60
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x1717260 Offset: 0x1717361 VA: 0x1717260
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x17173A0 Offset: 0x17174A1 VA: 0x17173A0 Slot: 2
	public override int GetHashCode() { }
}

