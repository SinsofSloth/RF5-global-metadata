[DefaultMemberAttribute] // RVA: 0xAC760 Offset: 0xAC861 VA: 0xAC760
[ComVisibleAttribute] // RVA: 0xAC760 Offset: 0xAC861 VA: 0xAC760
[Serializable]
public sealed class String : IComparable, ICloneable, IConvertible, IEnumerable, IComparable<string>, IEnumerable<char>, IEquatable<string> // TypeDefIndex: 310
{
	// Fields
	private int m_stringLength; // 0x10
	private char m_firstChar; // 0x14
	private const int TrimHead = 0;
	private const int TrimTail = 1;
	private const int TrimBoth = 2;
	public static readonly string Empty; // 0x0
	private const int charPtrAlignConst = 1;
	private const int alignConst = 3;

	// Properties
	public char Chars { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x2647460 Offset: 0x2647561 VA: 0x2647460
	public static string Join(string separator, string[] value) { }

	[ComVisibleAttribute] // RVA: 0xB6D40 Offset: 0xB6E41 VA: 0xB6D40
	// RVA: 0x26477A0 Offset: 0x26478A1 VA: 0x26477A0
	public static string Join(string separator, object[] values) { }

	// RVA: 0x2647500 Offset: 0x2647601 VA: 0x2647500
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: 0x2647970 Offset: 0x2647A71 VA: 0x2647970
	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D60 Offset: 0xB6E61 VA: 0xB6D60
	// RVA: 0x2647A60 Offset: 0x2647B61 VA: 0x2647A60
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x2647C40 Offset: 0x2647D41 VA: 0x2647C40
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D80 Offset: 0xB6E81 VA: 0xB6D80
	// RVA: 0x2647DE0 Offset: 0x2647EE1 VA: 0x2647DE0 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0xB6DA0 Offset: 0xB6EA1 VA: 0xB6DA0
	// RVA: 0x2642450 Offset: 0x2642551 VA: 0x2642450 Slot: 26
	public bool Equals(string value) { }

	// RVA: 0x2647ED0 Offset: 0x2647FD1 VA: 0x2647ED0
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x2648210 Offset: 0x2648311 VA: 0x2648210
	public static bool Equals(string a, string b) { }

	// RVA: 0x2648250 Offset: 0x2648351 VA: 0x2648250
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x263DC80 Offset: 0x263DD81 VA: 0x263DC80
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x2648540 Offset: 0x2648641 VA: 0x2648540
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x263AF30 Offset: 0x263B031 VA: 0x263AF30
	public char get_Chars(int index) { }

	// RVA: 0x26485A0 Offset: 0x26486A1 VA: 0x26485A0
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x2648790 Offset: 0x2648891 VA: 0x2648790
	public char[] ToCharArray() { }

	// RVA: 0x2648830 Offset: 0x2648931 VA: 0x2648830
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x2648850 Offset: 0x2648951 VA: 0x2648850
	public static bool IsNullOrWhiteSpace(string value) { }

	[ReliabilityContractAttribute] // RVA: 0xB6DC0 Offset: 0xB6EC1 VA: 0xB6DC0
	// RVA: 0x2648980 Offset: 0x2648A81 VA: 0x2648980 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0xB6DE0 Offset: 0xB6EE1 VA: 0xB6DE0
	// RVA: 0x2648A00 Offset: 0x2648B01 VA: 0x2648A00
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x2648A80 Offset: 0x2648B81 VA: 0x2648A80
	public string[] Split(char[] separator) { }

	[ComVisibleAttribute] // RVA: 0xB6E00 Offset: 0xB6F01 VA: 0xB6E00
	// RVA: 0x2648D00 Offset: 0x2648E01 VA: 0x2648D00
	public string[] Split(char[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0xB6E20 Offset: 0xB6F21 VA: 0xB6E20
	// RVA: 0x2648A90 Offset: 0x2648B91 VA: 0x2648A90
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x26492D0 Offset: 0x26493D1 VA: 0x26492D0
	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x2648F00 Offset: 0x2649001 VA: 0x2648F00
	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x2648D10 Offset: 0x2648E11 VA: 0x2648D10
	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	// RVA: 0x2649540 Offset: 0x2649641 VA: 0x2649540
	public string Substring(int startIndex) { }

	// RVA: 0x263DED0 Offset: 0x263DFD1 VA: 0x263DED0
	public string Substring(int startIndex, int length) { }

	// RVA: 0x2649550 Offset: 0x2649651 VA: 0x2649550
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x26495B0 Offset: 0x26496B1 VA: 0x26495B0
	public string Trim(char[] trimChars) { }

	// RVA: 0x2649BB0 Offset: 0x2649CB1 VA: 0x2649BB0
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x2649BD0 Offset: 0x2649CD1 VA: 0x2649BD0
	public string TrimEnd(char[] trimChars) { }

	[CLSCompliantAttribute] // RVA: 0xB6E40 Offset: 0xB6F41 VA: 0xB6E40
	// RVA: 0x2649BF0 Offset: 0x2649CF1 VA: 0x2649BF0
	public void .ctor(char* value) { }

	[CLSCompliantAttribute] // RVA: 0xB6E60 Offset: 0xB6F61 VA: 0xB6E60
	// RVA: 0x2649C00 Offset: 0x2649D01 VA: 0x2649C00
	public void .ctor(char* value, int startIndex, int length) { }

	[CLSCompliantAttribute] // RVA: 0xB6E80 Offset: 0xB6F81 VA: 0xB6E80
	// RVA: 0x2649C10 Offset: 0x2649D11 VA: 0x2649C10
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x2649C20 Offset: 0x2649D21 VA: 0x2649C20
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x2649D00 Offset: 0x2649E01 VA: 0x2649D00
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x2647960 Offset: 0x2647A61 VA: 0x2647960
	internal static string FastAllocateString(int length) { }

	// RVA: 0x2649DE0 Offset: 0x2649EE1 VA: 0x2649DE0
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x2649EA0 Offset: 0x2649FA1 VA: 0x2649EA0
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x2649EB0 Offset: 0x2649FB1 VA: 0x2649EB0
	public void .ctor(char[] value) { }

	// RVA: 0x2648780 Offset: 0x2648881 VA: 0x2648780
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x2649EC0 Offset: 0x2649FC1 VA: 0x2649EC0
	private string CtorCharArray(char[] value) { }

	// RVA: 0x2649F70 Offset: 0x264A071 VA: 0x2649F70
	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	// RVA: 0x264A120 Offset: 0x264A221 VA: 0x264A120
	private static int wcslen(char* ptr) { }

	// RVA: 0x264A1A0 Offset: 0x264A2A1 VA: 0x264A1A0
	private string CtorCharPtr(char* ptr) { }

	// RVA: 0x264A3D0 Offset: 0x264A4D1 VA: 0x264A3D0
	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	// RVA: 0x264A600 Offset: 0x264A701 VA: 0x264A600
	public void .ctor(char c, int count) { }

	// RVA: 0x264A610 Offset: 0x264A711 VA: 0x264A610
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x26443E0 Offset: 0x26444E1 VA: 0x26443E0
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x264A710 Offset: 0x264A811 VA: 0x264A710
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x264A7E0 Offset: 0x264A8E1 VA: 0x264A7E0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x26454B0 Offset: 0x26455B1 VA: 0x26454B0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x264AA80 Offset: 0x264AB81 VA: 0x264AA80 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x264AB60 Offset: 0x264AC61 VA: 0x264AB60 Slot: 24
	public int CompareTo(string strB) { }

	// RVA: 0x264AC20 Offset: 0x264AD21 VA: 0x264AC20
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x264AC70 Offset: 0x264AD71 VA: 0x264AC70
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x264ACA0 Offset: 0x264ADA1 VA: 0x264ACA0
	public bool Contains(string value) { }

	// RVA: 0x264ACE0 Offset: 0x264ADE1 VA: 0x264ACE0
	public bool EndsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0xB6EA0 Offset: 0xB6FA1 VA: 0xB6EA0
	// RVA: 0x2642520 Offset: 0x2642621 VA: 0x2642520
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x264ACF0 Offset: 0x264ADF1 VA: 0x264ACF0
	internal bool EndsWith(char value) { }

	// RVA: 0x264ADB0 Offset: 0x264AEB1 VA: 0x264ADB0
	public int IndexOf(char value) { }

	// RVA: 0x264AF10 Offset: 0x264B011 VA: 0x264AF10
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x2641720 Offset: 0x2641821 VA: 0x2641720
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x264B040 Offset: 0x264B141 VA: 0x264B040
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x263DEB0 Offset: 0x263DFB1 VA: 0x263DEB0
	public int IndexOf(string value) { }

	// RVA: 0x263DEC0 Offset: 0x263DFC1 VA: 0x263DEC0
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x264B060 Offset: 0x264B161 VA: 0x264B060
	public int IndexOf(string value, int startIndex, int count) { }

	// RVA: 0x264ACD0 Offset: 0x264ADD1 VA: 0x264ACD0
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x264B050 Offset: 0x264B151 VA: 0x264B050
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x264B180 Offset: 0x264B281 VA: 0x264B180
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x264B530 Offset: 0x264B631 VA: 0x264B530
	public int LastIndexOf(char value) { }

	// RVA: 0x264B690 Offset: 0x264B791 VA: 0x264B690
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x264B6A0 Offset: 0x264B7A1 VA: 0x264B6A0
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x264B8B0 Offset: 0x264B9B1 VA: 0x264B8B0
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x264B8C0 Offset: 0x264B9C1 VA: 0x264B8C0
	public int LastIndexOf(string value) { }

	// RVA: 0x264BCF0 Offset: 0x264BDF1 VA: 0x264BCF0
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x264B8D0 Offset: 0x264B9D1 VA: 0x264B8D0
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x264BD00 Offset: 0x264BE01 VA: 0x264BD00
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x264BF10 Offset: 0x264C011 VA: 0x264BF10
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x264BF20 Offset: 0x264C021 VA: 0x264BF20
	public bool StartsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0xB6EC0 Offset: 0xB6FC1 VA: 0xB6EC0
	// RVA: 0x264BFC0 Offset: 0x264C0C1 VA: 0x264BFC0
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x264C2A0 Offset: 0x264C3A1 VA: 0x264C2A0
	public string ToLower() { }

	// RVA: 0x264C310 Offset: 0x264C411 VA: 0x264C310
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x264C3C0 Offset: 0x264C4C1 VA: 0x264C3C0
	public string ToLowerInvariant() { }

	// RVA: 0x264C430 Offset: 0x264C531 VA: 0x264C430
	public string ToUpper() { }

	// RVA: 0x264C4A0 Offset: 0x264C5A1 VA: 0x264C4A0
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x264C550 Offset: 0x264C651 VA: 0x264C550
	public string ToUpperInvariant() { }

	// RVA: 0x264C5C0 Offset: 0x264C6C1 VA: 0x264C5C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x264C5D0 Offset: 0x264C6D1 VA: 0x264C5D0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x264C5E0 Offset: 0x264C6E1 VA: 0x264C5E0 Slot: 5
	public object Clone() { }

	// RVA: 0x264C5F0 Offset: 0x264C6F1 VA: 0x264C5F0
	private static bool IsBOMWhitespace(char c) { }

	// RVA: 0x2646760 Offset: 0x2646861 VA: 0x2646760
	public string Trim() { }

	// RVA: 0x26495D0 Offset: 0x26496D1 VA: 0x26495D0
	private string TrimHelper(int trimType) { }

	// RVA: 0x26498A0 Offset: 0x26499A1 VA: 0x26498A0
	private string TrimHelper(char[] trimChars, int trimType) { }

	// RVA: 0x264C600 Offset: 0x264C701 VA: 0x264C600
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x264C6C0 Offset: 0x264C7C1 VA: 0x264C6C0
	public string Insert(int startIndex, string value) { }

	// RVA: 0x264C830 Offset: 0x264C931 VA: 0x264C830
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x264C9D0 Offset: 0x264CAD1 VA: 0x264C9D0
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x264CB80 Offset: 0x264CC81 VA: 0x264CB80
	public string Remove(int startIndex, int count) { }

	// RVA: 0x263DE50 Offset: 0x263DF51 VA: 0x263DE50
	public static string Format(string format, object arg0) { }

	// RVA: 0x2645EF0 Offset: 0x2645FF1 VA: 0x2645EF0
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x264CE00 Offset: 0x264CF01 VA: 0x264CE00
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x264CE60 Offset: 0x264CF61 VA: 0x264CE60
	public static string Format(string format, object[] args) { }

	// RVA: 0x264CF40 Offset: 0x264D041 VA: 0x264CF40
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x264CFA0 Offset: 0x264D0A1 VA: 0x264CFA0
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x264D010 Offset: 0x264D111 VA: 0x264D010
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x264D080 Offset: 0x264D181 VA: 0x264D080
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x264CD00 Offset: 0x264CE01 VA: 0x264CD00
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x264D170 Offset: 0x264D271 VA: 0x264D170
	public static string Copy(string str) { }

	// RVA: 0x264D230 Offset: 0x264D331 VA: 0x264D230
	public static string Concat(object arg0) { }

	// RVA: 0x264D2A0 Offset: 0x264D3A1 VA: 0x264D2A0
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x264D370 Offset: 0x264D471 VA: 0x264D370
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x264D470 Offset: 0x264D571 VA: 0x264D470
	public static string Concat(object[] args) { }

	// RVA: 0x2641160 Offset: 0x2641261 VA: 0x2641160
	public static string Concat(string str0, string str1) { }

	// RVA: 0x26404A0 Offset: 0x26405A1 VA: 0x26404A0
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x264D750 Offset: 0x264D851 VA: 0x264D750
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x264D6A0 Offset: 0x264D7A1 VA: 0x264D6A0
	private static string ConcatArray(string[] values, int totalLength) { }

	// RVA: 0x264D8C0 Offset: 0x264D9C1 VA: 0x264D8C0
	public static string Concat(string[] values) { }

	// RVA: 0x264DA80 Offset: 0x264DB81 VA: 0x264DA80 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x264DA90 Offset: 0x264DB91 VA: 0x264DA90 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x264DB10 Offset: 0x264DC11 VA: 0x264DB10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x264DB90 Offset: 0x264DC91 VA: 0x264DB90 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x264DC10 Offset: 0x264DD11 VA: 0x264DC10 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x264DC90 Offset: 0x264DD91 VA: 0x264DC90 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x264DD10 Offset: 0x264DE11 VA: 0x264DD10 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x264DD90 Offset: 0x264DE91 VA: 0x264DD90 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x264DE10 Offset: 0x264DF11 VA: 0x264DE10 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x264DE90 Offset: 0x264DF91 VA: 0x264DE90 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x264DF10 Offset: 0x264E011 VA: 0x264DF10 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x264DF90 Offset: 0x264E091 VA: 0x264DF90 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x264E010 Offset: 0x264E111 VA: 0x264E010 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x264E090 Offset: 0x264E191 VA: 0x264E090 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x264E110 Offset: 0x264E211 VA: 0x264E110 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x264E190 Offset: 0x264E291 VA: 0x264E190 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x264E210 Offset: 0x264E311 VA: 0x264E210 Slot: 25
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x264E280 Offset: 0x264E381 VA: 0x264E280 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x264E2F0 Offset: 0x264E3F1 VA: 0x264E2F0
	public int get_Length() { }

	// RVA: 0x264E300 Offset: 0x264E401 VA: 0x264E300
	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	// RVA: 0x264ADC0 Offset: 0x264AEC1 VA: 0x264ADC0
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x264E490 Offset: 0x264E591 VA: 0x264E490
	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x264E650 Offset: 0x264E751 VA: 0x264E650
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x264AF20 Offset: 0x264B021 VA: 0x264AF20
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264E7C0 Offset: 0x264E8C1 VA: 0x264E7C0
	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264B540 Offset: 0x264B641 VA: 0x264B540
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x264E8C0 Offset: 0x264E9C1 VA: 0x264E8C0
	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x264B6B0 Offset: 0x264B7B1 VA: 0x264B6B0
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264EA80 Offset: 0x264EB81 VA: 0x264EA80
	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264A910 Offset: 0x264AA11 VA: 0x264A910
	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	// RVA: 0x264C840 Offset: 0x264C941 VA: 0x264C840
	private string ReplaceInternal(char oldChar, char newChar) { }

	// RVA: 0x264CA70 Offset: 0x264CB71 VA: 0x264CA70
	internal string ReplaceInternal(string oldValue, string newValue) { }

	// RVA: 0x264EB80 Offset: 0x264EC81 VA: 0x264EB80
	private string ReplaceUnchecked(string oldValue, string newValue) { }

	// RVA: 0x264F080 Offset: 0x264F181 VA: 0x264F080
	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	// RVA: 0x264BD10 Offset: 0x264BE11 VA: 0x264BD10
	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	// RVA: 0x264F250 Offset: 0x264F351 VA: 0x264F250
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x26481D0 Offset: 0x26482D1 VA: 0x26481D0
	internal bool IsAscii() { }

	// RVA: 0x264EB30 Offset: 0x264EC31 VA: 0x264EB30
	internal static void CharCopy(char* dest, char* src, int count) { }

	// RVA: 0x264F2A0 Offset: 0x264F3A1 VA: 0x264F2A0
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x264F430 Offset: 0x264F531 VA: 0x264F430
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x264F440 Offset: 0x264F541 VA: 0x264F440
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x264F590 Offset: 0x264F691 VA: 0x264F590
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x264F5A0 Offset: 0x264F6A1 VA: 0x264F5A0
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x264F5B0 Offset: 0x264F6B1 VA: 0x264F5B0
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x264F5C0 Offset: 0x264F6C1 VA: 0x264F5C0
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x264F5D0 Offset: 0x264F6D1 VA: 0x264F5D0
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x264F5E0 Offset: 0x264F6E1 VA: 0x264F5E0
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x264F5F0 Offset: 0x264F6F1 VA: 0x264F5F0
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x264F600 Offset: 0x264F701 VA: 0x264F600
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x264F610 Offset: 0x264F711 VA: 0x264F610
	private string CreateString(sbyte* value) { }

	// RVA: 0x264F990 Offset: 0x264FA91 VA: 0x264F990
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x264F9A0 Offset: 0x264FAA1 VA: 0x264F9A0
	private string CreateString(char* value) { }

	// RVA: 0x264F9B0 Offset: 0x264FAB1 VA: 0x264F9B0
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x2645DF0 Offset: 0x2645EF1 VA: 0x2645DF0
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x263AFD0 Offset: 0x263B0D1 VA: 0x263AFD0
	private string CreateString(char[] val) { }

	// RVA: 0x26451F0 Offset: 0x26452F1 VA: 0x26451F0
	private string CreateString(char c, int count) { }

	// RVA: 0x264F6B0 Offset: 0x264F7B1 VA: 0x264F6B0
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }
}

[DefaultMemberAttribute] // RVA: 0xAC760 Offset: 0xAC861 VA: 0xAC760
[ComVisibleAttribute] // RVA: 0xAC760 Offset: 0xAC861 VA: 0xAC760
[Serializable]
public sealed class String : IComparable, ICloneable, IConvertible, IEnumerable, IComparable<string>, IEnumerable<char>, IEquatable<string> // TypeDefIndex: 310
{
	// Fields
	private int m_stringLength; // 0x10
	private char m_firstChar; // 0x14
	private const int TrimHead = 0;
	private const int TrimTail = 1;
	private const int TrimBoth = 2;
	public static readonly string Empty; // 0x0
	private const int charPtrAlignConst = 1;
	private const int alignConst = 3;

	// Properties
	public char Chars { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x2647460 Offset: 0x2647561 VA: 0x2647460
	public static string Join(string separator, string[] value) { }

	[ComVisibleAttribute] // RVA: 0xB6D40 Offset: 0xB6E41 VA: 0xB6D40
	// RVA: 0x26477A0 Offset: 0x26478A1 VA: 0x26477A0
	public static string Join(string separator, object[] values) { }

	// RVA: 0x2647500 Offset: 0x2647601 VA: 0x2647500
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: 0x2647970 Offset: 0x2647A71 VA: 0x2647970
	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D60 Offset: 0xB6E61 VA: 0xB6D60
	// RVA: 0x2647A60 Offset: 0x2647B61 VA: 0x2647A60
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x2647C40 Offset: 0x2647D41 VA: 0x2647C40
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D80 Offset: 0xB6E81 VA: 0xB6D80
	// RVA: 0x2647DE0 Offset: 0x2647EE1 VA: 0x2647DE0 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0xB6DA0 Offset: 0xB6EA1 VA: 0xB6DA0
	// RVA: 0x2642450 Offset: 0x2642551 VA: 0x2642450 Slot: 26
	public bool Equals(string value) { }

	// RVA: 0x2647ED0 Offset: 0x2647FD1 VA: 0x2647ED0
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x2648210 Offset: 0x2648311 VA: 0x2648210
	public static bool Equals(string a, string b) { }

	// RVA: 0x2648250 Offset: 0x2648351 VA: 0x2648250
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x263DC80 Offset: 0x263DD81 VA: 0x263DC80
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x2648540 Offset: 0x2648641 VA: 0x2648540
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x263AF30 Offset: 0x263B031 VA: 0x263AF30
	public char get_Chars(int index) { }

	// RVA: 0x26485A0 Offset: 0x26486A1 VA: 0x26485A0
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x2648790 Offset: 0x2648891 VA: 0x2648790
	public char[] ToCharArray() { }

	// RVA: 0x2648830 Offset: 0x2648931 VA: 0x2648830
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x2648850 Offset: 0x2648951 VA: 0x2648850
	public static bool IsNullOrWhiteSpace(string value) { }

	[ReliabilityContractAttribute] // RVA: 0xB6DC0 Offset: 0xB6EC1 VA: 0xB6DC0
	// RVA: 0x2648980 Offset: 0x2648A81 VA: 0x2648980 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0xB6DE0 Offset: 0xB6EE1 VA: 0xB6DE0
	// RVA: 0x2648A00 Offset: 0x2648B01 VA: 0x2648A00
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x2648A80 Offset: 0x2648B81 VA: 0x2648A80
	public string[] Split(char[] separator) { }

	[ComVisibleAttribute] // RVA: 0xB6E00 Offset: 0xB6F01 VA: 0xB6E00
	// RVA: 0x2648D00 Offset: 0x2648E01 VA: 0x2648D00
	public string[] Split(char[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0xB6E20 Offset: 0xB6F21 VA: 0xB6E20
	// RVA: 0x2648A90 Offset: 0x2648B91 VA: 0x2648A90
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x26492D0 Offset: 0x26493D1 VA: 0x26492D0
	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x2648F00 Offset: 0x2649001 VA: 0x2648F00
	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x2648D10 Offset: 0x2648E11 VA: 0x2648D10
	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	// RVA: 0x2649540 Offset: 0x2649641 VA: 0x2649540
	public string Substring(int startIndex) { }

	// RVA: 0x263DED0 Offset: 0x263DFD1 VA: 0x263DED0
	public string Substring(int startIndex, int length) { }

	// RVA: 0x2649550 Offset: 0x2649651 VA: 0x2649550
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x26495B0 Offset: 0x26496B1 VA: 0x26495B0
	public string Trim(char[] trimChars) { }

	// RVA: 0x2649BB0 Offset: 0x2649CB1 VA: 0x2649BB0
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x2649BD0 Offset: 0x2649CD1 VA: 0x2649BD0
	public string TrimEnd(char[] trimChars) { }

	[CLSCompliantAttribute] // RVA: 0xB6E40 Offset: 0xB6F41 VA: 0xB6E40
	// RVA: 0x2649BF0 Offset: 0x2649CF1 VA: 0x2649BF0
	public void .ctor(char* value) { }

	[CLSCompliantAttribute] // RVA: 0xB6E60 Offset: 0xB6F61 VA: 0xB6E60
	// RVA: 0x2649C00 Offset: 0x2649D01 VA: 0x2649C00
	public void .ctor(char* value, int startIndex, int length) { }

	[CLSCompliantAttribute] // RVA: 0xB6E80 Offset: 0xB6F81 VA: 0xB6E80
	// RVA: 0x2649C10 Offset: 0x2649D11 VA: 0x2649C10
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x2649C20 Offset: 0x2649D21 VA: 0x2649C20
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x2649D00 Offset: 0x2649E01 VA: 0x2649D00
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x2647960 Offset: 0x2647A61 VA: 0x2647960
	internal static string FastAllocateString(int length) { }

	// RVA: 0x2649DE0 Offset: 0x2649EE1 VA: 0x2649DE0
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x2649EA0 Offset: 0x2649FA1 VA: 0x2649EA0
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x2649EB0 Offset: 0x2649FB1 VA: 0x2649EB0
	public void .ctor(char[] value) { }

	// RVA: 0x2648780 Offset: 0x2648881 VA: 0x2648780
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x2649EC0 Offset: 0x2649FC1 VA: 0x2649EC0
	private string CtorCharArray(char[] value) { }

	// RVA: 0x2649F70 Offset: 0x264A071 VA: 0x2649F70
	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	// RVA: 0x264A120 Offset: 0x264A221 VA: 0x264A120
	private static int wcslen(char* ptr) { }

	// RVA: 0x264A1A0 Offset: 0x264A2A1 VA: 0x264A1A0
	private string CtorCharPtr(char* ptr) { }

	// RVA: 0x264A3D0 Offset: 0x264A4D1 VA: 0x264A3D0
	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	// RVA: 0x264A600 Offset: 0x264A701 VA: 0x264A600
	public void .ctor(char c, int count) { }

	// RVA: 0x264A610 Offset: 0x264A711 VA: 0x264A610
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x26443E0 Offset: 0x26444E1 VA: 0x26443E0
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x264A710 Offset: 0x264A811 VA: 0x264A710
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x264A7E0 Offset: 0x264A8E1 VA: 0x264A7E0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x26454B0 Offset: 0x26455B1 VA: 0x26454B0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x264AA80 Offset: 0x264AB81 VA: 0x264AA80 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x264AB60 Offset: 0x264AC61 VA: 0x264AB60 Slot: 24
	public int CompareTo(string strB) { }

	// RVA: 0x264AC20 Offset: 0x264AD21 VA: 0x264AC20
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x264AC70 Offset: 0x264AD71 VA: 0x264AC70
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x264ACA0 Offset: 0x264ADA1 VA: 0x264ACA0
	public bool Contains(string value) { }

	// RVA: 0x264ACE0 Offset: 0x264ADE1 VA: 0x264ACE0
	public bool EndsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0xB6EA0 Offset: 0xB6FA1 VA: 0xB6EA0
	// RVA: 0x2642520 Offset: 0x2642621 VA: 0x2642520
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x264ACF0 Offset: 0x264ADF1 VA: 0x264ACF0
	internal bool EndsWith(char value) { }

	// RVA: 0x264ADB0 Offset: 0x264AEB1 VA: 0x264ADB0
	public int IndexOf(char value) { }

	// RVA: 0x264AF10 Offset: 0x264B011 VA: 0x264AF10
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x2641720 Offset: 0x2641821 VA: 0x2641720
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x264B040 Offset: 0x264B141 VA: 0x264B040
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x263DEB0 Offset: 0x263DFB1 VA: 0x263DEB0
	public int IndexOf(string value) { }

	// RVA: 0x263DEC0 Offset: 0x263DFC1 VA: 0x263DEC0
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x264B060 Offset: 0x264B161 VA: 0x264B060
	public int IndexOf(string value, int startIndex, int count) { }

	// RVA: 0x264ACD0 Offset: 0x264ADD1 VA: 0x264ACD0
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x264B050 Offset: 0x264B151 VA: 0x264B050
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x264B180 Offset: 0x264B281 VA: 0x264B180
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x264B530 Offset: 0x264B631 VA: 0x264B530
	public int LastIndexOf(char value) { }

	// RVA: 0x264B690 Offset: 0x264B791 VA: 0x264B690
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x264B6A0 Offset: 0x264B7A1 VA: 0x264B6A0
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x264B8B0 Offset: 0x264B9B1 VA: 0x264B8B0
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x264B8C0 Offset: 0x264B9C1 VA: 0x264B8C0
	public int LastIndexOf(string value) { }

	// RVA: 0x264BCF0 Offset: 0x264BDF1 VA: 0x264BCF0
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x264B8D0 Offset: 0x264B9D1 VA: 0x264B8D0
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x264BD00 Offset: 0x264BE01 VA: 0x264BD00
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x264BF10 Offset: 0x264C011 VA: 0x264BF10
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x264BF20 Offset: 0x264C021 VA: 0x264BF20
	public bool StartsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0xB6EC0 Offset: 0xB6FC1 VA: 0xB6EC0
	// RVA: 0x264BFC0 Offset: 0x264C0C1 VA: 0x264BFC0
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x264C2A0 Offset: 0x264C3A1 VA: 0x264C2A0
	public string ToLower() { }

	// RVA: 0x264C310 Offset: 0x264C411 VA: 0x264C310
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x264C3C0 Offset: 0x264C4C1 VA: 0x264C3C0
	public string ToLowerInvariant() { }

	// RVA: 0x264C430 Offset: 0x264C531 VA: 0x264C430
	public string ToUpper() { }

	// RVA: 0x264C4A0 Offset: 0x264C5A1 VA: 0x264C4A0
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x264C550 Offset: 0x264C651 VA: 0x264C550
	public string ToUpperInvariant() { }

	// RVA: 0x264C5C0 Offset: 0x264C6C1 VA: 0x264C5C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x264C5D0 Offset: 0x264C6D1 VA: 0x264C5D0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x264C5E0 Offset: 0x264C6E1 VA: 0x264C5E0 Slot: 5
	public object Clone() { }

	// RVA: 0x264C5F0 Offset: 0x264C6F1 VA: 0x264C5F0
	private static bool IsBOMWhitespace(char c) { }

	// RVA: 0x2646760 Offset: 0x2646861 VA: 0x2646760
	public string Trim() { }

	// RVA: 0x26495D0 Offset: 0x26496D1 VA: 0x26495D0
	private string TrimHelper(int trimType) { }

	// RVA: 0x26498A0 Offset: 0x26499A1 VA: 0x26498A0
	private string TrimHelper(char[] trimChars, int trimType) { }

	// RVA: 0x264C600 Offset: 0x264C701 VA: 0x264C600
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x264C6C0 Offset: 0x264C7C1 VA: 0x264C6C0
	public string Insert(int startIndex, string value) { }

	// RVA: 0x264C830 Offset: 0x264C931 VA: 0x264C830
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x264C9D0 Offset: 0x264CAD1 VA: 0x264C9D0
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x264CB80 Offset: 0x264CC81 VA: 0x264CB80
	public string Remove(int startIndex, int count) { }

	// RVA: 0x263DE50 Offset: 0x263DF51 VA: 0x263DE50
	public static string Format(string format, object arg0) { }

	// RVA: 0x2645EF0 Offset: 0x2645FF1 VA: 0x2645EF0
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x264CE00 Offset: 0x264CF01 VA: 0x264CE00
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x264CE60 Offset: 0x264CF61 VA: 0x264CE60
	public static string Format(string format, object[] args) { }

	// RVA: 0x264CF40 Offset: 0x264D041 VA: 0x264CF40
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x264CFA0 Offset: 0x264D0A1 VA: 0x264CFA0
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x264D010 Offset: 0x264D111 VA: 0x264D010
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x264D080 Offset: 0x264D181 VA: 0x264D080
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x264CD00 Offset: 0x264CE01 VA: 0x264CD00
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x264D170 Offset: 0x264D271 VA: 0x264D170
	public static string Copy(string str) { }

	// RVA: 0x264D230 Offset: 0x264D331 VA: 0x264D230
	public static string Concat(object arg0) { }

	// RVA: 0x264D2A0 Offset: 0x264D3A1 VA: 0x264D2A0
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x264D370 Offset: 0x264D471 VA: 0x264D370
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x264D470 Offset: 0x264D571 VA: 0x264D470
	public static string Concat(object[] args) { }

	// RVA: 0x2641160 Offset: 0x2641261 VA: 0x2641160
	public static string Concat(string str0, string str1) { }

	// RVA: 0x26404A0 Offset: 0x26405A1 VA: 0x26404A0
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x264D750 Offset: 0x264D851 VA: 0x264D750
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x264D6A0 Offset: 0x264D7A1 VA: 0x264D6A0
	private static string ConcatArray(string[] values, int totalLength) { }

	// RVA: 0x264D8C0 Offset: 0x264D9C1 VA: 0x264D8C0
	public static string Concat(string[] values) { }

	// RVA: 0x264DA80 Offset: 0x264DB81 VA: 0x264DA80 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x264DA90 Offset: 0x264DB91 VA: 0x264DA90 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x264DB10 Offset: 0x264DC11 VA: 0x264DB10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x264DB90 Offset: 0x264DC91 VA: 0x264DB90 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x264DC10 Offset: 0x264DD11 VA: 0x264DC10 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x264DC90 Offset: 0x264DD91 VA: 0x264DC90 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x264DD10 Offset: 0x264DE11 VA: 0x264DD10 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x264DD90 Offset: 0x264DE91 VA: 0x264DD90 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x264DE10 Offset: 0x264DF11 VA: 0x264DE10 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x264DE90 Offset: 0x264DF91 VA: 0x264DE90 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x264DF10 Offset: 0x264E011 VA: 0x264DF10 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x264DF90 Offset: 0x264E091 VA: 0x264DF90 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x264E010 Offset: 0x264E111 VA: 0x264E010 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x264E090 Offset: 0x264E191 VA: 0x264E090 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x264E110 Offset: 0x264E211 VA: 0x264E110 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x264E190 Offset: 0x264E291 VA: 0x264E190 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x264E210 Offset: 0x264E311 VA: 0x264E210 Slot: 25
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x264E280 Offset: 0x264E381 VA: 0x264E280 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x264E2F0 Offset: 0x264E3F1 VA: 0x264E2F0
	public int get_Length() { }

	// RVA: 0x264E300 Offset: 0x264E401 VA: 0x264E300
	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	// RVA: 0x264ADC0 Offset: 0x264AEC1 VA: 0x264ADC0
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x264E490 Offset: 0x264E591 VA: 0x264E490
	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x264E650 Offset: 0x264E751 VA: 0x264E650
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x264AF20 Offset: 0x264B021 VA: 0x264AF20
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264E7C0 Offset: 0x264E8C1 VA: 0x264E7C0
	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264B540 Offset: 0x264B641 VA: 0x264B540
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x264E8C0 Offset: 0x264E9C1 VA: 0x264E8C0
	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x264B6B0 Offset: 0x264B7B1 VA: 0x264B6B0
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264EA80 Offset: 0x264EB81 VA: 0x264EA80
	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264A910 Offset: 0x264AA11 VA: 0x264A910
	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	// RVA: 0x264C840 Offset: 0x264C941 VA: 0x264C840
	private string ReplaceInternal(char oldChar, char newChar) { }

	// RVA: 0x264CA70 Offset: 0x264CB71 VA: 0x264CA70
	internal string ReplaceInternal(string oldValue, string newValue) { }

	// RVA: 0x264EB80 Offset: 0x264EC81 VA: 0x264EB80
	private string ReplaceUnchecked(string oldValue, string newValue) { }

	// RVA: 0x264F080 Offset: 0x264F181 VA: 0x264F080
	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	// RVA: 0x264BD10 Offset: 0x264BE11 VA: 0x264BD10
	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	// RVA: 0x264F250 Offset: 0x264F351 VA: 0x264F250
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x26481D0 Offset: 0x26482D1 VA: 0x26481D0
	internal bool IsAscii() { }

	// RVA: 0x264EB30 Offset: 0x264EC31 VA: 0x264EB30
	internal static void CharCopy(char* dest, char* src, int count) { }

	// RVA: 0x264F2A0 Offset: 0x264F3A1 VA: 0x264F2A0
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x264F430 Offset: 0x264F531 VA: 0x264F430
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x264F440 Offset: 0x264F541 VA: 0x264F440
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x264F590 Offset: 0x264F691 VA: 0x264F590
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x264F5A0 Offset: 0x264F6A1 VA: 0x264F5A0
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x264F5B0 Offset: 0x264F6B1 VA: 0x264F5B0
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x264F5C0 Offset: 0x264F6C1 VA: 0x264F5C0
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x264F5D0 Offset: 0x264F6D1 VA: 0x264F5D0
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x264F5E0 Offset: 0x264F6E1 VA: 0x264F5E0
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x264F5F0 Offset: 0x264F6F1 VA: 0x264F5F0
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x264F600 Offset: 0x264F701 VA: 0x264F600
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x264F610 Offset: 0x264F711 VA: 0x264F610
	private string CreateString(sbyte* value) { }

	// RVA: 0x264F990 Offset: 0x264FA91 VA: 0x264F990
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x264F9A0 Offset: 0x264FAA1 VA: 0x264F9A0
	private string CreateString(char* value) { }

	// RVA: 0x264F9B0 Offset: 0x264FAB1 VA: 0x264F9B0
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x2645DF0 Offset: 0x2645EF1 VA: 0x2645DF0
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x263AFD0 Offset: 0x263B0D1 VA: 0x263AFD0
	private string CreateString(char[] val) { }

	// RVA: 0x26451F0 Offset: 0x26452F1 VA: 0x26451F0
	private string CreateString(char c, int count) { }

	// RVA: 0x264F6B0 Offset: 0x264F7B1 VA: 0x264F6B0
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }
}

[DefaultMemberAttribute] // RVA: 0xAC760 Offset: 0xAC861 VA: 0xAC760
[ComVisibleAttribute] // RVA: 0xAC760 Offset: 0xAC861 VA: 0xAC760
[Serializable]
public sealed class String : IComparable, ICloneable, IConvertible, IEnumerable, IComparable<string>, IEnumerable<char>, IEquatable<string> // TypeDefIndex: 310
{
	// Fields
	private int m_stringLength; // 0x10
	private char m_firstChar; // 0x14
	private const int TrimHead = 0;
	private const int TrimTail = 1;
	private const int TrimBoth = 2;
	public static readonly string Empty; // 0x0
	private const int charPtrAlignConst = 1;
	private const int alignConst = 3;

	// Properties
	public char Chars { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x2647460 Offset: 0x2647561 VA: 0x2647460
	public static string Join(string separator, string[] value) { }

	[ComVisibleAttribute] // RVA: 0xB6D40 Offset: 0xB6E41 VA: 0xB6D40
	// RVA: 0x26477A0 Offset: 0x26478A1 VA: 0x26477A0
	public static string Join(string separator, object[] values) { }

	// RVA: 0x2647500 Offset: 0x2647601 VA: 0x2647500
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: 0x2647970 Offset: 0x2647A71 VA: 0x2647970
	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D60 Offset: 0xB6E61 VA: 0xB6D60
	// RVA: 0x2647A60 Offset: 0x2647B61 VA: 0x2647A60
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x2647C40 Offset: 0x2647D41 VA: 0x2647C40
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D80 Offset: 0xB6E81 VA: 0xB6D80
	// RVA: 0x2647DE0 Offset: 0x2647EE1 VA: 0x2647DE0 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0xB6DA0 Offset: 0xB6EA1 VA: 0xB6DA0
	// RVA: 0x2642450 Offset: 0x2642551 VA: 0x2642450 Slot: 26
	public bool Equals(string value) { }

	// RVA: 0x2647ED0 Offset: 0x2647FD1 VA: 0x2647ED0
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x2648210 Offset: 0x2648311 VA: 0x2648210
	public static bool Equals(string a, string b) { }

	// RVA: 0x2648250 Offset: 0x2648351 VA: 0x2648250
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x263DC80 Offset: 0x263DD81 VA: 0x263DC80
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x2648540 Offset: 0x2648641 VA: 0x2648540
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x263AF30 Offset: 0x263B031 VA: 0x263AF30
	public char get_Chars(int index) { }

	// RVA: 0x26485A0 Offset: 0x26486A1 VA: 0x26485A0
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x2648790 Offset: 0x2648891 VA: 0x2648790
	public char[] ToCharArray() { }

	// RVA: 0x2648830 Offset: 0x2648931 VA: 0x2648830
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x2648850 Offset: 0x2648951 VA: 0x2648850
	public static bool IsNullOrWhiteSpace(string value) { }

	[ReliabilityContractAttribute] // RVA: 0xB6DC0 Offset: 0xB6EC1 VA: 0xB6DC0
	// RVA: 0x2648980 Offset: 0x2648A81 VA: 0x2648980 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0xB6DE0 Offset: 0xB6EE1 VA: 0xB6DE0
	// RVA: 0x2648A00 Offset: 0x2648B01 VA: 0x2648A00
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x2648A80 Offset: 0x2648B81 VA: 0x2648A80
	public string[] Split(char[] separator) { }

	[ComVisibleAttribute] // RVA: 0xB6E00 Offset: 0xB6F01 VA: 0xB6E00
	// RVA: 0x2648D00 Offset: 0x2648E01 VA: 0x2648D00
	public string[] Split(char[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0xB6E20 Offset: 0xB6F21 VA: 0xB6E20
	// RVA: 0x2648A90 Offset: 0x2648B91 VA: 0x2648A90
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x26492D0 Offset: 0x26493D1 VA: 0x26492D0
	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x2648F00 Offset: 0x2649001 VA: 0x2648F00
	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x2648D10 Offset: 0x2648E11 VA: 0x2648D10
	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	// RVA: 0x2649540 Offset: 0x2649641 VA: 0x2649540
	public string Substring(int startIndex) { }

	// RVA: 0x263DED0 Offset: 0x263DFD1 VA: 0x263DED0
	public string Substring(int startIndex, int length) { }

	// RVA: 0x2649550 Offset: 0x2649651 VA: 0x2649550
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x26495B0 Offset: 0x26496B1 VA: 0x26495B0
	public string Trim(char[] trimChars) { }

	// RVA: 0x2649BB0 Offset: 0x2649CB1 VA: 0x2649BB0
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x2649BD0 Offset: 0x2649CD1 VA: 0x2649BD0
	public string TrimEnd(char[] trimChars) { }

	[CLSCompliantAttribute] // RVA: 0xB6E40 Offset: 0xB6F41 VA: 0xB6E40
	// RVA: 0x2649BF0 Offset: 0x2649CF1 VA: 0x2649BF0
	public void .ctor(char* value) { }

	[CLSCompliantAttribute] // RVA: 0xB6E60 Offset: 0xB6F61 VA: 0xB6E60
	// RVA: 0x2649C00 Offset: 0x2649D01 VA: 0x2649C00
	public void .ctor(char* value, int startIndex, int length) { }

	[CLSCompliantAttribute] // RVA: 0xB6E80 Offset: 0xB6F81 VA: 0xB6E80
	// RVA: 0x2649C10 Offset: 0x2649D11 VA: 0x2649C10
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x2649C20 Offset: 0x2649D21 VA: 0x2649C20
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x2649D00 Offset: 0x2649E01 VA: 0x2649D00
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x2647960 Offset: 0x2647A61 VA: 0x2647960
	internal static string FastAllocateString(int length) { }

	// RVA: 0x2649DE0 Offset: 0x2649EE1 VA: 0x2649DE0
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x2649EA0 Offset: 0x2649FA1 VA: 0x2649EA0
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x2649EB0 Offset: 0x2649FB1 VA: 0x2649EB0
	public void .ctor(char[] value) { }

	// RVA: 0x2648780 Offset: 0x2648881 VA: 0x2648780
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x2649EC0 Offset: 0x2649FC1 VA: 0x2649EC0
	private string CtorCharArray(char[] value) { }

	// RVA: 0x2649F70 Offset: 0x264A071 VA: 0x2649F70
	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	// RVA: 0x264A120 Offset: 0x264A221 VA: 0x264A120
	private static int wcslen(char* ptr) { }

	// RVA: 0x264A1A0 Offset: 0x264A2A1 VA: 0x264A1A0
	private string CtorCharPtr(char* ptr) { }

	// RVA: 0x264A3D0 Offset: 0x264A4D1 VA: 0x264A3D0
	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	// RVA: 0x264A600 Offset: 0x264A701 VA: 0x264A600
	public void .ctor(char c, int count) { }

	// RVA: 0x264A610 Offset: 0x264A711 VA: 0x264A610
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x26443E0 Offset: 0x26444E1 VA: 0x26443E0
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x264A710 Offset: 0x264A811 VA: 0x264A710
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x264A7E0 Offset: 0x264A8E1 VA: 0x264A7E0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x26454B0 Offset: 0x26455B1 VA: 0x26454B0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x264AA80 Offset: 0x264AB81 VA: 0x264AA80 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x264AB60 Offset: 0x264AC61 VA: 0x264AB60 Slot: 24
	public int CompareTo(string strB) { }

	// RVA: 0x264AC20 Offset: 0x264AD21 VA: 0x264AC20
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x264AC70 Offset: 0x264AD71 VA: 0x264AC70
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x264ACA0 Offset: 0x264ADA1 VA: 0x264ACA0
	public bool Contains(string value) { }

	// RVA: 0x264ACE0 Offset: 0x264ADE1 VA: 0x264ACE0
	public bool EndsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0xB6EA0 Offset: 0xB6FA1 VA: 0xB6EA0
	// RVA: 0x2642520 Offset: 0x2642621 VA: 0x2642520
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x264ACF0 Offset: 0x264ADF1 VA: 0x264ACF0
	internal bool EndsWith(char value) { }

	// RVA: 0x264ADB0 Offset: 0x264AEB1 VA: 0x264ADB0
	public int IndexOf(char value) { }

	// RVA: 0x264AF10 Offset: 0x264B011 VA: 0x264AF10
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x2641720 Offset: 0x2641821 VA: 0x2641720
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x264B040 Offset: 0x264B141 VA: 0x264B040
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x263DEB0 Offset: 0x263DFB1 VA: 0x263DEB0
	public int IndexOf(string value) { }

	// RVA: 0x263DEC0 Offset: 0x263DFC1 VA: 0x263DEC0
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x264B060 Offset: 0x264B161 VA: 0x264B060
	public int IndexOf(string value, int startIndex, int count) { }

	// RVA: 0x264ACD0 Offset: 0x264ADD1 VA: 0x264ACD0
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x264B050 Offset: 0x264B151 VA: 0x264B050
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x264B180 Offset: 0x264B281 VA: 0x264B180
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x264B530 Offset: 0x264B631 VA: 0x264B530
	public int LastIndexOf(char value) { }

	// RVA: 0x264B690 Offset: 0x264B791 VA: 0x264B690
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x264B6A0 Offset: 0x264B7A1 VA: 0x264B6A0
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x264B8B0 Offset: 0x264B9B1 VA: 0x264B8B0
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x264B8C0 Offset: 0x264B9C1 VA: 0x264B8C0
	public int LastIndexOf(string value) { }

	// RVA: 0x264BCF0 Offset: 0x264BDF1 VA: 0x264BCF0
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x264B8D0 Offset: 0x264B9D1 VA: 0x264B8D0
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x264BD00 Offset: 0x264BE01 VA: 0x264BD00
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x264BF10 Offset: 0x264C011 VA: 0x264BF10
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x264BF20 Offset: 0x264C021 VA: 0x264BF20
	public bool StartsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0xB6EC0 Offset: 0xB6FC1 VA: 0xB6EC0
	// RVA: 0x264BFC0 Offset: 0x264C0C1 VA: 0x264BFC0
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x264C2A0 Offset: 0x264C3A1 VA: 0x264C2A0
	public string ToLower() { }

	// RVA: 0x264C310 Offset: 0x264C411 VA: 0x264C310
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x264C3C0 Offset: 0x264C4C1 VA: 0x264C3C0
	public string ToLowerInvariant() { }

	// RVA: 0x264C430 Offset: 0x264C531 VA: 0x264C430
	public string ToUpper() { }

	// RVA: 0x264C4A0 Offset: 0x264C5A1 VA: 0x264C4A0
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x264C550 Offset: 0x264C651 VA: 0x264C550
	public string ToUpperInvariant() { }

	// RVA: 0x264C5C0 Offset: 0x264C6C1 VA: 0x264C5C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x264C5D0 Offset: 0x264C6D1 VA: 0x264C5D0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x264C5E0 Offset: 0x264C6E1 VA: 0x264C5E0 Slot: 5
	public object Clone() { }

	// RVA: 0x264C5F0 Offset: 0x264C6F1 VA: 0x264C5F0
	private static bool IsBOMWhitespace(char c) { }

	// RVA: 0x2646760 Offset: 0x2646861 VA: 0x2646760
	public string Trim() { }

	// RVA: 0x26495D0 Offset: 0x26496D1 VA: 0x26495D0
	private string TrimHelper(int trimType) { }

	// RVA: 0x26498A0 Offset: 0x26499A1 VA: 0x26498A0
	private string TrimHelper(char[] trimChars, int trimType) { }

	// RVA: 0x264C600 Offset: 0x264C701 VA: 0x264C600
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x264C6C0 Offset: 0x264C7C1 VA: 0x264C6C0
	public string Insert(int startIndex, string value) { }

	// RVA: 0x264C830 Offset: 0x264C931 VA: 0x264C830
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x264C9D0 Offset: 0x264CAD1 VA: 0x264C9D0
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x264CB80 Offset: 0x264CC81 VA: 0x264CB80
	public string Remove(int startIndex, int count) { }

	// RVA: 0x263DE50 Offset: 0x263DF51 VA: 0x263DE50
	public static string Format(string format, object arg0) { }

	// RVA: 0x2645EF0 Offset: 0x2645FF1 VA: 0x2645EF0
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x264CE00 Offset: 0x264CF01 VA: 0x264CE00
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x264CE60 Offset: 0x264CF61 VA: 0x264CE60
	public static string Format(string format, object[] args) { }

	// RVA: 0x264CF40 Offset: 0x264D041 VA: 0x264CF40
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x264CFA0 Offset: 0x264D0A1 VA: 0x264CFA0
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x264D010 Offset: 0x264D111 VA: 0x264D010
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x264D080 Offset: 0x264D181 VA: 0x264D080
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x264CD00 Offset: 0x264CE01 VA: 0x264CD00
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x264D170 Offset: 0x264D271 VA: 0x264D170
	public static string Copy(string str) { }

	// RVA: 0x264D230 Offset: 0x264D331 VA: 0x264D230
	public static string Concat(object arg0) { }

	// RVA: 0x264D2A0 Offset: 0x264D3A1 VA: 0x264D2A0
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x264D370 Offset: 0x264D471 VA: 0x264D370
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x264D470 Offset: 0x264D571 VA: 0x264D470
	public static string Concat(object[] args) { }

	// RVA: 0x2641160 Offset: 0x2641261 VA: 0x2641160
	public static string Concat(string str0, string str1) { }

	// RVA: 0x26404A0 Offset: 0x26405A1 VA: 0x26404A0
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x264D750 Offset: 0x264D851 VA: 0x264D750
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x264D6A0 Offset: 0x264D7A1 VA: 0x264D6A0
	private static string ConcatArray(string[] values, int totalLength) { }

	// RVA: 0x264D8C0 Offset: 0x264D9C1 VA: 0x264D8C0
	public static string Concat(string[] values) { }

	// RVA: 0x264DA80 Offset: 0x264DB81 VA: 0x264DA80 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x264DA90 Offset: 0x264DB91 VA: 0x264DA90 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x264DB10 Offset: 0x264DC11 VA: 0x264DB10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x264DB90 Offset: 0x264DC91 VA: 0x264DB90 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x264DC10 Offset: 0x264DD11 VA: 0x264DC10 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x264DC90 Offset: 0x264DD91 VA: 0x264DC90 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x264DD10 Offset: 0x264DE11 VA: 0x264DD10 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x264DD90 Offset: 0x264DE91 VA: 0x264DD90 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x264DE10 Offset: 0x264DF11 VA: 0x264DE10 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x264DE90 Offset: 0x264DF91 VA: 0x264DE90 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x264DF10 Offset: 0x264E011 VA: 0x264DF10 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x264DF90 Offset: 0x264E091 VA: 0x264DF90 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x264E010 Offset: 0x264E111 VA: 0x264E010 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x264E090 Offset: 0x264E191 VA: 0x264E090 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x264E110 Offset: 0x264E211 VA: 0x264E110 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x264E190 Offset: 0x264E291 VA: 0x264E190 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x264E210 Offset: 0x264E311 VA: 0x264E210 Slot: 25
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x264E280 Offset: 0x264E381 VA: 0x264E280 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x264E2F0 Offset: 0x264E3F1 VA: 0x264E2F0
	public int get_Length() { }

	// RVA: 0x264E300 Offset: 0x264E401 VA: 0x264E300
	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	// RVA: 0x264ADC0 Offset: 0x264AEC1 VA: 0x264ADC0
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x264E490 Offset: 0x264E591 VA: 0x264E490
	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x264E650 Offset: 0x264E751 VA: 0x264E650
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x264AF20 Offset: 0x264B021 VA: 0x264AF20
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264E7C0 Offset: 0x264E8C1 VA: 0x264E7C0
	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264B540 Offset: 0x264B641 VA: 0x264B540
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x264E8C0 Offset: 0x264E9C1 VA: 0x264E8C0
	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x264B6B0 Offset: 0x264B7B1 VA: 0x264B6B0
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264EA80 Offset: 0x264EB81 VA: 0x264EA80
	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264A910 Offset: 0x264AA11 VA: 0x264A910
	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	// RVA: 0x264C840 Offset: 0x264C941 VA: 0x264C840
	private string ReplaceInternal(char oldChar, char newChar) { }

	// RVA: 0x264CA70 Offset: 0x264CB71 VA: 0x264CA70
	internal string ReplaceInternal(string oldValue, string newValue) { }

	// RVA: 0x264EB80 Offset: 0x264EC81 VA: 0x264EB80
	private string ReplaceUnchecked(string oldValue, string newValue) { }

	// RVA: 0x264F080 Offset: 0x264F181 VA: 0x264F080
	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	// RVA: 0x264BD10 Offset: 0x264BE11 VA: 0x264BD10
	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	// RVA: 0x264F250 Offset: 0x264F351 VA: 0x264F250
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x26481D0 Offset: 0x26482D1 VA: 0x26481D0
	internal bool IsAscii() { }

	// RVA: 0x264EB30 Offset: 0x264EC31 VA: 0x264EB30
	internal static void CharCopy(char* dest, char* src, int count) { }

	// RVA: 0x264F2A0 Offset: 0x264F3A1 VA: 0x264F2A0
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x264F430 Offset: 0x264F531 VA: 0x264F430
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x264F440 Offset: 0x264F541 VA: 0x264F440
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x264F590 Offset: 0x264F691 VA: 0x264F590
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x264F5A0 Offset: 0x264F6A1 VA: 0x264F5A0
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x264F5B0 Offset: 0x264F6B1 VA: 0x264F5B0
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x264F5C0 Offset: 0x264F6C1 VA: 0x264F5C0
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x264F5D0 Offset: 0x264F6D1 VA: 0x264F5D0
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x264F5E0 Offset: 0x264F6E1 VA: 0x264F5E0
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x264F5F0 Offset: 0x264F6F1 VA: 0x264F5F0
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x264F600 Offset: 0x264F701 VA: 0x264F600
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x264F610 Offset: 0x264F711 VA: 0x264F610
	private string CreateString(sbyte* value) { }

	// RVA: 0x264F990 Offset: 0x264FA91 VA: 0x264F990
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x264F9A0 Offset: 0x264FAA1 VA: 0x264F9A0
	private string CreateString(char* value) { }

	// RVA: 0x264F9B0 Offset: 0x264FAB1 VA: 0x264F9B0
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x2645DF0 Offset: 0x2645EF1 VA: 0x2645DF0
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x263AFD0 Offset: 0x263B0D1 VA: 0x263AFD0
	private string CreateString(char[] val) { }

	// RVA: 0x26451F0 Offset: 0x26452F1 VA: 0x26451F0
	private string CreateString(char c, int count) { }

	// RVA: 0x264F6B0 Offset: 0x264F7B1 VA: 0x264F6B0
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }
}

[DefaultMemberAttribute] // RVA: 0xAC760 Offset: 0xAC861 VA: 0xAC760
[ComVisibleAttribute] // RVA: 0xAC760 Offset: 0xAC861 VA: 0xAC760
[Serializable]
public sealed class String : IComparable, ICloneable, IConvertible, IEnumerable, IComparable<string>, IEnumerable<char>, IEquatable<string> // TypeDefIndex: 310
{
	// Fields
	private int m_stringLength; // 0x10
	private char m_firstChar; // 0x14
	private const int TrimHead = 0;
	private const int TrimTail = 1;
	private const int TrimBoth = 2;
	public static readonly string Empty; // 0x0
	private const int charPtrAlignConst = 1;
	private const int alignConst = 3;

	// Properties
	public char Chars { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x2647460 Offset: 0x2647561 VA: 0x2647460
	public static string Join(string separator, string[] value) { }

	[ComVisibleAttribute] // RVA: 0xB6D40 Offset: 0xB6E41 VA: 0xB6D40
	// RVA: 0x26477A0 Offset: 0x26478A1 VA: 0x26477A0
	public static string Join(string separator, object[] values) { }

	// RVA: 0x2647500 Offset: 0x2647601 VA: 0x2647500
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: 0x2647970 Offset: 0x2647A71 VA: 0x2647970
	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D60 Offset: 0xB6E61 VA: 0xB6D60
	// RVA: 0x2647A60 Offset: 0x2647B61 VA: 0x2647A60
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x2647C40 Offset: 0x2647D41 VA: 0x2647C40
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D80 Offset: 0xB6E81 VA: 0xB6D80
	// RVA: 0x2647DE0 Offset: 0x2647EE1 VA: 0x2647DE0 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0xB6DA0 Offset: 0xB6EA1 VA: 0xB6DA0
	// RVA: 0x2642450 Offset: 0x2642551 VA: 0x2642450 Slot: 26
	public bool Equals(string value) { }

	// RVA: 0x2647ED0 Offset: 0x2647FD1 VA: 0x2647ED0
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x2648210 Offset: 0x2648311 VA: 0x2648210
	public static bool Equals(string a, string b) { }

	// RVA: 0x2648250 Offset: 0x2648351 VA: 0x2648250
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x263DC80 Offset: 0x263DD81 VA: 0x263DC80
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x2648540 Offset: 0x2648641 VA: 0x2648540
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x263AF30 Offset: 0x263B031 VA: 0x263AF30
	public char get_Chars(int index) { }

	// RVA: 0x26485A0 Offset: 0x26486A1 VA: 0x26485A0
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x2648790 Offset: 0x2648891 VA: 0x2648790
	public char[] ToCharArray() { }

	// RVA: 0x2648830 Offset: 0x2648931 VA: 0x2648830
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x2648850 Offset: 0x2648951 VA: 0x2648850
	public static bool IsNullOrWhiteSpace(string value) { }

	[ReliabilityContractAttribute] // RVA: 0xB6DC0 Offset: 0xB6EC1 VA: 0xB6DC0
	// RVA: 0x2648980 Offset: 0x2648A81 VA: 0x2648980 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0xB6DE0 Offset: 0xB6EE1 VA: 0xB6DE0
	// RVA: 0x2648A00 Offset: 0x2648B01 VA: 0x2648A00
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x2648A80 Offset: 0x2648B81 VA: 0x2648A80
	public string[] Split(char[] separator) { }

	[ComVisibleAttribute] // RVA: 0xB6E00 Offset: 0xB6F01 VA: 0xB6E00
	// RVA: 0x2648D00 Offset: 0x2648E01 VA: 0x2648D00
	public string[] Split(char[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0xB6E20 Offset: 0xB6F21 VA: 0xB6E20
	// RVA: 0x2648A90 Offset: 0x2648B91 VA: 0x2648A90
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x26492D0 Offset: 0x26493D1 VA: 0x26492D0
	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x2648F00 Offset: 0x2649001 VA: 0x2648F00
	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x2648D10 Offset: 0x2648E11 VA: 0x2648D10
	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	// RVA: 0x2649540 Offset: 0x2649641 VA: 0x2649540
	public string Substring(int startIndex) { }

	// RVA: 0x263DED0 Offset: 0x263DFD1 VA: 0x263DED0
	public string Substring(int startIndex, int length) { }

	// RVA: 0x2649550 Offset: 0x2649651 VA: 0x2649550
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x26495B0 Offset: 0x26496B1 VA: 0x26495B0
	public string Trim(char[] trimChars) { }

	// RVA: 0x2649BB0 Offset: 0x2649CB1 VA: 0x2649BB0
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x2649BD0 Offset: 0x2649CD1 VA: 0x2649BD0
	public string TrimEnd(char[] trimChars) { }

	[CLSCompliantAttribute] // RVA: 0xB6E40 Offset: 0xB6F41 VA: 0xB6E40
	// RVA: 0x2649BF0 Offset: 0x2649CF1 VA: 0x2649BF0
	public void .ctor(char* value) { }

	[CLSCompliantAttribute] // RVA: 0xB6E60 Offset: 0xB6F61 VA: 0xB6E60
	// RVA: 0x2649C00 Offset: 0x2649D01 VA: 0x2649C00
	public void .ctor(char* value, int startIndex, int length) { }

	[CLSCompliantAttribute] // RVA: 0xB6E80 Offset: 0xB6F81 VA: 0xB6E80
	// RVA: 0x2649C10 Offset: 0x2649D11 VA: 0x2649C10
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x2649C20 Offset: 0x2649D21 VA: 0x2649C20
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x2649D00 Offset: 0x2649E01 VA: 0x2649D00
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x2647960 Offset: 0x2647A61 VA: 0x2647960
	internal static string FastAllocateString(int length) { }

	// RVA: 0x2649DE0 Offset: 0x2649EE1 VA: 0x2649DE0
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x2649EA0 Offset: 0x2649FA1 VA: 0x2649EA0
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x2649EB0 Offset: 0x2649FB1 VA: 0x2649EB0
	public void .ctor(char[] value) { }

	// RVA: 0x2648780 Offset: 0x2648881 VA: 0x2648780
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x2649EC0 Offset: 0x2649FC1 VA: 0x2649EC0
	private string CtorCharArray(char[] value) { }

	// RVA: 0x2649F70 Offset: 0x264A071 VA: 0x2649F70
	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	// RVA: 0x264A120 Offset: 0x264A221 VA: 0x264A120
	private static int wcslen(char* ptr) { }

	// RVA: 0x264A1A0 Offset: 0x264A2A1 VA: 0x264A1A0
	private string CtorCharPtr(char* ptr) { }

	// RVA: 0x264A3D0 Offset: 0x264A4D1 VA: 0x264A3D0
	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	// RVA: 0x264A600 Offset: 0x264A701 VA: 0x264A600
	public void .ctor(char c, int count) { }

	// RVA: 0x264A610 Offset: 0x264A711 VA: 0x264A610
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x26443E0 Offset: 0x26444E1 VA: 0x26443E0
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x264A710 Offset: 0x264A811 VA: 0x264A710
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x264A7E0 Offset: 0x264A8E1 VA: 0x264A7E0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x26454B0 Offset: 0x26455B1 VA: 0x26454B0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x264AA80 Offset: 0x264AB81 VA: 0x264AA80 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x264AB60 Offset: 0x264AC61 VA: 0x264AB60 Slot: 24
	public int CompareTo(string strB) { }

	// RVA: 0x264AC20 Offset: 0x264AD21 VA: 0x264AC20
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x264AC70 Offset: 0x264AD71 VA: 0x264AC70
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x264ACA0 Offset: 0x264ADA1 VA: 0x264ACA0
	public bool Contains(string value) { }

	// RVA: 0x264ACE0 Offset: 0x264ADE1 VA: 0x264ACE0
	public bool EndsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0xB6EA0 Offset: 0xB6FA1 VA: 0xB6EA0
	// RVA: 0x2642520 Offset: 0x2642621 VA: 0x2642520
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x264ACF0 Offset: 0x264ADF1 VA: 0x264ACF0
	internal bool EndsWith(char value) { }

	// RVA: 0x264ADB0 Offset: 0x264AEB1 VA: 0x264ADB0
	public int IndexOf(char value) { }

	// RVA: 0x264AF10 Offset: 0x264B011 VA: 0x264AF10
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x2641720 Offset: 0x2641821 VA: 0x2641720
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x264B040 Offset: 0x264B141 VA: 0x264B040
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x263DEB0 Offset: 0x263DFB1 VA: 0x263DEB0
	public int IndexOf(string value) { }

	// RVA: 0x263DEC0 Offset: 0x263DFC1 VA: 0x263DEC0
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x264B060 Offset: 0x264B161 VA: 0x264B060
	public int IndexOf(string value, int startIndex, int count) { }

	// RVA: 0x264ACD0 Offset: 0x264ADD1 VA: 0x264ACD0
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x264B050 Offset: 0x264B151 VA: 0x264B050
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x264B180 Offset: 0x264B281 VA: 0x264B180
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x264B530 Offset: 0x264B631 VA: 0x264B530
	public int LastIndexOf(char value) { }

	// RVA: 0x264B690 Offset: 0x264B791 VA: 0x264B690
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x264B6A0 Offset: 0x264B7A1 VA: 0x264B6A0
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x264B8B0 Offset: 0x264B9B1 VA: 0x264B8B0
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x264B8C0 Offset: 0x264B9C1 VA: 0x264B8C0
	public int LastIndexOf(string value) { }

	// RVA: 0x264BCF0 Offset: 0x264BDF1 VA: 0x264BCF0
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x264B8D0 Offset: 0x264B9D1 VA: 0x264B8D0
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x264BD00 Offset: 0x264BE01 VA: 0x264BD00
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x264BF10 Offset: 0x264C011 VA: 0x264BF10
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x264BF20 Offset: 0x264C021 VA: 0x264BF20
	public bool StartsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0xB6EC0 Offset: 0xB6FC1 VA: 0xB6EC0
	// RVA: 0x264BFC0 Offset: 0x264C0C1 VA: 0x264BFC0
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x264C2A0 Offset: 0x264C3A1 VA: 0x264C2A0
	public string ToLower() { }

	// RVA: 0x264C310 Offset: 0x264C411 VA: 0x264C310
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x264C3C0 Offset: 0x264C4C1 VA: 0x264C3C0
	public string ToLowerInvariant() { }

	// RVA: 0x264C430 Offset: 0x264C531 VA: 0x264C430
	public string ToUpper() { }

	// RVA: 0x264C4A0 Offset: 0x264C5A1 VA: 0x264C4A0
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x264C550 Offset: 0x264C651 VA: 0x264C550
	public string ToUpperInvariant() { }

	// RVA: 0x264C5C0 Offset: 0x264C6C1 VA: 0x264C5C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x264C5D0 Offset: 0x264C6D1 VA: 0x264C5D0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x264C5E0 Offset: 0x264C6E1 VA: 0x264C5E0 Slot: 5
	public object Clone() { }

	// RVA: 0x264C5F0 Offset: 0x264C6F1 VA: 0x264C5F0
	private static bool IsBOMWhitespace(char c) { }

	// RVA: 0x2646760 Offset: 0x2646861 VA: 0x2646760
	public string Trim() { }

	// RVA: 0x26495D0 Offset: 0x26496D1 VA: 0x26495D0
	private string TrimHelper(int trimType) { }

	// RVA: 0x26498A0 Offset: 0x26499A1 VA: 0x26498A0
	private string TrimHelper(char[] trimChars, int trimType) { }

	// RVA: 0x264C600 Offset: 0x264C701 VA: 0x264C600
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x264C6C0 Offset: 0x264C7C1 VA: 0x264C6C0
	public string Insert(int startIndex, string value) { }

	// RVA: 0x264C830 Offset: 0x264C931 VA: 0x264C830
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x264C9D0 Offset: 0x264CAD1 VA: 0x264C9D0
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x264CB80 Offset: 0x264CC81 VA: 0x264CB80
	public string Remove(int startIndex, int count) { }

	// RVA: 0x263DE50 Offset: 0x263DF51 VA: 0x263DE50
	public static string Format(string format, object arg0) { }

	// RVA: 0x2645EF0 Offset: 0x2645FF1 VA: 0x2645EF0
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x264CE00 Offset: 0x264CF01 VA: 0x264CE00
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x264CE60 Offset: 0x264CF61 VA: 0x264CE60
	public static string Format(string format, object[] args) { }

	// RVA: 0x264CF40 Offset: 0x264D041 VA: 0x264CF40
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x264CFA0 Offset: 0x264D0A1 VA: 0x264CFA0
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x264D010 Offset: 0x264D111 VA: 0x264D010
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x264D080 Offset: 0x264D181 VA: 0x264D080
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x264CD00 Offset: 0x264CE01 VA: 0x264CD00
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x264D170 Offset: 0x264D271 VA: 0x264D170
	public static string Copy(string str) { }

	// RVA: 0x264D230 Offset: 0x264D331 VA: 0x264D230
	public static string Concat(object arg0) { }

	// RVA: 0x264D2A0 Offset: 0x264D3A1 VA: 0x264D2A0
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x264D370 Offset: 0x264D471 VA: 0x264D370
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x264D470 Offset: 0x264D571 VA: 0x264D470
	public static string Concat(object[] args) { }

	// RVA: 0x2641160 Offset: 0x2641261 VA: 0x2641160
	public static string Concat(string str0, string str1) { }

	// RVA: 0x26404A0 Offset: 0x26405A1 VA: 0x26404A0
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x264D750 Offset: 0x264D851 VA: 0x264D750
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x264D6A0 Offset: 0x264D7A1 VA: 0x264D6A0
	private static string ConcatArray(string[] values, int totalLength) { }

	// RVA: 0x264D8C0 Offset: 0x264D9C1 VA: 0x264D8C0
	public static string Concat(string[] values) { }

	// RVA: 0x264DA80 Offset: 0x264DB81 VA: 0x264DA80 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x264DA90 Offset: 0x264DB91 VA: 0x264DA90 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x264DB10 Offset: 0x264DC11 VA: 0x264DB10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x264DB90 Offset: 0x264DC91 VA: 0x264DB90 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x264DC10 Offset: 0x264DD11 VA: 0x264DC10 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x264DC90 Offset: 0x264DD91 VA: 0x264DC90 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x264DD10 Offset: 0x264DE11 VA: 0x264DD10 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x264DD90 Offset: 0x264DE91 VA: 0x264DD90 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x264DE10 Offset: 0x264DF11 VA: 0x264DE10 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x264DE90 Offset: 0x264DF91 VA: 0x264DE90 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x264DF10 Offset: 0x264E011 VA: 0x264DF10 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x264DF90 Offset: 0x264E091 VA: 0x264DF90 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x264E010 Offset: 0x264E111 VA: 0x264E010 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x264E090 Offset: 0x264E191 VA: 0x264E090 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x264E110 Offset: 0x264E211 VA: 0x264E110 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x264E190 Offset: 0x264E291 VA: 0x264E190 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x264E210 Offset: 0x264E311 VA: 0x264E210 Slot: 25
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x264E280 Offset: 0x264E381 VA: 0x264E280 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x264E2F0 Offset: 0x264E3F1 VA: 0x264E2F0
	public int get_Length() { }

	// RVA: 0x264E300 Offset: 0x264E401 VA: 0x264E300
	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	// RVA: 0x264ADC0 Offset: 0x264AEC1 VA: 0x264ADC0
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x264E490 Offset: 0x264E591 VA: 0x264E490
	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x264E650 Offset: 0x264E751 VA: 0x264E650
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x264AF20 Offset: 0x264B021 VA: 0x264AF20
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264E7C0 Offset: 0x264E8C1 VA: 0x264E7C0
	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264B540 Offset: 0x264B641 VA: 0x264B540
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x264E8C0 Offset: 0x264E9C1 VA: 0x264E8C0
	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x264B6B0 Offset: 0x264B7B1 VA: 0x264B6B0
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264EA80 Offset: 0x264EB81 VA: 0x264EA80
	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264A910 Offset: 0x264AA11 VA: 0x264A910
	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	// RVA: 0x264C840 Offset: 0x264C941 VA: 0x264C840
	private string ReplaceInternal(char oldChar, char newChar) { }

	// RVA: 0x264CA70 Offset: 0x264CB71 VA: 0x264CA70
	internal string ReplaceInternal(string oldValue, string newValue) { }

	// RVA: 0x264EB80 Offset: 0x264EC81 VA: 0x264EB80
	private string ReplaceUnchecked(string oldValue, string newValue) { }

	// RVA: 0x264F080 Offset: 0x264F181 VA: 0x264F080
	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	// RVA: 0x264BD10 Offset: 0x264BE11 VA: 0x264BD10
	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	// RVA: 0x264F250 Offset: 0x264F351 VA: 0x264F250
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x26481D0 Offset: 0x26482D1 VA: 0x26481D0
	internal bool IsAscii() { }

	// RVA: 0x264EB30 Offset: 0x264EC31 VA: 0x264EB30
	internal static void CharCopy(char* dest, char* src, int count) { }

	// RVA: 0x264F2A0 Offset: 0x264F3A1 VA: 0x264F2A0
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x264F430 Offset: 0x264F531 VA: 0x264F430
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x264F440 Offset: 0x264F541 VA: 0x264F440
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x264F590 Offset: 0x264F691 VA: 0x264F590
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x264F5A0 Offset: 0x264F6A1 VA: 0x264F5A0
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x264F5B0 Offset: 0x264F6B1 VA: 0x264F5B0
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x264F5C0 Offset: 0x264F6C1 VA: 0x264F5C0
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x264F5D0 Offset: 0x264F6D1 VA: 0x264F5D0
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x264F5E0 Offset: 0x264F6E1 VA: 0x264F5E0
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x264F5F0 Offset: 0x264F6F1 VA: 0x264F5F0
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x264F600 Offset: 0x264F701 VA: 0x264F600
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x264F610 Offset: 0x264F711 VA: 0x264F610
	private string CreateString(sbyte* value) { }

	// RVA: 0x264F990 Offset: 0x264FA91 VA: 0x264F990
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x264F9A0 Offset: 0x264FAA1 VA: 0x264F9A0
	private string CreateString(char* value) { }

	// RVA: 0x264F9B0 Offset: 0x264FAB1 VA: 0x264F9B0
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x2645DF0 Offset: 0x2645EF1 VA: 0x2645DF0
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x263AFD0 Offset: 0x263B0D1 VA: 0x263AFD0
	private string CreateString(char[] val) { }

	// RVA: 0x26451F0 Offset: 0x26452F1 VA: 0x26451F0
	private string CreateString(char c, int count) { }

	// RVA: 0x264F6B0 Offset: 0x264F7B1 VA: 0x264F6B0
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }
}

[DefaultMemberAttribute] // RVA: 0xAC760 Offset: 0xAC861 VA: 0xAC760
[ComVisibleAttribute] // RVA: 0xAC760 Offset: 0xAC861 VA: 0xAC760
[Serializable]
public sealed class String : IComparable, ICloneable, IConvertible, IEnumerable, IComparable<string>, IEnumerable<char>, IEquatable<string> // TypeDefIndex: 310
{
	// Fields
	private int m_stringLength; // 0x10
	private char m_firstChar; // 0x14
	private const int TrimHead = 0;
	private const int TrimTail = 1;
	private const int TrimBoth = 2;
	public static readonly string Empty; // 0x0
	private const int charPtrAlignConst = 1;
	private const int alignConst = 3;

	// Properties
	public char Chars { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x2647460 Offset: 0x2647561 VA: 0x2647460
	public static string Join(string separator, string[] value) { }

	[ComVisibleAttribute] // RVA: 0xB6D40 Offset: 0xB6E41 VA: 0xB6D40
	// RVA: 0x26477A0 Offset: 0x26478A1 VA: 0x26477A0
	public static string Join(string separator, object[] values) { }

	// RVA: 0x2647500 Offset: 0x2647601 VA: 0x2647500
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: 0x2647970 Offset: 0x2647A71 VA: 0x2647970
	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D60 Offset: 0xB6E61 VA: 0xB6D60
	// RVA: 0x2647A60 Offset: 0x2647B61 VA: 0x2647A60
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x2647C40 Offset: 0x2647D41 VA: 0x2647C40
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D80 Offset: 0xB6E81 VA: 0xB6D80
	// RVA: 0x2647DE0 Offset: 0x2647EE1 VA: 0x2647DE0 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0xB6DA0 Offset: 0xB6EA1 VA: 0xB6DA0
	// RVA: 0x2642450 Offset: 0x2642551 VA: 0x2642450 Slot: 26
	public bool Equals(string value) { }

	// RVA: 0x2647ED0 Offset: 0x2647FD1 VA: 0x2647ED0
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x2648210 Offset: 0x2648311 VA: 0x2648210
	public static bool Equals(string a, string b) { }

	// RVA: 0x2648250 Offset: 0x2648351 VA: 0x2648250
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x263DC80 Offset: 0x263DD81 VA: 0x263DC80
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x2648540 Offset: 0x2648641 VA: 0x2648540
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x263AF30 Offset: 0x263B031 VA: 0x263AF30
	public char get_Chars(int index) { }

	// RVA: 0x26485A0 Offset: 0x26486A1 VA: 0x26485A0
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x2648790 Offset: 0x2648891 VA: 0x2648790
	public char[] ToCharArray() { }

	// RVA: 0x2648830 Offset: 0x2648931 VA: 0x2648830
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x2648850 Offset: 0x2648951 VA: 0x2648850
	public static bool IsNullOrWhiteSpace(string value) { }

	[ReliabilityContractAttribute] // RVA: 0xB6DC0 Offset: 0xB6EC1 VA: 0xB6DC0
	// RVA: 0x2648980 Offset: 0x2648A81 VA: 0x2648980 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0xB6DE0 Offset: 0xB6EE1 VA: 0xB6DE0
	// RVA: 0x2648A00 Offset: 0x2648B01 VA: 0x2648A00
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x2648A80 Offset: 0x2648B81 VA: 0x2648A80
	public string[] Split(char[] separator) { }

	[ComVisibleAttribute] // RVA: 0xB6E00 Offset: 0xB6F01 VA: 0xB6E00
	// RVA: 0x2648D00 Offset: 0x2648E01 VA: 0x2648D00
	public string[] Split(char[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0xB6E20 Offset: 0xB6F21 VA: 0xB6E20
	// RVA: 0x2648A90 Offset: 0x2648B91 VA: 0x2648A90
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x26492D0 Offset: 0x26493D1 VA: 0x26492D0
	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x2648F00 Offset: 0x2649001 VA: 0x2648F00
	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x2648D10 Offset: 0x2648E11 VA: 0x2648D10
	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	// RVA: 0x2649540 Offset: 0x2649641 VA: 0x2649540
	public string Substring(int startIndex) { }

	// RVA: 0x263DED0 Offset: 0x263DFD1 VA: 0x263DED0
	public string Substring(int startIndex, int length) { }

	// RVA: 0x2649550 Offset: 0x2649651 VA: 0x2649550
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x26495B0 Offset: 0x26496B1 VA: 0x26495B0
	public string Trim(char[] trimChars) { }

	// RVA: 0x2649BB0 Offset: 0x2649CB1 VA: 0x2649BB0
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x2649BD0 Offset: 0x2649CD1 VA: 0x2649BD0
	public string TrimEnd(char[] trimChars) { }

	[CLSCompliantAttribute] // RVA: 0xB6E40 Offset: 0xB6F41 VA: 0xB6E40
	// RVA: 0x2649BF0 Offset: 0x2649CF1 VA: 0x2649BF0
	public void .ctor(char* value) { }

	[CLSCompliantAttribute] // RVA: 0xB6E60 Offset: 0xB6F61 VA: 0xB6E60
	// RVA: 0x2649C00 Offset: 0x2649D01 VA: 0x2649C00
	public void .ctor(char* value, int startIndex, int length) { }

	[CLSCompliantAttribute] // RVA: 0xB6E80 Offset: 0xB6F81 VA: 0xB6E80
	// RVA: 0x2649C10 Offset: 0x2649D11 VA: 0x2649C10
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x2649C20 Offset: 0x2649D21 VA: 0x2649C20
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x2649D00 Offset: 0x2649E01 VA: 0x2649D00
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x2647960 Offset: 0x2647A61 VA: 0x2647960
	internal static string FastAllocateString(int length) { }

	// RVA: 0x2649DE0 Offset: 0x2649EE1 VA: 0x2649DE0
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x2649EA0 Offset: 0x2649FA1 VA: 0x2649EA0
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x2649EB0 Offset: 0x2649FB1 VA: 0x2649EB0
	public void .ctor(char[] value) { }

	// RVA: 0x2648780 Offset: 0x2648881 VA: 0x2648780
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x2649EC0 Offset: 0x2649FC1 VA: 0x2649EC0
	private string CtorCharArray(char[] value) { }

	// RVA: 0x2649F70 Offset: 0x264A071 VA: 0x2649F70
	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	// RVA: 0x264A120 Offset: 0x264A221 VA: 0x264A120
	private static int wcslen(char* ptr) { }

	// RVA: 0x264A1A0 Offset: 0x264A2A1 VA: 0x264A1A0
	private string CtorCharPtr(char* ptr) { }

	// RVA: 0x264A3D0 Offset: 0x264A4D1 VA: 0x264A3D0
	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	// RVA: 0x264A600 Offset: 0x264A701 VA: 0x264A600
	public void .ctor(char c, int count) { }

	// RVA: 0x264A610 Offset: 0x264A711 VA: 0x264A610
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x26443E0 Offset: 0x26444E1 VA: 0x26443E0
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x264A710 Offset: 0x264A811 VA: 0x264A710
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x264A7E0 Offset: 0x264A8E1 VA: 0x264A7E0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x26454B0 Offset: 0x26455B1 VA: 0x26454B0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x264AA80 Offset: 0x264AB81 VA: 0x264AA80 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x264AB60 Offset: 0x264AC61 VA: 0x264AB60 Slot: 24
	public int CompareTo(string strB) { }

	// RVA: 0x264AC20 Offset: 0x264AD21 VA: 0x264AC20
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x264AC70 Offset: 0x264AD71 VA: 0x264AC70
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x264ACA0 Offset: 0x264ADA1 VA: 0x264ACA0
	public bool Contains(string value) { }

	// RVA: 0x264ACE0 Offset: 0x264ADE1 VA: 0x264ACE0
	public bool EndsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0xB6EA0 Offset: 0xB6FA1 VA: 0xB6EA0
	// RVA: 0x2642520 Offset: 0x2642621 VA: 0x2642520
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x264ACF0 Offset: 0x264ADF1 VA: 0x264ACF0
	internal bool EndsWith(char value) { }

	// RVA: 0x264ADB0 Offset: 0x264AEB1 VA: 0x264ADB0
	public int IndexOf(char value) { }

	// RVA: 0x264AF10 Offset: 0x264B011 VA: 0x264AF10
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x2641720 Offset: 0x2641821 VA: 0x2641720
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x264B040 Offset: 0x264B141 VA: 0x264B040
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x263DEB0 Offset: 0x263DFB1 VA: 0x263DEB0
	public int IndexOf(string value) { }

	// RVA: 0x263DEC0 Offset: 0x263DFC1 VA: 0x263DEC0
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x264B060 Offset: 0x264B161 VA: 0x264B060
	public int IndexOf(string value, int startIndex, int count) { }

	// RVA: 0x264ACD0 Offset: 0x264ADD1 VA: 0x264ACD0
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x264B050 Offset: 0x264B151 VA: 0x264B050
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x264B180 Offset: 0x264B281 VA: 0x264B180
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x264B530 Offset: 0x264B631 VA: 0x264B530
	public int LastIndexOf(char value) { }

	// RVA: 0x264B690 Offset: 0x264B791 VA: 0x264B690
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x264B6A0 Offset: 0x264B7A1 VA: 0x264B6A0
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x264B8B0 Offset: 0x264B9B1 VA: 0x264B8B0
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x264B8C0 Offset: 0x264B9C1 VA: 0x264B8C0
	public int LastIndexOf(string value) { }

	// RVA: 0x264BCF0 Offset: 0x264BDF1 VA: 0x264BCF0
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x264B8D0 Offset: 0x264B9D1 VA: 0x264B8D0
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x264BD00 Offset: 0x264BE01 VA: 0x264BD00
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x264BF10 Offset: 0x264C011 VA: 0x264BF10
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x264BF20 Offset: 0x264C021 VA: 0x264BF20
	public bool StartsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0xB6EC0 Offset: 0xB6FC1 VA: 0xB6EC0
	// RVA: 0x264BFC0 Offset: 0x264C0C1 VA: 0x264BFC0
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x264C2A0 Offset: 0x264C3A1 VA: 0x264C2A0
	public string ToLower() { }

	// RVA: 0x264C310 Offset: 0x264C411 VA: 0x264C310
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x264C3C0 Offset: 0x264C4C1 VA: 0x264C3C0
	public string ToLowerInvariant() { }

	// RVA: 0x264C430 Offset: 0x264C531 VA: 0x264C430
	public string ToUpper() { }

	// RVA: 0x264C4A0 Offset: 0x264C5A1 VA: 0x264C4A0
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x264C550 Offset: 0x264C651 VA: 0x264C550
	public string ToUpperInvariant() { }

	// RVA: 0x264C5C0 Offset: 0x264C6C1 VA: 0x264C5C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x264C5D0 Offset: 0x264C6D1 VA: 0x264C5D0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x264C5E0 Offset: 0x264C6E1 VA: 0x264C5E0 Slot: 5
	public object Clone() { }

	// RVA: 0x264C5F0 Offset: 0x264C6F1 VA: 0x264C5F0
	private static bool IsBOMWhitespace(char c) { }

	// RVA: 0x2646760 Offset: 0x2646861 VA: 0x2646760
	public string Trim() { }

	// RVA: 0x26495D0 Offset: 0x26496D1 VA: 0x26495D0
	private string TrimHelper(int trimType) { }

	// RVA: 0x26498A0 Offset: 0x26499A1 VA: 0x26498A0
	private string TrimHelper(char[] trimChars, int trimType) { }

	// RVA: 0x264C600 Offset: 0x264C701 VA: 0x264C600
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x264C6C0 Offset: 0x264C7C1 VA: 0x264C6C0
	public string Insert(int startIndex, string value) { }

	// RVA: 0x264C830 Offset: 0x264C931 VA: 0x264C830
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x264C9D0 Offset: 0x264CAD1 VA: 0x264C9D0
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x264CB80 Offset: 0x264CC81 VA: 0x264CB80
	public string Remove(int startIndex, int count) { }

	// RVA: 0x263DE50 Offset: 0x263DF51 VA: 0x263DE50
	public static string Format(string format, object arg0) { }

	// RVA: 0x2645EF0 Offset: 0x2645FF1 VA: 0x2645EF0
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x264CE00 Offset: 0x264CF01 VA: 0x264CE00
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x264CE60 Offset: 0x264CF61 VA: 0x264CE60
	public static string Format(string format, object[] args) { }

	// RVA: 0x264CF40 Offset: 0x264D041 VA: 0x264CF40
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x264CFA0 Offset: 0x264D0A1 VA: 0x264CFA0
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x264D010 Offset: 0x264D111 VA: 0x264D010
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x264D080 Offset: 0x264D181 VA: 0x264D080
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x264CD00 Offset: 0x264CE01 VA: 0x264CD00
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x264D170 Offset: 0x264D271 VA: 0x264D170
	public static string Copy(string str) { }

	// RVA: 0x264D230 Offset: 0x264D331 VA: 0x264D230
	public static string Concat(object arg0) { }

	// RVA: 0x264D2A0 Offset: 0x264D3A1 VA: 0x264D2A0
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x264D370 Offset: 0x264D471 VA: 0x264D370
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x264D470 Offset: 0x264D571 VA: 0x264D470
	public static string Concat(object[] args) { }

	// RVA: 0x2641160 Offset: 0x2641261 VA: 0x2641160
	public static string Concat(string str0, string str1) { }

	// RVA: 0x26404A0 Offset: 0x26405A1 VA: 0x26404A0
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x264D750 Offset: 0x264D851 VA: 0x264D750
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x264D6A0 Offset: 0x264D7A1 VA: 0x264D6A0
	private static string ConcatArray(string[] values, int totalLength) { }

	// RVA: 0x264D8C0 Offset: 0x264D9C1 VA: 0x264D8C0
	public static string Concat(string[] values) { }

	// RVA: 0x264DA80 Offset: 0x264DB81 VA: 0x264DA80 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x264DA90 Offset: 0x264DB91 VA: 0x264DA90 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x264DB10 Offset: 0x264DC11 VA: 0x264DB10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x264DB90 Offset: 0x264DC91 VA: 0x264DB90 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x264DC10 Offset: 0x264DD11 VA: 0x264DC10 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x264DC90 Offset: 0x264DD91 VA: 0x264DC90 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x264DD10 Offset: 0x264DE11 VA: 0x264DD10 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x264DD90 Offset: 0x264DE91 VA: 0x264DD90 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x264DE10 Offset: 0x264DF11 VA: 0x264DE10 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x264DE90 Offset: 0x264DF91 VA: 0x264DE90 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x264DF10 Offset: 0x264E011 VA: 0x264DF10 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x264DF90 Offset: 0x264E091 VA: 0x264DF90 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x264E010 Offset: 0x264E111 VA: 0x264E010 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x264E090 Offset: 0x264E191 VA: 0x264E090 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x264E110 Offset: 0x264E211 VA: 0x264E110 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x264E190 Offset: 0x264E291 VA: 0x264E190 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x264E210 Offset: 0x264E311 VA: 0x264E210 Slot: 25
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x264E280 Offset: 0x264E381 VA: 0x264E280 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x264E2F0 Offset: 0x264E3F1 VA: 0x264E2F0
	public int get_Length() { }

	// RVA: 0x264E300 Offset: 0x264E401 VA: 0x264E300
	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	// RVA: 0x264ADC0 Offset: 0x264AEC1 VA: 0x264ADC0
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x264E490 Offset: 0x264E591 VA: 0x264E490
	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x264E650 Offset: 0x264E751 VA: 0x264E650
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x264AF20 Offset: 0x264B021 VA: 0x264AF20
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264E7C0 Offset: 0x264E8C1 VA: 0x264E7C0
	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264B540 Offset: 0x264B641 VA: 0x264B540
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x264E8C0 Offset: 0x264E9C1 VA: 0x264E8C0
	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x264B6B0 Offset: 0x264B7B1 VA: 0x264B6B0
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264EA80 Offset: 0x264EB81 VA: 0x264EA80
	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264A910 Offset: 0x264AA11 VA: 0x264A910
	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	// RVA: 0x264C840 Offset: 0x264C941 VA: 0x264C840
	private string ReplaceInternal(char oldChar, char newChar) { }

	// RVA: 0x264CA70 Offset: 0x264CB71 VA: 0x264CA70
	internal string ReplaceInternal(string oldValue, string newValue) { }

	// RVA: 0x264EB80 Offset: 0x264EC81 VA: 0x264EB80
	private string ReplaceUnchecked(string oldValue, string newValue) { }

	// RVA: 0x264F080 Offset: 0x264F181 VA: 0x264F080
	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	// RVA: 0x264BD10 Offset: 0x264BE11 VA: 0x264BD10
	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	// RVA: 0x264F250 Offset: 0x264F351 VA: 0x264F250
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x26481D0 Offset: 0x26482D1 VA: 0x26481D0
	internal bool IsAscii() { }

	// RVA: 0x264EB30 Offset: 0x264EC31 VA: 0x264EB30
	internal static void CharCopy(char* dest, char* src, int count) { }

	// RVA: 0x264F2A0 Offset: 0x264F3A1 VA: 0x264F2A0
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x264F430 Offset: 0x264F531 VA: 0x264F430
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x264F440 Offset: 0x264F541 VA: 0x264F440
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x264F590 Offset: 0x264F691 VA: 0x264F590
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x264F5A0 Offset: 0x264F6A1 VA: 0x264F5A0
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x264F5B0 Offset: 0x264F6B1 VA: 0x264F5B0
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x264F5C0 Offset: 0x264F6C1 VA: 0x264F5C0
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x264F5D0 Offset: 0x264F6D1 VA: 0x264F5D0
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x264F5E0 Offset: 0x264F6E1 VA: 0x264F5E0
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x264F5F0 Offset: 0x264F6F1 VA: 0x264F5F0
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x264F600 Offset: 0x264F701 VA: 0x264F600
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x264F610 Offset: 0x264F711 VA: 0x264F610
	private string CreateString(sbyte* value) { }

	// RVA: 0x264F990 Offset: 0x264FA91 VA: 0x264F990
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x264F9A0 Offset: 0x264FAA1 VA: 0x264F9A0
	private string CreateString(char* value) { }

	// RVA: 0x264F9B0 Offset: 0x264FAB1 VA: 0x264F9B0
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x2645DF0 Offset: 0x2645EF1 VA: 0x2645DF0
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x263AFD0 Offset: 0x263B0D1 VA: 0x263AFD0
	private string CreateString(char[] val) { }

	// RVA: 0x26451F0 Offset: 0x26452F1 VA: 0x26451F0
	private string CreateString(char c, int count) { }

	// RVA: 0x264F6B0 Offset: 0x264F7B1 VA: 0x264F6B0
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }
}

[DefaultMemberAttribute] // RVA: 0xAC760 Offset: 0xAC861 VA: 0xAC760
[ComVisibleAttribute] // RVA: 0xAC760 Offset: 0xAC861 VA: 0xAC760
[Serializable]
public sealed class String : IComparable, ICloneable, IConvertible, IEnumerable, IComparable<string>, IEnumerable<char>, IEquatable<string> // TypeDefIndex: 310
{
	// Fields
	private int m_stringLength; // 0x10
	private char m_firstChar; // 0x14
	private const int TrimHead = 0;
	private const int TrimTail = 1;
	private const int TrimBoth = 2;
	public static readonly string Empty; // 0x0
	private const int charPtrAlignConst = 1;
	private const int alignConst = 3;

	// Properties
	public char Chars { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x2647460 Offset: 0x2647561 VA: 0x2647460
	public static string Join(string separator, string[] value) { }

	[ComVisibleAttribute] // RVA: 0xB6D40 Offset: 0xB6E41 VA: 0xB6D40
	// RVA: 0x26477A0 Offset: 0x26478A1 VA: 0x26477A0
	public static string Join(string separator, object[] values) { }

	// RVA: 0x2647500 Offset: 0x2647601 VA: 0x2647500
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: 0x2647970 Offset: 0x2647A71 VA: 0x2647970
	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D60 Offset: 0xB6E61 VA: 0xB6D60
	// RVA: 0x2647A60 Offset: 0x2647B61 VA: 0x2647A60
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x2647C40 Offset: 0x2647D41 VA: 0x2647C40
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D80 Offset: 0xB6E81 VA: 0xB6D80
	// RVA: 0x2647DE0 Offset: 0x2647EE1 VA: 0x2647DE0 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0xB6DA0 Offset: 0xB6EA1 VA: 0xB6DA0
	// RVA: 0x2642450 Offset: 0x2642551 VA: 0x2642450 Slot: 26
	public bool Equals(string value) { }

	// RVA: 0x2647ED0 Offset: 0x2647FD1 VA: 0x2647ED0
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x2648210 Offset: 0x2648311 VA: 0x2648210
	public static bool Equals(string a, string b) { }

	// RVA: 0x2648250 Offset: 0x2648351 VA: 0x2648250
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x263DC80 Offset: 0x263DD81 VA: 0x263DC80
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x2648540 Offset: 0x2648641 VA: 0x2648540
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x263AF30 Offset: 0x263B031 VA: 0x263AF30
	public char get_Chars(int index) { }

	// RVA: 0x26485A0 Offset: 0x26486A1 VA: 0x26485A0
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x2648790 Offset: 0x2648891 VA: 0x2648790
	public char[] ToCharArray() { }

	// RVA: 0x2648830 Offset: 0x2648931 VA: 0x2648830
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x2648850 Offset: 0x2648951 VA: 0x2648850
	public static bool IsNullOrWhiteSpace(string value) { }

	[ReliabilityContractAttribute] // RVA: 0xB6DC0 Offset: 0xB6EC1 VA: 0xB6DC0
	// RVA: 0x2648980 Offset: 0x2648A81 VA: 0x2648980 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0xB6DE0 Offset: 0xB6EE1 VA: 0xB6DE0
	// RVA: 0x2648A00 Offset: 0x2648B01 VA: 0x2648A00
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x2648A80 Offset: 0x2648B81 VA: 0x2648A80
	public string[] Split(char[] separator) { }

	[ComVisibleAttribute] // RVA: 0xB6E00 Offset: 0xB6F01 VA: 0xB6E00
	// RVA: 0x2648D00 Offset: 0x2648E01 VA: 0x2648D00
	public string[] Split(char[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0xB6E20 Offset: 0xB6F21 VA: 0xB6E20
	// RVA: 0x2648A90 Offset: 0x2648B91 VA: 0x2648A90
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x26492D0 Offset: 0x26493D1 VA: 0x26492D0
	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x2648F00 Offset: 0x2649001 VA: 0x2648F00
	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x2648D10 Offset: 0x2648E11 VA: 0x2648D10
	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	// RVA: 0x2649540 Offset: 0x2649641 VA: 0x2649540
	public string Substring(int startIndex) { }

	// RVA: 0x263DED0 Offset: 0x263DFD1 VA: 0x263DED0
	public string Substring(int startIndex, int length) { }

	// RVA: 0x2649550 Offset: 0x2649651 VA: 0x2649550
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x26495B0 Offset: 0x26496B1 VA: 0x26495B0
	public string Trim(char[] trimChars) { }

	// RVA: 0x2649BB0 Offset: 0x2649CB1 VA: 0x2649BB0
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x2649BD0 Offset: 0x2649CD1 VA: 0x2649BD0
	public string TrimEnd(char[] trimChars) { }

	[CLSCompliantAttribute] // RVA: 0xB6E40 Offset: 0xB6F41 VA: 0xB6E40
	// RVA: 0x2649BF0 Offset: 0x2649CF1 VA: 0x2649BF0
	public void .ctor(char* value) { }

	[CLSCompliantAttribute] // RVA: 0xB6E60 Offset: 0xB6F61 VA: 0xB6E60
	// RVA: 0x2649C00 Offset: 0x2649D01 VA: 0x2649C00
	public void .ctor(char* value, int startIndex, int length) { }

	[CLSCompliantAttribute] // RVA: 0xB6E80 Offset: 0xB6F81 VA: 0xB6E80
	// RVA: 0x2649C10 Offset: 0x2649D11 VA: 0x2649C10
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x2649C20 Offset: 0x2649D21 VA: 0x2649C20
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x2649D00 Offset: 0x2649E01 VA: 0x2649D00
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x2647960 Offset: 0x2647A61 VA: 0x2647960
	internal static string FastAllocateString(int length) { }

	// RVA: 0x2649DE0 Offset: 0x2649EE1 VA: 0x2649DE0
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x2649EA0 Offset: 0x2649FA1 VA: 0x2649EA0
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x2649EB0 Offset: 0x2649FB1 VA: 0x2649EB0
	public void .ctor(char[] value) { }

	// RVA: 0x2648780 Offset: 0x2648881 VA: 0x2648780
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x2649EC0 Offset: 0x2649FC1 VA: 0x2649EC0
	private string CtorCharArray(char[] value) { }

	// RVA: 0x2649F70 Offset: 0x264A071 VA: 0x2649F70
	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	// RVA: 0x264A120 Offset: 0x264A221 VA: 0x264A120
	private static int wcslen(char* ptr) { }

	// RVA: 0x264A1A0 Offset: 0x264A2A1 VA: 0x264A1A0
	private string CtorCharPtr(char* ptr) { }

	// RVA: 0x264A3D0 Offset: 0x264A4D1 VA: 0x264A3D0
	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	// RVA: 0x264A600 Offset: 0x264A701 VA: 0x264A600
	public void .ctor(char c, int count) { }

	// RVA: 0x264A610 Offset: 0x264A711 VA: 0x264A610
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x26443E0 Offset: 0x26444E1 VA: 0x26443E0
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x264A710 Offset: 0x264A811 VA: 0x264A710
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x264A7E0 Offset: 0x264A8E1 VA: 0x264A7E0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x26454B0 Offset: 0x26455B1 VA: 0x26454B0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x264AA80 Offset: 0x264AB81 VA: 0x264AA80 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x264AB60 Offset: 0x264AC61 VA: 0x264AB60 Slot: 24
	public int CompareTo(string strB) { }

	// RVA: 0x264AC20 Offset: 0x264AD21 VA: 0x264AC20
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x264AC70 Offset: 0x264AD71 VA: 0x264AC70
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x264ACA0 Offset: 0x264ADA1 VA: 0x264ACA0
	public bool Contains(string value) { }

	// RVA: 0x264ACE0 Offset: 0x264ADE1 VA: 0x264ACE0
	public bool EndsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0xB6EA0 Offset: 0xB6FA1 VA: 0xB6EA0
	// RVA: 0x2642520 Offset: 0x2642621 VA: 0x2642520
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x264ACF0 Offset: 0x264ADF1 VA: 0x264ACF0
	internal bool EndsWith(char value) { }

	// RVA: 0x264ADB0 Offset: 0x264AEB1 VA: 0x264ADB0
	public int IndexOf(char value) { }

	// RVA: 0x264AF10 Offset: 0x264B011 VA: 0x264AF10
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x2641720 Offset: 0x2641821 VA: 0x2641720
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x264B040 Offset: 0x264B141 VA: 0x264B040
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x263DEB0 Offset: 0x263DFB1 VA: 0x263DEB0
	public int IndexOf(string value) { }

	// RVA: 0x263DEC0 Offset: 0x263DFC1 VA: 0x263DEC0
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x264B060 Offset: 0x264B161 VA: 0x264B060
	public int IndexOf(string value, int startIndex, int count) { }

	// RVA: 0x264ACD0 Offset: 0x264ADD1 VA: 0x264ACD0
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x264B050 Offset: 0x264B151 VA: 0x264B050
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x264B180 Offset: 0x264B281 VA: 0x264B180
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x264B530 Offset: 0x264B631 VA: 0x264B530
	public int LastIndexOf(char value) { }

	// RVA: 0x264B690 Offset: 0x264B791 VA: 0x264B690
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x264B6A0 Offset: 0x264B7A1 VA: 0x264B6A0
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x264B8B0 Offset: 0x264B9B1 VA: 0x264B8B0
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x264B8C0 Offset: 0x264B9C1 VA: 0x264B8C0
	public int LastIndexOf(string value) { }

	// RVA: 0x264BCF0 Offset: 0x264BDF1 VA: 0x264BCF0
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x264B8D0 Offset: 0x264B9D1 VA: 0x264B8D0
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x264BD00 Offset: 0x264BE01 VA: 0x264BD00
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x264BF10 Offset: 0x264C011 VA: 0x264BF10
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x264BF20 Offset: 0x264C021 VA: 0x264BF20
	public bool StartsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0xB6EC0 Offset: 0xB6FC1 VA: 0xB6EC0
	// RVA: 0x264BFC0 Offset: 0x264C0C1 VA: 0x264BFC0
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x264C2A0 Offset: 0x264C3A1 VA: 0x264C2A0
	public string ToLower() { }

	// RVA: 0x264C310 Offset: 0x264C411 VA: 0x264C310
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x264C3C0 Offset: 0x264C4C1 VA: 0x264C3C0
	public string ToLowerInvariant() { }

	// RVA: 0x264C430 Offset: 0x264C531 VA: 0x264C430
	public string ToUpper() { }

	// RVA: 0x264C4A0 Offset: 0x264C5A1 VA: 0x264C4A0
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x264C550 Offset: 0x264C651 VA: 0x264C550
	public string ToUpperInvariant() { }

	// RVA: 0x264C5C0 Offset: 0x264C6C1 VA: 0x264C5C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x264C5D0 Offset: 0x264C6D1 VA: 0x264C5D0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x264C5E0 Offset: 0x264C6E1 VA: 0x264C5E0 Slot: 5
	public object Clone() { }

	// RVA: 0x264C5F0 Offset: 0x264C6F1 VA: 0x264C5F0
	private static bool IsBOMWhitespace(char c) { }

	// RVA: 0x2646760 Offset: 0x2646861 VA: 0x2646760
	public string Trim() { }

	// RVA: 0x26495D0 Offset: 0x26496D1 VA: 0x26495D0
	private string TrimHelper(int trimType) { }

	// RVA: 0x26498A0 Offset: 0x26499A1 VA: 0x26498A0
	private string TrimHelper(char[] trimChars, int trimType) { }

	// RVA: 0x264C600 Offset: 0x264C701 VA: 0x264C600
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x264C6C0 Offset: 0x264C7C1 VA: 0x264C6C0
	public string Insert(int startIndex, string value) { }

	// RVA: 0x264C830 Offset: 0x264C931 VA: 0x264C830
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x264C9D0 Offset: 0x264CAD1 VA: 0x264C9D0
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x264CB80 Offset: 0x264CC81 VA: 0x264CB80
	public string Remove(int startIndex, int count) { }

	// RVA: 0x263DE50 Offset: 0x263DF51 VA: 0x263DE50
	public static string Format(string format, object arg0) { }

	// RVA: 0x2645EF0 Offset: 0x2645FF1 VA: 0x2645EF0
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x264CE00 Offset: 0x264CF01 VA: 0x264CE00
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x264CE60 Offset: 0x264CF61 VA: 0x264CE60
	public static string Format(string format, object[] args) { }

	// RVA: 0x264CF40 Offset: 0x264D041 VA: 0x264CF40
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x264CFA0 Offset: 0x264D0A1 VA: 0x264CFA0
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x264D010 Offset: 0x264D111 VA: 0x264D010
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x264D080 Offset: 0x264D181 VA: 0x264D080
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x264CD00 Offset: 0x264CE01 VA: 0x264CD00
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x264D170 Offset: 0x264D271 VA: 0x264D170
	public static string Copy(string str) { }

	// RVA: 0x264D230 Offset: 0x264D331 VA: 0x264D230
	public static string Concat(object arg0) { }

	// RVA: 0x264D2A0 Offset: 0x264D3A1 VA: 0x264D2A0
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x264D370 Offset: 0x264D471 VA: 0x264D370
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x264D470 Offset: 0x264D571 VA: 0x264D470
	public static string Concat(object[] args) { }

	// RVA: 0x2641160 Offset: 0x2641261 VA: 0x2641160
	public static string Concat(string str0, string str1) { }

	// RVA: 0x26404A0 Offset: 0x26405A1 VA: 0x26404A0
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x264D750 Offset: 0x264D851 VA: 0x264D750
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x264D6A0 Offset: 0x264D7A1 VA: 0x264D6A0
	private static string ConcatArray(string[] values, int totalLength) { }

	// RVA: 0x264D8C0 Offset: 0x264D9C1 VA: 0x264D8C0
	public static string Concat(string[] values) { }

	// RVA: 0x264DA80 Offset: 0x264DB81 VA: 0x264DA80 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x264DA90 Offset: 0x264DB91 VA: 0x264DA90 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x264DB10 Offset: 0x264DC11 VA: 0x264DB10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x264DB90 Offset: 0x264DC91 VA: 0x264DB90 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x264DC10 Offset: 0x264DD11 VA: 0x264DC10 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x264DC90 Offset: 0x264DD91 VA: 0x264DC90 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x264DD10 Offset: 0x264DE11 VA: 0x264DD10 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x264DD90 Offset: 0x264DE91 VA: 0x264DD90 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x264DE10 Offset: 0x264DF11 VA: 0x264DE10 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x264DE90 Offset: 0x264DF91 VA: 0x264DE90 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x264DF10 Offset: 0x264E011 VA: 0x264DF10 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x264DF90 Offset: 0x264E091 VA: 0x264DF90 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x264E010 Offset: 0x264E111 VA: 0x264E010 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x264E090 Offset: 0x264E191 VA: 0x264E090 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x264E110 Offset: 0x264E211 VA: 0x264E110 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x264E190 Offset: 0x264E291 VA: 0x264E190 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x264E210 Offset: 0x264E311 VA: 0x264E210 Slot: 25
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x264E280 Offset: 0x264E381 VA: 0x264E280 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x264E2F0 Offset: 0x264E3F1 VA: 0x264E2F0
	public int get_Length() { }

	// RVA: 0x264E300 Offset: 0x264E401 VA: 0x264E300
	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	// RVA: 0x264ADC0 Offset: 0x264AEC1 VA: 0x264ADC0
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x264E490 Offset: 0x264E591 VA: 0x264E490
	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x264E650 Offset: 0x264E751 VA: 0x264E650
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x264AF20 Offset: 0x264B021 VA: 0x264AF20
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264E7C0 Offset: 0x264E8C1 VA: 0x264E7C0
	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264B540 Offset: 0x264B641 VA: 0x264B540
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x264E8C0 Offset: 0x264E9C1 VA: 0x264E8C0
	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x264B6B0 Offset: 0x264B7B1 VA: 0x264B6B0
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264EA80 Offset: 0x264EB81 VA: 0x264EA80
	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264A910 Offset: 0x264AA11 VA: 0x264A910
	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	// RVA: 0x264C840 Offset: 0x264C941 VA: 0x264C840
	private string ReplaceInternal(char oldChar, char newChar) { }

	// RVA: 0x264CA70 Offset: 0x264CB71 VA: 0x264CA70
	internal string ReplaceInternal(string oldValue, string newValue) { }

	// RVA: 0x264EB80 Offset: 0x264EC81 VA: 0x264EB80
	private string ReplaceUnchecked(string oldValue, string newValue) { }

	// RVA: 0x264F080 Offset: 0x264F181 VA: 0x264F080
	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	// RVA: 0x264BD10 Offset: 0x264BE11 VA: 0x264BD10
	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	// RVA: 0x264F250 Offset: 0x264F351 VA: 0x264F250
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x26481D0 Offset: 0x26482D1 VA: 0x26481D0
	internal bool IsAscii() { }

	// RVA: 0x264EB30 Offset: 0x264EC31 VA: 0x264EB30
	internal static void CharCopy(char* dest, char* src, int count) { }

	// RVA: 0x264F2A0 Offset: 0x264F3A1 VA: 0x264F2A0
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x264F430 Offset: 0x264F531 VA: 0x264F430
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x264F440 Offset: 0x264F541 VA: 0x264F440
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x264F590 Offset: 0x264F691 VA: 0x264F590
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x264F5A0 Offset: 0x264F6A1 VA: 0x264F5A0
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x264F5B0 Offset: 0x264F6B1 VA: 0x264F5B0
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x264F5C0 Offset: 0x264F6C1 VA: 0x264F5C0
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x264F5D0 Offset: 0x264F6D1 VA: 0x264F5D0
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x264F5E0 Offset: 0x264F6E1 VA: 0x264F5E0
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x264F5F0 Offset: 0x264F6F1 VA: 0x264F5F0
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x264F600 Offset: 0x264F701 VA: 0x264F600
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x264F610 Offset: 0x264F711 VA: 0x264F610
	private string CreateString(sbyte* value) { }

	// RVA: 0x264F990 Offset: 0x264FA91 VA: 0x264F990
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x264F9A0 Offset: 0x264FAA1 VA: 0x264F9A0
	private string CreateString(char* value) { }

	// RVA: 0x264F9B0 Offset: 0x264FAB1 VA: 0x264F9B0
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x2645DF0 Offset: 0x2645EF1 VA: 0x2645DF0
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x263AFD0 Offset: 0x263B0D1 VA: 0x263AFD0
	private string CreateString(char[] val) { }

	// RVA: 0x26451F0 Offset: 0x26452F1 VA: 0x26451F0
	private string CreateString(char c, int count) { }

	// RVA: 0x264F6B0 Offset: 0x264F7B1 VA: 0x264F6B0
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }
}

[DefaultMemberAttribute] // RVA: 0xAC760 Offset: 0xAC861 VA: 0xAC760
[ComVisibleAttribute] // RVA: 0xAC760 Offset: 0xAC861 VA: 0xAC760
[Serializable]
public sealed class String : IComparable, ICloneable, IConvertible, IEnumerable, IComparable<string>, IEnumerable<char>, IEquatable<string> // TypeDefIndex: 310
{
	// Fields
	private int m_stringLength; // 0x10
	private char m_firstChar; // 0x14
	private const int TrimHead = 0;
	private const int TrimTail = 1;
	private const int TrimBoth = 2;
	public static readonly string Empty; // 0x0
	private const int charPtrAlignConst = 1;
	private const int alignConst = 3;

	// Properties
	public char Chars { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x2647460 Offset: 0x2647561 VA: 0x2647460
	public static string Join(string separator, string[] value) { }

	[ComVisibleAttribute] // RVA: 0xB6D40 Offset: 0xB6E41 VA: 0xB6D40
	// RVA: 0x26477A0 Offset: 0x26478A1 VA: 0x26477A0
	public static string Join(string separator, object[] values) { }

	// RVA: 0x2647500 Offset: 0x2647601 VA: 0x2647500
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: 0x2647970 Offset: 0x2647A71 VA: 0x2647970
	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D60 Offset: 0xB6E61 VA: 0xB6D60
	// RVA: 0x2647A60 Offset: 0x2647B61 VA: 0x2647A60
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x2647C40 Offset: 0x2647D41 VA: 0x2647C40
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0xB6D80 Offset: 0xB6E81 VA: 0xB6D80
	// RVA: 0x2647DE0 Offset: 0x2647EE1 VA: 0x2647DE0 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0xB6DA0 Offset: 0xB6EA1 VA: 0xB6DA0
	// RVA: 0x2642450 Offset: 0x2642551 VA: 0x2642450 Slot: 26
	public bool Equals(string value) { }

	// RVA: 0x2647ED0 Offset: 0x2647FD1 VA: 0x2647ED0
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x2648210 Offset: 0x2648311 VA: 0x2648210
	public static bool Equals(string a, string b) { }

	// RVA: 0x2648250 Offset: 0x2648351 VA: 0x2648250
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x263DC80 Offset: 0x263DD81 VA: 0x263DC80
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x2648540 Offset: 0x2648641 VA: 0x2648540
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x263AF30 Offset: 0x263B031 VA: 0x263AF30
	public char get_Chars(int index) { }

	// RVA: 0x26485A0 Offset: 0x26486A1 VA: 0x26485A0
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x2648790 Offset: 0x2648891 VA: 0x2648790
	public char[] ToCharArray() { }

	// RVA: 0x2648830 Offset: 0x2648931 VA: 0x2648830
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x2648850 Offset: 0x2648951 VA: 0x2648850
	public static bool IsNullOrWhiteSpace(string value) { }

	[ReliabilityContractAttribute] // RVA: 0xB6DC0 Offset: 0xB6EC1 VA: 0xB6DC0
	// RVA: 0x2648980 Offset: 0x2648A81 VA: 0x2648980 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0xB6DE0 Offset: 0xB6EE1 VA: 0xB6DE0
	// RVA: 0x2648A00 Offset: 0x2648B01 VA: 0x2648A00
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x2648A80 Offset: 0x2648B81 VA: 0x2648A80
	public string[] Split(char[] separator) { }

	[ComVisibleAttribute] // RVA: 0xB6E00 Offset: 0xB6F01 VA: 0xB6E00
	// RVA: 0x2648D00 Offset: 0x2648E01 VA: 0x2648D00
	public string[] Split(char[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0xB6E20 Offset: 0xB6F21 VA: 0xB6E20
	// RVA: 0x2648A90 Offset: 0x2648B91 VA: 0x2648A90
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x26492D0 Offset: 0x26493D1 VA: 0x26492D0
	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x2648F00 Offset: 0x2649001 VA: 0x2648F00
	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x2648D10 Offset: 0x2648E11 VA: 0x2648D10
	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	// RVA: 0x2649540 Offset: 0x2649641 VA: 0x2649540
	public string Substring(int startIndex) { }

	// RVA: 0x263DED0 Offset: 0x263DFD1 VA: 0x263DED0
	public string Substring(int startIndex, int length) { }

	// RVA: 0x2649550 Offset: 0x2649651 VA: 0x2649550
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x26495B0 Offset: 0x26496B1 VA: 0x26495B0
	public string Trim(char[] trimChars) { }

	// RVA: 0x2649BB0 Offset: 0x2649CB1 VA: 0x2649BB0
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x2649BD0 Offset: 0x2649CD1 VA: 0x2649BD0
	public string TrimEnd(char[] trimChars) { }

	[CLSCompliantAttribute] // RVA: 0xB6E40 Offset: 0xB6F41 VA: 0xB6E40
	// RVA: 0x2649BF0 Offset: 0x2649CF1 VA: 0x2649BF0
	public void .ctor(char* value) { }

	[CLSCompliantAttribute] // RVA: 0xB6E60 Offset: 0xB6F61 VA: 0xB6E60
	// RVA: 0x2649C00 Offset: 0x2649D01 VA: 0x2649C00
	public void .ctor(char* value, int startIndex, int length) { }

	[CLSCompliantAttribute] // RVA: 0xB6E80 Offset: 0xB6F81 VA: 0xB6E80
	// RVA: 0x2649C10 Offset: 0x2649D11 VA: 0x2649C10
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x2649C20 Offset: 0x2649D21 VA: 0x2649C20
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x2649D00 Offset: 0x2649E01 VA: 0x2649D00
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x2647960 Offset: 0x2647A61 VA: 0x2647960
	internal static string FastAllocateString(int length) { }

	// RVA: 0x2649DE0 Offset: 0x2649EE1 VA: 0x2649DE0
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x2649EA0 Offset: 0x2649FA1 VA: 0x2649EA0
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x2649EB0 Offset: 0x2649FB1 VA: 0x2649EB0
	public void .ctor(char[] value) { }

	// RVA: 0x2648780 Offset: 0x2648881 VA: 0x2648780
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x2649EC0 Offset: 0x2649FC1 VA: 0x2649EC0
	private string CtorCharArray(char[] value) { }

	// RVA: 0x2649F70 Offset: 0x264A071 VA: 0x2649F70
	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	// RVA: 0x264A120 Offset: 0x264A221 VA: 0x264A120
	private static int wcslen(char* ptr) { }

	// RVA: 0x264A1A0 Offset: 0x264A2A1 VA: 0x264A1A0
	private string CtorCharPtr(char* ptr) { }

	// RVA: 0x264A3D0 Offset: 0x264A4D1 VA: 0x264A3D0
	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	// RVA: 0x264A600 Offset: 0x264A701 VA: 0x264A600
	public void .ctor(char c, int count) { }

	// RVA: 0x264A610 Offset: 0x264A711 VA: 0x264A610
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x26443E0 Offset: 0x26444E1 VA: 0x26443E0
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x264A710 Offset: 0x264A811 VA: 0x264A710
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x264A7E0 Offset: 0x264A8E1 VA: 0x264A7E0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x26454B0 Offset: 0x26455B1 VA: 0x26454B0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x264AA80 Offset: 0x264AB81 VA: 0x264AA80 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x264AB60 Offset: 0x264AC61 VA: 0x264AB60 Slot: 24
	public int CompareTo(string strB) { }

	// RVA: 0x264AC20 Offset: 0x264AD21 VA: 0x264AC20
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x264AC70 Offset: 0x264AD71 VA: 0x264AC70
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x264ACA0 Offset: 0x264ADA1 VA: 0x264ACA0
	public bool Contains(string value) { }

	// RVA: 0x264ACE0 Offset: 0x264ADE1 VA: 0x264ACE0
	public bool EndsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0xB6EA0 Offset: 0xB6FA1 VA: 0xB6EA0
	// RVA: 0x2642520 Offset: 0x2642621 VA: 0x2642520
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x264ACF0 Offset: 0x264ADF1 VA: 0x264ACF0
	internal bool EndsWith(char value) { }

	// RVA: 0x264ADB0 Offset: 0x264AEB1 VA: 0x264ADB0
	public int IndexOf(char value) { }

	// RVA: 0x264AF10 Offset: 0x264B011 VA: 0x264AF10
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x2641720 Offset: 0x2641821 VA: 0x2641720
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x264B040 Offset: 0x264B141 VA: 0x264B040
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x263DEB0 Offset: 0x263DFB1 VA: 0x263DEB0
	public int IndexOf(string value) { }

	// RVA: 0x263DEC0 Offset: 0x263DFC1 VA: 0x263DEC0
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x264B060 Offset: 0x264B161 VA: 0x264B060
	public int IndexOf(string value, int startIndex, int count) { }

	// RVA: 0x264ACD0 Offset: 0x264ADD1 VA: 0x264ACD0
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x264B050 Offset: 0x264B151 VA: 0x264B050
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x264B180 Offset: 0x264B281 VA: 0x264B180
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x264B530 Offset: 0x264B631 VA: 0x264B530
	public int LastIndexOf(char value) { }

	// RVA: 0x264B690 Offset: 0x264B791 VA: 0x264B690
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x264B6A0 Offset: 0x264B7A1 VA: 0x264B6A0
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x264B8B0 Offset: 0x264B9B1 VA: 0x264B8B0
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x264B8C0 Offset: 0x264B9C1 VA: 0x264B8C0
	public int LastIndexOf(string value) { }

	// RVA: 0x264BCF0 Offset: 0x264BDF1 VA: 0x264BCF0
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x264B8D0 Offset: 0x264B9D1 VA: 0x264B8D0
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x264BD00 Offset: 0x264BE01 VA: 0x264BD00
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x264BF10 Offset: 0x264C011 VA: 0x264BF10
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x264BF20 Offset: 0x264C021 VA: 0x264BF20
	public bool StartsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0xB6EC0 Offset: 0xB6FC1 VA: 0xB6EC0
	// RVA: 0x264BFC0 Offset: 0x264C0C1 VA: 0x264BFC0
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x264C2A0 Offset: 0x264C3A1 VA: 0x264C2A0
	public string ToLower() { }

	// RVA: 0x264C310 Offset: 0x264C411 VA: 0x264C310
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x264C3C0 Offset: 0x264C4C1 VA: 0x264C3C0
	public string ToLowerInvariant() { }

	// RVA: 0x264C430 Offset: 0x264C531 VA: 0x264C430
	public string ToUpper() { }

	// RVA: 0x264C4A0 Offset: 0x264C5A1 VA: 0x264C4A0
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x264C550 Offset: 0x264C651 VA: 0x264C550
	public string ToUpperInvariant() { }

	// RVA: 0x264C5C0 Offset: 0x264C6C1 VA: 0x264C5C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x264C5D0 Offset: 0x264C6D1 VA: 0x264C5D0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x264C5E0 Offset: 0x264C6E1 VA: 0x264C5E0 Slot: 5
	public object Clone() { }

	// RVA: 0x264C5F0 Offset: 0x264C6F1 VA: 0x264C5F0
	private static bool IsBOMWhitespace(char c) { }

	// RVA: 0x2646760 Offset: 0x2646861 VA: 0x2646760
	public string Trim() { }

	// RVA: 0x26495D0 Offset: 0x26496D1 VA: 0x26495D0
	private string TrimHelper(int trimType) { }

	// RVA: 0x26498A0 Offset: 0x26499A1 VA: 0x26498A0
	private string TrimHelper(char[] trimChars, int trimType) { }

	// RVA: 0x264C600 Offset: 0x264C701 VA: 0x264C600
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x264C6C0 Offset: 0x264C7C1 VA: 0x264C6C0
	public string Insert(int startIndex, string value) { }

	// RVA: 0x264C830 Offset: 0x264C931 VA: 0x264C830
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x264C9D0 Offset: 0x264CAD1 VA: 0x264C9D0
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x264CB80 Offset: 0x264CC81 VA: 0x264CB80
	public string Remove(int startIndex, int count) { }

	// RVA: 0x263DE50 Offset: 0x263DF51 VA: 0x263DE50
	public static string Format(string format, object arg0) { }

	// RVA: 0x2645EF0 Offset: 0x2645FF1 VA: 0x2645EF0
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x264CE00 Offset: 0x264CF01 VA: 0x264CE00
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x264CE60 Offset: 0x264CF61 VA: 0x264CE60
	public static string Format(string format, object[] args) { }

	// RVA: 0x264CF40 Offset: 0x264D041 VA: 0x264CF40
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x264CFA0 Offset: 0x264D0A1 VA: 0x264CFA0
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x264D010 Offset: 0x264D111 VA: 0x264D010
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x264D080 Offset: 0x264D181 VA: 0x264D080
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x264CD00 Offset: 0x264CE01 VA: 0x264CD00
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x264D170 Offset: 0x264D271 VA: 0x264D170
	public static string Copy(string str) { }

	// RVA: 0x264D230 Offset: 0x264D331 VA: 0x264D230
	public static string Concat(object arg0) { }

	// RVA: 0x264D2A0 Offset: 0x264D3A1 VA: 0x264D2A0
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x264D370 Offset: 0x264D471 VA: 0x264D370
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x264D470 Offset: 0x264D571 VA: 0x264D470
	public static string Concat(object[] args) { }

	// RVA: 0x2641160 Offset: 0x2641261 VA: 0x2641160
	public static string Concat(string str0, string str1) { }

	// RVA: 0x26404A0 Offset: 0x26405A1 VA: 0x26404A0
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x264D750 Offset: 0x264D851 VA: 0x264D750
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x264D6A0 Offset: 0x264D7A1 VA: 0x264D6A0
	private static string ConcatArray(string[] values, int totalLength) { }

	// RVA: 0x264D8C0 Offset: 0x264D9C1 VA: 0x264D8C0
	public static string Concat(string[] values) { }

	// RVA: 0x264DA80 Offset: 0x264DB81 VA: 0x264DA80 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x264DA90 Offset: 0x264DB91 VA: 0x264DA90 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x264DB10 Offset: 0x264DC11 VA: 0x264DB10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x264DB90 Offset: 0x264DC91 VA: 0x264DB90 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x264DC10 Offset: 0x264DD11 VA: 0x264DC10 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x264DC90 Offset: 0x264DD91 VA: 0x264DC90 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x264DD10 Offset: 0x264DE11 VA: 0x264DD10 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x264DD90 Offset: 0x264DE91 VA: 0x264DD90 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x264DE10 Offset: 0x264DF11 VA: 0x264DE10 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x264DE90 Offset: 0x264DF91 VA: 0x264DE90 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x264DF10 Offset: 0x264E011 VA: 0x264DF10 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x264DF90 Offset: 0x264E091 VA: 0x264DF90 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x264E010 Offset: 0x264E111 VA: 0x264E010 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x264E090 Offset: 0x264E191 VA: 0x264E090 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x264E110 Offset: 0x264E211 VA: 0x264E110 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x264E190 Offset: 0x264E291 VA: 0x264E190 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x264E210 Offset: 0x264E311 VA: 0x264E210 Slot: 25
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x264E280 Offset: 0x264E381 VA: 0x264E280 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x264E2F0 Offset: 0x264E3F1 VA: 0x264E2F0
	public int get_Length() { }

	// RVA: 0x264E300 Offset: 0x264E401 VA: 0x264E300
	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	// RVA: 0x264ADC0 Offset: 0x264AEC1 VA: 0x264ADC0
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x264E490 Offset: 0x264E591 VA: 0x264E490
	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x264E650 Offset: 0x264E751 VA: 0x264E650
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x264AF20 Offset: 0x264B021 VA: 0x264AF20
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264E7C0 Offset: 0x264E8C1 VA: 0x264E7C0
	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264B540 Offset: 0x264B641 VA: 0x264B540
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x264E8C0 Offset: 0x264E9C1 VA: 0x264E8C0
	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x264B6B0 Offset: 0x264B7B1 VA: 0x264B6B0
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264EA80 Offset: 0x264EB81 VA: 0x264EA80
	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x264A910 Offset: 0x264AA11 VA: 0x264A910
	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	// RVA: 0x264C840 Offset: 0x264C941 VA: 0x264C840
	private string ReplaceInternal(char oldChar, char newChar) { }

	// RVA: 0x264CA70 Offset: 0x264CB71 VA: 0x264CA70
	internal string ReplaceInternal(string oldValue, string newValue) { }

	// RVA: 0x264EB80 Offset: 0x264EC81 VA: 0x264EB80
	private string ReplaceUnchecked(string oldValue, string newValue) { }

	// RVA: 0x264F080 Offset: 0x264F181 VA: 0x264F080
	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	// RVA: 0x264BD10 Offset: 0x264BE11 VA: 0x264BD10
	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	// RVA: 0x264F250 Offset: 0x264F351 VA: 0x264F250
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x26481D0 Offset: 0x26482D1 VA: 0x26481D0
	internal bool IsAscii() { }

	// RVA: 0x264EB30 Offset: 0x264EC31 VA: 0x264EB30
	internal static void CharCopy(char* dest, char* src, int count) { }

	// RVA: 0x264F2A0 Offset: 0x264F3A1 VA: 0x264F2A0
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x264F430 Offset: 0x264F531 VA: 0x264F430
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x264F440 Offset: 0x264F541 VA: 0x264F440
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x264F590 Offset: 0x264F691 VA: 0x264F590
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x264F5A0 Offset: 0x264F6A1 VA: 0x264F5A0
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x264F5B0 Offset: 0x264F6B1 VA: 0x264F5B0
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x264F5C0 Offset: 0x264F6C1 VA: 0x264F5C0
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x264F5D0 Offset: 0x264F6D1 VA: 0x264F5D0
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x264F5E0 Offset: 0x264F6E1 VA: 0x264F5E0
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x264F5F0 Offset: 0x264F6F1 VA: 0x264F5F0
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x264F600 Offset: 0x264F701 VA: 0x264F600
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x264F610 Offset: 0x264F711 VA: 0x264F610
	private string CreateString(sbyte* value) { }

	// RVA: 0x264F990 Offset: 0x264FA91 VA: 0x264F990
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x264F9A0 Offset: 0x264FAA1 VA: 0x264F9A0
	private string CreateString(char* value) { }

	// RVA: 0x264F9B0 Offset: 0x264FAB1 VA: 0x264F9B0
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x2645DF0 Offset: 0x2645EF1 VA: 0x2645DF0
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x263AFD0 Offset: 0x263B0D1 VA: 0x263AFD0
	private string CreateString(char[] val) { }

	// RVA: 0x26451F0 Offset: 0x26452F1 VA: 0x26451F0
	private string CreateString(char c, int count) { }

	// RVA: 0x264F6B0 Offset: 0x264F7B1 VA: 0x264F6B0
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }
}

