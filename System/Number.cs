[FriendAccessAllowedAttribute] // RVA: 0xAC470 Offset: 0xAC571 VA: 0xAC470
internal class Number // TypeDefIndex: 287
{
	// Methods

	// RVA: 0x18E1A40 Offset: 0x18E1B41 VA: 0x18E1A40
	public static bool NumberBufferToDecimal(byte* number, ref Decimal value) { }

	// RVA: 0x18E1A50 Offset: 0x18E1B51 VA: 0x18E1A50
	internal static bool NumberBufferToDouble(byte* number, ref double value) { }

	// RVA: 0x18E1A60 Offset: 0x18E1B61 VA: 0x18E1A60
	public static string FormatDecimal(Decimal value, string format, NumberFormatInfo info) { }

	// RVA: 0x18E1BD0 Offset: 0x18E1CD1 VA: 0x18E1BD0
	public static string FormatDouble(double value, string format, NumberFormatInfo info) { }

	// RVA: 0x18D7320 Offset: 0x18D7421 VA: 0x18D7320
	public static string FormatInt32(int value, string format, NumberFormatInfo info) { }

	// RVA: 0x18D75B0 Offset: 0x18D76B1 VA: 0x18D75B0
	public static string FormatUInt32(uint value, string format, NumberFormatInfo info) { }

	// RVA: 0x18D93B0 Offset: 0x18D94B1 VA: 0x18D93B0
	public static string FormatInt64(long value, string format, NumberFormatInfo info) { }

	// RVA: 0x18E20D0 Offset: 0x18E21D1 VA: 0x18E20D0
	public static string FormatUInt64(ulong value, string format, NumberFormatInfo info) { }

	// RVA: 0x18E2260 Offset: 0x18E2361 VA: 0x18E2260
	public static string FormatSingle(float value, string format, NumberFormatInfo info) { }

	// RVA: 0x18E2420 Offset: 0x18E2521 VA: 0x18E2420
	private static bool HexNumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	// RVA: 0x18E2580 Offset: 0x18E2681 VA: 0x18E2580
	private static bool HexNumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	// RVA: 0x18E24D0 Offset: 0x18E25D1 VA: 0x18E24D0
	private static bool HexNumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	// RVA: 0x18E2630 Offset: 0x18E2731 VA: 0x18E2630
	private static bool HexNumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	// RVA: 0x18E26E0 Offset: 0x18E27E1 VA: 0x18E26E0
	private static bool IsWhite(char ch) { }

	// RVA: 0x18E2710 Offset: 0x18E2811 VA: 0x18E2710
	private static bool NumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	// RVA: 0x18E27B0 Offset: 0x18E28B1 VA: 0x18E27B0
	private static bool NumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	// RVA: 0x18E2870 Offset: 0x18E2971 VA: 0x18E2870
	private static bool NumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	// RVA: 0x18E2910 Offset: 0x18E2A11 VA: 0x18E2910
	private static bool NumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	// RVA: 0x18E29B0 Offset: 0x18E2AB1 VA: 0x18E29B0
	private static char* MatchChars(char* p, string str) { }

	// RVA: 0x18E2A30 Offset: 0x18E2B31 VA: 0x18E2A30
	private static char* MatchChars(char* p, char* str) { }

	// RVA: 0x18E2A80 Offset: 0x18E2B81 VA: 0x18E2A80
	internal static Decimal ParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x18E2DB0 Offset: 0x18E2EB1 VA: 0x18E2DB0
	internal static double ParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x18D7830 Offset: 0x18D7931 VA: 0x18D7830
	internal static int ParseInt32(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x18D9610 Offset: 0x18D9711 VA: 0x18D9610
	internal static long ParseInt64(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x18E3150 Offset: 0x18E3251 VA: 0x18E3150
	private static bool ParseNumber(ref char* str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x18E3B00 Offset: 0x18E3C01 VA: 0x18E3B00
	internal static float ParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x18E3DD0 Offset: 0x18E3ED1 VA: 0x18E3DD0
	internal static uint ParseUInt32(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x18E3FE0 Offset: 0x18E40E1 VA: 0x18E3FE0
	internal static ulong ParseUInt64(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x18E2C00 Offset: 0x18E2D01 VA: 0x18E2C00
	private static void StringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	// RVA: 0x18E4200 Offset: 0x18E4301 VA: 0x18E4200
	private static bool TrailingZeros(string s, int index) { }

	// RVA: 0x18E4270 Offset: 0x18E4371 VA: 0x18E4270
	internal static bool TryParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt, out Decimal result) { }

	// RVA: 0x18E4400 Offset: 0x18E4501 VA: 0x18E4400
	internal static bool TryParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt, out double result) { }

	// RVA: 0x18D8770 Offset: 0x18D8871 VA: 0x18D8770
	internal static bool TryParseInt32(string s, NumberStyles style, NumberFormatInfo info, out int result) { }

	// RVA: 0x18D9910 Offset: 0x18D9A11 VA: 0x18D9910
	internal static bool TryParseInt64(string s, NumberStyles style, NumberFormatInfo info, out long result) { }

	// RVA: 0x18E4590 Offset: 0x18E4691 VA: 0x18E4590
	internal static bool TryParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt, out float result) { }

	// RVA: 0x18E4750 Offset: 0x18E4851 VA: 0x18E4750
	internal static bool TryParseUInt32(string s, NumberStyles style, NumberFormatInfo info, out uint result) { }

	// RVA: 0x18E49B0 Offset: 0x18E4AB1 VA: 0x18E49B0
	internal static bool TryParseUInt64(string s, NumberStyles style, NumberFormatInfo info, out ulong result) { }

	// RVA: 0x18E3070 Offset: 0x18E3171 VA: 0x18E3070
	internal static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo numfmt, bool parseDecimal) { }

	[FriendAccessAllowedAttribute] // RVA: 0xB6C10 Offset: 0xB6D11 VA: 0xB6C10
	// RVA: 0x18E4C10 Offset: 0x18E4D11 VA: 0x18E4C10
	internal static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }
}

internal static class Number // TypeDefIndex: 4375
{
	// Fields
	private static readonly ulong[] s_rgval64Power10; // 0x0
	private static readonly sbyte[] s_rgexp64Power10; // 0x8
	private static readonly ulong[] s_rgval64Power10By16; // 0x10
	private static readonly short[] s_rgexp64Power10By16; // 0x18

	// Methods

	// RVA: 0x1B67880 Offset: 0x1B67981 VA: 0x1B67880
	public static void RoundNumber(ref NumberBuffer number, int pos) { }

	// RVA: 0x1B68E90 Offset: 0x1B68F91 VA: 0x1B68E90
	public static bool NumberBufferToDecimal(ref NumberBuffer number, ref Decimal value) { }

	// RVA: 0x1B67070 Offset: 0x1B67171 VA: 0x1B67070
	public static void DecimalToNumber(Decimal value, ref NumberBuffer number) { }

	// RVA: 0x1B69CF0 Offset: 0x1B69DF1 VA: 0x1B69CF0
	private static void .cctor() { }
}

