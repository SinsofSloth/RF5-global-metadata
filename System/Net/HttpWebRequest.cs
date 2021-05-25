[Serializable]
public class HttpWebRequest : WebRequest, ISerializable // TypeDefIndex: 1975
{
	// Fields
	private Uri requestUri; // 0x20
	private Uri actualUri; // 0x28
	private bool hostChanged; // 0x30
	private bool allowAutoRedirect; // 0x31
	private bool allowBuffering; // 0x32
	private X509CertificateCollection certificates; // 0x38
	private string connectionGroup; // 0x40
	private bool haveContentLength; // 0x48
	private long contentLength; // 0x50
	private HttpContinueDelegate continueDelegate; // 0x58
	private CookieContainer cookieContainer; // 0x60
	private ICredentials credentials; // 0x68
	private bool haveResponse; // 0x70
	private bool haveRequest; // 0x71
	private bool requestSent; // 0x72
	private WebHeaderCollection webHeaders; // 0x78
	private bool keepAlive; // 0x80
	private int maxAutoRedirect; // 0x84
	private string mediaType; // 0x88
	private string method; // 0x90
	private string initialMethod; // 0x98
	private bool pipelined; // 0xA0
	private bool preAuthenticate; // 0xA1
	private bool usedPreAuth; // 0xA2
	private Version version; // 0xA8
	private bool force_version; // 0xB0
	private Version actualVersion; // 0xB8
	private IWebProxy proxy; // 0xC0
	private bool sendChunked; // 0xC8
	private ServicePoint servicePoint; // 0xD0
	private int timeout; // 0xD8
	private WebConnectionStream writeStream; // 0xE0
	private HttpWebResponse webResponse; // 0xE8
	private WebAsyncResult asyncWrite; // 0xF0
	private WebAsyncResult asyncRead; // 0xF8
	private EventHandler abortHandler; // 0x100
	private int aborted; // 0x108
	private bool gotRequestStream; // 0x10C
	private int redirects; // 0x110
	private bool expectContinue; // 0x114
	private byte[] bodyBuffer; // 0x118
	private int bodyBufferLength; // 0x120
	private bool getResponseCalled; // 0x124
	private Exception saved_exc; // 0x128
	private object locker; // 0x130
	private bool finished_reading; // 0x138
	internal WebConnection WebConnection; // 0x140
	private DecompressionMethods auto_decomp; // 0x148
	private static int defaultMaxResponseHeadersLength; // 0x0
	private int readWriteTimeout; // 0x14C
	private MonoTlsProvider tlsProvider; // 0x150
	private MonoTlsSettings tlsSettings; // 0x158
	private ServerCertValidationCallback certValidationCallback; // 0x160
	private HttpWebRequest.AuthorizationState auth_state; // 0x168
	private HttpWebRequest.AuthorizationState proxy_auth_state; // 0x178
	private string host; // 0x188
	internal Action<Stream> ResendContentFactory; // 0x190
	[CompilerGeneratedAttribute] // RVA: 0xBCF30 Offset: 0xBD031 VA: 0xBCF30
	private bool <ThrowOnError>k__BackingField; // 0x198
	private bool unsafe_auth_blah; // 0x199
	[CompilerGeneratedAttribute] // RVA: 0xBCF40 Offset: 0xBD041 VA: 0xBCF40
	private bool <ReuseConnection>k__BackingField; // 0x19A
	internal WebConnection StoredConnection; // 0x1A0

