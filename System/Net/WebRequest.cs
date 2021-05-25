[Serializable]
public abstract class WebRequest : MarshalByRefObject, ISerializable // TypeDefIndex: 1905
{
	// Fields
	private static ArrayList s_PrefixList; // 0x0
	private static object s_InternalSyncObject; // 0x8
	private static TimerThread.Queue s_DefaultTimerQueue; // 0x10
	private AuthenticationLevel m_AuthenticationLevel; // 0x18
	private TokenImpersonationLevel m_ImpersonationLevel; // 0x1C
	private static WebRequest.DesignerWebRequestCreate webRequestCreate; // 0x18
	private static IWebProxy s_DefaultWebProxy; // 0x20
	private static bool s_DefaultWebProxyInitialized; // 0x28

	// Properties
	private static object InternalSyncObject { get; }
	internal static ArrayList PrefixList { get; }
	public virtual string Method { get; set; }
	public virtual Uri RequestUri { get; }
	public virtual WebHeaderCollection Headers { get; }
	public virtual long ContentLength { get; }
	public virtual ICredentials Credentials { get; set; }
	public virtual IWebProxy Proxy { get; }
	public virtual int Timeout { get; }
	internal static IWebProxy InternalDefaultWebProxy { get; }
	public static IWebProxy DefaultWebProxy { get; }

	// Methods

	// RVA: 0x170CEF0 Offset: 0x170CFF1 VA: 0x170CEF0
	private static object get_InternalSyncObject() { }

	// RVA: 0x170CFF0 Offset: 0x170D0F1 VA: 0x170CFF0
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x170D5E0 Offset: 0x170D6E1 VA: 0x170D5E0
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x170D6B0 Offset: 0x170D7B1 VA: 0x170D6B0
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x170D250 Offset: 0x170D351 VA: 0x170D250
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x170D790 Offset: 0x170D891 VA: 0x170D790
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x170DA10 Offset: 0x170DB11 VA: 0x170DA10
	protected void .ctor() { }

	// RVA: 0x170DA40 Offset: 0x170DB41 VA: 0x170DA40
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x170DA50 Offset: 0x170DB51 VA: 0x170DA50 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x170DA60 Offset: 0x170DB61 VA: 0x170DA60 Slot: 7
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x170DA70 Offset: 0x170DB71 VA: 0x170DA70 Slot: 8
	public virtual string get_Method() { }

	// RVA: 0x170DAC0 Offset: 0x170DBC1 VA: 0x170DAC0 Slot: 9
	public virtual void set_Method(string value) { }

	// RVA: 0x170DB10 Offset: 0x170DC11 VA: 0x170DB10 Slot: 10
	public virtual Uri get_RequestUri() { }

	// RVA: 0x170DB60 Offset: 0x170DC61 VA: 0x170DB60 Slot: 11
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x170DBB0 Offset: 0x170DCB1 VA: 0x170DBB0 Slot: 12
	public virtual long get_ContentLength() { }

	// RVA: 0x170DC00 Offset: 0x170DD01 VA: 0x170DC00 Slot: 13
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x170DC50 Offset: 0x170DD51 VA: 0x170DC50 Slot: 14
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x170DCA0 Offset: 0x170DDA1 VA: 0x170DCA0 Slot: 15
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x170DCF0 Offset: 0x170DDF1 VA: 0x170DCF0 Slot: 16
	public virtual int get_Timeout() { }

	// RVA: 0x170DD40 Offset: 0x170DE41 VA: 0x170DD40 Slot: 17
	public virtual WebResponse GetResponse() { }

	// RVA: 0x170DD90 Offset: 0x170DE91 VA: 0x170DD90 Slot: 18
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x170DDE0 Offset: 0x170DEE1 VA: 0x170DDE0 Slot: 19
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x170DE30 Offset: 0x170DF31 VA: 0x170DE30 Slot: 20
	public virtual void Abort() { }

	// RVA: 0x170DE80 Offset: 0x170DF81 VA: 0x170DE80
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x170E090 Offset: 0x170E191 VA: 0x170E090
	public static IWebProxy get_DefaultWebProxy() { }

	// RVA: 0x170E100 Offset: 0x170E201 VA: 0x170E100
	private static void .cctor() { }
}

