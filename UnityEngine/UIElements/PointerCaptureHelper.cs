[ExtensionAttribute] // RVA: 0x11DF20 Offset: 0x11E021 VA: 0x11DF20
public static class PointerCaptureHelper // TypeDefIndex: 4126
{
	// Methods

	// RVA: 0x15C5B60 Offset: 0x15C5C61 VA: 0x15C5B60
	private static PointerDispatchState GetStateFor(IEventHandler handler) { }

	[ExtensionAttribute] // RVA: 0x11F8B0 Offset: 0x11F9B1 VA: 0x11F8B0
	// RVA: 0x15C1C70 Offset: 0x15C1D71 VA: 0x15C1C70
	public static bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x11F8C0 Offset: 0x11F9C1 VA: 0x11F8C0
	// RVA: 0x15C1DC0 Offset: 0x15C1EC1 VA: 0x15C1DC0
	public static void CapturePointer(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x11F8D0 Offset: 0x11F9D1 VA: 0x11F8D0
	// RVA: 0x15C2010 Offset: 0x15C2111 VA: 0x15C2010
	public static void ReleasePointer(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x11F8E0 Offset: 0x11F9E1 VA: 0x11F8E0
	// RVA: 0x15C28E0 Offset: 0x15C29E1 VA: 0x15C28E0
	public static IEventHandler GetCapturingElement(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x11F8F0 Offset: 0x11F9F1 VA: 0x11F8F0
	// RVA: 0x15C5460 Offset: 0x15C5561 VA: 0x15C5460
	public static void ReleasePointer(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x11F900 Offset: 0x11FA01 VA: 0x11F900
	// RVA: 0x15C5F50 Offset: 0x15C6051 VA: 0x15C5F50
	internal static void ActivateCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x11F910 Offset: 0x11FA11 VA: 0x11F910
	// RVA: 0x15C60A0 Offset: 0x15C61A1 VA: 0x15C60A0
	internal static void PreventCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x11F920 Offset: 0x11FA21 VA: 0x11F920
	// RVA: 0x15C5580 Offset: 0x15C5681 VA: 0x15C5580
	internal static bool ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt) { }

	[ExtensionAttribute] // RVA: 0x11F930 Offset: 0x11FA31 VA: 0x11F930
	// RVA: 0x15C1E00 Offset: 0x15C1F01 VA: 0x15C1E00
	internal static void ProcessPointerCapture(IPanel panel, int pointerId) { }
}

