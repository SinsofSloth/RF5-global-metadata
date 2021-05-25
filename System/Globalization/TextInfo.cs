[ComVisibleAttribute] // RVA: 0xAEEE0 Offset: 0xAEFE1 VA: 0xAEEE0
[Serializable]
public class TextInfo : ICloneable, IDeserializationCallback // TypeDefIndex: 731
{
	// Fields
	[OptionalFieldAttribute] // RVA: 0xB5260 Offset: 0xB5361 VA: 0xB5260
	private string m_listSeparator; // 0x10
	[OptionalFieldAttribute] // RVA: 0xB52A0 Offset: 0xB53A1 VA: 0xB52A0
	private bool m_isReadOnly; // 0x18
	[OptionalFieldAttribute] // RVA: 0xB52E0 Offset: 0xB53E1 VA: 0xB52E0
	private string m_cultureName; // 0x20
	private CultureData m_cultureData; // 0x28
	private string m_textInfoName; // 0x30
	private Nullable<bool> m_IsAsciiCasingSameAsInvariant; // 0x38
	internal static TextInfo s_Invariant; // 0x0
	[OptionalFieldAttribute] // RVA: 0xB5320 Offset: 0xB5421 VA: 0xB5320
	private string customCultureName; // 0x40
	[OptionalFieldAttribute] // RVA: 0xB5360 Offset: 0xB5461 VA: 0xB5360
	internal int m_nDataItem; // 0x48
	[OptionalFieldAttribute] // RVA: 0xB53A0 Offset: 0xB54A1 VA: 0xB53A0
	internal bool m_useUserOverride; // 0x4C
	[OptionalFieldAttribute] // RVA: 0xB53E0 Offset: 0xB54E1 VA: 0xB53E0
	internal int m_win32LangID; // 0x50
	private const int wordSeparatorMask = 536672256;

	// Properties
	internal static TextInfo Invariant { get; }
	[ComVisibleAttribute] // RVA: 0xBA330 Offset: 0xBA431 VA: 0xBA330
	public string CultureName { get; }
	private bool IsAsciiCasingSameAsInvariant { get; }

	// Methods

	// RVA: 0x19C97A0 Offset: 0x19C98A1 VA: 0x19C97A0
	internal static TextInfo get_Invariant() { }

	// RVA: 0x19C98A0 Offset: 0x19C99A1 VA: 0x19C98A0
	internal void .ctor(CultureData cultureData) { }

	[OnDeserializingAttribute] // RVA: 0xB88D0 Offset: 0xB89D1 VA: 0xB88D0
	// RVA: 0x19C9920 Offset: 0x19C9A21 VA: 0x19C9920
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x19C9960 Offset: 0x19C9A61 VA: 0x19C9960
	private void OnDeserialized() { }

	[OnDeserializedAttribute] // RVA: 0xB88E0 Offset: 0xB89E1 VA: 0xB88E0
	// RVA: 0x19C9AA0 Offset: 0x19C9BA1 VA: 0x19C9AA0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0xB88F0 Offset: 0xB89F1 VA: 0xB88F0
	// RVA: 0x19C9AB0 Offset: 0x19C9BB1 VA: 0x19C9AB0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x19C9B50 Offset: 0x19C9C51 VA: 0x19C9B50
	internal static int GetHashCodeOrdinalIgnoreCase(string s) { }

