[DefaultMemberAttribute] // RVA: 0xBC140 Offset: 0xBC241 VA: 0xBC140
internal class X509CertificateImplCollection : IDisposable // TypeDefIndex: 1848
{
	// Fields
	private List<X509CertificateImpl> list; // 0x10

	// Properties
	public int Count { get; }
	public X509CertificateImpl Item { get; }

	// Methods

	// RVA: 0x1716140 Offset: 0x1716241 VA: 0x1716140
	public void .ctor() { }

	// RVA: 0x17177C0 Offset: 0x17178C1 VA: 0x17177C0
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x1717950 Offset: 0x1717A51 VA: 0x1717950
	public int get_Count() { }

	// RVA: 0x17179A0 Offset: 0x1717AA1 VA: 0x17179A0
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x17161C0 Offset: 0x17162C1 VA: 0x17161C0
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x1714D00 Offset: 0x1714E01 VA: 0x1714D00
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x17165E0 Offset: 0x17166E1 VA: 0x17165E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1717A20 Offset: 0x1717B21 VA: 0x1717A20 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1717BE0 Offset: 0x1717CE1 VA: 0x1717BE0 Slot: 1
	protected override void Finalize() { }
}

