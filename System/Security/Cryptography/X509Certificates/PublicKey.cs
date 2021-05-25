public sealed class PublicKey // TypeDefIndex: 1839
{
	// Fields
	private AsymmetricAlgorithm _key; // 0x10
	private AsnEncodedData _keyValue; // 0x18
	private AsnEncodedData _params; // 0x20
	private Oid _oid; // 0x28
	private static byte[] Empty; // 0x0

	// Properties
	public AsnEncodedData EncodedKeyValue { get; }
	public AsnEncodedData EncodedParameters { get; }
	public AsymmetricAlgorithm Key { get; }
	public Oid Oid { get; }

	// Methods

	// RVA: 0x1711DA0 Offset: 0x1711EA1 VA: 0x1711DA0
	internal void .ctor(X509Certificate certificate) { }

	// RVA: 0x17121E0 Offset: 0x17122E1 VA: 0x17121E0
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x17121F0 Offset: 0x17122F1 VA: 0x17121F0
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x1712200 Offset: 0x1712301 VA: 0x1712200
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x1712E60 Offset: 0x1712F61 VA: 0x1712E60
	public Oid get_Oid() { }

	// RVA: 0x1712E70 Offset: 0x1712F71 VA: 0x1712E70
	private static byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x1712870 Offset: 0x1712971 VA: 0x1712870
	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters) { }

	// RVA: 0x17123D0 Offset: 0x17124D1 VA: 0x17123D0
	internal static RSA DecodeRSA(byte[] rawPublicKey) { }

	// RVA: 0x1712F20 Offset: 0x1713021 VA: 0x1712F20
	private static void .cctor() { }
}

