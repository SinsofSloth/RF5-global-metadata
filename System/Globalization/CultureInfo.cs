[ComVisibleAttribute] // RVA: 0xAEF40 Offset: 0xAF041 VA: 0xAEF40
[Serializable]
public class CultureInfo : ICloneable, IFormatProvider // TypeDefIndex: 744
{
	// Fields
	private static CultureInfo invariant_culture_info; // 0x0
	private static object shared_table_lock; // 0x8
	private static CultureInfo default_current_culture; // 0x10
	private bool m_isReadOnly; // 0x10
	private int cultureID; // 0x14
	private int parent_lcid; // 0x18
	private int datetime_index; // 0x1C
	private int number_index; // 0x20
	private int default_calendar_type; // 0x24
	private bool m_useUserOverride; // 0x28
	internal NumberFormatInfo numInfo; // 0x30
	internal DateTimeFormatInfo dateTimeInfo; // 0x38
	private TextInfo textInfo; // 0x40
	internal string m_name; // 0x48
	private string englishname; // 0x50
	private string nativename; // 0x58
	private string iso3lang; // 0x60
	private string iso2lang; // 0x68
	private string win3lang; // 0x70
	private string territory; // 0x78
	private string[] native_calendar_names; // 0x80
	private CompareInfo compareInfo; // 0x88
	private readonly void* textinfo_data; // 0x90
	private int m_dataItem; // 0x98
	private Calendar calendar; // 0xA0
	private CultureInfo parent_culture; // 0xA8
	private bool constructed; // 0xB0
	internal byte[] cached_serialized_form; // 0xB8
	internal CultureData m_cultureData; // 0xC0
	internal bool m_isInherited; // 0xC8
	internal const int InvariantCultureId = 127;
	private const int CalendarTypeBits = 8;
	private const string MSG_READONLY = "This instance is read only";
	private static CultureInfo s_DefaultThreadCurrentUICulture; // 0x18
	private static CultureInfo s_DefaultThreadCurrentCulture; // 0x20
	private static Dictionary<int, CultureInfo> shared_by_number; // 0x28
	private static Dictionary<string, CultureInfo> shared_by_name; // 0x30
	internal static readonly bool IsTaiwanSku; // 0x38

	// Properties
	public static CultureInfo InvariantCulture { get; }
	public static CultureInfo CurrentCulture { get; }
	public static CultureInfo CurrentUICulture { get; }
	internal string Territory { get; }
	public virtual int LCID { get; }
	public virtual string Name { get; }
	public virtual Calendar Calendar { get; }
	public virtual CultureInfo Parent { get; }
	public virtual TextInfo TextInfo { get; }
	public virtual CompareInfo CompareInfo { get; }
	public virtual bool IsNeutralCulture { get; }
	public virtual NumberFormatInfo NumberFormat { get; set; }
	public virtual DateTimeFormatInfo DateTimeFormat { get; set; }
	public virtual string EnglishName { get; }
	public bool IsReadOnly { get; }
	internal int CalendarType { get; }
	public static CultureInfo DefaultThreadCurrentCulture { get; }
	public static CultureInfo DefaultThreadCurrentUICulture { get; }
	internal string SortName { get; }
	internal static CultureInfo UserDefaultUICulture { get; }
	internal static CultureInfo UserDefaultCulture { get; }
	internal bool HasInvariantCultureName { get; }

	// Methods

	// RVA: 0x1797AA0 Offset: 0x1797BA1 VA: 0x1797AA0
	public static CultureInfo get_InvariantCulture() { }

	// RVA: 0x179B120 Offset: 0x179B221 VA: 0x179B120
	public static CultureInfo get_CurrentCulture() { }

	// RVA: 0x17A73C0 Offset: 0x17A74C1 VA: 0x17A73C0
	public static CultureInfo get_CurrentUICulture() { }

	// RVA: 0x17A73F0 Offset: 0x17A74F1 VA: 0x17A73F0
	internal static CultureInfo ConstructCurrentCulture() { }

