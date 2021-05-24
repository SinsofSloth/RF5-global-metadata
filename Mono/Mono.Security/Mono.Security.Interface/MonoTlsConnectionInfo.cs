public class MonoTlsConnectionInfo // TypeDefIndex: 1581
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBAD00 Offset: 0xBAE01 VA: 0xBAD00
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBAD10 Offset: 0xBAE11 VA: 0xBAD10
	private TlsProtocols <ProtocolVersion>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0xBAD20 Offset: 0xBAE21 VA: 0xBAD20
	private string <PeerDomainName>k__BackingField; // 0x18

	// Properties
	[CLSCompliantAttribute] // RVA: 0xBB100 Offset: 0xBB201 VA: 0xBB100
	public CipherSuiteCode CipherSuiteCode { get; set; }
	public TlsProtocols ProtocolVersion { get; set; }
	public string PeerDomainName { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xBADD0 Offset: 0xBAED1 VA: 0xBADD0
	// RVA: 0x1A6D590 Offset: 0x1A6D691 VA: 0x1A6D590
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CompilerGeneratedAttribute] // RVA: 0xBADE0 Offset: 0xBAEE1 VA: 0xBADE0
	// RVA: 0x1A6D5A0 Offset: 0x1A6D6A1 VA: 0x1A6D5A0
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBADF0 Offset: 0xBAEF1 VA: 0xBADF0
	// RVA: 0x1A6D5B0 Offset: 0x1A6D6B1 VA: 0x1A6D5B0
	public TlsProtocols get_ProtocolVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0xBAE00 Offset: 0xBAF01 VA: 0xBAE00
	// RVA: 0x1A6D5C0 Offset: 0x1A6D6C1 VA: 0x1A6D5C0
	public void set_ProtocolVersion(TlsProtocols value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBAE10 Offset: 0xBAF11 VA: 0xBAE10
	// RVA: 0x1A6D5D0 Offset: 0x1A6D6D1 VA: 0x1A6D5D0
	public void set_PeerDomainName(string value) { }

	// RVA: 0x1A6D5E0 Offset: 0x1A6D6E1 VA: 0x1A6D5E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A6D680 Offset: 0x1A6D781 VA: 0x1A6D680
	public void .ctor() { }
}

