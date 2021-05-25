[ComVisibleAttribute] // RVA: 0xABC20 Offset: 0xABD21 VA: 0xABC20
[Serializable]
public struct Char : IComparable, IConvertible, IComparable<char>, IEquatable<char> // TypeDefIndex: 193
{
	// Fields
	internal char m_value; // 0x0
	public const char MaxValue = '\xffff';
	public const char MinValue = '\x0';
	private static readonly byte[] categoryForLatin1; // 0x0
	internal const int UNICODE_PLANE00_END = 65535;
	internal const int UNICODE_PLANE01_START = 65536;
	internal const int UNICODE_PLANE16_END = 1114111;
	internal const int HIGH_SURROGATE_START = 55296;
	internal const int LOW_SURROGATE_END = 57343;

	// Methods

	// RVA: 0x1856990 Offset: 0x1856A91 VA: 0x1856990
	private static bool IsLatin1(char ch) { }

	// RVA: 0x18569A0 Offset: 0x1856AA1 VA: 0x18569A0
	private static bool IsAscii(char ch) { }

	// RVA: 0x18569B0 Offset: 0x1856AB1 VA: 0x18569B0
	private static UnicodeCategory GetLatin1UnicodeCategory(char ch) { }

	// RVA: 0xCCF0 Offset: 0xCDF1 VA: 0xCCF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xCD00 Offset: 0xCE01 VA: 0xCD00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCDB0 Offset: 0xCEB1 VA: 0xCDB0 Slot: 23
	public bool Equals(char obj) { }

	// RVA: 0xCDC0 Offset: 0xCEC1 VA: 0xCDC0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0xCDD0 Offset: 0xCED1 VA: 0xCDD0 Slot: 22
	public int CompareTo(char value) { }

	// RVA: 0xCDE0 Offset: 0xCEE1 VA: 0xCDE0 Slot: 3
	public override string ToString() { }

	// RVA: 0xCE60 Offset: 0xCF61 VA: 0xCE60 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1856C90 Offset: 0x1856D91 VA: 0x1856C90
	public static string ToString(char c) { }

	// RVA: 0x1856D30 Offset: 0x1856E31 VA: 0x1856D30
	public static char Parse(string s) { }

	// RVA: 0x1856E10 Offset: 0x1856F11 VA: 0x1856E10
	public static bool IsDigit(char c) { }

	// RVA: 0x1856EE0 Offset: 0x1856FE1 VA: 0x1856EE0
	internal static bool CheckLetter(UnicodeCategory uc) { }

	// RVA: 0x1856EF0 Offset: 0x1856FF1 VA: 0x1856EF0
	public static bool IsLetter(char c) { }

	// RVA: 0x1857030 Offset: 0x1857131 VA: 0x1857030
	private static bool IsWhiteSpaceLatin1(char c) { }

	// RVA: 0x1853FB0 Offset: 0x18540B1 VA: 0x1853FB0
	public static bool IsWhiteSpace(char c) { }

	// RVA: 0x1857080 Offset: 0x1857181 VA: 0x1857080
	public static bool IsUpper(char c) { }

	// RVA: 0x18571A0 Offset: 0x18572A1 VA: 0x18571A0
	public static bool IsLower(char c) { }

	// RVA: 0x18572C0 Offset: 0x18573C1 VA: 0x18572C0
	internal static bool CheckPunctuation(UnicodeCategory uc) { }

	// RVA: 0x18572D0 Offset: 0x18573D1 VA: 0x18572D0
	public static bool IsPunctuation(char c) { }

	// RVA: 0x18573D0 Offset: 0x18574D1 VA: 0x18573D0
	internal static bool CheckLetterOrDigit(UnicodeCategory uc) { }

	// RVA: 0x18573F0 Offset: 0x18574F1 VA: 0x18573F0
	public static bool IsLetterOrDigit(char c) { }

	// RVA: 0x1857500 Offset: 0x1857601 VA: 0x1857500
	public static char ToUpper(char c, CultureInfo culture) { }

	// RVA: 0x18575B0 Offset: 0x18576B1 VA: 0x18575B0
	public static char ToUpper(char c) { }

