internal class MSCompatUnicodeTable // TypeDefIndex: 34
{
	// Fields
	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x192DAE0 Offset: 0x192DBE1 VA: 0x192DAE0
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x192DC20 Offset: 0x192DD21 VA: 0x192DC20
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x192E2F0 Offset: 0x192E3F1 VA: 0x192E2F0
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x192E5B0 Offset: 0x192E6B1 VA: 0x192E5B0
	public static byte Category(int cp) { }

	// RVA: 0x192E6C0 Offset: 0x192E7C1 VA: 0x192E6C0
	public static byte Level1(int cp) { }

	// RVA: 0x192E7D0 Offset: 0x192E8D1 VA: 0x192E7D0
	public static byte Level2(int cp) { }

	// RVA: 0x192E8E0 Offset: 0x192E9E1 VA: 0x192E8E0
	public static byte Level3(int cp) { }

	// RVA: 0x192E9F0 Offset: 0x192EAF1 VA: 0x192E9F0
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x192EB80 Offset: 0x192EC81 VA: 0x192EB80
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x192EBF0 Offset: 0x192ECF1 VA: 0x192EBF0
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x192EC10 Offset: 0x192ED11 VA: 0x192EC10
	public static int ToWidthCompat(int i) { }

	// RVA: 0x192EDD0 Offset: 0x192EED1 VA: 0x192EDD0
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x192EE70 Offset: 0x192EF71 VA: 0x192EE70
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x192EE90 Offset: 0x192EF91 VA: 0x192EE90
	public static bool IsHiragana(char c) { }

	// RVA: 0x192EEB0 Offset: 0x192EFB1 VA: 0x192EEB0
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x192EFC0 Offset: 0x192F0C1 VA: 0x192EFC0
	public static bool get_IsReady() { }

	// RVA: 0x192F030 Offset: 0x192F131 VA: 0x192F030
	private static IntPtr GetResource(string name) { }

	// RVA: 0x192F0B0 Offset: 0x192F1B1 VA: 0x192F0B0
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x192F0E0 Offset: 0x192F1E1 VA: 0x192F0E0
	private static void .cctor() { }

	// RVA: 0x192F630 Offset: 0x192F731 VA: 0x192F630
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x192F7A0 Offset: 0x192F8A1 VA: 0x192F7A0
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }
}

internal class MSCompatUnicodeTable // TypeDefIndex: 34
{
	// Fields
	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x192DAE0 Offset: 0x192DBE1 VA: 0x192DAE0
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x192DC20 Offset: 0x192DD21 VA: 0x192DC20
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x192E2F0 Offset: 0x192E3F1 VA: 0x192E2F0
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x192E5B0 Offset: 0x192E6B1 VA: 0x192E5B0
	public static byte Category(int cp) { }

	// RVA: 0x192E6C0 Offset: 0x192E7C1 VA: 0x192E6C0
	public static byte Level1(int cp) { }

	// RVA: 0x192E7D0 Offset: 0x192E8D1 VA: 0x192E7D0
	public static byte Level2(int cp) { }

	// RVA: 0x192E8E0 Offset: 0x192E9E1 VA: 0x192E8E0
	public static byte Level3(int cp) { }

	// RVA: 0x192E9F0 Offset: 0x192EAF1 VA: 0x192E9F0
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x192EB80 Offset: 0x192EC81 VA: 0x192EB80
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x192EBF0 Offset: 0x192ECF1 VA: 0x192EBF0
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x192EC10 Offset: 0x192ED11 VA: 0x192EC10
	public static int ToWidthCompat(int i) { }

	// RVA: 0x192EDD0 Offset: 0x192EED1 VA: 0x192EDD0
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x192EE70 Offset: 0x192EF71 VA: 0x192EE70
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x192EE90 Offset: 0x192EF91 VA: 0x192EE90
	public static bool IsHiragana(char c) { }

	// RVA: 0x192EEB0 Offset: 0x192EFB1 VA: 0x192EEB0
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x192EFC0 Offset: 0x192F0C1 VA: 0x192EFC0
	public static bool get_IsReady() { }

