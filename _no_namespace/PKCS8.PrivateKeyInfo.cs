public class PKCS8.PrivateKeyInfo // TypeDefIndex: 68
{
	// Fields
	private int _version; // 0x10
	private string _algorithm; // 0x18
	private byte[] _key; // 0x20
	private ArrayList _list; // 0x28

	// Properties
	public byte[] PrivateKey { get; }

	// Methods

	// RVA: 0x18F5AB0 Offset: 0x18F5BB1 VA: 0x18F5AB0
	public void .ctor() { }

	// RVA: 0x18F5B30 Offset: 0x18F5C31 VA: 0x18F5B30
	public void .ctor(byte[] data) { }

	// RVA: 0x18F5E30 Offset: 0x18F5F31 VA: 0x18F5E30
	public byte[] get_PrivateKey() { }

	// RVA: 0x18F5BC0 Offset: 0x18F5CC1 VA: 0x18F5BC0
	private void Decode(byte[] data) { }

	// RVA: 0x18F5EB0 Offset: 0x18F5FB1 VA: 0x18F5EB0
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x18F5F60 Offset: 0x18F6061 VA: 0x18F5F60
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x18F6020 Offset: 0x18F6121 VA: 0x18F6020
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x18F6A30 Offset: 0x18F6B31 VA: 0x18F6A30
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }
}

public class PKCS8.PrivateKeyInfo // TypeDefIndex: 1596
{
	// Fields
	private int _version; // 0x10
	private string _algorithm; // 0x18
	private byte[] _key; // 0x20
	private ArrayList _list; // 0x28

	// Properties
	public byte[] PrivateKey { get; }

	// Methods

	// RVA: 0x1A69960 Offset: 0x1A69A61 VA: 0x1A69960
	public void .ctor() { }

	// RVA: 0x1A699E0 Offset: 0x1A69AE1 VA: 0x1A699E0
	public void .ctor(byte[] data) { }

	// RVA: 0x1A69CD0 Offset: 0x1A69DD1 VA: 0x1A69CD0
	public byte[] get_PrivateKey() { }

	// RVA: 0x1A69A70 Offset: 0x1A69B71 VA: 0x1A69A70
	private void Decode(byte[] data) { }

	// RVA: 0x1A69D50 Offset: 0x1A69E51 VA: 0x1A69D50
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x1A69E00 Offset: 0x1A69F01 VA: 0x1A69E00
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x1A69EC0 Offset: 0x1A69FC1 VA: 0x1A69EC0
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x1A6A8A0 Offset: 0x1A6A9A1 VA: 0x1A6A8A0
	public static byte[] Encode(RSA rsa) { }

	// RVA: 0x1A6AE80 Offset: 0x1A6AF81 VA: 0x1A6AE80
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0x1A6B0D0 Offset: 0x1A6B1D1 VA: 0x1A6B0D0
	public static byte[] Encode(DSA dsa) { }

	// RVA: 0x1A6B120 Offset: 0x1A6B221 VA: 0x1A6B120
	public static byte[] Encode(AsymmetricAlgorithm aa) { }
}

