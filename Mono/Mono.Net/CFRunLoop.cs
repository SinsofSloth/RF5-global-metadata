internal class CFRunLoop : CFObject // TypeDefIndex: 1692
{
	// Properties
	public static CFRunLoop CurrentRunLoop { get; }

	// Methods

	// RVA: 0x16EE170 Offset: 0x16EE271 VA: 0x16EE170
	private static extern void CFRunLoopAddSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	// RVA: 0x16EE210 Offset: 0x16EE311 VA: 0x16EE210
	private static extern void CFRunLoopRemoveSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	// RVA: 0x16EE2B0 Offset: 0x16EE3B1 VA: 0x16EE2B0
	private static extern int CFRunLoopRunInMode(IntPtr mode, double seconds, bool returnAfterSourceHandled) { }

	// RVA: 0x16EE350 Offset: 0x16EE451 VA: 0x16EE350
	private static extern IntPtr CFRunLoopGetCurrent() { }

	// RVA: 0x16EE3C0 Offset: 0x16EE4C1 VA: 0x16EE3C0
	private static extern void CFRunLoopStop(IntPtr rl) { }

	// RVA: 0x16EE440 Offset: 0x16EE541 VA: 0x16EE440
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x16EA470 Offset: 0x16EA571 VA: 0x16EA470
	public static CFRunLoop get_CurrentRunLoop() { }

	// RVA: 0x16EA6E0 Offset: 0x16EA7E1 VA: 0x16EA6E0
	public void AddSource(IntPtr source, CFString mode) { }

	// RVA: 0x16EA830 Offset: 0x16EA931 VA: 0x16EA830
	public void RemoveSource(IntPtr source, CFString mode) { }

	// RVA: 0x16EA780 Offset: 0x16EA881 VA: 0x16EA780
	public int RunInMode(CFString mode, double seconds, bool returnAfterSourceHandled) { }

	// RVA: 0x16EB820 Offset: 0x16EB921 VA: 0x16EB820
	public void Stop() { }
}

