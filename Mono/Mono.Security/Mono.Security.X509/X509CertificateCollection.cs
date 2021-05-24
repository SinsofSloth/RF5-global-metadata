[DefaultMemberAttribute] // RVA: 0xBABE0 Offset: 0xBACE1 VA: 0xBABE0
[Serializable]
public class X509CertificateCollection : CollectionBase, IEnumerable // TypeDefIndex: 1559
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0x1BD2280 Offset: 0x1BD2381 VA: 0x1BD2280
	public void .ctor() { }

	// RVA: 0x1BD2290 Offset: 0x1BD2391 VA: 0x1BD2290
	public X509Certificate get_Item(int index) { }

	// RVA: 0x1BD2340 Offset: 0x1BD2441 VA: 0x1BD2340
	public int Add(X509Certificate value) { }

	// RVA: 0x1BD23F0 Offset: 0x1BD24F1 VA: 0x1BD23F0
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x1BD2530 Offset: 0x1BD2631 VA: 0x1BD2530 Slot: 16
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1BD2560 Offset: 0x1BD2661 VA: 0x1BD2560 Slot: 2
	public override int GetHashCode() { }
}

