[DefaultMemberAttribute] // RVA: 0xBBC30 Offset: 0xBBD31 VA: 0xBBC30
internal class CFArray : CFObject // TypeDefIndex: 1685
{
	// Fields
	private static readonly IntPtr kCFTypeArrayCallbacks; // 0x0

	// Properties
	public int Count { get; }
	public IntPtr Item { get; }

	// Methods

	// RVA: 0x16E8060 Offset: 0x16E8161 VA: 0x16E8060
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x16E81A0 Offset: 0x16E82A1 VA: 0x16E81A0
	private static void .cctor() { }

	// RVA: 0x16E8590 Offset: 0x16E8691 VA: 0x16E8590
	private static extern IntPtr CFArrayGetCount(IntPtr handle) { }

	// RVA: 0x16E8610 Offset: 0x16E8711 VA: 0x16E8610
	public int get_Count() { }

	// RVA: 0x16E86F0 Offset: 0x16E87F1 VA: 0x16E86F0
	private static extern IntPtr CFArrayGetValueAtIndex(IntPtr handle, IntPtr index) { }

	// RVA: 0x16E8780 Offset: 0x16E8881 VA: 0x16E8780
	public IntPtr get_Item(int index) { }
}

