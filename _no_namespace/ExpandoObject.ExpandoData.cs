[DefaultMemberAttribute] // RVA: 0xBF100 Offset: 0xBF201 VA: 0xBF100
private class ExpandoObject.ExpandoData // TypeDefIndex: 2728
{
	// Fields
	internal static ExpandoObject.ExpandoData Empty; // 0x0
	internal readonly ExpandoClass Class; // 0x10
	private readonly object[] _dataArray; // 0x18
	private int _version; // 0x20

	// Properties
	internal object Item { get; set; }
	internal int Version { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0x169CC60 Offset: 0x169CD61 VA: 0x169CC60
	internal object get_Item(int index) { }

	// RVA: 0x169D3A0 Offset: 0x169D4A1 VA: 0x169D3A0
	internal void set_Item(int index, object value) { }

	// RVA: 0x169F260 Offset: 0x169F361 VA: 0x169F260
	internal int get_Version() { }

	// RVA: 0x169D880 Offset: 0x169D981 VA: 0x169D880
	internal int get_Length() { }

	// RVA: 0x169F270 Offset: 0x169F371 VA: 0x169F270
	private void .ctor() { }

	// RVA: 0x169F3B0 Offset: 0x169F4B1 VA: 0x169F3B0
	internal void .ctor(ExpandoClass klass, object[] data, int version) { }

	// RVA: 0x169D8C0 Offset: 0x169D9C1 VA: 0x169D8C0
	internal ExpandoObject.ExpandoData UpdateClass(ExpandoClass newClass) { }

	// RVA: 0x169F410 Offset: 0x169F511 VA: 0x169F410
	private static int GetAlignedSize(int len) { }

	// RVA: 0x169F420 Offset: 0x169F521 VA: 0x169F420
	private static void .cctor() { }
}

