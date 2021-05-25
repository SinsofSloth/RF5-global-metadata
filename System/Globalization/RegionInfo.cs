[ComVisibleAttribute] // RVA: 0xAEF60 Offset: 0xAF061 VA: 0xAEF60
[Serializable]
public class RegionInfo // TypeDefIndex: 749
{
	// Fields
	private static RegionInfo currentRegion; // 0x0
	private int regionId; // 0x10
	private string iso2Name; // 0x18
	private string iso3Name; // 0x20
	private string win3Name; // 0x28
	private string englishName; // 0x30
	private string nativeName; // 0x38
	private string currencySymbol; // 0x40
	private string isoCurrencySymbol; // 0x48
	private string currencyEnglishName; // 0x50
	private string currencyNativeName; // 0x58

	// Properties
	public static RegionInfo CurrentRegion { get; }
	[ComVisibleAttribute] // RVA: 0xBA350 Offset: 0xBA451 VA: 0xBA350
	public virtual string CurrencyEnglishName { get; }
	public virtual string CurrencySymbol { get; }
	[MonoTODOAttribute] // RVA: 0xBA370 Offset: 0xBA471 VA: 0xBA370
	public virtual string DisplayName { get; }
	public virtual string EnglishName { get; }
	[ComVisibleAttribute] // RVA: 0xBA3B0 Offset: 0xBA4B1 VA: 0xBA3B0
	public virtual int GeoId { get; }
	public virtual bool IsMetric { get; }
	public virtual string ISOCurrencySymbol { get; }
	[ComVisibleAttribute] // RVA: 0xBA3D0 Offset: 0xBA4D1 VA: 0xBA3D0
	public virtual string NativeName { get; }
	[ComVisibleAttribute] // RVA: 0xBA3F0 Offset: 0xBA4F1 VA: 0xBA3F0
	public virtual string CurrencyNativeName { get; }
	public virtual string Name { get; }
	public virtual string ThreeLetterISORegionName { get; }
	public virtual string ThreeLetterWindowsRegionName { get; }
	public virtual string TwoLetterISORegionName { get; }

	// Methods

	// RVA: 0x19C7EB0 Offset: 0x19C7FB1 VA: 0x19C7EB0
	public static RegionInfo get_CurrentRegion() { }

	// RVA: 0x19C8140 Offset: 0x19C8241 VA: 0x19C8140
	public void .ctor(int culture) { }

	// RVA: 0x19C8320 Offset: 0x19C8421 VA: 0x19C8320
	public void .ctor(string name) { }

	// RVA: 0x19C7F90 Offset: 0x19C8091 VA: 0x19C7F90
	private void .ctor(CultureInfo ci) { }

	// RVA: 0x19C8250 Offset: 0x19C8351 VA: 0x19C8250
	private bool GetByTerritory(CultureInfo ci) { }

	// RVA: 0x19C8460 Offset: 0x19C8561 VA: 0x19C8460
	private bool construct_internal_region_from_name(string name) { }

	// RVA: 0x19C8470 Offset: 0x19C8571 VA: 0x19C8470 Slot: 4
	public virtual string get_CurrencyEnglishName() { }

	// RVA: 0x19C8480 Offset: 0x19C8581 VA: 0x19C8480 Slot: 5
	public virtual string get_CurrencySymbol() { }

	// RVA: 0x19C8490 Offset: 0x19C8591 VA: 0x19C8490 Slot: 6
	public virtual string get_DisplayName() { }

	// RVA: 0x19C84A0 Offset: 0x19C85A1 VA: 0x19C84A0 Slot: 7
	public virtual string get_EnglishName() { }

	// RVA: 0x19C84B0 Offset: 0x19C85B1 VA: 0x19C84B0 Slot: 8
	public virtual int get_GeoId() { }

	// RVA: 0x19C84C0 Offset: 0x19C85C1 VA: 0x19C84C0 Slot: 9
	public virtual bool get_IsMetric() { }

	// RVA: 0x19C8550 Offset: 0x19C8651 VA: 0x19C8550 Slot: 10
	public virtual string get_ISOCurrencySymbol() { }

	// RVA: 0x19C8560 Offset: 0x19C8661 VA: 0x19C8560 Slot: 11
	public virtual string get_NativeName() { }

	// RVA: 0x19C8570 Offset: 0x19C8671 VA: 0x19C8570 Slot: 12
	public virtual string get_CurrencyNativeName() { }

	// RVA: 0x19C8580 Offset: 0x19C8681 VA: 0x19C8580 Slot: 13
	public virtual string get_Name() { }

	// RVA: 0x19C8590 Offset: 0x19C8691 VA: 0x19C8590 Slot: 14
	public virtual string get_ThreeLetterISORegionName() { }

	// RVA: 0x19C85A0 Offset: 0x19C86A1 VA: 0x19C85A0 Slot: 15
	public virtual string get_ThreeLetterWindowsRegionName() { }

	// RVA: 0x19C85B0 Offset: 0x19C86B1 VA: 0x19C85B0 Slot: 16
	public virtual string get_TwoLetterISORegionName() { }

	// RVA: 0x19C85C0 Offset: 0x19C86C1 VA: 0x19C85C0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x19C86A0 Offset: 0x19C87A1 VA: 0x19C86A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19C86D0 Offset: 0x19C87D1 VA: 0x19C86D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x19C86E0 Offset: 0x19C87E1 VA: 0x19C86E0
	internal static void ClearCachedData() { }
}