	// RVA: 0x192F030 Offset: 0x192F131 VA: 0x192F030
	private static IntPtr GetResource(string name) { }

	// RVA: 0x192F0B0 Offset: 0x192F1B1 VA: 0x192F0B0
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x192F0E0 Offset: 0x192F1E1 VA: 0x192F0E0
	private static void .cctor() { }

	// RVA: 0x192F630 Offset: 0x192F731 VA: 0x192F630
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x192F7A0 Offset: 0x192F8A1 VA: 0x192F7A0
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }
}

internal class MSCompatUnicodeTable // TypeDefIndex: 34
{
	// Fields
	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x192DAE0 Offset: 0x192DBE1 VA: 0x192DAE0
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x192DC20 Offset: 0x192DD21 VA: 0x192DC20
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x192E2F0 Offset: 0x192E3F1 VA: 0x192E2F0
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x192E5B0 Offset: 0x192E6B1 VA: 0x192E5B0
	public static byte Category(int cp) { }

	// RVA: 0x192E6C0 Offset: 0x192E7C1 VA: 0x192E6C0
	public static byte Level1(int cp) { }

	// RVA: 0x192E7D0 Offset: 0x192E8D1 VA: 0x192E7D0
	public static byte Level2(int cp) { }

	// RVA: 0x192E8E0 Offset: 0x192E9E1 VA: 0x192E8E0
	public static byte Level3(int cp) { }

	// RVA: 0x192E9F0 Offset: 0x192EAF1 VA: 0x192E9F0
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x192EB80 Offset: 0x192EC81 VA: 0x192EB80
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x192EBF0 Offset: 0x192ECF1 VA: 0x192EBF0
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x192EC10 Offset: 0x192ED11 VA: 0x192EC10
	public static int ToWidthCompat(int i) { }

	// RVA: 0x192EDD0 Offset: 0x192EED1 VA: 0x192EDD0
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x192EE70 Offset: 0x192EF71 VA: 0x192EE70
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x192EE90 Offset: 0x192EF91 VA: 0x192EE90
	public static bool IsHiragana(char c) { }

	// RVA: 0x192EEB0 Offset: 0x192EFB1 VA: 0x192EEB0
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x192EFC0 Offset: 0x192F0C1 VA: 0x192EFC0
	public static bool get_IsReady() { }

	// RVA: 0x192F030 Offset: 0x192F131 VA: 0x192F030
	private static IntPtr GetResource(string name) { }

	// RVA: 0x192F0B0 Offset: 0x192F1B1 VA: 0x192F0B0
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x192F0E0 Offset: 0x192F1E1 VA: 0x192F0E0
	private static void .cctor() { }

	// RVA: 0x192F630 Offset: 0x192F731 VA: 0x192F630
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x192F7A0 Offset: 0x192F8A1 VA: 0x192F7A0
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }
}

internal class MSCompatUnicodeTable // TypeDefIndex: 34
{
	// Fields
	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x192DAE0 Offset: 0x192DBE1 VA: 0x192DAE0
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x192DC20 Offset: 0x192DD21 VA: 0x192DC20
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x192E2F0 Offset: 0x192E3F1 VA: 0x192E2F0
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x192E5B0 Offset: 0x192E6B1 VA: 0x192E5B0
	public static byte Category(int cp) { }

	// RVA: 0x192E6C0 Offset: 0x192E7C1 VA: 0x192E6C0
	public static byte Level1(int cp) { }

	// RVA: 0x192E7D0 Offset: 0x192E8D1 VA: 0x192E7D0
	public static byte Level2(int cp) { }

	// RVA: 0x192E8E0 Offset: 0x192E9E1 VA: 0x192E8E0
	public static byte Level3(int cp) { }

	// RVA: 0x192E9F0 Offset: 0x192EAF1 VA: 0x192E9F0
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x192EB80 Offset: 0x192EC81 VA: 0x192EB80
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x192EBF0 Offset: 0x192ECF1 VA: 0x192EBF0
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x192EC10 Offset: 0x192ED11 VA: 0x192EC10
	public static int ToWidthCompat(int i) { }

