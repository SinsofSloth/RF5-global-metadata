[ComVisibleAttribute] // RVA: 0xBC2B0 Offset: 0xBC3B1 VA: 0xBC2B0
[DefaultMemberAttribute] // RVA: 0xBC2B0 Offset: 0xBC3B1 VA: 0xBC2B0
[Serializable]
public class WebHeaderCollection : NameValueCollection, ISerializable // TypeDefIndex: 1902
{
	// Fields
	private static readonly HeaderInfoTable HInfo; // 0x0
	private string[] m_CommonHeaders; // 0x58
	private int m_NumCommonHeaders; // 0x60
	private static readonly string[] s_CommonHeaderNames; // 0x8
	private static readonly sbyte[] s_CommonHeaderHints; // 0x10
	private NameValueCollection m_InnerCollection; // 0x68
	private WebHeaderCollectionType m_Type; // 0x70
	private static readonly char[] HttpTrimCharacters; // 0x18
	private static WebHeaderCollection.RfcChar[] RfcCharMap; // 0x20

	// Properties
	private NameValueCollection InnerCollection { get; }
	private bool AllowHttpRequestHeader { get; }
	public override int Count { get; }

	// Methods

	// RVA: 0x17085C0 Offset: 0x17086C1 VA: 0x17085C0
	private void NormalizeCommonHeaders() { }

	// RVA: 0x17086F0 Offset: 0x17087F1 VA: 0x17086F0
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x17087C0 Offset: 0x17088C1 VA: 0x17087C0
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x1708870 Offset: 0x1708971 VA: 0x1708870
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x17088B0 Offset: 0x17089B1 VA: 0x17088B0
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x17089C0 Offset: 0x1708AC1 VA: 0x17089C0
	internal void AddInternal(string name, string value) { }

	// RVA: 0x1708A20 Offset: 0x1708B21 VA: 0x1708A20
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x1708A80 Offset: 0x1708B81 VA: 0x1708A80
	internal void RemoveInternal(string name) { }

	// RVA: 0x1708AE0 Offset: 0x1708BE1 VA: 0x1708AE0
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x1708ED0 Offset: 0x1708FD1 VA: 0x1708ED0
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x1708F70 Offset: 0x1709071 VA: 0x1708F70
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x1709100 Offset: 0x1709201 VA: 0x1709100 Slot: 13
	public override void Add(string name, string value) { }

	// RVA: 0x17092C0 Offset: 0x17093C1 VA: 0x17092C0
	public void Add(string header) { }

	// RVA: 0x1709580 Offset: 0x1709681 VA: 0x1709580 Slot: 16
	public override void Set(string name, string value) { }

	// RVA: 0x17097A0 Offset: 0x17098A1 VA: 0x17097A0
	internal void SetInternal(string name, string value) { }

	// RVA: 0x17099C0 Offset: 0x1709AC1 VA: 0x17099C0 Slot: 17
	public override void Remove(string name) { }

	// RVA: 0x1709B00 Offset: 0x1709C01 VA: 0x1709B00 Slot: 15
	public override string[] GetValues(string header) { }

	// RVA: 0x1709D10 Offset: 0x1709E11 VA: 0x1709D10 Slot: 3
	public override string ToString() { }

	// RVA: 0x1709D80 Offset: 0x1709E81 VA: 0x1709D80
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x170A0B0 Offset: 0x170A1B1 VA: 0x170A0B0
	public void .ctor() { }

	// RVA: 0x170A130 Offset: 0x170A231 VA: 0x170A130
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x170A230 Offset: 0x170A331 VA: 0x170A230
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x170A3F0 Offset: 0x170A4F1 VA: 0x170A3F0 Slot: 10
	public override void OnDeserialization(object sender) { }

	// RVA: 0x170A400 Offset: 0x170A501 VA: 0x170A400 Slot: 9
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x170A580 Offset: 0x170A681 VA: 0x170A580 Slot: 7
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x170A590 Offset: 0x170A691 VA: 0x170A590 Slot: 14
	public override string Get(string name) { }

	// RVA: 0x170A8F0 Offset: 0x170A9F1 VA: 0x170A8F0 Slot: 11
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x170A970 Offset: 0x170AA71 VA: 0x170A970 Slot: 12
	public override int get_Count() { }

	// RVA: 0x170A9B0 Offset: 0x170AAB1 VA: 0x170A9B0 Slot: 18
	public override string Get(int index) { }

	// RVA: 0x170AA00 Offset: 0x170AB01 VA: 0x170AA00 Slot: 19
	public override string GetKey(int index) { }

	// RVA: 0x170AA50 Offset: 0x170AB51 VA: 0x170AA50
	private static void .cctor() { }
}

