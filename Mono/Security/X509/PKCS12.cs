internal class PKCS12 : ICloneable // TypeDefIndex: 51
{
	// Fields
	private byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Properties
	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }

	// Methods

	// RVA: 0x18FB3F0 Offset: 0x18FB4F1 VA: 0x18FB3F0
	public void .ctor() { }

	// RVA: 0x18FB500 Offset: 0x18FB601 VA: 0x18FB500
	public void .ctor(byte[] data) { }

	// RVA: 0x18FBEC0 Offset: 0x18FBFC1 VA: 0x18FBEC0
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x18FB7E0 Offset: 0x18FB8E1 VA: 0x18FB7E0
	private void Decode(byte[] data) { }

	// RVA: 0x18FCA00 Offset: 0x18FCB01 VA: 0x18FCA00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18FB590 Offset: 0x18FB691 VA: 0x18FB590
	public void set_Password(string value) { }

	// RVA: 0x18FCAA0 Offset: 0x18FCBA1 VA: 0x18FCAA0
	public int get_IterationCount() { }

	// RVA: 0x18FCAB0 Offset: 0x18FCBB1 VA: 0x18FCAB0
	public void set_IterationCount(int value) { }

	// RVA: 0x18FCAC0 Offset: 0x18FCBC1 VA: 0x18FCAC0
	public ArrayList get_Keys() { }

	// RVA: 0x18FD640 Offset: 0x18FD741 VA: 0x18FD640
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x18FDD10 Offset: 0x18FDE11 VA: 0x18FDD10
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x18FC0A0 Offset: 0x18FC1A1 VA: 0x18FC0A0
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x18FDD60 Offset: 0x18FDE61 VA: 0x18FDD60
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x18FD490 Offset: 0x18FD591 VA: 0x18FD490
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x18FC8F0 Offset: 0x18FC9F1 VA: 0x18FC8F0
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x18FE700 Offset: 0x18FE801 VA: 0x18FE700
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x18FE900 Offset: 0x18FEA01 VA: 0x18FE900
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x18FF1C0 Offset: 0x18FF2C1 VA: 0x18FF1C0
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x18FC130 Offset: 0x18FC231 VA: 0x18FC130
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x18FF400 Offset: 0x18FF501 VA: 0x18FF400
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x18FBF10 Offset: 0x18FC011 VA: 0x18FBF10
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x1900360 Offset: 0x1900461 VA: 0x1900360
	public byte[] GetBytes() { }

	// RVA: 0x1902DC0 Offset: 0x1902EC1 VA: 0x1902DC0
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x1902DB0 Offset: 0x1902EB1 VA: 0x1902DB0
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x1903110 Offset: 0x1903211 VA: 0x1903110
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x1902DA0 Offset: 0x1902EA1 VA: 0x1902DA0
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x1903400 Offset: 0x1903501 VA: 0x1903400
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x19039A0 Offset: 0x1903AA1 VA: 0x19039A0 Slot: 4
	public object Clone() { }

	// RVA: 0x1903AE0 Offset: 0x1903BE1 VA: 0x1903AE0
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x1903B50 Offset: 0x1903C51 VA: 0x1903B50
	private static void .cctor() { }
}

public class PKCS12 : ICloneable // TypeDefIndex: 1555
{
	// Fields
	private byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Properties
	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }

	// Methods

	// RVA: 0x1A73020 Offset: 0x1A73121 VA: 0x1A73020
	public void .ctor() { }

	// RVA: 0x1A73120 Offset: 0x1A73221 VA: 0x1A73120
	public void .ctor(byte[] data) { }

	// RVA: 0x1A73AB0 Offset: 0x1A73BB1 VA: 0x1A73AB0
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x1A73400 Offset: 0x1A73501 VA: 0x1A73400
	private void Decode(byte[] data) { }

	// RVA: 0x1A74620 Offset: 0x1A74721 VA: 0x1A74620 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A731B0 Offset: 0x1A732B1 VA: 0x1A731B0
	public void set_Password(string value) { }

	// RVA: 0x1A746C0 Offset: 0x1A747C1 VA: 0x1A746C0
	public int get_IterationCount() { }

	// RVA: 0x1A746D0 Offset: 0x1A747D1 VA: 0x1A746D0
	public void set_IterationCount(int value) { }

	// RVA: 0x1A746E0 Offset: 0x1A747E1 VA: 0x1A746E0
	public ArrayList get_Keys() { }

	// RVA: 0x1A75250 Offset: 0x1A75351 VA: 0x1A75250
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1A756B0 Offset: 0x1A757B1 VA: 0x1A756B0
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x1A73C90 Offset: 0x1A73D91 VA: 0x1A73C90
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x1A75700 Offset: 0x1A75801 VA: 0x1A75700
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x1A750A0 Offset: 0x1A751A1 VA: 0x1A750A0
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x1A74520 Offset: 0x1A74621 VA: 0x1A74520
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x1A75F70 Offset: 0x1A76071 VA: 0x1A75F70
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x1A76170 Offset: 0x1A76271 VA: 0x1A76170
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x1A76400 Offset: 0x1A76501 VA: 0x1A76400
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x1A73D20 Offset: 0x1A73E21 VA: 0x1A73D20
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x1A76640 Offset: 0x1A76741 VA: 0x1A76640
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x1A73B00 Offset: 0x1A73C01 VA: 0x1A73B00
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x1A77990 Offset: 0x1A77A91 VA: 0x1A77990
	public byte[] GetBytes() { }

	// RVA: 0x1A7A640 Offset: 0x1A7A741 VA: 0x1A7A640
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x1A7A630 Offset: 0x1A7A731 VA: 0x1A7A630
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x1A7ADE0 Offset: 0x1A7AEE1 VA: 0x1A7ADE0
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x1A7A620 Offset: 0x1A7A721 VA: 0x1A7A620
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x1A7B0C0 Offset: 0x1A7B1C1 VA: 0x1A7B0C0
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x1A7B670 Offset: 0x1A7B771 VA: 0x1A7B670 Slot: 4
	public object Clone() { }

	// RVA: 0x1A7B7B0 Offset: 0x1A7B8B1 VA: 0x1A7B7B0
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x1A7B820 Offset: 0x1A7B921 VA: 0x1A7B820
	private static void .cctor() { }
}

