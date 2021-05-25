private sealed class Lease.RenewalDelegate : MulticastDelegate // TypeDefIndex: 1139
{
	// Methods

	// RVA: 0x174AE60 Offset: 0x174AF61 VA: 0x174AE60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x174B120 Offset: 0x174B221 VA: 0x174B120 Slot: 13
	public virtual TimeSpan Invoke(ILease lease) { }

	// RVA: 0x174AE80 Offset: 0x174AF81 VA: 0x174AE80 Slot: 14
	public virtual IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, object object) { }

	// RVA: 0x174B0F0 Offset: 0x174B1F1 VA: 0x174B0F0 Slot: 15
	public virtual TimeSpan EndInvoke(IAsyncResult result) { }
}