	// RVA: 0x192EDD0 Offset: 0x192EED1 VA: 0x192EDD0
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x192EE70 Offset: 0x192EF71 VA: 0x192EE70
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x192EE90 Offset: 0x192EF91 VA: 0x192EE90
	public static bool IsHiragana(char c) { }

	// RVA: 0x192EEB0 Offset: 0x192EFB1 VA: 0x192EEB0
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x192EFC0 Offset: 0x192F0C1 VA: 0x192EFC0
	public static bool get_IsReady() { }

	// RVA: 0x192F030 Offset: 0x192F131 VA: 0x192F030
	private static IntPtr GetResource(string name) { }

	// RVA: 0x192F0B0 Offset: 0x192F1B1 VA: 0x192F0B0
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x192F0E0 Offset: 0x192F1E1 VA: 0x192F0E0
	private static void .cctor() { }

	// RVA: 0x192F630 Offset: 0x192F731 VA: 0x192F630
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x192F7A0 Offset: 0x192F8A1 VA: 0x192F7A0
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }
}

internal class MSCompatUnicodeTable // TypeDefIndex: 34
{
	// Fields
	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x192DAE0 Offset: 0x192DBE1 VA: 0x192DAE0
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x192DC20 Offset: 0x192DD21 VA: 0x192DC20
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x192E2F0 Offset: 0x192E3F1 VA: 0x192E2F0
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x192E5B0 Offset: 0x192E6B1 VA: 0x192E5B0
	public static byte Category(int cp) { }

	// RVA: 0x192E6C0 Offset: 0x192E7C1 VA: 0x192E6C0
	public static byte Level1(int cp) { }

	// RVA: 0x192E7D0 Offset: 0x192E8D1 VA: 0x192E7D0
	public static byte Level2(int cp) { }

	// RVA: 0x192E8E0 Offset: 0x192E9E1 VA: 0x192E8E0
	public static byte Level3(int cp) { }

	// RVA: 0x192E9F0 Offset: 0x192EAF1 VA: 0x192E9F0
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x192EB80 Offset: 0x192EC81 VA: 0x192EB80
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x192EBF0 Offset: 0x192ECF1 VA: 0x192EBF0
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x192EC10 Offset: 0x192ED11 VA: 0x192EC10
	public static int ToWidthCompat(int i) { }

	// RVA: 0x192EDD0 Offset: 0x192EED1 VA: 0x192EDD0
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x192EE70 Offset: 0x192EF71 VA: 0x192EE70
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x192EE90 Offset: 0x192EF91 VA: 0x192EE90
	public static bool IsHiragana(char c) { }

	// RVA: 0x192EEB0 Offset: 0x192EFB1 VA: 0x192EEB0
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x192EFC0 Offset: 0x192F0C1 VA: 0x192EFC0
	public static bool get_IsReady() { }

	// RVA: 0x192F030 Offset: 0x192F131 VA: 0x192F030
	private static IntPtr GetResource(string name) { }

	// RVA: 0x192F0B0 Offset: 0x192F1B1 VA: 0x192F0B0
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x192F0E0 Offset: 0x192F1E1 VA: 0x192F0E0
	private static void .cctor() { }

	// RVA: 0x192F630 Offset: 0x192F731 VA: 0x192F630
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x192F7A0 Offset: 0x192F8A1 VA: 0x192F7A0
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }
}

internal class MSCompatUnicodeTable // TypeDefIndex: 34
{
	// Fields
	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x192DAE0 Offset: 0x192DBE1 VA: 0x192DAE0
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x192DC20 Offset: 0x192DD21 VA: 0x192DC20
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x192E2F0 Offset: 0x192E3F1 VA: 0x192E2F0
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x192E5B0 Offset: 0x192E6B1 VA: 0x192E5B0
	public static byte Category(int cp) { }

	// RVA: 0x192E6C0 Offset: 0x192E7C1 VA: 0x192E6C0
	public static byte Level1(int cp) { }

