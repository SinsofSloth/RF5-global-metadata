public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 1971
{
	// Fields
	private Uri requestUri; // 0x20
	private string file_name; // 0x28
	private ServicePoint servicePoint; // 0x30
	private Stream origDataStream; // 0x38
	private Stream dataStream; // 0x40
	private Stream controlStream; // 0x48
	private StreamReader controlReader; // 0x50
	private NetworkCredential credentials; // 0x58
	private IPHostEntry hostEntry; // 0x60
	private IPEndPoint localEndPoint; // 0x68
	private IPEndPoint remoteEndPoint; // 0x70
	private IWebProxy proxy; // 0x78
	private int timeout; // 0x80
	private int rwTimeout; // 0x84
	private long offset; // 0x88
	private bool binary; // 0x90
	private bool enableSsl; // 0x91
	private bool usePassive; // 0x92
	private bool keepAlive; // 0x93
	private string method; // 0x98
	private string renameTo; // 0xA0
	private object locker; // 0xA8
	private FtpWebRequest.RequestState requestState; // 0xB0
	private FtpAsyncResult asyncResult; // 0xB8
	private FtpWebResponse ftpResponse; // 0xC0
	private Stream requestStream; // 0xC8
	private string initial_path; // 0xD0
	private static readonly string[] supportedCommands; // 0x0
	private Encoding dataEncoding; // 0xD8

	// Properties
	public override long ContentLength { get; }
	public override ICredentials Credentials { get; set; }
	public bool EnableSsl { get; }
	[MonoTODOAttribute] // RVA: 0xBDD10 Offset: 0xBDE11 VA: 0xBDD10
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override IWebProxy Proxy { get; }
	public int ReadWriteTimeout { get; }
	public override Uri RequestUri { get; }
	public ServicePoint ServicePoint { get; }
	public override int Timeout { get; }
	private string DataType { get; }
	private FtpWebRequest.RequestState State { get; set; }

	// Methods

	// RVA: 0x17834A0 Offset: 0x17835A1 VA: 0x17834A0
	internal void .ctor(Uri uri) { }

	// RVA: 0x1783760 Offset: 0x1783861 VA: 0x1783760
	private static Exception GetMustImplement() { }

	// RVA: 0x17837C0 Offset: 0x17838C1 VA: 0x17837C0 Slot: 12
	public override long get_ContentLength() { }

	// RVA: 0x17837D0 Offset: 0x17838D1 VA: 0x17837D0 Slot: 13
	public override ICredentials get_Credentials() { }

	// RVA: 0x17837E0 Offset: 0x17838E1 VA: 0x17837E0 Slot: 14
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x17839D0 Offset: 0x1783AD1 VA: 0x17839D0
	public bool get_EnableSsl() { }

	// RVA: 0x17839E0 Offset: 0x1783AE1 VA: 0x17839E0 Slot: 11
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1783A50 Offset: 0x1783B51 VA: 0x1783A50 Slot: 8
	public override string get_Method() { }

	// RVA: 0x1783A60 Offset: 0x1783B61 VA: 0x1783A60 Slot: 9
	public override void set_Method(string value) { }

	// RVA: 0x1783B90 Offset: 0x1783C91 VA: 0x1783B90 Slot: 15
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1783BA0 Offset: 0x1783CA1 VA: 0x1783BA0
	public int get_ReadWriteTimeout() { }

	// RVA: 0x1783BB0 Offset: 0x1783CB1 VA: 0x1783BB0 Slot: 10
	public override Uri get_RequestUri() { }

	// RVA: 0x1783BC0 Offset: 0x1783CC1 VA: 0x1783BC0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1783D40 Offset: 0x1783E41 VA: 0x1783D40 Slot: 16
	public override int get_Timeout() { }

	// RVA: 0x1783D50 Offset: 0x1783E51 VA: 0x1783D50
	private string get_DataType() { }

	// RVA: 0x1783DB0 Offset: 0x1783EB1 VA: 0x1783DB0
	private FtpWebRequest.RequestState get_State() { }

	// RVA: 0x1783E50 Offset: 0x1783F51 VA: 0x1783E50
	private void set_State(FtpWebRequest.RequestState value) { }

	// RVA: 0x1783FF0 Offset: 0x17840F1 VA: 0x1783FF0 Slot: 20
	public override void Abort() { }

	// RVA: 0x1784700 Offset: 0x1784801 VA: 0x1784700 Slot: 18
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1784A40 Offset: 0x1784B41 VA: 0x1784A40 Slot: 19
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1784BC0 Offset: 0x1784CC1 VA: 0x1784BC0 Slot: 17
	public override WebResponse GetResponse() { }

	// RVA: 0x1783C80 Offset: 0x1783D81 VA: 0x1783C80
	private ServicePoint GetServicePoint() { }

	// RVA: 0x1784C10 Offset: 0x1784D11 VA: 0x1784C10
	private void ResolveHost() { }

	// RVA: 0x1784DE0 Offset: 0x1784EE1 VA: 0x1784DE0
	private void ProcessRequest() { }

	// RVA: 0x1785AF0 Offset: 0x1785BF1 VA: 0x1785AF0
	private void SetType() { }

	// RVA: 0x1785D30 Offset: 0x1785E31 VA: 0x1785D30
	private string GetRemoteFolderPath(Uri uri) { }

	// RVA: 0x1785F00 Offset: 0x1786001 VA: 0x1785F00
	private void CWDAndSetFileName(Uri uri) { }

	// RVA: 0x17851D0 Offset: 0x17852D1 VA: 0x17851D0
	private void ProcessMethod() { }

	// RVA: 0x1786DA0 Offset: 0x1786EA1 VA: 0x1786DA0
	private void CloseControlConnection() { }

	// RVA: 0x1781A80 Offset: 0x1781B81 VA: 0x1781A80
	internal void CloseDataConnection() { }

	// RVA: 0x1786ED0 Offset: 0x1786FD1 VA: 0x1786ED0
	private void CloseConnection() { }

	// RVA: 0x17867F0 Offset: 0x17868F1 VA: 0x17867F0
	private void ProcessSimpleMethod() { }

	// RVA: 0x1786730 Offset: 0x1786831 VA: 0x1786730
	private void UploadData() { }

	// RVA: 0x1786680 Offset: 0x1786781 VA: 0x1786680
	private void DownloadData() { }

	// RVA: 0x17838D0 Offset: 0x17839D1 VA: 0x17838D0
	private void CheckRequestStarted() { }

	// RVA: 0x17860A0 Offset: 0x17861A1 VA: 0x17860A0
	private void OpenControlConnection() { }

	// RVA: 0x1787930 Offset: 0x1787A31 VA: 0x1787930
	private static string GetInitialPath(FtpStatus status) { }

	// RVA: 0x1787AC0 Offset: 0x1787BC1 VA: 0x1787AC0
	private Socket SetupPassiveConnection(string statusDescription, bool ipv6) { }

	// RVA: 0x1787CA0 Offset: 0x1787DA1 VA: 0x1787CA0
	private int GetPortV4(string responseString) { }

	// RVA: 0x1787EE0 Offset: 0x1787FE1 VA: 0x1787EE0
	private int GetPortV6(string responseString) { }

	// RVA: 0x17880A0 Offset: 0x17881A1 VA: 0x17880A0
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1788520 Offset: 0x1788621 VA: 0x1788520
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x1785C50 Offset: 0x1785D51 VA: 0x1785C50
	private Exception CreateExceptionFromResponse(FtpStatus status) { }

	// RVA: 0x1781AD0 Offset: 0x1781BD1 VA: 0x1781AD0
	internal void SetTransferCompleted() { }

	// RVA: 0x1788650 Offset: 0x1788751 VA: 0x1788650
	internal void OperationCompleted() { }

	// RVA: 0x17856F0 Offset: 0x17857F1 VA: 0x17856F0
	private void SetCompleteWithError(Exception exc) { }

	// RVA: 0x17886B0 Offset: 0x17887B1 VA: 0x17886B0
	private Socket InitDataConnection() { }

	// RVA: 0x1786F20 Offset: 0x1787021 VA: 0x1786F20
	private void OpenDataConnection() { }

	// RVA: 0x17874D0 Offset: 0x17875D1 VA: 0x17874D0
	private void Authenticate() { }

	// RVA: 0x1785C40 Offset: 0x1785D41 VA: 0x1785C40
	private FtpStatus SendCommand(string command, string[] parameters) { }

	// RVA: 0x1784260 Offset: 0x1784361 VA: 0x1784260
	private FtpStatus SendCommand(bool waitResponse, string command, string[] parameters) { }

	// RVA: 0x1788DF0 Offset: 0x1788EF1 VA: 0x1788DF0
	internal static FtpStatus ServiceNotAvailable() { }

	// RVA: 0x17857D0 Offset: 0x17858D1 VA: 0x17857D0
	internal FtpStatus GetResponseStatus() { }

	// RVA: 0x1788CD0 Offset: 0x1788DD1 VA: 0x1788CD0
	private void InitiateSecureConnection(ref Stream stream) { }

	// RVA: 0x1788AE0 Offset: 0x1788BE1 VA: 0x1788AE0
	internal bool ChangeToSSLSocket(ref Stream stream) { }

	// RVA: 0x1784450 Offset: 0x1784551 VA: 0x1784450
	private bool InFinalState() { }

	// RVA: 0x1785710 Offset: 0x1785811 VA: 0x1785710
	private bool InProgress() { }

	// RVA: 0x1781980 Offset: 0x1781A81 VA: 0x1781980
	internal void CheckIfAborted() { }

	// RVA: 0x1783F60 Offset: 0x1784061 VA: 0x1783F60
	private void CheckFinalState() { }

	// RVA: 0x1788E80 Offset: 0x1788F81 VA: 0x1788E80
	private static void .cctor() { }
}