	// RVA: 0x17A79C0 Offset: 0x17A7AC1 VA: 0x17A79C0
	internal static CultureInfo ConstructCurrentUICulture() { }

	// RVA: 0x17A7A30 Offset: 0x17A7B31 VA: 0x17A7A30
	internal string get_Territory() { }

	// RVA: 0x17A7A40 Offset: 0x17A7B41 VA: 0x17A7A40 Slot: 6
	public virtual int get_LCID() { }

	// RVA: 0x17A7A50 Offset: 0x17A7B51 VA: 0x17A7A50 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x17A7A60 Offset: 0x17A7B61 VA: 0x17A7A60 Slot: 8
	public virtual Calendar get_Calendar() { }

	// RVA: 0x17A7D50 Offset: 0x17A7E51 VA: 0x17A7D50 Slot: 9
	public virtual CultureInfo get_Parent() { }

	// RVA: 0x17A8020 Offset: 0x17A8121 VA: 0x17A8020 Slot: 10
	public virtual TextInfo get_TextInfo() { }

	// RVA: 0x17A8210 Offset: 0x17A8311 VA: 0x17A8210 Slot: 11
	public virtual object Clone() { }

	// RVA: 0x17A84B0 Offset: 0x17A85B1 VA: 0x17A84B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x17A8570 Offset: 0x17A8671 VA: 0x17A8570
	private CultureInfo.Data GetTextInfoData() { }

	// RVA: 0x17A8590 Offset: 0x17A8691 VA: 0x17A8590 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17A85A0 Offset: 0x17A86A1 VA: 0x17A85A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x17A85B0 Offset: 0x17A86B1 VA: 0x17A85B0 Slot: 12
	public virtual CompareInfo get_CompareInfo() { }

	// RVA: 0x17A8710 Offset: 0x17A8811 VA: 0x17A8710 Slot: 13
	public virtual bool get_IsNeutralCulture() { }

	// RVA: 0x17A8770 Offset: 0x17A8871 VA: 0x17A8770
	private void CheckNeutral() { }

	// RVA: 0x17A8780 Offset: 0x17A8881 VA: 0x17A8780 Slot: 14
	public virtual NumberFormatInfo get_NumberFormat() { }

	// RVA: 0x17A8830 Offset: 0x17A8931 VA: 0x17A8830 Slot: 15
	public virtual void set_NumberFormat(NumberFormatInfo value) { }

	// RVA: 0x17A8930 Offset: 0x17A8A31 VA: 0x17A8930 Slot: 16
	public virtual DateTimeFormatInfo get_DateTimeFormat() { }

	// RVA: 0x17A8AB0 Offset: 0x17A8BB1 VA: 0x17A8AB0 Slot: 17
	public virtual void set_DateTimeFormat(DateTimeFormatInfo value) { }

	// RVA: 0x17A8BB0 Offset: 0x17A8CB1 VA: 0x17A8BB0 Slot: 18
	public virtual string get_EnglishName() { }

	// RVA: 0x17A8C00 Offset: 0x17A8D01 VA: 0x17A8C00
	public bool get_IsReadOnly() { }

	// RVA: 0x17A8C10 Offset: 0x17A8D11 VA: 0x17A8C10 Slot: 19
	public virtual object GetFormat(Type formatType) { }

	// RVA: 0x17A7B20 Offset: 0x17A7C21 VA: 0x17A7B20
	private void Construct() { }

	// RVA: 0x17A8D20 Offset: 0x17A8E21 VA: 0x17A8D20
	private bool construct_internal_locale_from_lcid(int lcid) { }

	// RVA: 0x17A8D30 Offset: 0x17A8E31 VA: 0x17A8D30
	private bool construct_internal_locale_from_name(string name) { }

	// RVA: 0x17A7650 Offset: 0x17A7751 VA: 0x17A7650
	private static string get_current_locale_name() { }

	// RVA: 0x17A8D40 Offset: 0x17A8E41 VA: 0x17A8D40
	private void ConstructInvariant(bool read_only) { }

