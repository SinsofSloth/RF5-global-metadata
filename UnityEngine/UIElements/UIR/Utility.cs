[NativeHeaderAttribute] // RVA: 0x11E0E0 Offset: 0x11E1E1 VA: 0x11E0E0
internal class Utility // TypeDefIndex: 4242
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x11F5E0 Offset: 0x11F6E1 VA: 0x11F5E0
	[DebuggerBrowsableAttribute] // RVA: 0x11F5E0 Offset: 0x11F6E1 VA: 0x11F5E0
	private static Action<bool> GraphicsResourcesRecreate; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x11F620 Offset: 0x11F721 VA: 0x11F620
	[DebuggerBrowsableAttribute] // RVA: 0x11F620 Offset: 0x11F721 VA: 0x11F620
	private static Action EngineUpdate; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x11F660 Offset: 0x11F761 VA: 0x11F660
	[DebuggerBrowsableAttribute] // RVA: 0x11F660 Offset: 0x11F761 VA: 0x11F660
	private static Action FlushPendingResources; // 0x10
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x1200A0 Offset: 0x1201A1 VA: 0x1200A0
	// RVA: 0x15CDE90 Offset: 0x15CDF91 VA: 0x15CDE90
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x1200B0 Offset: 0x1201B1 VA: 0x1200B0
	// RVA: 0x15CDF30 Offset: 0x15CE031 VA: 0x15CDF30
	internal static void RaiseEngineUpdate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x1200C0 Offset: 0x1201C1 VA: 0x1200C0
	// RVA: 0x15CDFF0 Offset: 0x15CE0F1 VA: 0x15CDFF0
	internal static void RaiseFlushPendingResources() { }

	// RVA: 0x15CE080 Offset: 0x15CE181 VA: 0x15CE080
	private static void .cctor() { }
}