public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 1971
{
	// Fields
	private Uri requestUri; // 0x20
	private string file_name; // 0x28
	private ServicePoint servicePoint; // 0x30
	private Stream origDataStream; // 0x38
	private Stream dataStream; // 0x40
	private Stream controlStream; // 0x48
	private StreamReader controlReader; // 0x50
	private NetworkCredential credentials; // 0x58
	private IPHostEntry hostEntry; // 0x60
	private IPEndPoint localEndPoint; // 0x68
	private IPEndPoint remoteEndPoint; // 0x70
	private IWebProxy proxy; // 0x78
	private int timeout; // 0x80
	private int rwTimeout; // 0x84
	private long offset; // 0x88
	private bool binary; // 0x90
	private bool enableSsl; // 0x91
	private bool usePassive; // 0x92
	private bool keepAlive; // 0x93
	private string method; // 0x98
	private string renameTo; // 0xA0
	private object locker; // 0xA8
	private FtpWebRequest.RequestState requestState; // 0xB0
	private FtpAsyncResult asyncResult; // 0xB8
	private FtpWebResponse ftpResponse; // 0xC0
	private Stream requestStream; // 0xC8
	private string initial_path; // 0xD0
	private static readonly string[] supportedCommands; // 0x0
	private Encoding dataEncoding; // 0xD8

	// Properties
	public override long ContentLength { get; }
	public override ICredentials Credentials { get; set; }
	public bool EnableSsl { get; }
	[MonoTODOAttribute] // RVA: 0xBDD10 Offset: 0xBDE11 VA: 0xBDD10
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override IWebProxy Proxy { get; }
	public int ReadWriteTimeout { get; }
	public override Uri RequestUri { get; }
	public ServicePoint ServicePoint { get; }
	public override int Timeout { get; }
	private string DataType { get; }
	private FtpWebRequest.RequestState State { get; set; }

	// Methods

	// RVA: 0x17834A0 Offset: 0x17835A1 VA: 0x17834A0
	internal void .ctor(Uri uri) { }

	// RVA: 0x1783760 Offset: 0x1783861 VA: 0x1783760
	private static Exception GetMustImplement() { }

	// RVA: 0x17837C0 Offset: 0x17838C1 VA: 0x17837C0 Slot: 12
	public override long get_ContentLength() { }

	// RVA: 0x17837D0 Offset: 0x17838D1 VA: 0x17837D0 Slot: 13
	public override ICredentials get_Credentials() { }

	// RVA: 0x17837E0 Offset: 0x17838E1 VA: 0x17837E0 Slot: 14
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x17839D0 Offset: 0x1783AD1 VA: 0x17839D0
	public bool get_EnableSsl() { }

	// RVA: 0x17839E0 Offset: 0x1783AE1 VA: 0x17839E0 Slot: 11
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1783A50 Offset: 0x1783B51 VA: 0x1783A50 Slot: 8
	public override string get_Method() { }

	// RVA: 0x1783A60 Offset: 0x1783B61 VA: 0x1783A60 Slot: 9
	public override void set_Method(string value) { }

	// RVA: 0x1783B90 Offset: 0x1783C91 VA: 0x1783B90 Slot: 15
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1783BA0 Offset: 0x1783CA1 VA: 0x1783BA0
	public int get_ReadWriteTimeout() { }

	// RVA: 0x1783BB0 Offset: 0x1783CB1 VA: 0x1783BB0 Slot: 10
	public override Uri get_RequestUri() { }

	// RVA: 0x1783BC0 Offset: 0x1783CC1 VA: 0x1783BC0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1783D40 Offset: 0x1783E41 VA: 0x1783D40 Slot: 16
	public override int get_Timeout() { }

	// RVA: 0x1783D50 Offset: 0x1783E51 VA: 0x1783D50
	private string get_DataType() { }

	// RVA: 0x1783DB0 Offset: 0x1783EB1 VA: 0x1783DB0
	private FtpWebRequest.RequestState get_State() { }

	// RVA: 0x1783E50 Offset: 0x1783F51 VA: 0x1783E50
	private void set_State(FtpWebRequest.RequestState value) { }

	// RVA: 0x1783FF0 Offset: 0x17840F1 VA: 0x1783FF0 Slot: 20
	public override void Abort() { }

	// RVA: 0x1784700 Offset: 0x1784801 VA: 0x1784700 Slot: 18
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1784A40 Offset: 0x1784B41 VA: 0x1784A40 Slot: 19
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1784BC0 Offset: 0x1784CC1 VA: 0x1784BC0 Slot: 17
	public override WebResponse GetResponse() { }

	// RVA: 0x1783C80 Offset: 0x1783D81 VA: 0x1783C80
	private ServicePoint GetServicePoint() { }

	// RVA: 0x1784C10 Offset: 0x1784D11 VA: 0x1784C10
	private void ResolveHost() { }

	// RVA: 0x1784DE0 Offset: 0x1784EE1 VA: 0x1784DE0
	private void ProcessRequest() { }

	// RVA: 0x1785AF0 Offset: 0x1785BF1 VA: 0x1785AF0
	private void SetType() { }

	// RVA: 0x1785D30 Offset: 0x1785E31 VA: 0x1785D30
	private string GetRemoteFolderPath(Uri uri) { }

	// RVA: 0x1785F00 Offset: 0x1786001 VA: 0x1785F00
	private void CWDAndSetFileName(Uri uri) { }

	// RVA: 0x17851D0 Offset: 0x17852D1 VA: 0x17851D0
	private void ProcessMethod() { }

	// RVA: 0x1786DA0 Offset: 0x1786EA1 VA: 0x1786DA0
	private void CloseControlConnection() { }

	// RVA: 0x1781A80 Offset: 0x1781B81 VA: 0x1781A80
	internal void CloseDataConnection() { }

	// RVA: 0x1786ED0 Offset: 0x1786FD1 VA: 0x1786ED0
	private void CloseConnection() { }

	// RVA: 0x17867F0 Offset: 0x17868F1 VA: 0x17867F0
	private void ProcessSimpleMethod() { }

	// RVA: 0x1786730 Offset: 0x1786831 VA: 0x1786730
	private void UploadData() { }

	// RVA: 0x1786680 Offset: 0x1786781 VA: 0x1786680
	private void DownloadData() { }

	// RVA: 0x17838D0 Offset: 0x17839D1 VA: 0x17838D0
	private void CheckRequestStarted() { }

	// RVA: 0x17860A0 Offset: 0x17861A1 VA: 0x17860A0
	private void OpenControlConnection() { }

	// RVA: 0x1787930 Offset: 0x1787A31 VA: 0x1787930
	private static string GetInitialPath(FtpStatus status) { }

	// RVA: 0x1787AC0 Offset: 0x1787BC1 VA: 0x1787AC0
	private Socket SetupPassiveConnection(string statusDescription, bool ipv6) { }

	// RVA: 0x1787CA0 Offset: 0x1787DA1 VA: 0x1787CA0
	private int GetPortV4(string responseString) { }

	// RVA: 0x1787EE0 Offset: 0x1787FE1 VA: 0x1787EE0
	private int GetPortV6(string responseString) { }

	// RVA: 0x17880A0 Offset: 0x17881A1 VA: 0x17880A0
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1788520 Offset: 0x1788621 VA: 0x1788520
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x1785C50 Offset: 0x1785D51 VA: 0x1785C50
	private Exception CreateExceptionFromResponse(FtpStatus status) { }

	// RVA: 0x1781AD0 Offset: 0x1781BD1 VA: 0x1781AD0
	internal void SetTransferCompleted() { }

	// RVA: 0x1788650 Offset: 0x1788751 VA: 0x1788650
	internal void OperationCompleted() { }

	// RVA: 0x17856F0 Offset: 0x17857F1 VA: 0x17856F0
	private void SetCompleteWithError(Exception exc) { }

	// RVA: 0x17886B0 Offset: 0x17887B1 VA: 0x17886B0
	private Socket InitDataConnection() { }

	// RVA: 0x1786F20 Offset: 0x1787021 VA: 0x1786F20
	private void OpenDataConnection() { }

	// RVA: 0x17874D0 Offset: 0x17875D1 VA: 0x17874D0
	private void Authenticate() { }

	// RVA: 0x1785C40 Offset: 0x1785D41 VA: 0x1785C40
	private FtpStatus SendCommand(string command, string[] parameters) { }

	// RVA: 0x1784260 Offset: 0x1784361 VA: 0x1784260
	private FtpStatus SendCommand(bool waitResponse, string command, string[] parameters) { }

	// RVA: 0x1788DF0 Offset: 0x1788EF1 VA: 0x1788DF0
	internal static FtpStatus ServiceNotAvailable() { }

	// RVA: 0x17857D0 Offset: 0x17858D1 VA: 0x17857D0
	internal FtpStatus GetResponseStatus() { }

	// RVA: 0x1788CD0 Offset: 0x1788DD1 VA: 0x1788CD0
	private void InitiateSecureConnection(ref Stream stream) { }

	// RVA: 0x1788AE0 Offset: 0x1788BE1 VA: 0x1788AE0
	internal bool ChangeToSSLSocket(ref Stream stream) { }

	// RVA: 0x1784450 Offset: 0x1784551 VA: 0x1784450
	private bool InFinalState() { }

	// RVA: 0x1785710 Offset: 0x1785811 VA: 0x1785710
	private bool InProgress() { }

	// RVA: 0x1781980 Offset: 0x1781A81 VA: 0x1781980
	internal void CheckIfAborted() { }

	// RVA: 0x1783F60 Offset: 0x1784061 VA: 0x1783F60
	private void CheckFinalState() { }

	// RVA: 0x1788E80 Offset: 0x1788F81 VA: 0x1788E80
	private static void .cctor() { }
}

