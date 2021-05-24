[Serializable]
public class CookieContainer // TypeDefIndex: 1938
{
	// Fields
	private static readonly HeaderVariantInfo[] HeaderInfo; // 0x0
	private Hashtable m_domainTable; // 0x10
	private int m_maxCookieSize; // 0x18
	private int m_maxCookies; // 0x1C
	private int m_maxCookiesPerDomain; // 0x20
	private int m_count; // 0x24
	private string m_fqdnMyDomain; // 0x28

	// Methods

	// RVA: 0x28F8E60 Offset: 0x28F8F61 VA: 0x28F8E60
	public void .ctor() { }

	// RVA: 0x28F8F70 Offset: 0x28F9071 VA: 0x28F8F70
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x28F9080 Offset: 0x28F9181 VA: 0x28F9080
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x28F9890 Offset: 0x28F9991 VA: 0x28F9890
	private bool AgeCookies(string domain) { }

	// RVA: 0x28FAF60 Offset: 0x28FB061 VA: 0x28FAF60
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x28FB0E0 Offset: 0x28FB1E1 VA: 0x28FB0E0
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x28FB630 Offset: 0x28FB731 VA: 0x28FB630
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x28FBE80 Offset: 0x28FBF81 VA: 0x28FBE80
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x28FC1B0 Offset: 0x28FC2B1 VA: 0x28FC1B0
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x28FC970 Offset: 0x28FCA71 VA: 0x28FC970
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x28FCD70 Offset: 0x28FCE71 VA: 0x28FCD70
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x28FCE40 Offset: 0x28FCF41 VA: 0x28FCE40
	internal string GetCookieHeader(Uri uri, out string optCookie2) { }

	// RVA: 0x28FD180 Offset: 0x28FD281 VA: 0x28FD180
	private static void .cctor() { }
}

