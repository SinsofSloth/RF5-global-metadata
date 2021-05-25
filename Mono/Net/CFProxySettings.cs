internal class CFProxySettings // TypeDefIndex: 1695
{
	// Fields
	private static IntPtr kCFNetworkProxiesHTTPEnable; // 0x0
	private static IntPtr kCFNetworkProxiesHTTPPort; // 0x8
	private static IntPtr kCFNetworkProxiesHTTPProxy; // 0x10
	private static IntPtr kCFNetworkProxiesProxyAutoConfigEnable; // 0x18
	private static IntPtr kCFNetworkProxiesProxyAutoConfigJavaScript; // 0x20
	private static IntPtr kCFNetworkProxiesProxyAutoConfigURLString; // 0x28
	private CFDictionary settings; // 0x10

	// Properties
	public CFDictionary Dictionary { get; }

	// Methods

	// RVA: 0x16EDF30 Offset: 0x16EE031 VA: 0x16EDF30
	private static void .cctor() { }

	// RVA: 0x16EB240 Offset: 0x16EB341 VA: 0x16EB240
	public void .ctor(CFDictionary settings) { }

	// RVA: 0x16EE120 Offset: 0x16EE221 VA: 0x16EE120
	public CFDictionary get_Dictionary() { }
}

