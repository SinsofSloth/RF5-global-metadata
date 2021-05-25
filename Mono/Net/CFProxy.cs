internal class CFProxy // TypeDefIndex: 1694
{
	// Fields
	private static IntPtr kCFProxyAutoConfigurationJavaScriptKey; // 0x0
	private static IntPtr kCFProxyAutoConfigurationURLKey; // 0x8
	private static IntPtr kCFProxyHostNameKey; // 0x10
	private static IntPtr kCFProxyPasswordKey; // 0x18
	private static IntPtr kCFProxyPortNumberKey; // 0x20
	private static IntPtr kCFProxyTypeKey; // 0x28
	private static IntPtr kCFProxyUsernameKey; // 0x30
	private static IntPtr kCFProxyTypeAutoConfigurationURL; // 0x38
	private static IntPtr kCFProxyTypeAutoConfigurationJavaScript; // 0x40
	private static IntPtr kCFProxyTypeFTP; // 0x48
	private static IntPtr kCFProxyTypeHTTP; // 0x50
	private static IntPtr kCFProxyTypeHTTPS; // 0x58
	private static IntPtr kCFProxyTypeSOCKS; // 0x60
	private CFDictionary settings; // 0x10

	// Properties
	public IntPtr AutoConfigurationJavaScript { get; }
	public IntPtr AutoConfigurationUrl { get; }
	public string HostName { get; }
	public string Password { get; }
	public int Port { get; }
	public CFProxyType ProxyType { get; }
	public string Username { get; }

	// Methods

	// RVA: 0x16ED7F0 Offset: 0x16ED8F1 VA: 0x16ED7F0
	private static void .cctor() { }

	// RVA: 0x16E9D40 Offset: 0x16E9E41 VA: 0x16E9D40
	internal void .ctor(CFDictionary settings) { }

	// RVA: 0x16EDAC0 Offset: 0x16EDBC1 VA: 0x16EDAC0
	private static CFProxyType CFProxyTypeToEnum(IntPtr type) { }

	// RVA: 0x16ECD20 Offset: 0x16ECE21 VA: 0x16ECD20
	public IntPtr get_AutoConfigurationJavaScript() { }

	// RVA: 0x16ECEA0 Offset: 0x16ECFA1 VA: 0x16ECEA0
	public IntPtr get_AutoConfigurationUrl() { }

	// RVA: 0x16EC270 Offset: 0x16EC371 VA: 0x16EC270
	public string get_HostName() { }

	// RVA: 0x16EC0F0 Offset: 0x16EC1F1 VA: 0x16EC0F0
	public string get_Password() { }

	// RVA: 0x16EC3F0 Offset: 0x16EC4F1 VA: 0x16EC3F0
	public int get_Port() { }

	// RVA: 0x16EBDF0 Offset: 0x16EBEF1 VA: 0x16EBDF0
	public CFProxyType get_ProxyType() { }

	// RVA: 0x16EBF70 Offset: 0x16EC071 VA: 0x16EBF70
	public string get_Username() { }
}