public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 1971
{
	// Fields
	private Uri requestUri; // 0x20
	private string file_name; // 0x28
	private ServicePoint servicePoint; // 0x30
	private Stream origDataStream; // 0x38
	private Stream dataStream; // 0x40
	private Stream controlStream; // 0x48
	private StreamReader controlReader; // 0x50
	private NetworkCredential credentials; // 0x58
	private IPHostEntry hostEntry; // 0x60
	private IPEndPoint localEndPoint; // 0x68
	private IPEndPoint remoteEndPoint; // 0x70
	private IWebProxy proxy; // 0x78
	private int timeout; // 0x80
	private int rwTimeout; // 0x84
	private long offset; // 0x88
	private bool binary; // 0x90
	private bool enableSsl; // 0x91
	private bool usePassive; // 0x92
	private bool keepAlive; // 0x93
	private string method; // 0x98
	private string renameTo; // 0xA0
	private object locker; // 0xA8
	private FtpWebRequest.RequestState requestState; // 0xB0
	private FtpAsyncResult asyncResult; // 0xB8
	private FtpWebResponse ftpResponse; // 0xC0
	private Stream requestStream; // 0xC8
	private string initial_path; // 0xD0
	private static readonly string[] supportedCommands; // 0x0
	private Encoding dataEncoding; // 0xD8

	// Properties
	public override long ContentLength { get; }
	public override ICredentials Credentials { get; set; }
	public bool EnableSsl { get; }
	[MonoTODOAttribute] // RVA: 0xBDD10 Offset: 0xBDE11 VA: 0xBDD10
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override IWebProxy Proxy { get; }
	public int ReadWriteTimeout { get; }
	public override Uri RequestUri { get; }
	public ServicePoint ServicePoint { get; }
	public override int Timeout { get; }
	private string DataType { get; }
	private FtpWebRequest.RequestState State { get; set; }

	// Methods

	// RVA: 0x17834A0 Offset: 0x17835A1 VA: 0x17834A0
	internal void .ctor(Uri uri) { }

	// RVA: 0x1783760 Offset: 0x1783861 VA: 0x1783760
	private static Exception GetMustImplement() { }

	// RVA: 0x17837C0 Offset: 0x17838C1 VA: 0x17837C0 Slot: 12
	public override long get_ContentLength() { }

	// RVA: 0x17837D0 Offset: 0x17838D1 VA: 0x17837D0 Slot: 13
	public override ICredentials get_Credentials() { }

	// RVA: 0x17837E0 Offset: 0x17838E1 VA: 0x17837E0 Slot: 14
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x17839D0 Offset: 0x1783AD1 VA: 0x17839D0
	public bool get_EnableSsl() { }

	// RVA: 0x17839E0 Offset: 0x1783AE1 VA: 0x17839E0 Slot: 11
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1783A50 Offset: 0x1783B51 VA: 0x1783A50 Slot: 8
	public override string get_Method() { }

	// RVA: 0x1783A60 Offset: 0x1783B61 VA: 0x1783A60 Slot: 9
	public override void set_Method(string value) { }

	// RVA: 0x1783B90 Offset: 0x1783C91 VA: 0x1783B90 Slot: 15
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1783BA0 Offset: 0x1783CA1 VA: 0x1783BA0
	public int get_ReadWriteTimeout() { }

	// RVA: 0x1783BB0 Offset: 0x1783CB1 VA: 0x1783BB0 Slot: 10
	public override Uri get_RequestUri() { }

	// RVA: 0x1783BC0 Offset: 0x1783CC1 VA: 0x1783BC0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1783D40 Offset: 0x1783E41 VA: 0x1783D40 Slot: 16
	public override int get_Timeout() { }

	// RVA: 0x1783D50 Offset: 0x1783E51 VA: 0x1783D50
	private string get_DataType() { }

	// RVA: 0x1783DB0 Offset: 0x1783EB1 VA: 0x1783DB0
	private FtpWebRequest.RequestState get_State() { }

	// RVA: 0x1783E50 Offset: 0x1783F51 VA: 0x1783E50
	private void set_State(FtpWebRequest.RequestState value) { }

	// RVA: 0x1783FF0 Offset: 0x17840F1 VA: 0x1783FF0 Slot: 20
	public override void Abort() { }

	// RVA: 0x1784700 Offset: 0x1784801 VA: 0x1784700 Slot: 18
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1784A40 Offset: 0x1784B41 VA: 0x1784A40 Slot: 19
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1784BC0 Offset: 0x1784CC1 VA: 0x1784BC0 Slot: 17
	public override WebResponse GetResponse() { }

	// RVA: 0x1783C80 Offset: 0x1783D81 VA: 0x1783C80
	private ServicePoint GetServicePoint() { }

	// RVA: 0x1784C10 Offset: 0x1784D11 VA: 0x1784C10
	private void ResolveHost() { }

	// RVA: 0x1784DE0 Offset: 0x1784EE1 VA: 0x1784DE0
	private void ProcessRequest() { }

	// RVA: 0x1785AF0 Offset: 0x1785BF1 VA: 0x1785AF0
	private void SetType() { }

	// RVA: 0x1785D30 Offset: 0x1785E31 VA: 0x1785D30
	private string GetRemoteFolderPath(Uri uri) { }

	// RVA: 0x1785F00 Offset: 0x1786001 VA: 0x1785F00
	private void CWDAndSetFileName(Uri uri) { }

	// RVA: 0x17851D0 Offset: 0x17852D1 VA: 0x17851D0
	private void ProcessMethod() { }

	// RVA: 0x1786DA0 Offset: 0x1786EA1 VA: 0x1786DA0
	private void CloseControlConnection() { }

	// RVA: 0x1781A80 Offset: 0x1781B81 VA: 0x1781A80
	internal void CloseDataConnection() { }

	// RVA: 0x1786ED0 Offset: 0x1786FD1 VA: 0x1786ED0
	private void CloseConnection() { }

	// RVA: 0x17867F0 Offset: 0x17868F1 VA: 0x17867F0
	private void ProcessSimpleMethod() { }

	// RVA: 0x1786730 Offset: 0x1786831 VA: 0x1786730
	private void UploadData() { }

	// RVA: 0x1786680 Offset: 0x1786781 VA: 0x1786680
	private void DownloadData() { }

	// RVA: 0x17838D0 Offset: 0x17839D1 VA: 0x17838D0
	private void CheckRequestStarted() { }

	// RVA: 0x17860A0 Offset: 0x17861A1 VA: 0x17860A0
	private void OpenControlConnection() { }

	// RVA: 0x1787930 Offset: 0x1787A31 VA: 0x1787930
	private static string GetInitialPath(FtpStatus status) { }

	// RVA: 0x1787AC0 Offset: 0x1787BC1 VA: 0x1787AC0
	private Socket SetupPassiveConnection(string statusDescription, bool ipv6) { }

	// RVA: 0x1787CA0 Offset: 0x1787DA1 VA: 0x1787CA0
	private int GetPortV4(string responseString) { }

	// RVA: 0x1787EE0 Offset: 0x1787FE1 VA: 0x1787EE0
	private int GetPortV6(string responseString) { }

	// RVA: 0x17880A0 Offset: 0x17881A1 VA: 0x17880A0
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1788520 Offset: 0x1788621 VA: 0x1788520
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x1785C50 Offset: 0x1785D51 VA: 0x1785C50
	private Exception CreateExceptionFromResponse(FtpStatus status) { }

	// RVA: 0x1781AD0 Offset: 0x1781BD1 VA: 0x1781AD0
	internal void SetTransferCompleted() { }

	// RVA: 0x1788650 Offset: 0x1788751 VA: 0x1788650
	internal void OperationCompleted() { }

	// RVA: 0x17856F0 Offset: 0x17857F1 VA: 0x17856F0
	private void SetCompleteWithError(Exception exc) { }

	// RVA: 0x17886B0 Offset: 0x17887B1 VA: 0x17886B0
	private Socket InitDataConnection() { }

	// RVA: 0x1786F20 Offset: 0x1787021 VA: 0x1786F20
	private void OpenDataConnection() { }

	// RVA: 0x17874D0 Offset: 0x17875D1 VA: 0x17874D0
	private void Authenticate() { }

	// RVA: 0x1785C40 Offset: 0x1785D41 VA: 0x1785C40
	private FtpStatus SendCommand(string command, string[] parameters) { }

	// RVA: 0x1784260 Offset: 0x1784361 VA: 0x1784260
	private FtpStatus SendCommand(bool waitResponse, string command, string[] parameters) { }

	// RVA: 0x1788DF0 Offset: 0x1788EF1 VA: 0x1788DF0
	internal static FtpStatus ServiceNotAvailable() { }

	// RVA: 0x17857D0 Offset: 0x17858D1 VA: 0x17857D0
	internal FtpStatus GetResponseStatus() { }

	// RVA: 0x1788CD0 Offset: 0x1788DD1 VA: 0x1788CD0
	private void InitiateSecureConnection(ref Stream stream) { }

	// RVA: 0x1788AE0 Offset: 0x1788BE1 VA: 0x1788AE0
	internal bool ChangeToSSLSocket(ref Stream stream) { }

	// RVA: 0x1784450 Offset: 0x1784551 VA: 0x1784450
	private bool InFinalState() { }

	// RVA: 0x1785710 Offset: 0x1785811 VA: 0x1785710
	private bool InProgress() { }

	// RVA: 0x1781980 Offset: 0x1781A81 VA: 0x1781980
	internal void CheckIfAborted() { }

	// RVA: 0x1783F60 Offset: 0x1784061 VA: 0x1783F60
	private void CheckFinalState() { }

	// RVA: 0x1788E80 Offset: 0x1788F81 VA: 0x1788E80
	private static void .cctor() { }
}

