internal class DigestHeaderParser // TypeDefIndex: 1961
{
	// Fields
	private string header; // 0x10
	private int length; // 0x18
	private int pos; // 0x1C
	private static string[] keywords; // 0x0
	private string[] values; // 0x20

	// Properties
	public string Realm { get; }
	public string Opaque { get; }
	public string Nonce { get; }
	public string Algorithm { get; }
	public string QOP { get; }

	// Methods

	// RVA: 0x177BB20 Offset: 0x177BC21 VA: 0x177BB20
	public void .ctor(string header) { }

	// RVA: 0x177BBF0 Offset: 0x177BCF1 VA: 0x177BBF0
	public string get_Realm() { }

	// RVA: 0x177BC30 Offset: 0x177BD31 VA: 0x177BC30
	public string get_Opaque() { }

	// RVA: 0x177BC70 Offset: 0x177BD71 VA: 0x177BC70
	public string get_Nonce() { }

	// RVA: 0x177BCB0 Offset: 0x177BDB1 VA: 0x177BCB0
	public string get_Algorithm() { }

	// RVA: 0x177BCF0 Offset: 0x177BDF1 VA: 0x177BCF0
	public string get_QOP() { }

	// RVA: 0x177BD30 Offset: 0x177BE31 VA: 0x177BD30
	public bool Parse() { }

	// RVA: 0x177C210 Offset: 0x177C311 VA: 0x177C210
	private void SkipWhitespace() { }

	// RVA: 0x177C2A0 Offset: 0x177C3A1 VA: 0x177C2A0
	private string GetKey() { }

	// RVA: 0x177BFA0 Offset: 0x177C0A1 VA: 0x177BFA0
	private bool GetKeywordAndValue(out string key, out string value) { }

	// RVA: 0x177C3A0 Offset: 0x177C4A1 VA: 0x177C3A0
	private static void .cctor() { }
}

