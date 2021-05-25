public sealed class InteractionSystem.InteractionDelegate : MulticastDelegate // TypeDefIndex: 9517
{
	// Methods

	// RVA: 0x2916190 Offset: 0x2916291 VA: 0x2916190
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2917A70 Offset: 0x2917B71 VA: 0x2917A70 Slot: 13
	public virtual void Invoke(FullBodyBipedEffector effectorType, InteractionObject interactionObject) { }

	// RVA: 0x2917D40 Offset: 0x2917E41 VA: 0x2917D40 Slot: 14
	public virtual IAsyncResult BeginInvoke(FullBodyBipedEffector effectorType, InteractionObject interactionObject, AsyncCallback callback, object object) { }

	// RVA: 0x2917DE0 Offset: 0x2917EE1 VA: 0x2917DE0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

