internal static class CFNetwork // TypeDefIndex: 1696
{
	// Fields
	private static object lock_obj; // 0x0
	private static Queue<CFNetwork.GetProxyData> get_proxy_queue; // 0x8
	private static AutoResetEvent proxy_event; // 0x10

	// Methods

	// RVA: 0x16E8E30 Offset: 0x16E8F31 VA: 0x16E8E30
	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x16E8ED0 Offset: 0x16E8FD1 VA: 0x16E8ED0
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	// RVA: 0x16E8F80 Offset: 0x16E9081 VA: 0x16E8F80
	private static void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	// RVA: 0x16E92C0 Offset: 0x16E93C1 VA: 0x16E92C0
	private static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x16E9810 Offset: 0x16E9911 VA: 0x16E9810
	private static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x16E98E0 Offset: 0x16E99E1 VA: 0x16E98E0
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x16E9E00 Offset: 0x16E9F01 VA: 0x16E9E00
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri) { }

	// RVA: 0x16EA130 Offset: 0x16EA231 VA: 0x16EA130
	public static CFProxy[] ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL) { }

	// RVA: 0x16EA8D0 Offset: 0x16EA9D1 VA: 0x16EA8D0
	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings) { }

	// RVA: 0x16EA960 Offset: 0x16EAA61 VA: 0x16EA960
	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	// RVA: 0x16EAA90 Offset: 0x16EAB91 VA: 0x16EAA90
	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	// RVA: 0x16EB050 Offset: 0x16EB151 VA: 0x16EB050
	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	// RVA: 0x16EB1D0 Offset: 0x16EB2D1 VA: 0x16EB1D0
	private static extern IntPtr CFNetworkCopySystemProxySettings() { }

	// RVA: 0x16EAF10 Offset: 0x16EB011 VA: 0x16EAF10
	public static CFProxySettings GetSystemProxySettings() { }

	// RVA: 0x16EB280 Offset: 0x16EB381 VA: 0x16EB280
	public static IWebProxy GetDefaultProxy() { }

	// RVA: 0x16EB2F0 Offset: 0x16EB3F1 VA: 0x16EB2F0
	private static void .cctor() { }
}

internal static class CFNetwork // TypeDefIndex: 1696
{
	// Fields
	private static object lock_obj; // 0x0
	private static Queue<CFNetwork.GetProxyData> get_proxy_queue; // 0x8
	private static AutoResetEvent proxy_event; // 0x10

	// Methods

	// RVA: 0x16E8E30 Offset: 0x16E8F31 VA: 0x16E8E30
	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x16E8ED0 Offset: 0x16E8FD1 VA: 0x16E8ED0
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	// RVA: 0x16E8F80 Offset: 0x16E9081 VA: 0x16E8F80
	private static void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	// RVA: 0x16E92C0 Offset: 0x16E93C1 VA: 0x16E92C0
	private static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x16E9810 Offset: 0x16E9911 VA: 0x16E9810
	private static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x16E98E0 Offset: 0x16E99E1 VA: 0x16E98E0
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x16E9E00 Offset: 0x16E9F01 VA: 0x16E9E00
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri) { }

	// RVA: 0x16EA130 Offset: 0x16EA231 VA: 0x16EA130
	public static CFProxy[] ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL) { }

	// RVA: 0x16EA8D0 Offset: 0x16EA9D1 VA: 0x16EA8D0
	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings) { }

	// RVA: 0x16EA960 Offset: 0x16EAA61 VA: 0x16EA960
	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	// RVA: 0x16EAA90 Offset: 0x16EAB91 VA: 0x16EAA90
	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	// RVA: 0x16EB050 Offset: 0x16EB151 VA: 0x16EB050
	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	// RVA: 0x16EB1D0 Offset: 0x16EB2D1 VA: 0x16EB1D0
	private static extern IntPtr CFNetworkCopySystemProxySettings() { }

	// RVA: 0x16EAF10 Offset: 0x16EB011 VA: 0x16EAF10
	public static CFProxySettings GetSystemProxySettings() { }

	// RVA: 0x16EB280 Offset: 0x16EB381 VA: 0x16EB280
	public static IWebProxy GetDefaultProxy() { }

	// RVA: 0x16EB2F0 Offset: 0x16EB3F1 VA: 0x16EB2F0
	private static void .cctor() { }
}

internal static class CFNetwork // TypeDefIndex: 1696
{
	// Fields
	private static object lock_obj; // 0x0
	private static Queue<CFNetwork.GetProxyData> get_proxy_queue; // 0x8
	private static AutoResetEvent proxy_event; // 0x10

	// Methods

