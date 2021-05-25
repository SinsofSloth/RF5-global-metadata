[ComVisibleAttribute] // RVA: 0xAED40 Offset: 0xAEE41 VA: 0xAED40
[Serializable]
public class CompareInfo : IDeserializationCallback // TypeDefIndex: 705
{
	// Fields
	private const CompareOptions ValidIndexMaskOffFlags = -32;
	private const CompareOptions ValidCompareMaskOffFlags = -536870944;
	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = -32;
	[OptionalFieldAttribute] // RVA: 0xB48E0 Offset: 0xB49E1 VA: 0xB48E0
	private string m_name; // 0x10
	private string m_sortName; // 0x18
	[OptionalFieldAttribute] // RVA: 0xB4920 Offset: 0xB4A21 VA: 0xB4920
	private int win32LCID; // 0x20
	private int culture; // 0x24
	private const int LINGUISTIC_IGNORECASE = 16;
	private const int NORM_IGNORECASE = 1;
	private const int NORM_IGNOREKANATYPE = 65536;
	private const int LINGUISTIC_IGNOREDIACRITIC = 32;
	private const int NORM_IGNORENONSPACE = 2;
	private const int NORM_IGNORESYMBOLS = 4;
	private const int NORM_IGNOREWIDTH = 131072;
	private const int SORT_STRINGSORT = 4096;
	private const int COMPARE_OPTIONS_ORDINAL = 1073741824;
	internal const int NORM_LINGUISTIC_CASING = 134217728;
	private const int RESERVED_FIND_ASCII_STRING = 536870912;
	private const int SORT_VERSION_WHIDBEY = 4096;
	private const int SORT_VERSION_V4 = 393473;
	[OptionalFieldAttribute] // RVA: 0xB4960 Offset: 0xB4A61 VA: 0xB4960
	private SortVersion m_SortVersion; // 0x28
	private SimpleCollator collator; // 0x30
	private static Dictionary<string, SimpleCollator> collators; // 0x0
	private static bool managedCollation; // 0x8
	private static bool managedCollationChecked; // 0x9

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA230 Offset: 0xBA331 VA: 0xBA230
	public virtual string Name { get; }
	private static bool UseManagedCollation { get; }

	// Methods

	// RVA: 0x17A4270 Offset: 0x17A4371 VA: 0x17A4270
	internal void .ctor(CultureInfo culture) { }

	// RVA: 0x17A42C0 Offset: 0x17A43C1 VA: 0x17A42C0
	public static CompareInfo GetCompareInfo(string name) { }

	[OnDeserializingAttribute] // RVA: 0xB8840 Offset: 0xB8941 VA: 0xB8840
	// RVA: 0x17A4380 Offset: 0x17A4481 VA: 0x17A4380
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x17A4390 Offset: 0x17A4491 VA: 0x17A4390
	private void OnDeserialized() { }

	[OnDeserializedAttribute] // RVA: 0xB8850 Offset: 0xB8951 VA: 0xB8850
	// RVA: 0x17A46B0 Offset: 0x17A47B1 VA: 0x17A46B0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0xB8860 Offset: 0xB8961 VA: 0xB8860
	// RVA: 0x17A46C0 Offset: 0x17A47C1 VA: 0x17A46C0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x17A4760 Offset: 0x17A4861 VA: 0x17A4760 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x17A4770 Offset: 0x17A4871 VA: 0x17A4770 Slot: 5
	public virtual string get_Name() { }

	// RVA: 0x17A4800 Offset: 0x17A4901 VA: 0x17A4800 Slot: 6
	public virtual int Compare(string string1, string string2) { }

	// RVA: 0x17A4810 Offset: 0x17A4911 VA: 0x17A4810 Slot: 7
	public virtual int Compare(string string1, string string2, CompareOptions options) { }

	// RVA: 0x17A4AA0 Offset: 0x17A4BA1 VA: 0x17A4AA0 Slot: 8
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x17A4E00 Offset: 0x17A4F01 VA: 0x17A4E00
	private static int CompareOrdinal(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	// RVA: 0x17A4E60 Offset: 0x17A4F61 VA: 0x17A4E60 Slot: 9
	public virtual bool IsPrefix(string source, string prefix, CompareOptions options) { }

	// RVA: 0x17A5440 Offset: 0x17A5541 VA: 0x17A5440 Slot: 10
	public virtual bool IsSuffix(string source, string suffix, CompareOptions options) { }

	// RVA: 0x17A5660 Offset: 0x17A5761 VA: 0x17A5660 Slot: 11
	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x17A59A0 Offset: 0x17A5AA1 VA: 0x17A59A0 Slot: 12
	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x17A5C70 Offset: 0x17A5D71 VA: 0x17A5C70 Slot: 13
	public virtual SortKey GetSortKey(string source, CompareOptions options) { }

	// RVA: 0x17A5C80 Offset: 0x17A5D81 VA: 0x17A5C80
	private SortKey CreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x17A5E80 Offset: 0x17A5F81 VA: 0x17A5E80 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x17A5F60 Offset: 0x17A6061 VA: 0x17A5F60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17A5F90 Offset: 0x17A6091 VA: 0x17A5F90
	internal int GetHashCodeOfString(string source, CompareOptions options) { }

	// RVA: 0x17A5FA0 Offset: 0x17A60A1 VA: 0x17A5FA0
	internal int GetHashCodeOfString(string source, CompareOptions options, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x17A60D0 Offset: 0x17A61D1 VA: 0x17A60D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x17A5080 Offset: 0x17A5181 VA: 0x17A5080
	private static bool get_UseManagedCollation() { }

	// RVA: 0x17A51A0 Offset: 0x17A52A1 VA: 0x17A51A0
	private SimpleCollator GetCollator() { }

	// RVA: 0x17A5DA0 Offset: 0x17A5EA1 VA: 0x17A5DA0
	private SortKey CreateSortKeyCore(string source, CompareOptions options) { }

	// RVA: 0x17A5890 Offset: 0x17A5991 VA: 0x17A5890
	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x17A49E0 Offset: 0x17A4AE1 VA: 0x17A49E0
	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x17A61F0 Offset: 0x17A62F1 VA: 0x17A61F0
	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x17A6160 Offset: 0x17A6261 VA: 0x17A6160
	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x17A6140 Offset: 0x17A6241 VA: 0x17A6140
	private void assign_sortkey(object key, string source, CompareOptions options) { }

	// RVA: 0x17A61E0 Offset: 0x17A62E1 VA: 0x17A61E0
	private int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x17A6150 Offset: 0x17A6251 VA: 0x17A6150
	private int internal_index(string source, int sindex, int count, string value, CompareOptions options, bool first) { }

	// RVA: 0x17A6270 Offset: 0x17A6371 VA: 0x17A6270
	internal void .ctor() { }
}

