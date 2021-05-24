internal class WebConnection // TypeDefIndex: 1996
{
	// Fields
	private ServicePoint sPoint; // 0x10
	private Stream nstream; // 0x18
	internal Socket socket; // 0x20
	private object socketLock; // 0x28
	private IWebConnectionState state; // 0x30
	private WebExceptionStatus status; // 0x38
	private bool keepAlive; // 0x3C
	private byte[] buffer; // 0x40
	private EventHandler abortHandler; // 0x48
	private WebConnection.AbortHelper abortHelper; // 0x50
	internal WebConnectionData Data; // 0x58
	private bool chunkedRead; // 0x60
	private MonoChunkStream chunkStream; // 0x68
	private Queue queue; // 0x70
	private bool reused; // 0x78
	private int position; // 0x7C
	private HttpWebRequest priority_request; // 0x80
	private NetworkCredential ntlm_credentials; // 0x88
	private bool ntlm_authenticated; // 0x90
	private bool unsafe_sharing; // 0x91
	private WebConnection.NtlmAuthState connect_ntlm_auth_state; // 0x94
	private HttpWebRequest connect_request; // 0x98
	private Exception connect_exception; // 0xA0
	private MonoTlsStream tlsStream; // 0xA8

	// Properties
	internal HttpWebRequest PriorityRequest { set; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	// RVA: 0x16E1060 Offset: 0x16E1161 VA: 0x16E1060
	public void .ctor(IWebConnectionState wcs, ServicePoint sPoint) { }

	// RVA: 0x16E1270 Offset: 0x16E1371 VA: 0x16E1270
	private bool CanReuse() { }

	// RVA: 0x16E12A0 Offset: 0x16E13A1 VA: 0x16E12A0
	private void Connect(HttpWebRequest request) { }

	// RVA: 0x16E1B70 Offset: 0x16E1C71 VA: 0x16E1B70
	private bool CreateTunnel(HttpWebRequest request, Uri connectUri, Stream stream, out byte[] buffer) { }

	// RVA: 0x16E24C0 Offset: 0x16E25C1 VA: 0x16E24C0
	private WebHeaderCollection ReadHeaders(Stream stream, out byte[] retBuffer, out int status) { }

	// RVA: 0x16E2C80 Offset: 0x16E2D81 VA: 0x16E2C80
	private void FlushContents(Stream stream, int contentLength) { }

	// RVA: 0x16E2FB0 Offset: 0x16E30B1 VA: 0x16E2FB0
	private bool CreateStream(HttpWebRequest request) { }

	// RVA: 0x16E2A20 Offset: 0x16E2B21 VA: 0x16E2A20
	private void HandleError(WebExceptionStatus st, Exception e, string where) { }

	// RVA: 0x16E3720 Offset: 0x16E3821 VA: 0x16E3720
	private void ReadDone(IAsyncResult result) { }

	// RVA: 0x16E4920 Offset: 0x16E4A21 VA: 0x16E4920
	private static bool ExpectContent(int statusCode, string method) { }

	// RVA: 0x16E47B0 Offset: 0x16E48B1 VA: 0x16E47B0
	internal void InitRead() { }

	// RVA: 0x16E3E20 Offset: 0x16E3F21 VA: 0x16E3E20
	private static int GetResponse(WebConnectionData data, ServicePoint sPoint, byte[] buffer, int max) { }

	// RVA: 0x16E49C0 Offset: 0x16E4AC1 VA: 0x16E49C0
	private void InitConnection(HttpWebRequest request) { }

	// RVA: 0x16CDEE0 Offset: 0x16CDFE1 VA: 0x16CDEE0
	internal EventHandler SendRequest(HttpWebRequest request) { }

	// RVA: 0x16E4CA0 Offset: 0x16E4DA1 VA: 0x16E4CA0
	private void SendNext() { }

	// RVA: 0x16E4E10 Offset: 0x16E4F11 VA: 0x16E4E10
	internal void NextRead() { }

	// RVA: 0x16E2D40 Offset: 0x16E2E41 VA: 0x16E2D40
	private static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x16E52D0 Offset: 0x16E53D1 VA: 0x16E52D0
	internal IAsyncResult BeginRead(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x16E56C0 Offset: 0x16E57C1 VA: 0x16E56C0
	internal int EndRead(HttpWebRequest request, IAsyncResult result) { }

	// RVA: 0x16E5D90 Offset: 0x16E5E91 VA: 0x16E5D90
	private int EnsureRead(byte[] buffer, int offset, int size) { }

	// RVA: 0x16E1AC0 Offset: 0x16E1BC1 VA: 0x16E1AC0
	private bool CompleteChunkedRead() { }

	// RVA: 0x16E5EE0 Offset: 0x16E5FE1 VA: 0x16E5EE0
	internal IAsyncResult BeginWrite(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x16E6350 Offset: 0x16E6451 VA: 0x16E6350
	internal bool EndWrite(HttpWebRequest request, bool throwOnError, IAsyncResult result) { }

	// RVA: 0x16E6720 Offset: 0x16E6821 VA: 0x16E6720
	internal int Read(HttpWebRequest request, byte[] buffer, int offset, int size) { }

	// RVA: 0x16E6C20 Offset: 0x16E6D21 VA: 0x16E6C20
	internal bool Write(HttpWebRequest request, byte[] buffer, int offset, int size, ref string err_msg) { }

	// RVA: 0x16E32A0 Offset: 0x16E33A1 VA: 0x16E32A0
	internal void Close(bool sendNext) { }

	// RVA: 0x16E6F90 Offset: 0x16E7091 VA: 0x16E6F90
	private void Abort(object sender, EventArgs args) { }

	// RVA: 0x16E6F50 Offset: 0x16E7051 VA: 0x16E6F50
	internal void ResetNtlm() { }

	// RVA: 0x16E74A0 Offset: 0x16E75A1 VA: 0x16E74A0
	internal void set_PriorityRequest(HttpWebRequest value) { }

	// RVA: 0x16E74B0 Offset: 0x16E75B1 VA: 0x16E74B0
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x16E74C0 Offset: 0x16E75C1 VA: 0x16E74C0
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x16E74D0 Offset: 0x16E75D1 VA: 0x16E74D0
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x16E74E0 Offset: 0x16E75E1 VA: 0x16E74E0
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x16E74F0 Offset: 0x16E75F1 VA: 0x16E74F0
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x16E7500 Offset: 0x16E7601 VA: 0x16E7500
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBDAA0 Offset: 0xBDBA1 VA: 0xBDAA0
	// RVA: 0x16E7510 Offset: 0x16E7611 VA: 0x16E7510
	private void <SendRequest>b__41_0(object o) { }
}

internal class WebConnection // TypeDefIndex: 1996
{
	// Fields
	private ServicePoint sPoint; // 0x10
	private Stream nstream; // 0x18
	internal Socket socket; // 0x20
	private object socketLock; // 0x28
	private IWebConnectionState state; // 0x30
	private WebExceptionStatus status; // 0x38
	private bool keepAlive; // 0x3C
	private byte[] buffer; // 0x40
	private EventHandler abortHandler; // 0x48
	private WebConnection.AbortHelper abortHelper; // 0x50
	internal WebConnectionData Data; // 0x58
	private bool chunkedRead; // 0x60
	private MonoChunkStream chunkStream; // 0x68
	private Queue queue; // 0x70
	private bool reused; // 0x78
	private int position; // 0x7C
	private HttpWebRequest priority_request; // 0x80
	private NetworkCredential ntlm_credentials; // 0x88
	private bool ntlm_authenticated; // 0x90
	private bool unsafe_sharing; // 0x91
	private WebConnection.NtlmAuthState connect_ntlm_auth_state; // 0x94
	private HttpWebRequest connect_request; // 0x98
	private Exception connect_exception; // 0xA0
	private MonoTlsStream tlsStream; // 0xA8

	// Properties
	internal HttpWebRequest PriorityRequest { set; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	// RVA: 0x16E1060 Offset: 0x16E1161 VA: 0x16E1060
	public void .ctor(IWebConnectionState wcs, ServicePoint sPoint) { }

	// RVA: 0x16E1270 Offset: 0x16E1371 VA: 0x16E1270
	private bool CanReuse() { }

	// RVA: 0x16E12A0 Offset: 0x16E13A1 VA: 0x16E12A0
	private void Connect(HttpWebRequest request) { }

	// RVA: 0x16E1B70 Offset: 0x16E1C71 VA: 0x16E1B70
	private bool CreateTunnel(HttpWebRequest request, Uri connectUri, Stream stream, out byte[] buffer) { }

	// RVA: 0x16E24C0 Offset: 0x16E25C1 VA: 0x16E24C0
	private WebHeaderCollection ReadHeaders(Stream stream, out byte[] retBuffer, out int status) { }

	// RVA: 0x16E2C80 Offset: 0x16E2D81 VA: 0x16E2C80
	private void FlushContents(Stream stream, int contentLength) { }

	// RVA: 0x16E2FB0 Offset: 0x16E30B1 VA: 0x16E2FB0
	private bool CreateStream(HttpWebRequest request) { }

	// RVA: 0x16E2A20 Offset: 0x16E2B21 VA: 0x16E2A20
	private void HandleError(WebExceptionStatus st, Exception e, string where) { }

	// RVA: 0x16E3720 Offset: 0x16E3821 VA: 0x16E3720
	private void ReadDone(IAsyncResult result) { }

	// RVA: 0x16E4920 Offset: 0x16E4A21 VA: 0x16E4920
	private static bool ExpectContent(int statusCode, string method) { }

	// RVA: 0x16E47B0 Offset: 0x16E48B1 VA: 0x16E47B0
	internal void InitRead() { }

	// RVA: 0x16E3E20 Offset: 0x16E3F21 VA: 0x16E3E20
	private static int GetResponse(WebConnectionData data, ServicePoint sPoint, byte[] buffer, int max) { }

	// RVA: 0x16E49C0 Offset: 0x16E4AC1 VA: 0x16E49C0
	private void InitConnection(HttpWebRequest request) { }

	// RVA: 0x16CDEE0 Offset: 0x16CDFE1 VA: 0x16CDEE0
	internal EventHandler SendRequest(HttpWebRequest request) { }

	// RVA: 0x16E4CA0 Offset: 0x16E4DA1 VA: 0x16E4CA0
	private void SendNext() { }

	// RVA: 0x16E4E10 Offset: 0x16E4F11 VA: 0x16E4E10
	internal void NextRead() { }

	// RVA: 0x16E2D40 Offset: 0x16E2E41 VA: 0x16E2D40
	private static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x16E52D0 Offset: 0x16E53D1 VA: 0x16E52D0
	internal IAsyncResult BeginRead(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x16E56C0 Offset: 0x16E57C1 VA: 0x16E56C0
	internal int EndRead(HttpWebRequest request, IAsyncResult result) { }

	// RVA: 0x16E5D90 Offset: 0x16E5E91 VA: 0x16E5D90
	private int EnsureRead(byte[] buffer, int offset, int size) { }

	// RVA: 0x16E1AC0 Offset: 0x16E1BC1 VA: 0x16E1AC0
	private bool CompleteChunkedRead() { }

	// RVA: 0x16E5EE0 Offset: 0x16E5FE1 VA: 0x16E5EE0
	internal IAsyncResult BeginWrite(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x16E6350 Offset: 0x16E6451 VA: 0x16E6350
	internal bool EndWrite(HttpWebRequest request, bool throwOnError, IAsyncResult result) { }

	// RVA: 0x16E6720 Offset: 0x16E6821 VA: 0x16E6720
	internal int Read(HttpWebRequest request, byte[] buffer, int offset, int size) { }

	// RVA: 0x16E6C20 Offset: 0x16E6D21 VA: 0x16E6C20
	internal bool Write(HttpWebRequest request, byte[] buffer, int offset, int size, ref string err_msg) { }

	// RVA: 0x16E32A0 Offset: 0x16E33A1 VA: 0x16E32A0
	internal void Close(bool sendNext) { }

	// RVA: 0x16E6F90 Offset: 0x16E7091 VA: 0x16E6F90
	private void Abort(object sender, EventArgs args) { }

	// RVA: 0x16E6F50 Offset: 0x16E7051 VA: 0x16E6F50
	internal void ResetNtlm() { }

	// RVA: 0x16E74A0 Offset: 0x16E75A1 VA: 0x16E74A0
	internal void set_PriorityRequest(HttpWebRequest value) { }

	// RVA: 0x16E74B0 Offset: 0x16E75B1 VA: 0x16E74B0
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x16E74C0 Offset: 0x16E75C1 VA: 0x16E74C0
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x16E74D0 Offset: 0x16E75D1 VA: 0x16E74D0
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x16E74E0 Offset: 0x16E75E1 VA: 0x16E74E0
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x16E74F0 Offset: 0x16E75F1 VA: 0x16E74F0
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x16E7500 Offset: 0x16E7601 VA: 0x16E7500
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBDAA0 Offset: 0xBDBA1 VA: 0xBDAA0
	// RVA: 0x16E7510 Offset: 0x16E7611 VA: 0x16E7510
	private void <SendRequest>b__41_0(object o) { }
}

internal class WebConnection // TypeDefIndex: 1996
{
	// Fields
	private ServicePoint sPoint; // 0x10
	private Stream nstream; // 0x18
	internal Socket socket; // 0x20
	private object socketLock; // 0x28
	private IWebConnectionState state; // 0x30
	private WebExceptionStatus status; // 0x38
	private bool keepAlive; // 0x3C
	private byte[] buffer; // 0x40
	private EventHandler abortHandler; // 0x48
	private WebConnection.AbortHelper abortHelper; // 0x50
	internal WebConnectionData Data; // 0x58
	private bool chunkedRead; // 0x60
	private MonoChunkStream chunkStream; // 0x68
	private Queue queue; // 0x70
	private bool reused; // 0x78
	private int position; // 0x7C
	private HttpWebRequest priority_request; // 0x80
	private NetworkCredential ntlm_credentials; // 0x88
	private bool ntlm_authenticated; // 0x90
	private bool unsafe_sharing; // 0x91
	private WebConnection.NtlmAuthState connect_ntlm_auth_state; // 0x94
	private HttpWebRequest connect_request; // 0x98
	private Exception connect_exception; // 0xA0
	private MonoTlsStream tlsStream; // 0xA8

	// Properties
	internal HttpWebRequest PriorityRequest { set; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	// RVA: 0x16E1060 Offset: 0x16E1161 VA: 0x16E1060
	public void .ctor(IWebConnectionState wcs, ServicePoint sPoint) { }

	// RVA: 0x16E1270 Offset: 0x16E1371 VA: 0x16E1270
	private bool CanReuse() { }

	// RVA: 0x16E12A0 Offset: 0x16E13A1 VA: 0x16E12A0
	private void Connect(HttpWebRequest request) { }

	// RVA: 0x16E1B70 Offset: 0x16E1C71 VA: 0x16E1B70
	private bool CreateTunnel(HttpWebRequest request, Uri connectUri, Stream stream, out byte[] buffer) { }

	// RVA: 0x16E24C0 Offset: 0x16E25C1 VA: 0x16E24C0
	private WebHeaderCollection ReadHeaders(Stream stream, out byte[] retBuffer, out int status) { }

	// RVA: 0x16E2C80 Offset: 0x16E2D81 VA: 0x16E2C80
	private void FlushContents(Stream stream, int contentLength) { }

	// RVA: 0x16E2FB0 Offset: 0x16E30B1 VA: 0x16E2FB0
	private bool CreateStream(HttpWebRequest request) { }

	// RVA: 0x16E2A20 Offset: 0x16E2B21 VA: 0x16E2A20
	private void HandleError(WebExceptionStatus st, Exception e, string where) { }

	// RVA: 0x16E3720 Offset: 0x16E3821 VA: 0x16E3720
	private void ReadDone(IAsyncResult result) { }

	// RVA: 0x16E4920 Offset: 0x16E4A21 VA: 0x16E4920
	private static bool ExpectContent(int statusCode, string method) { }

	// RVA: 0x16E47B0 Offset: 0x16E48B1 VA: 0x16E47B0
	internal void InitRead() { }

	// RVA: 0x16E3E20 Offset: 0x16E3F21 VA: 0x16E3E20
	private static int GetResponse(WebConnectionData data, ServicePoint sPoint, byte[] buffer, int max) { }

	// RVA: 0x16E49C0 Offset: 0x16E4AC1 VA: 0x16E49C0
	private void InitConnection(HttpWebRequest request) { }

	// RVA: 0x16CDEE0 Offset: 0x16CDFE1 VA: 0x16CDEE0
	internal EventHandler SendRequest(HttpWebRequest request) { }

	// RVA: 0x16E4CA0 Offset: 0x16E4DA1 VA: 0x16E4CA0
	private void SendNext() { }

	// RVA: 0x16E4E10 Offset: 0x16E4F11 VA: 0x16E4E10
	internal void NextRead() { }

	// RVA: 0x16E2D40 Offset: 0x16E2E41 VA: 0x16E2D40
	private static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x16E52D0 Offset: 0x16E53D1 VA: 0x16E52D0
	internal IAsyncResult BeginRead(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x16E56C0 Offset: 0x16E57C1 VA: 0x16E56C0
	internal int EndRead(HttpWebRequest request, IAsyncResult result) { }

	// RVA: 0x16E5D90 Offset: 0x16E5E91 VA: 0x16E5D90
	private int EnsureRead(byte[] buffer, int offset, int size) { }

	// RVA: 0x16E1AC0 Offset: 0x16E1BC1 VA: 0x16E1AC0
	private bool CompleteChunkedRead() { }

	// RVA: 0x16E5EE0 Offset: 0x16E5FE1 VA: 0x16E5EE0
	internal IAsyncResult BeginWrite(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x16E6350 Offset: 0x16E6451 VA: 0x16E6350
	internal bool EndWrite(HttpWebRequest request, bool throwOnError, IAsyncResult result) { }

	// RVA: 0x16E6720 Offset: 0x16E6821 VA: 0x16E6720
	internal int Read(HttpWebRequest request, byte[] buffer, int offset, int size) { }

	// RVA: 0x16E6C20 Offset: 0x16E6D21 VA: 0x16E6C20
	internal bool Write(HttpWebRequest request, byte[] buffer, int offset, int size, ref string err_msg) { }

	// RVA: 0x16E32A0 Offset: 0x16E33A1 VA: 0x16E32A0
	internal void Close(bool sendNext) { }

	// RVA: 0x16E6F90 Offset: 0x16E7091 VA: 0x16E6F90
	private void Abort(object sender, EventArgs args) { }

	// RVA: 0x16E6F50 Offset: 0x16E7051 VA: 0x16E6F50
	internal void ResetNtlm() { }

	// RVA: 0x16E74A0 Offset: 0x16E75A1 VA: 0x16E74A0
	internal void set_PriorityRequest(HttpWebRequest value) { }

	// RVA: 0x16E74B0 Offset: 0x16E75B1 VA: 0x16E74B0
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x16E74C0 Offset: 0x16E75C1 VA: 0x16E74C0
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x16E74D0 Offset: 0x16E75D1 VA: 0x16E74D0
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x16E74E0 Offset: 0x16E75E1 VA: 0x16E74E0
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x16E74F0 Offset: 0x16E75F1 VA: 0x16E74F0
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x16E7500 Offset: 0x16E7601 VA: 0x16E7500
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBDAA0 Offset: 0xBDBA1 VA: 0xBDAA0
	// RVA: 0x16E7510 Offset: 0x16E7611 VA: 0x16E7510
	private void <SendRequest>b__41_0(object o) { }
}

internal class WebConnection // TypeDefIndex: 1996
{
	// Fields
	private ServicePoint sPoint; // 0x10
	private Stream nstream; // 0x18
	internal Socket socket; // 0x20
	private object socketLock; // 0x28
	private IWebConnectionState state; // 0x30
	private WebExceptionStatus status; // 0x38
	private bool keepAlive; // 0x3C
	private byte[] buffer; // 0x40
	private EventHandler abortHandler; // 0x48
	private WebConnection.AbortHelper abortHelper; // 0x50
	internal WebConnectionData Data; // 0x58
	private bool chunkedRead; // 0x60
	private MonoChunkStream chunkStream; // 0x68
	private Queue queue; // 0x70
	private bool reused; // 0x78
	private int position; // 0x7C
	private HttpWebRequest priority_request; // 0x80
	private NetworkCredential ntlm_credentials; // 0x88
	private bool ntlm_authenticated; // 0x90
	private bool unsafe_sharing; // 0x91
	private WebConnection.NtlmAuthState connect_ntlm_auth_state; // 0x94
	private HttpWebRequest connect_request; // 0x98
	private Exception connect_exception; // 0xA0
	private MonoTlsStream tlsStream; // 0xA8

	// Properties
	internal HttpWebRequest PriorityRequest { set; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	// RVA: 0x16E1060 Offset: 0x16E1161 VA: 0x16E1060
	public void .ctor(IWebConnectionState wcs, ServicePoint sPoint) { }

	// RVA: 0x16E1270 Offset: 0x16E1371 VA: 0x16E1270
	private bool CanReuse() { }

	// RVA: 0x16E12A0 Offset: 0x16E13A1 VA: 0x16E12A0
	private void Connect(HttpWebRequest request) { }

	// RVA: 0x16E1B70 Offset: 0x16E1C71 VA: 0x16E1B70
	private bool CreateTunnel(HttpWebRequest request, Uri connectUri, Stream stream, out byte[] buffer) { }

	// RVA: 0x16E24C0 Offset: 0x16E25C1 VA: 0x16E24C0
	private WebHeaderCollection ReadHeaders(Stream stream, out byte[] retBuffer, out int status) { }

	// RVA: 0x16E2C80 Offset: 0x16E2D81 VA: 0x16E2C80
	private void FlushContents(Stream stream, int contentLength) { }

	// RVA: 0x16E2FB0 Offset: 0x16E30B1 VA: 0x16E2FB0
	private bool CreateStream(HttpWebRequest request) { }

	// RVA: 0x16E2A20 Offset: 0x16E2B21 VA: 0x16E2A20
	private void HandleError(WebExceptionStatus st, Exception e, string where) { }

	// RVA: 0x16E3720 Offset: 0x16E3821 VA: 0x16E3720
	private void ReadDone(IAsyncResult result) { }

	// RVA: 0x16E4920 Offset: 0x16E4A21 VA: 0x16E4920
	private static bool ExpectContent(int statusCode, string method) { }

	// RVA: 0x16E47B0 Offset: 0x16E48B1 VA: 0x16E47B0
	internal void InitRead() { }

	// RVA: 0x16E3E20 Offset: 0x16E3F21 VA: 0x16E3E20
	private static int GetResponse(WebConnectionData data, ServicePoint sPoint, byte[] buffer, int max) { }

	// RVA: 0x16E49C0 Offset: 0x16E4AC1 VA: 0x16E49C0
	private void InitConnection(HttpWebRequest request) { }

	// RVA: 0x16CDEE0 Offset: 0x16CDFE1 VA: 0x16CDEE0
	internal EventHandler SendRequest(HttpWebRequest request) { }

	// RVA: 0x16E4CA0 Offset: 0x16E4DA1 VA: 0x16E4CA0
	private void SendNext() { }

	// RVA: 0x16E4E10 Offset: 0x16E4F11 VA: 0x16E4E10
	internal void NextRead() { }

	// RVA: 0x16E2D40 Offset: 0x16E2E41 VA: 0x16E2D40
	private static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x16E52D0 Offset: 0x16E53D1 VA: 0x16E52D0
	internal IAsyncResult BeginRead(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x16E56C0 Offset: 0x16E57C1 VA: 0x16E56C0
	internal int EndRead(HttpWebRequest request, IAsyncResult result) { }

	// RVA: 0x16E5D90 Offset: 0x16E5E91 VA: 0x16E5D90
	private int EnsureRead(byte[] buffer, int offset, int size) { }

	// RVA: 0x16E1AC0 Offset: 0x16E1BC1 VA: 0x16E1AC0
	private bool CompleteChunkedRead() { }

	// RVA: 0x16E5EE0 Offset: 0x16E5FE1 VA: 0x16E5EE0
	internal IAsyncResult BeginWrite(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x16E6350 Offset: 0x16E6451 VA: 0x16E6350
	internal bool EndWrite(HttpWebRequest request, bool throwOnError, IAsyncResult result) { }

	// RVA: 0x16E6720 Offset: 0x16E6821 VA: 0x16E6720
	internal int Read(HttpWebRequest request, byte[] buffer, int offset, int size) { }

	// RVA: 0x16E6C20 Offset: 0x16E6D21 VA: 0x16E6C20
	internal bool Write(HttpWebRequest request, byte[] buffer, int offset, int size, ref string err_msg) { }

	// RVA: 0x16E32A0 Offset: 0x16E33A1 VA: 0x16E32A0
	internal void Close(bool sendNext) { }

	// RVA: 0x16E6F90 Offset: 0x16E7091 VA: 0x16E6F90
	private void Abort(object sender, EventArgs args) { }

	// RVA: 0x16E6F50 Offset: 0x16E7051 VA: 0x16E6F50
	internal void ResetNtlm() { }

	// RVA: 0x16E74A0 Offset: 0x16E75A1 VA: 0x16E74A0
	internal void set_PriorityRequest(HttpWebRequest value) { }

	// RVA: 0x16E74B0 Offset: 0x16E75B1 VA: 0x16E74B0
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x16E74C0 Offset: 0x16E75C1 VA: 0x16E74C0
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x16E74D0 Offset: 0x16E75D1 VA: 0x16E74D0
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x16E74E0 Offset: 0x16E75E1 VA: 0x16E74E0
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x16E74F0 Offset: 0x16E75F1 VA: 0x16E74F0
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x16E7500 Offset: 0x16E7601 VA: 0x16E7500
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBDAA0 Offset: 0xBDBA1 VA: 0xBDAA0
	// RVA: 0x16E7510 Offset: 0x16E7611 VA: 0x16E7510
	private void <SendRequest>b__41_0(object o) { }
}

internal class WebConnection // TypeDefIndex: 1996
{
	// Fields
	private ServicePoint sPoint; // 0x10
	private Stream nstream; // 0x18
	internal Socket socket; // 0x20
	private object socketLock; // 0x28
	private IWebConnectionState state; // 0x30
	private WebExceptionStatus status; // 0x38
	private bool keepAlive; // 0x3C
	private byte[] buffer; // 0x40
	private EventHandler abortHandler; // 0x48
	private WebConnection.AbortHelper abortHelper; // 0x50
	internal WebConnectionData Data; // 0x58
	private bool chunkedRead; // 0x60
	private MonoChunkStream chunkStream; // 0x68
	private Queue queue; // 0x70
	private bool reused; // 0x78
	private int position; // 0x7C
	private HttpWebRequest priority_request; // 0x80
	private NetworkCredential ntlm_credentials; // 0x88
	private bool ntlm_authenticated; // 0x90
	private bool unsafe_sharing; // 0x91
	private WebConnection.NtlmAuthState connect_ntlm_auth_state; // 0x94
	private HttpWebRequest connect_request; // 0x98
	private Exception connect_exception; // 0xA0
	private MonoTlsStream tlsStream; // 0xA8

	// Properties
	internal HttpWebRequest PriorityRequest { set; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	// RVA: 0x16E1060 Offset: 0x16E1161 VA: 0x16E1060
	public void .ctor(IWebConnectionState wcs, ServicePoint sPoint) { }

	// RVA: 0x16E1270 Offset: 0x16E1371 VA: 0x16E1270
	private bool CanReuse() { }

	// RVA: 0x16E12A0 Offset: 0x16E13A1 VA: 0x16E12A0
	private void Connect(HttpWebRequest request) { }

	// RVA: 0x16E1B70 Offset: 0x16E1C71 VA: 0x16E1B70
	private bool CreateTunnel(HttpWebRequest request, Uri connectUri, Stream stream, out byte[] buffer) { }

	// RVA: 0x16E24C0 Offset: 0x16E25C1 VA: 0x16E24C0
	private WebHeaderCollection ReadHeaders(Stream stream, out byte[] retBuffer, out int status) { }

	// RVA: 0x16E2C80 Offset: 0x16E2D81 VA: 0x16E2C80
	private void FlushContents(Stream stream, int contentLength) { }

	// RVA: 0x16E2FB0 Offset: 0x16E30B1 VA: 0x16E2FB0
	private bool CreateStream(HttpWebRequest request) { }

	// RVA: 0x16E2A20 Offset: 0x16E2B21 VA: 0x16E2A20
	private void HandleError(WebExceptionStatus st, Exception e, string where) { }

	// RVA: 0x16E3720 Offset: 0x16E3821 VA: 0x16E3720
	private void ReadDone(IAsyncResult result) { }

	// RVA: 0x16E4920 Offset: 0x16E4A21 VA: 0x16E4920
	private static bool ExpectContent(int statusCode, string method) { }

	// RVA: 0x16E47B0 Offset: 0x16E48B1 VA: 0x16E47B0
	internal void InitRead() { }

	// RVA: 0x16E3E20 Offset: 0x16E3F21 VA: 0x16E3E20
	private static int GetResponse(WebConnectionData data, ServicePoint sPoint, byte[] buffer, int max) { }

	// RVA: 0x16E49C0 Offset: 0x16E4AC1 VA: 0x16E49C0
	private void InitConnection(HttpWebRequest request) { }

	// RVA: 0x16CDEE0 Offset: 0x16CDFE1 VA: 0x16CDEE0
	internal EventHandler SendRequest(HttpWebRequest request) { }

	// RVA: 0x16E4CA0 Offset: 0x16E4DA1 VA: 0x16E4CA0
	private void SendNext() { }

	// RVA: 0x16E4E10 Offset: 0x16E4F11 VA: 0x16E4E10
	internal void NextRead() { }

	// RVA: 0x16E2D40 Offset: 0x16E2E41 VA: 0x16E2D40
	private static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x16E52D0 Offset: 0x16E53D1 VA: 0x16E52D0
	internal IAsyncResult BeginRead(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x16E56C0 Offset: 0x16E57C1 VA: 0x16E56C0
	internal int EndRead(HttpWebRequest request, IAsyncResult result) { }

	// RVA: 0x16E5D90 Offset: 0x16E5E91 VA: 0x16E5D90
	private int EnsureRead(byte[] buffer, int offset, int size) { }

	// RVA: 0x16E1AC0 Offset: 0x16E1BC1 VA: 0x16E1AC0
	private bool CompleteChunkedRead() { }

	// RVA: 0x16E5EE0 Offset: 0x16E5FE1 VA: 0x16E5EE0
	internal IAsyncResult BeginWrite(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x16E6350 Offset: 0x16E6451 VA: 0x16E6350
	internal bool EndWrite(HttpWebRequest request, bool throwOnError, IAsyncResult result) { }

	// RVA: 0x16E6720 Offset: 0x16E6821 VA: 0x16E6720
	internal int Read(HttpWebRequest request, byte[] buffer, int offset, int size) { }

	// RVA: 0x16E6C20 Offset: 0x16E6D21 VA: 0x16E6C20
	internal bool Write(HttpWebRequest request, byte[] buffer, int offset, int size, ref string err_msg) { }

	// RVA: 0x16E32A0 Offset: 0x16E33A1 VA: 0x16E32A0
	internal void Close(bool sendNext) { }

	// RVA: 0x16E6F90 Offset: 0x16E7091 VA: 0x16E6F90
	private void Abort(object sender, EventArgs args) { }

	// RVA: 0x16E6F50 Offset: 0x16E7051 VA: 0x16E6F50
	internal void ResetNtlm() { }

	// RVA: 0x16E74A0 Offset: 0x16E75A1 VA: 0x16E74A0
	internal void set_PriorityRequest(HttpWebRequest value) { }

	// RVA: 0x16E74B0 Offset: 0x16E75B1 VA: 0x16E74B0
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x16E74C0 Offset: 0x16E75C1 VA: 0x16E74C0
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x16E74D0 Offset: 0x16E75D1 VA: 0x16E74D0
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x16E74E0 Offset: 0x16E75E1 VA: 0x16E74E0
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x16E74F0 Offset: 0x16E75F1 VA: 0x16E74F0
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x16E7500 Offset: 0x16E7601 VA: 0x16E7500
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBDAA0 Offset: 0xBDBA1 VA: 0xBDAA0
	// RVA: 0x16E7510 Offset: 0x16E7611 VA: 0x16E7510
	private void <SendRequest>b__41_0(object o) { }
}

internal class WebConnection // TypeDefIndex: 1996
{
	// Fields
	private ServicePoint sPoint; // 0x10
	private Stream nstream; // 0x18
	internal Socket socket; // 0x20
	private object socketLock; // 0x28
	private IWebConnectionState state; // 0x30
	private WebExceptionStatus status; // 0x38
	private bool keepAlive; // 0x3C
	private byte[] buffer; // 0x40
	private EventHandler abortHandler; // 0x48
	private WebConnection.AbortHelper abortHelper; // 0x50
	internal WebConnectionData Data; // 0x58
	private bool chunkedRead; // 0x60
	private MonoChunkStream chunkStream; // 0x68
	private Queue queue; // 0x70
	private bool reused; // 0x78
	private int position; // 0x7C
	private HttpWebRequest priority_request; // 0x80
	private NetworkCredential ntlm_credentials; // 0x88
	private bool ntlm_authenticated; // 0x90
	private bool unsafe_sharing; // 0x91
	private WebConnection.NtlmAuthState connect_ntlm_auth_state; // 0x94
	private HttpWebRequest connect_request; // 0x98
	private Exception connect_exception; // 0xA0
	private MonoTlsStream tlsStream; // 0xA8

	// Properties
	internal HttpWebRequest PriorityRequest { set; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	// RVA: 0x16E1060 Offset: 0x16E1161 VA: 0x16E1060
	public void .ctor(IWebConnectionState wcs, ServicePoint sPoint) { }

	// RVA: 0x16E1270 Offset: 0x16E1371 VA: 0x16E1270
	private bool CanReuse() { }

	// RVA: 0x16E12A0 Offset: 0x16E13A1 VA: 0x16E12A0
	private void Connect(HttpWebRequest request) { }

	// RVA: 0x16E1B70 Offset: 0x16E1C71 VA: 0x16E1B70
	private bool CreateTunnel(HttpWebRequest request, Uri connectUri, Stream stream, out byte[] buffer) { }

	// RVA: 0x16E24C0 Offset: 0x16E25C1 VA: 0x16E24C0
	private WebHeaderCollection ReadHeaders(Stream stream, out byte[] retBuffer, out int status) { }

	// RVA: 0x16E2C80 Offset: 0x16E2D81 VA: 0x16E2C80
	private void FlushContents(Stream stream, int contentLength) { }

	// RVA: 0x16E2FB0 Offset: 0x16E30B1 VA: 0x16E2FB0
	private bool CreateStream(HttpWebRequest request) { }

	// RVA: 0x16E2A20 Offset: 0x16E2B21 VA: 0x16E2A20
	private void HandleError(WebExceptionStatus st, Exception e, string where) { }

	// RVA: 0x16E3720 Offset: 0x16E3821 VA: 0x16E3720
	private void ReadDone(IAsyncResult result) { }

	// RVA: 0x16E4920 Offset: 0x16E4A21 VA: 0x16E4920
	private static bool ExpectContent(int statusCode, string method) { }

	// RVA: 0x16E47B0 Offset: 0x16E48B1 VA: 0x16E47B0
	internal void InitRead() { }

	// RVA: 0x16E3E20 Offset: 0x16E3F21 VA: 0x16E3E20
	private static int GetResponse(WebConnectionData data, ServicePoint sPoint, byte[] buffer, int max) { }

	// RVA: 0x16E49C0 Offset: 0x16E4AC1 VA: 0x16E49C0
	private void InitConnection(HttpWebRequest request) { }

	// RVA: 0x16CDEE0 Offset: 0x16CDFE1 VA: 0x16CDEE0
	internal EventHandler SendRequest(HttpWebRequest request) { }

	// RVA: 0x16E4CA0 Offset: 0x16E4DA1 VA: 0x16E4CA0
	private void SendNext() { }

	// RVA: 0x16E4E10 Offset: 0x16E4F11 VA: 0x16E4E10
	internal void NextRead() { }

	// RVA: 0x16E2D40 Offset: 0x16E2E41 VA: 0x16E2D40
	private static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x16E52D0 Offset: 0x16E53D1 VA: 0x16E52D0
	internal IAsyncResult BeginRead(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x16E56C0 Offset: 0x16E57C1 VA: 0x16E56C0
	internal int EndRead(HttpWebRequest request, IAsyncResult result) { }

	// RVA: 0x16E5D90 Offset: 0x16E5E91 VA: 0x16E5D90
	private int EnsureRead(byte[] buffer, int offset, int size) { }

	// RVA: 0x16E1AC0 Offset: 0x16E1BC1 VA: 0x16E1AC0
	private bool CompleteChunkedRead() { }

	// RVA: 0x16E5EE0 Offset: 0x16E5FE1 VA: 0x16E5EE0
	internal IAsyncResult BeginWrite(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x16E6350 Offset: 0x16E6451 VA: 0x16E6350
	internal bool EndWrite(HttpWebRequest request, bool throwOnError, IAsyncResult result) { }

	// RVA: 0x16E6720 Offset: 0x16E6821 VA: 0x16E6720
	internal int Read(HttpWebRequest request, byte[] buffer, int offset, int size) { }

	// RVA: 0x16E6C20 Offset: 0x16E6D21 VA: 0x16E6C20
	internal bool Write(HttpWebRequest request, byte[] buffer, int offset, int size, ref string err_msg) { }

	// RVA: 0x16E32A0 Offset: 0x16E33A1 VA: 0x16E32A0
	internal void Close(bool sendNext) { }

	// RVA: 0x16E6F90 Offset: 0x16E7091 VA: 0x16E6F90
	private void Abort(object sender, EventArgs args) { }

	// RVA: 0x16E6F50 Offset: 0x16E7051 VA: 0x16E6F50
	internal void ResetNtlm() { }

	// RVA: 0x16E74A0 Offset: 0x16E75A1 VA: 0x16E74A0
	internal void set_PriorityRequest(HttpWebRequest value) { }

	// RVA: 0x16E74B0 Offset: 0x16E75B1 VA: 0x16E74B0
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x16E74C0 Offset: 0x16E75C1 VA: 0x16E74C0
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x16E74D0 Offset: 0x16E75D1 VA: 0x16E74D0
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x16E74E0 Offset: 0x16E75E1 VA: 0x16E74E0
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x16E74F0 Offset: 0x16E75F1 VA: 0x16E74F0
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x16E7500 Offset: 0x16E7601 VA: 0x16E7500
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBDAA0 Offset: 0xBDBA1 VA: 0xBDAA0
	// RVA: 0x16E7510 Offset: 0x16E7611 VA: 0x16E7510
	private void <SendRequest>b__41_0(object o) { }
}

internal class WebConnection // TypeDefIndex: 1996
{
	// Fields
	private ServicePoint sPoint; // 0x10
	private Stream nstream; // 0x18
	internal Socket socket; // 0x20
	private object socketLock; // 0x28
	private IWebConnectionState state; // 0x30
	private WebExceptionStatus status; // 0x38
	private bool keepAlive; // 0x3C
	private byte[] buffer; // 0x40
	private EventHandler abortHandler; // 0x48
	private WebConnection.AbortHelper abortHelper; // 0x50
	internal WebConnectionData Data; // 0x58
	private bool chunkedRead; // 0x60
	private MonoChunkStream chunkStream; // 0x68
	private Queue queue; // 0x70
	private bool reused; // 0x78
	private int position; // 0x7C
	private HttpWebRequest priority_request; // 0x80
	private NetworkCredential ntlm_credentials; // 0x88
	private bool ntlm_authenticated; // 0x90
	private bool unsafe_sharing; // 0x91
	private WebConnection.NtlmAuthState connect_ntlm_auth_state; // 0x94
	private HttpWebRequest connect_request; // 0x98
	private Exception connect_exception; // 0xA0
	private MonoTlsStream tlsStream; // 0xA8

	// Properties
	internal HttpWebRequest PriorityRequest { set; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	// RVA: 0x16E1060 Offset: 0x16E1161 VA: 0x16E1060
	public void .ctor(IWebConnectionState wcs, ServicePoint sPoint) { }

	// RVA: 0x16E1270 Offset: 0x16E1371 VA: 0x16E1270
	private bool CanReuse() { }

	// RVA: 0x16E12A0 Offset: 0x16E13A1 VA: 0x16E12A0
	private void Connect(HttpWebRequest request) { }

	// RVA: 0x16E1B70 Offset: 0x16E1C71 VA: 0x16E1B70
	private bool CreateTunnel(HttpWebRequest request, Uri connectUri, Stream stream, out byte[] buffer) { }

	// RVA: 0x16E24C0 Offset: 0x16E25C1 VA: 0x16E24C0
	private WebHeaderCollection ReadHeaders(Stream stream, out byte[] retBuffer, out int status) { }

	// RVA: 0x16E2C80 Offset: 0x16E2D81 VA: 0x16E2C80
	private void FlushContents(Stream stream, int contentLength) { }

	// RVA: 0x16E2FB0 Offset: 0x16E30B1 VA: 0x16E2FB0
	private bool CreateStream(HttpWebRequest request) { }

	// RVA: 0x16E2A20 Offset: 0x16E2B21 VA: 0x16E2A20
	private void HandleError(WebExceptionStatus st, Exception e, string where) { }

	// RVA: 0x16E3720 Offset: 0x16E3821 VA: 0x16E3720
	private void ReadDone(IAsyncResult result) { }

	// RVA: 0x16E4920 Offset: 0x16E4A21 VA: 0x16E4920
	private static bool ExpectContent(int statusCode, string method) { }

	// RVA: 0x16E47B0 Offset: 0x16E48B1 VA: 0x16E47B0
	internal void InitRead() { }

	// RVA: 0x16E3E20 Offset: 0x16E3F21 VA: 0x16E3E20
	private static int GetResponse(WebConnectionData data, ServicePoint sPoint, byte[] buffer, int max) { }

	// RVA: 0x16E49C0 Offset: 0x16E4AC1 VA: 0x16E49C0
	private void InitConnection(HttpWebRequest request) { }

	// RVA: 0x16CDEE0 Offset: 0x16CDFE1 VA: 0x16CDEE0
	internal EventHandler SendRequest(HttpWebRequest request) { }

	// RVA: 0x16E4CA0 Offset: 0x16E4DA1 VA: 0x16E4CA0
	private void SendNext() { }

	// RVA: 0x16E4E10 Offset: 0x16E4F11 VA: 0x16E4E10
	internal void NextRead() { }

	// RVA: 0x16E2D40 Offset: 0x16E2E41 VA: 0x16E2D40
	private static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x16E52D0 Offset: 0x16E53D1 VA: 0x16E52D0
	internal IAsyncResult BeginRead(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x16E56C0 Offset: 0x16E57C1 VA: 0x16E56C0
	internal int EndRead(HttpWebRequest request, IAsyncResult result) { }

	// RVA: 0x16E5D90 Offset: 0x16E5E91 VA: 0x16E5D90
	private int EnsureRead(byte[] buffer, int offset, int size) { }

	// RVA: 0x16E1AC0 Offset: 0x16E1BC1 VA: 0x16E1AC0
	private bool CompleteChunkedRead() { }

	// RVA: 0x16E5EE0 Offset: 0x16E5FE1 VA: 0x16E5EE0
	internal IAsyncResult BeginWrite(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x16E6350 Offset: 0x16E6451 VA: 0x16E6350
	internal bool EndWrite(HttpWebRequest request, bool throwOnError, IAsyncResult result) { }

	// RVA: 0x16E6720 Offset: 0x16E6821 VA: 0x16E6720
	internal int Read(HttpWebRequest request, byte[] buffer, int offset, int size) { }

	// RVA: 0x16E6C20 Offset: 0x16E6D21 VA: 0x16E6C20
	internal bool Write(HttpWebRequest request, byte[] buffer, int offset, int size, ref string err_msg) { }

	// RVA: 0x16E32A0 Offset: 0x16E33A1 VA: 0x16E32A0
	internal void Close(bool sendNext) { }

	// RVA: 0x16E6F90 Offset: 0x16E7091 VA: 0x16E6F90
	private void Abort(object sender, EventArgs args) { }

	// RVA: 0x16E6F50 Offset: 0x16E7051 VA: 0x16E6F50
	internal void ResetNtlm() { }

	// RVA: 0x16E74A0 Offset: 0x16E75A1 VA: 0x16E74A0
	internal void set_PriorityRequest(HttpWebRequest value) { }

	// RVA: 0x16E74B0 Offset: 0x16E75B1 VA: 0x16E74B0
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x16E74C0 Offset: 0x16E75C1 VA: 0x16E74C0
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x16E74D0 Offset: 0x16E75D1 VA: 0x16E74D0
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x16E74E0 Offset: 0x16E75E1 VA: 0x16E74E0
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x16E74F0 Offset: 0x16E75F1 VA: 0x16E74F0
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x16E7500 Offset: 0x16E7601 VA: 0x16E7500
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBDAA0 Offset: 0xBDBA1 VA: 0xBDAA0
	// RVA: 0x16E7510 Offset: 0x16E7611 VA: 0x16E7510
	private void <SendRequest>b__41_0(object o) { }
}

