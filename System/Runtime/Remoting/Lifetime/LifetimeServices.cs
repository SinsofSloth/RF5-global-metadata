[ComVisibleAttribute] // RVA: 0xB0CA0 Offset: 0xB0DA1 VA: 0xB0CA0
public sealed class LifetimeServices // TypeDefIndex: 1143
{
	// Fields
	private static TimeSpan _leaseManagerPollTime; // 0x0
	private static TimeSpan _leaseTime; // 0x8
	private static TimeSpan _renewOnCallTime; // 0x10
	private static TimeSpan _sponsorshipTimeout; // 0x18
	private static LeaseManager _leaseManager; // 0x20

	// Properties
	public static TimeSpan LeaseManagerPollTime { get; set; }
	public static TimeSpan LeaseTime { get; set; }
	public static TimeSpan RenewOnCallTime { get; set; }
	public static TimeSpan SponsorshipTimeout { get; set; }

	// Methods

	// RVA: 0x174C090 Offset: 0x174C191 VA: 0x174C090
	private static void .cctor() { }

	// RVA: 0x174C1F0 Offset: 0x174C2F1 VA: 0x174C1F0
	public static TimeSpan get_LeaseManagerPollTime() { }

	// RVA: 0x1745780 Offset: 0x1745881 VA: 0x1745780
	public static void set_LeaseManagerPollTime(TimeSpan value) { }

	// RVA: 0x174C260 Offset: 0x174C361 VA: 0x174C260
	public static TimeSpan get_LeaseTime() { }

	// RVA: 0x174C2D0 Offset: 0x174C3D1 VA: 0x174C2D0
	public static void set_LeaseTime(TimeSpan value) { }

	// RVA: 0x174C340 Offset: 0x174C441 VA: 0x174C340
	public static TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x174C3B0 Offset: 0x174C4B1 VA: 0x174C3B0
	public static void set_RenewOnCallTime(TimeSpan value) { }

	// RVA: 0x174C420 Offset: 0x174C521 VA: 0x174C420
	public static TimeSpan get_SponsorshipTimeout() { }

	// RVA: 0x174C490 Offset: 0x174C591 VA: 0x174C490
	public static void set_SponsorshipTimeout(TimeSpan value) { }

	// RVA: 0x174C500 Offset: 0x174C601 VA: 0x174C500
	internal static void TrackLifetime(ServerIdentity identity) { }
}

