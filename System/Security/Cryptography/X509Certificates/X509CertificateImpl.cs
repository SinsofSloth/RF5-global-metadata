internal abstract class X509CertificateImpl : IDisposable // TypeDefIndex: 992
{
	// Fields
	private byte[] cachedCertificateHash; // 0x10

	// Properties
	public abstract bool IsValid { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid() { }

	// RVA: 0x263C7F0 Offset: 0x263C8F1 VA: 0x263C7F0
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509CertificateImpl Clone() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string GetIssuerName(bool legacyV1Mode) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string GetSubjectName(bool legacyV1Mode) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract byte[] GetRawCertData() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DateTime GetValidFrom() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DateTime GetValidUntil() { }

	// RVA: 0x263BC20 Offset: 0x263BD21 VA: 0x263BC20
	public byte[] GetCertHash() { }

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract byte[] GetCertHash(bool lazy) { }

	// RVA: 0x263C8E0 Offset: 0x263C9E1 VA: 0x263C8E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool Equals(X509CertificateImpl other, out bool result) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract byte[] GetSerialNumber() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string ToString(bool full) { }

	// RVA: 0x263C990 Offset: 0x263CA91 VA: 0x263C990 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x263C770 Offset: 0x263C871 VA: 0x263C770 Slot: 4
	public void Dispose() { }

	// RVA: 0x263CBB0 Offset: 0x263CCB1 VA: 0x263CBB0 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x263CBC0 Offset: 0x263CCC1 VA: 0x263CBC0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x263CC40 Offset: 0x263CD41 VA: 0x263CC40
	protected void .ctor() { }
}

