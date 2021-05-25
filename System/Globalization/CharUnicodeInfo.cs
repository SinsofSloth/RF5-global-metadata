public static class CharUnicodeInfo // TypeDefIndex: 700
{
	// Fields
	private static ushort[] s_pCategoryLevel1Index; // 0x0
	private static byte[] s_pCategoriesValue; // 0x8
	private static ushort[] s_pNumericLevel1Index; // 0x10
	private static byte[] s_pNumericValues; // 0x18
	private static ushort[] s_pDigitValues; // 0x20

	// Methods

	// RVA: 0x17A37C0 Offset: 0x17A38C1 VA: 0x17A37C0
	internal static int InternalConvertToUtf32(string s, int index) { }

	// RVA: 0x17A38A0 Offset: 0x17A39A1 VA: 0x17A38A0
	internal static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x17A3A20 Offset: 0x17A3B21 VA: 0x17A3A20
	internal static bool IsWhiteSpace(char c) { }

	// RVA: 0x17A3B70 Offset: 0x17A3C71 VA: 0x17A3B70
	internal static double InternalGetNumericValue(int ch) { }

	// RVA: 0x17A3C50 Offset: 0x17A3D51 VA: 0x17A3C50
	public static double GetNumericValue(string s, int index) { }

	// RVA: 0x17A3AA0 Offset: 0x17A3BA1 VA: 0x17A3AA0
	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	// RVA: 0x17A3930 Offset: 0x17A3A31 VA: 0x17A3930
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x17A3D50 Offset: 0x17A3E51 VA: 0x17A3D50
	internal static UnicodeCategory InternalGetUnicodeCategory(int ch) { }

	// RVA: 0x17A3E90 Offset: 0x17A3F91 VA: 0x17A3E90
	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	// RVA: 0x17A3DC0 Offset: 0x17A3EC1 VA: 0x17A3DC0
	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	// RVA: 0x17A3F90 Offset: 0x17A4091 VA: 0x17A3F90
	private static void .cctor() { }
}

