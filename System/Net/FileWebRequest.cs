[Serializable]
public class FileWebRequest : WebRequest, ISerializable // TypeDefIndex: 1942
{
	// Fields
	private static WaitCallback s_GetRequestStreamCallback; // 0x0
	private static WaitCallback s_GetResponseCallback; // 0x8
	private string m_connectionGroupName; // 0x20
	private long m_contentLength; // 0x28
	private ICredentials m_credentials; // 0x30
	private FileAccess m_fileAccess; // 0x38
	private WebHeaderCollection m_headers; // 0x40
	private string m_method; // 0x48
	private IWebProxy m_proxy; // 0x50
	private ManualResetEvent m_readerEvent; // 0x58
	private bool m_readPending; // 0x60
	private WebResponse m_response; // 0x68
	private Stream m_stream; // 0x70
	private bool m_syncHint; // 0x78
	private int m_timeout; // 0x7C
	private Uri m_uri; // 0x80
	private bool m_writePending; // 0x88
	private bool m_writing; // 0x89
	private LazyAsyncResult m_WriteAResult; // 0x90
	private LazyAsyncResult m_ReadAResult; // 0x98
	private int m_Aborted; // 0xA0

	// Properties
	internal bool Aborted { get; }
	public override long ContentLength { get; }
	public override ICredentials Credentials { get; set; }
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override IWebProxy Proxy { get; }
	public override int Timeout { get; }
	public override Uri RequestUri { get; }

	// Methods

	// RVA: 0x177DAF0 Offset: 0x177DBF1 VA: 0x177DAF0
	internal void .ctor(Uri uri) { }

	[ObsoleteAttribute] // RVA: 0xBD820 Offset: 0xBD921 VA: 0xBD820
	// RVA: 0x177DC60 Offset: 0x177DD61 VA: 0x177DC60
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x177DF60 Offset: 0x177E061 VA: 0x177DF60 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x177DF70 Offset: 0x177E071 VA: 0x177DF70 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x177E190 Offset: 0x177E291 VA: 0x177E190
	internal bool get_Aborted() { }

	// RVA: 0x177E1A0 Offset: 0x177E2A1 VA: 0x177E1A0 Slot: 12
	public override long get_ContentLength() { }

	// RVA: 0x177E1B0 Offset: 0x177E2B1 VA: 0x177E1B0 Slot: 13
	public override ICredentials get_Credentials() { }

	// RVA: 0x177E1C0 Offset: 0x177E2C1 VA: 0x177E1C0 Slot: 14
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x177E1D0 Offset: 0x177E2D1 VA: 0x177E1D0 Slot: 11
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x177E1E0 Offset: 0x177E2E1 VA: 0x177E1E0 Slot: 8
	public override string get_Method() { }

	// RVA: 0x177E1F0 Offset: 0x177E2F1 VA: 0x177E1F0 Slot: 9
	public override void set_Method(string value) { }

	// RVA: 0x177E2D0 Offset: 0x177E3D1 VA: 0x177E2D0 Slot: 15
	public override IWebProxy get_Proxy() { }

	// RVA: 0x177E2E0 Offset: 0x177E3E1 VA: 0x177E2E0 Slot: 16
	public override int get_Timeout() { }

	// RVA: 0x177E2F0 Offset: 0x177E3F1 VA: 0x177E2F0 Slot: 10
	public override Uri get_RequestUri() { }

	// RVA: 0x177E300 Offset: 0x177E401 VA: 0x177E300 Slot: 18
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x177E740 Offset: 0x177E841 VA: 0x177E740 Slot: 19
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x177EA40 Offset: 0x177EB41 VA: 0x177EA40 Slot: 17
	public override WebResponse GetResponse() { }

	// RVA: 0x177EE40 Offset: 0x177EF41 VA: 0x177EE40
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x177F250 Offset: 0x177F351 VA: 0x177F250
	private static void GetResponseCallback(object state) { }

	// RVA: 0x177F940 Offset: 0x177FA41 VA: 0x177F940
	internal void UnblockReader() { }

	// RVA: 0x177F9F0 Offset: 0x177FAF1 VA: 0x177F9F0 Slot: 20
	public override void Abort() { }

	// RVA: 0x177FEE0 Offset: 0x177FFE1 VA: 0x177FEE0
	private static void .cctor() { }
}

