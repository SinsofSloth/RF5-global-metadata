public struct FriendPresence // TypeDefIndex: 11674
{
	// Methods

	// RVA: 0x363390 Offset: 0x363491 VA: 0x363390
	public string GetDescription() { }

	// RVA: 0x3633A0 Offset: 0x3634A1 VA: 0x3633A0
	public ApplicationInfo GetLastPlayedApplication() { }

	// RVA: 0x3633D0 Offset: 0x3634D1 VA: 0x3633D0
	public long GetLastUpdatePosixTime() { }

	// RVA: 0x363400 Offset: 0x363501 VA: 0x363400
	public PresenceStatus GetStatus() { }

	// RVA: 0x363430 Offset: 0x363531 VA: 0x363430
	public bool IsSamePresenceGroupApplication() { }

	// RVA: 0x26AAE70 Offset: 0x26AAF71 VA: 0x26AAE70
	private static extern void GetDescription(FriendPresence pFriendPresence, [In] [Out] StringBuilder description, long size) { }

	// RVA: 0x26AAF20 Offset: 0x26AB021 VA: 0x26AAF20
	private static extern ApplicationInfo GetLastPlayedApplication(FriendPresence pFriendPresence) { }

	// RVA: 0x26AAF80 Offset: 0x26AB081 VA: 0x26AAF80
	private static extern long GetLastUpdatePosixTime(FriendPresence pFriendPresence) { }

	// RVA: 0x26AAFE0 Offset: 0x26AB0E1 VA: 0x26AAFE0
	private static extern PresenceStatus GetStatus(FriendPresence pFriendPresence) { }

	// RVA: 0x26AB050 Offset: 0x26AB151 VA: 0x26AB050
	private static extern bool IsSamePresenceGroupApplication(FriendPresence pFriendPresence) { }
}