	// RVA: 0x16E8E30 Offset: 0x16E8F31 VA: 0x16E8E30
	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x16E8ED0 Offset: 0x16E8FD1 VA: 0x16E8ED0
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	// RVA: 0x16E8F80 Offset: 0x16E9081 VA: 0x16E8F80
	private static void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	// RVA: 0x16E92C0 Offset: 0x16E93C1 VA: 0x16E92C0
	private static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x16E9810 Offset: 0x16E9911 VA: 0x16E9810
	private static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x16E98E0 Offset: 0x16E99E1 VA: 0x16E98E0
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x16E9E00 Offset: 0x16E9F01 VA: 0x16E9E00
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri) { }

	// RVA: 0x16EA130 Offset: 0x16EA231 VA: 0x16EA130
	public static CFProxy[] ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL) { }

	// RVA: 0x16EA8D0 Offset: 0x16EA9D1 VA: 0x16EA8D0
	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings) { }

	// RVA: 0x16EA960 Offset: 0x16EAA61 VA: 0x16EA960
	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	// RVA: 0x16EAA90 Offset: 0x16EAB91 VA: 0x16EAA90
	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	// RVA: 0x16EB050 Offset: 0x16EB151 VA: 0x16EB050
	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	// RVA: 0x16EB1D0 Offset: 0x16EB2D1 VA: 0x16EB1D0
	private static extern IntPtr CFNetworkCopySystemProxySettings() { }

	// RVA: 0x16EAF10 Offset: 0x16EB011 VA: 0x16EAF10
	public static CFProxySettings GetSystemProxySettings() { }

	// RVA: 0x16EB280 Offset: 0x16EB381 VA: 0x16EB280
	public static IWebProxy GetDefaultProxy() { }

	// RVA: 0x16EB2F0 Offset: 0x16EB3F1 VA: 0x16EB2F0
	private static void .cctor() { }
}

internal static class CFNetwork // TypeDefIndex: 1696
{
	// Fields
	private static object lock_obj; // 0x0
	private static Queue<CFNetwork.GetProxyData> get_proxy_queue; // 0x8
	private static AutoResetEvent proxy_event; // 0x10

	// Methods

	// RVA: 0x16E8E30 Offset: 0x16E8F31 VA: 0x16E8E30
	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x16E8ED0 Offset: 0x16E8FD1 VA: 0x16E8ED0
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	// RVA: 0x16E8F80 Offset: 0x16E9081 VA: 0x16E8F80
	private static void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	// RVA: 0x16E92C0 Offset: 0x16E93C1 VA: 0x16E92C0
	private static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x16E9810 Offset: 0x16E9911 VA: 0x16E9810
	private static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x16E98E0 Offset: 0x16E99E1 VA: 0x16E98E0
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x16E9E00 Offset: 0x16E9F01 VA: 0x16E9E00
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri) { }

	// RVA: 0x16EA130 Offset: 0x16EA231 VA: 0x16EA130
	public static CFProxy[] ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL) { }

	// RVA: 0x16EA8D0 Offset: 0x16EA9D1 VA: 0x16EA8D0
	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings) { }

	// RVA: 0x16EA960 Offset: 0x16EAA61 VA: 0x16EA960
	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	// RVA: 0x16EAA90 Offset: 0x16EAB91 VA: 0x16EAA90
	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	// RVA: 0x16EB050 Offset: 0x16EB151 VA: 0x16EB050
	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	// RVA: 0x16EB1D0 Offset: 0x16EB2D1 VA: 0x16EB1D0
	private static extern IntPtr CFNetworkCopySystemProxySettings() { }

	// RVA: 0x16EAF10 Offset: 0x16EB011 VA: 0x16EAF10
	public static CFProxySettings GetSystemProxySettings() { }

	// RVA: 0x16EB280 Offset: 0x16EB381 VA: 0x16EB280
	public static IWebProxy GetDefaultProxy() { }

	// RVA: 0x16EB2F0 Offset: 0x16EB3F1 VA: 0x16EB2F0
	private static void .cctor() { }
}

internal static class CFNetwork // TypeDefIndex: 1696
{
	// Fields
	private static object lock_obj; // 0x0
	private static Queue<CFNetwork.GetProxyData> get_proxy_queue; // 0x8
	private static AutoResetEvent proxy_event; // 0x10

	// Methods

	// RVA: 0x16E8E30 Offset: 0x16E8F31 VA: 0x16E8E30
	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x16E8ED0 Offset: 0x16E8FD1 VA: 0x16E8ED0
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	// RVA: 0x16E8F80 Offset: 0x16E9081 VA: 0x16E8F80
	private static void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	// RVA: 0x16E92C0 Offset: 0x16E93C1 VA: 0x16E92C0
	private static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x16E9810 Offset: 0x16E9911 VA: 0x16E9810
	private static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x16E98E0 Offset: 0x16E99E1 VA: 0x16E98E0
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x16E9E00 Offset: 0x16E9F01 VA: 0x16E9E00
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri) { }

	// RVA: 0x16EA130 Offset: 0x16EA231 VA: 0x16EA130
	public static CFProxy[] ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL) { }

	// RVA: 0x16EA8D0 Offset: 0x16EA9D1 VA: 0x16EA8D0
	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings) { }

	// RVA: 0x16EA960 Offset: 0x16EAA61 VA: 0x16EA960
	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	// RVA: 0x16EAA90 Offset: 0x16EAB91 VA: 0x16EAA90
	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	// RVA: 0x16EB050 Offset: 0x16EB151 VA: 0x16EB050
	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	// RVA: 0x16EB1D0 Offset: 0x16EB2D1 VA: 0x16EB1D0
	private static extern IntPtr CFNetworkCopySystemProxySettings() { }

	// RVA: 0x16EAF10 Offset: 0x16EB011 VA: 0x16EAF10
	public static CFProxySettings GetSystemProxySettings() { }

	// RVA: 0x16EB280 Offset: 0x16EB381 VA: 0x16EB280
	public static IWebProxy GetDefaultProxy() { }

	// RVA: 0x16EB2F0 Offset: 0x16EB3F1 VA: 0x16EB2F0
	private static void .cctor() { }
}

