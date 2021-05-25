public sealed class WorldAnchor.OnTrackingChangedDelegate : MulticastDelegate // TypeDefIndex: 4269
{
	// Methods

	// RVA: 0x1BE3620 Offset: 0x1BE3721 VA: 0x1BE3620
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BE31A0 Offset: 0x1BE32A1 VA: 0x1BE31A0 Slot: 13
	public virtual void Invoke(WorldAnchor worldAnchor, bool located) { }

	// RVA: 0x1BE3640 Offset: 0x1BE3741 VA: 0x1BE3640 Slot: 14
	public virtual IAsyncResult BeginInvoke(WorldAnchor worldAnchor, bool located, AsyncCallback callback, object object) { }

	// RVA: 0x1BE36E0 Offset: 0x1BE37E1 VA: 0x1BE36E0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

