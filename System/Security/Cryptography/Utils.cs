internal static class Utils // TypeDefIndex: 976
{
	// Fields
	private static RNGCryptoServiceProvider _rng; // 0x0

	// Properties
	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator { get; }

	// Methods

	// RVA: 0x2631030 Offset: 0x2631131 VA: 0x2631030
	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	// RVA: 0x262E2E0 Offset: 0x262E3E1 VA: 0x262E2E0
	internal static byte[] GenerateRandom(int keySize) { }

	// RVA: 0x263A220 Offset: 0x263A321 VA: 0x263A220
	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	// RVA: 0x263AB30 Offset: 0x263AC31 VA: 0x263AB30
	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	// RVA: 0x263AB50 Offset: 0x263AC51 VA: 0x263AB50
	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x263B080 Offset: 0x263B181 VA: 0x263B080
	internal static int ConvertByteArrayToInt(byte[] input) { }

	// RVA: 0x263B0F0 Offset: 0x263B1F1 VA: 0x263B0F0
	internal static byte[] ConvertIntToByteArray(int dwInput) { }

	// RVA: 0x2639DF0 Offset: 0x2639EF1 VA: 0x2639DF0
	internal static byte[] FixupKeyParity(byte[] key) { }

	// RVA: 0x263B250 Offset: 0x263B351 VA: 0x263B250
	internal static void DWORDFromLittleEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x263B2A0 Offset: 0x263B3A1 VA: 0x263B2A0
	internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x2633FC0 Offset: 0x26340C1 VA: 0x2633FC0
	internal static void DWORDFromBigEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x2633EB0 Offset: 0x2633FB1 VA: 0x2633EB0
	internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x26369A0 Offset: 0x2636AA1 VA: 0x26369A0
	internal static void QuadWordFromBigEndian(ulong* x, int digits, byte* block) { }

	// RVA: 0x26367E0 Offset: 0x26368E1 VA: 0x26367E0
	internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits) { }

	// RVA: 0x263B3B0 Offset: 0x263B4B1 VA: 0x263B3B0
	internal static bool _ProduceLegacyHmacValues() { }
}

