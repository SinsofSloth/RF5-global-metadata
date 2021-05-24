public static class ChallengeResponse2 // TypeDefIndex: 1564
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0x1A6F890 Offset: 0x1A6F991 VA: 0x1A6F890
	private static byte[] Compute_LM(string password, byte[] challenge) { }

	// RVA: 0x1A70070 Offset: 0x1A70171 VA: 0x1A70070
	private static byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0x1A701C0 Offset: 0x1A702C1 VA: 0x1A701C0
	private static byte[] Compute_NTLM(string password, byte[] challenge) { }

	// RVA: 0x1A70240 Offset: 0x1A70341 VA: 0x1A70240
	private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1A70480 Offset: 0x1A70581 VA: 0x1A70480
	private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0x1A70AF0 Offset: 0x1A70BF1 VA: 0x1A70AF0
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1A6FD70 Offset: 0x1A6FE71 VA: 0x1A6FD70
	private static byte[] GetResponse(byte[] challenge, byte[] pwd) { }

	// RVA: 0x1A70F20 Offset: 0x1A71021 VA: 0x1A70F20
	private static byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1A6FC00 Offset: 0x1A6FD01 VA: 0x1A6FC00
	private static byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1A71130 Offset: 0x1A71231 VA: 0x1A71130
	private static void .cctor() { }
}

