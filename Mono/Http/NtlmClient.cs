internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 1731
{
	// Fields
	private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache; // 0x0

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x16E76A0 Offset: 0x16E77A1 VA: 0x16E76A0 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x16E7E80 Offset: 0x16E7F81 VA: 0x16E7E80 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x16E7E90 Offset: 0x16E7F91 VA: 0x16E7E90 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x16E7EE0 Offset: 0x16E7FE1 VA: 0x16E7EE0
	public void .ctor() { }

	// RVA: 0x16E7EF0 Offset: 0x16E7FF1 VA: 0x16E7EF0
	private static void .cctor() { }
}