	// RVA: 0x19C9B80 Offset: 0x19C9C81 VA: 0x19C9B80
	internal static int GetHashCodeOrdinalIgnoreCase(string s, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x19C9CB0 Offset: 0x19C9DB1 VA: 0x19C9CB0
	internal static int CompareOrdinalIgnoreCase(string str1, string str2) { }

	// RVA: 0x19C9EA0 Offset: 0x19C9FA1 VA: 0x19C9EA0
	internal static int CompareOrdinalIgnoreCaseEx(string strA, int indexA, string strB, int indexB, int lengthA, int lengthB) { }

	// RVA: 0x19C9EB0 Offset: 0x19C9FB1 VA: 0x19C9EB0
	internal static int IndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	// RVA: 0x19C9F90 Offset: 0x19CA091 VA: 0x19C9F90
	internal static int LastIndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	// RVA: 0x19CA050 Offset: 0x19CA151 VA: 0x19CA050
	public string get_CultureName() { }

	[ComVisibleAttribute] // RVA: 0xB8900 Offset: 0xB8A01 VA: 0xB8900
	// RVA: 0x19CA060 Offset: 0x19CA161 VA: 0x19CA060 Slot: 6
	public virtual object Clone() { }

	// RVA: 0x19CA0F0 Offset: 0x19CA1F1 VA: 0x19CA0F0
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x19CA100 Offset: 0x19CA201 VA: 0x19CA100 Slot: 7
	public virtual char ToLower(char c) { }

	// RVA: 0x19CA870 Offset: 0x19CA971 VA: 0x19CA870 Slot: 8
	public virtual string ToLower(string str) { }

	// RVA: 0x19CA270 Offset: 0x19CA371 VA: 0x19CA270
	private static char ToLowerAsciiInvariant(char c) { }

	// RVA: 0x19CAA10 Offset: 0x19CAB11 VA: 0x19CAA10 Slot: 9
	public virtual char ToUpper(char c) { }

	// RVA: 0x19CB0D0 Offset: 0x19CB1D1 VA: 0x19CB0D0 Slot: 10
	public virtual string ToUpper(string str) { }

	// RVA: 0x19CAA80 Offset: 0x19CAB81 VA: 0x19CAA80
	private static char ToUpperAsciiInvariant(char c) { }

	// RVA: 0x19CA170 Offset: 0x19CA271 VA: 0x19CA170
	private static bool IsAscii(char c) { }

	// RVA: 0x19CA180 Offset: 0x19CA281 VA: 0x19CA180
	private bool get_IsAsciiCasingSameAsInvariant() { }

	// RVA: 0x19CB270 Offset: 0x19CB371 VA: 0x19CB270 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x19CB330 Offset: 0x19CB431 VA: 0x19CB330 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19CB350 Offset: 0x19CB451 VA: 0x19CB350 Slot: 3
	public override string ToString() { }

	// RVA: 0x19CB3B0 Offset: 0x19CB4B1 VA: 0x19CB3B0 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x19CB3C0 Offset: 0x19CB4C1 VA: 0x19CB3C0
	internal int GetCaseInsensitiveHashCode(string str) { }

	// RVA: 0x19C9BB0 Offset: 0x19C9CB1 VA: 0x19C9BB0
	internal int GetCaseInsensitiveHashCode(string str, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x19CB3D0 Offset: 0x19CB4D1 VA: 0x19CB3D0
	private int GetInvariantCaseInsensitiveHashCode(string str) { }

	// RVA: 0x19CB170 Offset: 0x19CB271 VA: 0x19CB170
	private string ToUpperInternal(string str) { }

	// RVA: 0x19CA910 Offset: 0x19CAA11 VA: 0x19CA910
	private string ToLowerInternal(string str) { }

	// RVA: 0x19CAAA0 Offset: 0x19CABA1 VA: 0x19CAAA0
	private char ToUpperInternal(char c) { }

	// RVA: 0x19CA290 Offset: 0x19CA391 VA: 0x19CA290
	private char ToLowerInternal(char c) { }

	// RVA: 0x19C9CE0 Offset: 0x19C9DE1 VA: 0x19C9CE0
	private static int InternalCompareStringOrdinalIgnoreCase(string strA, int indexA, string strB, int indexB, int lenA, int lenB) { }

	// RVA: 0x19CB520 Offset: 0x19CB621 VA: 0x19CB520
	internal void .ctor() { }
}

