internal class EventCallbackListPool // TypeDefIndex: 4169
{
	// Fields
	private readonly Stack<EventCallbackList> m_Stack; // 0x10

	// Methods

	// RVA: 0x15BC460 Offset: 0x15BC561 VA: 0x15BC460
	public EventCallbackList Get(EventCallbackList initializer) { }

	// RVA: 0x15BC5E0 Offset: 0x15BC6E1 VA: 0x15BC5E0
	public void Release(EventCallbackList element) { }

	// RVA: 0x15BC690 Offset: 0x15BC791 VA: 0x15BC690
	public void .ctor() { }
}

