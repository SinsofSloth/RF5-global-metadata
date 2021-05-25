public class ServicePoint // TypeDefIndex: 1987
{
	// Fields
	private readonly Uri uri; // 0x10
	private int connectionLimit; // 0x18
	private int maxIdleTime; // 0x1C
	private int currentConnections; // 0x20
	private DateTime idleSince; // 0x28
	private DateTime lastDnsResolve; // 0x30
	private Version protocolVersion; // 0x38
	private IPHostEntry host; // 0x40
	private bool usesProxy; // 0x48
	private Dictionary<string, WebConnectionGroup> groups; // 0x50
	private bool sendContinue; // 0x58
	private bool useConnect; // 0x59
	private object hostE; // 0x60
	private bool useNagle; // 0x68
	private BindIPEndPoint endPointCallback; // 0x70
	private bool tcp_keepalive; // 0x78
	private int tcp_keepalive_time; // 0x7C
	private int tcp_keepalive_interval; // 0x80
	private Timer idleTimer; // 0x88
	private object m_ServerCertificateOrBytes; // 0x90
	private object m_ClientCertificateOrBytes; // 0x98

	// Properties
	public Uri Address { get; }
	public int ConnectionLimit { get; }
	public virtual Version ProtocolVersion { get; }
	public bool Expect100Continue { set; }
	public bool UseNagleAlgorithm { get; set; }
	internal bool SendContinue { get; set; }
	internal bool UsesProxy { get; set; }
	internal bool UseConnect { get; set; }
	private bool HasTimedOut { get; }
	internal IPHostEntry HostEntry { get; }

	// Methods

	// RVA: 0x16CC8C0 Offset: 0x16CC9C1 VA: 0x16CC8C0
	internal void .ctor(Uri uri, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x16CC9B0 Offset: 0x16CCAB1 VA: 0x16CC9B0
	public Uri get_Address() { }

	// RVA: 0x16CC9C0 Offset: 0x16CCAC1 VA: 0x16CC9C0
	public int get_ConnectionLimit() { }

	// RVA: 0x16CC9D0 Offset: 0x16CCAD1 VA: 0x16CC9D0 Slot: 4
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x16CC9E0 Offset: 0x16CCAE1 VA: 0x16CC9E0
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x16CC9F0 Offset: 0x16CCAF1 VA: 0x16CC9F0
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0x16CCA00 Offset: 0x16CCB01 VA: 0x16CCA00
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x16CCA10 Offset: 0x16CCB11 VA: 0x16CCA10
	internal bool get_SendContinue() { }

	// RVA: 0x16CCB20 Offset: 0x16CCC21 VA: 0x16CCB20
	internal void set_SendContinue(bool value) { }

	// RVA: 0x16CCB30 Offset: 0x16CCC31 VA: 0x16CCB30
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0x16CCC10 Offset: 0x16CCD11 VA: 0x16CCC10
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0x16CCCE0 Offset: 0x16CCDE1 VA: 0x16CCCE0
	private static void PutBytes(byte[] bytes, uint v, int offset) { }

	// RVA: 0x16CCE50 Offset: 0x16CCF51 VA: 0x16CCE50
	internal bool get_UsesProxy() { }

	// RVA: 0x16CCE60 Offset: 0x16CCF61 VA: 0x16CCE60
	internal void set_UsesProxy(bool value) { }

	// RVA: 0x16CCE70 Offset: 0x16CCF71 VA: 0x16CCE70
	internal bool get_UseConnect() { }

	// RVA: 0x16CCE80 Offset: 0x16CCF81 VA: 0x16CCE80
	internal void set_UseConnect(bool value) { }

	// RVA: 0x16CCE90 Offset: 0x16CCF91 VA: 0x16CCE90
	private WebConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0x16CCFF0 Offset: 0x16CD0F1 VA: 0x16CCFF0
	private void RemoveConnectionGroup(WebConnectionGroup group) { }

	// RVA: 0x16CD0B0 Offset: 0x16CD1B1 VA: 0x16CD0B0
	private bool CheckAvailableForRecycling(out DateTime outIdleSince) { }

	// RVA: 0x16CD760 Offset: 0x16CD861 VA: 0x16CD760
	private void IdleTimerCallback(object obj) { }

	// RVA: 0x16CD790 Offset: 0x16CD891 VA: 0x16CD790
	private bool get_HasTimedOut() { }

	// RVA: 0x16CD910 Offset: 0x16CDA11 VA: 0x16CD910
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x16CDCF0 Offset: 0x16CDDF1 VA: 0x16CDCF0
	internal void SetVersion(Version version) { }

	// RVA: 0x16CDD00 Offset: 0x16CDE01 VA: 0x16CDD00
	internal EventHandler SendRequest(HttpWebRequest request, string groupName) { }

	// RVA: 0x16CE150 Offset: 0x16CE251 VA: 0x16CE150
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0x16CE1B0 Offset: 0x16CE2B1 VA: 0x16CE1B0
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0x16CE210 Offset: 0x16CE311 VA: 0x16CE210
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

	[CompilerGeneratedAttribute] // RVA: 0xBDA90 Offset: 0xBDB91 VA: 0xBDA90
	// RVA: 0x16CE5E0 Offset: 0x16CE6E1 VA: 0x16CE5E0
	private void <GetConnectionGroup>b__66_0(object s, EventArgs e) { }
}

