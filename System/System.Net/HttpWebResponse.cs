[Serializable]
public class HttpWebResponse : WebResponse, ISerializable, IDisposable // TypeDefIndex: 1979
{
	// Fields
	private Uri uri; // 0x18
	private WebHeaderCollection webHeaders; // 0x20
	private CookieCollection cookieCollection; // 0x28
	private string method; // 0x30
	private Version version; // 0x38
	private HttpStatusCode statusCode; // 0x40
	private string statusDescription; // 0x48
	private long contentLength; // 0x50
	private string contentType; // 0x58
	private CookieContainer cookie_container; // 0x60
	private bool disposed; // 0x68
	private Stream stream; // 0x70

	// Properties
	public override WebHeaderCollection Headers { get; }
	public virtual HttpStatusCode StatusCode { get; }
	public virtual string StatusDescription { get; }

	// Methods

	// RVA: 0x1790A10 Offset: 0x1790B11 VA: 0x1790A10
	internal void .ctor(Uri uri, string method, WebConnectionData data, CookieContainer container) { }

	[ObsoleteAttribute] // RVA: 0xBD9F0 Offset: 0xBDAF1 VA: 0xBD9F0
	// RVA: 0x1792250 Offset: 0x1792351 VA: 0x1792250
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1792530 Offset: 0x1792631 VA: 0x1792530 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1792540 Offset: 0x1792641 VA: 0x1792540 Slot: 13
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x1792550 Offset: 0x1792651 VA: 0x1792550 Slot: 14
	public virtual string get_StatusDescription() { }

	// RVA: 0x178FD60 Offset: 0x178FE61 VA: 0x178FD60
	internal void ReadAll() { }

	// RVA: 0x1792630 Offset: 0x1792731 VA: 0x1792630 Slot: 11
	public override Stream GetResponseStream() { }

	// RVA: 0x17926D0 Offset: 0x17927D1 VA: 0x17926D0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x17926E0 Offset: 0x17927E1 VA: 0x17926E0 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1792830 Offset: 0x1792931 VA: 0x1792830 Slot: 9
	public override void Close() { }

	// RVA: 0x1792880 Offset: 0x1792981 VA: 0x1792880 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1792890 Offset: 0x1792991 VA: 0x1792890 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1792580 Offset: 0x1792681 VA: 0x1792580
	private void CheckDisposed() { }

	// RVA: 0x1791FC0 Offset: 0x17920C1 VA: 0x1791FC0
	private void FillCookies() { }

	[EditorBrowsableAttribute] // RVA: 0xBDA30 Offset: 0xBDB31 VA: 0xBDA30
	[ObsoleteAttribute] // RVA: 0xBDA30 Offset: 0xBDB31 VA: 0xBDA30
	// RVA: 0x17928B0 Offset: 0x17929B1 VA: 0x17928B0
	public void .ctor() { }
}

