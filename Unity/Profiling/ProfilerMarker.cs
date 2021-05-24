[NativeHeaderAttribute] // RVA: 0xC3860 Offset: 0xC3961 VA: 0xC3860
[UsedByNativeCodeAttribute] // RVA: 0xC3860 Offset: 0xC3961 VA: 0xC3860
public struct ProfilerMarker // TypeDefIndex: 2786
{
	// Fields
	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0xC93B0 Offset: 0xC94B1 VA: 0xC93B0
	internal readonly IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x37B270 Offset: 0x37B371 VA: 0x37B270
	public void .ctor(string name) { }

	// RVA: 0x37B2D0 Offset: 0x37B3D1 VA: 0x37B2D0
	public ProfilerMarker.AutoScope Auto() { }

	[ThreadSafeAttribute] // RVA: 0xCC190 Offset: 0xCC291 VA: 0xCC190
	[NativeConditionalAttribute] // RVA: 0xCC190 Offset: 0xCC291 VA: 0xCC190
	// RVA: 0x2AF44E0 Offset: 0x2AF45E1 VA: 0x2AF44E0
	internal static IntPtr Internal_Create(string name, ushort flags) { }

	[NativeConditionalAttribute] // RVA: 0xCC1E0 Offset: 0xCC2E1 VA: 0xCC1E0
	[ThreadSafeAttribute] // RVA: 0xCC1E0 Offset: 0xCC2E1 VA: 0xCC1E0
	// RVA: 0x2AF4580 Offset: 0x2AF4681 VA: 0x2AF4580
	internal static void Internal_Begin(IntPtr markerPtr) { }

	[NativeConditionalAttribute] // RVA: 0xCC230 Offset: 0xCC331 VA: 0xCC230
	[ThreadSafeAttribute] // RVA: 0xCC230 Offset: 0xCC331 VA: 0xCC230
	// RVA: 0x2AF45D0 Offset: 0x2AF46D1 VA: 0x2AF45D0
	internal static void Internal_End(IntPtr markerPtr) { }
}

