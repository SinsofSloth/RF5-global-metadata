[ComVisibleAttribute] // RVA: 0xB0C40 Offset: 0xB0D41 VA: 0xB0C40
public interface ILease // TypeDefIndex: 1136
{
	// Properties
	public abstract TimeSpan CurrentLeaseTime { get; }
	public abstract LeaseState CurrentState { get; }
	public abstract TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TimeSpan get_CurrentLeaseTime() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract LeaseState get_CurrentState() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TimeSpan get_RenewOnCallTime() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract TimeSpan Renew(TimeSpan renewalTime) { }
}

