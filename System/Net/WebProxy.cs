[Serializable]
public class WebProxy : IWebProxy, ISerializable // TypeDefIndex: 1947
{
	// Fields
	private bool _UseRegistry; // 0x10
	private bool _BypassOnLocal; // 0x11
	private bool m_EnableAutoproxy; // 0x12
	private Uri _ProxyAddress; // 0x18
	private ArrayList _BypassList; // 0x20
	private ICredentials _Credentials; // 0x28
	private Regex[] _RegExBypassList; // 0x30
	private Hashtable _ProxyHostAddresses; // 0x38
	private AutoWebProxyScriptEngine m_ScriptEngine; // 0x40

	// Properties
	public ICredentials Credentials { get; }
	public bool UseDefaultCredentials { get; set; }
	internal AutoWebProxyScriptEngine ScriptEngine { get; }

	// Methods

	// RVA: 0x170B1C0 Offset: 0x170B2C1 VA: 0x170B1C0
	public void .ctor() { }

	// RVA: 0x170B240 Offset: 0x170B341 VA: 0x170B240
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x170B720 Offset: 0x170B821 VA: 0x170B720 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x170B730 Offset: 0x170B831 VA: 0x170B730
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x170B7D0 Offset: 0x170B8D1 VA: 0x170B7D0
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x170B860 Offset: 0x170B961 VA: 0x170B860 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x170B320 Offset: 0x170B421 VA: 0x170B320
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x170BDB0 Offset: 0x170BEB1 VA: 0x170BDB0
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x170C040 Offset: 0x170C141 VA: 0x170C040
	private bool IsLocal(Uri host) { }

	// RVA: 0x170C1C0 Offset: 0x170C2C1 VA: 0x170C1C0
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x170C2E0 Offset: 0x170C3E1 VA: 0x170C2E0 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x170BC30 Offset: 0x170BD31 VA: 0x170BC30
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x170C510 Offset: 0x170C611 VA: 0x170C510
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x170C880 Offset: 0x170C981 VA: 0x170C880 Slot: 7
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x170C890 Offset: 0x170C991 VA: 0x170C890 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x170C9F0 Offset: 0x170CAF1 VA: 0x170C9F0
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x170CA00 Offset: 0x170CB01 VA: 0x170CA00
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x170CA70 Offset: 0x170CB71 VA: 0x170CA70
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x170C870 Offset: 0x170C971 VA: 0x170C870
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x170BA10 Offset: 0x170BB11 VA: 0x170BA10
	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	// RVA: 0x170C3E0 Offset: 0x170C4E1 VA: 0x170C3E0
	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	// RVA: 0x170CAB0 Offset: 0x170CBB1 VA: 0x170CAB0
	private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly) { }

	// RVA: 0x170CE50 Offset: 0x170CF51 VA: 0x170CE50
	private static Uri ProxyUri(string proxyName) { }
}

