public class ServicePointManager // TypeDefIndex: 1988
{
	// Fields
	private static HybridDictionary servicePoints; // 0x0
	private static ICertificatePolicy policy; // 0x8
	private static int defaultConnectionLimit; // 0x10
	private static int maxServicePointIdleTime; // 0x14
	private static int maxServicePoints; // 0x18
	private static int dnsRefreshTimeout; // 0x1C
	private static bool _checkCRL; // 0x20
	private static SecurityProtocolType _securityProtocol; // 0x24
	private static bool expectContinue; // 0x28
	private static bool useNagle; // 0x29
	private static ServerCertValidationCallback server_cert_cb; // 0x30
	private static bool tcp_keepalive; // 0x38
	private static int tcp_keepalive_time; // 0x3C
	private static int tcp_keepalive_interval; // 0x40

	// Properties
	[MonoTODOAttribute] // RVA: 0xBDD20 Offset: 0xBDE21 VA: 0xBDD20
	public static bool CheckCertificateRevocationList { get; }
	public static int DnsRefreshTimeout { get; }
	public static SecurityProtocolType SecurityProtocol { get; }
	internal static ServerCertValidationCallback ServerCertValidationCallback { get; }

	// Methods

	// RVA: 0x16CE5F0 Offset: 0x16CE6F1 VA: 0x16CE5F0
	private static void .cctor() { }

	// RVA: 0x16CE6C0 Offset: 0x16CE7C1 VA: 0x16CE6C0
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0x16CE730 Offset: 0x16CE831 VA: 0x16CE730
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0x16CE7A0 Offset: 0x16CE8A1 VA: 0x16CE7A0
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0x16CE810 Offset: 0x16CE911 VA: 0x16CE810
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0x16CE880 Offset: 0x16CE981 VA: 0x16CE880
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x16CE8F0 Offset: 0x16CE9F1 VA: 0x16CE8F0
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }
}