public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 1971
{
	// Fields
	private Uri requestUri; // 0x20
	private string file_name; // 0x28
	private ServicePoint servicePoint; // 0x30
	private Stream origDataStream; // 0x38
	private Stream dataStream; // 0x40
	private Stream controlStream; // 0x48
	private StreamReader controlReader; // 0x50
	private NetworkCredential credentials; // 0x58
	private IPHostEntry hostEntry; // 0x60
	private IPEndPoint localEndPoint; // 0x68
	private IPEndPoint remoteEndPoint; // 0x70
	private IWebProxy proxy; // 0x78
	private int timeout; // 0x80
	private int rwTimeout; // 0x84
	private long offset; // 0x88
	private bool binary; // 0x90
	private bool enableSsl; // 0x91
	private bool usePassive; // 0x92
	private bool keepAlive; // 0x93
	private string method; // 0x98
	private string renameTo; // 0xA0
	private object locker; // 0xA8
	private FtpWebRequest.RequestState requestState; // 0xB0
	private FtpAsyncResult asyncResult; // 0xB8
	private FtpWebResponse ftpResponse; // 0xC0
	private Stream requestStream; // 0xC8
	private string initial_path; // 0xD0
	private static readonly string[] supportedCommands; // 0x0
	private Encoding dataEncoding; // 0xD8

	// Properties
	public override long ContentLength { get; }
	public override ICredentials Credentials { get; set; }
	public bool EnableSsl { get; }
	[MonoTODOAttribute] // RVA: 0xBDD10 Offset: 0xBDE11 VA: 0xBDD10
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override IWebProxy Proxy { get; }
	public int ReadWriteTimeout { get; }
	public override Uri RequestUri { get; }
	public ServicePoint ServicePoint { get; }
	public override int Timeout { get; }
	private string DataType { get; }
	private FtpWebRequest.RequestState State { get; set; }

	// Methods

	// RVA: 0x17834A0 Offset: 0x17835A1 VA: 0x17834A0
	internal void .ctor(Uri uri) { }

	// RVA: 0x1783760 Offset: 0x1783861 VA: 0x1783760
	private static Exception GetMustImplement() { }

	// RVA: 0x17837C0 Offset: 0x17838C1 VA: 0x17837C0 Slot: 12
	public override long get_ContentLength() { }

	// RVA: 0x17837D0 Offset: 0x17838D1 VA: 0x17837D0 Slot: 13
	public override ICredentials get_Credentials() { }

	// RVA: 0x17837E0 Offset: 0x17838E1 VA: 0x17837E0 Slot: 14
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x17839D0 Offset: 0x1783AD1 VA: 0x17839D0
	public bool get_EnableSsl() { }

	// RVA: 0x17839E0 Offset: 0x1783AE1 VA: 0x17839E0 Slot: 11
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1783A50 Offset: 0x1783B51 VA: 0x1783A50 Slot: 8
	public override string get_Method() { }

	// RVA: 0x1783A60 Offset: 0x1783B61 VA: 0x1783A60 Slot: 9
	public override void set_Method(string value) { }

	// RVA: 0x1783B90 Offset: 0x1783C91 VA: 0x1783B90 Slot: 15
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1783BA0 Offset: 0x1783CA1 VA: 0x1783BA0
	public int get_ReadWriteTimeout() { }

	// RVA: 0x1783BB0 Offset: 0x1783CB1 VA: 0x1783BB0 Slot: 10
	public override Uri get_RequestUri() { }

	// RVA: 0x1783BC0 Offset: 0x1783CC1 VA: 0x1783BC0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1783D40 Offset: 0x1783E41 VA: 0x1783D40 Slot: 16
	public override int get_Timeout() { }

	// RVA: 0x1783D50 Offset: 0x1783E51 VA: 0x1783D50
	private string get_DataType() { }

	// RVA: 0x1783DB0 Offset: 0x1783EB1 VA: 0x1783DB0
	private FtpWebRequest.RequestState get_State() { }

	// RVA: 0x1783E50 Offset: 0x1783F51 VA: 0x1783E50
	private void set_State(FtpWebRequest.RequestState value) { }

	// RVA: 0x1783FF0 Offset: 0x17840F1 VA: 0x1783FF0 Slot: 20
	public override void Abort() { }

	// RVA: 0x1784700 Offset: 0x1784801 VA: 0x1784700 Slot: 18
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1784A40 Offset: 0x1784B41 VA: 0x1784A40 Slot: 19
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1784BC0 Offset: 0x1784CC1 VA: 0x1784BC0 Slot: 17
	public override WebResponse GetResponse() { }

	// RVA: 0x1783C80 Offset: 0x1783D81 VA: 0x1783C80
	private ServicePoint GetServicePoint() { }

	// RVA: 0x1784C10 Offset: 0x1784D11 VA: 0x1784C10
	private void ResolveHost() { }

	// RVA: 0x1784DE0 Offset: 0x1784EE1 VA: 0x1784DE0
	private void ProcessRequest() { }

	// RVA: 0x1785AF0 Offset: 0x1785BF1 VA: 0x1785AF0
	private void SetType() { }

	// RVA: 0x1785D30 Offset: 0x1785E31 VA: 0x1785D30
	private string GetRemoteFolderPath(Uri uri) { }

	// RVA: 0x1785F00 Offset: 0x1786001 VA: 0x1785F00
	private void CWDAndSetFileName(Uri uri) { }

	// RVA: 0x17851D0 Offset: 0x17852D1 VA: 0x17851D0
	private void ProcessMethod() { }

	// RVA: 0x1786DA0 Offset: 0x1786EA1 VA: 0x1786DA0
	private void CloseControlConnection() { }

	// RVA: 0x1781A80 Offset: 0x1781B81 VA: 0x1781A80
	internal void CloseDataConnection() { }

	// RVA: 0x1786ED0 Offset: 0x1786FD1 VA: 0x1786ED0
	private void CloseConnection() { }

	// RVA: 0x17867F0 Offset: 0x17868F1 VA: 0x17867F0
	private void ProcessSimpleMethod() { }

	// RVA: 0x1786730 Offset: 0x1786831 VA: 0x1786730
	private void UploadData() { }

	// RVA: 0x1786680 Offset: 0x1786781 VA: 0x1786680
	private void DownloadData() { }

	// RVA: 0x17838D0 Offset: 0x17839D1 VA: 0x17838D0
	private void CheckRequestStarted() { }

	// RVA: 0x17860A0 Offset: 0x17861A1 VA: 0x17860A0
	private void OpenControlConnection() { }

	// RVA: 0x1787930 Offset: 0x1787A31 VA: 0x1787930
	private static string GetInitialPath(FtpStatus status) { }

	// RVA: 0x1787AC0 Offset: 0x1787BC1 VA: 0x1787AC0
	private Socket SetupPassiveConnection(string statusDescription, bool ipv6) { }

	// RVA: 0x1787CA0 Offset: 0x1787DA1 VA: 0x1787CA0
	private int GetPortV4(string responseString) { }

	// RVA: 0x1787EE0 Offset: 0x1787FE1 VA: 0x1787EE0
	private int GetPortV6(string responseString) { }

	// RVA: 0x17880A0 Offset: 0x17881A1 VA: 0x17880A0
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1788520 Offset: 0x1788621 VA: 0x1788520
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x1785C50 Offset: 0x1785D51 VA: 0x1785C50
	private Exception CreateExceptionFromResponse(FtpStatus status) { }

	// RVA: 0x1781AD0 Offset: 0x1781BD1 VA: 0x1781AD0
	internal void SetTransferCompleted() { }

	// RVA: 0x1788650 Offset: 0x1788751 VA: 0x1788650
	internal void OperationCompleted() { }

	// RVA: 0x17856F0 Offset: 0x17857F1 VA: 0x17856F0
	private void SetCompleteWithError(Exception exc) { }

	// RVA: 0x17886B0 Offset: 0x17887B1 VA: 0x17886B0
	private Socket InitDataConnection() { }

	// RVA: 0x1786F20 Offset: 0x1787021 VA: 0x1786F20
	private void OpenDataConnection() { }

	// RVA: 0x17874D0 Offset: 0x17875D1 VA: 0x17874D0
	private void Authenticate() { }

	// RVA: 0x1785C40 Offset: 0x1785D41 VA: 0x1785C40
	private FtpStatus SendCommand(string command, string[] parameters) { }

	// RVA: 0x1784260 Offset: 0x1784361 VA: 0x1784260
	private FtpStatus SendCommand(bool waitResponse, string command, string[] parameters) { }

	// RVA: 0x1788DF0 Offset: 0x1788EF1 VA: 0x1788DF0
	internal static FtpStatus ServiceNotAvailable() { }

	// RVA: 0x17857D0 Offset: 0x17858D1 VA: 0x17857D0
	internal FtpStatus GetResponseStatus() { }

	// RVA: 0x1788CD0 Offset: 0x1788DD1 VA: 0x1788CD0
	private void InitiateSecureConnection(ref Stream stream) { }

	// RVA: 0x1788AE0 Offset: 0x1788BE1 VA: 0x1788AE0
	internal bool ChangeToSSLSocket(ref Stream stream) { }

	// RVA: 0x1784450 Offset: 0x1784551 VA: 0x1784450
	private bool InFinalState() { }

	// RVA: 0x1785710 Offset: 0x1785811 VA: 0x1785710
	private bool InProgress() { }

	// RVA: 0x1781980 Offset: 0x1781A81 VA: 0x1781980
	internal void CheckIfAborted() { }

	// RVA: 0x1783F60 Offset: 0x1784061 VA: 0x1783F60
	private void CheckFinalState() { }

	// RVA: 0x1788E80 Offset: 0x1788F81 VA: 0x1788E80
	private static void .cctor() { }
}

