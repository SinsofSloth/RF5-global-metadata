internal class EventCallbackRegistry // TypeDefIndex: 4171
{
	// Fields
	private static readonly EventCallbackListPool s_ListPool; // 0x0
	private EventCallbackList m_Callbacks; // 0x10
	private EventCallbackList m_TemporaryCallbacks; // 0x18
	private int m_IsInvoking; // 0x20

	// Methods

	// RVA: 0x15BC710 Offset: 0x15BC811 VA: 0x15BC710
	private static EventCallbackList GetCallbackList(EventCallbackList initializer) { }

	// RVA: 0x15BC790 Offset: 0x15BC891 VA: 0x15BC790
	private static void ReleaseCallbackList(EventCallbackList toRelease) { }

	// RVA: 0x15B7E70 Offset: 0x15B7F71 VA: 0x15B7E70
	public void InvokeCallbacks(EventBase evt) { }

	// RVA: 0x15B81C0 Offset: 0x15B82C1 VA: 0x15B81C0
	public bool HasTrickleDownHandlers() { }

	// RVA: 0x15B8210 Offset: 0x15B8311 VA: 0x15B8210
	public bool HasBubbleHandlers() { }

	// RVA: 0x15BC810 Offset: 0x15BC911 VA: 0x15BC810
	private static void .cctor() { }
}

