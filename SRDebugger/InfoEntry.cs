public sealed class InfoEntry // TypeDefIndex: 5534
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x13BDE0 Offset: 0x13BEE1 VA: 0x13BDE0
	private string <Title>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x13BDF0 Offset: 0x13BEF1 VA: 0x13BDF0
	private bool <IsPrivate>k__BackingField; // 0x18
	private Func<object> _valueGetter; // 0x20

	// Properties
	public string Title { get; set; }
	public object Value { get; }
	public bool IsPrivate { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x13CD10 Offset: 0x13CE11 VA: 0x13CD10
	// RVA: 0x152D000 Offset: 0x152D101 VA: 0x152D000
	public string get_Title() { }

	[CompilerGeneratedAttribute] // RVA: 0x13CD20 Offset: 0x13CE21 VA: 0x13CD20
	// RVA: 0x152D010 Offset: 0x152D111 VA: 0x152D010
	public void set_Title(string value) { }

	// RVA: 0x152D020 Offset: 0x152D121 VA: 0x152D020
	public object get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x13CD30 Offset: 0x13CE31 VA: 0x13CD30
	// RVA: 0x152D1B0 Offset: 0x152D2B1 VA: 0x152D1B0
	public bool get_IsPrivate() { }

	[CompilerGeneratedAttribute] // RVA: 0x13CD40 Offset: 0x13CE41 VA: 0x13CD40
	// RVA: 0x152D1C0 Offset: 0x152D2C1 VA: 0x152D1C0
	private void set_IsPrivate(bool value) { }

	// RVA: 0x152D1D0 Offset: 0x152D2D1 VA: 0x152D1D0
	public static InfoEntry Create(string name, Func<object> getter, bool isPrivate = False) { }

	// RVA: 0x152D280 Offset: 0x152D381 VA: 0x152D280
	public static InfoEntry Create(string name, object value, bool isPrivate = False) { }

	// RVA: 0x152D270 Offset: 0x152D371 VA: 0x152D270
	public void .ctor() { }
}