public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 1971
{
	// Fields
	private Uri requestUri; // 0x20
	private string file_name; // 0x28
	private ServicePoint servicePoint; // 0x30
	private Stream origDataStream; // 0x38
	private Stream dataStream; // 0x40
	private Stream controlStream; // 0x48
	private StreamReader controlReader; // 0x50
	private NetworkCredential credentials; // 0x58
	private IPHostEntry hostEntry; // 0x60
	private IPEndPoint localEndPoint; // 0x68
	private IPEndPoint remoteEndPoint; // 0x70
	private IWebProxy proxy; // 0x78
	private int timeout; // 0x80
	private int rwTimeout; // 0x84
	private long offset; // 0x88
	private bool binary; // 0x90
	private bool enableSsl; // 0x91
	private bool usePassive; // 0x92
	private bool keepAlive; // 0x93
	private string method; // 0x98
	private string renameTo; // 0xA0
	private object locker; // 0xA8
	private FtpWebRequest.RequestState requestState; // 0xB0
	private FtpAsyncResult asyncResult; // 0xB8
	private FtpWebResponse ftpResponse; // 0xC0
	private Stream requestStream; // 0xC8
	private string initial_path; // 0xD0
	private static readonly string[] supportedCommands; // 0x0
	private Encoding dataEncoding; // 0xD8

	// Properties
	public override long ContentLength { get; }
	public override ICredentials Credentials { get; set; }
	public bool EnableSsl { get; }
	[MonoTODOAttribute] // RVA: 0xBDD10 Offset: 0xBDE11 VA: 0xBDD10
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override IWebProxy Proxy { get; }
	public int ReadWriteTimeout { get; }
	public override Uri RequestUri { get; }
	public ServicePoint ServicePoint { get; }
	public override int Timeout { get; }
	private string DataType { get; }
	private FtpWebRequest.RequestState State { get; set; }

	// Methods

	// RVA: 0x17834A0 Offset: 0x17835A1 VA: 0x17834A0
	internal void .ctor(Uri uri) { }

	// RVA: 0x1783760 Offset: 0x1783861 VA: 0x1783760
	private static Exception GetMustImplement() { }

	// RVA: 0x17837C0 Offset: 0x17838C1 VA: 0x17837C0 Slot: 12
	public override long get_ContentLength() { }

	// RVA: 0x17837D0 Offset: 0x17838D1 VA: 0x17837D0 Slot: 13
	public override ICredentials get_Credentials() { }

	// RVA: 0x17837E0 Offset: 0x17838E1 VA: 0x17837E0 Slot: 14
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x17839D0 Offset: 0x1783AD1 VA: 0x17839D0
	public bool get_EnableSsl() { }

	// RVA: 0x17839E0 Offset: 0x1783AE1 VA: 0x17839E0 Slot: 11
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1783A50 Offset: 0x1783B51 VA: 0x1783A50 Slot: 8
	public override string get_Method() { }

	// RVA: 0x1783A60 Offset: 0x1783B61 VA: 0x1783A60 Slot: 9
	public override void set_Method(string value) { }

	// RVA: 0x1783B90 Offset: 0x1783C91 VA: 0x1783B90 Slot: 15
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1783BA0 Offset: 0x1783CA1 VA: 0x1783BA0
	public int get_ReadWriteTimeout() { }

	// RVA: 0x1783BB0 Offset: 0x1783CB1 VA: 0x1783BB0 Slot: 10
	public override Uri get_RequestUri() { }

	// RVA: 0x1783BC0 Offset: 0x1783CC1 VA: 0x1783BC0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1783D40 Offset: 0x1783E41 VA: 0x1783D40 Slot: 16
	public override int get_Timeout() { }

	// RVA: 0x1783D50 Offset: 0x1783E51 VA: 0x1783D50
	private string get_DataType() { }

	// RVA: 0x1783DB0 Offset: 0x1783EB1 VA: 0x1783DB0
	private FtpWebRequest.RequestState get_State() { }

	// RVA: 0x1783E50 Offset: 0x1783F51 VA: 0x1783E50
	private void set_State(FtpWebRequest.RequestState value) { }

	// RVA: 0x1783FF0 Offset: 0x17840F1 VA: 0x1783FF0 Slot: 20
	public override void Abort() { }

	// RVA: 0x1784700 Offset: 0x1784801 VA: 0x1784700 Slot: 18
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1784A40 Offset: 0x1784B41 VA: 0x1784A40 Slot: 19
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1784BC0 Offset: 0x1784CC1 VA: 0x1784BC0 Slot: 17
	public override WebResponse GetResponse() { }

	// RVA: 0x1783C80 Offset: 0x1783D81 VA: 0x1783C80
	private ServicePoint GetServicePoint() { }

	// RVA: 0x1784C10 Offset: 0x1784D11 VA: 0x1784C10
	private void ResolveHost() { }

	// RVA: 0x1784DE0 Offset: 0x1784EE1 VA: 0x1784DE0
	private void ProcessRequest() { }

	// RVA: 0x1785AF0 Offset: 0x1785BF1 VA: 0x1785AF0
	private void SetType() { }

	// RVA: 0x1785D30 Offset: 0x1785E31 VA: 0x1785D30
	private string GetRemoteFolderPath(Uri uri) { }

	// RVA: 0x1785F00 Offset: 0x1786001 VA: 0x1785F00
	private void CWDAndSetFileName(Uri uri) { }

	// RVA: 0x17851D0 Offset: 0x17852D1 VA: 0x17851D0
	private void ProcessMethod() { }

	// RVA: 0x1786DA0 Offset: 0x1786EA1 VA: 0x1786DA0
	private void CloseControlConnection() { }

	// RVA: 0x1781A80 Offset: 0x1781B81 VA: 0x1781A80
	internal void CloseDataConnection() { }

	// RVA: 0x1786ED0 Offset: 0x1786FD1 VA: 0x1786ED0
	private void CloseConnection() { }

	// RVA: 0x17867F0 Offset: 0x17868F1 VA: 0x17867F0
	private void ProcessSimpleMethod() { }

	// RVA: 0x1786730 Offset: 0x1786831 VA: 0x1786730
	private void UploadData() { }

	// RVA: 0x1786680 Offset: 0x1786781 VA: 0x1786680
	private void DownloadData() { }

	// RVA: 0x17838D0 Offset: 0x17839D1 VA: 0x17838D0
	private void CheckRequestStarted() { }

	// RVA: 0x17860A0 Offset: 0x17861A1 VA: 0x17860A0
	private void OpenControlConnection() { }

	// RVA: 0x1787930 Offset: 0x1787A31 VA: 0x1787930
	private static string GetInitialPath(FtpStatus status) { }

	// RVA: 0x1787AC0 Offset: 0x1787BC1 VA: 0x1787AC0
	private Socket SetupPassiveConnection(string statusDescription, bool ipv6) { }

	// RVA: 0x1787CA0 Offset: 0x1787DA1 VA: 0x1787CA0
	private int GetPortV4(string responseString) { }

	// RVA: 0x1787EE0 Offset: 0x1787FE1 VA: 0x1787EE0
	private int GetPortV6(string responseString) { }

	// RVA: 0x17880A0 Offset: 0x17881A1 VA: 0x17880A0
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1788520 Offset: 0x1788621 VA: 0x1788520
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x1785C50 Offset: 0x1785D51 VA: 0x1785C50
	private Exception CreateExceptionFromResponse(FtpStatus status) { }

	// RVA: 0x1781AD0 Offset: 0x1781BD1 VA: 0x1781AD0
	internal void SetTransferCompleted() { }

	// RVA: 0x1788650 Offset: 0x1788751 VA: 0x1788650
	internal void OperationCompleted() { }

	// RVA: 0x17856F0 Offset: 0x17857F1 VA: 0x17856F0
	private void SetCompleteWithError(Exception exc) { }

	// RVA: 0x17886B0 Offset: 0x17887B1 VA: 0x17886B0
	private Socket InitDataConnection() { }

	// RVA: 0x1786F20 Offset: 0x1787021 VA: 0x1786F20
	private void OpenDataConnection() { }

	// RVA: 0x17874D0 Offset: 0x17875D1 VA: 0x17874D0
	private void Authenticate() { }

	// RVA: 0x1785C40 Offset: 0x1785D41 VA: 0x1785C40
	private FtpStatus SendCommand(string command, string[] parameters) { }

	// RVA: 0x1784260 Offset: 0x1784361 VA: 0x1784260
	private FtpStatus SendCommand(bool waitResponse, string command, string[] parameters) { }

	// RVA: 0x1788DF0 Offset: 0x1788EF1 VA: 0x1788DF0
	internal static FtpStatus ServiceNotAvailable() { }

	// RVA: 0x17857D0 Offset: 0x17858D1 VA: 0x17857D0
	internal FtpStatus GetResponseStatus() { }

	// RVA: 0x1788CD0 Offset: 0x1788DD1 VA: 0x1788CD0
	private void InitiateSecureConnection(ref Stream stream) { }

	// RVA: 0x1788AE0 Offset: 0x1788BE1 VA: 0x1788AE0
	internal bool ChangeToSSLSocket(ref Stream stream) { }

	// RVA: 0x1784450 Offset: 0x1784551 VA: 0x1784450
	private bool InFinalState() { }

	// RVA: 0x1785710 Offset: 0x1785811 VA: 0x1785710
	private bool InProgress() { }

	// RVA: 0x1781980 Offset: 0x1781A81 VA: 0x1781980
	internal void CheckIfAborted() { }

	// RVA: 0x1783F60 Offset: 0x1784061 VA: 0x1783F60
	private void CheckFinalState() { }

	// RVA: 0x1788E80 Offset: 0x1788F81 VA: 0x1788E80
	private static void .cctor() { }
}

