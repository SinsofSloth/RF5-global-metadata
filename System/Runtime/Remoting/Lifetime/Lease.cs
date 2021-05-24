internal class Lease : MarshalByRefObject, ILease // TypeDefIndex: 1138
{
	// Fields
	private DateTime _leaseExpireTime; // 0x18
	private LeaseState _currentState; // 0x20
	private TimeSpan _initialLeaseTime; // 0x28
	private TimeSpan _renewOnCallTime; // 0x30
	private TimeSpan _sponsorshipTimeout; // 0x38
	private ArrayList _sponsors; // 0x40
	private Queue _renewingSponsors; // 0x48
	private Lease.RenewalDelegate _renewalDelegate; // 0x50

	// Properties
	public TimeSpan CurrentLeaseTime { get; }
	public LeaseState CurrentState { get; }
	public TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: 0x174A540 Offset: 0x174A641 VA: 0x174A540
	public void .ctor() { }

	// RVA: 0x174A720 Offset: 0x174A821 VA: 0x174A720 Slot: 6
	public TimeSpan get_CurrentLeaseTime() { }

	// RVA: 0x174A7A0 Offset: 0x174A8A1 VA: 0x174A7A0 Slot: 7
	public LeaseState get_CurrentState() { }

	// RVA: 0x174A7B0 Offset: 0x174A8B1 VA: 0x174A7B0
	public void Activate() { }

	// RVA: 0x174A7C0 Offset: 0x174A8C1 VA: 0x174A7C0 Slot: 8
	public TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x174A7D0 Offset: 0x174A8D1 VA: 0x174A7D0 Slot: 9
	public TimeSpan Renew(TimeSpan renewalTime) { }

	// RVA: 0x174A8E0 Offset: 0x174A9E1 VA: 0x174A8E0 Slot: 10
	public void Unregister(ISponsor obj) { }

	// RVA: 0x174AA20 Offset: 0x174AB21 VA: 0x174AA20
	internal void UpdateState() { }

	// RVA: 0x174ABF0 Offset: 0x174ACF1 VA: 0x174ABF0
	private void CheckNextSponsor() { }

	// RVA: 0x174AEB0 Offset: 0x174AFB1 VA: 0x174AEB0
	private void ProcessSponsorResponse(object state, bool timedOut) { }
}

