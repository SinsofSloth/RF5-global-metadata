private class CFNetwork.CFWebProxy : IWebProxy // TypeDefIndex: 1699
{
	// Fields
	private ICredentials credentials; // 0x10
	private bool userSpecified; // 0x18

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0x16EB2E0 Offset: 0x16EB3E1 VA: 0x16EB2E0
	public void .ctor() { }

	// RVA: 0x16EBC20 Offset: 0x16EBD21 VA: 0x16EBC20 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x16EBC30 Offset: 0x16EBD31 VA: 0x16EBC30
	private static Uri GetProxyUri(CFProxy proxy, out NetworkCredential credentials) { }

	// RVA: 0x16EC630 Offset: 0x16EC731 VA: 0x16EC630
	private static Uri GetProxyUriFromScript(IntPtr script, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x16EC7B0 Offset: 0x16EC8B1 VA: 0x16EC7B0
	private static Uri ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x16EC6C0 Offset: 0x16EC7C1 VA: 0x16EC6C0
	private static Uri SelectProxy(CFProxy[] proxies, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x16EC840 Offset: 0x16EC941 VA: 0x16EC840 Slot: 4
	public Uri GetProxy(Uri targetUri) { }

	// RVA: 0x16ED020 Offset: 0x16ED121 VA: 0x16ED020 Slot: 5
	public bool IsBypassed(Uri targetUri) { }
}

