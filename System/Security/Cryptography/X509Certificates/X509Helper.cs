internal static class X509Helper // TypeDefIndex: 994
{
	// Fields
	private static INativeCertificateHelper nativeHelper; // 0x0

	// Methods

	// RVA: 0x263D4C0 Offset: 0x263D5C1 VA: 0x263D4C0
	internal static void InstallNativeHelper(INativeCertificateHelper helper) { }

	// RVA: 0x263D530 Offset: 0x263D631 VA: 0x263D530
	private static X509CertificateImpl Import(byte[] rawData) { }

	// RVA: 0x263B730 Offset: 0x263B831 VA: 0x263B730
	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	// RVA: 0x263B530 Offset: 0x263B631 VA: 0x263B530
	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	// RVA: 0x263B9C0 Offset: 0x263BAC1 VA: 0x263B9C0
	public static bool IsValid(X509CertificateImpl impl) { }

	// RVA: 0x263B930 Offset: 0x263BA31 VA: 0x263B930
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x263C860 Offset: 0x263C961 VA: 0x263C860
	internal static Exception GetInvalidContextException() { }

	// RVA: 0x263D720 Offset: 0x263D821 VA: 0x263D720
	internal static X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	// RVA: 0x263DCC0 Offset: 0x263DDC1 VA: 0x263DCC0
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x263E040 Offset: 0x263E141 VA: 0x263E040
	private static byte[] ConvertData(byte[] data) { }

	// RVA: 0x263D540 Offset: 0x263D641 VA: 0x263D540
	private static X509CertificateImpl ImportCore(byte[] rawData) { }

	// RVA: 0x263C440 Offset: 0x263C541 VA: 0x263C440
	public static X509CertificateImpl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x263BCF0 Offset: 0x263BDF1 VA: 0x263BCF0
	public static string ToHexString(byte[] data) { }
}

