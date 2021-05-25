internal class DigestSession // TypeDefIndex: 1962
{
	// Fields
	private static RandomNumberGenerator rng; // 0x0
	private DateTime lastUse; // 0x10
	private int _nc; // 0x18
	private HashAlgorithm hash; // 0x20
	private DigestHeaderParser parser; // 0x28
	private string _cnonce; // 0x30

	// Properties
	public string Algorithm { get; }
	public string Realm { get; }
	public string Nonce { get; }
	public string Opaque { get; }
	public string QOP { get; }
	public string CNonce { get; }
	public DateTime LastUse { get; }

	// Methods

	// RVA: 0x177C5B0 Offset: 0x177C6B1 VA: 0x177C5B0
	private static void .cctor() { }

	// RVA: 0x177B1A0 Offset: 0x177B2A1 VA: 0x177B1A0
	public void .ctor() { }

	// RVA: 0x177C610 Offset: 0x177C711 VA: 0x177C610
	public string get_Algorithm() { }

	// RVA: 0x177C650 Offset: 0x177C751 VA: 0x177C650
	public string get_Realm() { }

	// RVA: 0x177B340 Offset: 0x177B441 VA: 0x177B340
	public string get_Nonce() { }

	// RVA: 0x177C690 Offset: 0x177C791 VA: 0x177C690
	public string get_Opaque() { }

	// RVA: 0x177C6D0 Offset: 0x177C7D1 VA: 0x177C6D0
	public string get_QOP() { }

	// RVA: 0x177C710 Offset: 0x177C811 VA: 0x177C710
	public string get_CNonce() { }

	// RVA: 0x177B220 Offset: 0x177B321 VA: 0x177B220
	public bool Parse(string challenge) { }

	// RVA: 0x177C830 Offset: 0x177C931 VA: 0x177C830
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x177C9B0 Offset: 0x177CAB1 VA: 0x177C9B0
	private string HA1(string username, string password) { }

	// RVA: 0x177CAF0 Offset: 0x177CBF1 VA: 0x177CAF0
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x177CBE0 Offset: 0x177CCE1 VA: 0x177CBE0
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x177B380 Offset: 0x177B481 VA: 0x177B380
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x177CD60 Offset: 0x177CE61 VA: 0x177CD60
	public DateTime get_LastUse() { }
}

