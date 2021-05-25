[Serializable]
public sealed class Cookie // TypeDefIndex: 1928
{
	// Fields
	internal static readonly char[] PortSplitDelimiters; // 0x0
	internal static readonly char[] Reserved2Name; // 0x8
	internal static readonly char[] Reserved2Value; // 0x10
	private static Comparer staticComparer; // 0x18
	private string m_comment; // 0x10
	private Uri m_commentUri; // 0x18
	private CookieVariant m_cookieVariant; // 0x20
	private bool m_discard; // 0x24
	private string m_domain; // 0x28
	private bool m_domain_implicit; // 0x30
	private DateTime m_expires; // 0x38
	private string m_name; // 0x40
	private string m_path; // 0x48
	private bool m_path_implicit; // 0x50
	private string m_port; // 0x58
	private bool m_port_implicit; // 0x60
	private int[] m_port_list; // 0x68
	private bool m_secure; // 0x70
	[OptionalFieldAttribute] // RVA: 0xBCF10 Offset: 0xBD011 VA: 0xBCF10
	private bool m_httpOnly; // 0x71
	private DateTime m_timeStamp; // 0x78
	private string m_value; // 0x80
	private int m_version; // 0x88
	private string m_domainKey; // 0x90
	internal bool IsQuotedVersion; // 0x98
	internal bool IsQuotedDomain; // 0x99

	// Properties
	public string Comment { get; set; }
	public Uri CommentUri { set; }
	public bool HttpOnly { set; }
	public bool Discard { set; }
	public string Domain { get; set; }
	private string _Domain { get; }
	public bool Expired { get; }
	public DateTime Expires { set; }
	public string Name { get; }
	public string Path { get; set; }
	private string _Path { get; }
	internal bool Plain { get; }
	public string Port { set; }
	internal int[] PortList { get; }
	private string _Port { get; }
	public bool Secure { get; set; }
	public string Value { get; set; }
	internal CookieVariant Variant { get; }
	internal string DomainKey { get; }
	public int Version { get; set; }
	private string _Version { get; }

	// Methods

	// RVA: 0x28F52E0 Offset: 0x28F53E1 VA: 0x28F52E0
	public void .ctor() { }

	// RVA: 0x28F5440 Offset: 0x28F5541 VA: 0x28F5440
	public string get_Comment() { }

	// RVA: 0x28F5450 Offset: 0x28F5551 VA: 0x28F5450
	public void set_Comment(string value) { }

	// RVA: 0x28F54C0 Offset: 0x28F55C1 VA: 0x28F54C0
	public void set_CommentUri(Uri value) { }

	// RVA: 0x28F54D0 Offset: 0x28F55D1 VA: 0x28F54D0
	public void set_HttpOnly(bool value) { }

	// RVA: 0x28F54E0 Offset: 0x28F55E1 VA: 0x28F54E0
	public void set_Discard(bool value) { }

	// RVA: 0x28F54F0 Offset: 0x28F55F1 VA: 0x28F54F0
	public string get_Domain() { }

	// RVA: 0x28F5500 Offset: 0x28F5601 VA: 0x28F5500
	public void set_Domain(string value) { }

	// RVA: 0x28F55B0 Offset: 0x28F56B1 VA: 0x28F55B0
	private string get__Domain() { }

	// RVA: 0x28F5690 Offset: 0x28F5791 VA: 0x28F5690
	public bool get_Expired() { }

	// RVA: 0x28F5770 Offset: 0x28F5871 VA: 0x28F5770
	public void set_Expires(DateTime value) { }

	// RVA: 0x28F5780 Offset: 0x28F5881 VA: 0x28F5780
	public string get_Name() { }

	// RVA: 0x28F5790 Offset: 0x28F5891 VA: 0x28F5790
	internal bool InternalSetName(string value) { }

	// RVA: 0x28F58D0 Offset: 0x28F59D1 VA: 0x28F58D0
	public string get_Path() { }

	// RVA: 0x28F58E0 Offset: 0x28F59E1 VA: 0x28F58E0
	public void set_Path(string value) { }

	// RVA: 0x28F5970 Offset: 0x28F5A71 VA: 0x28F5970
	private string get__Path() { }

	// RVA: 0x28F5680 Offset: 0x28F5781 VA: 0x28F5680
	internal bool get_Plain() { }

	// RVA: 0x28F5A10 Offset: 0x28F5B11 VA: 0x28F5A10
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x28F5A80 Offset: 0x28F5B81 VA: 0x28F5A80
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x28F6640 Offset: 0x28F6741 VA: 0x28F6640
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x28F6700 Offset: 0x28F6801 VA: 0x28F6700
	public void set_Port(string value) { }

	// RVA: 0x28F6A60 Offset: 0x28F6B61 VA: 0x28F6A60
	internal int[] get_PortList() { }

	// RVA: 0x28F6A70 Offset: 0x28F6B71 VA: 0x28F6A70
	private string get__Port() { }

	// RVA: 0x28F6B30 Offset: 0x28F6C31 VA: 0x28F6B30
	public bool get_Secure() { }

	// RVA: 0x28F6B40 Offset: 0x28F6C41 VA: 0x28F6B40
	public void set_Secure(bool value) { }

	// RVA: 0x28F6B50 Offset: 0x28F6C51 VA: 0x28F6B50
	public string get_Value() { }

	// RVA: 0x28F6B60 Offset: 0x28F6C61 VA: 0x28F6B60
	public void set_Value(string value) { }

	// RVA: 0x28F6BE0 Offset: 0x28F6CE1 VA: 0x28F6BE0
	internal CookieVariant get_Variant() { }

	// RVA: 0x28F6BF0 Offset: 0x28F6CF1 VA: 0x28F6BF0
	internal string get_DomainKey() { }

	// RVA: 0x28F6C10 Offset: 0x28F6D11 VA: 0x28F6C10
	public int get_Version() { }

	// RVA: 0x28F6C20 Offset: 0x28F6D21 VA: 0x28F6C20
	public void set_Version(int value) { }

	// RVA: 0x28F6CD0 Offset: 0x28F6DD1 VA: 0x28F6CD0
	private string get__Version() { }

	// RVA: 0x28F6DD0 Offset: 0x28F6ED1 VA: 0x28F6DD0
	internal static IComparer GetComparer() { }

	// RVA: 0x28F6E40 Offset: 0x28F6F41 VA: 0x28F6E40 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x28F6F90 Offset: 0x28F7091 VA: 0x28F6F90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x28F72A0 Offset: 0x28F73A1 VA: 0x28F72A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x28F78D0 Offset: 0x28F79D1 VA: 0x28F78D0
	private static void .cctor() { }
}