internal static class CFNetwork // TypeDefIndex: 1696
{
	// Fields
	private static object lock_obj; // 0x0
	private static Queue<CFNetwork.GetProxyData> get_proxy_queue; // 0x8
	private static AutoResetEvent proxy_event; // 0x10

	// Methods

	// RVA: 0x16E8E30 Offset: 0x16E8F31 VA: 0x16E8E30
	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x16E8ED0 Offset: 0x16E8FD1 VA: 0x16E8ED0
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	// RVA: 0x16E8F80 Offset: 0x16E9081 VA: 0x16E8F80
	private static void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	// RVA: 0x16E92C0 Offset: 0x16E93C1 VA: 0x16E92C0
	private static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x16E9810 Offset: 0x16E9911 VA: 0x16E9810
	private static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x16E98E0 Offset: 0x16E99E1 VA: 0x16E98E0
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x16E9E00 Offset: 0x16E9F01 VA: 0x16E9E00
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri) { }

	// RVA: 0x16EA130 Offset: 0x16EA231 VA: 0x16EA130
	public static CFProxy[] ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL) { }

	// RVA: 0x16EA8D0 Offset: 0x16EA9D1 VA: 0x16EA8D0
	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings) { }

	// RVA: 0x16EA960 Offset: 0x16EAA61 VA: 0x16EA960
	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	// RVA: 0x16EAA90 Offset: 0x16EAB91 VA: 0x16EAA90
	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	// RVA: 0x16EB050 Offset: 0x16EB151 VA: 0x16EB050
	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	// RVA: 0x16EB1D0 Offset: 0x16EB2D1 VA: 0x16EB1D0
	private static extern IntPtr CFNetworkCopySystemProxySettings() { }

	// RVA: 0x16EAF10 Offset: 0x16EB011 VA: 0x16EAF10
	public static CFProxySettings GetSystemProxySettings() { }

	// RVA: 0x16EB280 Offset: 0x16EB381 VA: 0x16EB280
	public static IWebProxy GetDefaultProxy() { }

	// RVA: 0x16EB2F0 Offset: 0x16EB3F1 VA: 0x16EB2F0
	private static void .cctor() { }
}

internal static class CFNetwork // TypeDefIndex: 1696
{
	// Fields
	private static object lock_obj; // 0x0
	private static Queue<CFNetwork.GetProxyData> get_proxy_queue; // 0x8
	private static AutoResetEvent proxy_event; // 0x10

	// Methods

	// RVA: 0x16E8E30 Offset: 0x16E8F31 VA: 0x16E8E30
	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x16E8ED0 Offset: 0x16E8FD1 VA: 0x16E8ED0
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	// RVA: 0x16E8F80 Offset: 0x16E9081 VA: 0x16E8F80
	private static void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	// RVA: 0x16E92C0 Offset: 0x16E93C1 VA: 0x16E92C0
	private static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x16E9810 Offset: 0x16E9911 VA: 0x16E9810
	private static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x16E98E0 Offset: 0x16E99E1 VA: 0x16E98E0
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x16E9E00 Offset: 0x16E9F01 VA: 0x16E9E00
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri) { }

	// RVA: 0x16EA130 Offset: 0x16EA231 VA: 0x16EA130
	public static CFProxy[] ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL) { }

	// RVA: 0x16EA8D0 Offset: 0x16EA9D1 VA: 0x16EA8D0
	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings) { }

	// RVA: 0x16EA960 Offset: 0x16EAA61 VA: 0x16EA960
	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	// RVA: 0x16EAA90 Offset: 0x16EAB91 VA: 0x16EAA90
	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	// RVA: 0x16EB050 Offset: 0x16EB151 VA: 0x16EB050
	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	// RVA: 0x16EB1D0 Offset: 0x16EB2D1 VA: 0x16EB1D0
	private static extern IntPtr CFNetworkCopySystemProxySettings() { }

	// RVA: 0x16EAF10 Offset: 0x16EB011 VA: 0x16EAF10
	public static CFProxySettings GetSystemProxySettings() { }

	// RVA: 0x16EB280 Offset: 0x16EB381 VA: 0x16EB280
	public static IWebProxy GetDefaultProxy() { }

	// RVA: 0x16EB2F0 Offset: 0x16EB3F1 VA: 0x16EB2F0
	private static void .cctor() { }
}