	// RVA: 0x1857650 Offset: 0x1857751 VA: 0x1857650
	public static char ToUpperInvariant(char c) { }

	// RVA: 0x18576F0 Offset: 0x18577F1 VA: 0x18576F0
	public static char ToLower(char c, CultureInfo culture) { }

	// RVA: 0x18577A0 Offset: 0x18578A1 VA: 0x18577A0
	public static char ToLower(char c) { }

	// RVA: 0x1857840 Offset: 0x1857941 VA: 0x1857840
	public static char ToLowerInvariant(char c) { }

	// RVA: 0xCEE0 Offset: 0xCFE1 VA: 0xCEE0 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0xCEF0 Offset: 0xCFF1 VA: 0xCEF0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xCF00 Offset: 0xD001 VA: 0xCF00 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xCF10 Offset: 0xD011 VA: 0xCF10 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xCF80 Offset: 0xD081 VA: 0xCF80 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xCFF0 Offset: 0xD0F1 VA: 0xCFF0 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xD060 Offset: 0xD161 VA: 0xD060 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xD0D0 Offset: 0xD1D1 VA: 0xD0D0 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xD140 Offset: 0xD241 VA: 0xD140 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xD1B0 Offset: 0xD2B1 VA: 0xD1B0 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xD220 Offset: 0xD321 VA: 0xD220 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xD290 Offset: 0xD391 VA: 0xD290 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0xD2A0 Offset: 0xD3A1 VA: 0xD2A0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0xD2B0 Offset: 0xD3B1 VA: 0xD2B0 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xD2C0 Offset: 0xD3C1 VA: 0xD2C0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0xD2D0 Offset: 0xD3D1 VA: 0xD2D0 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x18581E0 Offset: 0x18582E1 VA: 0x18581E0
	public static bool IsControl(char c) { }

	// RVA: 0x18582B0 Offset: 0x18583B1 VA: 0x18582B0
	public static bool IsLetterOrDigit(string s, int index) { }

	// RVA: 0x1858450 Offset: 0x1858551 VA: 0x1858450
	internal static bool CheckNumber(UnicodeCategory uc) { }

	// RVA: 0x1858460 Offset: 0x1858561 VA: 0x1858460
	public static bool IsNumber(char c) { }

	// RVA: 0x18585A0 Offset: 0x18586A1 VA: 0x18585A0
	public static bool IsNumber(string s, int index) { }

	// RVA: 0x1858770 Offset: 0x1858871 VA: 0x1858770
	internal static bool CheckSeparator(UnicodeCategory uc) { }

	// RVA: 0x1858780 Offset: 0x1858881 VA: 0x1858780
	private static bool IsSeparatorLatin1(char c) { }

	// RVA: 0x18587A0 Offset: 0x18588A1 VA: 0x18587A0
	public static bool IsSeparator(char c) { }

	// RVA: 0x18588A0 Offset: 0x18589A1 VA: 0x18588A0
	public static bool IsSurrogate(char c) { }

	// RVA: 0x18588B0 Offset: 0x18589B1 VA: 0x18588B0
	public static bool IsSurrogate(string s, int index) { }

	// RVA: 0x18589B0 Offset: 0x1858AB1 VA: 0x18589B0
	public static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x1858B80 Offset: 0x1858C81 VA: 0x1858B80
	public static UnicodeCategory GetUnicodeCategory(char c) { }

	// RVA: 0x1858C60 Offset: 0x1858D61 VA: 0x1858C60
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x1858DE0 Offset: 0x1858EE1 VA: 0x1858DE0
	public static double GetNumericValue(string s, int index) { }

	// RVA: 0x1858ED0 Offset: 0x1858FD1 VA: 0x1858ED0
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x1858EE0 Offset: 0x1858FE1 VA: 0x1858EE0
	public static bool IsHighSurrogate(string s, int index) { }

	// RVA: 0x1858FE0 Offset: 0x18590E1 VA: 0x1858FE0
	public static bool IsLowSurrogate(char c) { }

	// RVA: 0x1858FF0 Offset: 0x18590F1 VA: 0x1858FF0
	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x1859020 Offset: 0x1859121 VA: 0x1859020
	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x1859160 Offset: 0x1859261 VA: 0x1859160
	private static void .cctor() { }
}

