public sealed class InteractionSystem.InteractionEventDelegate : MulticastDelegate // TypeDefIndex: 9518
{
	// Methods

	// RVA: 0x2917DF0 Offset: 0x2917EF1 VA: 0x2917DF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2917E10 Offset: 0x2917F11 VA: 0x2917E10 Slot: 13
	public virtual void Invoke(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent) { }

	// RVA: 0x2918100 Offset: 0x2918201 VA: 0x2918100 Slot: 14
	public virtual IAsyncResult BeginInvoke(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent, AsyncCallback callback, object object) { }

	// RVA: 0x29181A0 Offset: 0x29182A1 VA: 0x29181A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

