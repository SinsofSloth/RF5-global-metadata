internal class RSAManaged : RSA // TypeDefIndex: 71
{
	// Fields
	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0xB41F0 Offset: 0xB42F1 VA: 0xB41F0
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x18F6F30 Offset: 0x18F7031 VA: 0x18F6F30
	public void .ctor(int keySize) { }

	// RVA: 0x18F7040 Offset: 0x18F7141 VA: 0x18F7040 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18F70C0 Offset: 0x18F71C1 VA: 0x18F70C0
	private void GenerateKeyPair() { }

	// RVA: 0x18F7870 Offset: 0x18F7971 VA: 0x18F7870 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x18F7940 Offset: 0x18F7A41 VA: 0x18F7940
	public bool get_PublicOnly() { }

	// RVA: 0x18F7A20 Offset: 0x18F7B21 VA: 0x18F7A20 Slot: 10
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x18F7EE0 Offset: 0x18F7FE1 VA: 0x18F7EE0 Slot: 11
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x18F8510 Offset: 0x18F8611 VA: 0x18F8510 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGeneratedAttribute] // RVA: 0xB5620 Offset: 0xB5721 VA: 0xB5620
	// RVA: 0x18F8830 Offset: 0x18F8931 VA: 0x18F8830
	public void add_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB5630 Offset: 0xB5731 VA: 0xB5630
	// RVA: 0x18F88E0 Offset: 0x18F89E1 VA: 0x18F88E0
	public void remove_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	// RVA: 0x18F8990 Offset: 0x18F8A91 VA: 0x18F8990 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x18F7E10 Offset: 0x18F7F11 VA: 0x18F7E10
	private byte[] GetPaddedValue(BigInteger value, int length) { }
}

public class RSAManaged : RSA // TypeDefIndex: 1598
{
	// Fields
	private bool isCRTpossible; // 0x20
	private bool keypairGenerated; // 0x21
	private bool m_disposed; // 0x22
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0xBADC0 Offset: 0xBAEC1 VA: 0xBADC0
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1A6B270 Offset: 0x1A6B371 VA: 0x1A6B270
	private void GenerateKeyPair() { }

	// RVA: 0x1A6BC40 Offset: 0x1A6BD41 VA: 0x1A6BC40
	public bool get_PublicOnly() { }

	// RVA: 0x1A6BD20 Offset: 0x1A6BE21 VA: 0x1A6BD20 Slot: 10
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1A6C1A0 Offset: 0x1A6C2A1 VA: 0x1A6C1A0 Slot: 11
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1A6C0E0 Offset: 0x1A6C1E1 VA: 0x1A6C0E0
	private byte[] GetPaddedValue(BigInteger value, int length) { }
}