	// Properties
	public Uri Address { get; set; }
	public virtual bool AllowWriteStreamBuffering { get; }
	public DecompressionMethods AutomaticDecompression { get; }
	internal bool InternalAllowBuffering { get; }
	private bool MethodWithBuffer { get; }
	internal MonoTlsProvider TlsProvider { get; }
	internal MonoTlsSettings TlsSettings { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public override long ContentLength { get; }
	internal long InternalContentLength { set; }
	internal bool ThrowOnError { get; set; }
	public override ICredentials Credentials { get; set; }
	public override WebHeaderCollection Headers { get; }
	public string Host { get; }
	public bool KeepAlive { get; }
	public int ReadWriteTimeout { get; }
	public override string Method { get; set; }
	public override IWebProxy Proxy { get; }
	public override Uri RequestUri { get; }
	public bool SendChunked { get; }
	public ServicePoint ServicePoint { get; }
	internal ServicePoint ServicePointNoLock { get; }
	public override int Timeout { get; }
	public string TransferEncoding { get; }
	public bool UnsafeAuthenticatedConnectionSharing { get; }
	internal bool ExpectContinue { get; set; }
	internal Uri AuthUri { get; }
	internal bool ProxyQuery { get; }
	internal ServerCertValidationCallback ServerCertValidationCallback { get; }
	internal bool FinishedReading { get; set; }
	internal bool Aborted { get; }
	internal bool ReuseConnection { get; set; }

	// Methods

	// RVA: 0x178C660 Offset: 0x178C761 VA: 0x178C660
	private static void .cctor() { }

	// RVA: 0x178C370 Offset: 0x178C471 VA: 0x178C370
	public void .ctor(Uri uri) { }

	[ObsoleteAttribute] // RVA: 0xBD8E0 Offset: 0xBD9E1 VA: 0xBD8E0
	// RVA: 0x178C740 Offset: 0x178C841 VA: 0x178C740
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x178C6C0 Offset: 0x178C7C1 VA: 0x178C6C0
	private void ResetAuthorization() { }

	// RVA: 0x178CE30 Offset: 0x178CF31 VA: 0x178CE30
	public Uri get_Address() { }

	// RVA: 0x178CE40 Offset: 0x178CF41 VA: 0x178CE40
	internal void set_Address(Uri value) { }

	// RVA: 0x178CE50 Offset: 0x178CF51 VA: 0x178CE50 Slot: 21
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x178CE60 Offset: 0x178CF61 VA: 0x178CE60
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x178CE70 Offset: 0x178CF71 VA: 0x178CE70
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x178CE90 Offset: 0x178CF91 VA: 0x178CE90
	private bool get_MethodWithBuffer() { }

	// RVA: 0x178CF70 Offset: 0x178D071 VA: 0x178CF70
	internal MonoTlsProvider get_TlsProvider() { }

	// RVA: 0x178CF80 Offset: 0x178D081 VA: 0x178CF80
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x178CF90 Offset: 0x178D091 VA: 0x178CF90
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x178D020 Offset: 0x178D121 VA: 0x178D020 Slot: 12
	public override long get_ContentLength() { }

	// RVA: 0x178D030 Offset: 0x178D131 VA: 0x178D030
	internal void set_InternalContentLength(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBD920 Offset: 0xBDA21 VA: 0xBD920
	// RVA: 0x178D040 Offset: 0x178D141 VA: 0x178D040
	internal bool get_ThrowOnError() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD930 Offset: 0xBDA31 VA: 0xBD930
	// RVA: 0x178D050 Offset: 0x178D151 VA: 0x178D050
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x178D060 Offset: 0x178D161 VA: 0x178D060 Slot: 13
	public override ICredentials get_Credentials() { }

	// RVA: 0x178D070 Offset: 0x178D171 VA: 0x178D070 Slot: 14
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x178D080 Offset: 0x178D181 VA: 0x178D080 Slot: 11
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x178D090 Offset: 0x178D191 VA: 0x178D090
	public string get_Host() { }

	// RVA: 0x178D0C0 Offset: 0x178D1C1 VA: 0x178D0C0
	public bool get_KeepAlive() { }

	// RVA: 0x178D0D0 Offset: 0x178D1D1 VA: 0x178D0D0
	public int get_ReadWriteTimeout() { }

	// RVA: 0x178D0E0 Offset: 0x178D1E1 VA: 0x178D0E0 Slot: 8
	public override string get_Method() { }

	// RVA: 0x178D0F0 Offset: 0x178D1F1 VA: 0x178D0F0 Slot: 9
	public override void set_Method(string value) { }

	// RVA: 0x178D2C0 Offset: 0x178D3C1 VA: 0x178D2C0 Slot: 15
	public override IWebProxy get_Proxy() { }

	// RVA: 0x178D2D0 Offset: 0x178D3D1 VA: 0x178D2D0 Slot: 10
	public override Uri get_RequestUri() { }

	// RVA: 0x178D2E0 Offset: 0x178D3E1 VA: 0x178D2E0
	public bool get_SendChunked() { }

	// RVA: 0x178D2F0 Offset: 0x178D3F1 VA: 0x178D2F0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x178D440 Offset: 0x178D541 VA: 0x178D440
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x178D450 Offset: 0x178D551 VA: 0x178D450 Slot: 16
	public override int get_Timeout() { }

	// RVA: 0x178D460 Offset: 0x178D561 VA: 0x178D460
	public string get_TransferEncoding() { }

	// RVA: 0x178D4C0 Offset: 0x178D5C1 VA: 0x178D4C0
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x178D4D0 Offset: 0x178D5D1 VA: 0x178D4D0
	internal bool get_ExpectContinue() { }

	// RVA: 0x178D4E0 Offset: 0x178D5E1 VA: 0x178D4E0
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x178D4F0 Offset: 0x178D5F1 VA: 0x178D4F0
	internal Uri get_AuthUri() { }

	// RVA: 0x178D500 Offset: 0x178D601 VA: 0x178D500
	internal bool get_ProxyQuery() { }

	// RVA: 0x178D540 Offset: 0x178D641 VA: 0x178D540
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x178D300 Offset: 0x178D401 VA: 0x178D300
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x178D550 Offset: 0x178D651 VA: 0x178D550
	private bool CheckIfForceWrite(SimpleAsyncResult result) { }

	// RVA: 0x178D660 Offset: 0x178D761 VA: 0x178D660 Slot: 18
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x178D980 Offset: 0x178DA81 VA: 0x178D980 Slot: 19
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x178DB00 Offset: 0x178DC01 VA: 0x178DB00 Slot: 17
	public override WebResponse GetResponse() { }

	// RVA: 0x178DBC0 Offset: 0x178DCC1 VA: 0x178DBC0
	internal bool get_FinishedReading() { }

	// RVA: 0x178DBD0 Offset: 0x178DCD1 VA: 0x178DBD0
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x178D950 Offset: 0x178DA51 VA: 0x178D950
	internal bool get_Aborted() { }

	// RVA: 0x178DBE0 Offset: 0x178DCE1 VA: 0x178DBE0 Slot: 20
	public override void Abort() { }

	// RVA: 0x178E070 Offset: 0x178E171 VA: 0x178E070 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x178E080 Offset: 0x178E181 VA: 0x178E080 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x178E3D0 Offset: 0x178E4D1 VA: 0x178E3D0
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x178E3E0 Offset: 0x178E4E1 VA: 0x178E3E0
	private void RewriteRedirectToGet() { }

	// RVA: 0x178E460 Offset: 0x178E561 VA: 0x178E460
	private bool Redirect(WebAsyncResult result, HttpStatusCode code, WebResponse response) { }

	// RVA: 0x178E960 Offset: 0x178EA61 VA: 0x178E960
	private string GetHeaders() { }

	// RVA: 0x178EFB0 Offset: 0x178F0B1 VA: 0x178EFB0
	private void DoPreAuthenticate() { }

	// RVA: 0x178F1C0 Offset: 0x178F2C1 VA: 0x178F1C0
	internal void SetWriteStreamError(WebExceptionStatus status, Exception exc) { }

	// RVA: 0x178F380 Offset: 0x178F481 VA: 0x178F380
	internal byte[] GetRequestHeaders() { }

	// RVA: 0x178F730 Offset: 0x178F831 VA: 0x178F730
	internal void SetWriteStream(WebConnectionStream stream) { }

	// RVA: 0x178F840 Offset: 0x178F941 VA: 0x178F840
	private void SetWriteStreamInner(SimpleAsyncCallback callback) { }

	// RVA: 0x178F8D0 Offset: 0x178F9D1 VA: 0x178F8D0
	private void SetWriteStreamError(Exception exc) { }

	// RVA: 0x178F970 Offset: 0x178FA71 VA: 0x178F970
	internal void SetResponseError(WebExceptionStatus status, Exception e, string where) { }

	// RVA: 0x178FC30 Offset: 0x178FD31 VA: 0x178FC30
	private void CheckSendError(WebConnectionData data) { }

	// RVA: 0x178FE70 Offset: 0x178FF71 VA: 0x178FE70
	private bool HandleNtlmAuth(WebAsyncResult r) { }

	// RVA: 0x17900E0 Offset: 0x17901E1 VA: 0x17900E0
	internal void SetResponseData(WebConnectionData data) { }

	// RVA: 0x17914C0 Offset: 0x17915C1 VA: 0x17914C0
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x1790D10 Offset: 0x1790E11 VA: 0x1790D10
	private bool CheckFinalStatus(WebAsyncResult result) { }

	[CompilerGeneratedAttribute] // RVA: 0xBD940 Offset: 0xBDA41 VA: 0xBD940
	// RVA: 0x1791880 Offset: 0x1791981 VA: 0x1791880
	internal bool get_ReuseConnection() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD950 Offset: 0xBDA51 VA: 0xBD950
	// RVA: 0x1791890 Offset: 0x1791991 VA: 0x1791890
	internal void set_ReuseConnection(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBD960 Offset: 0xBDA61 VA: 0xBD960
	// RVA: 0x17918A0 Offset: 0x17919A1 VA: 0x17918A0
	private void <SetWriteStream>b__258_0(SimpleAsyncResult result) { }

	[CompilerGeneratedAttribute] // RVA: 0xBD970 Offset: 0xBDA71 VA: 0xBD970
	// RVA: 0x1791A20 Offset: 0x1791B21 VA: 0x1791A20
	private void <SetWriteStream>b__258_1(SimpleAsyncResult inner) { }

	[CompilerGeneratedAttribute] // RVA: 0xBD980 Offset: 0xBDA81 VA: 0xBD980
	// RVA: 0x1791B30 Offset: 0x1791C31 VA: 0x1791B30
	private bool <SetWriteStreamInner>b__259_0(SimpleAsyncResult result) { }

	[ObsoleteAttribute] // RVA: 0xBD990 Offset: 0xBDA91 VA: 0xBD990
	[EditorBrowsableAttribute] // RVA: 0xBD990 Offset: 0xBDA91 VA: 0xBD990
	// RVA: 0x1791C10 Offset: 0x1791D11 VA: 0x1791C10
	public void .ctor() { }
}