public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 1971
{
	// Fields
	private Uri requestUri; // 0x20
	private string file_name; // 0x28
	private ServicePoint servicePoint; // 0x30
	private Stream origDataStream; // 0x38
	private Stream dataStream; // 0x40
	private Stream controlStream; // 0x48
	private StreamReader controlReader; // 0x50
	private NetworkCredential credentials; // 0x58
	private IPHostEntry hostEntry; // 0x60
	private IPEndPoint localEndPoint; // 0x68
	private IPEndPoint remoteEndPoint; // 0x70
	private IWebProxy proxy; // 0x78
	private int timeout; // 0x80
	private int rwTimeout; // 0x84
	private long offset; // 0x88
	private bool binary; // 0x90
	private bool enableSsl; // 0x91
	private bool usePassive; // 0x92
	private bool keepAlive; // 0x93
	private string method; // 0x98
	private string renameTo; // 0xA0
	private object locker; // 0xA8
	private FtpWebRequest.RequestState requestState; // 0xB0
	private FtpAsyncResult asyncResult; // 0xB8
	private FtpWebResponse ftpResponse; // 0xC0
	private Stream requestStream; // 0xC8
	private string initial_path; // 0xD0
	private static readonly string[] supportedCommands; // 0x0
	private Encoding dataEncoding; // 0xD8

	// Properties
	public override long ContentLength { get; }
	public override ICredentials Credentials { get; set; }
	public bool EnableSsl { get; }
	[MonoTODOAttribute] // RVA: 0xBDD10 Offset: 0xBDE11 VA: 0xBDD10
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override IWebProxy Proxy { get; }
	public int ReadWriteTimeout { get; }
	public override Uri RequestUri { get; }
	public ServicePoint ServicePoint { get; }
	public override int Timeout { get; }
	private string DataType { get; }
	private FtpWebRequest.RequestState State { get; set; }

	// Methods

	// RVA: 0x17834A0 Offset: 0x17835A1 VA: 0x17834A0
	internal void .ctor(Uri uri) { }

	// RVA: 0x1783760 Offset: 0x1783861 VA: 0x1783760
	private static Exception GetMustImplement() { }

	// RVA: 0x17837C0 Offset: 0x17838C1 VA: 0x17837C0 Slot: 12
	public override long get_ContentLength() { }

	// RVA: 0x17837D0 Offset: 0x17838D1 VA: 0x17837D0 Slot: 13
	public override ICredentials get_Credentials() { }

	// RVA: 0x17837E0 Offset: 0x17838E1 VA: 0x17837E0 Slot: 14
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x17839D0 Offset: 0x1783AD1 VA: 0x17839D0
	public bool get_EnableSsl() { }

	// RVA: 0x17839E0 Offset: 0x1783AE1 VA: 0x17839E0 Slot: 11
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1783A50 Offset: 0x1783B51 VA: 0x1783A50 Slot: 8
	public override string get_Method() { }

	// RVA: 0x1783A60 Offset: 0x1783B61 VA: 0x1783A60 Slot: 9
	public override void set_Method(string value) { }

	// RVA: 0x1783B90 Offset: 0x1783C91 VA: 0x1783B90 Slot: 15
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1783BA0 Offset: 0x1783CA1 VA: 0x1783BA0
	public int get_ReadWriteTimeout() { }

	// RVA: 0x1783BB0 Offset: 0x1783CB1 VA: 0x1783BB0 Slot: 10
	public override Uri get_RequestUri() { }

	// RVA: 0x1783BC0 Offset: 0x1783CC1 VA: 0x1783BC0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1783D40 Offset: 0x1783E41 VA: 0x1783D40 Slot: 16
	public override int get_Timeout() { }

	// RVA: 0x1783D50 Offset: 0x1783E51 VA: 0x1783D50
	private string get_DataType() { }

	// RVA: 0x1783DB0 Offset: 0x1783EB1 VA: 0x1783DB0
	private FtpWebRequest.RequestState get_State() { }

	// RVA: 0x1783E50 Offset: 0x1783F51 VA: 0x1783E50
	private void set_State(FtpWebRequest.RequestState value) { }

	// RVA: 0x1783FF0 Offset: 0x17840F1 VA: 0x1783FF0 Slot: 20
	public override void Abort() { }

	// RVA: 0x1784700 Offset: 0x1784801 VA: 0x1784700 Slot: 18
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1784A40 Offset: 0x1784B41 VA: 0x1784A40 Slot: 19
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1784BC0 Offset: 0x1784CC1 VA: 0x1784BC0 Slot: 17
	public override WebResponse GetResponse() { }

	// RVA: 0x1783C80 Offset: 0x1783D81 VA: 0x1783C80
	private ServicePoint GetServicePoint() { }

	// RVA: 0x1784C10 Offset: 0x1784D11 VA: 0x1784C10
	private void ResolveHost() { }

	// RVA: 0x1784DE0 Offset: 0x1784EE1 VA: 0x1784DE0
	private void ProcessRequest() { }

	// RVA: 0x1785AF0 Offset: 0x1785BF1 VA: 0x1785AF0
	private void SetType() { }

	// RVA: 0x1785D30 Offset: 0x1785E31 VA: 0x1785D30
	private string GetRemoteFolderPath(Uri uri) { }

	// RVA: 0x1785F00 Offset: 0x1786001 VA: 0x1785F00
	private void CWDAndSetFileName(Uri uri) { }

	// RVA: 0x17851D0 Offset: 0x17852D1 VA: 0x17851D0
	private void ProcessMethod() { }

	// RVA: 0x1786DA0 Offset: 0x1786EA1 VA: 0x1786DA0
	private void CloseControlConnection() { }

	// RVA: 0x1781A80 Offset: 0x1781B81 VA: 0x1781A80
	internal void CloseDataConnection() { }

	// RVA: 0x1786ED0 Offset: 0x1786FD1 VA: 0x1786ED0
	private void CloseConnection() { }

	// RVA: 0x17867F0 Offset: 0x17868F1 VA: 0x17867F0
	private void ProcessSimpleMethod() { }

	// RVA: 0x1786730 Offset: 0x1786831 VA: 0x1786730
	private void UploadData() { }

	// RVA: 0x1786680 Offset: 0x1786781 VA: 0x1786680
	private void DownloadData() { }

	// RVA: 0x17838D0 Offset: 0x17839D1 VA: 0x17838D0
	private void CheckRequestStarted() { }

	// RVA: 0x17860A0 Offset: 0x17861A1 VA: 0x17860A0
	private void OpenControlConnection() { }

	// RVA: 0x1787930 Offset: 0x1787A31 VA: 0x1787930
	private static string GetInitialPath(FtpStatus status) { }

	// RVA: 0x1787AC0 Offset: 0x1787BC1 VA: 0x1787AC0
	private Socket SetupPassiveConnection(string statusDescription, bool ipv6) { }

	// RVA: 0x1787CA0 Offset: 0x1787DA1 VA: 0x1787CA0
	private int GetPortV4(string responseString) { }

	// RVA: 0x1787EE0 Offset: 0x1787FE1 VA: 0x1787EE0
	private int GetPortV6(string responseString) { }

	// RVA: 0x17880A0 Offset: 0x17881A1 VA: 0x17880A0
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1788520 Offset: 0x1788621 VA: 0x1788520
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x1785C50 Offset: 0x1785D51 VA: 0x1785C50
	private Exception CreateExceptionFromResponse(FtpStatus status) { }

	// RVA: 0x1781AD0 Offset: 0x1781BD1 VA: 0x1781AD0
	internal void SetTransferCompleted() { }

	// RVA: 0x1788650 Offset: 0x1788751 VA: 0x1788650
	internal void OperationCompleted() { }

	// RVA: 0x17856F0 Offset: 0x17857F1 VA: 0x17856F0
	private void SetCompleteWithError(Exception exc) { }

	// RVA: 0x17886B0 Offset: 0x17887B1 VA: 0x17886B0
	private Socket InitDataConnection() { }

	// RVA: 0x1786F20 Offset: 0x1787021 VA: 0x1786F20
	private void OpenDataConnection() { }

	// RVA: 0x17874D0 Offset: 0x17875D1 VA: 0x17874D0
	private void Authenticate() { }

	// RVA: 0x1785C40 Offset: 0x1785D41 VA: 0x1785C40
	private FtpStatus SendCommand(string command, string[] parameters) { }

	// RVA: 0x1784260 Offset: 0x1784361 VA: 0x1784260
	private FtpStatus SendCommand(bool waitResponse, string command, string[] parameters) { }

	// RVA: 0x1788DF0 Offset: 0x1788EF1 VA: 0x1788DF0
	internal static FtpStatus ServiceNotAvailable() { }

	// RVA: 0x17857D0 Offset: 0x17858D1 VA: 0x17857D0
	internal FtpStatus GetResponseStatus() { }

	// RVA: 0x1788CD0 Offset: 0x1788DD1 VA: 0x1788CD0
	private void InitiateSecureConnection(ref Stream stream) { }

	// RVA: 0x1788AE0 Offset: 0x1788BE1 VA: 0x1788AE0
	internal bool ChangeToSSLSocket(ref Stream stream) { }

	// RVA: 0x1784450 Offset: 0x1784551 VA: 0x1784450
	private bool InFinalState() { }

	// RVA: 0x1785710 Offset: 0x1785811 VA: 0x1785710
	private bool InProgress() { }

	// RVA: 0x1781980 Offset: 0x1781A81 VA: 0x1781980
	internal void CheckIfAborted() { }

	// RVA: 0x1783F60 Offset: 0x1784061 VA: 0x1783F60
	private void CheckFinalState() { }

	// RVA: 0x1788E80 Offset: 0x1788F81 VA: 0x1788E80
	private static void .cctor() { }
}

