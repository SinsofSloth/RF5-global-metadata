[NativeHeaderAttribute] // RVA: 0xC8A50 Offset: 0xC8B51 VA: 0xC8A50
[NativeHeaderAttribute] // RVA: 0xC8A50 Offset: 0xC8B51 VA: 0xC8A50
[NativeHeaderAttribute] // RVA: 0xC8A50 Offset: 0xC8B51 VA: 0xC8A50
[NativeTypeAttribute] // RVA: 0xC8A50 Offset: 0xC8B51 VA: 0xC8A50
[NativeHeaderAttribute] // RVA: 0xC8A50 Offset: 0xC8B51 VA: 0xC8A50
[NativeHeaderAttribute] // RVA: 0xC8A50 Offset: 0xC8B51 VA: 0xC8A50
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext> // TypeDefIndex: 3329
{
	// Fields
	private IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x3746D0 Offset: 0x3747D1 VA: 0x3746D0
	private int GetNumberOfCameras_Internal() { }

	// RVA: 0x374720 Offset: 0x374821 VA: 0x374720
	private Camera GetCamera_Internal(int index) { }

	// RVA: 0x374770 Offset: 0x374871 VA: 0x374770
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x374780 Offset: 0x374881 VA: 0x374780
	internal int GetNumberOfCameras() { }

	// RVA: 0x3747D0 Offset: 0x3748D1 VA: 0x3747D0
	internal Camera GetCamera(int index) { }

	// RVA: 0x374820 Offset: 0x374921 VA: 0x374820 Slot: 4
	public bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x3748A0 Offset: 0x3749A1 VA: 0x3748A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x374970 Offset: 0x374A71 VA: 0x374970 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2A222A0 Offset: 0x2A223A1 VA: 0x2A222A0
	private static int GetNumberOfCameras_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	// RVA: 0x2A22340 Offset: 0x2A22441 VA: 0x2A22340
	private static Camera GetCamera_Internal_Injected(ref ScriptableRenderContext _unity_self, int index) { }
}

