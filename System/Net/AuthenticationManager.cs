public class AuthenticationManager // TypeDefIndex: 1956
{
	// Fields
	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Methods

	// RVA: 0x28F2670 Offset: 0x28F2771 VA: 0x28F2670
	private static void EnsureModules() { }

	// RVA: 0x28F28E0 Offset: 0x28F29E1 VA: 0x28F28E0
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x28F29E0 Offset: 0x28F2AE1 VA: 0x28F29E0
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x28F2EC0 Offset: 0x28F2FC1 VA: 0x28F2EC0
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x28F33E0 Offset: 0x28F34E1 VA: 0x28F33E0
	private static void .cctor() { }
}

