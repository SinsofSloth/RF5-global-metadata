[ComVisibleAttribute] // RVA: 0xB2110 Offset: 0xB2211 VA: 0xB2110
[MonoTODOAttribute] // RVA: 0xB2110 Offset: 0xB2211 VA: 0xB2110
public struct GCHandle // TypeDefIndex: 1321
{
	// Fields
	private int handle; // 0x0

	// Properties
	public bool IsAllocated { get; }
	public object Target { get; set; }

	// Methods

	// RVA: 0xB590 Offset: 0xB691 VA: 0xB590
	private void .ctor(IntPtr h) { }

	// RVA: 0xB5C0 Offset: 0xB6C1 VA: 0xB5C0
	private void .ctor(object obj) { }

	// RVA: 0xB5F0 Offset: 0xB6F1 VA: 0xB5F0
	internal void .ctor(object value, GCHandleType type) { }

	// RVA: 0xB630 Offset: 0xB731 VA: 0xB630
	public bool get_IsAllocated() { }

	// RVA: 0xB640 Offset: 0xB741 VA: 0xB640
	public object get_Target() { }

	// RVA: 0xB6E0 Offset: 0xB7E1 VA: 0xB6E0
	public void set_Target(object value) { }

	// RVA: 0xB720 Offset: 0xB821 VA: 0xB720
	public IntPtr AddrOfPinnedObject() { }

	// RVA: 0x1804030 Offset: 0x1804131 VA: 0x1804030
	public static GCHandle Alloc(object value) { }

	// RVA: 0x1804050 Offset: 0x1804151 VA: 0x1804050
	public static GCHandle Alloc(object value, GCHandleType type) { }

	// RVA: 0xB730 Offset: 0xB831 VA: 0xB730
	public void Free() { }

	// RVA: 0x1804140 Offset: 0x1804241 VA: 0x1804140
	public static IntPtr op_Explicit(GCHandle value) { }

	// RVA: 0x1804150 Offset: 0x1804251 VA: 0x1804150
	public static GCHandle op_Explicit(IntPtr value) { }

	// RVA: 0x1804230 Offset: 0x1804331 VA: 0x1804230
	private static bool CheckCurrentDomain(int handle) { }

	// RVA: 0x1803ED0 Offset: 0x1803FD1 VA: 0x1803ED0
	private static object GetTarget(int handle) { }

	// RVA: 0x1803E10 Offset: 0x1803F11 VA: 0x1803E10
	private static int GetTargetHandle(object obj, int handle, GCHandleType type) { }

	// RVA: 0x1804130 Offset: 0x1804231 VA: 0x1804130
	private static void FreeHandle(int handle) { }

	// RVA: 0x1804020 Offset: 0x1804121 VA: 0x1804020
	private static IntPtr GetAddrOfPinnedObject(int handle) { }

	// RVA: 0x1804240 Offset: 0x1804341 VA: 0x1804240
	public static bool op_Equality(GCHandle a, GCHandle b) { }

	// RVA: 0xB740 Offset: 0xB841 VA: 0xB740 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0xB7F0 Offset: 0xB8F1 VA: 0xB7F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1804310 Offset: 0x1804411 VA: 0x1804310
	public static GCHandle FromIntPtr(IntPtr value) { }

	// RVA: 0x1804330 Offset: 0x1804431 VA: 0x1804330
	public static IntPtr ToIntPtr(GCHandle value) { }
}