	// RVA: 0x192E7D0 Offset: 0x192E8D1 VA: 0x192E7D0
	public static byte Level2(int cp) { }

	// RVA: 0x192E8E0 Offset: 0x192E9E1 VA: 0x192E8E0
	public static byte Level3(int cp) { }

	// RVA: 0x192E9F0 Offset: 0x192EAF1 VA: 0x192E9F0
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x192EB80 Offset: 0x192EC81 VA: 0x192EB80
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x192EBF0 Offset: 0x192ECF1 VA: 0x192EBF0
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x192EC10 Offset: 0x192ED11 VA: 0x192EC10
	public static int ToWidthCompat(int i) { }

	// RVA: 0x192EDD0 Offset: 0x192EED1 VA: 0x192EDD0
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x192EE70 Offset: 0x192EF71 VA: 0x192EE70
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x192EE90 Offset: 0x192EF91 VA: 0x192EE90
	public static bool IsHiragana(char c) { }

	// RVA: 0x192EEB0 Offset: 0x192EFB1 VA: 0x192EEB0
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x192EFC0 Offset: 0x192F0C1 VA: 0x192EFC0
	public static bool get_IsReady() { }

	// RVA: 0x192F030 Offset: 0x192F131 VA: 0x192F030
	private static IntPtr GetResource(string name) { }

	// RVA: 0x192F0B0 Offset: 0x192F1B1 VA: 0x192F0B0
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x192F0E0 Offset: 0x192F1E1 VA: 0x192F0E0
	private static void .cctor() { }

	// RVA: 0x192F630 Offset: 0x192F731 VA: 0x192F630
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x192F7A0 Offset: 0x192F8A1 VA: 0x192F7A0
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }
}

internal class MSCompatUnicodeTable // TypeDefIndex: 34
{
	// Fields
	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x192DAE0 Offset: 0x192DBE1 VA: 0x192DAE0
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x192DC20 Offset: 0x192DD21 VA: 0x192DC20
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x192E2F0 Offset: 0x192E3F1 VA: 0x192E2F0
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x192E5B0 Offset: 0x192E6B1 VA: 0x192E5B0
	public static byte Category(int cp) { }

	// RVA: 0x192E6C0 Offset: 0x192E7C1 VA: 0x192E6C0
	public static byte Level1(int cp) { }

	// RVA: 0x192E7D0 Offset: 0x192E8D1 VA: 0x192E7D0
	public static byte Level2(int cp) { }

	// RVA: 0x192E8E0 Offset: 0x192E9E1 VA: 0x192E8E0
	public static byte Level3(int cp) { }

	// RVA: 0x192E9F0 Offset: 0x192EAF1 VA: 0x192E9F0
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x192EB80 Offset: 0x192EC81 VA: 0x192EB80
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x192EBF0 Offset: 0x192ECF1 VA: 0x192EBF0
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x192EC10 Offset: 0x192ED11 VA: 0x192EC10
	public static int ToWidthCompat(int i) { }

	// RVA: 0x192EDD0 Offset: 0x192EED1 VA: 0x192EDD0
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x192EE70 Offset: 0x192EF71 VA: 0x192EE70
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x192EE90 Offset: 0x192EF91 VA: 0x192EE90
	public static bool IsHiragana(char c) { }

	// RVA: 0x192EEB0 Offset: 0x192EFB1 VA: 0x192EEB0
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x192EFC0 Offset: 0x192F0C1 VA: 0x192EFC0
	public static bool get_IsReady() { }

	// RVA: 0x192F030 Offset: 0x192F131 VA: 0x192F030
	private static IntPtr GetResource(string name) { }

	// RVA: 0x192F0B0 Offset: 0x192F1B1 VA: 0x192F0B0
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x192F0E0 Offset: 0x192F1E1 VA: 0x192F0E0
	private static void .cctor() { }

	// RVA: 0x192F630 Offset: 0x192F731 VA: 0x192F630
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x192F7A0 Offset: 0x192F8A1 VA: 0x192F7A0
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }
}

