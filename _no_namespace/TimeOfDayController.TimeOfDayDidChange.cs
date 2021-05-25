public sealed class TimeOfDayController.TimeOfDayDidChange : MulticastDelegate // TypeDefIndex: 9678
{
	// Methods

	// RVA: 0x2299470 Offset: 0x2299571 VA: 0x2299470
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2299010 Offset: 0x2299111 VA: 0x2299010 Slot: 13
	public virtual void Invoke(TimeOfDayController tc, float timeOfDay) { }

	// RVA: 0x2299490 Offset: 0x2299591 VA: 0x2299490 Slot: 14
	public virtual IAsyncResult BeginInvoke(TimeOfDayController tc, float timeOfDay, AsyncCallback callback, object object) { }

	// RVA: 0x2299530 Offset: 0x2299631 VA: 0x2299530 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

