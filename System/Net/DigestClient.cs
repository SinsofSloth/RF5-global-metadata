internal class DigestClient : IAuthenticationModule // TypeDefIndex: 1963
{
	// Fields
	private static readonly Hashtable cache; // 0x0

	// Properties
	private static Hashtable Cache { get; }
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x177A500 Offset: 0x177A601 VA: 0x177A500
	private static Hashtable get_Cache() { }

	// RVA: 0x177A670 Offset: 0x177A771 VA: 0x177A670
	private static void CheckExpired(int count) { }

	// RVA: 0x177AE90 Offset: 0x177AF91 VA: 0x177AE90 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x177B8C0 Offset: 0x177B9C1 VA: 0x177B8C0 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x177BA40 Offset: 0x177BB41 VA: 0x177BA40 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x177BA90 Offset: 0x177BB91 VA: 0x177BA90
	public void .ctor() { }

	// RVA: 0x177BAA0 Offset: 0x177BBA1 VA: 0x177BAA0
	private static void .cctor() { }
}

