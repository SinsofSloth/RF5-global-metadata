internal struct SafeStringMarshal : IDisposable // TypeDefIndex: 21
{
	// Fields
	private readonly string str; // 0x0
	private IntPtr marshaled_string; // 0x8

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x19409F0 Offset: 0x1940AF1 VA: 0x19409F0
	public static IntPtr StringToUtf8(string str) { }

	// RVA: 0x1940A00 Offset: 0x1940B01 VA: 0x1940A00
	public static void GFree(IntPtr ptr) { }

	// RVA: 0x117A0 Offset: 0x118A1 VA: 0x117A0
	public void .ctor(string str) { }

	// RVA: 0x11810 Offset: 0x11911 VA: 0x11810
	public IntPtr get_Value() { }

	// RVA: 0x11880 Offset: 0x11981 VA: 0x11880 Slot: 4
	public void Dispose() { }
}

