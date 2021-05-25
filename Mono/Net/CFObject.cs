internal class CFObject : IDisposable // TypeDefIndex: 1684
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBCD70 Offset: 0xBCE71 VA: 0xBCD70
	private IntPtr <Handle>k__BackingField; // 0x10

	// Properties
	public IntPtr Handle { get; set; }

	// Methods

	// RVA: 0x16E83B0 Offset: 0x16E84B1 VA: 0x16E83B0
	public static extern IntPtr dlopen(string path, int mode) { }

	// RVA: 0x16ED2C0 Offset: 0x16ED3C1 VA: 0x16ED2C0
	private static extern IntPtr dlsym(IntPtr handle, string symbol) { }

	// RVA: 0x16E8510 Offset: 0x16E8611 VA: 0x16E8510
	public static extern void dlclose(IntPtr handle) { }

	// RVA: 0x16E8460 Offset: 0x16E8561 VA: 0x16E8460
	public static IntPtr GetIndirect(IntPtr handle, string symbol) { }

	// RVA: 0x16ED370 Offset: 0x16ED471 VA: 0x16ED370
	public static IntPtr GetCFObjectHandle(IntPtr handle, string symbol) { }

	// RVA: 0x16E8100 Offset: 0x16E8201 VA: 0x16E8100
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x16ED500 Offset: 0x16ED601 VA: 0x16ED500 Slot: 1
	protected override void Finalize() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD220 Offset: 0xBD321 VA: 0xBD220
	// RVA: 0x16ED580 Offset: 0x16ED681 VA: 0x16ED580 Slot: 5
	public IntPtr get_Handle() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD230 Offset: 0xBD331 VA: 0xBD230
	// RVA: 0x16ED590 Offset: 0x16ED691 VA: 0x16ED590
	private void set_Handle(IntPtr value) { }

	// RVA: 0x16ED5A0 Offset: 0x16ED6A1 VA: 0x16ED5A0
	internal static extern IntPtr CFRetain(IntPtr handle) { }

	// RVA: 0x16ED480 Offset: 0x16ED581 VA: 0x16ED480
	private void Retain() { }

	// RVA: 0x16ED620 Offset: 0x16ED721 VA: 0x16ED620
	internal static extern void CFRelease(IntPtr handle) { }

	// RVA: 0x16ED6A0 Offset: 0x16ED7A1 VA: 0x16ED6A0
	private void Release() { }

	// RVA: 0x16ED720 Offset: 0x16ED821 VA: 0x16ED720 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16E9D80 Offset: 0x16E9E81 VA: 0x16E9D80 Slot: 4
	public void Dispose() { }
}

