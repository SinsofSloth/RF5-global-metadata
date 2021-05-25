internal class BasicClient : IAuthenticationModule // TypeDefIndex: 1957
{
	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x28F3630 Offset: 0x28F3731 VA: 0x28F3630 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x28F3B10 Offset: 0x28F3C11 VA: 0x28F3B10
	private static byte[] GetBytes(string str) { }

	// RVA: 0x28F36F0 Offset: 0x28F37F1 VA: 0x28F36F0
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x28F3BE0 Offset: 0x28F3CE1 VA: 0x28F3BE0 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x28F3BF0 Offset: 0x28F3CF1 VA: 0x28F3BF0 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x28F28D0 Offset: 0x28F29D1 VA: 0x28F28D0
	public void .ctor() { }
}

