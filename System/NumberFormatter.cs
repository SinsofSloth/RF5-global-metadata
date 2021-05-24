internal sealed class NumberFormatter // TypeDefIndex: 392
{
	// Fields
	private static readonly ulong* MantissaBitsTable; // 0x0
	private static readonly int* TensExponentTable; // 0x8
	private static readonly char* DigitLowerTable; // 0x10
	private static readonly char* DigitUpperTable; // 0x18
	private static readonly long* TenPowersList; // 0x20
	private static readonly int* DecHexDigits; // 0x28
	private NumberFormatInfo _nfi; // 0x10
	private char[] _cbuf; // 0x18
	private bool _NaN; // 0x20
	private bool _infinity; // 0x21
	private bool _isCustomFormat; // 0x22
	private bool _specifierIsUpper; // 0x23
	private bool _positive; // 0x24
	private char _specifier; // 0x26
	private int _precision; // 0x28
	private int _defPrecision; // 0x2C
	private int _digitsLen; // 0x30
	private int _offset; // 0x34
	private int _decPointPos; // 0x38
	private uint _val1; // 0x3C
	private uint _val2; // 0x40
	private uint _val3; // 0x44
	private uint _val4; // 0x48
	private int _ind; // 0x4C
	[ThreadStaticAttribute] // RVA: 0xB44F0 Offset: 0xB45F1 VA: 0xB44F0
	private static NumberFormatter threadNumberFormatter; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB4500 Offset: 0xB4601 VA: 0xB4500
	private static NumberFormatter userFormatProvider; // 0x80000008

	// Properties
	private CultureInfo CurrentCulture { set; }
	private int IntegerDigits { get; }
	private int DecimalDigits { get; }
	private bool IsFloatingSource { get; }
	private bool IsZero { get; }
	private bool IsZeroInteger { get; }

	// Methods

	// RVA: 0x18E4D50 Offset: 0x18E4E51 VA: 0x18E4D50
	private static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) { }

	// RVA: 0x18E4D60 Offset: 0x18E4E61 VA: 0x18E4D60
	private static void .cctor() { }

	// RVA: 0x18E4DC0 Offset: 0x18E4EC1 VA: 0x18E4DC0
	private static long GetTenPowerOf(int i) { }

	// RVA: 0x18E4E30 Offset: 0x18E4F31 VA: 0x18E4E30
	private void InitDecHexDigits(uint value) { }

	// RVA: 0x18E50B0 Offset: 0x18E51B1 VA: 0x18E50B0
	private void InitDecHexDigits(ulong value) { }

	// RVA: 0x18E51E0 Offset: 0x18E52E1 VA: 0x18E51E0
	private void InitDecHexDigits(uint hi, ulong lo) { }

	// RVA: 0x18E4F00 Offset: 0x18E5001 VA: 0x18E4F00
	private static uint FastToDecHex(int val) { }

	// RVA: 0x18E4FE0 Offset: 0x18E50E1 VA: 0x18E4FE0
	private static uint ToDecHex(int val) { }

	// RVA: 0x18E53D0 Offset: 0x18E54D1 VA: 0x18E53D0
	private static int FastDecHexLen(int val) { }

	// RVA: 0x18E5400 Offset: 0x18E5501 VA: 0x18E5400
	private static int DecHexLen(uint val) { }

	// RVA: 0x18E54F0 Offset: 0x18E55F1 VA: 0x18E54F0
	private int DecHexLen() { }

	// RVA: 0x18E5950 Offset: 0x18E5A51 VA: 0x18E5950
	private static int ScaleOrder(long hi) { }

	// RVA: 0x18E5A50 Offset: 0x18E5B51 VA: 0x18E5A50
	private int InitialFloatingPrecision() { }

	// RVA: 0x18E5B40 Offset: 0x18E5C41 VA: 0x18E5B40
	private static int ParsePrecision(string format) { }

	// RVA: 0x18E5BD0 Offset: 0x18E5CD1 VA: 0x18E5BD0
	private void .ctor(Thread current) { }

	// RVA: 0x18E5D30 Offset: 0x18E5E31 VA: 0x18E5D30
	private void Init(string format) { }

	// RVA: 0x18E5EB0 Offset: 0x18E5FB1 VA: 0x18E5EB0
	private void InitHex(ulong value) { }

	// RVA: 0x18E5F00 Offset: 0x18E6001 VA: 0x18E5F00
	private void Init(string format, int value, int defPrecision) { }

	// RVA: 0x18E5FB0 Offset: 0x18E60B1 VA: 0x18E5FB0
	private void Init(string format, uint value, int defPrecision) { }

	// RVA: 0x18E6050 Offset: 0x18E6151 VA: 0x18E6050
	private void Init(string format, long value) { }

	// RVA: 0x18E60F0 Offset: 0x18E61F1 VA: 0x18E60F0
	private void Init(string format, ulong value) { }

	// RVA: 0x18E6180 Offset: 0x18E6281 VA: 0x18E6180
	private void Init(string format, double value, int defPrecision) { }

	// RVA: 0x18E6810 Offset: 0x18E6911 VA: 0x18E6810
	private void Init(string format, Decimal value) { }

	// RVA: 0x18E6990 Offset: 0x18E6A91 VA: 0x18E6990
	private void ResetCharBuf(int size) { }

	// RVA: 0x18E6A30 Offset: 0x18E6B31 VA: 0x18E6A30
	private void Resize(int len) { }

	// RVA: 0x18E6A90 Offset: 0x18E6B91 VA: 0x18E6A90
	private void Append(char c) { }

	// RVA: 0x18E6B60 Offset: 0x18E6C61 VA: 0x18E6B60
	private void Append(char c, int cnt) { }

	// RVA: 0x18E6C50 Offset: 0x18E6D51 VA: 0x18E6C50
	private void Append(string s) { }

	// RVA: 0x18E6D50 Offset: 0x18E6E51 VA: 0x18E6D50
	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) { }

	// RVA: 0x18E5CC0 Offset: 0x18E5DC1 VA: 0x18E5CC0
	private void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x18E6D70 Offset: 0x18E6E71 VA: 0x18E6D70
	private int get_IntegerDigits() { }

	// RVA: 0x18E6D80 Offset: 0x18E6E81 VA: 0x18E6D80
	private int get_DecimalDigits() { }

	// RVA: 0x18E6DA0 Offset: 0x18E6EA1 VA: 0x18E6DA0
	private bool get_IsFloatingSource() { }

	// RVA: 0x18E6DC0 Offset: 0x18E6EC1 VA: 0x18E6DC0
	private bool get_IsZero() { }

	// RVA: 0x18E6DD0 Offset: 0x18E6ED1 VA: 0x18E6DD0
	private bool get_IsZeroInteger() { }

	// RVA: 0x18E6DF0 Offset: 0x18E6EF1 VA: 0x18E6DF0
	private void RoundPos(int pos) { }

	// RVA: 0x18E6FC0 Offset: 0x18E70C1 VA: 0x18E6FC0
	private bool RoundDecimal(int decimals) { }

	// RVA: 0x18E6E00 Offset: 0x18E6F01 VA: 0x18E6E00
	private bool RoundBits(int shift) { }

	// RVA: 0x18E73B0 Offset: 0x18E74B1 VA: 0x18E73B0
	private void RemoveTrailingZeros() { }

	// RVA: 0x18E6FE0 Offset: 0x18E70E1 VA: 0x18E6FE0
	private void AddOneToDecHex() { }

	// RVA: 0x18E7400 Offset: 0x18E7501 VA: 0x18E7400
	private static uint AddOneToDecHex(uint val) { }

	// RVA: 0x18E6550 Offset: 0x18E6651 VA: 0x18E6550
	private int CountTrailingZeros() { }

	// RVA: 0x18E74B0 Offset: 0x18E75B1 VA: 0x18E74B0
	private static int CountTrailingZeros(uint val) { }

	// RVA: 0x18E7500 Offset: 0x18E7601 VA: 0x18E7500
	private static NumberFormatter GetInstance(IFormatProvider fp) { }

	// RVA: 0x18E7710 Offset: 0x18E7811 VA: 0x18E7710
	private void Release() { }

	// RVA: 0x18E1EA0 Offset: 0x18E1FA1 VA: 0x18E1EA0
	public static string NumberToString(string format, uint value, IFormatProvider fp) { }

	// RVA: 0x18E1D90 Offset: 0x18E1E91 VA: 0x18E1D90
	public static string NumberToString(string format, int value, IFormatProvider fp) { }

	// RVA: 0x18E2150 Offset: 0x18E2251 VA: 0x18E2150
	public static string NumberToString(string format, ulong value, IFormatProvider fp) { }

	// RVA: 0x18E1FB0 Offset: 0x18E20B1 VA: 0x18E1FB0
	public static string NumberToString(string format, long value, IFormatProvider fp) { }

	// RVA: 0x18E22F0 Offset: 0x18E23F1 VA: 0x18E22F0
	public static string NumberToString(string format, float value, IFormatProvider fp) { }

	// RVA: 0x18E1C60 Offset: 0x18E1D61 VA: 0x18E1C60
	public static string NumberToString(string format, double value, IFormatProvider fp) { }

	// RVA: 0x18E1AF0 Offset: 0x18E1BF1 VA: 0x18E1AF0
	public static string NumberToString(string format, Decimal value, IFormatProvider fp) { }

	// RVA: 0x18E77D0 Offset: 0x18E78D1 VA: 0x18E77D0
	private string IntegerToString(string format, IFormatProvider fp) { }

	// RVA: 0x18E7AF0 Offset: 0x18E7BF1 VA: 0x18E7AF0
	private string NumberToString(string format, NumberFormatInfo nfi) { }

	// RVA: 0x18E7E30 Offset: 0x18E7F31 VA: 0x18E7E30
	private string FormatCurrency(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8110 Offset: 0x18E8211 VA: 0x18E8110
	private string FormatDecimal(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8990 Offset: 0x18E8A91 VA: 0x18E8990
	private string FormatHexadecimal(int precision) { }

	// RVA: 0x18E8290 Offset: 0x18E8391 VA: 0x18E8290
	private string FormatFixedPoint(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E7CC0 Offset: 0x18E7DC1 VA: 0x18E7CC0
	private string FormatRoundtrip(double origval, NumberFormatInfo nfi) { }

	// RVA: 0x18E7A10 Offset: 0x18E7B11 VA: 0x18E7A10
	private string FormatRoundtrip(float origval, NumberFormatInfo nfi) { }

	// RVA: 0x18E8410 Offset: 0x18E8511 VA: 0x18E8410
	private string FormatGeneral(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E85E0 Offset: 0x18E86E1 VA: 0x18E85E0
	private string FormatNumber(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E87C0 Offset: 0x18E88C1 VA: 0x18E87C0
	private string FormatPercent(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8230 Offset: 0x18E8331 VA: 0x18E8230
	private string FormatExponential(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E97D0 Offset: 0x18E98D1 VA: 0x18E97D0
	private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) { }

	// RVA: 0x18E8B50 Offset: 0x18E8C51 VA: 0x18E8B50
	private string FormatCustom(string format, NumberFormatInfo nfi) { }

	// RVA: 0x18EA840 Offset: 0x18EA941 VA: 0x18EA840
	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) { }

	// RVA: 0x18EA730 Offset: 0x18EA831 VA: 0x18EA730
	private static bool IsZeroOnly(StringBuilder sb) { }

	// RVA: 0x18EA480 Offset: 0x18EA581 VA: 0x18EA480
	private static void AppendNonNegativeNumber(StringBuilder sb, int v) { }

	// RVA: 0x18EA680 Offset: 0x18EA781 VA: 0x18EA680
	private void AppendIntegerString(int minLength, StringBuilder sb) { }

	// RVA: 0x18E96F0 Offset: 0x18E97F1 VA: 0x18E96F0
	private void AppendIntegerString(int minLength) { }

	// RVA: 0x18EA710 Offset: 0x18EA811 VA: 0x18EA710
	private void AppendDecimalString(int precision, StringBuilder sb) { }

	// RVA: 0x18E93B0 Offset: 0x18E94B1 VA: 0x18E93B0
	private void AppendDecimalString(int precision) { }

	// RVA: 0x18E9130 Offset: 0x18E9231 VA: 0x18E9130
	private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) { }

	// RVA: 0x18E9A50 Offset: 0x18E9B51 VA: 0x18E9A50
	private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) { }

	// RVA: 0x18E9920 Offset: 0x18E9A21 VA: 0x18E9920
	private void AppendOneDigit(int start) { }

	// RVA: 0x18E93D0 Offset: 0x18E94D1 VA: 0x18E93D0
	private void AppendDigits(int start, int end) { }

	// RVA: 0x18EB1F0 Offset: 0x18EB2F1 VA: 0x18EB1F0
	private void AppendDigits(int start, int end, StringBuilder sb) { }

	// RVA: 0x18E9900 Offset: 0x18E9A01 VA: 0x18E9900
	private void Multiply10(int count) { }

	// RVA: 0x18EA460 Offset: 0x18EA561 VA: 0x18EA460
	private void Divide10(int count) { }

	// RVA: 0x18E9760 Offset: 0x18E9861 VA: 0x18E9760
	private NumberFormatter GetClone() { }
}

internal sealed class NumberFormatter // TypeDefIndex: 392
{
	// Fields
	private static readonly ulong* MantissaBitsTable; // 0x0
	private static readonly int* TensExponentTable; // 0x8
	private static readonly char* DigitLowerTable; // 0x10
	private static readonly char* DigitUpperTable; // 0x18
	private static readonly long* TenPowersList; // 0x20
	private static readonly int* DecHexDigits; // 0x28
	private NumberFormatInfo _nfi; // 0x10
	private char[] _cbuf; // 0x18
	private bool _NaN; // 0x20
	private bool _infinity; // 0x21
	private bool _isCustomFormat; // 0x22
	private bool _specifierIsUpper; // 0x23
	private bool _positive; // 0x24
	private char _specifier; // 0x26
	private int _precision; // 0x28
	private int _defPrecision; // 0x2C
	private int _digitsLen; // 0x30
	private int _offset; // 0x34
	private int _decPointPos; // 0x38
	private uint _val1; // 0x3C
	private uint _val2; // 0x40
	private uint _val3; // 0x44
	private uint _val4; // 0x48
	private int _ind; // 0x4C
	[ThreadStaticAttribute] // RVA: 0xB44F0 Offset: 0xB45F1 VA: 0xB44F0
	private static NumberFormatter threadNumberFormatter; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB4500 Offset: 0xB4601 VA: 0xB4500
	private static NumberFormatter userFormatProvider; // 0x80000008

	// Properties
	private CultureInfo CurrentCulture { set; }
	private int IntegerDigits { get; }
	private int DecimalDigits { get; }
	private bool IsFloatingSource { get; }
	private bool IsZero { get; }
	private bool IsZeroInteger { get; }

	// Methods

	// RVA: 0x18E4D50 Offset: 0x18E4E51 VA: 0x18E4D50
	private static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) { }

	// RVA: 0x18E4D60 Offset: 0x18E4E61 VA: 0x18E4D60
	private static void .cctor() { }

	// RVA: 0x18E4DC0 Offset: 0x18E4EC1 VA: 0x18E4DC0
	private static long GetTenPowerOf(int i) { }

	// RVA: 0x18E4E30 Offset: 0x18E4F31 VA: 0x18E4E30
	private void InitDecHexDigits(uint value) { }

	// RVA: 0x18E50B0 Offset: 0x18E51B1 VA: 0x18E50B0
	private void InitDecHexDigits(ulong value) { }

	// RVA: 0x18E51E0 Offset: 0x18E52E1 VA: 0x18E51E0
	private void InitDecHexDigits(uint hi, ulong lo) { }

	// RVA: 0x18E4F00 Offset: 0x18E5001 VA: 0x18E4F00
	private static uint FastToDecHex(int val) { }

	// RVA: 0x18E4FE0 Offset: 0x18E50E1 VA: 0x18E4FE0
	private static uint ToDecHex(int val) { }

	// RVA: 0x18E53D0 Offset: 0x18E54D1 VA: 0x18E53D0
	private static int FastDecHexLen(int val) { }

	// RVA: 0x18E5400 Offset: 0x18E5501 VA: 0x18E5400
	private static int DecHexLen(uint val) { }

	// RVA: 0x18E54F0 Offset: 0x18E55F1 VA: 0x18E54F0
	private int DecHexLen() { }

	// RVA: 0x18E5950 Offset: 0x18E5A51 VA: 0x18E5950
	private static int ScaleOrder(long hi) { }

	// RVA: 0x18E5A50 Offset: 0x18E5B51 VA: 0x18E5A50
	private int InitialFloatingPrecision() { }

	// RVA: 0x18E5B40 Offset: 0x18E5C41 VA: 0x18E5B40
	private static int ParsePrecision(string format) { }

	// RVA: 0x18E5BD0 Offset: 0x18E5CD1 VA: 0x18E5BD0
	private void .ctor(Thread current) { }

	// RVA: 0x18E5D30 Offset: 0x18E5E31 VA: 0x18E5D30
	private void Init(string format) { }

	// RVA: 0x18E5EB0 Offset: 0x18E5FB1 VA: 0x18E5EB0
	private void InitHex(ulong value) { }

	// RVA: 0x18E5F00 Offset: 0x18E6001 VA: 0x18E5F00
	private void Init(string format, int value, int defPrecision) { }

	// RVA: 0x18E5FB0 Offset: 0x18E60B1 VA: 0x18E5FB0
	private void Init(string format, uint value, int defPrecision) { }

	// RVA: 0x18E6050 Offset: 0x18E6151 VA: 0x18E6050
	private void Init(string format, long value) { }

	// RVA: 0x18E60F0 Offset: 0x18E61F1 VA: 0x18E60F0
	private void Init(string format, ulong value) { }

	// RVA: 0x18E6180 Offset: 0x18E6281 VA: 0x18E6180
	private void Init(string format, double value, int defPrecision) { }

	// RVA: 0x18E6810 Offset: 0x18E6911 VA: 0x18E6810
	private void Init(string format, Decimal value) { }

	// RVA: 0x18E6990 Offset: 0x18E6A91 VA: 0x18E6990
	private void ResetCharBuf(int size) { }

	// RVA: 0x18E6A30 Offset: 0x18E6B31 VA: 0x18E6A30
	private void Resize(int len) { }

	// RVA: 0x18E6A90 Offset: 0x18E6B91 VA: 0x18E6A90
	private void Append(char c) { }

	// RVA: 0x18E6B60 Offset: 0x18E6C61 VA: 0x18E6B60
	private void Append(char c, int cnt) { }

	// RVA: 0x18E6C50 Offset: 0x18E6D51 VA: 0x18E6C50
	private void Append(string s) { }

	// RVA: 0x18E6D50 Offset: 0x18E6E51 VA: 0x18E6D50
	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) { }

	// RVA: 0x18E5CC0 Offset: 0x18E5DC1 VA: 0x18E5CC0
	private void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x18E6D70 Offset: 0x18E6E71 VA: 0x18E6D70
	private int get_IntegerDigits() { }

	// RVA: 0x18E6D80 Offset: 0x18E6E81 VA: 0x18E6D80
	private int get_DecimalDigits() { }

	// RVA: 0x18E6DA0 Offset: 0x18E6EA1 VA: 0x18E6DA0
	private bool get_IsFloatingSource() { }

	// RVA: 0x18E6DC0 Offset: 0x18E6EC1 VA: 0x18E6DC0
	private bool get_IsZero() { }

	// RVA: 0x18E6DD0 Offset: 0x18E6ED1 VA: 0x18E6DD0
	private bool get_IsZeroInteger() { }

	// RVA: 0x18E6DF0 Offset: 0x18E6EF1 VA: 0x18E6DF0
	private void RoundPos(int pos) { }

	// RVA: 0x18E6FC0 Offset: 0x18E70C1 VA: 0x18E6FC0
	private bool RoundDecimal(int decimals) { }

	// RVA: 0x18E6E00 Offset: 0x18E6F01 VA: 0x18E6E00
	private bool RoundBits(int shift) { }

	// RVA: 0x18E73B0 Offset: 0x18E74B1 VA: 0x18E73B0
	private void RemoveTrailingZeros() { }

	// RVA: 0x18E6FE0 Offset: 0x18E70E1 VA: 0x18E6FE0
	private void AddOneToDecHex() { }

	// RVA: 0x18E7400 Offset: 0x18E7501 VA: 0x18E7400
	private static uint AddOneToDecHex(uint val) { }

	// RVA: 0x18E6550 Offset: 0x18E6651 VA: 0x18E6550
	private int CountTrailingZeros() { }

	// RVA: 0x18E74B0 Offset: 0x18E75B1 VA: 0x18E74B0
	private static int CountTrailingZeros(uint val) { }

	// RVA: 0x18E7500 Offset: 0x18E7601 VA: 0x18E7500
	private static NumberFormatter GetInstance(IFormatProvider fp) { }

	// RVA: 0x18E7710 Offset: 0x18E7811 VA: 0x18E7710
	private void Release() { }

	// RVA: 0x18E1EA0 Offset: 0x18E1FA1 VA: 0x18E1EA0
	public static string NumberToString(string format, uint value, IFormatProvider fp) { }

	// RVA: 0x18E1D90 Offset: 0x18E1E91 VA: 0x18E1D90
	public static string NumberToString(string format, int value, IFormatProvider fp) { }

	// RVA: 0x18E2150 Offset: 0x18E2251 VA: 0x18E2150
	public static string NumberToString(string format, ulong value, IFormatProvider fp) { }

	// RVA: 0x18E1FB0 Offset: 0x18E20B1 VA: 0x18E1FB0
	public static string NumberToString(string format, long value, IFormatProvider fp) { }

	// RVA: 0x18E22F0 Offset: 0x18E23F1 VA: 0x18E22F0
	public static string NumberToString(string format, float value, IFormatProvider fp) { }

	// RVA: 0x18E1C60 Offset: 0x18E1D61 VA: 0x18E1C60
	public static string NumberToString(string format, double value, IFormatProvider fp) { }

	// RVA: 0x18E1AF0 Offset: 0x18E1BF1 VA: 0x18E1AF0
	public static string NumberToString(string format, Decimal value, IFormatProvider fp) { }

	// RVA: 0x18E77D0 Offset: 0x18E78D1 VA: 0x18E77D0
	private string IntegerToString(string format, IFormatProvider fp) { }

	// RVA: 0x18E7AF0 Offset: 0x18E7BF1 VA: 0x18E7AF0
	private string NumberToString(string format, NumberFormatInfo nfi) { }

	// RVA: 0x18E7E30 Offset: 0x18E7F31 VA: 0x18E7E30
	private string FormatCurrency(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8110 Offset: 0x18E8211 VA: 0x18E8110
	private string FormatDecimal(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8990 Offset: 0x18E8A91 VA: 0x18E8990
	private string FormatHexadecimal(int precision) { }

	// RVA: 0x18E8290 Offset: 0x18E8391 VA: 0x18E8290
	private string FormatFixedPoint(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E7CC0 Offset: 0x18E7DC1 VA: 0x18E7CC0
	private string FormatRoundtrip(double origval, NumberFormatInfo nfi) { }

	// RVA: 0x18E7A10 Offset: 0x18E7B11 VA: 0x18E7A10
	private string FormatRoundtrip(float origval, NumberFormatInfo nfi) { }

	// RVA: 0x18E8410 Offset: 0x18E8511 VA: 0x18E8410
	private string FormatGeneral(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E85E0 Offset: 0x18E86E1 VA: 0x18E85E0
	private string FormatNumber(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E87C0 Offset: 0x18E88C1 VA: 0x18E87C0
	private string FormatPercent(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8230 Offset: 0x18E8331 VA: 0x18E8230
	private string FormatExponential(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E97D0 Offset: 0x18E98D1 VA: 0x18E97D0
	private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) { }

	// RVA: 0x18E8B50 Offset: 0x18E8C51 VA: 0x18E8B50
	private string FormatCustom(string format, NumberFormatInfo nfi) { }

	// RVA: 0x18EA840 Offset: 0x18EA941 VA: 0x18EA840
	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) { }

	// RVA: 0x18EA730 Offset: 0x18EA831 VA: 0x18EA730
	private static bool IsZeroOnly(StringBuilder sb) { }

	// RVA: 0x18EA480 Offset: 0x18EA581 VA: 0x18EA480
	private static void AppendNonNegativeNumber(StringBuilder sb, int v) { }

	// RVA: 0x18EA680 Offset: 0x18EA781 VA: 0x18EA680
	private void AppendIntegerString(int minLength, StringBuilder sb) { }

	// RVA: 0x18E96F0 Offset: 0x18E97F1 VA: 0x18E96F0
	private void AppendIntegerString(int minLength) { }

	// RVA: 0x18EA710 Offset: 0x18EA811 VA: 0x18EA710
	private void AppendDecimalString(int precision, StringBuilder sb) { }

	// RVA: 0x18E93B0 Offset: 0x18E94B1 VA: 0x18E93B0
	private void AppendDecimalString(int precision) { }

	// RVA: 0x18E9130 Offset: 0x18E9231 VA: 0x18E9130
	private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) { }

	// RVA: 0x18E9A50 Offset: 0x18E9B51 VA: 0x18E9A50
	private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) { }

	// RVA: 0x18E9920 Offset: 0x18E9A21 VA: 0x18E9920
	private void AppendOneDigit(int start) { }

	// RVA: 0x18E93D0 Offset: 0x18E94D1 VA: 0x18E93D0
	private void AppendDigits(int start, int end) { }

	// RVA: 0x18EB1F0 Offset: 0x18EB2F1 VA: 0x18EB1F0
	private void AppendDigits(int start, int end, StringBuilder sb) { }

	// RVA: 0x18E9900 Offset: 0x18E9A01 VA: 0x18E9900
	private void Multiply10(int count) { }

	// RVA: 0x18EA460 Offset: 0x18EA561 VA: 0x18EA460
	private void Divide10(int count) { }

	// RVA: 0x18E9760 Offset: 0x18E9861 VA: 0x18E9760
	private NumberFormatter GetClone() { }
}

internal sealed class NumberFormatter // TypeDefIndex: 392
{
	// Fields
	private static readonly ulong* MantissaBitsTable; // 0x0
	private static readonly int* TensExponentTable; // 0x8
	private static readonly char* DigitLowerTable; // 0x10
	private static readonly char* DigitUpperTable; // 0x18
	private static readonly long* TenPowersList; // 0x20
	private static readonly int* DecHexDigits; // 0x28
	private NumberFormatInfo _nfi; // 0x10
	private char[] _cbuf; // 0x18
	private bool _NaN; // 0x20
	private bool _infinity; // 0x21
	private bool _isCustomFormat; // 0x22
	private bool _specifierIsUpper; // 0x23
	private bool _positive; // 0x24
	private char _specifier; // 0x26
	private int _precision; // 0x28
	private int _defPrecision; // 0x2C
	private int _digitsLen; // 0x30
	private int _offset; // 0x34
	private int _decPointPos; // 0x38
	private uint _val1; // 0x3C
	private uint _val2; // 0x40
	private uint _val3; // 0x44
	private uint _val4; // 0x48
	private int _ind; // 0x4C
	[ThreadStaticAttribute] // RVA: 0xB44F0 Offset: 0xB45F1 VA: 0xB44F0
	private static NumberFormatter threadNumberFormatter; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB4500 Offset: 0xB4601 VA: 0xB4500
	private static NumberFormatter userFormatProvider; // 0x80000008

	// Properties
	private CultureInfo CurrentCulture { set; }
	private int IntegerDigits { get; }
	private int DecimalDigits { get; }
	private bool IsFloatingSource { get; }
	private bool IsZero { get; }
	private bool IsZeroInteger { get; }

	// Methods

	// RVA: 0x18E4D50 Offset: 0x18E4E51 VA: 0x18E4D50
	private static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) { }

	// RVA: 0x18E4D60 Offset: 0x18E4E61 VA: 0x18E4D60
	private static void .cctor() { }

	// RVA: 0x18E4DC0 Offset: 0x18E4EC1 VA: 0x18E4DC0
	private static long GetTenPowerOf(int i) { }

	// RVA: 0x18E4E30 Offset: 0x18E4F31 VA: 0x18E4E30
	private void InitDecHexDigits(uint value) { }

	// RVA: 0x18E50B0 Offset: 0x18E51B1 VA: 0x18E50B0
	private void InitDecHexDigits(ulong value) { }

	// RVA: 0x18E51E0 Offset: 0x18E52E1 VA: 0x18E51E0
	private void InitDecHexDigits(uint hi, ulong lo) { }

	// RVA: 0x18E4F00 Offset: 0x18E5001 VA: 0x18E4F00
	private static uint FastToDecHex(int val) { }

	// RVA: 0x18E4FE0 Offset: 0x18E50E1 VA: 0x18E4FE0
	private static uint ToDecHex(int val) { }

	// RVA: 0x18E53D0 Offset: 0x18E54D1 VA: 0x18E53D0
	private static int FastDecHexLen(int val) { }

	// RVA: 0x18E5400 Offset: 0x18E5501 VA: 0x18E5400
	private static int DecHexLen(uint val) { }

	// RVA: 0x18E54F0 Offset: 0x18E55F1 VA: 0x18E54F0
	private int DecHexLen() { }

	// RVA: 0x18E5950 Offset: 0x18E5A51 VA: 0x18E5950
	private static int ScaleOrder(long hi) { }

	// RVA: 0x18E5A50 Offset: 0x18E5B51 VA: 0x18E5A50
	private int InitialFloatingPrecision() { }

	// RVA: 0x18E5B40 Offset: 0x18E5C41 VA: 0x18E5B40
	private static int ParsePrecision(string format) { }

	// RVA: 0x18E5BD0 Offset: 0x18E5CD1 VA: 0x18E5BD0
	private void .ctor(Thread current) { }

	// RVA: 0x18E5D30 Offset: 0x18E5E31 VA: 0x18E5D30
	private void Init(string format) { }

	// RVA: 0x18E5EB0 Offset: 0x18E5FB1 VA: 0x18E5EB0
	private void InitHex(ulong value) { }

	// RVA: 0x18E5F00 Offset: 0x18E6001 VA: 0x18E5F00
	private void Init(string format, int value, int defPrecision) { }

	// RVA: 0x18E5FB0 Offset: 0x18E60B1 VA: 0x18E5FB0
	private void Init(string format, uint value, int defPrecision) { }

	// RVA: 0x18E6050 Offset: 0x18E6151 VA: 0x18E6050
	private void Init(string format, long value) { }

	// RVA: 0x18E60F0 Offset: 0x18E61F1 VA: 0x18E60F0
	private void Init(string format, ulong value) { }

	// RVA: 0x18E6180 Offset: 0x18E6281 VA: 0x18E6180
	private void Init(string format, double value, int defPrecision) { }

	// RVA: 0x18E6810 Offset: 0x18E6911 VA: 0x18E6810
	private void Init(string format, Decimal value) { }

	// RVA: 0x18E6990 Offset: 0x18E6A91 VA: 0x18E6990
	private void ResetCharBuf(int size) { }

	// RVA: 0x18E6A30 Offset: 0x18E6B31 VA: 0x18E6A30
	private void Resize(int len) { }

	// RVA: 0x18E6A90 Offset: 0x18E6B91 VA: 0x18E6A90
	private void Append(char c) { }

	// RVA: 0x18E6B60 Offset: 0x18E6C61 VA: 0x18E6B60
	private void Append(char c, int cnt) { }

	// RVA: 0x18E6C50 Offset: 0x18E6D51 VA: 0x18E6C50
	private void Append(string s) { }

	// RVA: 0x18E6D50 Offset: 0x18E6E51 VA: 0x18E6D50
	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) { }

	// RVA: 0x18E5CC0 Offset: 0x18E5DC1 VA: 0x18E5CC0
	private void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x18E6D70 Offset: 0x18E6E71 VA: 0x18E6D70
	private int get_IntegerDigits() { }

	// RVA: 0x18E6D80 Offset: 0x18E6E81 VA: 0x18E6D80
	private int get_DecimalDigits() { }

	// RVA: 0x18E6DA0 Offset: 0x18E6EA1 VA: 0x18E6DA0
	private bool get_IsFloatingSource() { }

	// RVA: 0x18E6DC0 Offset: 0x18E6EC1 VA: 0x18E6DC0
	private bool get_IsZero() { }

	// RVA: 0x18E6DD0 Offset: 0x18E6ED1 VA: 0x18E6DD0
	private bool get_IsZeroInteger() { }

	// RVA: 0x18E6DF0 Offset: 0x18E6EF1 VA: 0x18E6DF0
	private void RoundPos(int pos) { }

	// RVA: 0x18E6FC0 Offset: 0x18E70C1 VA: 0x18E6FC0
	private bool RoundDecimal(int decimals) { }

	// RVA: 0x18E6E00 Offset: 0x18E6F01 VA: 0x18E6E00
	private bool RoundBits(int shift) { }

	// RVA: 0x18E73B0 Offset: 0x18E74B1 VA: 0x18E73B0
	private void RemoveTrailingZeros() { }

	// RVA: 0x18E6FE0 Offset: 0x18E70E1 VA: 0x18E6FE0
	private void AddOneToDecHex() { }

	// RVA: 0x18E7400 Offset: 0x18E7501 VA: 0x18E7400
	private static uint AddOneToDecHex(uint val) { }

	// RVA: 0x18E6550 Offset: 0x18E6651 VA: 0x18E6550
	private int CountTrailingZeros() { }

	// RVA: 0x18E74B0 Offset: 0x18E75B1 VA: 0x18E74B0
	private static int CountTrailingZeros(uint val) { }

	// RVA: 0x18E7500 Offset: 0x18E7601 VA: 0x18E7500
	private static NumberFormatter GetInstance(IFormatProvider fp) { }

	// RVA: 0x18E7710 Offset: 0x18E7811 VA: 0x18E7710
	private void Release() { }

	// RVA: 0x18E1EA0 Offset: 0x18E1FA1 VA: 0x18E1EA0
	public static string NumberToString(string format, uint value, IFormatProvider fp) { }

	// RVA: 0x18E1D90 Offset: 0x18E1E91 VA: 0x18E1D90
	public static string NumberToString(string format, int value, IFormatProvider fp) { }

	// RVA: 0x18E2150 Offset: 0x18E2251 VA: 0x18E2150
	public static string NumberToString(string format, ulong value, IFormatProvider fp) { }

	// RVA: 0x18E1FB0 Offset: 0x18E20B1 VA: 0x18E1FB0
	public static string NumberToString(string format, long value, IFormatProvider fp) { }

	// RVA: 0x18E22F0 Offset: 0x18E23F1 VA: 0x18E22F0
	public static string NumberToString(string format, float value, IFormatProvider fp) { }

	// RVA: 0x18E1C60 Offset: 0x18E1D61 VA: 0x18E1C60
	public static string NumberToString(string format, double value, IFormatProvider fp) { }

	// RVA: 0x18E1AF0 Offset: 0x18E1BF1 VA: 0x18E1AF0
	public static string NumberToString(string format, Decimal value, IFormatProvider fp) { }

	// RVA: 0x18E77D0 Offset: 0x18E78D1 VA: 0x18E77D0
	private string IntegerToString(string format, IFormatProvider fp) { }

	// RVA: 0x18E7AF0 Offset: 0x18E7BF1 VA: 0x18E7AF0
	private string NumberToString(string format, NumberFormatInfo nfi) { }

	// RVA: 0x18E7E30 Offset: 0x18E7F31 VA: 0x18E7E30
	private string FormatCurrency(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8110 Offset: 0x18E8211 VA: 0x18E8110
	private string FormatDecimal(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8990 Offset: 0x18E8A91 VA: 0x18E8990
	private string FormatHexadecimal(int precision) { }

	// RVA: 0x18E8290 Offset: 0x18E8391 VA: 0x18E8290
	private string FormatFixedPoint(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E7CC0 Offset: 0x18E7DC1 VA: 0x18E7CC0
	private string FormatRoundtrip(double origval, NumberFormatInfo nfi) { }

	// RVA: 0x18E7A10 Offset: 0x18E7B11 VA: 0x18E7A10
	private string FormatRoundtrip(float origval, NumberFormatInfo nfi) { }

	// RVA: 0x18E8410 Offset: 0x18E8511 VA: 0x18E8410
	private string FormatGeneral(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E85E0 Offset: 0x18E86E1 VA: 0x18E85E0
	private string FormatNumber(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E87C0 Offset: 0x18E88C1 VA: 0x18E87C0
	private string FormatPercent(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8230 Offset: 0x18E8331 VA: 0x18E8230
	private string FormatExponential(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E97D0 Offset: 0x18E98D1 VA: 0x18E97D0
	private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) { }

	// RVA: 0x18E8B50 Offset: 0x18E8C51 VA: 0x18E8B50
	private string FormatCustom(string format, NumberFormatInfo nfi) { }

	// RVA: 0x18EA840 Offset: 0x18EA941 VA: 0x18EA840
	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) { }

	// RVA: 0x18EA730 Offset: 0x18EA831 VA: 0x18EA730
	private static bool IsZeroOnly(StringBuilder sb) { }

	// RVA: 0x18EA480 Offset: 0x18EA581 VA: 0x18EA480
	private static void AppendNonNegativeNumber(StringBuilder sb, int v) { }

	// RVA: 0x18EA680 Offset: 0x18EA781 VA: 0x18EA680
	private void AppendIntegerString(int minLength, StringBuilder sb) { }

	// RVA: 0x18E96F0 Offset: 0x18E97F1 VA: 0x18E96F0
	private void AppendIntegerString(int minLength) { }

	// RVA: 0x18EA710 Offset: 0x18EA811 VA: 0x18EA710
	private void AppendDecimalString(int precision, StringBuilder sb) { }

	// RVA: 0x18E93B0 Offset: 0x18E94B1 VA: 0x18E93B0
	private void AppendDecimalString(int precision) { }

	// RVA: 0x18E9130 Offset: 0x18E9231 VA: 0x18E9130
	private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) { }

	// RVA: 0x18E9A50 Offset: 0x18E9B51 VA: 0x18E9A50
	private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) { }

	// RVA: 0x18E9920 Offset: 0x18E9A21 VA: 0x18E9920
	private void AppendOneDigit(int start) { }

	// RVA: 0x18E93D0 Offset: 0x18E94D1 VA: 0x18E93D0
	private void AppendDigits(int start, int end) { }

	// RVA: 0x18EB1F0 Offset: 0x18EB2F1 VA: 0x18EB1F0
	private void AppendDigits(int start, int end, StringBuilder sb) { }

	// RVA: 0x18E9900 Offset: 0x18E9A01 VA: 0x18E9900
	private void Multiply10(int count) { }

	// RVA: 0x18EA460 Offset: 0x18EA561 VA: 0x18EA460
	private void Divide10(int count) { }

	// RVA: 0x18E9760 Offset: 0x18E9861 VA: 0x18E9760
	private NumberFormatter GetClone() { }
}

internal sealed class NumberFormatter // TypeDefIndex: 392
{
	// Fields
	private static readonly ulong* MantissaBitsTable; // 0x0
	private static readonly int* TensExponentTable; // 0x8
	private static readonly char* DigitLowerTable; // 0x10
	private static readonly char* DigitUpperTable; // 0x18
	private static readonly long* TenPowersList; // 0x20
	private static readonly int* DecHexDigits; // 0x28
	private NumberFormatInfo _nfi; // 0x10
	private char[] _cbuf; // 0x18
	private bool _NaN; // 0x20
	private bool _infinity; // 0x21
	private bool _isCustomFormat; // 0x22
	private bool _specifierIsUpper; // 0x23
	private bool _positive; // 0x24
	private char _specifier; // 0x26
	private int _precision; // 0x28
	private int _defPrecision; // 0x2C
	private int _digitsLen; // 0x30
	private int _offset; // 0x34
	private int _decPointPos; // 0x38
	private uint _val1; // 0x3C
	private uint _val2; // 0x40
	private uint _val3; // 0x44
	private uint _val4; // 0x48
	private int _ind; // 0x4C
	[ThreadStaticAttribute] // RVA: 0xB44F0 Offset: 0xB45F1 VA: 0xB44F0
	private static NumberFormatter threadNumberFormatter; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB4500 Offset: 0xB4601 VA: 0xB4500
	private static NumberFormatter userFormatProvider; // 0x80000008

	// Properties
	private CultureInfo CurrentCulture { set; }
	private int IntegerDigits { get; }
	private int DecimalDigits { get; }
	private bool IsFloatingSource { get; }
	private bool IsZero { get; }
	private bool IsZeroInteger { get; }

	// Methods

	// RVA: 0x18E4D50 Offset: 0x18E4E51 VA: 0x18E4D50
	private static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) { }

	// RVA: 0x18E4D60 Offset: 0x18E4E61 VA: 0x18E4D60
	private static void .cctor() { }

	// RVA: 0x18E4DC0 Offset: 0x18E4EC1 VA: 0x18E4DC0
	private static long GetTenPowerOf(int i) { }

	// RVA: 0x18E4E30 Offset: 0x18E4F31 VA: 0x18E4E30
	private void InitDecHexDigits(uint value) { }

	// RVA: 0x18E50B0 Offset: 0x18E51B1 VA: 0x18E50B0
	private void InitDecHexDigits(ulong value) { }

	// RVA: 0x18E51E0 Offset: 0x18E52E1 VA: 0x18E51E0
	private void InitDecHexDigits(uint hi, ulong lo) { }

	// RVA: 0x18E4F00 Offset: 0x18E5001 VA: 0x18E4F00
	private static uint FastToDecHex(int val) { }

	// RVA: 0x18E4FE0 Offset: 0x18E50E1 VA: 0x18E4FE0
	private static uint ToDecHex(int val) { }

	// RVA: 0x18E53D0 Offset: 0x18E54D1 VA: 0x18E53D0
	private static int FastDecHexLen(int val) { }

	// RVA: 0x18E5400 Offset: 0x18E5501 VA: 0x18E5400
	private static int DecHexLen(uint val) { }

	// RVA: 0x18E54F0 Offset: 0x18E55F1 VA: 0x18E54F0
	private int DecHexLen() { }

	// RVA: 0x18E5950 Offset: 0x18E5A51 VA: 0x18E5950
	private static int ScaleOrder(long hi) { }

	// RVA: 0x18E5A50 Offset: 0x18E5B51 VA: 0x18E5A50
	private int InitialFloatingPrecision() { }

	// RVA: 0x18E5B40 Offset: 0x18E5C41 VA: 0x18E5B40
	private static int ParsePrecision(string format) { }

	// RVA: 0x18E5BD0 Offset: 0x18E5CD1 VA: 0x18E5BD0
	private void .ctor(Thread current) { }

	// RVA: 0x18E5D30 Offset: 0x18E5E31 VA: 0x18E5D30
	private void Init(string format) { }

	// RVA: 0x18E5EB0 Offset: 0x18E5FB1 VA: 0x18E5EB0
	private void InitHex(ulong value) { }

	// RVA: 0x18E5F00 Offset: 0x18E6001 VA: 0x18E5F00
	private void Init(string format, int value, int defPrecision) { }

	// RVA: 0x18E5FB0 Offset: 0x18E60B1 VA: 0x18E5FB0
	private void Init(string format, uint value, int defPrecision) { }

	// RVA: 0x18E6050 Offset: 0x18E6151 VA: 0x18E6050
	private void Init(string format, long value) { }

	// RVA: 0x18E60F0 Offset: 0x18E61F1 VA: 0x18E60F0
	private void Init(string format, ulong value) { }

	// RVA: 0x18E6180 Offset: 0x18E6281 VA: 0x18E6180
	private void Init(string format, double value, int defPrecision) { }

	// RVA: 0x18E6810 Offset: 0x18E6911 VA: 0x18E6810
	private void Init(string format, Decimal value) { }

	// RVA: 0x18E6990 Offset: 0x18E6A91 VA: 0x18E6990
	private void ResetCharBuf(int size) { }

	// RVA: 0x18E6A30 Offset: 0x18E6B31 VA: 0x18E6A30
	private void Resize(int len) { }

	// RVA: 0x18E6A90 Offset: 0x18E6B91 VA: 0x18E6A90
	private void Append(char c) { }

	// RVA: 0x18E6B60 Offset: 0x18E6C61 VA: 0x18E6B60
	private void Append(char c, int cnt) { }

	// RVA: 0x18E6C50 Offset: 0x18E6D51 VA: 0x18E6C50
	private void Append(string s) { }

	// RVA: 0x18E6D50 Offset: 0x18E6E51 VA: 0x18E6D50
	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) { }

	// RVA: 0x18E5CC0 Offset: 0x18E5DC1 VA: 0x18E5CC0
	private void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x18E6D70 Offset: 0x18E6E71 VA: 0x18E6D70
	private int get_IntegerDigits() { }

	// RVA: 0x18E6D80 Offset: 0x18E6E81 VA: 0x18E6D80
	private int get_DecimalDigits() { }

	// RVA: 0x18E6DA0 Offset: 0x18E6EA1 VA: 0x18E6DA0
	private bool get_IsFloatingSource() { }

	// RVA: 0x18E6DC0 Offset: 0x18E6EC1 VA: 0x18E6DC0
	private bool get_IsZero() { }

	// RVA: 0x18E6DD0 Offset: 0x18E6ED1 VA: 0x18E6DD0
	private bool get_IsZeroInteger() { }

	// RVA: 0x18E6DF0 Offset: 0x18E6EF1 VA: 0x18E6DF0
	private void RoundPos(int pos) { }

	// RVA: 0x18E6FC0 Offset: 0x18E70C1 VA: 0x18E6FC0
	private bool RoundDecimal(int decimals) { }

	// RVA: 0x18E6E00 Offset: 0x18E6F01 VA: 0x18E6E00
	private bool RoundBits(int shift) { }

	// RVA: 0x18E73B0 Offset: 0x18E74B1 VA: 0x18E73B0
	private void RemoveTrailingZeros() { }

	// RVA: 0x18E6FE0 Offset: 0x18E70E1 VA: 0x18E6FE0
	private void AddOneToDecHex() { }

	// RVA: 0x18E7400 Offset: 0x18E7501 VA: 0x18E7400
	private static uint AddOneToDecHex(uint val) { }

	// RVA: 0x18E6550 Offset: 0x18E6651 VA: 0x18E6550
	private int CountTrailingZeros() { }

	// RVA: 0x18E74B0 Offset: 0x18E75B1 VA: 0x18E74B0
	private static int CountTrailingZeros(uint val) { }

	// RVA: 0x18E7500 Offset: 0x18E7601 VA: 0x18E7500
	private static NumberFormatter GetInstance(IFormatProvider fp) { }

	// RVA: 0x18E7710 Offset: 0x18E7811 VA: 0x18E7710
	private void Release() { }

	// RVA: 0x18E1EA0 Offset: 0x18E1FA1 VA: 0x18E1EA0
	public static string NumberToString(string format, uint value, IFormatProvider fp) { }

	// RVA: 0x18E1D90 Offset: 0x18E1E91 VA: 0x18E1D90
	public static string NumberToString(string format, int value, IFormatProvider fp) { }

	// RVA: 0x18E2150 Offset: 0x18E2251 VA: 0x18E2150
	public static string NumberToString(string format, ulong value, IFormatProvider fp) { }

	// RVA: 0x18E1FB0 Offset: 0x18E20B1 VA: 0x18E1FB0
	public static string NumberToString(string format, long value, IFormatProvider fp) { }

	// RVA: 0x18E22F0 Offset: 0x18E23F1 VA: 0x18E22F0
	public static string NumberToString(string format, float value, IFormatProvider fp) { }

	// RVA: 0x18E1C60 Offset: 0x18E1D61 VA: 0x18E1C60
	public static string NumberToString(string format, double value, IFormatProvider fp) { }

	// RVA: 0x18E1AF0 Offset: 0x18E1BF1 VA: 0x18E1AF0
	public static string NumberToString(string format, Decimal value, IFormatProvider fp) { }

	// RVA: 0x18E77D0 Offset: 0x18E78D1 VA: 0x18E77D0
	private string IntegerToString(string format, IFormatProvider fp) { }

	// RVA: 0x18E7AF0 Offset: 0x18E7BF1 VA: 0x18E7AF0
	private string NumberToString(string format, NumberFormatInfo nfi) { }

	// RVA: 0x18E7E30 Offset: 0x18E7F31 VA: 0x18E7E30
	private string FormatCurrency(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8110 Offset: 0x18E8211 VA: 0x18E8110
	private string FormatDecimal(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8990 Offset: 0x18E8A91 VA: 0x18E8990
	private string FormatHexadecimal(int precision) { }

	// RVA: 0x18E8290 Offset: 0x18E8391 VA: 0x18E8290
	private string FormatFixedPoint(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E7CC0 Offset: 0x18E7DC1 VA: 0x18E7CC0
	private string FormatRoundtrip(double origval, NumberFormatInfo nfi) { }

	// RVA: 0x18E7A10 Offset: 0x18E7B11 VA: 0x18E7A10
	private string FormatRoundtrip(float origval, NumberFormatInfo nfi) { }

	// RVA: 0x18E8410 Offset: 0x18E8511 VA: 0x18E8410
	private string FormatGeneral(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E85E0 Offset: 0x18E86E1 VA: 0x18E85E0
	private string FormatNumber(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E87C0 Offset: 0x18E88C1 VA: 0x18E87C0
	private string FormatPercent(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8230 Offset: 0x18E8331 VA: 0x18E8230
	private string FormatExponential(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E97D0 Offset: 0x18E98D1 VA: 0x18E97D0
	private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) { }

	// RVA: 0x18E8B50 Offset: 0x18E8C51 VA: 0x18E8B50
	private string FormatCustom(string format, NumberFormatInfo nfi) { }

	// RVA: 0x18EA840 Offset: 0x18EA941 VA: 0x18EA840
	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) { }

	// RVA: 0x18EA730 Offset: 0x18EA831 VA: 0x18EA730
	private static bool IsZeroOnly(StringBuilder sb) { }

	// RVA: 0x18EA480 Offset: 0x18EA581 VA: 0x18EA480
	private static void AppendNonNegativeNumber(StringBuilder sb, int v) { }

	// RVA: 0x18EA680 Offset: 0x18EA781 VA: 0x18EA680
	private void AppendIntegerString(int minLength, StringBuilder sb) { }

	// RVA: 0x18E96F0 Offset: 0x18E97F1 VA: 0x18E96F0
	private void AppendIntegerString(int minLength) { }

	// RVA: 0x18EA710 Offset: 0x18EA811 VA: 0x18EA710
	private void AppendDecimalString(int precision, StringBuilder sb) { }

	// RVA: 0x18E93B0 Offset: 0x18E94B1 VA: 0x18E93B0
	private void AppendDecimalString(int precision) { }

	// RVA: 0x18E9130 Offset: 0x18E9231 VA: 0x18E9130
	private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) { }

	// RVA: 0x18E9A50 Offset: 0x18E9B51 VA: 0x18E9A50
	private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) { }

	// RVA: 0x18E9920 Offset: 0x18E9A21 VA: 0x18E9920
	private void AppendOneDigit(int start) { }

	// RVA: 0x18E93D0 Offset: 0x18E94D1 VA: 0x18E93D0
	private void AppendDigits(int start, int end) { }

	// RVA: 0x18EB1F0 Offset: 0x18EB2F1 VA: 0x18EB1F0
	private void AppendDigits(int start, int end, StringBuilder sb) { }

	// RVA: 0x18E9900 Offset: 0x18E9A01 VA: 0x18E9900
	private void Multiply10(int count) { }

	// RVA: 0x18EA460 Offset: 0x18EA561 VA: 0x18EA460
	private void Divide10(int count) { }

	// RVA: 0x18E9760 Offset: 0x18E9861 VA: 0x18E9760
	private NumberFormatter GetClone() { }
}

internal sealed class NumberFormatter // TypeDefIndex: 392
{
	// Fields
	private static readonly ulong* MantissaBitsTable; // 0x0
	private static readonly int* TensExponentTable; // 0x8
	private static readonly char* DigitLowerTable; // 0x10
	private static readonly char* DigitUpperTable; // 0x18
	private static readonly long* TenPowersList; // 0x20
	private static readonly int* DecHexDigits; // 0x28
	private NumberFormatInfo _nfi; // 0x10
	private char[] _cbuf; // 0x18
	private bool _NaN; // 0x20
	private bool _infinity; // 0x21
	private bool _isCustomFormat; // 0x22
	private bool _specifierIsUpper; // 0x23
	private bool _positive; // 0x24
	private char _specifier; // 0x26
	private int _precision; // 0x28
	private int _defPrecision; // 0x2C
	private int _digitsLen; // 0x30
	private int _offset; // 0x34
	private int _decPointPos; // 0x38
	private uint _val1; // 0x3C
	private uint _val2; // 0x40
	private uint _val3; // 0x44
	private uint _val4; // 0x48
	private int _ind; // 0x4C
	[ThreadStaticAttribute] // RVA: 0xB44F0 Offset: 0xB45F1 VA: 0xB44F0
	private static NumberFormatter threadNumberFormatter; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB4500 Offset: 0xB4601 VA: 0xB4500
	private static NumberFormatter userFormatProvider; // 0x80000008

	// Properties
	private CultureInfo CurrentCulture { set; }
	private int IntegerDigits { get; }
	private int DecimalDigits { get; }
	private bool IsFloatingSource { get; }
	private bool IsZero { get; }
	private bool IsZeroInteger { get; }

	// Methods

	// RVA: 0x18E4D50 Offset: 0x18E4E51 VA: 0x18E4D50
	private static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) { }

	// RVA: 0x18E4D60 Offset: 0x18E4E61 VA: 0x18E4D60
	private static void .cctor() { }

	// RVA: 0x18E4DC0 Offset: 0x18E4EC1 VA: 0x18E4DC0
	private static long GetTenPowerOf(int i) { }

	// RVA: 0x18E4E30 Offset: 0x18E4F31 VA: 0x18E4E30
	private void InitDecHexDigits(uint value) { }

	// RVA: 0x18E50B0 Offset: 0x18E51B1 VA: 0x18E50B0
	private void InitDecHexDigits(ulong value) { }

	// RVA: 0x18E51E0 Offset: 0x18E52E1 VA: 0x18E51E0
	private void InitDecHexDigits(uint hi, ulong lo) { }

	// RVA: 0x18E4F00 Offset: 0x18E5001 VA: 0x18E4F00
	private static uint FastToDecHex(int val) { }

	// RVA: 0x18E4FE0 Offset: 0x18E50E1 VA: 0x18E4FE0
	private static uint ToDecHex(int val) { }

	// RVA: 0x18E53D0 Offset: 0x18E54D1 VA: 0x18E53D0
	private static int FastDecHexLen(int val) { }

	// RVA: 0x18E5400 Offset: 0x18E5501 VA: 0x18E5400
	private static int DecHexLen(uint val) { }

	// RVA: 0x18E54F0 Offset: 0x18E55F1 VA: 0x18E54F0
	private int DecHexLen() { }

	// RVA: 0x18E5950 Offset: 0x18E5A51 VA: 0x18E5950
	private static int ScaleOrder(long hi) { }

	// RVA: 0x18E5A50 Offset: 0x18E5B51 VA: 0x18E5A50
	private int InitialFloatingPrecision() { }

	// RVA: 0x18E5B40 Offset: 0x18E5C41 VA: 0x18E5B40
	private static int ParsePrecision(string format) { }

	// RVA: 0x18E5BD0 Offset: 0x18E5CD1 VA: 0x18E5BD0
	private void .ctor(Thread current) { }

	// RVA: 0x18E5D30 Offset: 0x18E5E31 VA: 0x18E5D30
	private void Init(string format) { }

	// RVA: 0x18E5EB0 Offset: 0x18E5FB1 VA: 0x18E5EB0
	private void InitHex(ulong value) { }

	// RVA: 0x18E5F00 Offset: 0x18E6001 VA: 0x18E5F00
	private void Init(string format, int value, int defPrecision) { }

	// RVA: 0x18E5FB0 Offset: 0x18E60B1 VA: 0x18E5FB0
	private void Init(string format, uint value, int defPrecision) { }

	// RVA: 0x18E6050 Offset: 0x18E6151 VA: 0x18E6050
	private void Init(string format, long value) { }

	// RVA: 0x18E60F0 Offset: 0x18E61F1 VA: 0x18E60F0
	private void Init(string format, ulong value) { }

	// RVA: 0x18E6180 Offset: 0x18E6281 VA: 0x18E6180
	private void Init(string format, double value, int defPrecision) { }

	// RVA: 0x18E6810 Offset: 0x18E6911 VA: 0x18E6810
	private void Init(string format, Decimal value) { }

	// RVA: 0x18E6990 Offset: 0x18E6A91 VA: 0x18E6990
	private void ResetCharBuf(int size) { }

	// RVA: 0x18E6A30 Offset: 0x18E6B31 VA: 0x18E6A30
	private void Resize(int len) { }

	// RVA: 0x18E6A90 Offset: 0x18E6B91 VA: 0x18E6A90
	private void Append(char c) { }

	// RVA: 0x18E6B60 Offset: 0x18E6C61 VA: 0x18E6B60
	private void Append(char c, int cnt) { }

	// RVA: 0x18E6C50 Offset: 0x18E6D51 VA: 0x18E6C50
	private void Append(string s) { }

	// RVA: 0x18E6D50 Offset: 0x18E6E51 VA: 0x18E6D50
	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) { }

	// RVA: 0x18E5CC0 Offset: 0x18E5DC1 VA: 0x18E5CC0
	private void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x18E6D70 Offset: 0x18E6E71 VA: 0x18E6D70
	private int get_IntegerDigits() { }

	// RVA: 0x18E6D80 Offset: 0x18E6E81 VA: 0x18E6D80
	private int get_DecimalDigits() { }

	// RVA: 0x18E6DA0 Offset: 0x18E6EA1 VA: 0x18E6DA0
	private bool get_IsFloatingSource() { }

	// RVA: 0x18E6DC0 Offset: 0x18E6EC1 VA: 0x18E6DC0
	private bool get_IsZero() { }

	// RVA: 0x18E6DD0 Offset: 0x18E6ED1 VA: 0x18E6DD0
	private bool get_IsZeroInteger() { }

	// RVA: 0x18E6DF0 Offset: 0x18E6EF1 VA: 0x18E6DF0
	private void RoundPos(int pos) { }

	// RVA: 0x18E6FC0 Offset: 0x18E70C1 VA: 0x18E6FC0
	private bool RoundDecimal(int decimals) { }

	// RVA: 0x18E6E00 Offset: 0x18E6F01 VA: 0x18E6E00
	private bool RoundBits(int shift) { }

	// RVA: 0x18E73B0 Offset: 0x18E74B1 VA: 0x18E73B0
	private void RemoveTrailingZeros() { }

	// RVA: 0x18E6FE0 Offset: 0x18E70E1 VA: 0x18E6FE0
	private void AddOneToDecHex() { }

	// RVA: 0x18E7400 Offset: 0x18E7501 VA: 0x18E7400
	private static uint AddOneToDecHex(uint val) { }

	// RVA: 0x18E6550 Offset: 0x18E6651 VA: 0x18E6550
	private int CountTrailingZeros() { }

	// RVA: 0x18E74B0 Offset: 0x18E75B1 VA: 0x18E74B0
	private static int CountTrailingZeros(uint val) { }

	// RVA: 0x18E7500 Offset: 0x18E7601 VA: 0x18E7500
	private static NumberFormatter GetInstance(IFormatProvider fp) { }

	// RVA: 0x18E7710 Offset: 0x18E7811 VA: 0x18E7710
	private void Release() { }

	// RVA: 0x18E1EA0 Offset: 0x18E1FA1 VA: 0x18E1EA0
	public static string NumberToString(string format, uint value, IFormatProvider fp) { }

	// RVA: 0x18E1D90 Offset: 0x18E1E91 VA: 0x18E1D90
	public static string NumberToString(string format, int value, IFormatProvider fp) { }

	// RVA: 0x18E2150 Offset: 0x18E2251 VA: 0x18E2150
	public static string NumberToString(string format, ulong value, IFormatProvider fp) { }

	// RVA: 0x18E1FB0 Offset: 0x18E20B1 VA: 0x18E1FB0
	public static string NumberToString(string format, long value, IFormatProvider fp) { }

	// RVA: 0x18E22F0 Offset: 0x18E23F1 VA: 0x18E22F0
	public static string NumberToString(string format, float value, IFormatProvider fp) { }

	// RVA: 0x18E1C60 Offset: 0x18E1D61 VA: 0x18E1C60
	public static string NumberToString(string format, double value, IFormatProvider fp) { }

	// RVA: 0x18E1AF0 Offset: 0x18E1BF1 VA: 0x18E1AF0
	public static string NumberToString(string format, Decimal value, IFormatProvider fp) { }

	// RVA: 0x18E77D0 Offset: 0x18E78D1 VA: 0x18E77D0
	private string IntegerToString(string format, IFormatProvider fp) { }

	// RVA: 0x18E7AF0 Offset: 0x18E7BF1 VA: 0x18E7AF0
	private string NumberToString(string format, NumberFormatInfo nfi) { }

	// RVA: 0x18E7E30 Offset: 0x18E7F31 VA: 0x18E7E30
	private string FormatCurrency(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8110 Offset: 0x18E8211 VA: 0x18E8110
	private string FormatDecimal(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8990 Offset: 0x18E8A91 VA: 0x18E8990
	private string FormatHexadecimal(int precision) { }

	// RVA: 0x18E8290 Offset: 0x18E8391 VA: 0x18E8290
	private string FormatFixedPoint(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E7CC0 Offset: 0x18E7DC1 VA: 0x18E7CC0
	private string FormatRoundtrip(double origval, NumberFormatInfo nfi) { }

	// RVA: 0x18E7A10 Offset: 0x18E7B11 VA: 0x18E7A10
	private string FormatRoundtrip(float origval, NumberFormatInfo nfi) { }

	// RVA: 0x18E8410 Offset: 0x18E8511 VA: 0x18E8410
	private string FormatGeneral(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E85E0 Offset: 0x18E86E1 VA: 0x18E85E0
	private string FormatNumber(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E87C0 Offset: 0x18E88C1 VA: 0x18E87C0
	private string FormatPercent(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8230 Offset: 0x18E8331 VA: 0x18E8230
	private string FormatExponential(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E97D0 Offset: 0x18E98D1 VA: 0x18E97D0
	private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) { }

	// RVA: 0x18E8B50 Offset: 0x18E8C51 VA: 0x18E8B50
	private string FormatCustom(string format, NumberFormatInfo nfi) { }

	// RVA: 0x18EA840 Offset: 0x18EA941 VA: 0x18EA840
	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) { }

	// RVA: 0x18EA730 Offset: 0x18EA831 VA: 0x18EA730
	private static bool IsZeroOnly(StringBuilder sb) { }

	// RVA: 0x18EA480 Offset: 0x18EA581 VA: 0x18EA480
	private static void AppendNonNegativeNumber(StringBuilder sb, int v) { }

	// RVA: 0x18EA680 Offset: 0x18EA781 VA: 0x18EA680
	private void AppendIntegerString(int minLength, StringBuilder sb) { }

	// RVA: 0x18E96F0 Offset: 0x18E97F1 VA: 0x18E96F0
	private void AppendIntegerString(int minLength) { }

	// RVA: 0x18EA710 Offset: 0x18EA811 VA: 0x18EA710
	private void AppendDecimalString(int precision, StringBuilder sb) { }

	// RVA: 0x18E93B0 Offset: 0x18E94B1 VA: 0x18E93B0
	private void AppendDecimalString(int precision) { }

	// RVA: 0x18E9130 Offset: 0x18E9231 VA: 0x18E9130
	private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) { }

	// RVA: 0x18E9A50 Offset: 0x18E9B51 VA: 0x18E9A50
	private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) { }

	// RVA: 0x18E9920 Offset: 0x18E9A21 VA: 0x18E9920
	private void AppendOneDigit(int start) { }

	// RVA: 0x18E93D0 Offset: 0x18E94D1 VA: 0x18E93D0
	private void AppendDigits(int start, int end) { }

	// RVA: 0x18EB1F0 Offset: 0x18EB2F1 VA: 0x18EB1F0
	private void AppendDigits(int start, int end, StringBuilder sb) { }

	// RVA: 0x18E9900 Offset: 0x18E9A01 VA: 0x18E9900
	private void Multiply10(int count) { }

	// RVA: 0x18EA460 Offset: 0x18EA561 VA: 0x18EA460
	private void Divide10(int count) { }

	// RVA: 0x18E9760 Offset: 0x18E9861 VA: 0x18E9760
	private NumberFormatter GetClone() { }
}

internal sealed class NumberFormatter // TypeDefIndex: 392
{
	// Fields
	private static readonly ulong* MantissaBitsTable; // 0x0
	private static readonly int* TensExponentTable; // 0x8
	private static readonly char* DigitLowerTable; // 0x10
	private static readonly char* DigitUpperTable; // 0x18
	private static readonly long* TenPowersList; // 0x20
	private static readonly int* DecHexDigits; // 0x28
	private NumberFormatInfo _nfi; // 0x10
	private char[] _cbuf; // 0x18
	private bool _NaN; // 0x20
	private bool _infinity; // 0x21
	private bool _isCustomFormat; // 0x22
	private bool _specifierIsUpper; // 0x23
	private bool _positive; // 0x24
	private char _specifier; // 0x26
	private int _precision; // 0x28
	private int _defPrecision; // 0x2C
	private int _digitsLen; // 0x30
	private int _offset; // 0x34
	private int _decPointPos; // 0x38
	private uint _val1; // 0x3C
	private uint _val2; // 0x40
	private uint _val3; // 0x44
	private uint _val4; // 0x48
	private int _ind; // 0x4C
	[ThreadStaticAttribute] // RVA: 0xB44F0 Offset: 0xB45F1 VA: 0xB44F0
	private static NumberFormatter threadNumberFormatter; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB4500 Offset: 0xB4601 VA: 0xB4500
	private static NumberFormatter userFormatProvider; // 0x80000008

	// Properties
	private CultureInfo CurrentCulture { set; }
	private int IntegerDigits { get; }
	private int DecimalDigits { get; }
	private bool IsFloatingSource { get; }
	private bool IsZero { get; }
	private bool IsZeroInteger { get; }

	// Methods

	// RVA: 0x18E4D50 Offset: 0x18E4E51 VA: 0x18E4D50
	private static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) { }

	// RVA: 0x18E4D60 Offset: 0x18E4E61 VA: 0x18E4D60
	private static void .cctor() { }

	// RVA: 0x18E4DC0 Offset: 0x18E4EC1 VA: 0x18E4DC0
	private static long GetTenPowerOf(int i) { }

	// RVA: 0x18E4E30 Offset: 0x18E4F31 VA: 0x18E4E30
	private void InitDecHexDigits(uint value) { }

	// RVA: 0x18E50B0 Offset: 0x18E51B1 VA: 0x18E50B0
	private void InitDecHexDigits(ulong value) { }

	// RVA: 0x18E51E0 Offset: 0x18E52E1 VA: 0x18E51E0
	private void InitDecHexDigits(uint hi, ulong lo) { }

	// RVA: 0x18E4F00 Offset: 0x18E5001 VA: 0x18E4F00
	private static uint FastToDecHex(int val) { }

	// RVA: 0x18E4FE0 Offset: 0x18E50E1 VA: 0x18E4FE0
	private static uint ToDecHex(int val) { }

	// RVA: 0x18E53D0 Offset: 0x18E54D1 VA: 0x18E53D0
	private static int FastDecHexLen(int val) { }

	// RVA: 0x18E5400 Offset: 0x18E5501 VA: 0x18E5400
	private static int DecHexLen(uint val) { }

	// RVA: 0x18E54F0 Offset: 0x18E55F1 VA: 0x18E54F0
	private int DecHexLen() { }

	// RVA: 0x18E5950 Offset: 0x18E5A51 VA: 0x18E5950
	private static int ScaleOrder(long hi) { }

	// RVA: 0x18E5A50 Offset: 0x18E5B51 VA: 0x18E5A50
	private int InitialFloatingPrecision() { }

	// RVA: 0x18E5B40 Offset: 0x18E5C41 VA: 0x18E5B40
	private static int ParsePrecision(string format) { }

	// RVA: 0x18E5BD0 Offset: 0x18E5CD1 VA: 0x18E5BD0
	private void .ctor(Thread current) { }

	// RVA: 0x18E5D30 Offset: 0x18E5E31 VA: 0x18E5D30
	private void Init(string format) { }

	// RVA: 0x18E5EB0 Offset: 0x18E5FB1 VA: 0x18E5EB0
	private void InitHex(ulong value) { }

	// RVA: 0x18E5F00 Offset: 0x18E6001 VA: 0x18E5F00
	private void Init(string format, int value, int defPrecision) { }

	// RVA: 0x18E5FB0 Offset: 0x18E60B1 VA: 0x18E5FB0
	private void Init(string format, uint value, int defPrecision) { }

	// RVA: 0x18E6050 Offset: 0x18E6151 VA: 0x18E6050
	private void Init(string format, long value) { }

	// RVA: 0x18E60F0 Offset: 0x18E61F1 VA: 0x18E60F0
	private void Init(string format, ulong value) { }

	// RVA: 0x18E6180 Offset: 0x18E6281 VA: 0x18E6180
	private void Init(string format, double value, int defPrecision) { }

	// RVA: 0x18E6810 Offset: 0x18E6911 VA: 0x18E6810
	private void Init(string format, Decimal value) { }

	// RVA: 0x18E6990 Offset: 0x18E6A91 VA: 0x18E6990
	private void ResetCharBuf(int size) { }

	// RVA: 0x18E6A30 Offset: 0x18E6B31 VA: 0x18E6A30
	private void Resize(int len) { }

	// RVA: 0x18E6A90 Offset: 0x18E6B91 VA: 0x18E6A90
	private void Append(char c) { }

	// RVA: 0x18E6B60 Offset: 0x18E6C61 VA: 0x18E6B60
	private void Append(char c, int cnt) { }

	// RVA: 0x18E6C50 Offset: 0x18E6D51 VA: 0x18E6C50
	private void Append(string s) { }

	// RVA: 0x18E6D50 Offset: 0x18E6E51 VA: 0x18E6D50
	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) { }

	// RVA: 0x18E5CC0 Offset: 0x18E5DC1 VA: 0x18E5CC0
	private void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x18E6D70 Offset: 0x18E6E71 VA: 0x18E6D70
	private int get_IntegerDigits() { }

	// RVA: 0x18E6D80 Offset: 0x18E6E81 VA: 0x18E6D80
	private int get_DecimalDigits() { }

	// RVA: 0x18E6DA0 Offset: 0x18E6EA1 VA: 0x18E6DA0
	private bool get_IsFloatingSource() { }

	// RVA: 0x18E6DC0 Offset: 0x18E6EC1 VA: 0x18E6DC0
	private bool get_IsZero() { }

	// RVA: 0x18E6DD0 Offset: 0x18E6ED1 VA: 0x18E6DD0
	private bool get_IsZeroInteger() { }

	// RVA: 0x18E6DF0 Offset: 0x18E6EF1 VA: 0x18E6DF0
	private void RoundPos(int pos) { }

	// RVA: 0x18E6FC0 Offset: 0x18E70C1 VA: 0x18E6FC0
	private bool RoundDecimal(int decimals) { }

	// RVA: 0x18E6E00 Offset: 0x18E6F01 VA: 0x18E6E00
	private bool RoundBits(int shift) { }

	// RVA: 0x18E73B0 Offset: 0x18E74B1 VA: 0x18E73B0
	private void RemoveTrailingZeros() { }

	// RVA: 0x18E6FE0 Offset: 0x18E70E1 VA: 0x18E6FE0
	private void AddOneToDecHex() { }

	// RVA: 0x18E7400 Offset: 0x18E7501 VA: 0x18E7400
	private static uint AddOneToDecHex(uint val) { }

	// RVA: 0x18E6550 Offset: 0x18E6651 VA: 0x18E6550
	private int CountTrailingZeros() { }

	// RVA: 0x18E74B0 Offset: 0x18E75B1 VA: 0x18E74B0
	private static int CountTrailingZeros(uint val) { }

	// RVA: 0x18E7500 Offset: 0x18E7601 VA: 0x18E7500
	private static NumberFormatter GetInstance(IFormatProvider fp) { }

	// RVA: 0x18E7710 Offset: 0x18E7811 VA: 0x18E7710
	private void Release() { }

	// RVA: 0x18E1EA0 Offset: 0x18E1FA1 VA: 0x18E1EA0
	public static string NumberToString(string format, uint value, IFormatProvider fp) { }

	// RVA: 0x18E1D90 Offset: 0x18E1E91 VA: 0x18E1D90
	public static string NumberToString(string format, int value, IFormatProvider fp) { }

	// RVA: 0x18E2150 Offset: 0x18E2251 VA: 0x18E2150
	public static string NumberToString(string format, ulong value, IFormatProvider fp) { }

	// RVA: 0x18E1FB0 Offset: 0x18E20B1 VA: 0x18E1FB0
	public static string NumberToString(string format, long value, IFormatProvider fp) { }

	// RVA: 0x18E22F0 Offset: 0x18E23F1 VA: 0x18E22F0
	public static string NumberToString(string format, float value, IFormatProvider fp) { }

	// RVA: 0x18E1C60 Offset: 0x18E1D61 VA: 0x18E1C60
	public static string NumberToString(string format, double value, IFormatProvider fp) { }

	// RVA: 0x18E1AF0 Offset: 0x18E1BF1 VA: 0x18E1AF0
	public static string NumberToString(string format, Decimal value, IFormatProvider fp) { }

	// RVA: 0x18E77D0 Offset: 0x18E78D1 VA: 0x18E77D0
	private string IntegerToString(string format, IFormatProvider fp) { }

	// RVA: 0x18E7AF0 Offset: 0x18E7BF1 VA: 0x18E7AF0
	private string NumberToString(string format, NumberFormatInfo nfi) { }

	// RVA: 0x18E7E30 Offset: 0x18E7F31 VA: 0x18E7E30
	private string FormatCurrency(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8110 Offset: 0x18E8211 VA: 0x18E8110
	private string FormatDecimal(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8990 Offset: 0x18E8A91 VA: 0x18E8990
	private string FormatHexadecimal(int precision) { }

	// RVA: 0x18E8290 Offset: 0x18E8391 VA: 0x18E8290
	private string FormatFixedPoint(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E7CC0 Offset: 0x18E7DC1 VA: 0x18E7CC0
	private string FormatRoundtrip(double origval, NumberFormatInfo nfi) { }

	// RVA: 0x18E7A10 Offset: 0x18E7B11 VA: 0x18E7A10
	private string FormatRoundtrip(float origval, NumberFormatInfo nfi) { }

	// RVA: 0x18E8410 Offset: 0x18E8511 VA: 0x18E8410
	private string FormatGeneral(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E85E0 Offset: 0x18E86E1 VA: 0x18E85E0
	private string FormatNumber(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E87C0 Offset: 0x18E88C1 VA: 0x18E87C0
	private string FormatPercent(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8230 Offset: 0x18E8331 VA: 0x18E8230
	private string FormatExponential(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E97D0 Offset: 0x18E98D1 VA: 0x18E97D0
	private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) { }

	// RVA: 0x18E8B50 Offset: 0x18E8C51 VA: 0x18E8B50
	private string FormatCustom(string format, NumberFormatInfo nfi) { }

	// RVA: 0x18EA840 Offset: 0x18EA941 VA: 0x18EA840
	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) { }

	// RVA: 0x18EA730 Offset: 0x18EA831 VA: 0x18EA730
	private static bool IsZeroOnly(StringBuilder sb) { }

	// RVA: 0x18EA480 Offset: 0x18EA581 VA: 0x18EA480
	private static void AppendNonNegativeNumber(StringBuilder sb, int v) { }

	// RVA: 0x18EA680 Offset: 0x18EA781 VA: 0x18EA680
	private void AppendIntegerString(int minLength, StringBuilder sb) { }

	// RVA: 0x18E96F0 Offset: 0x18E97F1 VA: 0x18E96F0
	private void AppendIntegerString(int minLength) { }

	// RVA: 0x18EA710 Offset: 0x18EA811 VA: 0x18EA710
	private void AppendDecimalString(int precision, StringBuilder sb) { }

	// RVA: 0x18E93B0 Offset: 0x18E94B1 VA: 0x18E93B0
	private void AppendDecimalString(int precision) { }

	// RVA: 0x18E9130 Offset: 0x18E9231 VA: 0x18E9130
	private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) { }

	// RVA: 0x18E9A50 Offset: 0x18E9B51 VA: 0x18E9A50
	private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) { }

	// RVA: 0x18E9920 Offset: 0x18E9A21 VA: 0x18E9920
	private void AppendOneDigit(int start) { }

	// RVA: 0x18E93D0 Offset: 0x18E94D1 VA: 0x18E93D0
	private void AppendDigits(int start, int end) { }

	// RVA: 0x18EB1F0 Offset: 0x18EB2F1 VA: 0x18EB1F0
	private void AppendDigits(int start, int end, StringBuilder sb) { }

	// RVA: 0x18E9900 Offset: 0x18E9A01 VA: 0x18E9900
	private void Multiply10(int count) { }

	// RVA: 0x18EA460 Offset: 0x18EA561 VA: 0x18EA460
	private void Divide10(int count) { }

	// RVA: 0x18E9760 Offset: 0x18E9861 VA: 0x18E9760
	private NumberFormatter GetClone() { }
}

internal sealed class NumberFormatter // TypeDefIndex: 392
{
	// Fields
	private static readonly ulong* MantissaBitsTable; // 0x0
	private static readonly int* TensExponentTable; // 0x8
	private static readonly char* DigitLowerTable; // 0x10
	private static readonly char* DigitUpperTable; // 0x18
	private static readonly long* TenPowersList; // 0x20
	private static readonly int* DecHexDigits; // 0x28
	private NumberFormatInfo _nfi; // 0x10
	private char[] _cbuf; // 0x18
	private bool _NaN; // 0x20
	private bool _infinity; // 0x21
	private bool _isCustomFormat; // 0x22
	private bool _specifierIsUpper; // 0x23
	private bool _positive; // 0x24
	private char _specifier; // 0x26
	private int _precision; // 0x28
	private int _defPrecision; // 0x2C
	private int _digitsLen; // 0x30
	private int _offset; // 0x34
	private int _decPointPos; // 0x38
	private uint _val1; // 0x3C
	private uint _val2; // 0x40
	private uint _val3; // 0x44
	private uint _val4; // 0x48
	private int _ind; // 0x4C
	[ThreadStaticAttribute] // RVA: 0xB44F0 Offset: 0xB45F1 VA: 0xB44F0
	private static NumberFormatter threadNumberFormatter; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0xB4500 Offset: 0xB4601 VA: 0xB4500
	private static NumberFormatter userFormatProvider; // 0x80000008

	// Properties
	private CultureInfo CurrentCulture { set; }
	private int IntegerDigits { get; }
	private int DecimalDigits { get; }
	private bool IsFloatingSource { get; }
	private bool IsZero { get; }
	private bool IsZeroInteger { get; }

	// Methods

	// RVA: 0x18E4D50 Offset: 0x18E4E51 VA: 0x18E4D50
	private static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) { }

	// RVA: 0x18E4D60 Offset: 0x18E4E61 VA: 0x18E4D60
	private static void .cctor() { }

	// RVA: 0x18E4DC0 Offset: 0x18E4EC1 VA: 0x18E4DC0
	private static long GetTenPowerOf(int i) { }

	// RVA: 0x18E4E30 Offset: 0x18E4F31 VA: 0x18E4E30
	private void InitDecHexDigits(uint value) { }

	// RVA: 0x18E50B0 Offset: 0x18E51B1 VA: 0x18E50B0
	private void InitDecHexDigits(ulong value) { }

	// RVA: 0x18E51E0 Offset: 0x18E52E1 VA: 0x18E51E0
	private void InitDecHexDigits(uint hi, ulong lo) { }

	// RVA: 0x18E4F00 Offset: 0x18E5001 VA: 0x18E4F00
	private static uint FastToDecHex(int val) { }

	// RVA: 0x18E4FE0 Offset: 0x18E50E1 VA: 0x18E4FE0
	private static uint ToDecHex(int val) { }

	// RVA: 0x18E53D0 Offset: 0x18E54D1 VA: 0x18E53D0
	private static int FastDecHexLen(int val) { }

	// RVA: 0x18E5400 Offset: 0x18E5501 VA: 0x18E5400
	private static int DecHexLen(uint val) { }

	// RVA: 0x18E54F0 Offset: 0x18E55F1 VA: 0x18E54F0
	private int DecHexLen() { }

	// RVA: 0x18E5950 Offset: 0x18E5A51 VA: 0x18E5950
	private static int ScaleOrder(long hi) { }

	// RVA: 0x18E5A50 Offset: 0x18E5B51 VA: 0x18E5A50
	private int InitialFloatingPrecision() { }

	// RVA: 0x18E5B40 Offset: 0x18E5C41 VA: 0x18E5B40
	private static int ParsePrecision(string format) { }

	// RVA: 0x18E5BD0 Offset: 0x18E5CD1 VA: 0x18E5BD0
	private void .ctor(Thread current) { }

	// RVA: 0x18E5D30 Offset: 0x18E5E31 VA: 0x18E5D30
	private void Init(string format) { }

	// RVA: 0x18E5EB0 Offset: 0x18E5FB1 VA: 0x18E5EB0
	private void InitHex(ulong value) { }

	// RVA: 0x18E5F00 Offset: 0x18E6001 VA: 0x18E5F00
	private void Init(string format, int value, int defPrecision) { }

	// RVA: 0x18E5FB0 Offset: 0x18E60B1 VA: 0x18E5FB0
	private void Init(string format, uint value, int defPrecision) { }

	// RVA: 0x18E6050 Offset: 0x18E6151 VA: 0x18E6050
	private void Init(string format, long value) { }

	// RVA: 0x18E60F0 Offset: 0x18E61F1 VA: 0x18E60F0
	private void Init(string format, ulong value) { }

	// RVA: 0x18E6180 Offset: 0x18E6281 VA: 0x18E6180
	private void Init(string format, double value, int defPrecision) { }

	// RVA: 0x18E6810 Offset: 0x18E6911 VA: 0x18E6810
	private void Init(string format, Decimal value) { }

	// RVA: 0x18E6990 Offset: 0x18E6A91 VA: 0x18E6990
	private void ResetCharBuf(int size) { }

	// RVA: 0x18E6A30 Offset: 0x18E6B31 VA: 0x18E6A30
	private void Resize(int len) { }

	// RVA: 0x18E6A90 Offset: 0x18E6B91 VA: 0x18E6A90
	private void Append(char c) { }

	// RVA: 0x18E6B60 Offset: 0x18E6C61 VA: 0x18E6B60
	private void Append(char c, int cnt) { }

	// RVA: 0x18E6C50 Offset: 0x18E6D51 VA: 0x18E6C50
	private void Append(string s) { }

	// RVA: 0x18E6D50 Offset: 0x18E6E51 VA: 0x18E6D50
	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) { }

	// RVA: 0x18E5CC0 Offset: 0x18E5DC1 VA: 0x18E5CC0
	private void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x18E6D70 Offset: 0x18E6E71 VA: 0x18E6D70
	private int get_IntegerDigits() { }

	// RVA: 0x18E6D80 Offset: 0x18E6E81 VA: 0x18E6D80
	private int get_DecimalDigits() { }

	// RVA: 0x18E6DA0 Offset: 0x18E6EA1 VA: 0x18E6DA0
	private bool get_IsFloatingSource() { }

	// RVA: 0x18E6DC0 Offset: 0x18E6EC1 VA: 0x18E6DC0
	private bool get_IsZero() { }

	// RVA: 0x18E6DD0 Offset: 0x18E6ED1 VA: 0x18E6DD0
	private bool get_IsZeroInteger() { }

	// RVA: 0x18E6DF0 Offset: 0x18E6EF1 VA: 0x18E6DF0
	private void RoundPos(int pos) { }

	// RVA: 0x18E6FC0 Offset: 0x18E70C1 VA: 0x18E6FC0
	private bool RoundDecimal(int decimals) { }

	// RVA: 0x18E6E00 Offset: 0x18E6F01 VA: 0x18E6E00
	private bool RoundBits(int shift) { }

	// RVA: 0x18E73B0 Offset: 0x18E74B1 VA: 0x18E73B0
	private void RemoveTrailingZeros() { }

	// RVA: 0x18E6FE0 Offset: 0x18E70E1 VA: 0x18E6FE0
	private void AddOneToDecHex() { }

	// RVA: 0x18E7400 Offset: 0x18E7501 VA: 0x18E7400
	private static uint AddOneToDecHex(uint val) { }

	// RVA: 0x18E6550 Offset: 0x18E6651 VA: 0x18E6550
	private int CountTrailingZeros() { }

	// RVA: 0x18E74B0 Offset: 0x18E75B1 VA: 0x18E74B0
	private static int CountTrailingZeros(uint val) { }

	// RVA: 0x18E7500 Offset: 0x18E7601 VA: 0x18E7500
	private static NumberFormatter GetInstance(IFormatProvider fp) { }

	// RVA: 0x18E7710 Offset: 0x18E7811 VA: 0x18E7710
	private void Release() { }

	// RVA: 0x18E1EA0 Offset: 0x18E1FA1 VA: 0x18E1EA0
	public static string NumberToString(string format, uint value, IFormatProvider fp) { }

	// RVA: 0x18E1D90 Offset: 0x18E1E91 VA: 0x18E1D90
	public static string NumberToString(string format, int value, IFormatProvider fp) { }

	// RVA: 0x18E2150 Offset: 0x18E2251 VA: 0x18E2150
	public static string NumberToString(string format, ulong value, IFormatProvider fp) { }

	// RVA: 0x18E1FB0 Offset: 0x18E20B1 VA: 0x18E1FB0
	public static string NumberToString(string format, long value, IFormatProvider fp) { }

	// RVA: 0x18E22F0 Offset: 0x18E23F1 VA: 0x18E22F0
	public static string NumberToString(string format, float value, IFormatProvider fp) { }

	// RVA: 0x18E1C60 Offset: 0x18E1D61 VA: 0x18E1C60
	public static string NumberToString(string format, double value, IFormatProvider fp) { }

	// RVA: 0x18E1AF0 Offset: 0x18E1BF1 VA: 0x18E1AF0
	public static string NumberToString(string format, Decimal value, IFormatProvider fp) { }

	// RVA: 0x18E77D0 Offset: 0x18E78D1 VA: 0x18E77D0
	private string IntegerToString(string format, IFormatProvider fp) { }

	// RVA: 0x18E7AF0 Offset: 0x18E7BF1 VA: 0x18E7AF0
	private string NumberToString(string format, NumberFormatInfo nfi) { }

	// RVA: 0x18E7E30 Offset: 0x18E7F31 VA: 0x18E7E30
	private string FormatCurrency(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8110 Offset: 0x18E8211 VA: 0x18E8110
	private string FormatDecimal(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8990 Offset: 0x18E8A91 VA: 0x18E8990
	private string FormatHexadecimal(int precision) { }

	// RVA: 0x18E8290 Offset: 0x18E8391 VA: 0x18E8290
	private string FormatFixedPoint(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E7CC0 Offset: 0x18E7DC1 VA: 0x18E7CC0
	private string FormatRoundtrip(double origval, NumberFormatInfo nfi) { }

	// RVA: 0x18E7A10 Offset: 0x18E7B11 VA: 0x18E7A10
	private string FormatRoundtrip(float origval, NumberFormatInfo nfi) { }

	// RVA: 0x18E8410 Offset: 0x18E8511 VA: 0x18E8410
	private string FormatGeneral(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E85E0 Offset: 0x18E86E1 VA: 0x18E85E0
	private string FormatNumber(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E87C0 Offset: 0x18E88C1 VA: 0x18E87C0
	private string FormatPercent(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E8230 Offset: 0x18E8331 VA: 0x18E8230
	private string FormatExponential(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x18E97D0 Offset: 0x18E98D1 VA: 0x18E97D0
	private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) { }

	// RVA: 0x18E8B50 Offset: 0x18E8C51 VA: 0x18E8B50
	private string FormatCustom(string format, NumberFormatInfo nfi) { }

	// RVA: 0x18EA840 Offset: 0x18EA941 VA: 0x18EA840
	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) { }

	// RVA: 0x18EA730 Offset: 0x18EA831 VA: 0x18EA730
	private static bool IsZeroOnly(StringBuilder sb) { }

	// RVA: 0x18EA480 Offset: 0x18EA581 VA: 0x18EA480
	private static void AppendNonNegativeNumber(StringBuilder sb, int v) { }

	// RVA: 0x18EA680 Offset: 0x18EA781 VA: 0x18EA680
	private void AppendIntegerString(int minLength, StringBuilder sb) { }

	// RVA: 0x18E96F0 Offset: 0x18E97F1 VA: 0x18E96F0
	private void AppendIntegerString(int minLength) { }

	// RVA: 0x18EA710 Offset: 0x18EA811 VA: 0x18EA710
	private void AppendDecimalString(int precision, StringBuilder sb) { }

	// RVA: 0x18E93B0 Offset: 0x18E94B1 VA: 0x18E93B0
	private void AppendDecimalString(int precision) { }

	// RVA: 0x18E9130 Offset: 0x18E9231 VA: 0x18E9130
	private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) { }

	// RVA: 0x18E9A50 Offset: 0x18E9B51 VA: 0x18E9A50
	private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) { }

	// RVA: 0x18E9920 Offset: 0x18E9A21 VA: 0x18E9920
	private void AppendOneDigit(int start) { }

	// RVA: 0x18E93D0 Offset: 0x18E94D1 VA: 0x18E93D0
	private void AppendDigits(int start, int end) { }

	// RVA: 0x18EB1F0 Offset: 0x18EB2F1 VA: 0x18EB1F0
	private void AppendDigits(int start, int end, StringBuilder sb) { }

	// RVA: 0x18E9900 Offset: 0x18E9A01 VA: 0x18E9900
	private void Multiply10(int count) { }

	// RVA: 0x18EA460 Offset: 0x18EA561 VA: 0x18EA460
	private void Divide10(int count) { }

	// RVA: 0x18E9760 Offset: 0x18E9861 VA: 0x18E9760
	private NumberFormatter GetClone() { }
}

