internal sealed class RegexCharClass // TypeDefIndex: 1772
{
	// Fields
	private List<RegexCharClass.SingleRange> _rangelist; // 0x10
	private StringBuilder _categories; // 0x18
	private bool _canonical; // 0x20
	private bool _negate; // 0x21
	private RegexCharClass _subtractor; // 0x28
	private static readonly string InternalRegexIgnoreCase; // 0x0
	private static readonly string Space; // 0x8
	private static readonly string NotSpace; // 0x10
	private static readonly string Word; // 0x18
	private static readonly string NotWord; // 0x20
	internal static readonly string SpaceClass; // 0x28
	internal static readonly string NotSpaceClass; // 0x30
	internal static readonly string WordClass; // 0x38
	internal static readonly string NotWordClass; // 0x40
	internal static readonly string DigitClass; // 0x48
	internal static readonly string NotDigitClass; // 0x50
	private static Dictionary<string, string> _definedCategories; // 0x58
	private static readonly string[,] _propTable; // 0x60
	private static readonly RegexCharClass.LowerCaseMapping[] _lcTable; // 0x68

	// Properties
	internal bool CanMerge { get; }
	internal bool Negate { set; }

	// Methods

	// RVA: 0x160F330 Offset: 0x160F431 VA: 0x160F330
	private static void .cctor() { }

	// RVA: 0x1613FA0 Offset: 0x16140A1 VA: 0x1613FA0
	internal void .ctor() { }

	// RVA: 0x1614060 Offset: 0x1614161 VA: 0x1614060
	private void .ctor(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x16140E0 Offset: 0x16141E1 VA: 0x16140E0
	internal bool get_CanMerge() { }

	// RVA: 0x1614100 Offset: 0x1614201 VA: 0x1614100
	internal void set_Negate(bool value) { }

	// RVA: 0x1614110 Offset: 0x1614211 VA: 0x1614110
	internal void AddChar(char c) { }

	// RVA: 0x1614200 Offset: 0x1614301 VA: 0x1614200
	internal void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x1614580 Offset: 0x1614681 VA: 0x1614580
	private void AddSet(string set) { }

	// RVA: 0x1614860 Offset: 0x1614961 VA: 0x1614860
	internal void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x1614120 Offset: 0x1614221 VA: 0x1614120
	internal void AddRange(char first, char last) { }

	// RVA: 0x1614870 Offset: 0x1614971 VA: 0x1614870
	internal void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x1614D90 Offset: 0x1614E91 VA: 0x1614D90
	private void AddCategory(string category) { }

	// RVA: 0x1614DB0 Offset: 0x1614EB1 VA: 0x1614DB0
	internal void AddLowercase(CultureInfo culture) { }

	// RVA: 0x1614ED0 Offset: 0x1614FD1 VA: 0x1614ED0
	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	// RVA: 0x1615180 Offset: 0x1615281 VA: 0x1615180
	internal void AddWord(bool ecma, bool negate) { }

	// RVA: 0x1615280 Offset: 0x1615381 VA: 0x1615280
	internal void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x1615380 Offset: 0x1615481 VA: 0x1615380
	internal void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x1615430 Offset: 0x1615531 VA: 0x1615430
	internal static char SingletonChar(string set) { }

	// RVA: 0x1615450 Offset: 0x1615551 VA: 0x1615450
	internal static bool IsMergeable(string charClass) { }

	// RVA: 0x16155F0 Offset: 0x16156F1 VA: 0x16155F0
	internal static bool IsEmpty(string charClass) { }

	// RVA: 0x16156F0 Offset: 0x16157F1 VA: 0x16156F0
	internal static bool IsSingleton(string set) { }

	// RVA: 0x1615870 Offset: 0x1615971 VA: 0x1615870
	internal static bool IsSingletonInverse(string set) { }

	// RVA: 0x1615580 Offset: 0x1615681 VA: 0x1615580
	private static bool IsSubtraction(string charClass) { }

	// RVA: 0x1615550 Offset: 0x1615651 VA: 0x1615550
	internal static bool IsNegated(string set) { }

	// RVA: 0x16159F0 Offset: 0x1615AF1 VA: 0x16159F0
	internal static bool IsECMAWordChar(char ch) { }

	// RVA: 0x1615B30 Offset: 0x1615C31 VA: 0x1615B30
	internal static bool IsWordChar(char ch) { }

	// RVA: 0x1615AB0 Offset: 0x1615BB1 VA: 0x1615AB0
	internal static bool CharInClass(char ch, string set) { }

	// RVA: 0x1615C20 Offset: 0x1615D21 VA: 0x1615C20
	internal static bool CharInClassRecursive(char ch, string set, int start) { }

	// RVA: 0x1615D70 Offset: 0x1615E71 VA: 0x1615D70
	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x1615EA0 Offset: 0x1615FA1 VA: 0x1615EA0
	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x16160D0 Offset: 0x16161D1 VA: 0x16160D0
	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	// RVA: 0x1613EA0 Offset: 0x1613FA1 VA: 0x1613EA0
	private static string NegateCategory(string category) { }

	// RVA: 0x16161B0 Offset: 0x16162B1 VA: 0x16161B0
	internal static RegexCharClass Parse(string charClass) { }

	// RVA: 0x1616220 Offset: 0x1616321 VA: 0x1616220
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x16144B0 Offset: 0x16145B1 VA: 0x16144B0
	private int RangeCount() { }

	// RVA: 0x16164E0 Offset: 0x16165E1 VA: 0x16164E0
	internal string ToStringClass() { }

	// RVA: 0x1614500 Offset: 0x1614601 VA: 0x1614500
	private RegexCharClass.SingleRange GetRangeAt(int i) { }

	// RVA: 0x16166B0 Offset: 0x16167B1 VA: 0x16166B0
	private void Canonicalize() { }

	// RVA: 0x1614A80 Offset: 0x1614B81 VA: 0x1614A80
	private static string SetFromProperty(string capname, bool invert, string pattern) { }
}

