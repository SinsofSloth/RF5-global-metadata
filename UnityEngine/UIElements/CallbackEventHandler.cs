public abstract class CallbackEventHandler : IEventHandler // TypeDefIndex: 4173
{
	// Fields
	private EventCallbackRegistry m_CallbackRegistry; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SendEvent(EventBase e) { }

	// RVA: 0x15B7D40 Offset: 0x15B7E41 VA: 0x15B7D40
	internal void HandleEventAtTargetPhase(EventBase evt) { }

	// RVA: 0x15B7DA0 Offset: 0x15B7EA1 VA: 0x15B7DA0 Slot: 7
	public virtual void HandleEvent(EventBase evt) { }

	// RVA: 0x15B8190 Offset: 0x15B8291 VA: 0x15B8190 Slot: 8
	public bool HasTrickleDownHandlers() { }

	// RVA: 0x15B81E0 Offset: 0x15B82E1 VA: 0x15B81E0 Slot: 9
	public bool HasBubbleUpHandlers() { }

	// RVA: 0x15B8230 Offset: 0x15B8331 VA: 0x15B8230 Slot: 10
	protected virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x15B8240 Offset: 0x15B8341 VA: 0x15B8240 Slot: 11
	protected virtual void ExecuteDefaultAction(EventBase evt) { }
}

