[DefaultMemberAttribute] // RVA: 0xAC5B0 Offset: 0xAC6B1 VA: 0xAC5B0
internal struct ParamsArray // TypeDefIndex: 295
{
	// Fields
	private static readonly object[] oneArgArray; // 0x0
	private static readonly object[] twoArgArray; // 0x8
	private static readonly object[] threeArgArray; // 0x10
	private readonly object arg0; // 0x0
	private readonly object arg1; // 0x8
	private readonly object arg2; // 0x10
	private readonly object[] args; // 0x18

	// Properties
	public int Length { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x12980 Offset: 0x12A81 VA: 0x12980
	public void .ctor(object arg0) { }

	// RVA: 0x12990 Offset: 0x12A91 VA: 0x12990
	public void .ctor(object arg0, object arg1) { }

	// RVA: 0x129A0 Offset: 0x12AA1 VA: 0x129A0
	public void .ctor(object arg0, object arg1, object arg2) { }

	// RVA: 0x129B0 Offset: 0x12AB1 VA: 0x129B0
	public void .ctor(object[] args) { }

	// RVA: 0x129C0 Offset: 0x12AC1 VA: 0x129C0
	public int get_Length() { }

	// RVA: 0x129E0 Offset: 0x12AE1 VA: 0x129E0
	public object get_Item(int index) { }

	// RVA: 0x12A60 Offset: 0x12B61 VA: 0x12A60
	private object GetAtSlow(int index) { }

	// RVA: 0x19565A0 Offset: 0x19566A1 VA: 0x19565A0
	private static void .cctor() { }
}

