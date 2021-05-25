public sealed class Behavior.BehaviorHandler : MulticastDelegate // TypeDefIndex: 4649
{
	// Methods

	// RVA: 0x1764D60 Offset: 0x1764E61 VA: 0x1764D60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1763B20 Offset: 0x1763C21 VA: 0x1763B20 Slot: 13
	public virtual void Invoke(Behavior behavior) { }

	// RVA: 0x1764D80 Offset: 0x1764E81 VA: 0x1764D80 Slot: 14
	public virtual IAsyncResult BeginInvoke(Behavior behavior, AsyncCallback callback, object object) { }

	// RVA: 0x1764DB0 Offset: 0x1764EB1 VA: 0x1764DB0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

