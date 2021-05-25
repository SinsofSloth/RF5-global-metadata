internal struct ResourceLocator // TypeDefIndex: 504
{
	// Fields
	internal object _value; // 0x0
	internal int _dataPos; // 0x8

	// Properties
	internal int DataPosition { get; }
	internal object Value { get; set; }

	// Methods

	// RVA: 0xAE40 Offset: 0xAF41 VA: 0xAE40
	internal void .ctor(int dataPos, object value) { }

	// RVA: 0xAE50 Offset: 0xAF51 VA: 0xAE50
	internal int get_DataPosition() { }

	// RVA: 0xAE60 Offset: 0xAF61 VA: 0xAE60
	internal object get_Value() { }

	// RVA: 0xAE70 Offset: 0xAF71 VA: 0xAE70
	internal void set_Value(object value) { }

	// RVA: 0x17F8110 Offset: 0x17F8211 VA: 0x17F8110
	internal static bool CanCache(ResourceTypeCode value) { }
}

