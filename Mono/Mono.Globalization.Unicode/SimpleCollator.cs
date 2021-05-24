internal class SimpleCollator // TypeDefIndex: 38
{
	// Fields
	private static bool QuickCheckDisabled; // 0x0
	private static SimpleCollator invariant; // 0x8
	private readonly TextInfo textInfo; // 0x10
	private readonly CodePointIndexer cjkIndexer; // 0x18
	private readonly Contraction[] contractions; // 0x20
	private readonly Level2Map[] level2Maps; // 0x28
	private readonly byte[] unsafeFlags; // 0x30
	private readonly byte* cjkCatTable; // 0x38
	private readonly byte* cjkLv1Table; // 0x40
	private readonly byte* cjkLv2Table; // 0x48
	private readonly CodePointIndexer cjkLv2Indexer; // 0x50
	private readonly int lcid; // 0x58
	private readonly bool frenchSort; // 0x5C
	private const int UnsafeFlagLength = 96;

	// Methods

	// RVA: 0x19306C0 Offset: 0x19307C1 VA: 0x19306C0
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x1930A20 Offset: 0x1930B21 VA: 0x1930A20
	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x1930B60 Offset: 0x1930C61 VA: 0x1930B60
	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	// RVA: 0x1930BE0 Offset: 0x1930CE1 VA: 0x1930BE0
	private byte Category(int cp) { }

	// RVA: 0x1930CE0 Offset: 0x1930DE1 VA: 0x1930CE0
	private byte Level1(int cp) { }

	// RVA: 0x1930DE0 Offset: 0x1930EE1 VA: 0x1930DE0
	private byte Level2(int cp, SimpleCollator.ExtenderType ext) { }

	// RVA: 0x1930FA0 Offset: 0x19310A1 VA: 0x1930FA0
	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	// RVA: 0x1931040 Offset: 0x1931141 VA: 0x1931040
	private Contraction GetContraction(string s, int start, int end) { }

	// RVA: 0x1931120 Offset: 0x1931221 VA: 0x1931120
	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x1931280 Offset: 0x1931381 VA: 0x1931280
	private Contraction GetTailContraction(string s, int start, int end) { }

	// RVA: 0x1931360 Offset: 0x1931461 VA: 0x1931360
	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x1931570 Offset: 0x1931671 VA: 0x1931570
	private int FilterOptions(int i, CompareOptions opt) { }

	// RVA: 0x1931690 Offset: 0x1931791 VA: 0x1931690
	private SimpleCollator.ExtenderType GetExtenderType(int i) { }

	// RVA: 0x19317B0 Offset: 0x19318B1 VA: 0x19317B0
	private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x19317D0 Offset: 0x19318D1 VA: 0x19317D0
	private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x1931A50 Offset: 0x1931B51 VA: 0x1931A50
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	// RVA: 0x1931B00 Offset: 0x1931C01 VA: 0x1931B00
	private bool IsSafe(int i) { }

	// RVA: 0x1931B70 Offset: 0x1931C71 VA: 0x1931B70
	public SortKey GetSortKey(string s, CompareOptions options) { }

	// RVA: 0x1931B90 Offset: 0x1931C91 VA: 0x1931B90
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	// RVA: 0x1931F00 Offset: 0x1932001 VA: 0x1931F00
	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x1932590 Offset: 0x1932691 VA: 0x1932590
	private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x1932D60 Offset: 0x1932E61 VA: 0x1932D60
	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	// RVA: 0x1932EC0 Offset: 0x1932FC1 VA: 0x1932EC0
	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x1932510 Offset: 0x1932611 VA: 0x1932510
	private void ClearBuffer(byte* buffer, int size) { }

	// RVA: 0x1932F50 Offset: 0x1933051 VA: 0x1932F50
	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1934E70 Offset: 0x1934F71 VA: 0x1934E70
	private int CompareFlagPair(bool b1, bool b2) { }

	// RVA: 0x1934E90 Offset: 0x1934F91 VA: 0x1934E90
	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	// RVA: 0x1934EB0 Offset: 0x1934FB1 VA: 0x1934EB0
	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1934FB0 Offset: 0x19350B1 VA: 0x1934FB0
	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1935020 Offset: 0x1935121 VA: 0x1935020
	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	// RVA: 0x1935040 Offset: 0x1935141 VA: 0x1935040
	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1935420 Offset: 0x1935521 VA: 0x1935420
	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	// RVA: 0x19355C0 Offset: 0x19356C1 VA: 0x19355C0
	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1935FD0 Offset: 0x19360D1 VA: 0x1935FD0
	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x19360D0 Offset: 0x19361D1 VA: 0x19360D0
	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	// RVA: 0x1936160 Offset: 0x1936261 VA: 0x1936160
	private int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x19358B0 Offset: 0x19359B1 VA: 0x19358B0
	private int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1935140 Offset: 0x1935241 VA: 0x1935140
	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x19364D0 Offset: 0x19365D1 VA: 0x19364D0
	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x1936DB0 Offset: 0x1936EB1 VA: 0x1936DB0
	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1936610 Offset: 0x1936711 VA: 0x1936610
	private int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1936220 Offset: 0x1936321 VA: 0x1936220
	private bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1937140 Offset: 0x1937241 VA: 0x1937140
	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1937520 Offset: 0x1937621 VA: 0x1937520
	private bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4) { }

	// RVA: 0x1936E70 Offset: 0x1936F71 VA: 0x1936E70
	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1937A00 Offset: 0x1937B01 VA: 0x1937A00
	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1938080 Offset: 0x1938181 VA: 0x1938080
	private static void .cctor() { }
}