	// RVA: 0x17A8180 Offset: 0x17A8281 VA: 0x17A8180
	private TextInfo CreateTextInfo(bool readOnly) { }

	// RVA: 0x17A8010 Offset: 0x17A8111 VA: 0x17A8010
	public void .ctor(int culture) { }

	// RVA: 0x17A8ED0 Offset: 0x17A8FD1 VA: 0x17A8ED0
	public void .ctor(int culture, bool useUserOverride) { }

	// RVA: 0x17A8EE0 Offset: 0x17A8FE1 VA: 0x17A8EE0
	private void .ctor(int culture, bool useUserOverride, bool read_only) { }

	// RVA: 0x17A8000 Offset: 0x17A8101 VA: 0x17A8000
	public void .ctor(string name) { }

	// RVA: 0x17A6810 Offset: 0x17A6911 VA: 0x17A6810
	public void .ctor(string name, bool useUserOverride) { }

	// RVA: 0x17A92A0 Offset: 0x17A93A1 VA: 0x17A92A0
	private void .ctor(string name, bool useUserOverride, bool read_only) { }

	// RVA: 0x17A9610 Offset: 0x17A9711 VA: 0x17A9610
	private void .ctor() { }

	// RVA: 0x17A9640 Offset: 0x17A9741 VA: 0x17A9640
	private static void insert_into_shared_tables(CultureInfo c) { }

	// RVA: 0x17A4470 Offset: 0x17A4571 VA: 0x17A4470
	public static CultureInfo GetCultureInfo(int culture) { }

	// RVA: 0x17A3440 Offset: 0x17A3541 VA: 0x17A3440
	public static CultureInfo GetCultureInfo(string name) { }

	// RVA: 0x17A97D0 Offset: 0x17A98D1 VA: 0x17A97D0
	internal static CultureInfo CreateCulture(string name, bool reference) { }

	// RVA: 0x17A7660 Offset: 0x17A7761 VA: 0x17A7660
	public static CultureInfo CreateSpecificCulture(string name) { }

	// RVA: 0x17A9860 Offset: 0x17A9961 VA: 0x17A9860
	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	// RVA: 0x17A9200 Offset: 0x17A9301 VA: 0x17A9200
	internal int get_CalendarType() { }

	// RVA: 0x17A7B50 Offset: 0x17A7C51 VA: 0x17A7B50
	private static Calendar CreateCalendar(int calendarType) { }

	// RVA: 0x17A9570 Offset: 0x17A9671 VA: 0x17A9570
	private static Exception CreateNotFoundException(string name) { }

	// RVA: 0x17AB7F0 Offset: 0x17AB8F1 VA: 0x17AB7F0
	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	// RVA: 0x17AB860 Offset: 0x17AB961 VA: 0x17AB860
	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	// RVA: 0x17AB8D0 Offset: 0x17AB9D1 VA: 0x17AB8D0
	internal string get_SortName() { }

	// RVA: 0x17AB8E0 Offset: 0x17AB9E1 VA: 0x17AB8E0
	internal static CultureInfo get_UserDefaultUICulture() { }

	// RVA: 0x17AB9A0 Offset: 0x17ABAA1 VA: 0x17AB9A0
	internal static CultureInfo get_UserDefaultCulture() { }

	// RVA: 0x17ABA10 Offset: 0x17ABB11 VA: 0x17ABA10
	internal static void CheckDomainSafetyObject(object obj, object container) { }

	// RVA: 0x17ABBA0 Offset: 0x17ABCA1 VA: 0x17ABBA0
	internal bool get_HasInvariantCultureName() { }

	// RVA: 0x17ABCA0 Offset: 0x17ABDA1 VA: 0x17ABCA0
	internal static bool VerifyCultureName(string cultureName, bool throwException) { }

	// RVA: 0x17ABE20 Offset: 0x17ABF21 VA: 0x17ABE20
	private static void .cctor() { }
}

