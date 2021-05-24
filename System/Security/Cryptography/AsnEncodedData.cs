public class AsnEncodedData // TypeDefIndex: 1830
{
	// Fields
	internal Oid _oid; // 0x10
	internal byte[] _raw; // 0x18

	// Properties
	public Oid Oid { set; }
	public byte[] RawData { get; set; }

	// Methods

	// RVA: 0x170E970 Offset: 0x170EA71 VA: 0x170E970
	protected void .ctor() { }

	// RVA: 0x170E980 Offset: 0x170EA81 VA: 0x170E980
	public void .ctor(Oid oid, byte[] rawData) { }

	// RVA: 0x170EA80 Offset: 0x170EB81 VA: 0x170EA80
	public void set_Oid(Oid value) { }

	// RVA: 0x170ECC0 Offset: 0x170EDC1 VA: 0x170ECC0
	public byte[] get_RawData() { }

	// RVA: 0x170EB20 Offset: 0x170EC21 VA: 0x170EB20
	public void set_RawData(byte[] value) { }

	// RVA: 0x170ECD0 Offset: 0x170EDD1 VA: 0x170ECD0 Slot: 4
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x170EE60 Offset: 0x170EF61 VA: 0x170EE60 Slot: 5
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x170FF70 Offset: 0x1710071 VA: 0x170FF70
	internal string Default(bool multiLine) { }

	// RVA: 0x170F000 Offset: 0x170F101 VA: 0x170F000
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x170F140 Offset: 0x170F241 VA: 0x170F140
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x170F280 Offset: 0x170F381 VA: 0x170F280
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x170F3C0 Offset: 0x170F4C1 VA: 0x170F3C0
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x170F500 Offset: 0x170F601 VA: 0x170F500
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x170FC00 Offset: 0x170FD01 VA: 0x170FC00
	internal string NetscapeCertType(bool multiLine) { }
}

