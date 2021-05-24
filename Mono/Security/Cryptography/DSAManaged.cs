internal class DSAManaged : DSA // TypeDefIndex: 74
{
	// Fields
	private bool keypairGenerated; // 0x20
	private bool m_disposed; // 0x21
	private BigInteger p; // 0x28
	private BigInteger q; // 0x30
	private BigInteger g; // 0x38
	private BigInteger x; // 0x40
	private BigInteger y; // 0x48
	private BigInteger j; // 0x50
	private BigInteger seed; // 0x58
	private int counter; // 0x60
	private bool j_missing; // 0x64
	private RandomNumberGenerator rng; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0xB4200 Offset: 0xB4301 VA: 0xB4200
	private DSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x70

	// Properties
	private RandomNumberGenerator Random { get; }
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x18EF970 Offset: 0x18EFA71 VA: 0x18EF970
	public void .ctor(int dwKeySize) { }

	// RVA: 0x18EFA70 Offset: 0x18EFB71 VA: 0x18EFA70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18EFAF0 Offset: 0x18EFBF1 VA: 0x18EFAF0
	private void Generate() { }

	// RVA: 0x18F01C0 Offset: 0x18F02C1 VA: 0x18F01C0
	private void GenerateKeyPair() { }

	// RVA: 0x18F0720 Offset: 0x18F0821 VA: 0x18F0720
	private void add(byte[] a, byte[] b, int value) { }

	// RVA: 0x18EFB40 Offset: 0x18EFC41 VA: 0x18EFB40
	private void GenerateParams(int keyLength) { }

	// RVA: 0x18F07D0 Offset: 0x18F08D1 VA: 0x18F07D0
	private RandomNumberGenerator get_Random() { }

	// RVA: 0x18F0820 Offset: 0x18F0921 VA: 0x18F0820 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x18F0850 Offset: 0x18F0951 VA: 0x18F0850
	public bool get_PublicOnly() { }

	// RVA: 0x18F08E0 Offset: 0x18F09E1 VA: 0x18F08E0
	private byte[] NormalizeArray(byte[] array) { }

	// RVA: 0x18F09A0 Offset: 0x18F0AA1 VA: 0x18F09A0 Slot: 10
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x18F1060 Offset: 0x18F1161 VA: 0x18F1060 Slot: 11
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x18F13D0 Offset: 0x18F14D1 VA: 0x18F13D0 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGeneratedAttribute] // RVA: 0xB5640 Offset: 0xB5741 VA: 0xB5640
	// RVA: 0x18F1690 Offset: 0x18F1791 VA: 0x18F1690
	public void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0xB5650 Offset: 0xB5751 VA: 0xB5650
	// RVA: 0x18F1740 Offset: 0x18F1841 VA: 0x18F1740
	public void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }
}

