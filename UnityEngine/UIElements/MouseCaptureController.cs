[ExtensionAttribute] // RVA: 0x11DF00 Offset: 0x11E001 VA: 0x11DF00
public static class MouseCaptureController // TypeDefIndex: 4117
{
	// Fields
	private static bool m_IsMouseCapturedWarningEmitted; // 0x0
	private static bool m_ReleaseMouseWarningEmitted; // 0x1

	// Methods

	[ExtensionAttribute] // RVA: 0x11F7B0 Offset: 0x11F8B1 VA: 0x11F7B0
	// RVA: 0x15C0E80 Offset: 0x15C0F81 VA: 0x15C0E80
	public static bool HasMouseCapture(IEventHandler handler) { }

	[ExtensionAttribute] // RVA: 0x11F7C0 Offset: 0x11F8C1 VA: 0x11F7C0
	// RVA: 0x15C1CD0 Offset: 0x15C1DD1 VA: 0x15C1CD0
	public static void CaptureMouse(IEventHandler handler) { }

	[ExtensionAttribute] // RVA: 0x11F7D0 Offset: 0x11F8D1 VA: 0x11F7D0
	// RVA: 0x15C1EF0 Offset: 0x15C1FF1 VA: 0x15C1EF0
	public static void ReleaseMouse(IEventHandler handler) { }

	// RVA: 0x15C2080 Offset: 0x15C2181 VA: 0x15C2080
	private static void .cctor() { }
}

