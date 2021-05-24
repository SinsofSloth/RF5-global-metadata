[Serializable]
public class FileWebResponse : WebResponse, ISerializable, ICloseEx // TypeDefIndex: 1945
{
	// Fields
	private bool m_closed; // 0x18
	private long m_contentLength; // 0x20
	private FileAccess m_fileAccess; // 0x28
	private WebHeaderCollection m_headers; // 0x30
	private Stream m_stream; // 0x38
	private Uri m_uri; // 0x40

	// Properties
	public override WebHeaderCollection Headers { get; }

	// Methods

	// RVA: 0x177F580 Offset: 0x177F681 VA: 0x177F580
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[ObsoleteAttribute] // RVA: 0xBD860 Offset: 0xBD961 VA: 0xBD860
	// RVA: 0x17800E0 Offset: 0x17801E1 VA: 0x17800E0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x17802C0 Offset: 0x17803C1 VA: 0x17802C0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x17802D0 Offset: 0x17803D1 VA: 0x17802D0 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1780440 Offset: 0x1780541 VA: 0x1780440 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1780470 Offset: 0x1780571 VA: 0x1780470
	private void CheckDisposed() { }

	// RVA: 0x1780520 Offset: 0x1780621 VA: 0x1780520 Slot: 9
	public override void Close() { }

	// RVA: 0x17805D0 Offset: 0x17806D1 VA: 0x17805D0 Slot: 13
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1780770 Offset: 0x1780871 VA: 0x1780770 Slot: 11
	public override Stream GetResponseStream() { }
}

